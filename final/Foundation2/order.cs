// File: Order.cs
using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const double ShippingCostUSA = 5.00;
    private const double ShippingCostInternational = 35.00;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double productSubtotal = 0;
        foreach (Product product in _products)
        {
            productSubtotal += product.GetTotalCost();
        }

        // Determine shipping cost based on customer's location
        double shippingCost = _customer.IsInUSA() ? ShippingCostUSA : ShippingCostInternational;

        return productSubtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product product in _products)
        {
            label += $"Name: {product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---\n";
        label += $"Customer: {_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddressString();
        return label;
    }
}