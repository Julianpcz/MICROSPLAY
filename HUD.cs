using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI Puntos;
	public GameObject[] vidas;
    
	void Update () {
		Puntos.text = GameManager.Instance.PuntosTotales.ToString();
	}

	public void ActualizarPuntos(int puntosTotales)
	{
		Puntos.text = puntosTotales.ToString();
	} 

	public void DesactivarVida(int indice) {
		vidas[indice].SetActive(false);
	}

	public void ActivarVida(int indice) {
		vidas[indice].SetActive(true);
	}
}