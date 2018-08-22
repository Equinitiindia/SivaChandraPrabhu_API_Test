using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDWebApi.Models
{
    public class Account
    {
        public string Id { get; set; }
        public int ApplicationId { get; set; }
        public double Amount { get; set; }
        public string Summary { get; set; }        

        public static List<Account> getCollections()
        {
            List<Account> list = new List<Account>();

            list.Add(new Account
            {
                Id = "3f2b12b8-2a06-45b4-b057-45949279b4e5",
                ApplicationId = 111,
                Amount = 50.30,
                Summary = "Payment"              
            });
            list.Add(new Account
            {
                Id = "d2032222-47a6-4048-9894-11ab8ebb9f69",
                ApplicationId = 222,
                Amount = 10.25,
                Summary = "Payment"
            });
            list.Add(new Account
            {
                Id = "d8f156f3-bd57-49c3-9dcb-fcaaa52308f5",
                ApplicationId = 333,
                Amount = 23.45,
                Summary = "Payment"
            });
            list.Add(new Account
            {
                Id = "194f0d46-6b87-4b59-a73c-e543f035ae1a",
                ApplicationId = 444,
                Amount = 46.23,
                Summary = "Payment"
            });            
            return list;
        }
    }
}