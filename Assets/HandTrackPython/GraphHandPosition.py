import os
import numpy as np
import matplotlib.pyplot as plt

def ParseMessage(message):
	#remove leading and trailing characters from string
	message = message[2:-2]
	message = message.split(',')
	x.append(message[0])
	y.append(message[1])

x = []
y = []
#open text file and loop through
file = open(os.path.expanduser("~/Desktop/HandTrackPython/positions.txt"), 'r') 
#parse each line
for line in file: 
	ParseMessage(line)

plt.title('Hand Positions')
plt.xlabel('x')
plt.ylabel('y')
# Plot
plt.scatter(x, y)
plt.show()
