

create database store
use store

create table strpr(  ID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);
INSERT INTO strpr VALUES (1, 'deepak', 'mishra', 'sadar','nagpur');
INSERT INTO strpr VALUES (2, 'abc', 'mishra', 'sadar','nagpur');

INSERT INTO strpr VALUES (3, 'xyz', 'mishra', 'sadar','nagpur');

INSERT INTO strpr VALUES (4, 'lmo', 'mishra', 'sadar','nagpur');

create table secondtable(  ID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);
INSERT INTO strpr VALUES (1, 'deepak', 'mishra', 'sadar','nagpur');
INSERT INTO strpr VALUES (2, 'abc', 'mishra', 'sadar','nagpur');

INSERT INTO strpr VALUES (3, 'xyz', 'mishra', 'sadar','nagpur');

INSERT INTO strpr VALUES (4, 'lmo', 'mishra', 'sadar','nagpur');




create procedure PROCM
AS
BEGIN
     select * from strpr where ID <4;
	 END 


	 exec PROCM


	 --alter Store Procedure

	 alter procedure PROCM
	 AS 
	 BEGIN
	 select * from strpr where ID<4 and Address='nagpur';
	 END
	 exec PROCM

	 --drop

	 drop procedure PROCM

	 use secondtable


	 --sp procedure with input parameter
	 create procedure secondtables(@Address varchar(255))
	 as 
	 begin
	 select * from secondtable where Address=@Address
	 end

	 --display
	 exec secondtables Address='sadar'


	 --SP with output parameter
	 create procedure PROC_DT1(@TID int output)
	 as
	 begin
	 select @TID=max(TID) from Dlithe_Trainees
	 END

	 Declare 

	 exec PROC_DT1 @TID output
	 print 