using Microsoft.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Curator : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [NotNull]
        public int? GroupId { get; set; }

        public virtual Group Group {  get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string Name {  get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        public override bool IsValid()
        {
            if (GroupId == null)
                return false;

            if (Name == null)
                return false;

            if (Email == null)
                return false;

            if (!StringExtensions.IsEmail(Email))
                return false;

            if (Name.Length > 150 || Name.Length < 2)
                return false;

            return true;
        }
    }
}
