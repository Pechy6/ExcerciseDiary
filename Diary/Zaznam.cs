using System.Text;

namespace Diary;

public class Zaznam
{
    DateTime Datum { get; set; }
    string Text { get; set; }

    public LinkedListNode<Zaznam> Node { get; set; }
    public LinkedList<Zaznam> Zaznamy { get; set; } = new();


    public Zaznam(DateTime datum, string text)
    {
        Datum = datum;
        Text = text;
    }

    public Zaznam()
    {
    }

    /// <summary>
    /// Přidává záznam do listu
    /// </summary>
    /// <param name="datum">Datum zaznamu</param>
    /// <param name="text">Text zaznamu</param>
    public void PridejZaznam(DateTime datum, string text)
    {
        var novyZaznam = new Zaznam(datum, text);
        Zaznamy.AddLast(novyZaznam);

        if (Node == null)
        {
            Node = Zaznamy.First;
        }
    }

    /// <summary>
    /// Odstraňuje aktuální záznam z listu a nastavuje následující nebo předchozí uzel jako aktuální.
    /// </summary>
    public void VymazZaznam()
    {
        if (Node == null)
        {
            // Console.WriteLine("Zaznamy nejsou k dispozici.");
            return;
        }

        // Vybere nasledujici nebo predchozi uzel
        var dalsiNode = Node.Next != null ? Node.Next : Node.Previous;

        // odstrani aktualni uzel ze zaznamu
        Zaznamy.Remove(Node);

        // nastavi dalsi uzel jako aktualni
        Node = dalsiNode;
    }

    /// <summary>
    /// Nastavuje následující záznam v seznamu jako aktuální, pokud existuje, a vypisuje jeho obsah.
    /// </summary>
    public void DalsiZaznam()
    {
        if (Node == null)
        {
            
        }

        if (Node.Next != null)
        {
            Node = Node.Next;
            Console.WriteLine($"Datum: {Node.Value.Datum}");
            Console.WriteLine($"Text: {Node.Value.Text}");
        }
    }

    /// <summary>
    /// Nastavuje předchozí záznam v seznamu jako aktuální, pokud existuje, a vypisuje jeho obsah.
    /// </summary>
    public void PredchoziZaznam()
    {
        if (Node == null)
        {
            // Console.WriteLine("Zaznamy nejsou k dispozici.");
        }

        if (Node.Previous != null)
        {
            Node = Node.Previous;
            Console.WriteLine($"Datum: {Node.Value.Datum}");
            Console.WriteLine($"Text: {Node.Value.Text}");
        }
        else
        {
            Console.WriteLine("Nebyl nalezen predchozi zaznam.");
        }
    }

    /// <summary>
    /// Zobrazuje obsah aktuálního záznamu včetně data a textu.
    /// </summary>
    public void ZobrazAktualniZaznam()
    {
        if (Node == null)
        {
            // Console.WriteLine("Zaznamy nejsou k dispozici.");
            return;
        }

        Console.WriteLine($"Datum: {Node.Value.Datum:d}\n");
        Console.WriteLine($"{Node.Value.Text}");
    }
}