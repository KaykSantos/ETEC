bool botao1 = true;
bool botao2 = true;
bool botao3 = true;

const int pinobotao1 = 13;
const int pinobotao2 = 12;
const int pinobotao3 = 11;

void setup()
{
  //LED RGB
  pinMode(4, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(2, OUTPUT);
  
  pinMode(pinobotao1, INPUT);
  pinMode(pinobotao2, INPUT);
  pinMode(pinobotao3, INPUT);
}


void loop()
{
  botao1 = digitalRead(pinobotao1);
  botao2 = digitalRead(pinobotao2);
  botao3 = digitalRead(pinobotao3);
  
  if(botao1){
    digitalWrite(4, HIGH);
    digitalWrite(3, HIGH);
    digitalWrite(2, HIGH);
    delay(200);
  }else{
    digitalWrite(4, LOW);
    digitalWrite(3, LOW);
    digitalWrite(2, LOW);
  }
  
  if(botao2){
    digitalWrite(4, HIGH);
    digitalWrite(3, LOW);
    digitalWrite(2, HIGH);
  }else{
    digitalWrite(4, LOW);
    digitalWrite(3, LOW);
    digitalWrite(2, LOW);
  }
  
  if(botao3){
    digitalWrite(4, HIGH);
    digitalWrite(3, HIGH);
    digitalWrite(2, LOW);
  }else{
    digitalWrite(4, LOW);
    digitalWrite(3, LOW);
    digitalWrite(2, LOW);
  }
}