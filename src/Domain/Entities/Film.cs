﻿using System;

namespace Domain.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Director { get; set; }
        public DateTime Edited { get; set; }
        public int EpisodeId { get; set; }
        public string OpeningCrawl { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
    }
}
