using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relacionais : MonoBehaviour {


	/*
	
	
	
	
	 */

	int numero1 = 10;
	int numero2 = 20;
	// Use this for initialization
	void Start () {
		
		//Operadores Lógicos.
		print(numero1 == numero2 && numero1 > numero2); //false (and)
		print(numero1 != numero2 && numero2 != numero1); //true (and)
		print(numero1 > numero2 || numero2 > numero1); //true (or)
		print(numero1 < numero2 || numero2 < numero1); //true (or)
		print(numero1 >= numero2); //false
		print(!(numero1 <= numero2)); //!(not)true == false
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
