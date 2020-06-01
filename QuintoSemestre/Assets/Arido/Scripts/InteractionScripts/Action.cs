using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Action : MonoBehaviour
{

	public PlayableDirector alavanca;
	//public PlayableDirector evento;

	public GameObject Cinematic;

	public void Ativa()
	{
		 if(alavanca != null) alavanca.Play();
		//evento.Play();
		Instantiate(Cinematic);

		//Destroy(this);
		//Destroy(gameObject.GetComponent<Selecionavel>());
	}
}

