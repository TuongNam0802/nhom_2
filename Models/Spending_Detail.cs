using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace my_new_app.Models
{
    // chi tiết thu chi
    public class Spending_Detail
    {
        [Key]
        public int Id{get;set;}
        public DateTime DateTime{get;set;}
        [MaxLength(100)]
        public string Note {get;set;}
        public int Status {get;set;}
        //tiền mặt hay chuyển khoản( int  0/1)
        // 0 là tiền mặt --- 1 là chuyển khoản
        public int UserId{get;set;}
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get;set; }
        public int SpendingId{get;set;}

        [ForeignKey("SpendingId")]
       // [InverseProperty("OtherSpending")]  
        public virtual Spending Spending { get;set; }
        public int BankId{get;set;}

        [ForeignKey("BankId")]
        public virtual Bank Bank { get;set; }
    }
}