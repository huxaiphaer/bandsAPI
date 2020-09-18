using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BandAPI.Entities
{
    public class Album
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Title { get; set; }

        [MaxLength(400)]
        public string Description { get; set; }

        [ForeignKey("BandId")]
        public Band Band { get; set; }
        public Guid BandId { get; set; }
    }
}
