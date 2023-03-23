create database shop;
Use shop;
create table if not exists products (
ProductID int NOT NULL AUTO_INCREMENT,
ProductCode int(3),
Nam varchar(30) not null,
quantity int not null,
price decimal(7,2) not null,
dscription varchar(30),
primary key (ProductID)
);


select * from products;

create table productCopy As
select nam,quantity from products;

select * from productCopy;

drop table productCopy;
alter table products add age int;
alter table products drop column age;
insert into products (productCode, nam, quantity, price, dscription) values ('126', 'Mouse', '20', '500', 'for computer');
insert into products (productCode, nam, quantity, price, dscription) values ('125', 'Keyboard', '20', '700', 'computer keyboard');
select nam from products;

update products set nam = 'CPU' where productCode = '125';
delete from products where productCode = '125';

update products set nam = 'printer' , quantity = '234', price = '700' where productcode = '126';

create table employee(
emp_id int not null,
name varchar(15) not null,
hire_date date not null,
salary int(11) not null,
unique(name)
);

use shop;
select * from mysite_customer;
