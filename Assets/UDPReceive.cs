using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPReceive : MonoBehaviour {

	private const int PORT = 1991;
	public UIBehavior UI;

	private string lastPacketText;
	private bool gotNewPacket = false;
	private Thread receiveThread;
	private UdpClient client;

	private static void Main() {
		UDPReceive receiveObj=new UDPReceive();
		receiveObj.init();
	}
	// start from unity3d
	public void Start() {
		init();
	}

	void Update(){
		//listen for changes on message thread
		if (gotNewPacket) {
			gotNewPacket = false;
			GotNewMessage ();
		}
	}

	private void init(){
		receiveThread = new Thread(new ThreadStart(ReceiveData));
		receiveThread.IsBackground = true;
		receiveThread.Start();

	}

	// receive thread
	private  void ReceiveData() {
		client = new UdpClient(PORT);
		while (true && client != null) {
			try {
				IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
				byte[] data = client.Receive(ref anyIP);
				string text = Encoding.UTF8.GetString(data);
				lastPacketText = text;
				gotNewPacket = true;
			} catch (Exception err){
				print(err);
			}
		}
	}

	void GotNewMessage(){
		UI.GotMessage (lastPacketText);
	}

	void OnDisable() { 
		if (receiveThread != null) {
			receiveThread.Abort ();
		}
		client.Close(); 
	}
}
