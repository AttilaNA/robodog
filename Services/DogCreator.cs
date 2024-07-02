namespace robodog;

public static class DogCreator
{
    private static readonly List<string> DogNames = new List<string> {"Balu", "Benji", "Hektor", "Zizi", "Bambo"};

    public static readonly List<string> Breeds = new List<string> {"Mix", "German shepherd", "Small", "Big", "Medium"};

    public static Dog CreateRandomDog(){
        return new Dog(){
            Age = new Random().Next(1, 10),
            Name = DogNames[new Random().Next(DogNames.Count)],
            Breed = new Breed(){
                Name = Breeds[new Random().Next(Breeds.Count)]
            }
        };
    }
}
