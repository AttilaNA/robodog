namespace robodog;

public class DogStorage
{
    public List<Dog> Dogs {get; set;}

    public DogStorage()
    {
        Dogs = new List<Dog>();
    }

    public void AddRandomDog()
    {
        Dogs.Add(DogCreator.CreateRandomDog());
    }

    public void AddDogFromUserInput(string name, int age, string breed)
    {
        Dogs.Add(
            new Dog(){
            Age = age,
            Name = name,
            Breed = new Breed(){
                Name = breed
            }
            }
        );
    }

    public void UpdateDog(UpdateDog dogToupdate)
    {
        var dogs = new List<Dog>(Dogs);
        foreach (var dog in dogs)
        {
            if (dog.Age == dogToupdate.OldAge && dog.Name == dogToupdate.OldName && dog.Breed.Name == dogToupdate.OldBreed.Name)
            {
                Dogs.Remove(dog);
                AddDogFromUserInput(dogToupdate.NewName, dogToupdate.NewAge, dogToupdate.NewBreed.Name);
                return;
            }
        }
    }

    public void DeleteDog(Dog dogToDelete){
        var dogs = new List<Dog>(Dogs);
        foreach (var dog in dogs)
        {
            if (dog.Age == dogToDelete.Age && dog.Name == dogToDelete.Name && dog.Breed.Name == dogToDelete.Breed.Name)
            {
                Dogs.Remove(dog);
                return;
            }
        }
    }
}
