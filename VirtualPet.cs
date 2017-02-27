using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {   //fields
        //properties
        //constructors
        //methods 

        //Fields == (instance) variables
        private string name;//Lionel Z. L'P-Ard
        private string myColor;//gold
        private int playfulness;//Happy Playful Leopard
        private int sleepiness;//sweetly sleeping
        private int treeClimbing;
        private int mySpeed;//36 mph
        private string age; //7 years

        //constructors
        public Pet()
        {
            this.name = "Lionel Z. L'P-Ard";
            this.myColor = "golden brown";
            this.playfulness = 10;
            this.sleepiness = 2;
            this.treeClimbing = 7;
            this.mySpeed = 36;
            this.age = "7";
        }

        public Pet(string name, int playfullness, int treeClimbing)
        {
            this.name = name;
            this.playfulness = playfullness;
            this.treeClimbing = treeClimbing;
        }

        public Pet(int treeClimbing, int sleepiness, int mySpeed)
        {
            this.treeClimbing = treeClimbing;
            this.sleepiness = sleepiness;
            this.mySpeed = mySpeed;
        }

        public Pet(string name, string myColor, int mySpeed, string age)
        {
            this.name = name;
            this.myColor = myColor;
            this.mySpeed = mySpeed;
            this.age = age;
        }
        public Pet(string name, string myColor, int playfullness, int sleepiness, int treeClimbing, int mySpeed, string age)
        {
            this.name = name;
            this.myColor = myColor;
            this.playfulness = playfullness;
            this.sleepiness = sleepiness;
            this.treeClimbing = treeClimbing;
            this.mySpeed = mySpeed;
            this.age = age;
        }
        //Properties
        public string Animal
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string FurColor
        {
            get { return this.myColor; }
            set { this.myColor = value; }
        }
        public int Speed
        {
            get { return this.mySpeed; }
            set { this.mySpeed = value; }
        }
        public string Years
        {
            get { return this.age; }
            set { this.age = value; }
        }

        //Beginning of Methods  
        //The uniqueness of Utsukushii
        public void SayMyName()
        {
            Console.WriteLine("\a\aGood day! I am {0} the lovely leopard!", name);
        }

        public void FurColors()
        {
            Console.WriteLine("\nI have a majestic {0} coat adorned\nwith a special black rosette pattern", myColor);
        }

        public void Fun()
        {
            Console.WriteLine("\n{0} Let's climb a tree! We can figure\nthe rest out as we go along friend.", playfulness);
        }

        public void Fatigue()
        {
            Console.WriteLine("\n{0} Do something or I'm going to sleep.", sleepiness);
        }
        public void ImFast()
        {
            Console.WriteLine("\nI can run about {0} miles per hour.\nI'm super speedy quick...If I say so myself!", mySpeed);
        }
        public void MyAge()
        {
            Console.WriteLine("\nI am {0} years old...the perfect age!", age);
            Console.WriteLine("");
        }

        public void Tick()
        {
            mySpeed = 4;
            while (mySpeed <= 10 || sleepiness <= 7)
            {
                Console.WriteLine("My speed is at a " + mySpeed + " and when it decreases when I grow tired.\nPlay with me so I won't fall asleep!");
                Console.WriteLine("");
                mySpeed++;
                break;
            }

            //private string myColor; 
            //private int playfulness; 
            //private int sleepiness; 
            //private int treeClimbing;
            //private int mySpeed;      
            //int playfulness = 0;
            //while (playfulness > 1 || playfulness < 500)
            //{
            //    Console.WriteLine("Please enter a number greater than 3 if you want to play with Lionel or less than three if you want her to go to sleep.");
            //    string playOrSleep = Console.ReadLine();
            //    playfulness = Convert.ToInt32(playOrSleep);
            //}
            //Console.WriteLine("What is your favorite roygbiv color? \nif you do not know what a roygbiv color is, please type help");
            //string userColor = Console.ReadLine();

            //if (playfulness > 3 || sleepiness < 3)
            //{
            //    Console.WriteLine("I want to climb a tree. Come climb with me!");
            //    userColor = Console.ReadLine();//how to put in an option that says hey you're
            //}

            var arr = new[]

            {

                (@"
                                                                                                  _
                                                                                              __ | __`.
                                                                                           . '       `--.
                                                                                        .- '             . `-.
.                                                                                  .----'       .`--    -`    )_
 .                                       _..----.._......---- - '             `-\     _ )__-`
 .                          .'       .--'          `--.___..------ -````                             .-/`.)'     ''
  .                     / '..     .' |\.    .                                                               '''
   ...'   .'                                                        '``'  `'`                                       '''
              `./     `/ .'   .'                                                           \ `
                         -. .'      .--'.                                               .'                         .'
                           '             `-.                           .'.'               .'.       .'
                          '                 `.                         '.'             _-' -\    .'              Lovely leopard on the move...
                         '                    `.                     .--`.            '         `-_ - '      ``--'
              `--.      '                       `-.             ..--'.            ._'   \       '
                  `-.   '                        `.' -.      ..- '         `.          .'    _.- ''      `-...- '
                     `-'                          `.  '-- - '              .        .'--''
                       '                             `.     __            ,       (.-'
                       '    `-.           `-.          `.  /   `           \      \
                       '     .'`--.         .'`.         ' `  _ /           \      \
                       '    '      ``------'  `.`         .'  )\         .-' \      \
                       '   `                    `-._      '.' /  _..-'.'   \      \
                      '   '`-                      .`.        '''   .'      `.     \
                     .    '  `--.               .-'   `.  '.'.'          `.    \

                 .       `--..         .'       `..'         '             \    )
                    '   '             `-.._.'           `.       -'              \    \
                   .   .                   `-'               `.      :               `-```)
                   '   .                                       `     `.                `''
                   `   :                                        `.    '
                  .   .                                          .`    `
                  .   .                                           `.    `
                  .   .                                             `.   `.
                  `.   .                                              .    .
                   .   `                                               `.   `.
                   '   .                                                `-.  .`.
                    `   .                                                   `.-'
                    '   .
                    '   .
                    .   '
                   '   `
                  '   '
                 '   .
                `   .
                .   '
                `-'

@") }; 
            {
                Console.WindowWidth = 160;
                Console.WriteLine("\n\n");
                foreach (string line in arr) 
                Console.WriteLine(line);
                Console.ReadKey();
            }

        }
    }
}
