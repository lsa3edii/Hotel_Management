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



CREATE or alter PROCEDURE DeleteReservation
    @Id INT
AS
BEGIN
    --SET NOCOUNT ON; -- is a SQL Server command that prevents the message that shows the number of rows affected by a SQL statement from being returned for performance.

    DELETE FROM [dbo].[reservation]
    WHERE [Id] = @Id;
END;

begin tran
EXEC DeleteReservation @Id = 5;
-- commit
-- rollback



CREATE or alter PROCEDURE UpdateReservation
    @Id INT,
    @first_name NVARCHAR(50) = NULL,
    @last_name NVARCHAR(50) = NULL,
    @birth_day NVARCHAR(50) = NULL,
    @gender NVARCHAR(50) = NULL,
    @phone_number NVARCHAR(50) = NULL,
    @email_address NVARCHAR(MAX) = NULL,
    @number_guest INT = NULL,
    @street_address NVARCHAR(MAX) = NULL,
    @apt_suite NVARCHAR(50) = NULL,
    @city NVARCHAR(MAX) = NULL,
    @state NVARCHAR(50) = NULL,
    @zip_code NCHAR(10) = NULL,
    @room_type NCHAR(10) = NULL,
    @room_floor NCHAR(10) = NULL,
    @room_number NCHAR(10) = NULL,
    @total_bill FLOAT = NULL,
    @payment_type NCHAR(10) = NULL,
    @card_type NCHAR(10) = NULL,
    @card_number NVARCHAR(50) = NULL,
    @card_exp NVARCHAR(50) = NULL,
    @card_cvc NCHAR(10) = NULL,
    @arrival_time DATE = NULL,
    @leaving_time DATE = NULL,
    @check_in BIT = NULL,
    @break_fast INT = NULL,
    @lunch INT = NULL,
    @dinner INT = NULL,
    @cleaning BIT = NULL,
    @towel BIT = NULL,
    @s_surprise BIT = NULL,
    @supply_status BIT = NULL,
    @food_bill INT = NULL
AS
BEGIN
    -- SET NOCOUNT ON;

    UPDATE reservation
    SET 
        first_name = ISNULL(@first_name, first_name),
        last_name = ISNULL(@last_name, last_name),
        birth_day = ISNULL(@birth_day, birth_day),
        gender = ISNULL(@gender, gender),
        phone_number = ISNULL(@phone_number, phone_number),
        email_address = ISNULL(@email_address, email_address),
        number_guest = ISNULL(@number_guest, number_guest),
        street_address = ISNULL(@street_address, street_address),
        apt_suite = ISNULL(@apt_suite, apt_suite),
        city = ISNULL(@city, city),
        state = ISNULL(@state, state),
        zip_code = ISNULL(@zip_code, zip_code),
        room_type = ISNULL(@room_type, room_type),
        room_floor = ISNULL(@room_floor, room_floor),
        room_number = ISNULL(@room_number, room_number),
        total_bill = ISNULL(@total_bill, total_bill),
        payment_type = ISNULL(@payment_type, payment_type),
        card_type = ISNULL(@card_type, card_type),
        card_number = ISNULL(@card_number, card_number),
        card_exp = ISNULL(@card_exp, card_exp),
        card_cvc = ISNULL(@card_cvc, card_cvc),
        arrival_time = ISNULL(@arrival_time, arrival_time),
        leaving_time = ISNULL(@leaving_time, leaving_time),
        check_in = ISNULL(@check_in, check_in),
        break_fast = ISNULL(@break_fast, break_fast),
        lunch = ISNULL(@lunch, lunch),
        dinner = ISNULL(@dinner, dinner),
        cleaning = ISNULL(@cleaning, cleaning),
        towel = ISNULL(@towel, towel),
        s_surprise = ISNULL(@s_surprise, s_surprise),
        supply_status = ISNULL(@supply_status, supply_status),
        food_bill = ISNULL(@food_bill, food_bill)
    WHERE Id = @Id;
END;



EXEC UpdateReservation
    @Id = 31, 
    @first_name = 'Alice', 
    @gender = 'Female', 
    @phone_number = '9876543210', 
    @email_address = 'alice@example.com', 
    @number_guest = 2, 
    @street_address = '123 Main St', 
    @apt_suite = 'Apt 4B', 
    @city = 'New York', 
    @state = 'NY', 
    @zip_code = '10001', 
    @room_type = 'Deluxe', 
    @room_floor = '3', 
    @room_number = '305', 
    @total_bill = 500.00, 
    @payment_type = 'Credit', 
    @card_type = 'Visa', 
    @card_number = '4111111111111111', 
    @card_exp = '12/27', 
    @card_cvc = '123', 
    @arrival_time = '2025-06-01', 
    @leaving_time = '2025-06-05';



CREATE or alter PROCEDURE InsertReservation
    @first_name NVARCHAR(50),
    @last_name NVARCHAR(50),
    @birth_day NVARCHAR(50),
    @gender NVARCHAR(50),
    @phone_number NVARCHAR(50),
    @email_address NVARCHAR(MAX),
    @number_guest INT,
    @street_address NVARCHAR(MAX),
    @apt_suite NVARCHAR(50),
    @city NVARCHAR(MAX),
    @state NVARCHAR(50),
    @zip_code NCHAR(10),
    @room_type NCHAR(10),
    @room_floor NCHAR(10),
    @room_number NCHAR(10),
    @total_bill FLOAT,
    @payment_type NCHAR(10),
    @card_type NCHAR(10),
    @card_number NVARCHAR(50),
    @card_exp NVARCHAR(50),
    @card_cvc NCHAR(10),
    @arrival_time DATE,
    @leaving_time DATE,
    @check_in BIT,
    @break_fast INT,
    @lunch INT,
    @dinner INT,
    @cleaning BIT,
    @towel BIT,
    @s_surprise BIT,
    @supply_status BIT,
    @food_bill INT
AS
BEGIN
    -- SET NOCOUNT ON;

    INSERT INTO reservation (
        first_name, last_name, birth_day, gender, phone_number, email_address, 
        number_guest, street_address, apt_suite, city, state, zip_code, room_type, 
        room_floor, room_number, total_bill, payment_type, card_type, card_number, 
        card_exp, card_cvc, arrival_time, leaving_time, check_in, break_fast, lunch, 
        dinner, cleaning, towel, s_surprise, supply_status, food_bill
    ) VALUES (
        @first_name, @last_name, @birth_day, @gender, @phone_number, @email_address, 
        @number_guest, @street_address, @apt_suite, @city, @state, @zip_code, @room_type, 
        @room_floor, @room_number, @total_bill, @payment_type, @card_type, @card_number, 
        @card_exp, @card_cvc, @arrival_time, @leaving_time, @check_in, @break_fast, @lunch, 
        @dinner, @cleaning, @towel, @s_surprise, @supply_status, @food_bill
    );


    -- Return the last inserted ID
    -- SELECT SCOPE_IDENTITY() AS NewReservationID;
END;



CREATE or alter PROCEDURE SelectAllReservation
as
begin
	select * from reservation
end

exec SelectAllReservation


select * from reservation
select * from reservation where Id = 31

delete from reservation where Id between 1001 and 50000;


update reservation
set first_name = 'Muhammed', last_name = 'Abdo'
where id = 555
