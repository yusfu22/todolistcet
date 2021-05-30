using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CetToDoList.Models
{
    public class Catagory
    {
        
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual List<Catagory> Catagories { get; set; }
        
    }
}
