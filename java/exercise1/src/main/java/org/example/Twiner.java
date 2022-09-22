package org.example;
import java.util.Arrays;

public class Twiner {

    public boolean AreTwins(String a, String b)
    {
        boolean result = false;

        if((a.trim().isEmpty() || b.trim().isEmpty()) || (a.length() != b.length())){
           return result;
        }

        a = a.toLowerCase();
        b = b.toLowerCase();

        char[] aLetters = a.toCharArray(), bLetters = b.toCharArray();
        Arrays.sort(aLetters);
        Arrays.sort(bLetters);

        if(Arrays.equals(aLetters, bLetters)){
            result = true;
        }

        return result;
    }
}
