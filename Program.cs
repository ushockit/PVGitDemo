using System;
using System.Collections;
using System.Collections.Generic;


namespace SomeProject {
    class Item 
    {
        public string Name { get; set; }
    }
    class Program {
        static List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };
        static void Main(string[] args) {

            int action;

            Console.WriteLine("[1] Start");
            Console.WriteLine("[2] Search item");
            Console.WriteLine("[3] Exit");

            int.TryParse(Console.ReadLine(), out action);

            switch(action) {
                case 1:
                    Console.WriteLine("Starting...");
                    Start();
                break;
                case 2:
                    SearchItem("Item 2");
                break;
                case 3:
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

        static string SearchItem(string srchItem) {
            return items.FirstOrDefault(item => item.Equals(srchItem));
        }
    }
}