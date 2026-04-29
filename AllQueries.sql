Create Database Hotel_Reservation;

CREATE TABLE RegistrationDetails (
    IDCardNumber NVARCHAR(20) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    ContactNumber NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL
);





CREATE TABLE BookingDetails (
    BookingID INT IDENTITY(1,1) PRIMARY KEY, 
    IDCardNumber NVARCHAR(20) NOT NULL,      
    CheckInDate DATE NOT NULL,                
    DaysStayed INT NOT NULL,                 
    CheckOutDate DATE NOT NULL,               
    PaymentType NVARCHAR(30),                 
    TotalAmount DECIMAL(18, 2),               
    

    CONSTRAINT FK_UserBooking FOREIGN KEY (IDCardNumber) 
    REFERENCES RegistrationDetails(IDCardNumber)
);

CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Available'
);

INSERT INTO Rooms (RoomID, Status)
VALUES 
(1, 'Available'),
(2, 'Available'),
(3, 'Available'),
(4, 'Available'),
(5, 'Available'),
(6, 'Available');
