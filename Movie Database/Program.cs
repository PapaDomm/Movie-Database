using Movie_Database;
using System.ComponentModel;

List<Movie> movieList = new List<Movie>
{
    new Movie("Star Wars Episode 4", "Sci-Fi", 121, 1977),
    new Movie("Evil Dead", "Horror", 85, 1981),
    new Movie("Howls Moving Castle", "Ghibli", 119, 2004),
    new Movie("Cloverfield", "Sci-Fi", 85, 2008),
    new Movie("There Will Be Blood", "Western", 158, 2007),
    new Movie("For a Few Dollars More", "Western", 132, 1965),
    new Movie("Dune", "Sci-Fi", 156, 2021),
    new Movie("Spirited Away", "Ghibli", 125, 2001),
    new Movie("After the Dark", "Sci-Fi", 121, 1977),
    new Movie("Godzilla: King of the Monsters", "Kaiju", 132, 2019),
    new Movie("Shin Godzilla", "Kaiju", 120, 2016),
    new Movie("Phantom of the Opera", "Musical", 143, 2004),
    new Movie("Spy-Kids", "Family", 88, 2001),
    new Movie("Oppenheimer", "Thriller", 180, 2023),
    new Movie("Interstellar", "Sci-Fi", 169, 2014),
    new Movie("Inception", "Sci-Fi", 148, 2010)
};

//bool addNew = true;
//while(movieList.Count < 10 && addNew == true)
//{
//    Console.WriteLine("What is movie name, category, runtime, year released.... (if<10, cycle, if >= 10 would you like to add another movie?)");
//}

bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Here are our categories");
    Console.WriteLine();
    List<string> categories = new List<string>();
    int i = 1;
    foreach (Movie movie in movieList.DistinctBy(x => x.category).ToList().OrderBy(x => x.name))
    {
        Console.WriteLine($"{i}- {movie.category}");
        categories.Add(movie.category.ToLower());
        i++;
    }

    //Console.WriteLine();
    //for (int i = 0; i < categories.Count; i++)
    //{
    //    Console.WriteLine($"{i}- {categories[i]}");
    //}

    Console.WriteLine();
    Console.Write("Which one would you like to choose?: ");
    string category = categories[Validator.getValidInt(1, categories.Count) - 1];
    Console.WriteLine();

    foreach (Movie movie in movieList.Where(b => b.category.ToLower() == category).ToList().OrderBy(x => x.name))
    {
        movie.displayMovie();
    }

    runProgram = Validator.getContinue("Would you like to pick another category?");
    Console.Clear();
}

Console.WriteLine("Goodbye!");