#include "board.h"

void var_delay_ms(int ms)
{
	for (int i=0; i<ms; i++)_delay_ms(1.0);
}

void timer0_setup()
{
	TCCR0A=(0<<COM0B0)|(1<<COM0B1)|(0<<WGM01)|(1<<WGM00);
	TCCR0B=(0<<CS02)|(0<<CS01)|(1<<CS00)|(0<<WGM02);
}

void timer0_setvalue(byte value)
{
	OCR0B=value;
}

void sserial_send_start(unsigned char portindex)
{
	if (portindex==UART_485)	{
		DDRB|=(1<<6);
		PORTB|=(1<<6);
	}
}
void sserial_send_end(unsigned char portindex)
{
	if (portindex==UART_485)	{
		DDRB|=(1<<6);
		PORTB&=(~(1<<6));
	}
}



void ir_led_set(char state)
{
	setbit(DDRA,7,1);
	setbit(PORTA,7,state);
}

void ir_modulation_delay()
{
	_delay_us(10.5);
}

#define TEMP_SENSOR_PIN 1
void set_ow_pin(byte mode, byte state)
{
	if (state){PORTC|=1<<TEMP_SENSOR_PIN;	}else{PORTC&=(~(1<<TEMP_SENSOR_PIN));}
	if (mode){DDRC|=1<<TEMP_SENSOR_PIN;	}else{DDRC&=(~(1<<TEMP_SENSOR_PIN));}
}

unsigned char get_ow_pin()
{
	return ((PINC&(1<<TEMP_SENSOR_PIN)));
}

void set_motordrive(byte driverid, byte motor1, byte motor2)
{
	RELAY_MAIN_ON;
	setbit (PORTC,6,0); setbit (DDRC,6,1);
	setbit (PORTC,7,0); setbit (DDRC,7,1);
	
	setbit (PORTD,4,0); setbit (DDRD,4,1);
	setbit (PORTD,5,0); setbit (DDRD,5,1);
	setbit (PORTD,6,0); setbit (DDRD,6,1);
	setbit (PORTD,7,0); setbit (DDRD,7,1);
	
	if (driverid==0) {setbit (PORTC,6,1);}
	if (driverid==1) {setbit (PORTC,7,1);}

	if (motor1>128)	 {setbit (PORTD,4,1)}
	if (motor1<127)	 {setbit (PORTD,5,1)}

	if (motor2>128)	 {setbit (PORTD,6,1)}
	if (motor2<127)	 {setbit (PORTD,7,1)}
}
