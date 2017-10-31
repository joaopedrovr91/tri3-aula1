using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

	public static GM instance = null;

	public float yMinLive= 10f;
	public Transform SpawnPoint;

	public GameObject playerPrefab;

	PlayerController player;

	public float timeToRespawn = 2f;

	void Awake () {
		if(instance == null){
			instance = this;
		}
		else if( instance != this){
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}

	void Start () {
		if(player == null){
			RespawnPlayer();
		}
	}
	
	void Update () {
		if(player == null){
			GameObject obj = GameObject.FindGameObjectWithTag("Player");
			if( obj != null){
				player = obj.GetComponent<PlayerController>();
			}
		}
	}

	public void RespawnPlayer(){
		Instantiate(playerPrefab,SpawnPoint.position,SpawnPoint.rotation);
	}

	public void KillPlayer(){
		if(player != null){
			Destroy(player.gameObject);
			Invoke("RespawnPlayer", timeToRespawn);
		}
	}
}
