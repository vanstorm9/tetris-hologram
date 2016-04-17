//Turns on and off a light emitting diode(LED) connected to digital pin 13, when pressing a pushbutton attached to pin 2. 
 
/*
 The circuit:
 * LED attached from pin 13 to ground 
 * pushbutton attached to pin 2 from +5V
 * 10K resistor attached to pin 2 from ground
 
 * Note: on most Arduinos there is already an LED on the board
 attached to pin 13.
 
 
 This example code is in the public domain.
 
 http://www.arduino.cc/en/Tutorial/Button
 */

#define LED 6

const int LeftPin = 2;     // the number of the pushbutton pin
const int ledPin =  13;      // the number of the LED pin

const int RightPin = 4;  
const int UpPin = 7;  
const int DownPin = 3;     


// variables will change:
int buttonStateLeft = 0;         // variable for reading the pushbutton status
int buttonStateRight = 0; 
int buttonStateUp = 0; 
int buttonStateDown = 0; 


char byte_val;


void initalizeDigitalRead()
{
    buttonStateLeft = digitalRead(LeftPin);
    buttonStateRight = digitalRead(RightPin);
    buttonStateUp = digitalRead(UpPin);
    buttonStateDown = digitalRead(DownPin);

}

void buttonControl()
{

  
  if (buttonStateLeft == HIGH) {     
    // turn LED on:    
    Serial.print("LEFT was pressed");
    digitalWrite(ledPin, HIGH);  
    digitalWrite(LED, HIGH);
  } 

  if(buttonStateRight == HIGH)
  {
    Serial.print("RIGHT was pressed");
    digitalWrite(ledPin, HIGH);
    digitalWrite(LED, HIGH);   
  } else if(buttonStateUp == HIGH){
    Serial.print("UP was pressed");
     digitalWrite(ledPin, HIGH);  
    digitalWrite(LED, HIGH);
  } else if(buttonStateDown == HIGH){
    Serial.print("DOWN was pressed");
     digitalWrite(ledPin, HIGH);  
    digitalWrite(LED, HIGH);
  }else{
    Serial.print("No imput");
    // turn LED off:
    digitalWrite(ledPin, LOW);
    digitalWrite(LED, LOW); 
  }

  Serial.flush();


  Serial.println();
  delay(30);
  
  
}



void setup()
{
 Serial.begin(9800);

  // initialize the LED pin as an output:
  pinMode(ledPin, OUTPUT);  
      
  // initialize the pushbutton pin as an input:
  pinMode(LeftPin, INPUT);
  pinMode(RightPin, INPUT);  
  pinMode(UpPin, INPUT);  
  pinMode(DownPin, INPUT);  


  pinMode(LED, OUTPUT);    

  
 
}


void loop(){

    initalizeDigitalRead();
    buttonControl();

  
}
