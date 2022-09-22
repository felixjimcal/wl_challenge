#include <algorithm>
#include <cctype>
#include <gtest/gtest.h>
#include <iostream>
#include <set>
#include <vector>

struct Twiner {
  bool CheckTwins(std::string a, std::string b) {
    bool result = false;

    if (a.length() == b.length()) {
      a = ToLowerCase(a);
      b = ToLowerCase(b);

      std::sort(a.begin(), a.end());
      std::sort(b.begin(), b.end());

      if (a == b) {
        result = true;
      }
    }

    return result;
  }

  std::string ToLowerCase(std::string text) {
    std::transform(text.begin(), text.end(), text.begin(),
                   [](unsigned char c) { return std::tolower(c); });
    return text;
  }
} twiner;

class Answer {
public:
  static bool AreTwins(std::string a, std::string b) {
    return twiner.CheckTwins(a, b);
  }
};

int main() {
  testing::InitGoogleTest();
  return RUN_ALL_TESTS();
}

TEST(TwinWords, SameLengthFALSE) {
  std::string a = "abc", b = "abcdefg";
  EXPECT_FALSE(Answer::AreTwins(a, b));
}

TEST(TwinWords, SameLengthTRUE) {
  std::string a = "abc", b = "abc";
  EXPECT_TRUE(Answer::AreTwins(a, b));
}

TEST(TwinWords, AllLowerCase) {
  std::string a = "AbCdEfG", expectedResult = "abcdefg";
  std::string actualResult = twiner.ToLowerCase(a);
  EXPECT_EQ(expectedResult, actualResult);
}

TEST(TwinWords, SameLettersSorted) {
  std::string a = "abc", b = "cba";
  EXPECT_TRUE(Answer::AreTwins(a, b));
}

TEST(TwinWords, DifferentLettersSorted) {
  std::string a = "aBz", b = "aCz";
  EXPECT_FALSE(Answer::AreTwins(a, b));
}
