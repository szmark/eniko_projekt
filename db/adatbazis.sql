-- cegek definition

CREATE TABLE IF NOT EXISTS cegek (
	id INTEGER PRIMARY KEY,
	nev VARCHAR(128) NOT NULL,
	cim VARCHAR(256) NOT NULL,
	bankszamla_szam VARCHAR(256) NOT NULL
);

-- szamlak definition

CREATE TABLE IF NOT EXISTS szamlak (
	id INTEGER PRIMARY KEY,
	tipus INTEGER NOT NULL,
	teljesites_datuma DATE,
	osszeg INTEGER NOT NULL DEFAULT 0,
	letrehozas_datuma DATE DEFAULT (datetime('now','localtime')),
	ceg_id INTEGER NOT NULL,
	megjegyzes VARCHAR(512),
	FOREIGN KEY (ceg_id) 
		REFERENCES cegek (id)
);