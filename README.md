# RoboDog

## Goal of the project

* Create a new ASP.NET Core project.
* Work with HTTP requests.
    * Route with ASP.NET Core.
    * Respond differently, based on the HTTP request method value.
* Organize project into folders.

## Tasks

### *Create environment*

1. An ASP.NET MVC project is created.
2. The project contains the automatically generated <span style="color: yellow">Program</span> class.

### *Create a model to describe a dog*

The application can model a dog by its age, name, and breed. This class is located in the <span style="color: yellow">Models</span> folder.

1. The application has a model class for dog with properties of age, name, and breed.
2. The model class is located in a <span style="color: yellow">Models</span> folder.
3. The <span style="color: yellow">Breed</span> property has its own type, without using strings.

### *Logic for creating dogs*

There is a <span style="color: yellow">DogCreator</span> class in the <span style="color: yellow">Services</span> folder, which contains a <span style="color: yellow">@CreateRandomDog()</span> method.

1. The <span style="color: yellow">@CreateRandomDog()</span> method returns a new instance of the <span style="color: yellow">Dog</span> class with randomized values for the name, age, and breed properties.

### *Dog storage*

*Who let the dogs out?* Let's shelter them! Create a <span style="color: yellow">DogStorage</span> class for handling the dogs.

1. Dogs are stored in a list.
2. A dog can be added to the list.
3. A randomly generated dog can be added to the list.
4. The list of all dogs can be returned.
5. A dog can be updated.

### *GET a pet!*

Create an api controller <span style="color: yellow">DogController</span> class and a mvc controller <span style="color: yellow">HomeController</span> in the <span style="color: yellow">Controllers</span> folder to let others interact with the dogs. This controller must contain methods to get all dogs, create a random dog, add a specific dog, or update the dog. To achieve this behavior, this class must not contain the full logic in itself. Instead, it must be wired with another class responsible for such services.

1. The <span style="color: yellow">DogController</span> class contains the <span style="color: yellow">[ApiController]</span> attribute.
2. The classes are dependent on the <span style="color: yellow">DogStorage </span> service.
3. A controller has a GET endpoint for returning all stored dogs.
4. A controller has a POST endpoint for randomly creating a dog.
5. A controller has a GET endpoint for adding a new dog.
6. A controller has a PUT endpoint for updating the selected dog.
7. A controller has a DELETE endpoint for delete the required dog.

### *Check your dogs*

Create some views to visualize the data you interact with.