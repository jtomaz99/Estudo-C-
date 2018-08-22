using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementoDecremento : MonoBehaviour {


    int carteira = 100;
    int carteira2 = 200;
    int carteira3 = 999;


	void Start () {
        //O ++ faz um incremento de 1 a mais como se fosse o +=1 do python
        //pós incremento
        print(carteira++);
        print(carteira);

        //pre incremento
        print(++carteira2);

        //decremento é com "--" e segue a regra anterior
        carteira3 = (int)--carteira3;
        print(--carteira3);



    }


    void Update () {
		
	}
}
