using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{

	GameObject descricao;

	void Start()
	{
		descricao = GameObject.Find("interacaoMessage");
		descricao.SetActive(false);
	}

	void Update()
	{
		Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		Selecionavel selecao = null;
		Ativavel ativacao = null;

		if (Physics.Raycast(raio, out hit, 5))
		{
			selecao = hit.transform.GetComponent<Selecionavel>();
			ativacao = hit.transform.GetComponent<Ativavel>();
		}

		if (selecao != null)
		{
			//selecao.Seleciona();
			descricao.SetActive(true);
		}
		else
		{
			descricao.SetActive(false);
		}

		if (ativacao != null)
		{
			if (Input.GetKeyDown(KeyCode.E)) ativacao.Ativa();
		}
	}
}
