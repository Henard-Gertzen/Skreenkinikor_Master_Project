USE ScreenKinikor
GO

CREATE TABLE Confectionary_Item_Type
(
	Confectionary_Type_ID	int IDENTITY(1,1)PRIMARY KEY,
	Confectionary_Type_Name	varchar(max),
	Confectionary_Type_Desc	varchar(max)
);

CREATE TABLE Confectionary_Item
(
	Confectionary_ID	int	IDENTITY(1,1)PRIMARY KEY,
	Confectionary_Type_ID	int	FOREIGN KEY REFERENCES Confectionary_Item_Type(Confectionary_Type_ID),
	Confectionary_Name	varchar(max),
	Confectionary_Price	decimal(19,4),
	Confectionary_Stock	int
);

CREATE TABLE Confectionary_Sale
(
	Confectionary_Sale_ID	int	IDENTITY(1,1)PRIMARY KEY,
	Sale_Total	decimal(19,4)
);

CREATE TABLE Sale_Item
(
	Confectionary_ID	int NOT NULL,
	Confectionary_Sale_ID	int NOT NULL,
	Sold_Amount	int,
	CONSTRAINT CP_Sale_Item PRIMARY KEY (Confectionary_ID, Confectionary_Sale_ID),
	FOREIGN KEY (Confectionary_ID) REFERENCES Confectionary_Item(Confectionary_ID),
	FOREIGN KEY (Confectionary_Sale_ID) REFERENCES Confectionary_Sale(Confectionary_Sale_ID)
);


CREATE TABLE Movie_Info
(
	Movie_ID	int	IDENTITY(1,1)PRIMARY KEY,
	Movie_Name	varchar(40),
	Movie_Description	varchar(max),
	Seat_Price	decimal(19,4)
);

CREATE TABLE Ticket_Info
(
	Ticket_ID	int	IDENTITY(1,1)PRIMARY KEY,
	Movie_ID	int	FOREIGN KEY REFERENCES Movie_Info(Movie_ID),
	Ticket_Total	decimal(19,4),
	Seats NVARCHAR(500), 
	Payment_Date date
);


CREATE TABLE Actor_Info
(
	Actor_ID	int	IDENTITY(1,1)PRIMARY KEY,
	First_Name	varchar(20),
	Last_Name	varchar(20),
	Description	varchar(max)
);

CREATE TABLE Actor_On_Movie
(
	Actor_ID	int NOT NULL,
	Movie_ID	int NOT NULL,
	CONSTRAINT CP_Actor_On_Movie PRIMARY KEY (Actor_ID,Movie_ID),
	FOREIGN KEY (Actor_ID) REFERENCES Actor_Info(Actor_ID),
	FOREIGN KEY (Movie_ID) REFERENCES Movie_Info(Movie_ID)
);

CREATE TABLE Schedule
(
	Schedule_ID	int	IDENTITY(1,1)PRIMARY KEY,
	Timeslot	time(7),
	Day_Shown	date
);

CREATE TABLE Movie_On_Schedule
(
	Schedule_ID	int NOT NULL,
	Movie_ID	int NOT NULL,
	CONSTRAINT CP_Movie_On_Schedule PRIMARY KEY (Schedule_ID,Movie_ID),
	FOREIGN KEY (Schedule_ID) REFERENCES Schedule(Schedule_ID),
	FOREIGN KEY (Movie_ID) REFERENCES Movie_Info(Movie_ID)
);