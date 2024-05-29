# Functional Programming Challenges
This repository contains a set of algorithms written delibretely in an imperative manner, with the purpose of being refactored in a more declerative way using the functional concepts available in the respective programming languages.

## Getting Started
Fork and clone or just clone the repo

### Goal
Refactor the algorithms using functional programming, whilst maintianing <span style="color:green">**green**</span> tests!

### Suggested path
I advice to get an overview of the entire scope first, and then gradually working through the algorithms from easiest to hardest. A recomended order would be to:
1. Start with the basic mathematical functions first followed by the bits-and-bytes functions
2. String manipulation functions
3. Then try out some of the sorting algorithms and prime number counter

### Some Advice
- AI assistants such as GitHub Copilot, Chat GPT, etc. are of course allowed, but try to use those tools only for understanding the problems, not for solving them.
- Some of the algorithms are possible to replace with existing implementations of the same algorithms provided by programming language defualt frameworks. E.g. `Sum` in `LINQ`. Try to discovere these features to learn about their existence and usefulness, but try to solv the problems without them.
- In the beginning, you might find some of the algorithms to be quite hard to solve using functional programming. Give it a couple of tries, and then move on to solve some of the others instead.
- Create as many helper methods as you need, but leave the original function decleration as is or it may mess up the tests.

## Weird Things You Might Struggle With
Some of the code was a bit complicated to write in it's "pure" imperative nature due to some of the features of the programming languages. 

### JavaScript and Integer Division
JavaScript/TypeScript does not have a concept of integer division which some of these algorithms requrire for the imperative approach to work. Therefore you'll find some strange code such as `(i / 2) >> 0`. Here, `i` represents an integer, but when divied by 2 the result will naturally be a stored as a float if `i` is not divisable by 2. E.g. `5 / 2 = 2.5`, but with integer divison we would expect `5 / 2 = 2`. As there is no explicit notion of an integer in JavaScript/TypeScript a way to force the result to return only the integer part of the number (removing any decimals / factional digits) is to combine the division with an operations that returns a 32-bit integer, such as [right shift](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Right_shift). E.g. `5 / 2 = 2.5, 2.5 >> 0 = 2`.
