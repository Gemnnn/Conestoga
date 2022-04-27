-- Assignment 05
-- Byounguk Min

-- Warm up: Textbook Exercise

-- Chapter 8 (pg.239)
use ap;
-- ex.1
SELECT invoice_total,
FORMAT(invoice_total, 1) AS invoice_total_format,
CONVERT(invoice_total, SIGNED) AS invoice_total_convert,
CAST(invoice_total AS SIGNED) AS invoice_total_cast
FROM invoices;

-- ex.2
SELECT invoice_date,
CAST(invoice_date AS DATETIME) AS invoice_date_full,
CAST(invoice_date AS CHAR(7)) AS invoice_date_year_month
FROM invoices;

-- Chapter 9 (pg.272-273)
use ap;
-- ex.1
SELECT invoice_total,
ROUND(invoice_total, 1) AS invoice_total_1,
ROUND(invoice_total, 0) AS invoice_total_0
FROM invoicesl;

-- ex.2
use ex;
SELECT start_date, 
DATE_FORMAT(start_date, '%b/%d/%y') AS format1, 
DATE_FORMAT(start_date, '%c/%e/%y') AS format2, 
DATE_FORMAT(start_date, '%l:%i %p') AS twelve_hour,
DATE_FORMAT(start_date, '%c/%e/%y %l:%i %p') AS format3 
FROM date_sample;

-- ex.3
use ap;
SELECT vendor_name,
    UPPER(vendor_name) AS vendor_name_upper,
    vendor_phone,
    SUBSTRING(vendor_phone, 11) AS last_digits,
    REPLACE(REPLACE(REPLACE(vendor_phone, '(', ''), ') ', '.'), '-', '.') AS phone_with_dots, 
    SUBSTRING(vendor_name, 
        LOCATE(' ', vendor_name),
        LOCATE(' ', vendor_name, LOCATE(' ', vendor_name) + 1) - LOCATE(' ', vendor_name))
        AS second_word
FROM vendors;

-- ex.4
use ap;
SELECT invoice_number,
       invoice_date,
       DATE_ADD(invoice_date, INTERVAL 30 DAY) AS date_plus_30_days,
       payment_date,
       DATEDIFF(payment_date, invoice_date) AS days_to_pay,
       MONTH(invoice_date) AS "month",
       YEAR(invoice_date) AS "year"
FROM invoices
WHERE invoice_date > '2014-04-30' AND invoice_date < '2014-06-01';

-- Task 1

-- Q1. exercise 8-1
use my_guitar_shop;
SELECT list_price, discount_percent,
FORMAT(list_price, 2) AS list_price_2,
CAST(discount_percent AS SIGNED) AS discount_percent_integer,
ROUND(list_price * (discount_percent/100), 2) AS discount_amount,
DATE_FORMAT(date_added, '%m/%d') AS month_day_added
FROM products;

-- Q2. exercise 9-2
use my_guitar_shop;
SELECT order_date,
DATE_FORMAT(order_date, '%Y') AS order_date_4,
DATE_FORMAT(order_date, '%b-%d-%Y') AS format1,
DATE_FORMAT(order_date, '%H:%i:%S %p') AS format2,
DATE_FORMAT(order_date, '%c/%e/%y %H:%i') AS format3
FROM orders;

-- Task 2
use swexpert;

-- Q1. SWE Ecercise1
SELECT 
CONCAT_WS(' ', c_first, c_last) full_name,
ROUND(AVG(score), 2)
FROM consultant
JOIN evaluation 
ON consultant.c_id = evaluation.e_id;


-- Q2. SWE Exercise2
SELECT 
RPAD(p_id, 4, ' ') AS p_id,
RPAD(c_id, 4, ' ') AS c_id,
LPAD(TRUNCATE(DATEDIFF(roll_off_date,roll_on_date) / 30.4, 0), 6, ' ') AS months
FROM project_consultant
ORDER BY p_id;
