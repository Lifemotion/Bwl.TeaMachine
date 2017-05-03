#include "board/board.h"
#define DEV_NAME "TeaMachine 1.0"

void set_heater(byte val)
{
	if (val){RELAY_FAN_ON;} else {RELAY_FAN_OFF;}
}

byte pump_main=0;
byte pump_cleaner=0;

void sserial_process_request(unsigned char portindex)
{
	if (sserial_request.command==21)
	{
		set_heater(sserial_request.data[0]);
		sserial_response.result=128+sserial_request.command;
		sserial_response.datalength=1;
		sserial_send_response();
	}
	if (sserial_request.command==22)
	{
		pump_main=sserial_request.data[0];
		pump_cleaner=sserial_request.data[1];
		sserial_response.result=128+sserial_request.command;
		sserial_response.datalength=1;
		sserial_send_response();
	}	
	if (sserial_request.command==23)
	{
		byte dir=0;
		for (int i=0; i<sserial_request.datalength; i++)
		{
			int pause=sserial_request.data[i];
			if (pause==255)
			{
				 set_motordrive(0,127,127);
			}else
			{
				if (dir==0)
			{
				 set_motordrive(1,240,127);
				 var_delay_ms(pause*10);
				 set_motordrive(1,127,127);
				 var_delay_ms(300);
				 dir=1;
			}else
			{
				 set_motordrive(1,10,127);
				 var_delay_ms(pause*10);
				 set_motordrive(1,127,127);
				 var_delay_ms(300);
				 dir=0;				
			}			
			}
		}
	}
	if (sserial_request.command==24)
	{
		byte index=sserial_request.data[0];
		byte pause=sserial_request.data[1];
		if (index==1)
		{
			 set_motordrive(0,127,240);
			 var_delay_ms(pause*50);
				 set_motordrive(0,127,127);
		}
	}	
	
}

void sserial_init()
{
	uart_init_withdivider(UART_485,UBRR_VALUE);
	sserial_find_bootloader();
	sserial_set_devname(DEV_NAME);
	sserial_append_devname(16,12,__DATE__);
	sserial_append_devname(27,8,__TIME__);
}

ISR(USART0_RX_vect)
{
	sserial_poll_uart(0);
}

void board_init()
{
	RELAY_MAIN_ON;
	//var_delay_ms(500);
}

int main(void)
{
	sei();
	wdt_enable(WDTO_8S);
	board_init();
	sserial_init();
	setbit(UCSR0B,RXCIE0,1);
	//timer0_setup();
	//timer0_setvalue(10);
	byte counter=0;
	while(1)
	{
		if (counter==0)
		{
			if (pump_main>0){RELAY_COMPUTER_ON;}
			if (pump_cleaner>0){RELAY_HEAT_ON;}
			}
			if (counter==pump_main){RELAY_COMPUTER_OFF;}
			if (counter==pump_cleaner){RELAY_HEAT_OFF;}
		counter++;
		wdt_reset();
	}
}
