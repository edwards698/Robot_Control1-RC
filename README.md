# Robot Control 1
EO-RC is a Desktop RC remote that controls a great number of AVR Microcontrollers. This Desktop Application is compatible with Arduino Uno,Arduino Mega,Arduino Leonardo,Arduino Due,Arduino Robot,Arduino Nano and ATmega32

#                                                              EO_RC Diagram
![Screenshot (137)](https://user-images.githubusercontent.com/72227750/193684569-91009c61-b7a6-4eec-a12b-6bbc42e22785.png)


# EO_RC Serial Communicate
The EO_RC has a feature that can be a great help in dubugging sketches or controlling AVR Microcontroller from your Computer. The EO_RC is Desktop that communicates by receiving and sending Serial Data.
Serial Data is sent over a single wire (but usually travels over USB in our case) and consists of a series of 1's and 0's sent over the wire. Data can be sent in both directions (In our case on two wires).

In Aduino C/C++ to To set it up, in your void setup you have to select a baud rate which is basically the rate at which the data will be transferred and that has to match the rate set in the serial monitor window. E.g

![Screenshot (139)](https://user-images.githubusercontent.com/72227750/193691312-62e0324e-1350-489f-83d2-afb9b4f1bb39.png)

And in your void loop you can read values and they will display on the EO_RC or you can send values to the arduino. E.g

![Screenshot (143)](https://user-images.githubusercontent.com/72227750/193693958-fad500d4-6d36-432f-a81d-8c4db93e7859.png)


There are 15 buttons on the EO_RC that are A,a,B,b and C,D,E,F and I,J,K,L and G,H,I and M. All buttons have been equipped with RC filters, thanks to which the readings are stable and there is no need to program the inputs in order to avoid the so-called. 
To use the buttons, the pin should be Charecter as a value input using the if(val=='A'){} function, in which as the charecter we put a Letter  to be used in inpute mode and show on the board as output. Each button as a letter.

#Diagram 

![Screenshot (145)](https://user-images.githubusercontent.com/72227750/193697946-e9f1bc78-5fed-487e-936e-4ebd2d6e3637.png)

# We Build and Inspire

