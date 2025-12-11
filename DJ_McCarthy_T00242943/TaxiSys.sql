DROP TABLE Bookings;
DROP TABLE MakesModels;
DROP TABLE Drivers;
DROP TABLE Accounts;



CREATE TABLE MakesModels(
Makes Varchar2 (15) NOT NULL,
Models Varchar2 (15) NOT NULL,
CONSTRAINT pk_makeModel PRIMARY KEY (Makes,Models)
);

CREATE TABLE Drivers
(
DriverID NUMERIC (4),
Forename VARCHAR2 (20),
Surname VARCHAR2 (20),
PhoneNumber VARCHAR2 (10),
LicenseNo varchar2 (9),
CarMake VARCHAR2 (20),
CarModel VARCHAR2 (20),
CarRegNo VARCHAR2 (20),
carNoSeats NUMERIC (2),
DriverStatus char (1) default 'A',
CONSTRAINT pk_DriverID PRIMARY KEY (DriverID)
);





INSERT INTO MakesModels (Makes,Models)
VALUES
('Hyundai','i10');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Hyundai','Tucson');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Hyundai','i30');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Toyota','Corrolla');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Toyota','Yaris');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Toyota','Prius');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Renault','Clio');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Renault','Megane');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Ford','Focus');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Ford','Fiesta');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Honda','Civic');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Honda','Accord');
INSERT INTO MakesModels (Makes,Models)
VALUES
('Honda','Type R');

INSERT INTO Drivers 
Values
(1,'DJ','McCarthy','0871234267','124356789','Renault','Megane','12-KY-211',4,'A');

INSERT INTO Drivers 
VALUES (2, 'Emma', 'Smith', '0872345678', '987654321', 'Toyota', 'Yaris', '151-D-345', 5, 'A');

INSERT INTO Drivers 
VALUES (3, 'John', 'Doe', '0873456789', '567890123', 'Ford', 'Focus', '08-D-456', 3, 'A');

INSERT INTO Drivers 
VALUES (4, 'Alice', 'Johnson', '0874567890', '901234567', 'Hyundai', 'i10', '11-L-57', 3, 'A');

INSERT INTO Drivers 
VALUES (5, 'Bob', 'Williams', '0875678901', '234567890', 'Honda', 'Civic', '212-D-6728', 7, 'A');

INSERT INTO Drivers 
VALUES (6, 'Sophia', 'Brown', '0876789012', '678901234', 'Toyota', 'Corrolla', '162-D-789', 5, 'A');

INSERT INTO Drivers 
VALUES (7, 'William', 'Jones', '0877890123', '123789045', 'Renault', 'Clio', '09-KY-8490', 7, 'A');

INSERT INTO Drivers 
VALUES (8, 'Olivia', 'Davis', '0878901234', '456123789', 'Ford', 'Fiesta', '11-KY-901', 6, 'A');

INSERT INTO Drivers 
VALUES (9, 'Liam', 'Miller', '0879012345', '789456123', 'Honda', 'Accord', '222-G-12', 4, 'A');

INSERT INTO Drivers 
VALUES (10, 'Mia', 'Wilson', '0870123456', '012345678', 'Toyota', 'Prius', '142-TN-1323', 5, 'A');

INSERT INTO Drivers 
VALUES (11, 'Lucas', 'Taylor', '0871234560', '345678901', 'Hyundai', 'Tucson', '181-L-24434', 4, 'A');

CREATE TABLE Accounts
(
AccountID NUMERIC (4),
Username VARCHAR2 (20),
Password VARCHAR2 (20) NOT NULL,
EmailAddress VARCHAR2 (30),
PhoneNumber VARCHAR2 (10),
AccountStatus varchar (1) default 'A',
CONSTRAINT pk_AccountID PRIMARY KEY (AccountID)
);

INSERT INTO Accounts
VALUES(1,'donny','gotdat12!','djmac2001@gmail.com','0831112223','A');
INSERT INTO Accounts 
VALUES(2, 'bingo', 'pass123!', 'bingo@ittralee.ie', '0912345678', 'A');
INSERT INTO Accounts 
VALUES(3, 'janedoe', 'doe@456', 'janedoe@gmail.net', '0987754321', 'A');
INSERT INTO Accounts
VALUES(4, 'alice', 'alic#epass', 'alice@example.com', '0876543210', 'A');
INSERT INTO Accounts 
VALUES(5, 'bob', 'b0bp@ss', 'bob@example.com', '0865432109', 'A');
INSERT INTO Accounts 
VALUES(6, 'charlie', 'charlie!123', 'charlie@example.com', '0854321098', 'A');
INSERT INTO Accounts 
VALUES(7, 'diana', 'dian@789', 'diana@example.com', '0843210987', 'A');
INSERT INTO Accounts
VALUES(8, 'edward', 'edward#321', 'edward@example.com', '0832109876', 'A');
INSERT INTO Accounts 
VALUES(9, 'frank', 'fr@nk098', 'frank@example.com', '0821098765', 'A');
INSERT INTO Accounts 
VALUES(10, 'grace', 'grace*567', 'grace@example.com', '0810987654', 'A');
INSERT INTO Accounts 
VALUES(11, 'harry', 'h@rry890', 'harry@example.com', '0809876543', 'A');
INSERT INTO Accounts 
VALUES(12, 'isabel', 'is@bel123', 'isabel@example.com', '0798765432', 'A');
INSERT INTO Accounts 
VALUES(13, 'jack', 'j@ck456', 'jack@example.com', '0787654321', 'A');
INSERT INTO Accounts 
VALUES(14, 'kate', 'k@te789', 'kate@example.com', '0776543210', 'A');
INSERT INTO Accounts VALUES
(15, 'lucy', 'lucy!987', 'lucy@example.com', '0765432109', 'A');
INSERT INTO Accounts VALUES
(16, 'mike', 'mike?654', 'mike@example.com', '0754321098', 'A');
INSERT INTO Accounts VALUES
(17, 'nancy', 'n@ncy321', 'nancy@example.com', '0743210987', 'A');
INSERT INTO Accounts VALUES
(18, 'oliver', 'oliver#456', 'oliver@example.com', '0732109876', 'A');
INSERT INTO Accounts VALUES
(19, 'peter', 'peter*789', 'peter@example.com', '0721098765', 'A');
INSERT INTO Accounts VALUES
(20, 'quinn', 'qu!nn123', 'quinn@example.com', '0710987654', 'A');


CREATE TABLE Bookings
(
BookingID NUMERIC (4),
DriverID NUMERIC (4) NOT NULL,
bookingDate DATE,
AccountID NUMERIC (4) NOT NULL,
Distance NUMERIC (2),
Destination VARCHAR2 (30),
pickUp VARCHAR2 (30),
Passengers NUMERIC (1),
Cost DECIMAL (5,2),
status char (1) default 'A',
CONSTRAINT pk_BookingID PRIMARY KEY (BookingID),
CONSTRAINT fk_DriverID FOREIGN KEY (DriverID) REFERENCES Drivers,
CONSTRAINT fk_AccountID FOREIGN KEY (AccountID) REFERENCES Accounts
);

INSERT INTO Bookings VALUES (1,'3','17-Apr-2024','1',22,'Tralee','Killarney',3,47,'F');
INSERT INTO Bookings VALUES(2, '1', '05-Jan-2024', '5', 15, 'Cork', 'Limerick', 2, 30.53, 'F');
INSERT INTO Bookings VALUES(3, '9', '20-Jan-2024', '17', 50, 'Dublin', 'Galway', 4, 91.00, 'F');
INSERT INTO Bookings VALUES(4, '10', '10-Feb-2024', '5', 30, 'Waterford', 'Wexford', 3, 59.44, 'F');
INSERT INTO Bookings VALUES(5, '2', '15-Feb-2024', '9', 10, 'Dundalk', 'Drogheda', 2, 23.80, 'F');
INSERT INTO Bookings VALUES(6, '3', '25-Feb-2024', '1', 40, 'Athlone', 'Mullingar', 4, 75, 'F');
INSERT INTO Bookings VALUES(7, '2', '05-Mar-2024', '2', 25, 'Sligo', 'Enniskillen', 3, 56.32, 'F');
INSERT INTO Bookings VALUES(8, '7', '10-Mar-2024', '6', 20, 'Kilkenny', 'Carlow', 2, 35.07, 'F');
INSERT INTO Bookings VALUES(9, '4', '15-Mar-2024', '3', 35, 'Limerick', 'Tralee', 4, 67.43, 'F');
INSERT INTO Bookings VALUES(10, '10', '20-Mar-2024', '10', 55, 'Galway', 'Dublin', 5, 102.05, 'F');
INSERT INTO Bookings VALUES(11, '8', '25-Mar-2024', '15', 60, 'Cork', 'Waterford', 5, 114.33, 'F');
INSERT INTO Bookings VALUES(12, '5', '30-Mar-2024', '13', 15, 'Dundalk', 'Drogheda', 2, 31.12, 'F');
INSERT INTO Bookings VALUES(13, '4', '05-Apr-2024', '16', 40, 'Athlone', 'Mullingar', 4, 76.00, 'F');
INSERT INTO Bookings VALUES(14, '5', '10-Apr-2024', '7', 50, 'Sligo', 'Enniskillen', 4, 90.90, 'F');
INSERT INTO Bookings VALUES(15, '2', '15-Apr-2024', '5', 20, 'Kilkenny', 'Carlow', 2, 39.65, 'F');
INSERT INTO Bookings VALUES(16, '1', '01-Jan-2024', '4', 30, 'Limerick', 'Tralee', 3, 61.21, 'F');
INSERT INTO Bookings VALUES(17, '3', '10-Jan-2024', '17', 25, 'Galway', 'Dublin', 3, 48.09, 'F');
INSERT INTO Bookings VALUES(18, '2', '20-Jan-2024', '14', 45, 'Cork', 'Waterford', 5, 84.43, 'F');
INSERT INTO Bookings VALUES(19, '11', '05-Feb-2024', '9', 10, 'Dundalk', 'Drogheda', 2, 23.44, 'F');
INSERT INTO Bookings VALUES(20, '6', '10-Feb-2024', '2', 35, 'Athlone', 'Mullingar', 4, 65.60, 'F');
INSERT INTO Bookings VALUES(21, '3', '15-Feb-2024', '13', 40, 'Sligo', 'Enniskillen', 4, 73.87, 'F');
INSERT INTO Bookings VALUES(22, '6', '25-Feb-2024', '1', 50, 'Kilkenny', 'Carlow', 5, 92.12, 'F');
INSERT INTO Bookings VALUES(23, '9', '05-Mar-2024', '5', 20, 'Limerick', 'Tralee', 3, 41.21, 'F');
INSERT INTO Bookings VALUES(24, '1', '10-Mar-2024', '8', 15, 'Galway', 'Dublin', 2, 30.50, 'F');
INSERT INTO Bookings VALUES(25, '2', '15-Mar-2024', '16', 60, 'Cork', 'Waterford', 5, 110.21, 'F');
INSERT INTO Bookings VALUES(26, '4', '20-Mar-2024', '7', 25, 'Dundalk', 'Drogheda', 3, 53.4, 'F');
INSERT INTO Bookings VALUES(27, '8', '25-Mar-2024', '6', 30, 'Athlone', 'Mullingar', 3, 53.32, 'F');
INSERT INTO Bookings VALUES(28, '3', '01-Apr-2024', '3', 10, 'Sligo', 'Enniskillen', 2, 20.43, 'F');
INSERT INTO Bookings VALUES(29, '9', '10-Apr-2024', '20', 45, 'Kilkenny', 'Carlow', 4, 86.33, 'F');
INSERT INTO Bookings VALUES(30, '10', '15-Apr-2024', '1', 35, 'Limerick', 'Tralee', 3, 61.17, 'F');