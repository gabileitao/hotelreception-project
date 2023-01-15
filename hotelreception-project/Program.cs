using System;
using System.Collections.Generic;

namespace hotelreception_project {
    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Quantas pessoas se hospedarao: ");
            int guestsQuantity = int.Parse(Console.ReadLine());

            Suite suite = SelectedSuite();



            Console.WriteLine(suite);

        }

        public static Suite SelectedSuite() {

            List<Suite> avaiableSuites = new List<Suite>();

            Suite roomP = new Suite("simples", 2, 35);
            Suite roomM = new Suite("normal", 4, 60);
            Suite roomG = new Suite("grande", 5, 70);
            Suite roomXG = new Suite("master", 6, 90);

            avaiableSuites.Add(roomP);
            avaiableSuites.Add(roomM);
            avaiableSuites.Add(roomG);
            avaiableSuites.Add(roomXG);

            Console.WriteLine("Escolha o numero da sua suite: ");

            for (int i = 0; i < avaiableSuites.Count; i++) {
                Console.WriteLine($"{i + 1} Tipo: {avaiableSuites[i].SuiteType}. Capacidade: {avaiableSuites[i].Capacity}. Valor: {avaiableSuites[i].DailyValue}");
            }

            bool option = false;
            int chosenSuite = 0;

            while (!option) {
                chosenSuite = int.Parse(Console.ReadLine());

                if (chosenSuite >= 1 && chosenSuite <= avaiableSuites.Count) {
                    option = true;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção invalida. Selecione novamente.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                
            }

            return avaiableSuites[chosenSuite-1];
        }
    }
}
