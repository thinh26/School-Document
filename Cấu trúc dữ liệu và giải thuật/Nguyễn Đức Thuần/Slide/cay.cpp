#include <stdio.h>
//--------------------------------
struct nut {
	int info;
	nut *left,*right;
};

typedef nut Node;
//-----------------------------------
Node *goc;

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
/* 
1. Tinh chieu cao cua cay
2. Dem xem co bao nhieu nut co cay con trai cao hon cay con phai
3. Dem xem co bao nhieu nut mang gia tri chan
4. Tinh tong so nut la
5. Tinh tong cac nut nhanh

*/
int main()
{khoitao(goc);
 taocay(goc);
 printf("\n Duyet cay LNR \n");
 LNR(goc);
 printf("\n Tong cac nut %d \n",tongnut(goc));
 printf("\n So nut cua cay %d \n",demnut(goc));
 printf("\n So nut la cua cay %d \n",sonutla(goc));
 /*printf("\n Duyet cay NLR \n");
 NLR(goc);*/
 return 0;
}
