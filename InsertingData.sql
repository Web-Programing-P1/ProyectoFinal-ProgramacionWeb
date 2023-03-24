USE DEALER

INSERT INTO marca(nombre_marca,url_logo_marca)
Values ('Porsche', 'https://1000marcas.net/wp-content/uploads/2019/12/Porsche-logo.png')

INSERT INTO modelo(id_marca,nombre_modelo,potencia,cilindrada,combustible,pasajeros,traccion,precio_base,img_modelo)
values(1,'718 Cayman GTS 4.0', '400 HP', '6 cil', 'Gasolina', '2 plazas','RWD', 114300,'https://files.porsche.com/filestore/image/multimedia/none/982-718-c7-gts-4-modelimage-sideshot/model/5c334596-a8d0-11eb-80d5-005056bbdc38/porsche-model.png'),
	  (1,'911 Carrera 4', '385 HP', '6 cil', 'Gasolina', '4 plazas','AWD', 164900,'https://files.porsche.com/filestore/image/multimedia/none/992-c4-modelimage-sideshot/model/205499c1-d980-11eb-80d9-005056bbdc38/porsche-model.png'),
	  (1,'Cayanne', '340 HP', '6 cil', 'Gasolina', '5 plazas','AWD', 100300,'https://d2j2k5ljcmlttk.cloudfront.net/models/cayenne/cabecera/cayenne_turbo_gt.webp'),
	  (1,'Taycan', '326-380 HP', '0', 'Electrico', '5 plazas','RWD', 155800,'https://files.porsche.com/filestore/image/multimedia/none/j1-taycan-tu-s-modelimage-sideshot/model/60c967a4-ac79-11e9-80c4-005056bbdc38/porsche-model.png'),
	  (1,'Taycan 4 Cross Turismo', '380-476 HP', '0', 'Electrico', '5 plazas','AWD', 157600,'https://files.porsche.com/filestore/image/multimedia/none/j1-taycan-4-cross-turismo-modelimage-sideshot/model/585661af-75d5-11eb-80d3-005056bbdc38/porsche-model.png'),
	  (1,'Taycan 4S', '435-530 HP', '0', 'Electrico', '5 plazas','RWD', 167800,'https://files.porsche.com/filestore/image/multimedia/none/j1-taycan-4s-modelimage-sideshot/model/e2a54809-dac1-11e9-80c6-005056bbdc38/porsche-model.png'),
	  (1,'Panamera', '330 HP', '6 cil', 'Gasolina', '5 plazas','RWD', 142900,'https://files.porsche.com/filestore/image/multimedia/none/971-g2-2nd-v6-modelimage-sideshot/model/dc348883-d31f-11ea-80cc-005056bbdc38/porsche-model.png'),
	  (1,'Macan', '265 HP', '4 cil', 'Gasolina', '5 plazas','AWD', 70900,'https://files.porsche.com/filestore/image/multimedia/none/pa3-r4-modelimage-sideshot/model/373fd3ae-de41-11eb-80d9-005056bbdc38/porsche-model.png')

Insert into equipamiento_serie(id_modelo,nombre_equipamiento_extra)
values(1, 'Bloque de aluminio y culatas'),
	  (1, 'Refrigerado por agua con gestión térmica'),
	  (1, 'Cuatro válvulas por cilindro'),
	  (1, 'Single turbocharger con geometría de turbina variable (VTG), un intercooler'),
	  (1, 'VarioCam Plus, válvulas con temporizador variable y elevación'),
	  (1, 'Lubricación de sumidero en seco integrado'),
	  (1, 'Inyección directa de combustible (DFI)'),
	  (1, 'Convertidor catalítico de tres vías y diagnóstico a bordo para monitorear el sistema de control de emisiones.'),
	  (1, 'Convertidor catalítico '),
	  (2, 'Bloque de motor y cilindros de aluminio'),
	  (2, 'Refrigerado por agua con administrador térmico'),
	  (2, 'Cuatro válvulas por cilindro'),
	  (2, '2 turbocargadores, 2 intercoolers'),
	  (2, 'Regulación variable de las válvulas VarioCam Plus'),
	  (2, 'Lubricación por cárter seco con control de bombeo de aceite'),
	  (2, 'Direct Fuel Injection (DFI)'),
	  (2, 'Dos convertidores catalíticos de 3 vías y diagnóstico a bordo para el monitoreo de control de emisiones'),
	  (3, 'Inyección directa de combustible (DFI) con posición central del inyector'),
	  (3, 'Twin-scroll turbocharger'),
	  (3, 'Enfriado por agua con gestión térmica'),
	  (3, 'VarioCam Plus'),
	  (4, 'Performance Battery Plus 150 KW'),
	  (4, 'Modo SPORT para la activación de ajustes dinámicos de rendimiento incl. Launch Control'),
	  (4, 'Modo RANGE para la activación de ajustes orientados a la eficiencia'),
	  (5, 'Performance Battery Plus 150 KW'),
	  (5, 'Modo SPORT para la activación de ajustes dinámicos de rendimiento incl. Launch Control'),
	  (5, 'Modo RANGE para la activación de ajustes orientados a la eficiencia'),
	  (6, 'Performance Battery Plus 150 KW'),
	  (6, 'Modo SPORT para la activación de ajustes dinámicos de rendimiento incl. Launch Control'),
	  (6, 'Modo RANGE para la activación de ajustes orientados a la eficiencia'),
	  (7, 'Inyección directa de combustible (DFI) con posición central del inyector'),
	  (7, 'Enfriado por agua con gestión térmica'),
	  (7, 'VarioCam Plus'),
	  (8, 'Botón SPORT'),
	  (8, 'Gestion Termica'),
	  (8, 'TurboCargador'),
	  (8, 'Filtro de partículas de gasolinar')
	   
	  
Insert into metodo_pago(metodo_pago) 
values('Al contado'),
	  ('Transferencia Bancaria'), 
	  ('Tarjeta Credito/Debito'),
	  ('Financiacion')


Insert into color_exterior(color_exterior,precio_color_exterior)
values ('Negro', '1.500'),
	   ('Blanco', '1.300'),
	   ('Rojo', '1.750')

Insert into color_interior(color_interior,precio_color_interior)
Values('Blanco','1.200'),
	  ('plata','1.400'),
	  ('Negro','1.600'),
	  ('Gris','1.750')



		


Select * from marca
select * from modelo
SELECT * FROM equipamiento_serie
SELECT * FROM metodo_pago
