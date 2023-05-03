using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MoviesApp.Models
{
    public partial class Film
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Metascore { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string ImdbId { get; set; }
        public string Type { get; set; }
        public string Response { get; set; }
        public string Images0 { get; set; }
        public string Images1 { get; set; }
        public string Images2 { get; set; }
        public string Images3 { get; set; }
        public string Images4 { get; set; }
        public int? TotalSeasons { get; set; }
        public string ComingSoon { get; set; }
    }
}
