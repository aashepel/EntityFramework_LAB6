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
    public class Group : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public int CuratorId { get; set; }

        public virtual Curator Curator { get; set; }
        
        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
