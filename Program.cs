using System;
using System.Collections;
using System.Collections.Generic;


namespace SomeProject {
    class Program {
        static List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };
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
                case 3:
                    foreach(var item in items) {
                        Console.WriteLine(item);
                    }
                break;
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