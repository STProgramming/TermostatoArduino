# TermostatoArduino
Applicazione di gestione di sensori Arduino
dht11eled_handshake è la cartella che contiene il codice che deve andare su arduino.
Arduino deve avere montato su breadboard il sensore DHT11 e un led.
Il sensore DHT11 è responsabile quindi di dare in output i dati su temperatura o umidità e/o indice di calore o C° o F°.
Il led invece funzionerà come led di stato. 
Lo script è molto fico perchè nel momento in cui l'applicazione e arduino si connettono avverrà uno scambio di dati ambe lati per fortificare la sicurezza della trasmissione dati e 
diminuire/azzerare la dispersione dei dati.
In pratica arduino darà in output al computer se prima non si sono autentificati.
Arduino, quindi, bombarderà il buffer sempre con il messaggio finche l'applicazione non capterà che sia arduino e a sua volta invierà un messaggio ad arduino dicendogli di che è possibile comunicare.
