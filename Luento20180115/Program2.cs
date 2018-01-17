using System;
using static System.Console;

namespace Luento3_2 {
  class Program {
    static void Main(string[] args)
    {
      int vuosi;
      do {

        Write("Anna vuosi (0 lopettaa): ");
        vuosi = int.Parse(ReadLine());

        if (vuosi == 0)
          {
            break;
          }

        else if ((OnJaollinen(vuosi, 4) && !OnJaollinen(vuosi, 100)) || OnJaollinen(vuosi,400))
          {
            WriteLine($"{vuosi} on karkausvuosi.");
          }
      } while(true);

      ReadLine();

    }
    static bool OnJaollinen(int jaettava, int jakaja) {
      return jaettava % jakaja == 0;
    }
  }
}
