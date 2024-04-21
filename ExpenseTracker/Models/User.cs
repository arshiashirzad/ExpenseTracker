using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models;

public class User
{
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(255)")]
        public string Username { get; set; }= string.Empty;
        [Column]
        public byte[] PasswordHash { get; set; } 
        [Column(TypeName = "nvarchar(255")] 
        public byte[] PasswordSalt  { get; set; }
}