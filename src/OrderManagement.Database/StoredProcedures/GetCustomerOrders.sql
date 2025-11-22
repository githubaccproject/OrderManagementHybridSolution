
CREATE PROCEDURE [dbo].[GetCustomerOrders]
(
    @CustomerId INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT o.OrderId, o.OrderDate, o.Amount
    FROM Orders o
    WHERE o.CustomerId = @CustomerId;
END
