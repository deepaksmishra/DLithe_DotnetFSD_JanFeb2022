-- CREATE DATABASE 
create database Kasainsurance

--USE DATABASE
use Kasainsurance
--create table(DDL)
create table Details
(
ID int NOT NULL,
Name varchar(250) NOT NULL
);

--Insert Records into the Tables(DML)
insert into Details values(1 , 'deepak');

--select (*-> all the coloums print)
select * from Details
select id from Details
--ALTER
alter table Details add emailid varchar(25)

--update
update Details set emailid='deepak123.dm98@gmail.com'


--select condition

select * from Details where emailid='deepak123.dm98@gmail.com'
select * from Details where id > 2 and id < 6  --relational operator/logical 
select * from Details where id > 2 between id < 6  -- range operator
select * from Details where Name like 'S%' -- like operator 
select * from Details where Name like '_a%' -- like operator



--CREATE Schema 

create schema TE 

--CREATE TABLE INSIDE THE SCHEMA TE
create table TE.MarchTrainees
( 
id int NOT NULL,
Name varchar(25),
Mobile nvarchar(10),
department varchar(25)
);

--DROP SCHEMA
drop schema if exists TE

--DROP TABLE MARCH TRAINEES
drop table TE.MarchTrainees

--Delete Records from a  Table

delete from  Details where emailid='deepak123.dm98@gmail.com'

--truncate data will gone 
truncate table Details



--Primary Kkey 
create table Depart
(
Dno int Primary key,
Dname varchar(25)
)



