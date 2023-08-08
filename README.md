# Ada TDD master class August 2023

## Tennis Kata

This Kata is about implementing a simple tennis game. I came up with it while thinking about Wii tennis, where they have simplified tennis, so each set is one game.

The scoring system is rather simple:

- Each player can have either of these points in one game “love” - “30” “40”
- If you have 40 and you win the point you win the game, however - e are special rules.
- If both have 40 the players are “deuce”.
- If the game is in deuce, the winner of a point will have advantage
- If the player with advantage wins the ball he wins the game
- If the player without advantage wins they are back at deuce.

Alternate description of the rules per Wikipedia (http://en.wikipedia.org/wiki/Tennis#Scoring ):

- A game is won by the first player to have won at least four- points in total and at least two points more than the opponent.
- The running score of each game is described in a manner peculiar- to tennis: scores from zero to three points are described as- “love”, “15”, “30”, and “40” respectively.
- If at least three points have been scored by each player, and the- scores are equal, the score is “deuce”.
- If at least three points have been scored by each side and a- player has one more point than his opponent, the score of the game is “advantage” for the player in the lead.

## Fizz Buzz Factory Kata

[Oririnal FizzBuzzFactory Kata by Kevin Hantzen](https://github.com/khantzen/FizzBuzzFactory-Java)

### Iteration 1

Write a fizzBuzzIter1 method that take an integer as an input and return:

- If the input is divisible by 3, return Fizz
- If the input is divisible by 5, return Buzz
- If the input is divisible by 3 and 5, return FizzBuzz
- Else return the input

### Iteration 2

Write a fizzBuzzIter2 method that take an integer as an input and return:

- If the input is divisible by 7, return Fizz
- If the input is divisible by 11, return Buzz
- If the input is divisible bt 7 and 11, return FizzBuzz
- Else return the input

#### Retro

- What do you think about your code ?
- What does your code is thinking about you ?
- Is there any duplication ?
- Can you refactor your code, so there is no duplication ?
- What made you sure you didn't broke anything during your refactor ?

### Iteration 3

Write a fizzBuzzIter3 method that take an integer as input

- If the input is divisible by 13, return Fizz
- If the input is divisible by 17, return Buzz
- If the input is divisible by 19, return Fuzz
- If the input is divisible by 23, return Bizz
- If more than one rule match, return the result concatenation in the order of apparition
  - Else return the input

#### Retro

- What do you think about your code ?
- What does your code is thinking about you ?
- Can you refactor your code, so every FizzBuzz methods works in a similarity way ?

### Iteration 4

Write a superFizzBuzz method that take an integer as input

    If the input is not divisible by 3, return Fizz
    If the input is odd, return Buzz
    If the input is a perfect square, return Fuzz
    If more than one rule match, return the result concatenation in the order of apparition
    Else return the input

#### Retro

- What do you think about your code ?
- What does your code is thinking about you ?
- Can you refactor your code, so every FizzBuzz methods works in a similarity way ?
