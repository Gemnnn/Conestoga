-- Assignment 03
-- Byounguk Min

-- Task 1 (ap DB IS USED)

use ap;

-- Q1. 

INSERT INTO invoices VALUE 
(NULL, 32, "AX-014-027", "2014-08-01", 434.58, 0.00, 0.00, 2, "2014-08-31", NULL);
SELECT ROW_COUNT();

-- Q2.

INSERT INTO invoice_line_items VALUE
(LAST_INSERT_ID(), 1, 160, 180.23, "Hard drive"),
(LAST_INSERT_ID(), 2, 527, 254.35, "Exchange Server update");
SELECT ROW_COUNT();

-- Q3.

UPDATE invoices SET credit_total = cast(invoice_total * 0.1 AS decimal(9,2)), 
payment_total = invoice_total - credit_total
WHERE invoice_id = LAST_INSERT_ID();
SELECT ROW_COUNT();

-- Q4.


DELETE FROM invoice_line_items WHERE invoice_id = LAST_INSERT_ID();
SELECT ROW_COUNT();
DELETE FROM invoices WHERE invoice_id = LAST_INSERT_ID();
SELECT ROW_COUNT();


-- Task 2 (My Guitar Shop(MGS) DB IS USED)

use my_guitar_shop;

-- Q1. 

INSERT INTO categories VALUE
(NULL, "Wind");
SELECT ROW_COUNT();

UPDATE categories SET category_name = "String"
WHERE category_id = 5;
SELECT ROW_COUNT();

DELETE FROM categories WHERE category_id = LAST_INSERT_ID();
SELECT ROW_COUNT();

-- Q2.

INSERT INTO products VALUE
(NULL, 4, "dgx_640", "Yamaha DGX 640 Digital Piano", 
"This is the Yamaha DGX 640 Digital Piano with 88 keys.", 845.95, 
20.00, GETDATE());
SELECT ROW_COUNT();

UPDATE products SET discount_percent = 30.00
WHERE product_id = LAST_INSERT_ID();
SELECT ROW_COUNT();

-- Q3.

INSERT INTO customers(customer_id, email_address, password, first_name, last_name) 
VALUE(NULL, "ByoungukMin@conestogac.on.ca", "", "Byounguk", "Min");
SELECT ROW_COUNT();

UPDATE customers SET password = "s3cr3t"
WHERE email_address = "ByoungukMin@conestogac.on.ca";
SELECT ROW_COUNT();

-- Task 2 (Software Expert (SWE) DB IS USED)

use swexpert;

-- Q1. 

INSERT INTO consultant VALUE
(106, "Min", "Byounguk", "Branden", "295 Adelaide Street West", "Toronto", "BC", 50403, 01084410841, "bmfake@fake.com");
SELECT ROW_COUNT();

-- Q2.
INSERT INTO client VALUE
(17, "City of Waterloo", "Jaworsky", "Dave", 5198861550);
SELECT ROW_COUNT();

-- Q3.
INSERT INTO project VALUE
(88, "ION Rapid Transit", 17, 106, NULL);
SELECT ROW_COUNT();

-- Q4.
UPDATE project SET parent_p_id = 88
WHERE p_id = 1 
AND p_id = 4 
AND p_id = 5 
And p_id = 7;
SELECT ROW_COUNT();




