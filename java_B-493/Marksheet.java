class Marksheet {
  public static void main(String[] args) {
    float JAVA = 56, C = 75, OS = 83, SEO = 72, IOT = 67;
    System.out.println("First subject mark = " + JAVA);
    System.out.println("Second subject mark = " + C);
    System.out.println("Third subject mark = " + OS);
    System.out.println("Forth subject mark = " + SEO);
    System.out.println("Fifth subject mark = " + IOT);

    System.out.println();
    System.out.println(
        "Total mark of subjects = " + (JAVA + C + OS + SEO + IOT));
    System.out.println();
    System.out.println(
        "Percentage of total mark = " + (JAVA + C + OS + SEO + IOT) / 5);
    System.out.println();

    if (JAVA > 33 & C > 33 & OS > 33 & SEO >= 33 & IOT > 33) {
      System.out.println("Pass...");
      System.out.println();
      if (((JAVA + C + OS + SEO + IOT) / 5) > 70) {
        System.out.println("Distinction...");
        System.out.println();
      } else if (((JAVA + C + OS + SEO + IOT) / 5) > 60) {
        System.out.println("First Class...");
        System.out.println();
      } else if (((JAVA + C + OS + SEO + IOT) / 5) > 50) {
        System.out.println("Second Class...");
        System.out.println();
      } else if (((JAVA + C + OS + SEO + IOT) / 5) > 40) {
        System.out.println("Pass Class...");
        System.out.println();
      }
    } else {
      System.out.println("Fail...");
    }
  }
}