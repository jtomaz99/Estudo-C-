using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadorTernario : MonoBehaviour {
	int moedas_heroi = 10;
	int valor_vida = 100;
	string result;
	// Use this for initialization
	void Start () {
		/*if(moedas_heroi >= valor_vida){
			moedas_heroi -= valor_vida;
			print("você recebeu mais uma vida meu chapa.");
		}
		
		else{
			print("você não tem fundos suficientes!!! vá matar mais goblins.");
		} 
		*/

		//(condição)?True:False;
		result = (moedas_heroi >= valor_vida)?"você recebeu mais uma vida meu chapa.":"você não tem fundos suficientes!!! vá matar mais goblins.";
		print(result);
	}
		
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
