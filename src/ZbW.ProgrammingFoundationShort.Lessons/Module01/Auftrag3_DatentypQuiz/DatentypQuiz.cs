using System.Diagnostics;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz;

// ============================================================
// AUFTRAG 3 – Datentyp-Quiz (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Erstelle ein Konsolen-Quiz mit 5 Fragen zu C#-Datentypen und Operatoren.
//
// Anforderungen:
//   - Fragen per Console.Write ausgeben, Antwort mit Console.ReadLine() einlesen
//   - Gross-/Kleinschreibung ignorieren: .Trim().ToLower()
//   - Mindestens 1 Frage erwartet eine Zahl → mit int.TryParse prüfen
//   - Am Ende: $"Resultat: {punkte}/5" ausgeben
//   - Bonus: Gesamtzeit mit Stopwatch messen
//
// Frage 1 ist als Beispiel fertig. Ergänze die Fragen 2–5.
// ============================================================

public static class DatentypQuiz
{
  /// <summary>
  ///   Startet das Quiz auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO (Bonus): Stopwatch starten
    //         var stopwatch = System.Diagnostics.Stopwatch.StartNew();
    var Stopwatch = System.Diagnostics.Stopwatch.StartNew();
    int punkte = 0;

    // ── Frage 1 (Beispiel, Textantwort) ──────────────────────
    Console.Write("Frage 1: Welcher Datentyp speichert true/false? ");
    string antwort1 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort1 == "bool")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: bool");
    }

    // TODO 2: Frage 2 (Text) – z. B. «Welcher Typ eignet sich für Geldbeträge?» → decimal
    Console.Write("Welcher Typ eignet sich für Geldbeträge? ");
    string answer2 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (answer2 == "decimal")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("Falsch. Richtige Antwort ist Decimal");
    }
    // TODO 3: Frage 3 (Zahl) – z. B. «Was ergibt 7 / 2, wenn beide Zahlen int sind?» → 3
    //         if (int.TryParse(Console.ReadLine() ?? "", out int antwort3) && antwort3 == 3)
    Console.Write("Was ergibt 7 / 2 wenn beide Zahlen int sind? ");

    if (int.TryParse(Console.ReadLine() ?? "", out int answer3) && answer3 == 3)
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("Falsch. Richtige Antwort ist 3");
    }
    // TODO 4: Frage 4 (Zahl) – z. B. «Was ergibt 10 % 3?» → 1
    Console.Write("Was ergibt 10 % 3? ");

    if (int.TryParse(Console.ReadLine() ?? "", out int answer4) && answer4 == 1)
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("Falsch. Richtige Antwort ist 1");
    }
    // TODO 5: Frage 5 (Text) – z. B. «Welcher Typ speichert genau ein Zeichen?» → char
    Console.Write("Welcher Typ speichert genau ein Zeichen? ");
    string answer5 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (answer5 == "char")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("Falsch. Richtige Antwort ist Char");
    }


    Console.WriteLine($"Resultat: {punkte}/5");

    // TODO (Bonus): Stopwatch stoppen und Zeit ausgeben
    //         stopwatch.Stop();
    //         Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
    Stopwatch.Stop();
    Console.WriteLine($"Deine Zeit ist: {Stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
    }
}
