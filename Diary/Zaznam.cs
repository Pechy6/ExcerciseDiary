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

    public void PridejZaznam(DateTime datum, string text)
    {
        var novyZaznam = new Zaznam(datum, text);
        Zaznamy.AddLast(novyZaznam);

        if (Node == null)
        {
            Node = Zaznamy.First;
        }
    }

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