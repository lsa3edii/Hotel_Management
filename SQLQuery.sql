select * from [LOGIN_MANAGER].[dbo].frontend
select * from [LOGIN_MANAGER].[dbo].kitchen

select * from [FRONTEND_RESERVATION].[dbo].[reservation]



-- select * from FrontendUsers
select * from Admins
select * from KitchenUsers


select * from [FRONTEND_RESERVATION2].[dbo].[reservation]
select * from [FRONTEND_RESERVATION2].[dbo].__EFMigrationsHistory


-- SQL Injection
-- SELECT * FROM Admins WHERE username = '' OR '1'='1' AND password = '';


select * from users
delete from users

DBCC CHECKIDENT ('Users', RESEED, 0);


---------------------------------------------------------------

USE [FRONTEND_RESERVATION2];
GO

update [reservation]
set supply_status = 0;

delete from [reservation]


USE [FRONTEND_RESERVATION2]
GO

INSERT INTO [dbo].[reservation] (
    [first_name], [last_name], [birth_day], [gender], [phone_number], [email_address], 
    [number_guest], [street_address], [apt_suite], [city], [state], [zip_code], 
    [room_type], [room_floor], [room_number], [total_bill], [payment_type], 
    [card_type], [card_number], [card_exp], [card_cvc], [arrival_time], [leaving_time], 
    [check_in], [break_fast], [lunch], [dinner], [cleaning], [towel], 
    [s_surprise], [supply_status], [food_bill]
) 
VALUES 
('John', 'Doe', 'July-10-1985', 'Male', '1234567890', 'john.doe@example.com', 
 2, '123 Main St', 'Apt 1', 'New York', 'NY', '10001', 
 'Deluxe', '2', '201', 250.75, 'Credit', 
 'Visa', '4111111111111111', 'December-2026', '123', '2025-03-01', '2025-03-05', 
 1, 1, 1, 1, 1, 1, 
 0, 1, 50),

('Jane', 'Smith', 'November-22-1992', 'Female', '9876543210', 'jane.smith@example.com', 
 1, '456 Oak St', 'Apt 5B', 'Los Angeles', 'CA', '90002', 
 'Suite', '5', '502', 325.00, 'Debit', 
 'MasterCard', '5500000000000004', 'November-2027', '456', '2025-03-02', '2025-03-06', 
 1, 1, 1, 1, 0, 1, 
 1, 1, 60),

('Mike', 'Johnson', 'May-15-1990', 'Male', '5551234567', 'mike.johnson@example.com', 
 3, '789 Pine St', 'Unit 12', 'Chicago', 'IL', '60605', 
 'Standard', '3', '305', 180.50, 'Cash', 
 'N/A', '', '', '', '2025-03-03', '2025-03-07', 
 1, 1, 0, 1, 1, 0, 
 0, 1, 40),

('Emma', 'Brown', 'September-30-1988', 'Female', '2223334444', 'emma.brown@example.com', 
 2, '321 Maple Ave', 'Suite 200', 'Houston', 'TX', '77004', 
 'Executive', '4', '410', 400.00, 'Credit', 
 'Amex', '371449635398431', 'October-2028', '789', '2025-03-04', '2025-03-08', 
 1, 1, 1, 1, 1, 1, 
 1, 1, 70),

('Chris', 'Taylor', 'March-25-1995', 'Male', '6667778888', 'chris.taylor@example.com', 
 4, '567 Cedar Rd', 'Apt 8', 'Phoenix', 'AZ', '85003', 
 'Suite', '6', '601', 290.25, 'Debit', 
 'Visa', '4111111111111122', 'September-2026', '234', '2025-03-05', '2025-03-09', 
 1, 0, 1, 1, 0, 1, 
 0, 1, 55),

('Sophia', 'Williams', 'December-12-1993', 'Female', '9990001111', 'sophia.williams@example.com', 
 1, '890 Birch Ln', 'Unit 3A', 'Philadelphia', 'PA', '19102', 
 'Standard', '2', '202', 160.00, 'Credit', 
 'MasterCard', '5200000000000007', 'August-2027', '567', '2025-03-06', '2025-03-10', 
 1, 1, 0, 1, 1, 1, 
 1, 1, 30),

('Daniel', 'Martinez', 'June-18-1987', 'Male', '3334445555', 'daniel.martinez@example.com', 
 2, '234 Spruce St', 'Suite 5C', 'San Diego', 'CA', '92101', 
 'Deluxe', '3', '315', 280.00, 'Credit', 
 'Visa', '4111111111111133', 'July-2026', '678', '2025-03-07', '2025-03-11', 
 1, 1, 1, 0, 1, 0, 
 0, 1, 45),

('Olivia', 'Davis', 'August-05-1991', 'Female', '4445556666', 'olivia.davis@example.com', 
 3, '123 Elm St', 'Unit 7B', 'San Antonio', 'TX', '78205', 
 'Executive', '5', '503', 420.50, 'Debit', 
 'Amex', '370000000000002', 'June-2028', '890', '2025-03-08', '2025-03-12', 
 1, 1, 1, 1, 1, 1, 
 1, 1, 75),

('James', 'Lopez', 'April-10-1990', 'Male', '7778889999', 'james.lopez@example.com', 
 1, '456 Willow St', 'Apt 9C', 'Dallas', 'TX', '75201', 
 'Suite', '4', '407', 310.75, 'Credit', 
 'Visa', '4111111111111144', 'May-2026', '901', '2025-03-09', '2025-03-13', 
 1, 1, 0, 1, 0, 1, 
 0, 1, 50),

('Isabella', 'Gonzalez', 'July-20-1989', 'Female', '1112223333', 'isabella.gonzalez@example.com', 
 2, '678 Oakwood Dr', 'Suite 6D', 'Austin', 'TX', '73301', 
 'Deluxe', '3', '322', 275.00, 'Cash', 
 'N/A', '', '', '', '2025-03-10', '2025-03-14', 
 1, 1, 1, 0, 1, 0, 
 0, 1, 40);
GO


CREATE OR ALTER PROCEDURE SearchReservation
    @id INT = NULL,
    @fname NVARCHAR(50) = NULL
AS
BEGIN
    SELECT * FROM reservation
    WHERE (@id IS NOT NULL AND CAST(id AS NVARCHAR) LIKE '%' + CAST(@id AS NVARCHAR) + '%')
       OR (@fname IS NOT NULL AND first_name LIKE '%' + @fname + '%');
END;

exec SearchReservation 12, null;



CREATE OR ALTER PROCEDURE RservedRooms
AS
BEGIN
    SELECT Id, (first_name + ' ' + last_name)[FullName], room_number, room_type, phone_number, arrival_time, leaving_time FROM reservation
	Where check_in = 1
END;



CREATE OR ALTER PROCEDURE OccupiedRooms
AS
BEGIN
    SELECT Id, (first_name + ' ' + last_name)[FullName], room_number, room_type, phone_number FROM reservation
	Where check_in = 0
END;



create or alter procedure TestProc
as
begin
    select * from reservation
end;




CREATE OR ALTER PROCEDURE AuthenticateUser
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT *
    FROM Users
    WHERE Username = @Username AND Password = @Password;
END;

AuthenticateUser mo, mo



begin tran
delete from reservation where id = 20
-- commit
-- rollback



select * from reservation
