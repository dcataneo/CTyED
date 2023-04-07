using tp1;

ArbolBinario<int> raiz = new ArbolBinario<int>(10);
ArbolBinario<int> arbolizquierdo = new ArbolBinario<int>(20);
ArbolBinario<int> arbolderecho = new ArbolBinario<int>(30);

var hijoizquieroAI = new ArbolBinario<int>(40);
var hijoderechoAI = new ArbolBinario<int>(60);
arbolizquierdo.agregarHijoIzquierdo(hijoizquieroAI);
arbolizquierdo.agregarHijoDerecho(hijoderechoAI);


var hijoizquierdoAD = new ArbolBinario<int>(50);
var hijoderechoAD = new ArbolBinario<int>(70);
arbolderecho.agregarHijoIzquierdo(hijoizquierdoAD);
arbolderecho.agregarHijoDerecho(hijoderechoAD);

hijoizquieroAI.agregarHijoDerecho(new ArbolBinario<int>(80));
hijoderechoAD.agregarHijoIzquierdo(new ArbolBinario<int>(90));

raiz.agregarHijoIzquierdo(arbolizquierdo);
raiz.agregarHijoDerecho(arbolderecho);


raiz.preorden();

