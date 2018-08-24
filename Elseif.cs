using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elseif : MonoBehaviour {

	int moedas_heroi = 0;
	int valor_vida = 100;
	
	// Use this for initialization
	void Start () {
		if(moedas_heroi >= valor_vida){
			moedas_heroi -= valor_vida;
			print("você recebeu mais uma vida meu chapa.");
		}
		else if(moedas_heroi == 0){
			print("Tentou me enganar? agora morra!!!");
		}
		else{
			print("você não tem fundos suficientes!!! vá matar mais goblins.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
