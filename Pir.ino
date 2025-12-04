#include <Keypad.h>

// ------------ PINES ------------
#define pirPin 6
#define buzzerPin 8

// ---------- KEYPAD ----------
const byte FILAS = 4;
const byte COLUMNAS = 4;

char teclas[FILAS][COLUMNAS] = {
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}
};

byte pinesFilas[FILAS] = {2, 3, 4, 5};
byte pinesColumnas[COLUMNAS] = {10, 11, 12, 13};

Keypad keypad = Keypad(makeKeymap(teclas), pinesFilas, pinesColumnas, FILAS, COLUMNAS);

// -------- VARIABLES --------
bool alarmaActiva = false;
String codigoIngresado = "";
String codigoCorrecto = "1111";

void setup() {
  Serial.begin(9600);

  pinMode(pirPin, INPUT);
  pinMode(buzzerPin, OUTPUT);

  noTone(buzzerPin);

  Serial.println("Sistema listo.");
  Serial.println("Esperando movimiento...");
}

void loop() {

  // ----- DETECCIÓN PIR -----
  int estadoPIR = digitalRead(pirPin);

  if (estadoPIR == HIGH && !alarmaActiva) {
    alarmaActiva = true;
    tone(buzzerPin, 1000);
    Serial.println("⚠️ Movimiento detectado — ALARMA ACTIVADA");
  }

  // ----- LECTURA KEYPAD -----
  char tecla = keypad.getKey();
  if (tecla) {

    Serial.print("Tecla: ");
    Serial.println(tecla);

    if (tecla == '#') { // confirmar
      if (codigoIngresado == codigoCorrecto) {

        Serial.println("Código correcto — Alarma APAGADA por 30 segundos");
        noTone(buzzerPin);
        alarmaActiva = false;

        delay(30000);  // ← 30 segundos

        Serial.println("Sistema reiniciado. Esperando movimiento...");
        codigoIngresado = "";
      } 
      else {
        Serial.println("Código incorrecto");
        codigoIngresado = "";
      }
    }
    else {
      codigoIngresado += tecla;
    }
  }
}
