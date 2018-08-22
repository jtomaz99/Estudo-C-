using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converção : MonoBehaviour {

    int carteira;
    float carteira2 = 10.5f;
    bool teste = true;
    int converção2;
    int carteira3 = 100;
    string texto;

	// Use this for initialization
	void Start () {
        //converção1
        carteira = (int)carteira2;
        print(carteira);
        
        /* consigo converter um valor booleano para int
           pois true == 1 e false == 0
        */
        converção2 = Convert.ToInt32(teste);
        print(converção2);

        texto = carteira3.ToString();
        print(texto + "ola");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
