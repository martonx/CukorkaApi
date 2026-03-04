# CukorkaApi

CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Price INT NOT NULL,
    Stock INT NOT NULL
);

INSERT INTO Products (Name, Price, Stock) VALUES
('Mars', 300, 5),
('Balaton', 250, 21),
('Duna kavics', 450, 3),
('Twix', 320, 12),
('Snickers', 310, 8),
('Bounty', 330, 6),
('KitKat', 290, 15),
('Sport szelet', 270, 18),
('Milka csoki', 520, 10),
('Toblerone', 600, 4),
('Kinder Bueno', 400, 9),
('Raffaello', 750, 7),
('Ferrero Rocher', 1200, 5),
('After Eight', 680, 11),
('M&M''s', 350, 14),
('Haribo Goldbären', 390, 16),
('Chupa Chups', 120, 30),
('Orbit rágó', 280, 22),
('Tic Tac', 260, 19),
('Negro cukorka', 150, 25);