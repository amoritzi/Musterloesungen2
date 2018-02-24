create table Persons
(
	ID		int		identity(1,1)	not null,
	Name	varchar(40)				null,
	Vorname	varchar(40)				null,
	Strasse varchar(50)				null,
	PLZ		int						null,
	Ort		varchar(50)				null,
	Telefon	varchar(20)				null
	);