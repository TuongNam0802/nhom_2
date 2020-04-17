using System;
using System.ComponentModel.DataAnnotations;
namespace my_new_app.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public DateTime CreatedTime { get; set; }

        public bool Important { get; set; }

        public bool Checked { get; set; }
    }
}