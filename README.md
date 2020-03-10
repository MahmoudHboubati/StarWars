# StarWars

**How to run the project?**

first make sure you have *.net core 3.1* or higher, then use following commands on the root directory:

```
dotnet restore
dotnet run -p src/api
```

# Database requirements

## I am suggesting following changes on table:

**people table:**

- `eye_color, gender, hair_color, skin_color` should be stored in lookup tables like `eye_colors, genders, hair_colors,` and `skin_colors` and only reference it `people` table by ids.
- rename the table to be characters, it confuses as it has species not only humans.
- `average_lifespan` should contain only number, at least it should not be mixed.

**films table:**

- `producer` is a text field saving _comma separated values_, it is recommended to be save in another table like films_producers(film_id, producer_id) and link it to a new table for producers.

**planets table:**

- `climate` should be reference only and `planet_climate -> climate` should be created.
- `terrain` also need to have many to many relation tables structure, `planet -> planet_terrain <- terrain`.

**species table:**

- `classification, homeworld, language` and `designation` should be referenced from a primary table (one table for each).
- `hair_colors, eye_colors` many to many relations tables as it referees to possible colors.

**starships table:**

- `starship_class` should be referenced from primary table.

**transports table:**
- `consumables` is a descriptive field where we can't query by what it keeps!!!, better it can be a *timestamp* field, then we can operate on it.
- `cost_in_credits` data type should be number, crew should not contain an *'unknown'* value as it should be a number only, null can be considered as *'unknown'*.
- `manufacturer` should be referenced from a new primary table as it has repeated values, which we might need to rename later.
- `passengers` data type should be number of integer, should not contain *'n/a'* because it should be a number value.
