namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        /*
        //Example with a list return
        List<Pizza> specials = new();

        specials.AddRange(new List<Pizza>
        {
            new Pizza { Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegetarian = true, Vegan = false},
            new Pizza { Name = "Buffalo chicken", Price =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Vegetarian = true, Vegan = false},
            new Pizza { Name = "Veggie Delight", Price =  11.5M, Description = "It's like salad, but on a pizza", Vegetarian = true, Vegan = false},
            new Pizza { Name = "Margherita", Price =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil", Vegetarian = true, Vegan = false},
            new Pizza { Name = "Basic Cheese Pizza", Price =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", Vegetarian = true, Vegan = false},
            new Pizza { Name = "Classic pepperoni", Price =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", Vegetarian = true, Vegan = false}               
        });
        
        
        return Task.FromResult<Pizza[]>(specials.ToArray());

        */
        //Example returning array.

        var specials = new Pizza[]
        {
           /* new Pizza() { Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegetarian = true, Vegan = false},
            new Pizza() { Name = "Buffalo chicken", Price =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Vegetarian = true, Vegan = false},
            new Pizza() { Name = "Veggie Delight", Price =  11.5M, Description = "It's like salad, but on a pizza", Vegetarian = true, Vegan = false},
            new Pizza() { Name = "Margherita", Price =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil", Vegetarian = true, Vegan = false},
            new Pizza() { Name = "Basic Cheese Pizza", Price =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", Vegetarian = true, Vegan = false},
            new Pizza() { Name = "Classic pepperoni", Price =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", Vegetarian = true, Vegan = false},               
        */
        };

        //retuning in a task as we have stubed data - if this were a a real API
        // i would assume you would await the result... 
        return Task.FromResult<Pizza[]>(specials);

    }
}