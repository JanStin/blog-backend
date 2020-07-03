using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() => DateAdded = DateTime.UtcNow;

        [Required]
        public int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }
        
        public virtual string ImagePath { get; set; }

        public virtual string Article { get; set; }

        public virtual string MetaTitle { get; set; }

        public virtual string MetaDescription { get; set; }

        public virtual string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
