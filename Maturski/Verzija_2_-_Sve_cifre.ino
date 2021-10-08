/*************************************************** 
  Ovo je kod za mehanicki sat napravljen servo motorima.
  Radjeno 2020 godine. 4T2 Elmin Sofitc
 ****************************************************/
 
#include <Adafruit_PWMServoDriver.h>
#include "RTClib.h"

RTC_DS1307 rtc;

Adafruit_PWMServoDriver pwm0 = Adafruit_PWMServoDriver(0x40);
Adafruit_PWMServoDriver pwm1 = Adafruit_PWMServoDriver(0x41);
Adafruit_PWMServoDriver pwm2 = Adafruit_PWMServoDriver(0x42);
Adafruit_PWMServoDriver pwm3 = Adafruit_PWMServoDriver(0x43);

#define SERVOMIN  150 // This is the 'minimum' pulse length count (out of 4096)
#define SERVOMAX  600 // This is the 'maximum' pulse length count (out of 4096)
#define USMIN  600 // This is the rounded 'minimum' microsecond length based on the minimum pulse of 150
#define USMAX  2400 // This is the rounded 'maximum' microsecond length based on the maximum pulse of 600
#define SERVO_FREQ 50 // Analog servos run at ~50 Hz updates

#define HD 3 //Sati Desetice
#define HJ 2 //Sati Jedinice
#define MD 1 //Minute Desetice
#define MJ 0 //Minute Jedinice

//Uglovi motora za ukljucen i iskljucen segment
#define ON 0
#define OFF 90

//Definisani segmenti u kao slova zbog lakseg rada
#define A 0
#define B 1
#define C 2
#define D 3
#define E 4
#define F 5
#define G 6

void setup() {
  Serial.begin(9600);
  Serial.println("Setup start...");

  if (! rtc.begin()) {
    Serial.println("Couldn't find RTC");
    while (1);
  }

  if (! rtc.isrunning()) {
    Serial.println("RTC is NOT running!");
  }
  
  pwm0.begin();
  pwm0.setOscillatorFrequency(27000000);
  pwm0.setPWMFreq(SERVO_FREQ);  // Analog servos run at ~50 Hz updates
  delay(10);
  
  pwm1.begin();
  pwm1.setOscillatorFrequency(27000000);
  pwm1.setPWMFreq(SERVO_FREQ);  // Analog servos run at ~50 Hz updates
  delay(10);
  
  pwm2.begin();
  pwm2.setOscillatorFrequency(27000000);
  pwm2.setPWMFreq(SERVO_FREQ);  // Analog servos run at ~50 Hz updates
  delay(10);
  
  pwm3.begin();
  pwm3.setOscillatorFrequency(27000000);
  pwm3.setPWMFreq(SERVO_FREQ);  // Analog servos run at ~50 Hz updates
  delay(10);
  
  Serial.println("Setup done!");
}

void setServoDegree(uint8_t seg, uint8_t n, uint8_t degree) {
   int pulsedeg = map(degree, 0, 180, SERVOMIN, SERVOMAX);
        if(seg == 0)
        {
          pwm0.setPWM(n, 0, pulsedeg );
        }
        else if(seg == 1)
        {
          pwm1.setPWM(n, 0, pulsedeg ); 
        }      
        else if(seg == 2)
        {
          pwm2.setPWM(n, 0, pulsedeg ); 
        }
         else if(seg == 3)
        {
          pwm3.setPWM(n, 0, pulsedeg ); 
        }
}

void displayNumber(uint8_t segm, uint8_t num){
  //display on X segment Y number
  switch(num){
    case 0:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, ON);
      setServoDegree(segm, E, ON);
      setServoDegree(segm, F, ON);
      setServoDegree(segm, G, OFF);
      break;
      
    case 1:
      setServoDegree(segm, A, OFF);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, OFF);
      setServoDegree(segm, E, OFF);
      setServoDegree(segm, F, OFF);
      setServoDegree(segm, G, OFF);
      break;

    case 2:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, OFF);
      setServoDegree(segm, D, ON);
      setServoDegree(segm, E, ON);
      setServoDegree(segm, F, OFF);
      setServoDegree(segm, G, ON);
      break;
    
      
    case 3:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, ON);
      setServoDegree(segm, E, OFF);
      setServoDegree(segm, F, OFF);
      setServoDegree(segm, G, ON);
      break;

    case 4:
      setServoDegree(segm, A, OFF);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, OFF);
      setServoDegree(segm, E, OFF);
      setServoDegree(segm, F, ON);
      setServoDegree(segm, G, ON);
      break;

    case 5:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, OFF);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, ON);
      setServoDegree(segm, E, OFF);
      setServoDegree(segm, F, ON);
      setServoDegree(segm, G, ON);
      break;

    case 6:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, OFF);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, ON);
      setServoDegree(segm, E, ON);
      setServoDegree(segm, F, ON);
      setServoDegree(segm, G, ON);
      break;

    case 7:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, OFF);
      setServoDegree(segm, E, OFF);
      setServoDegree(segm, F, OFF);
      setServoDegree(segm, G, OFF);
      break;

    case 8:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, ON);
      setServoDegree(segm, E, ON);
      setServoDegree(segm, F, ON);
      setServoDegree(segm, G, ON);
      break;

    case 9:
      setServoDegree(segm, A, ON);
      setServoDegree(segm, B, ON);
      setServoDegree(segm, C, ON);
      setServoDegree(segm, D, ON);
      setServoDegree(segm, E, OFF);
      setServoDegree(segm, F, ON);
      setServoDegree(segm, G, ON);
      break;
  }
  
}


int satDesetice, satJedinice, minDesetice, minJedinice;

void loop() {
  DateTime now = rtc.now();

  satDesetice = now.hour() / 10;
  satJedinice = now.hour() % 10;
  minDesetice = now.minute() / 10;
  minJedinice = now.minute() % 10;

  //debugSerialTime(now);

  displayNumber(MJ, minJedinice);
  delay(100);
  displayNumber(MD, minDesetice);
  delay(100);
  displayNumber(HJ, satJedinice);
  delay(100);
  displayNumber(HD, satDesetice);
  delay(100);

}

//DEBUG FUNCTION
/*
char daysOfTheWeek[7][12] = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
void debugSerialTime(DateTime now){
  Serial.print(now.year(), DEC);
  Serial.print('/');
  Serial.print(now.month(), DEC);
  Serial.print('/');
  Serial.print(now.day(), DEC);
  Serial.print(" (");
  Serial.print(daysOfTheWeek[now.dayOfTheWeek()]);
  Serial.print(") ");
  Serial.print(now.hour(), DEC);
  Serial.print(':');
  Serial.print(now.minute(), DEC);
  Serial.print(':');
  Serial.print(now.second(), DEC);
  Serial.println();

  Serial.print(satDesetice, DEC);
  Serial.print(satJedinice, DEC);
  Serial.print(minDesetice, DEC);
  Serial.print(minJedinice, DEC);
  Serial.println();

  delay(4600);
  
}
*/
