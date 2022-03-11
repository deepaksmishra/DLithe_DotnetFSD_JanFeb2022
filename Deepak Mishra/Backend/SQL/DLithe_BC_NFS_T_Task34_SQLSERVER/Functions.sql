--FUNCTION SUb programs
--system and user-defined 
--system > math,string , datatime

--user defined 
--> scalar - accept only one value
--> inline - table -valued -table
--> multi statement table valued

--> inline example

create database functions
use functions

--> simple functiion
create function te(@a int)
returns int
as
	begin
		return @a+@a
	end
	
-- calling the function


select dbo.te(20) as 'Result'


--create table
create table student
(

id int primary key  IDENTITY,
NAME varchar(25),
DOB date
)

insert into student values('Deepak','08/09/1998')

select * from student


--creating a function for the DOB coloum in student

create function calculateage(@age date)
Returns int 
as 
begin
	Declare @tage int
	set @tage=DATEDIFF(YEAR,@age,GETDATE())
	return @tage
end

--display
select dbo.calculateage('12/12/2022') as Age
select id,name,dob,dbo.calculateage(dob) as Age from Student



--2) INLINE TABLED VALUES -RETURNS A TABLE ,ONLY ONE STATMENT CAN BE USED
--BEGIN END NOT REQIRED

create function inl_table(@id int)
Returns table
as
  return (select * from student where id=@id)

  select * from inl_table(1)


--3) MULTI STATMENT TABLE VALUED,MORE THAN ONE STATMENT , BEGIN AND EEND MUST BE USED

create function multistatment()
returns @table table(id int , name varchar(25) , Dateofbirth DATE)
as
	begin
		insert into @table
		select id , NAME , DOB from student where NAME='Deepak';
		Return
		end

--function calling
select * from multistatment() 