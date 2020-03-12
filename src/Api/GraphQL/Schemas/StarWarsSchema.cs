using Api.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;

namespace Api.GraphQL.Schemas
{
    public class StarWarsSchema : Schema
    {
        public StarWarsSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<FilmQuery>();
        }
    }
}
