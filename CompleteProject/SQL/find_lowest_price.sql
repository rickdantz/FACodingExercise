SELECT 
    pro_name, 
    pro_price
FROM
    Products
WHERE
    pro_price = (
        SELECT 
            MIN(pro_price)
        FROM
            Products);