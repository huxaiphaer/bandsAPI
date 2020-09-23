using System;
using BandAPI.Entities;

namespace BandAPI.Models
{
    public class AlbumsDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid BandId { get; set; }
    }
}