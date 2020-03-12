using System.Collections.Generic;
using Domain.Entities;
using GraphQL.Types;

namespace Api.GraphQL.Models
{
    public class FilmQLDto : ObjectGraphType<Film>
    {
        public FilmQLDto()
        {
            Field(x => x.Id);
            Field(x => x.Created);
            Field(x => x.Director);
            Field(x => x.Edited);
            Field(x => x.EpisodeId);
            Field(x => x.OpeningCrawl);
            Field(x => x.Producer);
            Field(x => x.ReleaseDate);
            Field(x => x.Title);
        }
    }
}
