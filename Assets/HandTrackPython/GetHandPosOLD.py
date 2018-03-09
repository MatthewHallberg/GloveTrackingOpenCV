#matthew hallberg
import socket
from mpl_toolkits.mplot3d import Axes3D
import matplotlib.pyplot as plt
import numpy as np
import random
import threading

global xValues
global yValues
global zValues
xValues,yValues,zValues = [],[],[]

def graph():
	plt.ion()
	fig = plt.figure()
	ax = fig.add_subplot(111, projection='3d')
	xTemp, yTemp, zTemp = [],[],[]
	ax.scatter(xTemp,yTemp,zTemp)
	plt.plot(xTemp,yTemp,zTemp)
	plt.draw()
	print("GRAPHING")
	for i in range(10000):
		ax.clear()
		ax.scatter(xValues,yValues,zValues)
		plt.plot(xValues,yValues,zValues)
		print(xValues)
		plt.draw()
		plt.pause(1)

	plt.waitforbuttonpress()

a = threading.Thread(target=graph)
a.start()

SENDING_IP = "192.168.1.151"
UDP_PORT = 1999
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM) # UDP
sock.bind((SENDING_IP, UDP_PORT))
print ("start listening...")

def ParseMessage(message):
	#remove leading and trailing characters from string
	message = message[3:]
	message = message[:-2]
	message = message.split(',')
	GraphCoordinates(message)

def GraphCoordinates(message):
	x = float(message[0])
	y = float(message[1])
	z = float(message[2])
	xValues.append(x)
	yValues.append(y)
	zValues.append(z)
	print("...")

while True:
	data, addr = sock.recvfrom(28) # buffer size is 1024 bytes
	message = str(data)
	ParseMessage(message)
