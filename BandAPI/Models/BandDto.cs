using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BandAPI.Entities;

namespace BandAPI.Models
{
    public class BandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string FoundedYearsAgo{ get; set; }
        public string MainGenre { get; set; }

    }
}