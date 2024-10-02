//Hi, the general purpose of this program is to encourage people to stay within their calorie limit for fitness purposes
//This can act as a calorie tracker that can help people pay close attention to the calorie counts of different meals they have during the day.
using System.Xml;

namespace Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nPut the amount of pounds(lbs) you weigh");
            double pounds = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your ideal weight?");
            double ideal = double.Parse(Console.ReadLine());
            double lose = pounds - ideal;
            Console.WriteLine("\nHow tall are you in inches?");
            double inches = double.Parse(Console.ReadLine());
            double BMI = ((pounds * 703) / inches / inches);
            if ((18.5 <= BMI) && (24.9 >= BMI))
            {
                Console.WriteLine("You are at a healthy weight");
            }
            else if ((25 <= BMI) && (29.9 >= BMI))
            {
                Console.WriteLine("You are in the overweight zone");
            }
            else if (BMI < 18.5)
            {
                Console.WriteLine("You are in the underweight zone");
            }
            else
            {
                Console.WriteLine("You are in the obese zone");
            }
            Console.WriteLine("No worries, no matter your BMI, we can get your health back on track");
       
            double Totalcalories = 0; //Set this in days in each days to change calorie count track so not sure yet
            Console.WriteLine($"\nYour goal is to lose {lose} pounds within a set period of time");
            Console.WriteLine("\nLet's work on your goal!");
            

            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (string day in days) {
                Console.WriteLine($"\n {day}'s Plan:");
                //List for saving exact food types
                List<string> meat = new List<string>();
                meat.Add("chicken breast");
                meat.Add("turkey breast");
                meat.Add("lean beef");
                meat.Add("salmon fillet");
                meat.Add("pork tenderloin");
                string chicken = meat[0];
                string turkey = meat[1];
                string beef = meat[2];
                string salmon = meat[3];
                string pork = meat[4];
                int meat_options = meat.Count();
                //Measurements for food calculations(in ounces(oz)):
                //chicken breast 4.23 oz= 198 calories
                //ground beef 1 oz cooked=77 calories
                //pork tenderloin 3 oz=125 calories
                //salmon fillet 8oz= 468 calories
                //turkey breast 3 oz= 125 calories
                double chickenmeasure = (4.23);
                double beefmeasure = (1);
                double porkmeasure = (3);
                double salmonmeasure = (8);
                double turkeymeasure = (3);
                //List for saving calorie values attributed to each food's assigned calories
                List<double> meatcalories = new List<double>();
                meatcalories.Add(198);
                meatcalories.Add(77);
                meatcalories.Add(125);
                meatcalories.Add(468);
                meatcalories.Add(125);
                double chickencal = meatcalories[0];
                double turkeycal = meatcalories[1];
                double beefcal = meatcalories[2];
                double salmoncal = meatcalories[3];
                double porkcal = meatcalories[4];

                Console.WriteLine($"\nThere are currently {meat_options} meat options in your plan");
                Console.WriteLine($"\nThese include {chicken}, {turkey}, {beef}, {salmon},and {pork}");
                Console.WriteLine("\nNote: These calories are for one serving size!");
                Console.WriteLine("\n\nPick one of the meat options to begin)" +
                    "(\nType in turkey for turkeybreast, chicken for chicken breast, beef for lean beef, salmon for salmon fillet, and pork for pork tenderloin\n");
                string meatoptions = Console.ReadLine();


                if (meatoptions == "turkey")
                {
                    Totalcalories = Totalcalories + turkeycal;
                    Console.WriteLine($"\n Your meat of choice:{turkey}, How much it weighs:{turkeymeasure} ounces, and it has {turkeycal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (meatoptions == "chicken")
                {
                    Totalcalories = Totalcalories + chickencal;
                    Console.WriteLine($"\n Your meat of choice:{chicken}, How much it weighs:{chickenmeasure} ounces, and it has {chickencal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (meatoptions == "beef")
                {
                    Totalcalories = Totalcalories + beefcal;
                    Console.WriteLine($"\n Your meat of choice:{beef}, How much it weighs:{beefmeasure} ounces, and it has {beefcal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (meatoptions == "pork")
                {
                    Totalcalories = Totalcalories + porkcal;
                    Console.WriteLine($"\n Your meat of choice:{pork}, How much it weighs:{porkmeasure} ounces, and it has {porkcal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (meatoptions == "salmon")
                {
                    Totalcalories = Totalcalories + salmoncal;
                    Console.WriteLine($"\n Your meat of choice:{salmon}, How much it weighs:{salmonmeasure} ounces, and it has {salmoncal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                List<string> vegetable = new List<string>();
                vegetable.Add("spinach");
                vegetable.Add("broccoli");
                vegetable.Add("greenbeans");
                vegetable.Add("carrots");
                vegetable.Add("yellowsquash");
                string spinach = vegetable[0];
                string broccoli = vegetable[1];
                string greenbeans = vegetable[2];
                string carrots = vegetable[3];
                string yellowsquash = vegetable[4];
                int vegetable_options = vegetable.Count();
                //Measurements for food calculations(in ounces(oz)):
                //spinach 1 oz= 7 calories
                // broccoli 8 oz cooked= 31 calories
                //greenbean 8 oz= 34 calories
                //carrot 3.5 oz= 41 calories
                //yellow squash 3.46 oz= 28 calories
                double spinachmeasure = (1);
                double broccolimeasure = (8);
                double greenbeansmeasure = (8);
                double carrotsmeasure = (3.5);
                double yellowsquashmeasure = (3.46);
                //List for saving calorie values attributed to each food's assigned calories
                List<double> vegetablecalories = new List<double>();
                vegetablecalories.Add(7);
                vegetablecalories.Add(31);
                vegetablecalories.Add(34);
                vegetablecalories.Add(41);
                vegetablecalories.Add(20);
                double spinachcal = vegetablecalories[0];
                double broccolical = vegetablecalories[1];
                double greenbeanscal = vegetablecalories[2];
                double carrotscal = vegetablecalories[3];
                double yellowsquashcal = vegetablecalories[4];



                Console.WriteLine($"\nThere are currently {vegetable_options} vegetable options in your plan");
                Console.WriteLine($"\nThese include {spinach}, {broccoli}, {greenbeans}, {carrots},and {yellowsquash}");
                Console.WriteLine("\nNote: These calories are for one serving size!");
                Console.WriteLine("\n\nPick one of the vegetable options to begin)" +
                    "(\nspinach, broccoli, greenbeans, carrots, or yellowsquash \n");

                string vegetableoptions = Console.ReadLine();

                if (vegetableoptions == "spinach")
                {
                    Totalcalories = Totalcalories + spinachcal;
                    Console.WriteLine($"\n Your vegetable of choice:{spinach},How much it weighs:{spinachmeasure} ounces, and it has {spinachcal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (vegetableoptions == "broccoli")
                {
                    Totalcalories = Totalcalories + broccolical;
                    Console.WriteLine($"\n Your vegetable of choice:{broccoli}, How much it weighs:{broccolimeasure} ounces, and it has {broccolical} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (vegetableoptions == "greenbeans")
                {
                    Totalcalories = Totalcalories + greenbeanscal;
                    Console.WriteLine($"\n Your vegetable of choice:{greenbeans}, How much it weighs:{greenbeansmeasure} ounces, and it has {greenbeanscal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (vegetableoptions == "carrots")
                {
                    Totalcalories = Totalcalories + carrotscal;
                    Console.WriteLine($"\n Your vegetable of choice:{carrots}, How much it weighs:{carrotsmeasure} ounces, and it has {carrotscal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (vegetableoptions == "yellowsquash")
                {
                    Totalcalories = Totalcalories + yellowsquashcal;
                    Console.WriteLine($"\n Your vegetable of choice:{yellowsquash}, How much it weighs:{yellowsquashmeasure} ounces, and it has {yellowsquashcal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }

                List<string> grains = new List<string>();

                grains.Add("proteinspaghetti");
                grains.Add("brownrice");
                grains.Add("couscous");
                grains.Add("naturesown_ketobread");

                string proteinspaghetti = grains[0];
                string brownrice = grains[1];
                string couscous = grains[2];
                string naturesown_ketobread = grains[3];

                int grains_options = grains.Count();
                //Measurements for food calculations(in ounces(oz)):
                //proteinspaghetti 8 oz =220 calories
                // brownrice 8 oz cooked= 215 calories
                //couscous 8 oz= 180 calories
                //naturesown_ketobread 0.9877 ounces/1 slice= 35 calories

                double proteinspaghettimeasure = (8);
                double brownricemeasure = (8);
                double couscousmeasure = (8);
                double naturesown_ketobreadmeasure = (1);

                //List for saving calorie values attributed to each food's assigned calories
                List<double> grainscalories = new List<double>();
                grainscalories.Add(7);
                grainscalories.Add(31);
                grainscalories.Add(34);
                grainscalories.Add(41);
                double proteinspaghettical = grainscalories[0];
                double brownricecal = grainscalories[1];
                double couscouscal = grainscalories[2];
                double naturesown_ketobreadcal = grainscalories[3];

                int grains_option = grains.Count();
                Console.WriteLine($"\nThere are currently {grains_option} grain options in your plan");
                Console.WriteLine($"\nThese include {spinach}, {broccoli}, {greenbeans}, {carrots},and {yellowsquash}");
                Console.WriteLine("\nNote: These calories are for one serving size!");
                Console.WriteLine("\n\nPick one of the grain options to begin)" +
                    "(\nproteinspaghetti, brownrice, couscous,or naturesown_ketobread \n");
                string grainoptions = Console.ReadLine();
                if (grainoptions == "proteinspaghetti")
                {
                    Totalcalories = Totalcalories + proteinspaghettical;
                    Console.WriteLine($"\n Your vegetable of choice:{spinach},How much it weighs:{proteinspaghettimeasure} ounces, and it has {proteinspaghettical} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (grainoptions == "brownrice")
                {
                    Totalcalories = Totalcalories + brownricecal;
                    Console.WriteLine($"\n Your vegetable of choice:{brownrice}, How much it weighs:{brownricemeasure} ounces, and it has {brownricecal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (grainoptions == "couscous")
                {
                    Totalcalories = Totalcalories + couscouscal;
                    Console.WriteLine($"\n Your vegetable of choice:{couscous}, How much it weighs:{couscousmeasure} ounces, and it has {couscouscal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                else if (grainoptions == "naturesown_ketobread")
                {
                    Totalcalories = Totalcalories + naturesown_ketobreadcal;
                    Console.WriteLine($"\n Your vegetable of choice:{carrots}, How much it weighs:{naturesown_ketobreadmeasure} ounces, and it has {naturesown_ketobreadcal} calories.");
                    Console.WriteLine($"\n Your total calories are now: {Totalcalories}");
                }
                //Water is generally known to have 0 calories no matter the serving, so it will be advised to drink as it is healthier and better option for this diet. 
                Console.WriteLine("\nFor the drinks portions of this diet, you will be advised to drink water");
                Console.WriteLine("\nWrite water to continue");
                string drinkwater = Console.ReadLine();
                double drinkwatercal = 0;
                if (drinkwater == "water")
                { Totalcalories = Totalcalories + drinkwatercal;
                    Console.WriteLine($"\n Total calories for the week so far are {Totalcalories} for {day}!");

                }




            }
        
            
            }
        
    }
}


