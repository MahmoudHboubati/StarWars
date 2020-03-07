namespace DAL.Constants
{
    public class SqlQueries
    {
        public const string MOST_APPEARED_SPECIES = 
            @"select species.name, Max(appeared) Count from species
            INNER JOIN (
                select species.id, species.name, films_characters.film_id, Count(*) appeared from species
                    INNER JOIN species_people ON species_people.species_id = species.id
                    INNER JOIN films_characters ON species_people.people_id = films_characters.people_id
                    group by species.id, species.name, films_characters.film_id
            ) AS appeares ON appeares.id = species.id
            group by species.id, species.name";
    }
}
