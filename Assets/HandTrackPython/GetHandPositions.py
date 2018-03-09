import socket
import os

SENDING_IP = "192.168.1.151"
UDP_PORT = 1999
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM) # UDP
sock.bind((SENDING_IP, UDP_PORT))
print ("start listening...")

def WriteToFile(message):
	print(message)
	file.write(message)
	file.write("\n") 
	file.flush()
#open file to write to
#file = open(os.path.expanduser("~/Desktop/HandTrackPython/positions.txt"),'w')
#read socket messages 
while True:
	data, addr = sock.recvfrom(28) # buffer size is 1024 bytes
	message = str(data)
	WriteToFile(message)