using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CetToDoList.Models
{
    public class Todo
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a title")]
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength (1500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name ="Is Completed")]
        public bool IsCompleted { get; set; }
        [Display(Name = "Due Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CompletedDate { get; set; }
        public int Remaininghour
        {
            get
            {
                var RemainingTime = ( DueDate- DateTime.Now);
                return (int) RemainingTime.TotalHours;

             }
        }
        public int CatagoryId { get; set; }
        public virtual Catagory Catagory { get; set; }
        
    }
}
