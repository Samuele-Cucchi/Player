using System.Numerics;
using System;
using BlaisePascal.Esempi.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player("Mario");

        // Stato iniziale
        Console.WriteLine("=== STATO INIZIALE ===");
        Console.WriteLine("Nome: " + player.Name);
        Console.WriteLine("Livello: " + player.Level);
        Console.WriteLine("Esperienza: " + player.Experience);
        Console.WriteLine("Salute: " + player.Health);
        Console.WriteLine("Salute massima: " + player.MaxHealth);
        Console.WriteLine("Vivo: " + player.IsAlive);
        Console.WriteLine("Oro: " + player.Gold);

        // Esperienza
        Console.WriteLine();
        Console.WriteLine("=== ESPERIENZA ===");

        player.AddExperience(250);

        Console.WriteLine("Livello: " + player.Level);
        Console.WriteLine("Esperienza: " + player.Experience);

        player.AddExperience(0);
        player.AddExperience(-10);

        Console.WriteLine("Esperienza dopo valori non validi: " + player.Experience);

        player.ResetExperience();

        Console.WriteLine("Esperienza azzerata: " + player.Experience);

        // Danno
        Console.WriteLine();
        Console.WriteLine("=== DANNO ===");

        player.TakeDamage(30);

        Console.WriteLine("Salute dopo il danno: " + player.Health);

        player.TakeDamage(0);
        player.TakeDamage(-10);

        Console.WriteLine("Salute dopo danni non validi: " + player.Health);

        // Cura
        Console.WriteLine();
        Console.WriteLine("=== CURA ===");

        player.Heal(20);

        Console.WriteLine("Salute dopo la cura: " + player.Health);

        player.Heal(200);

        Console.WriteLine("Salute dopo una cura elevata: " + player.Health);

        player.Heal(0);
        player.Heal(-10);

        Console.WriteLine("Salute dopo cure non valide: " + player.Health);

        // Morte
        Console.WriteLine();
        Console.WriteLine("=== MORTE ===");

        player.TakeDamage(200);

        Console.WriteLine("Salute: " + player.Health);
        Console.WriteLine("Vivo: " + player.IsAlive);

        player.Heal(50);

        Console.WriteLine("Vivo dopo un tentativo di cura: " + player.IsAlive);

        // Ripristino salute
        Console.WriteLine();
        Console.WriteLine("=== RIPRISTINO SALUTE ===");

        player.ResetHealth();

        Console.WriteLine("Salute: " + player.Health);
        Console.WriteLine("Vivo: " + player.IsAlive);

        // Oro
        Console.WriteLine();
        Console.WriteLine("=== ORO ===");

        player.AddGold(100);

        Console.WriteLine("Oro: " + player.Gold);

        player.AddGold(0);
        player.AddGold(-20);

        Console.WriteLine("Oro dopo valori non validi: " + player.Gold);

        // Stato finale
        Console.WriteLine();
        Console.WriteLine("=== STATO FINALE ===");
        Console.WriteLine("Nome: " + player.Name);
        Console.WriteLine("Livello: " + player.Level);
        Console.WriteLine("Esperienza: " + player.Experience);
        Console.WriteLine("Salute: " + player.Health);
        Console.WriteLine("Vivo: " + player.IsAlive);
        Console.WriteLine("Oro: " + player.Gold);
    }
}