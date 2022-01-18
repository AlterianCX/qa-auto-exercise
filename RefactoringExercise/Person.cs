namespace RefactoringExercise {
    public class Person {
        public static int OneThousand = 1000;
        public static int FiveThousand = 5000;
        public static int TenThousand = 10000;

        public int id;
        public string name;
        public double purchaseHistory;
        public int numberOfOrders;

        public Person(int id, string name, double purhasHistory, int orderQuantity) {
            this.id = id;
            this.name = name;
            this.purchaseHistory = purhasHistory;
            this.numberOfOrders = orderQuantity;
        }
    }
}
