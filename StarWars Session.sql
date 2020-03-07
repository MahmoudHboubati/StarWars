select  planets.name,
        count(people.id),
        STRING_AGG(people.name + ' - ' +  species.name , ',')
from planets
    inner join films_planets on planets.id = films_planets.planet_id
    inner join films_characters on films_planets.film_id = films_characters.film_id
    inner join people on films_characters.people_id = people.id
    inner join vehicles_pilots on people.id = vehicles_pilots.people_id
    inner join species_people on people.id = species_people.people_id
    inner join species on species_people.species_id = species.id
group by planets.name, species.name
order by count(people.id) desc

