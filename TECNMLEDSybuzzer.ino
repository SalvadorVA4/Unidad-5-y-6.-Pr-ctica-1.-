#include <LedControl.h>

LedControl M(14, 15, 16, 1);

int led1 = 17;
int led2 = 18;
int led3 = 19;

int buzzer = 8;

// ===== NOTAS =====
#define NOTE_B4  494
#define NOTE_C5  523
#define NOTE_D5  587
#define NOTE_E5  659
#define NOTE_F5  698
#define NOTE_G5  784

int melodia[] = {
  NOTE_E5, NOTE_E5, NOTE_E5,
  NOTE_E5, NOTE_E5, NOTE_E5,
  NOTE_E5, NOTE_G5, NOTE_C5, NOTE_D5, NOTE_E5
};

int duraciones[] = {
  250, 250, 500,
  250, 250, 500,
  250, 250, 250, 250, 750
};

unsigned long notaInicio = 0;
int notaIndex = 0;
bool notaActiva = false;

// ===== LETRAS =====
byte T_[8] = { B01111110,B00011000,B00011000,B00011000,B00011000,B00011000,B00000000,B00000000 };
byte E_[8] = { B01111110,B01100000,B01111100,B01100000,B01100000,B01111110,B00000000,B00000000 };
byte C_[8] = { B00111100,B01100010,B01100000,B01100000,B01100000,B01100010,B00111100,B00000000 };
byte N_[8] = { B01100110,B01110110,B01111110,B01101110,B01100110,B01100110,B00000000,B00000000 };
byte M_[8] = { B01100011,B01110111,B01111111,B01101011,B01100011,B01100011,B00000000,B00000000 };

byte *palabra[] = { T_, E_, C_, N_, M_ };
int letraIndex = 0;
unsigned long letraInicio = 0;

// ===== LED RUN + STROBE =====
int ledState = 0;
unsigned long ledTimer = 0;

void ledsShow() {
  if (millis() - ledTimer >= 120) {
    ledTimer = millis();

    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);

    if (ledState == 0) digitalWrite(led1, HIGH);
    if (ledState == 1) digitalWrite(led2, HIGH);
    if (ledState == 2) digitalWrite(led3, HIGH);

    ledState++;
    if (ledState > 2) ledState = 0;
  }
}

// ===== MOSTRAR LETRA =====
void mostrarLetra(byte L[]) {
  for (int i = 0; i < 8; i++) {
    M.setRow(0, i, L[i]);
  }
}

void setup() {
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  pinMode(buzzer, OUTPUT);

  M.shutdown(0, false);
  M.setIntensity(0, 8);
  M.clearDisplay(0);

  mostrarLetra(palabra[0]);
  letraInicio = millis();

  notaInicio = millis();
  notaActiva = true;
}

void loop() {
  // ========== ACTUALIZAR LETRAS ==========
  if (millis() - letraInicio >= 600) {
    letraInicio = millis();
    letraIndex++;
    if (letraIndex > 4) letraIndex = 0;
    mostrarLetra(palabra[letraIndex]);
  }

  // ========== LED EFECTO ==========
  ledsShow();

  // ========== MELODIA ==========
  if (notaActiva) {
    tone(buzzer, melodia[notaIndex]);
    notaActiva = false;
    notaInicio = millis();
  }

  if (millis() - notaInicio >= duraciones[notaIndex]) {
    noTone(buzzer);
    notaIndex++;
    if (notaIndex >= sizeof(melodia) / sizeof(int)) notaIndex = 0;
    notaActiva = true;
  }
}
