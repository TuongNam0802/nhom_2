using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace my_new_app.Models
{
    public class Spending 
    {
        [Key]
        public int Id{get;set;}
        [MaxLength(50)]
        public string Purpose{get;set;}
        public int Money{get;set;}
        public int revenue_and_expenditure{get;set;}
        // 1 là thu, 0 là chi
        public ICollection<Spending_Detail> Spending_Details { get;set; }
        public DateTime DateTime { get; internal set; }
        //  public List<Spending_Detail> OtherSpending {set; get;}

    }
}