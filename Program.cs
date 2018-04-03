using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Javier = new Human("Javier");
            Wizard gandolph = new Wizard("gandolph");
            Samurai jack = new Samurai("jack");
            Ninja black = new Ninja("black");
            Console.WriteLine($"name: {gandolph.name}");
            Console.WriteLine($"Health: {gandolph.health}");
            Console.WriteLine($"strength: {gandolph.strength}");

            black.Steal(gandolph);
            black.Get_Away();
            Console.WriteLine($"name: {black.name}");
            Console.WriteLine($"Health: {black.health}");
            Console.WriteLine($"dexterity: {black.dexterity}");
            Console.WriteLine($"Jack Health: {jack.health}");

            gandolph.Fireball(jack);
            Console.WriteLine($"jack Health: {jack.health}");
            Javier.attack(gandolph);
            Console.WriteLine($"gandolph Health: {gandolph.health}");
            jack.Death_Blow(gandolph);
            Console.WriteLine($"gandolph Health: {gandolph.health}");
            jack.Meditate();
            Console.WriteLine($"jack Health: {jack.health}");
            gandolph.Heal(gandolph);
            Console.WriteLine($"gandolph Health: {gandolph.health}");
        }
    }
}
