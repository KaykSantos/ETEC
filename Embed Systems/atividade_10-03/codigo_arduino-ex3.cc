const int pinoAnalogico = A0;
int posicaoled = 9;
int leds[] = {2, 3, 4, 5, 6, 7, 8, 9, 10};

void setup()
{
  for(int thisLed = 2; thisLed < 11; thisLed++){
  pinMode(leds[thisLed], OUTPUT);
  }
  pinMode(pinoAnalogico, INPUT);
}

void loop()
{
  int sensorReading = analogRead(pinoAnalogico);
  int ledLevel = map(sensorReading, 0, 1023, 0, 9);
  for(int thisLed = 2; thisLed < 11; thisLed++){
      if(ledLevel>2){
        digitalWrite(2, HIGH);
        digitalWrite(3, LOW);
        digitalWrite(4, LOW);
        
        digitalWrite(5, LOW);
        digitalWrite(6, LOW);
        digitalWrite(7, LOW);
        
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
        digitalWrite(10, LOW);
      }else{
        digitalWrite(leds[thisLed], LOW);
      }
      if(ledLevel>4){
        digitalWrite(2, HIGH);
        digitalWrite(3, LOW);
        digitalWrite(4, LOW);
        
        digitalWrite(5, HIGH);
        digitalWrite(6, LOW);
        digitalWrite(7, HIGH);
        
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
        digitalWrite(10, LOW);
      }else{
        digitalWrite(leds[thisLed], LOW);
      }
      if(ledLevel>7){
        digitalWrite(2, HIGH);
        digitalWrite(3, LOW);
        digitalWrite(4, LOW);
        
        digitalWrite(5, HIGH);
        digitalWrite(6, LOW);
        digitalWrite(7, HIGH);
        
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
        digitalWrite(10, HIGH);
      }else{
        digitalWrite(leds[thisLed], LOW);
      }
    }
 
}