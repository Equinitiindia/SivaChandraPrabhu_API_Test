using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUDWebApi.Models;
using CRUDWebApi.Container;

namespace CRUDWebApi.Controllers
{
    public class AccountServiceController : ApiController
    {
        private readonly IAccountContainer objAccount;

        public AccountServiceController()
        {
            objAccount = new AccountServiceContainer();
        }

        
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            var items = objAccount.Get();
            return items;
        }

        [HttpPost]
        public Account Add(Account items)
        {
           var item = objAccount.Add(items);
           return item;
        }

        [HttpPut]
        public void Update(int id, Account item)
        {
            item.ApplicationId = id;
            var Existitem = objAccount.Get().Where(X => X.ApplicationId == id).FirstOrDefault();
            if (Existitem != null)
            {
                Existitem.Id = item.Id;
                Existitem.Amount = item.Amount;
                Existitem.Summary = item.Summary;
            }
            else
            {                
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var item = objAccount.Get().Where(X => X.ApplicationId == id).FirstOrDefault();
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            objAccount.Remove(id);
        }
    }
}
