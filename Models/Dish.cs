// For each table we want to work with, we will create an associated Model class
// Model classes such as these, that bear the responsibility of representing an entry in a database table are typically referred to as an "Entity"
// In this Entity class, we will provide Auto-Implemented Properties that will be used by Entity Framework to "map" to Columns in the associated table.
// The name and type of each one of these properties will need to match the name and type of the table column they represent.
using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dish
    {
        // auto-implemented properties need to match the columns in your table
        // the [Key] attr is used to mark the Model property being used for your table's Primary Key
        [Key]
        [Required]
        public int DishId { get; set;}

        // MySQL VARCHAR and TEXT types can be represented by a string
        [Required(ErrorMessage = "Name of dish is required!")]
        [Display(Name = "Name of Dish")]
        public string Name { get; set;}

        [Required(ErrorMessage = "Chef's name is required!")]
        [Display(Name = "Chef's Name")]
        public string Chef { get; set;}

        [Required(ErrorMessage = "Please select between 1-5.")]
        [Range(1,6)]
        public int Tastiness { get; set;}

        [Required(ErrorMessage = "Please enter amount of calories of your dish.")]
        [Range(1,10000)]
        [Display(Name = "# of Calories")]
        public int Calories { get; set;}
        
        [Required(ErrorMessage = "Please describe your dish in a short summary.")]
        public string Description { get; set;}

        // The MySQL DATETIME type can be represented by a DateTime
        [Required]
        public DateTime CreatedAt { get; set;} = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set;} = DateTime.Now;
    }
}