- [x] **Spec:** The file structure will be as shown:
      Solution Name: WordCounter.Solution
      ├──Project Name: WordCounter
      └── Test Project Name: WordCounter.Tests

- [x] **Spec:** When viewing the project on GitHub, WordCounter, WordCounter.Tests, and README.md should be visible at the top level of the repository.

- [ ] **Spec:** The following specs have tests associated with them.

- [x] **Spec:** There is a class called RepeatCounter.

- [x] **Spec:** The program collects an empty word input and checks how frequently that full word appears in an inputted sentence, then returns the number.

  - Input: "", "test"
  - Output: 0; // Not a word error.

- [x] **Spec:** The program collects a single word input and checks how frequently that full word appears in an empty string, then returns the number.

  - Input: "test", ""
  - Output: 0 matches;

- [ ] **Spec:** The program collects a single word input and checks how frequently that full word appears in an inputted single word, then returns the number.

  - Input: "test", "test"
  - Output: 1;

- [ ] **Spec:** The program collects a single word input and checks how frequently that full word appears in a string of only that word, then returns the number.

  - Input: "test", "test test test"
  - Output: 3;

- [ ] **Spec:** The program collects a single word input and checks how frequently that full word appears in a string, then returns the number.

  - Input: "test", "this test is a test"
  - Output: 2;

- [ ] **Spec:** The program checks for full word matches only (case insensitive).

  - Input: "test", "this **test** is still **test**ing"
  - Output: 1;

- [ ] **Spec:** The program can find words separated at spaces, beginning and end of string, or with punctuation attached.
  - Input: "test", "this test is a 'test.'"
  - Output: 2;
