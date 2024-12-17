using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CKK.Logic.Models;

public class Store : Entity, IStore
{
    public int _id { get; set; }
    public string _name { get; set; }
    private List<StoreItem> Item = new List<StoreItem>();
    public int GetId()
    {
        return _id;
    }
    public void SetId(int id)
    {
        _id = id;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public StoreItem AddStoreItem(Product prod, int quantity)
    {
        if (quantity <= 0)
        {
            throw new InventoryItemStockTooLowException();
        }
        StoreItem temp = new StoreItem(prod, quantity);

        var st = FindStoreItemById(prod.Id);

        if (st != null)
        {
            st.Quantity = st.Quantity + quantity;
            return st;
        }
        Item.Add(temp);
        return temp;



    }
    public StoreItem RemoveStoreItem(int id, int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        var st = FindStoreItemById(id);
        if (st != null)
        {
            if (st.Quantity - quantity > 0)
            {
                st.Quantity = st.Quantity - quantity;
                return st;
            }
            if (st.Quantity - quantity <= 0)
            {
                st.Quantity = 0;

            }
            return st;
        }
        throw new ProductDoesNotExistException();



    }
    public List<StoreItem> GetStoreItems()
    {
        return Item;
    }
    public StoreItem FindStoreItemById(int id)
    {
        if (id < 0)
        {
            throw new InvalidIdException();
        }
        for (int i = 0; i < Item.Count(); i++)
        {
            if (Item[i].Product.Id == id)
            {
                return Item[i];
            }
         
        }
        return null;
    }
    public StoreItem DeleteStoreItem(int id)
    {
        var RemoveItem = FindStoreItemById(id);
        if (RemoveItem != null)
        {
            
            
                RemoveItem.Quantity = 0;
                Item.Remove(RemoveItem);
                return RemoveItem;
            
            
        }
        return null;
    }
}