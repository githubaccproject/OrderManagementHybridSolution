CREATE PROCEDURE [dbo].[GetCustomerOrders]
    @CustomerId INT
AS
BEGIN
    SELECT 
        o.OrderId,
        o.OrderDate,
        o.Amount
    FROM Orders o
    WHERE o.CustomerId = @CustomerId;
END
