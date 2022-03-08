bool botao1 = true;
bool botao2 = true;
bool botao3 = true;
bool botao4 = true;
bool botao5 = true;

const int pinobotao1 = 7;
const int pinobotao2 = 6;
const int pinobotao3 = 5;
const int pinobotao4 = 4;
const int pinobotao5 = 3;


void setup()
{
  //LED
  pinMode(13, OUTPUT); // Vermelho
  pinMode(12, OUTPUT); // Azul
  pinMode(11, OUTPUT); // Verde
  
  pinMode(pinobotao1, INPUT);
  pinMode(pinobotao2, INPUT);
  pinMode(pinobotao3, INPUT);
  pinMode(pinobotao4, INPUT);
  pinMode(pinobotao5, INPUT);
}

void loop()
{
  botao1 = digitalRead(pinobotao1);
  botao2 = digitalRead(pinobotao2);
  botao3 = digitalRead(pinobotao3);
  botao4 = digitalRead(pinobotao4);
  botao5 = digitalRead(pinobotao5);
  
  if(botao1){
  	digitalWrite(13, LOW);
    digitalWrite(12, LOW);
    digitalWrite(11, HIGH);
  }else{
  	digitalWrite(13, LOW);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
  }
  
  if(botao2){
  	digitalWrite(13, HIGH);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
  }else{
  	digitalWrite(13, LOW);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
  }
  
  if(botao3){
  	digitalWrite(13, LOW);
    digitalWrite(12, HIGH);
    digitalWrite(11, LOW);
  }else{
  	digitalWrite(13, LOW);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
  }
  
  if(botao4){
  	digitalWrite(13, HIGH);
    digitalWrite(12, LOW);
    digitalWrite(11, HIGH);
  }else{
  	digitalWrite(13, LOW);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
  }
  
  if(botao5){
  	digitalWrite(13, HIGH);
    digitalWrite(12, HIGH);
    digitalWrite(11, LOW);
  }else{
  	digitalWrite(13, LOW);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
  }
}