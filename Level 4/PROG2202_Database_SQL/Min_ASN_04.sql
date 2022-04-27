-- Assignment 04
-- Byounguk Min

-- Warm up: Textbook Exercise

-- Chapter 6
-- ex.1
use ap;

SELECT vendor_id, SUM(invoice_total)
FROM invoices
GROUP BY vendor_id;

-- ex.2
SELECT vendor_name, SUM(payment_total)
FROM vendors v 
JOIN invoices i
ON v.vendor_id = i.vendor_id
GROUP BY vendor_name
ORDER BY SUM(payment_total) DESC;

-- ex.3
SELECT vendor_name, COUNT(*), SUM(invoice_total)
FROM vendors v
JOIN invoices i
ON v.vendor_id = i.vendor_id
GROUP BY vendor_name
ORDER BY SUM(invoice_total) DESC;

-- ex.4
SELECT account_description, COUNT(*), SUM(line_item_amount)
FROM general_ledger_accounts gl 
JOIN invoice_line_items li
ON gl.account_number = li.account_number
GROUP BY account_description
HAVING COUNT(*) > 1
ORDER BY SUM(line_item_amount) DESC;

-- ex.5
SELECT account_description, COUNT(*) AS line_item_count,
       SUM(line_item_amount) AS line_item_amount_sum
FROM general_ledger_accounts gl 
  JOIN invoice_line_items li
    ON gl.account_number = li.account_number
  JOIN invoices i
    ON li.invoice_id = i.invoice_id
WHERE invoice_date BETWEEN '2014-04-01' AND '2014-06-30'
GROUP BY account_description
HAVING line_item_count > 1
ORDER BY line_item_amount_sum DESC;

-- ex.6
SELECT account_number, SUM(line_item_amount)
FROM invoice_line_items
GROUP BY account_number WITH ROLLUP;

-- ex.7
SELECT vendor_name,
COUNT(DISTINCT li.account_number) AS number_of_gl_accounts
FROM vendors v 
JOIN invoices i
ON v.vendor_id = i.vendor_id
JOIN invoice_line_items li
ON i.invoice_id = li.invoice_id
GROUP BY vendor_name
HAVING number_of_gl_accounts > 1
ORDER BY vendor_name;


-- Chapter 7
-- ex.1
SELECT vendor_name
FROM vendors
WHERE vendor_id IN
(SELECT DISTINCT vendor_id FROM invoices)
ORDER BY vendor_name;

-- ex.2
SELECT invoice_number, invoice_total
FROM invoices
WHERE payment_total >
(SELECT AVG(payment_total)
FROM invoices
WHERE payment_total > 0)
ORDER BY invoice_total DESC;

-- ex.3
SELECT account_number, account_description
FROM general_ledger_accounts gl
WHERE NOT EXISTS
(SELECT *
FROM invoice_line_items
WHERE account_number = gl.account_number)
ORDER BY account_number;

-- ex.4
SELECT vendor_name, i.invoice_id, invoice_sequence, line_item_amount
FROM vendors v JOIN invoices i
ON v.vendor_id = i.vendor_id
JOIN invoice_line_items li
ON i.invoice_id = li.invoice_id
WHERE i.invoice_id IN
(SELECT DISTINCT invoice_id
FROM invoice_line_items               
WHERE invoice_sequence > 1)
ORDER BY vendor_name, i.invoice_id, invoice_sequence;

-- ex.5
SELECT SUM(invoice_max) AS sum_of_maximums
FROM 
(SELECT vendor_id, MAX(invoice_total) AS invoice_max
FROM invoices
WHERE invoice_total - credit_total - payment_total > 0
GROUP BY vendor_id) t;
      
-- ex.6
SELECT vendor_name, vendor_city, vendor_state
FROM vendors
WHERE CONCAT(vendor_state, vendor_city) NOT IN 
(SELECT CONCAT(vendor_state, vendor_city) as vendor_city_state
FROM vendors
GROUP BY vendor_city_state
HAVING COUNT(*) > 1)
ORDER BY vendor_state, vendor_city;

-- ex.7
SELECT vendor_name, invoice_number, invoice_date, invoice_total
FROM invoices i JOIN vendors v
ON i.vendor_id = v.vendor_id
WHERE invoice_date =
(SELECT MIN(invoice_date)
FROM invoices 
WHERE vendor_id = i.vendor_id)
ORDER BY vendor_name;

-- ex.8
SELECT vendor_name, invoice_number, invoice_date, invoice_total
FROM invoices i
JOIN
(SELECT vendor_id, MIN(invoice_date) AS oldest_invoice_date
FROM invoices
GROUP BY vendor_id
) oi
ON i.vendor_id = oi.vendor_id AND
i.invoice_date = oi.oldest_invoice_date
JOIN vendors v
ON i.vendor_id = v.vendor_id
ORDER BY vendor_name;

-- Chapter 11
-- ex.1
CREATE INDEX vendors_zip_code_ix ON vendors (vendor_zip_code);

-- ex.2
USE ex;

DROP TABLE IF EXISTS members_groups;
DROP TABLE IF EXISTS members;
DROP TABLE IF EXISTS groups;

CREATE TABLE members 
(
  member_id     INT           PRIMARY KEY   AUTO_INCREMENT, 
  first_name    VARCHAR(50)   NOT NULL, 
  last_name     VARCHAR(50)   NOT NULL, 
  address       VARCHAR(50)   NOT NULL, 
  city          VARCHAR(25)   NOT NULL, 
  state         CHAR(2), 
  phone         VARCHAR(20)
);

CREATE TABLE groups 
(
  group_id      INT            PRIMARY KEY   AUTO_INCREMENT, 
  group_name    VARCHAR(50)    NOT NULL
);

CREATE TABLE members_groups
(
  member_id     INT              NOT NULL, 
  group_id      INT              NOT NULL,
  CONSTRAINT members_groups_fk_members FOREIGN KEY (member_id)
    REFERENCES members (member_id), 
  CONSTRAINT members_groups_fk_groups FOREIGN KEY (group_id)
	  REFERENCES groups (group_id)
);

-- ex.3
INSERT INTO members
VALUES (DEFAULT, 'John', 'Smith', '334 Valencia St.', 'San Francisco', 'CA', '415-942-1901');
INSERT INTO members
VALUES (DEFAULT, 'Jane', 'Doe', '872 Chetwood St.', 'Oakland', 'CA', '510-123-4567');

INSERT INTO groups
VALUES (DEFAULT, 'Book Club');
INSERT INTO groups
VALUES (DEFAULT, 'Bicycle Coalition');

INSERT INTO members_groups
VALUES (1, 2);
INSERT INTO members_groups
VALUES (2, 1);
INSERT INTO members_groups
VALUES (2, 2);

SELECT g.group_name, m.last_name, m.first_name
FROM groups g
  JOIN members_groups mg
    ON g.group_id = mg.group_id
  JOIN members m
    ON mg.member_id = m.member_id
ORDER BY g.group_name, m.last_name, m.first_name;

-- ex.4
ALTER TABLE members
  ADD annual_dues   DECIMAL(5,2)    DEFAULT 52.50;
ALTER TABLE members
  ADD payment_date  DATE;

-- ex.5
ALTER TABLE groups
MODIFY group_name VARCHAR(50) NOT NULL UNIQUE;

INSERT INTO groups (group_name)
VALUES ('Book Club');


-- Task 1

use my_guitar_shop;

-- MGS Exercise 6-1
SELECT COUNT(*), SUM(tax_amount)
FROM orders;

-- MGS Exercise 6-2
SELECT category_name, 
COUNT(p.product_id) AS product_count, 
MAX(list_price) AS most_expensive_product
FROM categories c JOIN products p ON c.category_id = p.category_id
GROUP BY category_name
ORDER BY list_price;

-- MGS Exercise 6-6
SELECT product_name, SUM((oi.item_price - oi.discount_amount)*oi.quantity) AS product_total
FROM products p JOIN order_items oi ON p.product_id = oi.product_id
GROUP BY product_name WITH ROLLUP;

-- MGS Exercise 7-3
SELECT account_number, account_description
FROM general_ledger_accounts gl
WHERE NOT EXISTS
    (SELECT *
     FROM invoice_line_items
     WHERE account_number = gl.account_number)
ORDER BY account_number;

-- Task 2
use swexpert;
-- SWE exercise 1
SELECT Round(AVG(score), 1)
FROM evaluation
WHERE evaluatee_id = 105;

-- SWE exercies 2
SELECT COUNT(*) AS number_of_consultants , skill_id
FROM consultant
JOIN consultant_skill
ON consultant.c_id = consultant_skill.c_id
WHERE skill_id = 1;

-- SWE exercise 3



-- Task 3
use swexpert;
-- SWE exercies 1
ALTER TABLE project_consultant
ADD today_days int default 0;

UPDATE project_consultant
SET today_days = datediff(roll_off_date,roll_on_date);
SELECT ROW_COUNT() AS "UPDATE: rows updated";
SELECT * from project_consultant;
ALTER TABLE project_consultant
DROP today_days;

-- SWE exercies 2
DROP TABLE IF exists swexpert.evaluation_audit;
CREATE Table evaluation_audit
(
	audit_id INT PRIMARY KEY auto_increment,
    audit_e_id INT NOT NULL,
    audit_score INT,
    audit_user VARCHAR(20)
);

INSERT into evaluation_audit
values (default,100,90,NULL);
SELECT ROW_COUNT() AS "INSEERT: rows inserted";

SELECT * from evaluation_audit;

-- SWE exercies 3
UPDATE evaluation_audit
set audit_user = ""
where audit_user is null;

ALTER TABLE evaluation_audit
MODIFY audit_user VARCHAR(20) not null; 

ALTER TABLE evaluation_audit
ADD audit_date date default 0;

INSERT into evaluation_audit
values (default,100,95,USER(),SYSDATE());
SELECT ROW_COUNT() AS "INSEERT: rows inserted";

SELECT * from evaluation_audit;

INSERT into evaluation_audit
values (-1,100,99,null,null);
SELECT ROW_COUNT() AS "INSEERT: rows inserted";


-- SWE exercies 4
INSERT into project_skill
values (-1,null);
SELECT ROW_COUNT() AS "INSEERT: rows inserted";


-- SWE exercies 5
DELETE FROM consultant;
SELECT ROW_COUNT() AS "DELETE: rows deleted";