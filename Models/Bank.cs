using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace my_new_app.Models
{
    public class Bank
    {
        [Key]
        public int Id{get;set;}
        [MaxLength(50)]
        public string BankName{get;set;}
        public int RedMoney{get;set;}
        
        public ICollection<Spending_Detail> Spending_Details { get;set; }
      //  public List<Spending_Detail> OtherSpenDetails {set; get;}
    }
}