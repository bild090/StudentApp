using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentApp.Core.Models
{
    public class Level
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int LevelNumber { get; set; }
    }
}
