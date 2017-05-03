#ifndef BOARD_H_
#define BOARD_H_

#define F_CPU 8000000UL
#define UART_485       0

#define BAUD 9600

//Atmel Libraries
#include <util/delay.h>
#include <avr/io.h>
#include <avr/wdt.h>
#include <stdlib.h>
#include <string.h>
#include <avr/interrupt.h>
#include <util/setbaud.h>

//User Libraries
#include "../libs/bwl_uart.h"
#include "../libs/bwl_simplserial.h"
#include "../libs/bwl_simplserial_ext.h"
#include "../libs/bwl_strings.h"
#include "../libs/bwl_tools.h"
#include "HAL_definition.h"

typedef unsigned char byte;
void var_delay_ms(int ms);
void timer0_setup();
void timer0_setvalue(byte value);
void set_motordrive(byte driverid, byte motor1, byte motor2);

#endif
