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
    public class Student : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id {  get; set; }

        [Required]
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public uint Age { get; set; }
    }
}
