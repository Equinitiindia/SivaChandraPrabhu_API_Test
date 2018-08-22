using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDWebApi.Models;
using CRUDWebApi.Container;

namespace CRUDWebApi.Container
{
    public class AccountServiceContainer:IAccountContainer 
    {
        public IEnumerable<Account> Get()
        {
            var creditItems = Account.getCollections().ToList();
            return creditItems;
        }

        public Account Add(Account item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int _nextId = 1;
            item.ApplicationId = _nextId++;
            Account.getCollections().Add(item);
            return item;
        }

        public void Remove(int id)
        {
            Account.getCollections().RemoveAll(p => p.ApplicationId == id);
        }
        public bool Update(Account item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = Account.getCollections().FindIndex(p => p.ApplicationId == item.ApplicationId);
            if (index == -1)
            {
                return false;
            }
            Account.getCollections().RemoveAt(index);
            Account.getCollections().Add(item);
            return true;
        }
    }
}