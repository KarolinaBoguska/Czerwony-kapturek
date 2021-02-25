using System;

namespace klasy.CzerwonyKapturek
{
    public class Opowiadanie
    {
        // nowe obiekty w klasie aktor        
        public void Opowiedz()
        {
            Aktor babcia = new Aktor();
            babcia.imie = "Babcia";
            Aktor czerwony_kapturek = new Aktor();
            czerwony_kapturek.imie = "Czerwony Kapturek";
            Aktor wilk = new Aktor();
            wilk.imie = "Wilk";

            // nowe obiekty w klasie narrator
            Narrator narrator = new Narrator();
            narrator.imie = "Narrator";

            // wywołaj metody
            wilk.Mówi("ddd");
            babcia.Mówi("ddd");
            czerwony_kapturek.Mówi("dd");
            narrator.Mówi("ddd");

            narrator.Mówi("Szedł do babci Czerwony Kapturek przez las i podskakując raz po raz, nie zważając na mamy przestrogi, zboczył nieco z leśnej drogi.");
            czerwony_kapturek.Mówi(" A co mi tam, zejdę z tej leśnej dróżki. Powącham tylko przez chwilę te piękne kwiatuszki.");
            narrator.Mówi("I tak Kapturek wąchając kwiaty, zachwycony, usłyszał jakiś głos. Głos był nieznajomy. I mimo, że ją ostrzegała mama, żeby z nikim obcym po drodze nie rozmawiała, wdała się w dyskusję z wilkiem:");
            wilk.Mówi("Witaj Czerwony Kapturku, gdzież to się wybierasz ?");
            czerwony_kapturek.Mówi("Idę do chorej babci.");
            wilk.Mówi("Hmmm... Do babci powiadasz.... A gdzie mieszka twojababcia?");
            czerwony_kapturek.Mówi("Tam, na polance, pod trzema dębami stoi babci chatka.");
            wilk.Mówi("Oj! Zagadałem się. Muszę już uciekać,bo mnie dzisiaj jeszcze dużo pracy czeka.");
            narrator.Mówi("Oj! Zagadałem się. Muszę już uciekać,bo mnie dzisiaj jeszcze dużo pracy czeka.");
            babcia.Mówi("Ale ty pamiętaj mój kolego drogi, nie zbaczaj nigdy z prostej drogi. Nie bierz przykładu z Czerwonego Kapturka i nie pokazuj drogi do swojego podwórka. Nie mów nigdy obcemu, nikomu, co masz cennego w swoim domu, Bo obcy, jak ten wilk kudłaty, może narazić ciebie i twoich rodziców na straty.");
Console.WriteLine(" ---- Koniec ----");




            
            

 
        }
    }
}


