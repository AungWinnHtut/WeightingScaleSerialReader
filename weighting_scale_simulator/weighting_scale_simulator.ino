
//Programmer Dr. Aung Win Htut
//This program is making emulator for 
//testing purpose of XK3190-A9+ weithting scale
//Date: 21-11-2017 Tuesday 1521
#define Start 2
#define End 3

void setup() {
  Serial.begin(9600);    
}

void loop() { 
  Serial.write(2);
  Serial.print("+023960015");
  Serial.write(3);
  delay(100);
}
