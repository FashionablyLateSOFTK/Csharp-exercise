# Animals

![Tiger2](https://upload.wikimedia.org/wikipedia/commons/0/06/Makari_the_Tiger.jpg)

>_**This is a fun program that you can use to invite animals, feed them and even make them sound!  Let's see...**_

### Wild animals
A wild animal is an animal that is, well, wild. This means that it isn't tame and it lives on its own without any help from people. A wild animal finds its own food, shelter, water and all its other needs in a specific natural habitat. Habitat can be a field, woods, pond, wetland, prairie, park, or your yard. Wild animals make their home in both the city and the country. Wild animals are forexample tigers, bears and wolfs.
Wild animals therefore **hunt**. Hunting prey is not allowed with every attempt, which is why will animals often prey. In this program, wild animals succeed with a 60% chance to eat while hunting. So the wild animals are eating only when they are lucky in hunting.

### Tame animals
A tame animal is an animal that is relatively tolerant of human presence. Tameness may arise naturally (as in the case, for example, of island tameness) or due to the deliberate, human-directed process of training an animal against its initially wild or natural instincts to avoid or attack humans. Tame animals are man's best friends, such as dogs, cats, rabbits or even birds. Tame animals are dependent on human food. They know that the host gives them food at regular intervals and therefore they do not have to hunt like wild animals. Tame animals learn a few tricks, which this program introduces "**come here**".

### About this prject
_This project is made together 3 students from Centria: Heidi Keskitalo, Mathilda Nynäs and Daniel Tunér. In each section, we have helped and advised each other to make the program as effective as possible. We have worked well as a group._

**Here you can find our Trello -board:
[*Click*](https://trello.com/b/7vo5ac4i/team-fashionablylate)**


___
## What this program can do?

Here you can see what the animals can do:

|**Animals**|**Talk to the owner**|**Make Sound**|**Come to the owver**|**Eat**|**Hunt**|
| ----------|:-------------------:|:------------:|:-------------------:|:-----:|:------:|
|  Cat      |   X                 |    x         |       x             |  x    |        |
|  Dog      |   x                 |    x         |       x             |  x    |        |
|  Bird     |  x                  |  x           |  x                  |  x    |        |
|  Bear*     |                     |  x           |                     |   x   |       x|
| Tiger*     |                     |  x           |                     |    x  |       x|
| Wolf*      |                     |  x           |                     |     x |       x|


>*= Eat only when they have luky in Hunting
___

![Cat](https://i.imgur.com/9oGgtUg.jpg)

## Tree

Here is the tree of this program:

```
├── assets
│    ├── class_diagram_with_connections.png
│    └── Sequence-diagram.png
│
├── src
│    │
│    └── Fauna    
│	  ├── Animals
│         │       ├── Tame
│         │       │    ├── Bird.cs
│         │       │    ├── Cat.cs
│         │       │    ├── Dog.cs
│         │       │    └── ITame.cs
│         │       ├── Wild
│         │       │     ├── Bear.cs
│         │       │     ├── IWild.cs
│         │       │     ├── Tiger.cs
│	  │       │     └── Wolf.cs
│	  │       │ 
│	  │       └── Animals.cs 
│         │            
│         ├── Fauna.csproj
│         ├── Program.cs
│         └── TextInterface.cs
├── test
│    └── ExampleTests
│          ├── FaunaTests.cs
│          └──  FaunaTests.csproj│    
├── .gitignore         
│
│
└── README.md
```
____

## Class Diagram of this project

>In this Class Diagram both tame and wild animals inherit the abstract class Animal. The wild animals Wolf, Tiger and Bear all implement the interface IWild and the tame animals Dog, Cat and Bird implement the interface ITame. Both tame and wild animals implement the interface TextInterface.

![Class Diagram](https://raw.githubusercontent.com/FashionablyLateSOFTK/Csharp-exercise/master/assets/Class%20diagram%20with%20connections.png)

___
## Sequence Diagram of this project

>Here's how the program works. Main initially creates all the animal used in the program. It then asks if you want a list of animals or if you want to quit. 

>Then you can choose which animal functions you want to view and try different functions. 

>"Back" always takes you back in the program and "quit" ends the program.

![Sequence diagram](https://github.com/FashionablyLateSOFTK/Csharp-exercise/blob/master/assets/Sequence-diagram.png)

___

### Thank you for reading this before using the program.
