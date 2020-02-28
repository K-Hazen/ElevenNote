using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        //Adding a Guid would allow only the unique user to add/delete the category, without anyone can create, use, edit, and delete. You can also use it to limit certain functions like... you can create and edit but not delete. This is Guid stuff is conntected to identity roles (the folder we moved at the beginning). 

        //With migrations they do carry a history and so if you migrate and something doesn't work you can go back to a previous migrations

        //What is happening in a migration? What is migrating? - Sets up new database with the new columns etc. and then Migrating data from the old setup to the new setup
    }
}
