# Jamie Pittak's Word Counter Project
#### Week 7 project for Epicodus

### By Jamie Pittak

## Description
This webpage will allow the user to input a word and a sentence and then will return how many times their word appears in their sentence. This project uses C#, .NET, HTML, CSS, Bootstrap, JS, jQuery and MVC for week seven of Epicodus.

## Setup
1. Clone this repository
2. type dotnet restore in terminal
3. type dotnet run in terminal
4. open web browser
5. go to localhost:5000/home

## Specifications
1. The application will prompt the user to enter a word or sentence if only a word is entered but not a sentence.
  input word: "Hello"
  input sentence: " "
  output: "Please enter a word AND sentence"
2. The application will prompt the user to enter a word or sentence if only a word is entered but not a sentence.
  input word: " "
  input sentence: "How was your day?"
  output: "Please enter a word AND sentence"
3. The application will evaluate the users word against the sentence and determine how many times it appears.
  input word: "are"
  input sentence: "How are you?"
  output: 1
4. The application will evaluate the users word against the sentence and determine how many times it appears including words with capitol letters.
  input word: "the"
  input sentence: "The fox and the hound"
  output: 2
5. The application will evaluate the users word against the sentence and determine if it appears at all.
  input word: "kittens"
  input sentence: "puppies are very energetic and cute"
  output: 0

## Technologies Used
* C#
* Razor
* MVC
* HTML
* CSS
* JS
* jQuery
* Bootstrap

## Legal
Copyright (c) 2018 Jamie Laurelann Pittak
