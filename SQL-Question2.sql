SELECT Customers.name
FROM Customers
LEFT JOIN Orders
ON Customers.id=Orders.customerId
WHERE Orders.customerId IS NULL
ORDER BY Customers.id