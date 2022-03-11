create database WebApi
use WebApi

create table UserRegistration
(
id int primary key identity,
Name varchar(25),
Email varchar(25),
Gender varchar(25),
Username varchar(25),
Password varchar(25)


)
select * from UserRegistration
insert into UserRegistration values('deepak','deepak123.dm98@gmail.com','male','deepakmishra','deepak' )
insert into UserRegistration values('suraj','suraj@gmail.com','male','surajmishra','suraj' )
insert into UserRegistration values('rohit','rohit@gmail.com','male','rohit','rohit' )