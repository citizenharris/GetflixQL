using System;

namespace Getflix.Data.Domain.Models
{
    public class Subtitles
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public Uri Url { get; set; }
    }
}