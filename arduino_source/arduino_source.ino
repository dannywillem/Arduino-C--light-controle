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
          Serial.println("on");
          break;                    // send command one time
       case 'F':
          digitalWrite(13, LOW);    // set the LED off
          Serial.println("off");
          break;              // send command one time
       case 'T':
          Serial.println("test");
          digitalWrite(13, HIGH);   // set the LED on
          delay(1500);              // wait for a second
          digitalWrite(13, LOW);    // set the LED off
          break;
     }
   }
}
