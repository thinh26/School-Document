def Dijkstra(W, i):
    # find the number of vertices
    n = W.shape[0]    
    # initialize the shortest distances to infinity
    shortestDistances = numpy.array([numpy.inf] * n)    
    # initialize the previous vertices
    previousVertices = numpy.array([numpy.inf] * n)
    
    # initialize the unvisited vertex set to be full
    unvisited = numpy.array([1] * n)
    
    # mark the source as visited
    unvisited[i - 1] = 0
    
    # initialize distance from the source to the source as 0
    shortestDistances[i - 1] = 0
    
    # loop for iteration per vertex until the unvisited set is empty
    for _ in range(n):
        # find the distances to all unvisited adjacent vertices and
        # set others to 0
        distances = shortestDistances * unvisited
        
        # find the index of the nearest unvisited vertex (where
        # distances > 0)
        x = numpy.argmin(numpy.ma.masked_where(
            distances == 0, distances))
        # mark vertex x as visited
        unvisited[x] = 0
        # iterate through the vertices
        for v in range(n):
            
            oldDistance = shortestDistances[v]
            newDistance = shortestDistances[x] + W[v,x]
            adjacent = W[v,x] > 0
            unvis = unvisited[v]
            
            # if v and x are connected, v has not been visited, and we
            # find a shorter distance to node v...
            if adjacent and unvis and oldDistance > newDistance:
                # save the shortest distance found so far
                shortestDistances[v] = shortestDistances[x] + W[v,x]
                
                # save the previous vertex
                previousVertices[v] = x    

    # print the table similar to the book
    print(numpy.array([numpy.arange(n) + 1, shortestDistances, 
                       previousVertices + 1]).T)    
    # return the outputs
    return shortestDistances, previousVertices
