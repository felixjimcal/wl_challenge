package org.example;

public class Main {
    public static void main(String[] args) {
        Twiner twiner = new Twiner();
        System.out.println(twiner.AreTwins("Mario", "Luigi") ? "Twins" : "Bros");
    }
}