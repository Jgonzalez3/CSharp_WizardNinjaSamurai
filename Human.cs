using System;
namespace WizardNinjaSamurai{
    public class Human{
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Human(string person){
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string player, int str, int intel, int dex, int hp){
            name = player;
            strength = str;
            intelligence =intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj){
            Human enemy = obj as Human;
            if(enemy == null){
                Console.WriteLine("Failed Attack");
            }
            else{
                enemy.health -= strength * 5;
            }
        }
    }
    public class Wizard : Human{
        public Wizard(string person) : base (person){
            name = person;
            intelligence = 25;
            health = 50;
        }
        public void Heal(object wizard){
            Wizard self = wizard as Wizard;
            if(self == null){
                Console.WriteLine("Heal Failed, can only heal Wizard");
            }
            else{
                self.health += 10 * intelligence;
            }
        }
        public void Fireball(object obj){
            Human enemy = obj as Human;
            Random rand = new Random();
            int attack = rand.Next(20,51);
            enemy.health -= attack;
        }
    }
    public class Ninja : Human{
        public Ninja(string person) : base (person){
            name = person;
            dexterity = 175;
        }
        public void Steal(object obj){
            Ninja self = obj as Ninja;
            if(self == null){
                health += 10;
            }
            else{
                Console.WriteLine("Failed to attack");
            }
        }
        public void Get_Away(){
            health -= 15;
        }
    }
    public class Samurai : Human{
        public Samurai(string person) : base (person){
            name = person;
            health = 200;
        }
        public void Death_Blow(object obj){
            Human enemy = obj as Human;
            if (enemy.health < 50){
                enemy.health = 0;
            }
        }
        public void Meditate(){
            health = 200;
        }
        // public static void How_Many(){
        //     foreach (Samurai sam in )
        // }
    }
}
