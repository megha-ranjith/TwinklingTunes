void setup() {
  for (int pin = 2; pin <= 13; pin++) {
    pinMode(pin, OUTPUT);
  }
}

void loop() {
  // "Deck the halls with boughs of holly" 
  int pattern1[] = {2, 4, 6, 8};
  colorfulBlink(pattern1, 4, 300, 3);

  // "Fa-la-la-la-la, la-la-la-la" 
  int pattern2[] = {3, 5, 7, 9, 11, 13};
  colorfulBlink(pattern2, 6, 200, 2);

  // "Tis the season to be jolly" 
  int pattern3[] = {2, 5, 8, 11};
  colorfulBlink(pattern3, 4, 300, 3);

  // "Fa-la-la-la-la, la-la-la-la" 
  int pattern4[] = {3, 6, 9, 12};
  colorfulBlink(pattern4, 4, 200, 2);

  // "Don we now our gay apparel" 
  int pattern5[] = {4, 7, 10, 13};
  colorfulBlink(pattern5, 4, 300, 3);

  // "Fa-la-la-la-la, la-la-la-la" 
  int pattern6[] = {2, 3, 4, 5, 6, 7};
  colorfulBlink(pattern6, 6, 200, 2);

  // "Troll the ancient Yuletide carol" 
  int pattern7[] = {8, 9, 10, 11, 12, 13};
  colorfulBlink(pattern7, 6, 300, 3);

  // "Fa-la-la-la-la, la-la-la-la"
  int pattern8[] = {2, 4, 6, 8, 10, 12};
  colorfulBlink(pattern8, 6, 200, 2);

  
  festiveColorfulBlink();
}

void colorfulBlink(int pins[], int size, int duration, int repeat) {
  for (int r = 0; r < repeat; r++) {
    
    for (int i = 0; i < size; i += 2) {
      digitalWrite(pins[i], HIGH);
    }
    delay(duration);

    
    for (int i = 1; i < size; i += 2) {
      digitalWrite(pins[i], HIGH);
    }
    delay(duration);

    for (int i = 0; i < size; i++) {
      digitalWrite(pins[i], LOW);
    }
    delay(duration);
  }
}

void festiveColorfulBlink() {
  
  for (int i = 0; i < 5; i++) {
   
    for (int pin = 2; pin <= 13; pin += 2) {
      digitalWrite(pin, HIGH);
    }
    delay(300);


    for (int pin = 2; pin <= 13; pin += 2) {
      digitalWrite(pin, LOW);
    }
    for (int pin = 3; pin <= 13; pin += 2) {
      digitalWrite(pin, HIGH);
    }
    delay(300);

    for (int pin = 2; pin <= 13; pin++) {
      digitalWrite(pin, LOW);
    }
    delay(300);
  }
}