/*
  Led control by dannywillem
 */

void setup() {                
  pinMode(13, OUTPUT);
  Serial.begin(9600); // allow read commands 
}

void loop() {
  
   if (Serial.available()) 
   {
       int c = Serial.read();
       switch (c)
     {
       case 'N':
          digitalWrite(13, HIGH);   // set the LED on
          break;                    // send command one time
       case 'F':
          digitalWrite(13, LOW);    // set the LED off
          break;              // send command one time
       case 'T':
          digitalWrite(13, HIGH);   // set the LED on
          delay(1500);              // wait for a second
          digitalWrite(13, LOW);    // set the LED off
		  break;
     }
   }
}
