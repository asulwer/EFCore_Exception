using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestModel.Models
{
    [Serializable]
    public partial class item
    {
        public item()
        {
        }

        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public DateTime TS { get; set; }
    }
}
