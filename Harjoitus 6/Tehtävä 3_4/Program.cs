using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

// Janne Rajuvaara
// NTK17 2018

namespace H6T3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Presidentti> Presidentit = new List<Presidentti>();

            Presidentit.Add(new Presidentti() { Nimi = "Ståhlberg, Kaarlo Juho", SyntymaAika = new DateTime(1865, 1, 28), VirkaAlkuPvm = new DateTime(1919, 7, 26), VirkaLoppuPvm = new DateTime(1925, 3, 2)});
            Presidentit.Add(new Presidentti() { Nimi = "Relander, Lauri Kristian", SyntymaAika = new DateTime(1883, 5, 31), VirkaAlkuPvm = new DateTime(1925, 3, 2), VirkaLoppuPvm = new DateTime(1931, 3, 2)});
            Presidentit.Add(new Presidentti() { Nimi = "Svinhufvud, Pehr Evind", SyntymaAika = new DateTime(1861, 12, 15), VirkaAlkuPvm = new DateTime(1931, 3, 2), VirkaLoppuPvm = new DateTime(1937, 3, 1)});
            Presidentit.Add(new Presidentti() { Nimi = "Kallio, Kyösti", SyntymaAika = new DateTime(1873, 4, 10), VirkaAlkuPvm = new DateTime(1937, 3, 1), VirkaLoppuPvm = new DateTime(1940, 12, 19)});
            Presidentit.Add(new Presidentti() { Nimi = "Ryti, Risto Heikki", SyntymaAika = new DateTime(1889, 2, 3), VirkaAlkuPvm = new DateTime(1940, 12, 19), VirkaLoppuPvm = new DateTime(1944, 8, 4)});
            Presidentit.Add(new Presidentti() { Nimi = "Mannerheim, Carl Gustav Emil", SyntymaAika = new DateTime(1867, 6, 4), VirkaAlkuPvm = new DateTime(1944, 8, 4), VirkaLoppuPvm = new DateTime(1946, 3, 11)});
            Presidentit.Add(new Presidentti() { Nimi = "Paasikivi, Juho Kusti", SyntymaAika = new DateTime(1870, 3, 27), VirkaAlkuPvm = new DateTime(1946, 3, 11), VirkaLoppuPvm = new DateTime(1956, 3, 1)});
            Presidentit.Add(new Presidentti() { Nimi = "Kekkonen, Urho Kaleva", SyntymaAika = new DateTime(1900, 9, 3), VirkaAlkuPvm = new DateTime(1956, 3, 1), VirkaLoppuPvm = new DateTime(1982, 1, 27)});
            Presidentit.Add(new Presidentti() { Nimi = "Koivisto, Mauno Henrik", SyntymaAika = new DateTime(1923, 11, 25), VirkaAlkuPvm = new DateTime(1982, 1, 27), VirkaLoppuPvm = new DateTime(1994, 3, 1)});
            Presidentit.Add(new Presidentti() { Nimi = "Ahtisaari, Martti Oiva Kalevi", SyntymaAika = new DateTime(1937, 6, 23), VirkaAlkuPvm = new DateTime(1994, 3, 1), VirkaLoppuPvm = new DateTime(2000, 3, 1)});
            Presidentit.Add(new Presidentti() { Nimi = "Halonen, Tarja Kaarina", SyntymaAika = new DateTime(1943, 12, 24), VirkaAlkuPvm = new DateTime(2000, 3, 1), VirkaLoppuPvm = new DateTime(2012, 3, 1)});
            Presidentit.Add(new Presidentti() { Nimi = "Niinistö, Sauli Väinämö", SyntymaAika = new DateTime(1948, 8, 24), VirkaAlkuPvm = new DateTime(2012, 3, 1), VirkaLoppuPvm = new DateTime(2024, 3, 1)});

            string syote;
            DateTime paivamaara;

            do
            {
                Write("Anna päiväys: ");
                syote = ReadLine();
                if (syote == "") { break; }
                else
                {
                    try
                    {
                        paivamaara = DateTime.Parse(syote, new CultureInfo("fi-FI"));
                        if (paivamaara < new DateTime(1919, 7, 26)) { WriteLine("Ei presidenttiä."); }
                        else if (paivamaara < new DateTime(2024, 3, 2))
                        {
                            foreach (Presidentti p in Presidentit)
                            {
                                if (p.VirkaAlkuPvm <= paivamaara && paivamaara <= p.VirkaLoppuPvm)
                                {
                                    // Tehtävänannon esimerkissä presidenttien iät lasketaan väärin.
                                    WriteLine($"{p.Nimi} {p.VirkaKausi}, {(int)((paivamaara - p.SyntymaAika).TotalDays / 365.2421875)}-vuotias.");
                                }
                            }
                        }
                        else { WriteLine("En voi ennustaa tulevaisuutta."); }

                    }
                    catch (Exception)
                    {
                        WriteLine("Virheellinen päiväys.");
                    }
                }
                
            } while (true);
        }
    }
}
