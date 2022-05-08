CREATE DATABASE OptimalNutrition
GO
USE OptimalNutrition

CREATE LOGIN NutritionLogin WITH PASSWORD = '000'
GO

CREATE USER NutritionUser FOR LOGIN NutritionLogin
GO

GRANT SELECT, INSERT, ALTER ON SCHEMA::dbo TO NutritionUser
GO

CREATE TABLE Products (
id INT NOT NULL IDENTITY PRIMARY KEY,
Product VARCHAR(255) NOT NULL,
VitaminA DECIMAL NOT NULL,
VitaminB1 DECIMAL NOT NULL,
VitaminB2 DECIMAL NOT NULL,
VitaminB3 DECIMAL NOT NULL,
VitaminB5 DECIMAL NOT NULL,
VitaminB6 DECIMAL NOT NULL,
VitaminB7 DECIMAL NOT NULL,
VitaminB12 DECIMAL NOT NULL,
VitaminD DECIMAL NOT NULL,
VitaminC DECIMAL NOT NULL,
VitaminE DECIMAL NOT NULL,
);

GO
INSERT INTO Products (Product, VitaminA, VitaminB1, VitaminB2,
VitaminB3, VitaminB5, VitaminB6, VitaminB7, VitaminB12, VitaminD, VitaminC, VitaminE)
VALUES
('Beans', 24, 80, 80, 70, 120, 20, 1000, 0, 0, 6000, 0),
('Potatoes', 0, 210, 10, 500, 430, 60, 300, 0, 0, 9000, 10),
('Carrots', 1850, 90, 20, 200, 230, 40, 300, 0, 0, 3000, 0),
('Onions', 0, 110, 20, 300, 40, 100, 1000, 0, 0, 3000, 300),
('Broccoli', 100, 40, 60, 500, 280, 110, 3500, 0, 0, 44000, 1670),
('Mushrooms', 0, 130, 270, 2500, 2380, 100, 11700, 0, 0, 1000, 10),
('Cabbage', 53, 150, 50, 300, 210, 70, 100, 0, 0, 56000, 90),
('Cauliflower', 4, 90, 30, 400, 470, 150, 1200, 0, 0, 30000, 110),
('Tomatoes', 58, 40, 10, 600, 290, 60, 1400, 0, 0, 22000, 520),
('Lettuce', 10, 140, 50, 500, 190, 20, 700, 0, 0, 1000, 640),
('Spinach baby', 260, 90, 180, 1000, 280, 120, 100, 0, 0, 29000, 480),
('Rocket', 190, 190, 180, 700, 290, 80, 1300, 0, 0, 20000, 220),
('Cucumber', 12, 30, 20, 200, 320, 10, 800, 0, 0, 2000, 40),
('Bananas', 4, 150, 40, 700, 350, 310, 2500, 0, 0, 9000, 160),
('Apples', 2, 40, 40, 100, 100, 70, 1100, 0, 0, 6000, 90),
('Pears', 2, 30, 40, 200, 80, 40, 300, 0, 0, 3000, 120),
('Grapes', 4, 40, 10, 200, 140, 40, 200, 0, 0, 2000, 180),
('Strawberries', 4, 20, 20, 600, 370, 30, 1200, 0, 0, 57000, 390),
('Blueberries', 2, 40, 40, 300, 200, 10, 1500, 0, 0, 6000, 940),
('Citrus', 18, 170, 30, 400, 150, 60, 1400, 0, 0, 42000, 210),
('Oranges', 9, 220, 30, 500, 270, 50, 1000, 0, 0, 52000, 350),
('Melon', 1, 70, 10, 500, 240, 70, 2600, 0, 0, 8000, 70),
('Eggs', 120, 80, 470, 80, 1250, 100, 16700, 2, 3200, 0, 1630),
('Salmon', 28, 430, 120, 8300, 1220, 730, 5200, 3.15, 8900, 0, 2290);
