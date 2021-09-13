public class Program {

    public static void main(String[] args) {
        Person a = new Person("Chau");
        Person b = new Person("Chau", 21);
        Person c = new Person("Chau", 21, 1.7f);
        c.getInfo();

        System.out.println("--------------------");

        Student s = new Student("Nam", 20, 1.8f);
        s.getInfo();
    }
}