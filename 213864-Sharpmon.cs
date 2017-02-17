using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpmonGame
{
    class Program
    {
        static Random rdm = new Random();
        public static dynamic Enemy;
        public static dynamic Fighter;
        public static dynamic Tour;

        class ItemShop
        {
            public class Potion
            {
                public string name = "Potion";
                public int price = 100;
                public string description = "+5HP to the current Sharpmon";
                public void Effect(dynamic cible, int Hp)
                {
                    if (Player.Items["Potion"] >= 1)
                    {
                        cible.Hp += 5;
                        Green("+5 HP");
                        Green("Hp de :" + Fighter.name + " :" + Fighter.Hp);
                        Player.Items["Potion"] -= 1;
                    }
                    else
                    {
                        Red("Tu n'a plus de Potion");
                    }

                }

            }
            public class SuperPotion
            {
                public string name = "Super Potion";
                public int price = 150;
                public string description = "+10HP to the current Sharpmon";
                public void Effect(dynamic cible, int Hp)
                {
                    if (Player.Items["SuperPotion"] >= 1)
                    {
                        cible.Hp += 10;
                        Green("+10 HP");
                        Green("Hp de :" + Fighter.name + " :" + Fighter.Hp);
                        Player.Items["SuperPotion"] -= 1;
                    }
                    else
                    {
                        Red("Tu n'a plus de SuperPotion");

                    }

                }

            }
            public class LandyRare
            {
                public string name = "Rare Landy";
                public int price = 1500;
                public string description = "Level up of the current Sharpmon";
                public void Effect(dynamic cible, int Hp)
                {
                    if (Player.Items["LandyRare"] >= 1)
                    {
                        cible.Level += 1;
                        Green("Tu as level up grâce a ton LandyRare");
                        Green("Level de :" + Fighter.name + " :" + Fighter.Level);
                        Player.Items["LandyRare"] -= 1;
                    }
                    else
                    {
                        Red("Tu n'a plus de LandyRare");

                    }


                }

            }
        }
        public class Sharpitle
            {
                public string name = "Sharpitle";
                public int Level = 1;
                public int Xp = 0;
                public sbyte Hp = 11;
                public sbyte Hpmax = 11;
                public int Defense = 2;
                public int Defensemax = 2;
                public int Accuracy = 1;
                public int AccuracyMax = 1;
                public int Power = 1;
                public int Powermax = 1;
                public int Dodge = 2;
                public int Dodgemax = 2;
                public int Speed = 2;
                public int NextLevel = 500;
                public void Attacks1()
                {
                    Console.WriteLine("Sharpitle lance Shell");
                    this.Defense += 1;
                }
                public void Attacks2(dynamic cible, int Hp, int Defense)
                {
                    var Degats = ((Power * 2) / cible.Defense);
                    Console.WriteLine("Sharpitle lance Pound et inflige "+ Degats + " dégats!");
                    cible.Hp -= ((Power * 2) / cible.Defense);
                }
        }
        public class Sharpender
            {
                public string name = "Sharpender";
                public int Level = 1;
                public int Xp = 0;
                public sbyte Hp = 10;
                public sbyte Hpmax = 10;
                public int Defense = 1;
                public int Defensemax = 1;
                public int Accuracy = 2;
                public int AccuracyMax = 2;
                public int Power = 1;
                public int Powermax = 1;
                public int Dodge = 1;
                public int Dodgemax = 1;
                public int Speed = 1;
                public int NextLevel = 500;
                public void Attacks1()
                {
                    Console.WriteLine("Sharpender lance Grawl");
                    this.Power += 1;
                }
                public void Attacks2(dynamic cible, int Hp, int Defense)
                {
                    int Degats = ((Power * 2) / cible.Defense);
                    Console.WriteLine("Sharpender lance Scratch et inflige " + Degats + " dégats!");
                    cible.Hp -= ((Power * 2) / cible.Defense);
                }
            
        }
        public class Sharpaseur
            {
                public string name = "Sharpaseur";
                public int Level = 1;
                public int Xp = 0;
                public sbyte Hp = 9;
                public sbyte Hpmax = 9;
                public int Defense = 1;
                public int Defensemax = 1;
                public int Accuracy = 2;
                public int AccuracyMax = 2;
                public int Power = 1;
                public int Powermax = 1;
                public int Dodge = 3;
                public int Dodgemax = 3;
                public int Speed = 2;
                public int NextLevel = 500;
                public void Attacks1()
                {
                    Console.WriteLine("Sharpaseur lance Foliage");
                    this.Dodge += 1;
                }
                public void Attacks2(dynamic cible, int Hp, int Defense)
                {
                    int Degats = ((Power * 2) / cible.Defense);
                    Console.WriteLine("Sharpaseur lance Pound et inflige " + Degats + " dégats!");
                    cible.Hp -= ((Power * 2) / cible.Defense);
                }

        }

        static void Red(string chaine)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(chaine);
            Console.ResetColor();
        }
        static void Green(string chaine)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(chaine);
            Console.ResetColor();
        }
        static void Blue(string chaine)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(chaine);
            Console.ResetColor();
        }

        public static void Levelup(dynamic cible)
        {
            Green("***LEVEL UP !!***");
            cible.Level += 1;
            cible.Hpmax += Math.Round(cible.Hp * 0.3);
            cible.Defensemax += Math.Round(cible.Defense * 0.3);
            cible.AccuracyMax += Math.Round(cible.Accuracy * 0.3);
            cible.Powermax += Math.Round(cible.Power * 0.3);
            cible.Dodgemax += Math.Round(cible.Dodge * 0.3);
            cible.Hp += Math.Round(cible.Hp * 0.3);
            cible.Defense += Math.Round(cible.Defense * 0.3);
            cible.Accuracy += Math.Round(cible.Accuracy * 0.3);
            cible.Power += Math.Round(cible.Power * 0.3);
            cible.Dodge += Math.Round(cible.Dodge * 0.3);
            cible.Speed += Math.Round(cible.Speed * 0.3);
            cible.NextLevel += 500;
        }
        class Player
        {
            public static int sharpdollars;
            public static Sharpender Sharpmon1 = new Sharpender();
            public static Sharpitle Sharpmon2 = new Sharpitle();
            public static Sharpaseur Sharpmon3 = new Sharpaseur();
            public static List<dynamic> sharpmons = new List<dynamic> { Sharpmon1, Sharpmon2, Sharpmon3, new Sharpaseur(), };
            public static string name = "";
            public static Dictionary<string, int> Items = new Dictionary<string, int> { { "Potion", 1 }, { "SuperPotion", 1 }, { "LandyRare", 0 } };

        }

        static void Wild()
        {
            
            Console.Clear();
            ItemShop.Potion Potion = new ItemShop.Potion();
            ItemShop.SuperPotion SuperPotion = new ItemShop.SuperPotion();
            ItemShop.LandyRare LandyRare = new ItemShop.LandyRare();
            int r = rdm.Next(1, 3);
            if (r == 1)
            {
                Enemy = new Sharpaseur();
            }
            else if (r == 2)
            {
                Enemy = new Sharpitle();
            }
            else if (r == 3)
            {
                Enemy = new Sharpender();
            }
                Console.WriteLine(@"
                                  ******************
                                  ***  FIGHT !!! ***
                                  ******************");
                Red("Tu combat contre :" + Enemy.name + "");
                Fighter = Player.Sharpmon1;
                Green("Ton Pokémon :" + Fighter.name + "");
                Console.WriteLine(@"
                ***********************************
                ***      Touche A : Attaquer    ***
                ***      Touche S : Sharpmon    ***
                ***      Touche I : Inventaire  ***
                ***      Touche C : Capture     ***
                ***      Touche F : Fuire !     ***
                ***********************************"); 
            Tour = 1;
            while( Enemy.Hp > 0)
            {
                if (Tour == 1)
                {
                    Tour = 0;
                    Green("A toi de jouer");
                    ConsoleKeyInfo actions = Console.ReadKey(true);
                    if (actions.Key == ConsoleKey.A)
                    {
                        Green("1 - Boost");
                        Red("2 - Attaquer");
                        var choix = Console.ReadLine();
                        if (choix == "1")
                        {
                            Fighter.Attacks1();
                        }
                        else if (choix == "2")
                        {
                            Fighter.Attacks2(Enemy, Enemy.Power, Enemy.Hp);
                            Red("Hp de : " + Enemy.name + " : " + Enemy.Hp + "");
                        }
                        else
                        {
                            Red("Erreur");
                            Tour = 1;
                        }
                    }
                    else if (actions.Key == ConsoleKey.S)
                    {
                        Console.WriteLine("Tes Sharpmon");
                        int i = 0;
                        int j = Player.sharpmons.Count();
                        int u = 0;
                        foreach (dynamic sharp in Player.sharpmons)
                        {
                            u += 1;
                            Console.WriteLine(u + "-" + sharp.name);
                            Blue(sharp.Hp + "/" + sharp.Hpmax + " Hp");
                        }                       
                        string choixSharpmon = Console.ReadLine();
                        Int32.TryParse(choixSharpmon, out i);      
                        if (i >= 0 && i <= j)
                        {
                            Fighter = Player.sharpmons[i-1];
                            Green("Tu as invoquer : " + Fighter.name + " !");
                        }
                        else
                        {
                            Red("Tu as Fail");
                            Tour = 1;
                        }

                    }
                    else if (actions.Key == ConsoleKey.I)
                    {
                        Console.WriteLine("Inventaires");
                        foreach (KeyValuePair<string, int> entry in Player.Items)
                        {
                            Console.WriteLine(entry.Key + ":" + entry.Value);
                        }
                        Blue("1 - Utiliser Potion");
                        Blue("2 - Utiliser SuperPotion");
                        Blue("3 - Utiliser LandyRare");
                        Red("Utiliser l'item numéro :");
                        var choix = Console.ReadLine();
                        if (choix == "1")
                        {
                            Potion.Effect(Fighter, Fighter.Hp);
                        }
                        else if (choix == "2")
                        {
                            SuperPotion.Effect(Fighter, Fighter.Hp);
                        }
                        else if (choix == "3")
                        {
                            LandyRare.Effect(Fighter, Fighter.Hp);
                        }
                        else
                        {
                            Red("Erreur");
                            Tour = 1;
                        }
                    }
                    else if (actions.Key == ConsoleKey.C)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("***Tentative de Capture de l'ennemi");
                        Console.ResetColor();
                        float CaptureSucces;
                        CaptureSucces = ((Enemy.Hpmax - Enemy.Hp)/100)- 1/2;
                        if (CaptureSucces>0.5)
                        {
                            int randomCapture = rdm.Next(1, 2);
                            if (randomCapture == 1)
                            {
                                Red("Tu as FAIL");
                            }
                            else
                            {
                                Player.sharpmons.Add(Enemy);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tu as capturé " + Enemy.name + "!");
                                Console.ResetColor();
                                break;
                            }
                        }
                        if (CaptureSucces<0.5)
                        {
                            int randomCapture = rdm.Next(1, 4);
                            if (randomCapture == 1 || randomCapture == 3)
                            {
                                Red("Tu as FAIL");
                            }
                            else
                            {
                                Player.sharpmons.Add(Enemy);
                                Green("Tu as capturé " + Enemy.name + "!");
                                break;
                            }
                        }
                    }
                    else if (actions.Key == ConsoleKey.F)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("***Tentative de fuite :p !");
                        Console.ResetColor();
                        float rc = Fighter.Dodge+Enemy.Dodge;
                        float RunAway = (Fighter.Dodge/rc);
                        if (RunAway > 0.5)
                        {
                            int randomFuite = rdm.Next(1, 2);
                            if (randomFuite == 1)
                            {
                                Red("Tu as FAIL");
                            }
                            else
                            {
                                Console.Clear();
                                Red("Tu as fuis le combat !");
                                System.Threading.Thread.Sleep(5000);
                                break;
                            }
                        }
                        if (RunAway < 0.5)
                        {
                            int randomFuite = rdm.Next(1, 4);
                            if (randomFuite == 1 || randomFuite == 3)
                            {
                                Red("Tu as FAIL");
                            }
                            else
                            {
                                Console.Clear();
                                Red("Tu as fuis le combat !");
                                System.Threading.Thread.Sleep(5000);
                                break;
                            }
                        }
                    }
                    else
                        {
                        Red("Erreur");
                        Tour += 1;
                        }
                }
                else if(Tour == 0)
                {
                    Console.WriteLine("Fin de ton tour");
                    int randomAttack = rdm.Next(1, 3);
                    if (randomAttack == 1)
                    {  
                        Enemy.Attacks1();
                    }
                    else if (randomAttack == 2 || randomAttack == 3)
                    {
                        Enemy.Attacks2(Fighter, Fighter.Power, Fighter.Hp);
                    }
                    Tour = 1;
                }
                if (Enemy.Hp <= 0 && Enemy.Hp >= -100)
                {
                    Green("Tu as gagner");
                    Fighter.Xp += rdm.Next(0, 500) * Enemy.Level;
                    Green("+" + Fighter.Xp + "Xp");
                    if (Fighter.Xp >= Fighter.NextLevel)
                    {
                        Levelup(Fighter);
                    }
                    break;
                }
                if (Fighter.Hp <= 0 && Fighter.Hp >= -10)
                {
                    Red("Tu as perdu");
                    break;
                }
            }
            Console.WriteLine("M- Menu");
            Commandes();
        }

        static void Shop()
        {
            Console.Clear();
            Console.WriteLine(@"
                                  *******************
                                  ***  $$ SHOP $$ ***
                                  *******************");
            Green(Player.sharpdollars+ "Sharpodollars");
            ItemShop.Potion item = new ItemShop.Potion();
            ItemShop.SuperPotion item2 = new ItemShop.SuperPotion();
            ItemShop.LandyRare item3 = new ItemShop.LandyRare();    
            Red("  "+ item.name +" Prix : " + item.price + " Description : " + item.description + " ");
            Red("  " + item2.name + " Prix :" + item2.price + " Description : " + item2.description + " ");
            Red("  " + item3.name + " Prix : " + item3.price + "  Description : " + item3.description + " ");

            Console.WriteLine(@"
                *************************************************************************************
                ***           $$ Acheter $$               ***             $$ Vendre $$            ***
                ***      Touche P : Acheter Potion        ***     Touche V : Vendre Potion        ***
                ***      Touche K : Acheter Super Potion  ***     Touche B : Vendre Super Potion  ***
                ***      Touche L : Acheter Landy Rare    ***     Touche N : Vendre Landy Rare    ***
                *************************************************************************************");
            Console.WriteLine(@"
                                  *************************
                                  ***  $$ INVENTAIRE $$ ***
                                  *************************");
            Blue("Potion : " + Player.Items["Potion"] + " - Prix a la revente :" + item.price/2 + " $" );
            Blue("SuperPotion : " + Player.Items["SuperPotion"] + " - Prix a la revente :" + item2.price/2 + " $");
            Blue("LandyRare : " + Player.Items["LandyRare"] + " - Prix a la revente :" + item3.price/2 + " $");

            ConsoleKeyInfo choixachats = Console.ReadKey(true);
            if (choixachats.Key == ConsoleKey.P)
            {
                if (Player.sharpdollars >= 100)
                {
                    Player.sharpdollars -= 100;
                    Blue("Tu as acheter une Potion !");
                    Player.Items["Potion"] += 1;
                }
                else
                {
                    Red("Tu n'a pas assez de Sharpdollars :(");
                }
                Shop();
            }
            else if (choixachats.Key == ConsoleKey.S)
            {
                if (Player.sharpdollars >= 150)
                {
                    Player.sharpdollars -= 150;
                    Blue("Tu as acheter une SuperPotion !");
                    Player.Items["SuperPotion"] += 1;

                }
                else
                {
                    Red("Tu n'a pas assez de Sharpdollars :(");
                }                
                Shop();
            }
            else if (choixachats.Key == ConsoleKey.L)
            {
                if (Player.sharpdollars >= 1500)
                {
                    Player.sharpdollars -= 1500;
                    Blue("Tu as acheter une LandyRare !");
                    Player.Items["LandyRare"] += 1;
                }
                else
                {
                    Red("Tu n'a pas assez de Sharpdollars :(");
                }
                Shop();
            }
            else if (choixachats.Key == ConsoleKey.V)
            {
                if (Player.Items["Potion"] >= 1)
                {
                    Player.sharpdollars += 50;
                    Player.Items["Potion"] -= 1;
                    Green("Tu as vendu une Potion !");
                }
                else
                {
                    Red("Tu n'a pas assez de Potion :(");
                }
                Shop();
            }
            else if (choixachats.Key == ConsoleKey.B)
            {
                if (Player.Items["SuperPotion"] >= 1)
                {
                    Player.sharpdollars += 75;
                    Player.Items["SuperPotion"] -= 1;
                    Green("Tu as vendu une SuperPotion !");
                }
                else
                {
                    Red("Tu n'a pas assez de SuperPotion :(");
                }
                Shop();
            }
            else if (choixachats.Key == ConsoleKey.N)
            {
                if (Player.Items["LandyRare"] >= 1)
                {
                    Player.sharpdollars += 750;
                    Player.Items["LandyRare"] -= 1;
                    Green("Tu as vendu une LandyRare !");
                }
                else
                {
                    Red("Tu n'a pas assez de LandyRare :(");
                }
                Shop();
            }
            else if (choixachats.Key == ConsoleKey.M)
            {
                Menu();
            }
            else
            {
                Shop();
            }

        }

        public static void Center()
        {
            Console.Clear();
            Console.WriteLine(@"
                                    *******************************
                                    ** <3 Heal your Sharpmons <3 **
                                    **    Touche H : Soigner     **
                                    *******************************");
            foreach(dynamic sharp in Player.sharpmons)
            {
                Blue(sharp.name + " -- Level: " + sharp.Level);
                Green(sharp.Hp + "/" + sharp.Hpmax + "Hp ---- " + "Dodge: " + sharp.Dodge);
                Green("Speed: " + sharp.Speed + " ---- Defense: " + sharp.Defense);
                Green("Accuracy: " + sharp.Accuracy + "  ---- " + "Power: " + sharp.Power);
                Red(sharp.Xp + "/" + sharp.NextLevel + " XP");

            }
            ConsoleKeyInfo choixheal = Console.ReadKey(true);
                if (choixheal.Key == ConsoleKey.H)
                {
                    Console.Clear();
                    foreach (dynamic sharp in Player.sharpmons)
                    {
                        dynamic heal = sharp.Hpmax;
                        sharp.Hp = heal;
                        Green(sharp.name + "a été soigner ! :)");
                    }
                System.Threading.Thread.Sleep(2000);
                Center();
                }
                else if (choixheal.Key == ConsoleKey.M)
                {
                    Menu();
                }
                else
                {
                    Center();
                }

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Honneur et Force {0} pour la suite !", Player.name);
            Green("Tu as " + Player.sharpdollars + " sharpdollars !");
            Console.WriteLine(@"
                                    ***************************
                                    *Welcome in Sharpmon world*
                                    ***************************");
            Console.WriteLine(@"Where do you want to go ?");
            Console.WriteLine(@"**Touche W* -- Into the wild");
            Console.WriteLine(@"**Touche S* -- In the shop");
            Console.WriteLine(@"**Touche C* -- In the Sharpmon Center");
            Console.WriteLine(@"**Touche M* -- Menu");
            Console.WriteLine(@"**Touche Q* -- Quitter :( ");
            Commandes();
        }
        static void Commandes()
        {
            ConsoleKeyInfo choix = Console.ReadKey(true);
            if (choix.Key == ConsoleKey.W)
            {
                Wild();
            }
            else if (choix.Key == ConsoleKey.S)
            {
                Shop();
            }
            else if (choix.Key == ConsoleKey.C)
            {
                Center();
            }
            else if (choix.Key == ConsoleKey.M)
            {
                Menu();
            }
            else if (choix.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            if (Player.name == "")
            {
                while (Player.name == "")
                {
                    Green("Choisis ton nom de Dresseur :");
                    Player.name = Console.ReadLine();
                    Console.Clear();                  
                }         
                Player.sharpdollars = 150;
                Menu();
                Commandes();
            }
            else
            {
                Menu();
            }
            Console.ReadKey();
        }
    }
}
