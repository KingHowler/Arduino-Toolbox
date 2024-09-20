#include <Wire.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_ADXL345_U.h>

Adafruit_ADXL345_Unified accel = Adafruit_ADXL345_Unified(12345);

void setup() {
  Serial.begin(9600);

  // Initialize the sensor
  if (!accel.begin()) {
    Serial.println("No ADXL345 detected, check wiring!");
    while (1);
  }

  // Set range to +/- 4g (you can adjust based on your needs)
  accel.setRange(ADXL345_RANGE_4_G);
}

void loop() {
  sensors_event_t event;
  accel.getEvent(&event);

  // Get X, Y, Z acceleration values
  float ax = event.acceleration.x;
  float ay = event.acceleration.y;
  float az = event.acceleration.z;

  // Calculate roll and pitch (in degrees)
  int roll = int(atan2(ay, az) * 57.2958);  // Convert radian to degrees
  int pitch = int(atan2(-ax, sqrt(ay * ay + az * az)) * 57.2958);

  // Display roll and pitch in the format {roll}/{pitch}
  Serial.print(roll);
  Serial.print("/");
  Serial.println(pitch);

  // Delay for readability
  delay(50);
}
