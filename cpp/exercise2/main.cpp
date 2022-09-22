#include <gtest/gtest.h>
#include<bits/stdc++.h>

struct Sorter {
  std::string SortCharacters(int number, std::string word) {

     word.erase(std::remove_if(word.begin(), word.end(), ::isspace), word.end());

     if(number == 0){
         return word;
     }

    int counter = 0;
    std::string text = "";
    for (int i = 0; i < word.size(); i++) {
      text += word.at(i);
      counter++;
      if (counter == number) {
        text += "\n";
        counter = 0;
      }
    }
    return text;
  }

} sorter;

class Answer {
public:
  static std::string NewSort(int number, std::string word) {
    return sorter.SortCharacters(number, word);
  }
};

int main() {
  testing::InitGoogleTest();
  return RUN_ALL_TESTS();
}


TEST(Sorter, RemoveWhiteSpaces) {
  int amount = 0;
  std::string text = "a bcd efgh ij";
  std::string expectedResult = "abcdefghij",
              actualResult = sorter.SortCharacters(amount, text);
  EXPECT_EQ(expectedResult, actualResult);
}

TEST(Sorter, SortSmall) {
    std::string text = "ab";
    std::string expectedResult = "a\nb\n", actualResult = sorter.SortCharacters(1, text);
    EXPECT_EQ(expectedResult, actualResult);
}

TEST(Sorter, SortTrio) {
  int amount = 3;
  std::string text = "a bcd efgh ij";
  std::string expectedResult = "abc\ndef\nghi\nj",
              actualResult = sorter.SortCharacters(amount, text);
  EXPECT_EQ(expectedResult, actualResult);
}

TEST(Sorter, SortCouple) {
  int amount = 2;
  std::string text = "0 12 345 6";
  std::string expectedResult = "01\n23\n45\n6",
              actualResult = sorter.SortCharacters(amount, text);
  EXPECT_EQ(expectedResult, actualResult);
}
