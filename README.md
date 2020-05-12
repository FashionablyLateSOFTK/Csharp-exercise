# Animals

![Tiger](https://i.pinimg.com/originals/ec/79/6c/ec796c953bdb1422affe2fb11eb7ac90.jpg)


>_**This is a fun program that you can use to invite animals, feed them and even make them sound!  Let's see...**_


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
|  Bear     |                     |  x           |                     |       |       x|
| Tiger     |                     |  x           |                     |       |       x|
| Wolf      |                     |  x           |                     |       |       x|

___
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

