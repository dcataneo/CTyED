﻿using System;

namespace tp1
{
	public class ArbolBinario<T>
	{
		
		private T dato;
		private ArbolBinario<T>? hijoIzquierdo;
		private ArbolBinario<T>? hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T>? getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T>? getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden() {
			if (hijoIzquierdo != null)
				hijoIzquierdo.inorden();
			Console.Write(dato + " ");
			if (hijoDerecho != null)	
				hijoDerecho.inorden();

		}
		
		public void preorden() {
			Console.Write(dato + " ");
			if (hijoIzquierdo != null)
				hijoIzquierdo.preorden();
			if (hijoDerecho != null)
				hijoDerecho.preorden();
		}
		
		public void postorden() {
			
			if (hijoIzquierdo != null)
				hijoIzquierdo.postorden();
			if (hijoDerecho != null)
				hijoDerecho.postorden();
			Console.Write(dato + " ");
			if (dato.incluye() == true)
				Console.Write("Se encontro igualdad con el dato: " + dato);
		}
		
		public void recorridoPorNiveles() {
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}

		public void incluye() {
		}
	}
}
