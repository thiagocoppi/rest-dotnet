CREATE TABLE IF NOT EXISTS books (
	id serial NOT NULL,
	Author varchar(50),
	LaunchDate timestamp NOT NULL,
	Price decimal(65,2) NOT NULL,
	Title varchar(50),
	PRIMARY KEY (id)
);