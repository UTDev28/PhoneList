
BEGIN TRAN 

INSERT INTO dbo.PhoneRecords (FirstName,LastName,PhoneNumber,Age)
VALUES
('Kevin','Reid',801123456,30),
('Greg','Sanders',801654321,19),
('Barbara','Williams',801987654,22),
('Sarah','Jacobs',801456789,57),
('Tim','Edwards',801654987,70)

--ROLLBACK TRAN 
COMMIT TRAN