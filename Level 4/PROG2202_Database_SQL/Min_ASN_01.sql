-- Assignment 01
-- Byounguk Min

USE ap;

-- Task 1 (AP DB IS USED)

-- Q1.
SELECT vendor_name, vendor_contact_last_name, vendor_contact_first_name 
FROM vendors 
ORDER BY vendor_contact_last_name ASC,
vendor_contact_first_name ASC;

-- Q2.
SELECT concat(vendor_contact_last_name,  ', ' ,vendor_contact_first_name)
AS full_name
FROM vendors
WHERE vendor_contact_last_name LIKE 'A%'
OR vendor_contact_last_name LIKE 'B%'
OR vendor_contact_last_name LIKE 'C%'
OR vendor_contact_last_name LIKE 'E%'
ORDER BY vendor_contact_last_name ASC,
vendor_contact_first_name ASC;

-- Q3.
SELECT invoice_due_date AS 'Due Date',
invoice_total AS 'Invoice Total',
(invoice_total * 0.1) AS '10%',
(invoice_total * 1.1) AS 'Plus 10%'
FROM invoices
WHERE invoice_total >= 500
AND invoice_total <= 1000
ORDER BY invoice_due_date DESC;

-- Q4.
SELECT invoice_number AS 'invoice_number',
invoice_total AS 'invoice_total',
payment_total + credit_total AS 'payment_credit_total',
invoice_total - payment_total - credit_total AS 'balance_due'
FROM invoices
WHERE invoice_total - payment_total - credit_total > 50
ORDER BY balance_due DESC
LIMIT 0,5;

-- Q5.
SELECT invoice_number AS 'invoice_number',
invoice_date AS 'invoice_date',
invoice_total - payment_total - credit_total AS 'balance_due',
payment_date AS 'payment_date'
FROM invoices
WHERE ISNULL(payment_date);

-- Q6.
SELECT DATE_FORMAT(current_date, '%m/%d/%Y') as 'current_date';

-- Q7.
SELECT 50000 AS 'starting_principal',
50000 * 0.065 AS 'interest',
50000 + (50000 * 0.065) AS principal_plus_interest;

-- Task 2 (MY FUITAR SHOP DB IS USED)

USE my_guitar_shop;

-- Q1. MGS Exercise 3-1

SELECT product_code, product_name, list_price, discount_percent
FROM products
ORDER BY list_price DESC;


-- Q2. MGS Exercise 3-3

SELECT product_name, list_price, date_added
FROM products
WHERE list_price > 500 AND
list_price < 2000
ORDER BY date_added DESC;

-- Q3. MGS Exercise 3-5

SELECT item_id, item_price, discount_amount, quantity,
quantity * item_price AS price_total,
discount_amount * quantity AS discount_total,
(item_price - discount_amount) * quantity AS item_total
FROM order_items
WHERE (item_price - discount_amount) * quantity > 500
ORDER BY item_total DESC;

-- Q4. MGS Exercise 3-6

SELECT order_id, order_date, ship_date
FROM orders
WHERE ship_date IS null
ORDER BY order_id DESC;

-- Q5. MGS Exercise 3-8

SELECT 100 AS price,
.07 AS tax_rate,
100*.07 AS tax_amount,
100+ (100*.07) AS total;

