# Animals

![Tiger2](https://upload.wikimedia.org/wikipedia/commons/0/06/Makari_the_Tiger.jpg)

>_**This is a fun program that you can use to invite animals, feed them and even make them sound!  Let's see...**_

### Wild animals
A wild animal is an animal that is, well, wild. This means that it isn't tame and it lives on its own without any help from people. A wild animal finds its own food, shelter, water and all its other needs in a specific natural habitat. Habitat can be a field, woods, pond, wetland, prairie, park, or your yard. Wild animals make their home in both the city and the country. Wild animals are forexample tigers, bears and wolfs.
Wild animals therefore **hunt**. Hunting prey is not allowed with every attempt, which is why will animals often prey. In this program, wild animals succeed with a 60% chance to eat while hunting. So the wild animals are eating only when they are lucky in hunting.

### Tame animals
A tame animal is an animal that is relatively tolerant of human presence. Tameness may arise naturally (as in the case, for example, of island tameness) or due to the deliberate, human-directed process of training an animal against its initially wild or natural instincts to avoid or attack humans. Tame animals are man's best friends, such as dogs, cats, rabbits or even birds. Tame animals are dependent on human food. They know that the host gives them food at regular intervals and therefore they do not have to hunt like wild animals. Domestic animals learn a few tricks, which this program introduces "**come here**".

### About this prject
This project is made together 3 students from Centria: Heidi Keskitalo, Mathilda Nynäs and Daniel Tunér.

**Here you can find our Trello -board:
[*Klik*](https://trello.com/b/7vo5ac4i/team-fashionablylate)**


___
## What this program can do?

So here you can see what the animals can do:

|**Animals**|**Talk to the owner**|**Make Sound**|**Come to the owver**|**Eat**|**Hunt**|
| ----------|:-------------------:|:------------:|:-------------------:|:-----:|:------:|
|  Cat      |   X                 |    x         |       x             |  x    |        |
|  Dog      |   x                 |    x         |       x             |  x    |        |
|  Bird     |  x                  |  x           |  x                  |  x    |        |
|  Bear     |                     |  x           |                     |   x   |       x|
| Tiger     |                     |  x           |                     |    x  |       x|
| Wolf      |                     |  x           |                     |     x |       x|

___

![Cat](https://i.imgur.com/9oGgtUg.jpg)

## Tree

Here is the tree of this program:

```
├── assets
│    └── class_diagram_with_connections.png
│ 
├── src
│    │
│    └── Fauna    
│	      ├── Animals
│       │       ├── Tame
│       │       │    ├── Bird.cs
│       │       │    ├── Cat.cs
│       │       │    ├── Dog.cs
│       │       │    └── ITame.cs
│       │       ├── Wild
│       │       │     ├── Bear.cs
│       │       │     ├── IWild.cs
│       │       │     ├── Tiger.cs
│	  	  │       |     └── Wolf.cs
│	   	  |       │ 
│	      │       └── Animals.cs 
│       │            
│       ├── Fauna.csproj
│       └── Program.cs
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

![Class Diagram](https://github.com/FashionablyLateSOFTK/Csharp-exercise/blob/master/assets/class_diagram_with_conections.png
)


## Sequense Diagram of this project

