public class SingletonTest {

    public static void main(String[] args) {

        Logger logger1 = Logger.getInstance();
        logger1.log("First Message");

        Logger logger2 = Logger.getInstance();
        logger2.log("Second Message");

        Logger logger3 = Logger.getInstance();
        logger3.log("Third Message");
        System.out.println();

        System.out.println("logger1 HashCode : " + logger1.hashCode());
        System.out.println("logger2 HashCode : " + logger2.hashCode());
        System.out.println("logger3 HashCode : " + logger3.hashCode());

        if (logger1 == logger2 && logger2 == logger3) {
            System.out.println("\nOnly one Logger instance exists.");
        } else {
            System.out.println("\nMultiple Logger instances exist.");
        }
    }
}
