using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	//executa somente depois de tudo que estiver relacionado a Update() for executado
	//assim, temos a certeza de que a câmera depois de tudo já ter se movido
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
