using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTouch : MonoBehaviour {

	Ray cameraRay;
	RaycastHit hit;
	public AudioClip albumAudio1;
	public AudioClip albumAudio2;
	public AudioClip albumAudio3;
	public AudioClip albumAudio4;
	public AudioClip albumAudio5;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.touchCount > 0 || Input.GetTouch (0).phase == TouchPhase.Began) {

			cameraRay = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);

			if (Physics.Raycast (cameraRay, out hit, Mathf.Infinity )) {
				if(hit.collider.gameObject.name == "Album1"){
					audioSource.clip = albumAudio1;
					audioSource.Play ();
				}

				if(hit.collider.gameObject.name == "Album2"){
					audioSource.clip = albumAudio2;
					audioSource.Play ();
				}

				if(hit.collider.gameObject.name == "Album3"){
					audioSource.clip = albumAudio3;
					audioSource.Play ();
				}

				if(hit.collider.gameObject.name == "Album4"){
					audioSource.clip = albumAudio4;
					audioSource.Play ();
				}

				if(hit.collider.gameObject.name == "Album5"){
					audioSource.clip = albumAudio5;
					audioSource.Play ();
				}
			
			}
		}
	}
}
