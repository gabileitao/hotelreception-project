using System;
using System.Collections.Generic;

namespace hotelreception_project {
    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Quantas pessoas se hospedarao: ");
            int guestsQuantity = int.Parse(Console.ReadLine());

            Suite suite = SelectedSuite(guestsQuantity);

            Console.Clear();

            List<Pessoa> guests = RegisterGuest(guestsQuantity);

            Console.WriteLine("Digite a quantidade de dias que ficarao hospedados: ");
            int daysInTheRoom = int.Parse(Console.ReadLine());

            Reserva booking = new Reserva(guests, suite, daysInTheRoom);

            Console.WriteLine($"Numero de hospedes: {guestsQuantity}.");
            Console.WriteLine($"Valor da estadia: {booking.GetPrice()}.");

        }

        public static List<Pessoa> RegisterGuest(int guests) {

            List<Pessoa> guestList = new List<Pessoa>();
            
            for(int i = 0; i < guests; i++) {
                Pessoa guest = new Pessoa();
                Console.WriteLine("Digite o nome da pessoa: ");
                guest.Name = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome da pessoa: ");
                guest.LastName = Console.ReadLine();
                guestList.Add(guest);
            }

            return guestList;
        }

        public static Suite SelectedSuite(int guestQuantity) {

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
                    if (guestQuantity <= avaiableSuites[chosenSuite - 1].Capacity) {
                        option = true;
                    } else {
                        Console.WriteLine("Quarto não comporta essa quantidade de pessoas. Escolha de novo.");
                    }
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
