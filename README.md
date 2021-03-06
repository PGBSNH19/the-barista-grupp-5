# Project 1 - The Barista
In this first project should you be working with what have been discussed regarding OOP in the theory for this lecture.

You should work in the group during the second half of the lecture.

On the start of the following lecture are your group going to present (a mini-presentation) the key points of you solution. And the rest of the class will give a points for the solution.

You need:

* One and only one, computer
* A stopwatch
* A yellow hat for the spy
* A green hat for the driver

Work with pair programming, one driver, 10 min per driver, driver wears a green hat, spy wears an yellow hat.

Everybody in the group is driver on turn. The last thing the drives does before leaving the keyboard to the next driver is to perform a commit and push of the code to GitHub. The comment should have the following comment "Driver @Github-username".

## Team

The team consist of 3 to 4 persons, with the following roles:

- **Driver**, the one sitting in front of the computer, and the only one using the keyboard and mouse, wears a green hat
- **Spy**, when signal is given should this person spy on another team
- **Timekeeper**, has a stopwatch and makes sure the team switch places as close to 10 min as possible and that the spy only spies the allowed time
- **Co-driver** (only for teams of four), everybody is in theory co-drivers and helps the driver. The term is taken from Rally where the co-driver keeps track on the track and the driver is responsible of steering the car.

The team rotate roles every 10 minutes, following this pattern:

* Spy becomes Driver
* Timekeeper becomes Spy
* Driver becomes Timekeeper, in case of four team members will the Driver become co-driver, and the co-driver become Timekeeper.

The timing is important as the team will retrieve penalty points for late or early rotation (measured on the git commit/push).

## Spying

When the signal is given should all spys go to a driver to learn about the solution by another team. Only the driver is allowed to talk with the spy and answer all the spy's questions. The total spy session from signal is given is **only** 45 seconds! And it's the mater of the timekeeper to cut of the spy.

A hint is to plan the spying: which team are we spying at? what are we looking for?

The result of the spying is a comment in the code like this:

```C#
// Spy: @GitHub-username, a short desciption of findings
```

## Mini-presentation of the project

On Thursday 5th of march 8:30, will each group do a mini presentation. You should long before the presentation have made decision in the group who is going to do the talking.

Be sharp you only have **5 min** including attaching your computer.

The rest of class will give a vote on paper, scale is 1-5, this vote is placed into the hat of the group.

### When voting

Remember to write the group you are voting on and your own group on the voting paper. Otherwise is the vote considered invalid.

Look for the following in the presentation:

- Code
- Tests
- Patterns
- Readiness
- Presentation

- Timing

## Points

This project is part of the overall evaluation of all students. This is done by collecting point. You and you team will get points for the following:

- Presentation, team-point
- A driver check-in, personal-point
- A vote, team-point
- A spy comment, personal-point
- Time off switching, gives negative points, team-point.

# Barista API
In this projects should you create an Fluent API for a [barista](https://en.wikipedia.org/wiki/Barista) to create espresso based drinks using code. An example of how the API could look (this is pseudo-code!!):

```c#
var smallEspresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToSmallCup();
```

![Coffee](https://i.pinimg.com/474x/f0/16/57/f01657c547416ccac3bf3f3577b04910--coffee-cafe-coffee-shops.jpg)

It's up to you how the output should be presented to the user.

## The solution 

The solution should cover the following:

- Encapsulation, Inheritance, Polymorphism, Abstraction
- A fluent api, which uses some lambda expressions
- Unit tests, is a must that the solution contains some unit tests

Extra

- The usage of attributes

## An alternative (but more or less the same)

Instead of a braista you could also have a coffee automat in mind, this Krups EA800540 could be used as an example.
[Review video](https://www.youtube.com/watch?v=pcDvSwqWUbc)

[Instruction manual](https://www.krups.co.uk/medias/?context=bWFzdGVyfHJvb3R8MzU0ODA0OXxhcHBsaWNhdGlvbi9wZGZ8aGU3L2g4ZS8xMjU0MzI2NjQyMjgxNC5wZGZ8MTJmMWFkODFjYzc3ZTg4NDdjYzViNDE5NjVmYzhiMTM5OTAzOTg1M2UzZGE1NDYwNzgzYjQ2MDE2ZjgxM2FhMg)




![Cofee automat, source: https://i.pinimg.com/originals/60/d2/49/60d249fd0e3963eb7e8894a32852f970.jpg](coffeeautomat.jpg)



- 

  






