using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        //Adding a foreign Key... you need the "virtual type" then the addition of the string representation. Must have the categoryID to add the foreign key to the table 

        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

       
        //We want this authorization so that only the user can use the notes
        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
