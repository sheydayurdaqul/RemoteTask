using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task.Data.Model
{
    public class CurrencyRecord:ModelBase
    {
        public CurrencyRecord()
        {

        }
        public int Id { get; set; }
        public double CurrencyUsd { get; set; }
        public int CurrencyEuro { get; set; }

    }
}