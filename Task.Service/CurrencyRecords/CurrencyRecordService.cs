using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data;
using Task.Data.Model;
using Task.Data.Repositories;

namespace Task.Service
{
  
   public class CurrencyRecordService
    {
        private EFRepository<CurrencyRecord> _currencyRecordRepository;

        public CurrencyRecordService(EFBlogContext EFBlogContext)
        {
            _currencyRecordRepository= new EFRepository<CurrencyRecord>(EFBlogContext);
        }
        public void AddCurrencyRecord(CurrencyRecord record)
        {
             _currencyRecordRepository.Add(record);
           

        }
    }
}
