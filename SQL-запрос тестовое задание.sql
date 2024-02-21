create table Products 
(
	Product_id int primary key,
	"Product_name" text
);

insert into Products
values
	(1, 'Product1'),
	(2, 'Product2'),
	(3, 'Product3'),
	(4, 'Product4'),
	(5, 'Product5'),
	(6, 'Product6'),
	(7, 'Product7'),
	(8, 'Product8');

create table Categories
(
	Category_id int primary key,
	"Category_name" text
)

insert into Categories
values
	(1, 'Category1'),
	(2, 'Category2'),
	(3, 'Category3'),
	(4, 'Category4');

create table ProductCategory
(
	Product_id int,
	Category_id int
)

insert into ProductCategory
values
	(1, 2),
	(1, 3),
	(2, 2),
	(2, 1),
	(2, 3),
	(4, 2),
	(4, 4),
	(6, 1),
	(6, 3),
	(6, 4);

SELECT Product_name, Category_name
FROM Products
LEFT JOIN ProductCategory
ON Products.Product_id = ProductCategory.Product_id
LEFT JOIN Categories C
ON ProductCategory.Category_id = C.Category_id;