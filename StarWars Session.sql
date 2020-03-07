select  FilmTitle,
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
order by SUM(CharacterExist) desc
