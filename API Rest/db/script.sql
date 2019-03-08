CREATE TABLE Person (
	id serial,
	firstname varchar(50) NOT NULL,
	lastname varchar(50) NOT NULL,
	adress varchar(50) NOT NULL,
	gender varchar(50) NOT NULL,
	CONSTRAINT person_pk PRIMARY KEY (Id)
);
