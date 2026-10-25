using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~15 Min.)
//
// Erstelle einen Konsolen-Taschenrechner, der zwei Zahlen und eine
// Operation einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Starten: In Lessons/Program.cs die Zeile
//          ...Auftrag1_Taschenrechner.Taschenrechner.Start();
//          einkommentieren (alle anderen Zeilen auskommentiert lassen).
// ============================================================

public static class Taschenrechner
{
  /// <summary>
  ///   Startet den Taschenrechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Erste Zahl einlesen und prüfen
             Console.Write("Erste Zahl: ");
             if (!double.TryParse(Console.ReadLine() ?? "", out double zahl1))
             {
               Console.WriteLine("Ungültige Zahl.");
               return;
             }

    // TODO 2: Zweite Zahl einlesen (gleiche Technik wie TODO 1)
              Console.Write("Zweite Zahl:");
              if (!double.TryParse(Console.ReadLine() ?? "", out double zahl2))
              {
                Console.WriteLine("Ungütlige Zahl.");
                return;
              }


    // TODO 3: Operation einlesen (+, -, *, /)
            Console.Write("Operant:");
            string operation = Console.ReadLine() ?? "";


    // TODO 4: Berechnen mit if / else if
    //         Achtung: Bei "/" zuerst prüfen, ob zahl2 == 0 ist!
    //         Unbekannte Operation → Meldung ausgeben
    double result = 0;

    if (operation == "+")
    { result = zahl1 + zahl2; }

    else if (operation == "*")
    { result = zahl1 * zahl2; }

    else if (operation == "/")
    {
      if (zahl2 == 0)
      { Console.WriteLine("Nicht durch 0 Teilbar");
        return;
      }
      else
      { result = zahl1 / zahl2; }
    }
    else if (operation == "-")
    { result = zahl1 - zahl2; }

    else
    { Console.WriteLine("Ungültiger Operant");
      return;
    }
    // TODO 5: Ergebnis ausgeben: $"Ergebnis: {result:F2}"
    Console.WriteLine($"Dein Ergebnis ist: {result:F2}");
  }
}
