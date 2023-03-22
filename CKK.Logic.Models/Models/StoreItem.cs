namespace CKK.Logic.Models;
using System;

public class StoreItem
{
    private Product _product;
    private int _quantity;
    
    public StoreItem(Product product, int quantity)
    {
        _product = product;
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public Product GetProduct()
    {
        return _product;
    }

    public SetProduct(Product product)
    {
        _product = product;
    }
}