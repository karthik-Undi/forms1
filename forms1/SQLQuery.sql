create database employee
use employee
create table EmployeeDetails(
EmployeeID int,
EmployeeName varchar(32),
salary int
);
SELECT * FROM EmployeeDetails
INSERT INTO EmployeeDetails VALUES(11,'pan',10000)
DELETE FROM EmployeeDetails WHERE EmployeeID=0;
DELETE FROM EmployeeDetails WHERE EmployeeName LIKE '%n'
