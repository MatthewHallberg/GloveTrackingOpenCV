using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour {

	public Text txtMessage;
	public Image redFlash;
	public Transform messageHolder;
	private Vector3 messageInPos = new Vector3 (0, 75, 0);
	private Vector3 messageOutPos = new Vector3 (0, -75, 0);
	private Vector3 desiredPosition;

	void Start () {
		desiredPosition = messageInPos;
	}
	
	void Update () {
		//moves message holder
		messageHolder.localPosition = Vector3.Lerp (messageHolder.localPosition, desiredPosition, Time.deltaTime * 6f);
	}

	public void GotMessage(string message){
		if (message.Contains ("empty")) {
			txtMessage.text = "";
			desiredPosition = messageInPos;
			if (message.Contains ("b")) {
				StopFlash ();
			}
		} else {
			txtMessage.text = message;
			desiredPosition = messageOutPos;
			if (message.Contains ("blocking")) {
				FlashCoroutine = StartCoroutine (RedFlashRoutine ());
			} else {
				StopFlash ();
			}
		}
	}

	void StartFlash(){
		redFlash.GetComponent<Animation> ().Play ();
	}

	void StopFlash(){
		if (FlashCoroutine != null) {
			StopCoroutine (FlashCoroutine);
		}
		redFlash.GetComponent<Animation> ().Stop ();
		Color tempColor = Color.white;
		tempColor.a = 0;
		redFlash.color = tempColor;
	}

	Coroutine FlashCoroutine;
	IEnumerator RedFlashRoutine(){
		yield return new WaitForSeconds (1f);
		StartFlash ();	
	}
}
