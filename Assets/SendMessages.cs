using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.Net;
using System.Text;

/// <summary>
/// This sends and recieves UDP packets to and from python
/// </summary>

namespace OpenCVForUnitySample {
	public class SendMessages : MonoBehaviour {

		public MultiObjectTrackingBasedOnColorSample handTracking;

		private const int PORT_NUM = 1996;
		private const float UPDATE_TIME = .5f;
		private string serverIP = "10.0.0.109";
		private IPAddress serverAddr;
		private IPEndPoint endPoint;
		private Socket sock;
		private byte[] send_buffer;

		void Start(){
			if (PlayerPrefs.HasKey("IP")){
				serverIP = PlayerPrefs.GetString("IP");
			}
		}

		void OnDisable(){
			CloseSocket ();
		}

		/// <summary>
		/// This gets called when the IP address is changed in the input field
		/// </summary>
		public void SetIP(string IP){
			serverIP = IP;
			PlayerPrefs.SetString ("IP", serverIP);
			Debug.Log ("New Server IP: " + IP);
			InitSocket ();
		}

		void InitSocket(){
			//close socket in case its already open
			CloseSocket ();
			//init socket
			sock = new Socket (AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			serverAddr = IPAddress.Parse (serverIP);
			endPoint = new IPEndPoint (serverAddr, PORT_NUM);
			SendPositionMessages();
		}

		void CloseSocket(){
			if (sock != null) {
				StopAllCoroutines ();
				sock.Disconnect (true);
			}
		}

		void SendPositionMessages(){
			Debug.Log ("Starting Messages...");
			InitSocket ();
			StartCoroutine (SendPosition ());
		}
			
		IEnumerator SendPosition(){
			while (true) {
				string text = handTracking.GetHandPositions ();
				send_buffer = Encoding.ASCII.GetBytes(text);
				sock.SendTo(send_buffer,endPoint);
				print (text);
				yield return new WaitForSeconds (UPDATE_TIME);
			}
		}
	}
}

