using ExportToExcel.Attributes;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.UserAggregate
{
    [Table("Users")]
    [SpreadSheet(nameof(User), typeof(User))]
    public class User : IdentityUser<string>
    {
        public User() : base()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Column(nameof(Id))]
        [SpreadSheetColumn(nameof(Id), 1)]
        public override string Id { get; set; }

        [Column(nameof(FirstName))]
        [SpreadSheetColumn("First Name", 2)]
        public string FirstName { get; set; }

        [Column(nameof(LastName))]
        [SpreadSheetColumn("Last Name", 3)]
        public string LastName { get; set; }
    }
}
