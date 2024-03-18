using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;
using System.Numerics;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ExpenseTracker.Models;

public class Category
{
    [Key] 
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; } = "";
    [Column(TypeName ="nvarchar(255)")]
    public string Icon { get; set; } = "";
    [Column(TypeName ="nvarchar(255)")]
    public string Type { get; set; } = "Expense";
    [NotMapped]
    public string? TitleWithIcon
    {
        get
        {
            return this.Icon + " " + this.Title;
        }
    }
}