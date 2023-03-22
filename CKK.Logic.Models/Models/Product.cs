namespace CKK.Logic.Models;
using System;

public class Product
{
	private int _id;
	private string _name;
	private decimal _price;

	public int GetId()
	{
		return _id;
	}

	public SetId(int id)
	{
		_id = id;
	}

	public GetName()
	{
		return _name;
	}

	public SetName(string name)
	{
		_name = name;
	}

	public decimal GetPrice()
	{
		return (decimal)_price;
	}

	public SetPrice(decimal price)
	{
		_price = price;
	}
}
