# include <stdio.h>
//-------------------------------------------------
struct nut {
	int gtri;
	nut *tiep;
};
typedef nut Node;
//--------------------------------------------------
Node *dau;
//--------------------------------------------------
void khoitao(Node *&dau)
{ dau = NULL;
}
//---------------------------------------------------
void nhapds(Node *&dau)
{ int tam;
  Node *p,*q;
  q=NULL;
  do {
  	printf("\n Nhap vao 1 so nguyen, 0:dung :");
  	scanf("%d",&tam);
  	if (tam!=0)
  	 { // Tao nut moi
  	     p= new Node;
  	     p->gtri=tam;
  	     p->tiep=NULL;
  	   // Moc vao danh sach
		 if (dau==NULL)
		   dau=p;
		 else
		    q->tiep=p;
		    q=p;
			 }	
	   }
  while(tam!=0);
}
//---------------------------------------------------
//--- Duyet danh sách - Vong lap
void duyetlap(Node *dau)
{ Node *p =dau;
   printf("\n");
   while (p!=NULL)
    { printf("%3d",p->gtri);
      p=p->tiep;
	}
}
//---------------------------------------------------
//--- Duyet de qui
void duyetdq(Node *dau)
{ if (dau!=NULL)
   { printf("%3d",dau->gtri);
     duyetdq(dau->tiep);
   }
}
//---------------------------------------------------
int tongnutlap(Node *dau)
{ int S=0;
  Node *p;
     p=dau;
  while (p!=NULL)
    { S=S+p->gtri;
      p=p->tiep;
		  }	  
   return S;		  
}
//---------------------------------------------------
int tongnutdq(Node *dau)
{ if (dau==NULL)
     return 0;
   else return dau->gtri +tongnutdq(dau->tiep);  
}
//---------------------------------------------------
int Tle(Node *dau)
{ if (dau==NULL) return 0;
   else
   if (dau->gtri % 2 !=0)
     return (dau->gtri+Tle(dau->tiep));
     else
     return (Tle(dau->tiep));
}
//---------------------------------------------------
// Bo sung 1 nut mang gia tri X vao dau ds
void chendau(Node *&dau,int X)
{ Node *p;
   p=new Node;
   p->gtri=X;
   p->tiep=dau;
   dau=p;
}
//---------------------------------------------------
void chencuoi(Node *&dau, int X)
{ Node *p,*q;
   p=new Node;
   p->gtri=X;
   p->tiep=NULL;
   // Tim nut cuoi cung
    q=dau;
    if (q==NULL)
     dau=p;
    else
	while (q->tiep!=NULL)
	  q=q->tiep;
	q->tiep=p;   
}
//---------------------------------------------------
void chensau(Node *&dau,int X, int Y)
{ Node *q; // chua d/c cua nut mang gtri Y
  Node *p; // chua d/c cua nut mang gtri X
  // Tim nut mang gia tri Y
    q=dau;
      while ((q!=NULL)&&(q->gtri!=Y))
       q=q->tiep;
   if (q!=NULL) // co nut mang gtri Y
    { // Tao nut chua gia tri X
       p = new Node;
       p->gtri = X;
       // Moc vao sau nut Y
       p->tiep=q->tiep;
       q->tiep=p;
	}
   }
//---------------------------------------------------
void chentruoc(Node *&dau,int X, int Y)
{ Node *p,*q,*t;
    // t: tro den nut Y; q: tro den nut truoc Y
    // p: dia chi nut X
    q=NULL;
    t=dau;
    // Tim nut mang gia tri
      while((t!=NULL)&&(t->gtri!=Y))
       { q=t;
         t=t->tiep;}
	  if (t!=NULL) // co nut mang gia tri Y
	    if (t==dau)
	      chendau(dau,X);
	    else
		 { // Tao nut moi chua X
		     p=new Node;
		     p->gtri=X;
		   // Moc nut
		     q->tiep=p;
			 p->tiep=t;  
		   }  
    }
//---------------------------------------------------
void xoadau(Node *&dau)
{ Node *p;
    if (dau!=NULL)
    { p=dau;
      dau=dau->tiep;
      delete p;
	}
}
//---------------------------------------------------
void xoacuoi(Node *&dau)
{ Node *p,*q;
  if (dau!=NULL)
  { // Tim nut cuoi cung
     q=NULL;
     p=dau;
       while ((p!=NULL)&&(p->tiep!=NULL))
        {q=p;
         p=p->tiep;		
        }
        if (p!=NULL) // p tro den nut cuoi
         { if (p==dau)
           xoadau(dau);
           else
           {q->tiep=NULL;
            delete p;
		   }
		 }
}
}
//---------------------------------------------------
int main()
{ khoitao(dau);
  nhapds(dau);
  duyetlap(dau);
  //xoadau(dau);
  xoacuoi(dau);
  duyetlap(dau);
  /*chensau(dau,88,5);
   duyetlap(dau);
   printf("\n Chen truoc \n"); 
   chentruoc(dau,11,6);
   duyetlap(dau);*/
  /*chendau(dau,77);
  duyetlap(dau);
  chencuoi(dau,99);
  duyetlap(dau);
  printf("\n Duyet de qui \n");
  duyetdq(dau);
  printf("\n Tong cac nut (lap) %3d \n",tongnutlap(dau));
  printf("\n Tong cac nut (de qui) %3d \n",tongnutdq(dau));
  printf("\n Tong cac nut le (de qui) %3d \n",Tle(dau));*/
  
  return 0;
}
