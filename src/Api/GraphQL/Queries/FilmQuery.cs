using Api.GraphQL.Models;
using AutoMapper;
using Domain.Services.Films;
using GraphQL.Types;

namespace Api.GraphQL.Queries
{
    public class FilmQuery : ObjectGraphType
    {
        public FilmQuery(IFilmProvider provider, IMapper mapper)
        {
            Field<ListGraphType<FilmQLDto>>("films",
                resolve: (context) =>
                {
                    return provider.Get();
                }
            );

            FieldAsync<LongestOpeningCrawlQL>("longestOpeningCrawl",
                resolve: async (context) =>
                {
                    return await provider.GetLongestOpeningCrawl();
                }
            );
        }
    }
}
