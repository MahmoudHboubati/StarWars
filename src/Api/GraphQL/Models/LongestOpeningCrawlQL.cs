using Domain.Entities;
using GraphQL.Types;

namespace Api.GraphQL.Models
{
    public class LongestOpeningCrawlQL : ObjectGraphType<LongestOpeningCrawl>
    {
        public LongestOpeningCrawlQL()
        {
            Field(x => x.FilmTitle);
            Field(x => x.Count);
        }
    }
}
