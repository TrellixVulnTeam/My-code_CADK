import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Person[] a = new Person[2];
        for (int i = 0; i < a.length; i++) {
            Scanner input = new Scanner(System.in);
            System.out.print("Enter name of person " + (i + 1) + " : ");
            String name = input.next();
            System.out.print("Enter birthday of person " + (i + 1) + " : ");
            int birthday = input.nextInt();
            System.out.print("Enter height of person " + (i + 1) + " : ");
            float height = input.nextFloat();
            System.out.print("Enter sex of person " + (i + 1) + " (1: male || 2: female): ");
            int sex = input.nextInt();
            a[i] = new Person(name, birthday, height, sex);
        }
        for (int i = 0; i < a.length; i++) {
            System.out.println("Enter name of person " + (i + 1) + " is " + a[i].name);
            System.out.println("Enter age of person " + (i + 1) + " is " + (2021 - a[i].birthday));
            System.out.println("Enter height of person " + (i + 1) + " is " + a[i].height);
            if (a[i].sex == 1) {
                System.out.println("sex is male");
            } else {
                System.out.println("Sex is female");
            }
        }
    }
}