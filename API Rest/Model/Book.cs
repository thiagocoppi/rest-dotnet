using System;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Model.Base;

namespace WebApplication1.Model
{
    public class Book : BaseEntity
    {
        [Column("author")]
        public string author { get; set; }
        [Column("launchdate")]
        public DateTime lauchTime { get; set; }
        [Column("price")]
        public decimal price{ get; set; }
        [Column("title")]
        public string title { get; set; }

    }
}
