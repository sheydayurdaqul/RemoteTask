using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Task.Data.Model;
using Task.Service.ServiceModel;

namespace Task.Service.WebServices
{

   public class CurrencyService
    {
        public double getCurrency()
        {
            UnitofWork db = new UnitofWork();
            var client = new RestClient("http://api.fixer.io/latest?base=USD");
            var request = new RestRequest(Method.GET);
            var response = client.Execute<CurrencyModel>(request).Data;
            CurrencyRecord currncyRecord = new CurrencyRecord();
            currncyRecord.CurrencyEuro = Convert.ToInt32(response.rates.EUR);
            currncyRecord.CurrencyUsd = Convert.ToInt32(response.rates.EUR);
            db.CurrencyRecords.AddCurrencyRecord(currncyRecord);
            
            return 0;
        }
       
    }
}
