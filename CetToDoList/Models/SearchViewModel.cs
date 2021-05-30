using System;
using System.Collections.Generic;

namespace CetToDoList.Models
{
    public class SearchViewModel
    {
        public string SearchText { get; set; }
        public bool ShowAll { get; set; }
        public bool DesSearch { get; set; }
        public List<Todo> Result { get; set;  }
        public List<Catagory> Abcd { get; set; }
    }
}
