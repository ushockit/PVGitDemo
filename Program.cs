using System;



namespace SomeProject {
    class Program {
        static void Main(string[] args) {

            int action;

            Console.WriteLine("[1] Start");
            Console.WriteLine("[2] Exit");
            int.TryParse(Console.ReadLine(), out action);

            switch(action) {
                case 1:
                    Console.WriteLine("Starting...");
                    Start();
                break;
                case 2:
                    Environment.Exit(0);
                break;
            }


            Console.Read();
        }


        static void Start() {
            while(true) {
                Console.Clear();

                for(int i = 0; i < 10; i++) {
                    for(int j = 0; j < 10; j++) {

                    }
                }
            }
        }
    }
}