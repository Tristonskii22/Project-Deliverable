﻿using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
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
            InventoryItemStockTooLowException.InventoryStockTooLow();
        }
        StoreItem temp = new StoreItem(prod, quantity);

        var st = FindStoreItemById(prod.Id);

        if (st != null)
        {
            st.SetQuantity(st.GetQuantity() + quantity);
            return st;
        }
        Item.Add(temp);
        return temp;



    }
    public StoreItem RemoveStoreItem(int id, int quantity)
    {
        if (quantity <= 0)
        {
            ProductDoesNotExistException.ProductDoesNotExist();
        }

        var st = FindStoreItemById(id);
        if (st != null)
        {
            if (st.GetQuantity() - quantity > 0)
            {
                st.SetQuantity(st.GetQuantity() - quantity);
                return st;
            }
            if (st.GetQuantity() - quantity <= 0)
            {
                st.SetQuantity(0);

            }
        }
        throw new ArgumentOutOfRangeException();



    }
    public List<StoreItem> GetStoreItems()
    {
        return Item;
    }
    public StoreItem FindStoreItemById(int id)
    {
        for (int i = 0; i < Item.Count(); i++)
        {
            if (Item[i].GetProduct().Id == id)
            {
                return Item[i];
            }
            else if(id < 0)
            {
                InvalIdIdException.EntityId();
            }
        }
        return null;
    }
}