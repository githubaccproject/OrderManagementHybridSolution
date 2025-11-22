using System.Collections.Generic;
namespace OrderManagement.Domain.Entities;
public class Customer {
    public int CustomerId {get;set;}
    public string Name {get;set;} = "";
    public string Email {get;set;} = "";
    public List<Order> Orders {get;set;} = new();
}
