
int x = 1000 ;

void setup() {
  // start serial port at 9600 bps:

  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
   pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {

String temp = Serial.readString();
x = temp.toInt();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(x);   
 digitalWrite(LED_BUILTIN, LOW); 
 delay(x);    
  }


