using CKK.Logic.Models;
using System;

public class Store
{
    private int _id;
    private string _name;
    private Product _product1;
    private Product _product2;
    private Product _product3;

    public int GetId()
    {
        return _id;
    }

    public SetId(int id)
    {
        _id = id;
    }

    public string GetName()
    {
        return _name;
    }

    public SetName(string name)
    {
        _name = name;
    }

    public AddStoreItem(Product prod)
    {
        if (_product1 = 0)
        {
            _product1 = prod;
        }
        if (_product2 = 0)
        {
            _product2 = prod;
        }
        if (_product3 = 0)
        {
            _product3 = prod;
        }
        else
        {
            return prod;
        }
    }

    public RemoveStoreItem(int productNum)
    {
        if (productNum == _product1)
        {
            _product1 = 0;
        }
        if (productNum == _product2)
        {
            _product2 = 0;
        }
        if (productNum == _product3)
        {
            _product3 = 0;
        }
        else
        {
            return;
        }
    }

    public Product GetStoreItem(int productNum)
    {
        if (productNum == _product1)
        {
            return _product1;
        }
        if (productNum == _product2)
        {
            return _product2;
        }
        if (productNum == _product3)
        {
            return _product3;
        }
        else
        {
            return null;
        }
    }

    public Product FindStoreItemById(int id)
    {
        if (id == _product1)
        {
            return _product1;
        }
        if (id == _product2)
        {
            return _product2;
        }
        if (id == _product3)
        {
            return _product3;
        }
        else
        {
            return null;
        }
    }
}
