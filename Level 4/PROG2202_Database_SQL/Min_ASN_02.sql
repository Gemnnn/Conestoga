-- Assignment 02
-- Byounguk Min

use my_guitar_shop;

-- Task 1 (my_guitar_shop DB IS USED)

-- Q1. 

SELECT categories.category_name, products.product_name, products.list_price
FROM categories
LEFT JOIN products ON categories.category_id = products.category_id
ORDER BY product_name ASC;

-- Q2.

SELECT customers.first_name, customers.last_name, addresses.line1, addresses.city,
addresses.state, addresses.zip_code
FROM customers
JOIN addresses ON customers.customer_id = addresses.customer_id
WHERE email_address LIKE "allan.sherwood@yahoo.com";

-- Q3.

SELECT c.last_name, c.first_name, o.order_date, p.product_name,
oi.item_price, oi.discount_amount, oi.quantity
FROM customers AS c
JOIN orders AS o ON c.customer_id = o.customer_id
JOIN order_items AS oi ON o.order_id = oi.order_id
JOIN products AS p ON oi.order_id = p.product_id
ORDER BY c.last_name, o.order_date, p.product_name;

-- Q4.

SELECT p1.product_id, p1.product_name, p1.list_price
FROM Products AS p1
JOIN Products AS p2 ON p1.product_id <> p2.product_id
AND p1.list_price = p2.list_price;

-- Q5.

SELECT 'SHIPPED' AS ship_status, orders.order_id, orders.order_date
FROM orders
WHERE orders.ship_date IS NOT NULL
UNION
SELECT 'NOT SHIPPED' AS ship_status, orders.order_id, orders.order_date
FROM orders
WHERE orders.ship_date IS NULL
ORDER BY order_date;

-- Task 2 (Software Expert (SWE) DB IS USED)

use swexpert;

-- Q1.

SELECT DISTINCT consultant.c_city
FROM consultant;

-- Q2.

SELECT project.p_id, project.project_name
FROM project
WHERE parent_p_id IS NOT NULL;

-- Q3.

SELECT project1.p_id, project1.project_name, project1.parent_p_id, project2.project_name AS parent_project_name
FROM project AS project2
RIGHT JOIN project AS project1 
ON project2.p_id = project1.parent_p_id;

-- Q4.

SELECT *
FROM consultant_skill
WHERE certification = "Y"
ORDER BY skill_id, c_id;

-- Q5.

SELECT consultant.c_id, consultant.c_last, consultant.c_first, 
consultant_skill.skill_id, skill.skill_description
FROM consultant
LEFT JOIN consultant_skill ON consultant.c_id = consultant_skill.c_id
LEFT JOIN skill ON consultant_skill.skill_id = skill.skill_id
ORDER BY skill_id, c_id;





