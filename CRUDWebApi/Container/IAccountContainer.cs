using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using CRUDWebApi.Models;

namespace CRUDWebApi.Container
{
    public interface IAccountContainer
    {
        IEnumerable<Account> Get();
        Account Add(Account credit);
        void Remove(int id);
        bool Update(Account item);
    }
}
