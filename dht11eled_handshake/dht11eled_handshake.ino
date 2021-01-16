#include <DHT.h>
#define DHTPIN 2
const int PINLED = 4;
const char instrucion;
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  while (!Serial) {
   ;
  }
  dht.begin();
  pinMode(PINLED, OUTPUT);
  establishContact();
}

void loop() {
    //declaration of all variables
    float h = dht.readHumidity();
    float t = dht.readTemperature();
    float f = dht.readTemperature(true);
    float hic = dht.computeHeatIndex(t, h, false);
    float hif = dht.computeHeatIndex(f, h);
    if (Serial.available() > 0) {
      digitalWrite(PINLED, HIGH);
      if (isnan(h) || isnan(t) || isnan(f)) {
        Serial.println(F("Failed to read from DHT sensor!"));
        digitalWrite(PINLED, LOW);
        Serial.end();
      }
        Serial.print(h);
        Serial.print(t);
        Serial.print(f);
        Serial.print(hic);
        Serial.print(hif);
        delay(1000);
      }
}  

void establishContact() {
  while (Serial.available() <= 0) {
    digitalWrite(4, LOW);
    Serial.print(" im_arduino ");
    delay(550);
  }
}
