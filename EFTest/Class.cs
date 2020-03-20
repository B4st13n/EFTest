using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    public class Item
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Composition> ChildCompositions { get; set; }

        public ICollection<Composition> ParentCompositions { get; set; }
    }

    public class Composition
    {
        public Guid Id { get; set; }

        public Guid ParentId { get; set; } // Id of Parent Item

        [ForeignKey(nameof(ParentId))]
        public Item Parent { get; set; }

        public Guid ChildId { get; set; } //  Id of Child Item

        [ForeignKey(nameof(ChildId))]
        public Item Child { get; set; }

        public int Ratio { get; set; } // Number of Child that compose the parent.
    }
}
