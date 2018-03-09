import threading
import random


#MESSAGE FORMAT b'(0.0, 1.1, -9.3)'

xValues, yValues, zValues = [],[],[]

def FakePosition():
  threading.Timer(1.0, FakePosition).start()
  x = random.uniform(-.9,.9)
  y = random.uniform(-.9,.9)
  z = random.uniform(-.9,.9)
  message = "b'(" + str(x) + "," + str(y) + "," + str(z) + ")'"
  ParseMessage(message)

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
	print("here")

FakePosition()





