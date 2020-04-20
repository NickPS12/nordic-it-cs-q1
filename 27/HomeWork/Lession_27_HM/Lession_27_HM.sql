CREATE DATABASE AirportInfo;
GO
USE AirportInfo
GO
-- Создание схемы
CREATE TABLE [AirportInfo].[dbo].[DepartureBoard ]( 
	[FlightNumber] 		[VARCHAR](10) 	NOT NULL, 
	[DepartureCity] 	[VARCHAR](20) 	NULL, 
	[DepartureCountry]	[VARCHAR](30) 	NOT NULL, 
	[ArrivalCity] 		[VARCHAR](20) 	NOT NULL, 
	[ArrivalCountry] 	[VARCHAR](30) 	NOT NULL,
	[DepartureTime]		[SMALLDATETIME] NOT NULL,
	[ArrivalTime] 		[SMALLDATETIME] NOT NULL,
	[FlightTime] 		[FLOAT] 		NOT NULL,
	[Airline] 			[VARCHAR](50) 	NOT NULL,
	[AircraftType] 		[VARCHAR](20) 	NOT NULL
);
GO
-- Вставка данных
INSERT INTO [AirportInfo].[dbo].[DepartureBoard ]( 
	[FlightNumber], 
	[DepartureCity], 
	[DepartureCountry], 
	[ArrivalCity], 
	[ArrivalCountry],
	[DepartureTime],
	[ArrivalTime],
	[FlightTime],
	[Airline],
	[AircraftType])
VALUES ('U3234', 'Moscow', 'Russia', 'Berlin', 'Germany', '2018-09-03 14:35:00', '2018-09-03 15:35:00', 2.5, 'AirBerlin', 'Boeing-737')
GO
INSERT INTO [AirportInfo].[dbo].[DepartureBoard ]( 
	[FlightNumber], 
	[DepartureCity], 
	[DepartureCountry], 
	[ArrivalCity], 
	[ArrivalCountry],
	[DepartureTime],
	[ArrivalTime],
	[FlightTime],
	[Airline],
	[AircraftType])
VALUES ('RV3234', 'Moscow', 'Russia', 'Paris', 'France', '2019-02-15 10:50:00', '2019-02-15 13:35:00', 4, 'AirFrance', 'Airbus-380')
GO 
-- Очистка
SELECT * FROM [dbo].[DepartureBoard]
GO 
DROP TABLE [dbo].[DepartureBoard]
GO
DROP DATABASE AirportInfo
