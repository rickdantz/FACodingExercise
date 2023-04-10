SELECT a.ord_no, a.purch_amt, b.cust_name, b.city 
FROM Orders a
JOIN Customers b
ON a.customer_id = b.customer_id
WHERE a.purch_amt BETWEEN 500 AND 2000;