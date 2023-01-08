#include <stdio.h>
//--------------------------------
struct nut {
	int info;
	nut *left,*right;
};

typedef nut Node;
//-----------------------------------
Node *goc,*goc1;

void khoitao(Node *&goc)
{ goc=NULL;
}
//------------------------------------
void mocnut(Node *&goc, int X)  // moc 1 nut gtri X vao cay
{ if (goc==NULL)
    { goc=new Node;
      goc->info=X;
      goc->left=NULL;
      goc->right=NULL;
	}
  else 
    if (goc->info>= X)
	 	mocnut(goc->left,X);
	else
	    mocnut(goc->right,X); 	
}
//--------------------------------------
void taocay(Node *&goc)
{ int tam;
   do{
   	printf("\n Nhap 1 so nguyen,0:dung ");
   	scanf("%d",&tam);
   	 if (tam!=0)
   	   mocnut(goc,tam);
   }   
   while (tam!=0);
}
//---------------------------------------
void LNR(Node *goc)
{  if (goc!=NULL)
      { LNR(goc->left);
        printf("%3d",goc->info);
        LNR(goc->right);
      }
}
//----------------------------------------
void NLR(Node *goc)
{ if (goc!=NULL)
    {printf("%3d",goc->info);
     NLR(goc->left);
	 NLR(goc->right); 
	}
}
//----------------------------------------
// Tinh tong cac nut thuoc cay
int tongnut(Node *goc)
{ if (goc==NULL)
    return 0;
  else
     return goc->info+tongnut(goc->left)+tongnut(goc->right);  
}
//----------------------------------------
// Dem so nut thuoc cay 
int demnut(Node *goc)
{ if (goc==NULL) return 0;
   else
   return 1+demnut(goc->left)+demnut(goc->right);
}
//----------------------------------------
// Dem so nut la cua cay
int sonutla(Node *goc)
{ if (goc==NULL) return 0;
  else
     if (goc->left==NULL && goc->right==NULL)
      return 1;
     else
	  return sonutla(goc->left)+sonutla(goc->right); 
}
//-----------------------------------------
// Chieu cao cua cay
int max(int a,int b)
{ if (a>b) return a;
  else
    return b;
}
int chieucao(Node *goc)
{ if (goc==NULL) return 0;
   else
    if (goc->left==NULL && goc->right==NULL)
       return 1;
    else
	   return 1 +max(chieucao(goc->left),chieucao(goc->right));   
}
//----------------------------------------- 
int demthp(Node *goc)
{ if (goc==NULL) return 0;
   else
    if (chieucao(goc->left)>chieucao(goc->right))
       return 1+ demthp(goc->left)+demthp(goc->right);
    else
	   return demthp(goc->left)+demthp(goc->right);
}
//-----------------------------------------
int demchan(Node *goc)
{ if (goc==NULL) return 0;
  else
    if (goc->info %2 ==0)
     return 1+demchan(goc->left)+demchan(goc->right);
     else
     return demchan(goc->left)+demchan(goc->right);
}
//-----------------------------------------
// Tong nut la
int tongla(Node *goc)
{ if (goc==NULL) return 0;
  else
    if (goc->left==NULL && goc->right==NULL)
      return goc->info;
    else
	  return tongla(goc->left)+tongla(goc->right);
}
//-----------------------------------------
int tongnhanh(Node *goc)
{ return tongnut(goc)- tongla(goc);
}
//-----------------------------------------
void inmuc(Node *goc,int i, int muc)
{ if (goc!=NULL)
    
	if (muc==i) printf("%3d",goc->info);
     else
       {inmuc(goc->left,i,muc+1);
        inmuc(goc->right,i,muc+1);}
}
//-----------------------------------------
void chepcay(Node *goc,Node *&goc1)
{ if (goc==NULL) goc1=NULL;
   else
   {goc1=new Node;
    goc1->info=goc->info;
    chepcay(goc->left,goc1->left);
    chepcay(goc->right,goc1->right);
   }
}
//----------------------------------------
void cayhoandoi(Node *&goc)
{ Node *tam;
if (goc!=NULL)
   { tam=goc->left;
     goc->left=goc->right;
     goc->right=tam;
     cayhoandoi(goc->left);
     cayhoandoi(goc->right);
   }
}
//----------------------------------------
int main()
{khoitao(goc);
 khoitao(goc1);
 taocay(goc);
 printf("\n Duyet cay LNR \n");
 LNR(goc);
 chepcay(goc,goc1);
 cayhoandoi(goc1);
 printf("\n Duyet cay LNR \n");
 LNR(goc1);
 /*inmuc(goc,3,1);
 printf("\n So nut mang gia tri chan: %d \n",demchan(goc));
 printf("\n Tong cac nut la: %d \n",tongla(goc));
 printf("\n Tong cac nut nhanh: %d \n",tongnhanh(goc));
 printf("\n Chieu cao cay: %d \n",chieucao(goc));
 printf("\n So nut cay trai cao hon cay phai: %d \n",demthp(goc));
 printf("\n Tong cac nut %d \n",tongnut(goc));
 printf("\n So nut cua cay %d \n",demnut(goc));
 printf("\n So nut la cua cay %d \n",sonutla(goc));
 printf("\n Duyet cay NLR \n");
 NLR(goc);*/
 return 0;
}
