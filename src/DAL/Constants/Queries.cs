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

        public const string MOST_VEHICLE_PILOTS_IN_SPECIES =
            @"select    A.Name PlanetName,
                    SUM(A.Count) Count,
                    STRING_AGG(A.PeopleName + ' - ' + A.SpeciesName , ',') Pilots
        from (
            select 
                planets.name Name,
                count(people.id) Count,
                people.name PeopleName,
                species.name SpeciesName
            from vehicles_pilots
            inner join people on vehicles_pilots.people_id = people.id
            inner join films_characters on people.id = films_characters.people_id
            inner join species_people on people.id = species_people.people_id
            inner join species on species.id = species_people.species_id
            inner join films_planets on films_planets.film_id = films_characters.film_id
            inner join planets on planets.id = films_planets.planet_id
            group by planets.name, people.name, species.name
        ) as A
        group by A.Name";

        public const string LONGEST_OPENING_CRAWLS =
            @"select    FilmTitle,
                    SUM(CharacterExist) as Count
                    from (
                        select
                        films.title as FilmTitle,
                        case
                            when CHARINDEX(people.name, films.opening_crawl) > 0 then 1
                            else 0 end as CharacterExist
                        from films
                            inner join films_characters on films_characters.film_id = films.id
                            inner join people on people.id = films_characters.people_id
                    ) as characters_in_opening_crawls
                    group by FilmTitle
                    order by SUM(CharacterExist) desc";
    }
}
