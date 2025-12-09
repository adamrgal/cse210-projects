// File: Customer.cs
using System;

// Class responsible for tracking customer details (name and address).
public class Customer
{
    private string _name;
    private Address _address; // Address is a composition member

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInUSA()
    {
        return _address.IsUSA();
    }

    public Address GetAddress()
    {
        return _address;
    }
}