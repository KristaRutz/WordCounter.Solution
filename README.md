# Word Counter (C# Console Application)

#### A console-based application to count appearances of a word, where the user can search text for a target search word, hosted on [GitHub](https://github.com/KristaRutz/WordCounter.Solution). _Last Updated 03.06.2020._

#### By _**Krista Rutz**_

## Description

This application lets the user enter a phrase, sentence, or block of text and specify a search word, and calculates how many times this search word appears in the given text. This fully tested application can be set to return case sensitive or case-insensitive matches. It determines full word matching only, and can account for mid-word punctuation.

This functionality is attained using Char and String methods in vanilla C#, and without regular expressions. It utilizes custom RepeatCounter objects and overloaded constructors.

It is hosted on [GitHub](https://github.com/KristaRutz/WordCounter.Solution).

See this example output searching through a quote from Frank Herbert's Dune:

```
$dotnet run

Enter the text through which you wish to search:
“I must not fear. Fear is the mind-killer. Fear is the little-death that brings total obliteration. I will face my fear. I will permit it to pass over me and through me. And when it has gone past I will turn the inner eye to see its path. Where the fear"

Enter the word you want to count:
fear

Case sensitive? [Y/N]
n

5 matches found
Press 'Enter' to perform a new search

Enter the text through which you wish to search:
“I must not fear. Fear is the mind-killer. Fear is the little-death that brings total obliteration. I will face my fear. I will permit it to pass over me and through me. And when it has gone past I will turn the inner eye to see its path. Where the fear"

Enter the word you want to count:
fear

Case sensitive? [Y/N]
y

3 matches found

```

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/WordCounter.Solution) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'WordCounter.Solution'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/KristaRutz/WordCounter.Solution`
    - The new directory will be created as 'Desktop/WordCounter.Solution'.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: `$ cd WordCounter.Solution/WordCounter`
  - `dotnet build`
  - `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- C#
- .NET Core 2.2

## Specs

<details>
  <summary>Expand specs for this project</summary>

- [x] **Spec:** The file structure will be as shown:

  - Solution Name: WordCounter.Solution
  - ├──Project Name: WordCounter
  - └── Test Project Name: WordCounter.Tests

- [x] **Spec:** When viewing the project on GitHub, WordCounter, WordCounter.Tests, and README.md should be visible at the top level of the repository.

- [x] **Spec:** The following specs have tests associated with them.

- [x] **Spec:** There is a class called RepeatCounter.

- [x] **Spec:** The program collects an empty word input and checks how frequently that full word appears in an inputted sentence, then returns the number.

  - Input: "", "test"
  - Output: 0; // Not a word error.

- [x] **Spec:** The program collects a single word input and checks how frequently that full word appears in an empty string, then returns the number.

  - Input: "test", ""
  - Output: 0 matches;

- [x] **Spec:** The program collects a single word input and checks how frequently that full word appears in an inputted single word, then returns the number.

  - Input: "test", "test"
  - Output: 1;

- [x] **Spec:** The program collects a single word input and checks how frequently that full word appears in a string of only that word, then returns the number.

  - Input: "test", "test test test"
  - Output: 3;

- [x] **Spec:** The program collects a single word input and checks how frequently that full word appears in a string, then returns the number.

  - Input: "test", "this test is a test"
  - Output: 2;

- [x] **Spec:** The program checks for full word matches only (case sensitive).

  - Input: "test", "this **test** is still **test**ing"
  - Output: 1;

- [x] **Spec:** The program can find words separated at spaces, beginning and end of string, or with punctuation attached.
  - Input: "test", "this test is a 'test.'"
  - Output: 2;

</details>
<details>
  <summary>Expand user stories for this project</summary>

| As a _User-Type_,    | I want...                                                            | so that...                                               |
| :------------------- | :------------------------------------------------------------------- | :------------------------------------------------------- |
| As a writer          | I want to know how many times I've typed a given word                | so that I can see the relative frequency of a given word |
| As an editor         | I want to know how often a word appears                              | so that I can make sure to edit all mentions of the word |
| As the app developer | I want the user to input whether or not the search is case-sensitive | so that the user can be satisfied with their output      |

</details>

## Known Bugs

- No known bugs

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. I can be contacted at <krista.rutz@pomona.edu>. Feel free to create a pull request for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
