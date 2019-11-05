using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Main_Classes_For_Game
{
    public class Item
    {
        protected int current_durability;
        protected int max_durability;
        protected string rare;
        public int CurrentDurability
        {
            get
            {
                return current_durability;
            }
            set
            {
                if (value >= 0 && value <= max_durability)
                {
                    current_durability = value;
                }
            }
        }
        public int MaxDurability
        {
            get
            {
                return max_durability;
            }
            set
            {
                if (value >= 0)
                {
                    max_durability = value;
                }
            }
        }
        public string Rare
        {
            get
            {
                return rare;
            }
            set
            {
                rare = value;
            }
        }
    }
    public class Weapon : Item
    {
        protected double damage;
        public double Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0)
                {
                    damage = value;
                }
            }
        }
        public Weapon(string PathToConfigOfWeapon)
        {
            WorkWithFiles ParseConfig = new WorkWithFiles();
            string[,] Values = ParseConfig.FileParser(PathToConfigOfWeapon);
            for (int i = 0; i < Values.GetLength(1); i++)
            {
                string CurrentParametr = Values[0, i];
                string Value = Values[1, i];
                if (CurrentParametr == "Rare")
                {
                    Rare = Value;
                }
                if (CurrentParametr == "Damage")
                {
                    Damage = double.Parse(Value);
                }
                if (CurrentParametr == "MaxDurability")
                {
                    MaxDurability = int.Parse(Value);
                }
                if (CurrentParametr == "CurrentDurability")
                {
                    CurrentDurability = int.Parse(Value);
                }
            }
        }
    }

    public class Character 
    {
        protected double health;
        protected double mana;
        protected double armor;
        protected double stamina;
        protected double damage;
        protected double agility;
        protected double strength;
        protected double intellegence;
        protected double attack_speed;
        protected double blood_clots_amount;
        protected double ratio_of_getting_clots;
        protected double getting_increase_from_base_talent;
        protected double[] coordinates = new double[2]; //x == [0], y = [1];

        public double Health
        {
            get
            {
                return health;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    health = value;
                }
            } 
        }
        public double Mana
        {
            get
            {
                return mana;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    mana = value;
                }
            }
        }
        public double Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    armor = value;
                }
            }
        }
        public double Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    stamina = value;
                }
            }
        }
        public double Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    damage = value;
                }
            }
        }
        public double Agility
        {
            get
            {
                return agility;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    agility = value;
                }
            }
        }
        public double Strength
        {
            get
            {
                return strength;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    strength = value;
                }
            }
        }
        public double Intellegence
        {
            get
            {
                return intellegence;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    intellegence = value;
                }
            }
        }
        public double AttackSpeed
        {
            get
            {
                return attack_speed;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    attack_speed = value;
                }
            }
        }
        public double BloodClotsAmount
        {
            get
            {
                return blood_clots_amount;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    blood_clots_amount = value;
                }
            }
        }
        public double RatioOfGettingClots
        {
            get
            {
                return ratio_of_getting_clots;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    ratio_of_getting_clots = value;
                }
            }
        }
        public double GettingIncreaseFromBaseTalent
        {
            get
            {
                return getting_increase_from_base_talent;
            }
            set
            {
                if ((value >= double.MinValue) && (value <= double.MaxValue))
                {
                    getting_increase_from_base_talent = value;
                }
            }
        }
        public double[] Coordinates
        {
            get
            {
                return coordinates;
            }
            set
            {
                if ((value[0] >= double.MinValue) && (value[0] <= double.MaxValue))
                {
                    coordinates[0] = value[0]; 
                }
                if ((value[1] >= double.MinValue) && (value[1] <= double.MaxValue))
                {
                    coordinates[1] = value[1];
                }
            }
        }
        //конструктор класса
        public Character(string PathToConfigOfBaseCharacteristics)
        {
            WorkWithFiles ParseConfig = new WorkWithFiles();
            string [,] Values = ParseConfig.FileParser(PathToConfigOfBaseCharacteristics);
            for (int i = 0; i < Values.GetLength(1); i++)
            {
                string CurrentParametr = Values[0, i];
                string Value = Values[1, i];
                if (CurrentParametr == "CharacterHealth")
                {
                    Health = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterMana")
                {
                    Mana = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterArmor")
                {
                    Armor = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterStamina")
                {
                    Stamina = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterDamage")
                {
                    Damage = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterAgility")
                {
                    Agility = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterStrength")
                {
                    Strength = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterIntellegence")
                {
                    Intellegence = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterAttackSpeed")
                {
                    AttackSpeed = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterCoordinates[x]")
                {
                    Coordinates[0] = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterCoordinates[y]")
                {
                    Coordinates[1] = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterBloodClotsAmount")
                {
                    BloodClotsAmount = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterRatioOfGettingClots")
                {
                    RatioOfGettingClots = double.Parse(Value);
                }
                if (CurrentParametr == "CharacterGettingIncreaseFromBaseTalent")
                {
                    GettingIncreaseFromBaseTalent = double.Parse(Value);
                }
            }
        }
        
        public void Print() //метод для отладки
        {
            Console.WriteLine("Health = {0}",Health);
            Console.WriteLine("Mana = {0}",Mana);
            Console.WriteLine("Armor = {0}",Armor);
            Console.WriteLine("Stamina = {0}",Stamina);
            Console.WriteLine("Damage = {0}",Damage);
            Console.WriteLine("Agility = {0}",Agility);
            Console.WriteLine("Strength = {0}",Strength);
            Console.WriteLine("Intellegence = {0}",Intellegence);
            Console.WriteLine("AttackSpeed = {0}",AttackSpeed);
            Console.WriteLine("Coordinates[x] = {0}", Coordinates[0]);
            Console.WriteLine("Coordinates[y] = {0}", Coordinates[1]);
            Console.WriteLine("BloodClotsAmount = {0}",BloodClotsAmount);
            Console.WriteLine("RatioOfGettingClots = {0}",RatioOfGettingClots);
            Console.WriteLine("GettingIncreaseFromBaseTalent = {0}", GettingIncreaseFromBaseTalent);
        }

        public virtual void GetBasicTalentsAndItems()
        {
            RatioOfGettingClots *= GettingIncreaseFromBaseTalent;    
        }
    }
    
    public class Warrior : Character
    {
        protected double basic_increase_health_from_class_warrior;
        double BasicIncreaseHealthFromClassWarrior
        {
            get
            {
                return basic_increase_health_from_class_warrior;
            }
            set
            {
                if (value >= 0)
                {
                    basic_increase_health_from_class_warrior = value;
                }
            }
        }
        public Warrior(string path, string PathToConfigOfClassWarrior) : base(path)
        {
            WorkWithFiles ParseConfig = new WorkWithFiles();
            string[,] Values = ParseConfig.FileParser(PathToConfigOfClassWarrior);
            for (int i = 0; i < Values.GetLength(1); i++)
            {
                string CurrentParametr = Values[0, i];
                string Value = Values[1, i];
                if (CurrentParametr == "WarriorBasicIncreaseHealthFromClassWarrior")
                {
                    BasicIncreaseHealthFromClassWarrior = double.Parse(Value);
                }
            }
            GetBasicTalentsAndItems();
        }
        public override void GetBasicTalentsAndItems()
        {
            Health += BasicIncreaseHealthFromClassWarrior;
        }
    }

    public class WorkWithFiles
    {
        public string[,] FileParser(string FilePath)
        {
            using (StreamReader Config = new StreamReader(FilePath, System.Text.Encoding.Default)) //using == замена конструкции try - catch
            {
                string[] Parametrs = new string[10000];
                string line;
                int k = 0;
                while ((line = Config.ReadLine()) != null)
                {
                    Parametrs[k] = line;
                    k++;
                }
                Config.Close();
                string[,] ReturnValues = new string[2,k];
                for (int i = 0; i < k; i++)
                {
                    int j = 0;
                    string CurrentParametr = "";
                    while (Parametrs[i][j] != ' ')
                    {
                        CurrentParametr += Parametrs[i][j];
                        j++;
                    }
                    j += 3;
                    ReturnValues[0,i] = CurrentParametr;
                    string CurrentParametrValue = "";
                    while (Parametrs[i][j] != ';')
                    {
                        CurrentParametrValue += Parametrs[i][j];
                        j++;
                    }
                    ReturnValues[1,i] = CurrentParametrValue;
                }
                return ReturnValues;
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Character player = new Character("C:/Users/олег/Desktop/RpgGame/ConfigOfCharacter.txt");
            Console.WriteLine("Character: ");
            
            
            player.GetBasicTalentsAndItems();
            player.Print();
            Console.WriteLine("Warrior: ");
            Warrior gamer = new Warrior("C:/Users/олег/Desktop/RpgGame/ConfigOfCharacter.txt", "C:/Users/олег/Desktop/RpgGame/ConfigOfWarrior.txt");
            gamer.Print();

        }
    }
}
