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

        [NotNull]
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        [NotNull]
        public string Name { get; set; } = "";

        [NotNull]
        public int Age { get; set; }
    }
}
