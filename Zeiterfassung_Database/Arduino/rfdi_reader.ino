#include <SPI.h>
#include <MFRC522.h>
 
#define SS_PIN 9
#define RST_PIN 8
 
MFRC522 mfrc522(SS_PIN, RST_PIN);
 
void setup() {
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  Serial.println("RFID-RC522 bereit");
}
 
void loop() {
  if (mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial()) {
    String uid = "";
    for (byte i = 0; i < mfrc522.uid.size; i++) {
      uid += String(mfrc522.uid.uidByte[i], HEX);
    }
    Serial.println("UID: " + uid);
    // Hier können Sie den UID-Wert an Ihren C#-Code senden.
    delay(2000);
  }
}