import sqlite3

print("Connecting to databse")
conn=sqlite3.connect('szinhaz2.db')
cursor=conn.cursor()
print("DONE")

print("CREATING TABLES:")

print("FELHASZNALOK")
cursor.execute("""CREATE TABLE IF NOT EXISTS "FELHASZNALOK" (
	"username"	TEXT NOT NULL UNIQUE,
	"pwd"	TEXT NOT NULL UNIQUE,
    "type" TEXT NOZ NULL,
	PRIMARY KEY("username")
    )""")

print("HELYEK")
cursor.execute("""CREATE TABLE IF NOT EXISTS "HELYEK" (
	"id"	INTEGER NOT NULL UNIQUE,
	"hely"	INTEGER NOT NULL,
	"sor"	INTEGER NOT NULL,
	"oszlop"	INTEGER NOT NULL,
	"kategoria"	TEXT NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT)
    )""")

print("KATEGORIAK")
cursor.execute("""CREATE TABLE IF NOT EXISTS "KATEGORIAK" (
	"kategoria"	TEXT NOT NULL UNIQUE,
	"ar"	INTEGER NOT NULL,
	PRIMARY KEY("kategoria")
    )""")

print("KEDVEZMENYEK")
cursor.execute("""CREATE TABLE IF NOT EXISTS "KEDVEZMENYEK" (
	"id"	INTEGER NOT NULL UNIQUE,
	"kupon"	TEXT NOT NULL UNIQUE,
	"ertek"	INTEGER NOT NULL,
	PRIMARY KEY("id")
    )""")

print("ELOADASOK")
cursor.execute("""CREATE TABLE IF NOT EXISTS"ELOADASOK" (
	"id"	INTEGER NOT NULL UNIQUE,
	"datum"	TEXT NOT NULL,
	"cim"	TEXT,
	PRIMARY KEY("id")
    )""")

print("VETELEK")
cursor.execute("""CREATE TABLE IF NOT EXISTS "VETELEK" (
	"eloadas_id"	INTEGER NOT NULL,
	"hely_id"	INTEGER NOT NULL,
	"vevo"	INTEGER NOT NULL,
	"kupon_id"	INTEGER,
	FOREIGN KEY("eloadas_id") REFERENCES "ELOADASOK"("id"),
	FOREIGN KEY("kupon_id") REFERENCES "KEDVEZMENYEK",
	FOREIGN KEY("hely_id") REFERENCES "HELYEK"("id"),
	PRIMARY KEY("eloadas_id","hely_id"))""")

print("DONE")

print("POPULATING TABLES:")
print("FELHASZNALOK")
cursor.execute("""INSERT INTO FELHASZNALOK (username,pwd,type) VALUES
    ("jegyvasarlo", "jegyvasarlo1","user"),
    ("rendszergazda","rendszergazda1","admin")"""
)
print(cursor.execute("""SELECT * FROM FELHASZNALOK""").fetchall())

print("HELYEK")
command="INSERT INTO HELYEK VALUES(?,?,?,?,?)"
id=1
#zsöllye 0
for i in range(6):
    for j in range(10):
        if(i==0):
            params=(id,0,i+1,j+1,"VIP")
        else:
            params=(id,0,i+1,j+1,"FOLDSZINT")
        cursor.execute(command,params)
        id+=1
#karzat 1
for i in range(4):
    for j in range(8):
        if(i==0):
            params=(id,1,i+1,j+1,"VIP")
        else:
            params=(id,1,i+1,j+1,"KARZAT")
        cursor.execute(command,params)
        id+=1

print(cursor.execute("""SELECT * FROM HELYEK""").fetchall())

print("KATEGORIAK")
cursor.execute("""INSERT INTO KATEGORIAK (kategoria,ar) VALUES
    ("FOLDSZINT", 4000),
    ("KARZAT",60000),
    ("VIP",12000)"""
)
print(cursor.execute("""SELECT * FROM KATEGORIAK""").fetchall())

print("KEDVEZMENYEK")
cursor.execute("""INSERT INTO KEDVEZMENYEK (id,kupon,ertek) VALUES
    (1,"KEDVEZMENY5", 5),
    (2,"KEDVEZMENY10",10)"""
)
print(cursor.execute("""SELECT * FROM KEDVEZMENYEK""").fetchall())

print("ELOADASOK")
cursor.execute("""INSERT INTO ELOADASOK(id,datum,cim) VALUES
	(1,"2021.2.10","Perelj, Uram!"),
	(2,"2021.4.5","Ember tragédiája 2.0"),
	(3,"2021.8.14","Karton papa")""")

print("DONE")
conn.commit()
print("FINISHED")