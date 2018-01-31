namespace FridgeOOP
{
    public class Fridge
    {
        //Fields
        private bool isClean;

        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //Properties
        public bool IsClean
        {
            get { return this.IsClean; }
            set { this.IsClean = value; }
        }

        public string DispenserType
        {
            get { return this.DispenserType; } //No set value do to hard coding the value
        }

        public string FoodAmount
        {
            get { return this.FoodAmount; }
            set { this.FoodAmount = value; }
        }

        public string BulbsWork
        {
            get { return this.BulbsWork; }
            set { this.BulbsWork = value; }
        }

        //Constructor allows us to create an instance of a class
        public Fridge()
        {
            this.dispenserType = "Basic water dispenser";
        }

        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }

        public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }

        //Methods()
        //I need a way to dispense water

        public void DispenseWater()
        {
            if (dispenserType == "basic water dispenser.")
            {
                System.Console.WriteLine("Here's some lukewarm water.");
            }
            else if (dispenserType == "deluxe dispenser.")
            {
                System.Console.WriteLine("Enjoy your perfect ice water.");
            }
            else
            {
                System.Console.WriteLine("What's gonna come out? It's a surprise.");
            }
        }

        public string ChangeBulbs()
        {
            if (bulbsWork == false)
            {
                bulbsWork = true;
                return "The bulbs have been changed.";
            }
            else
            {
                return "The bulbs don't have to be changed.";
            }
        }

        public void RemoveFood(int foodRemoved)
        {
            foodAmount -= foodRemoved;
        }

        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return "fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "getting low";
            }
            else
            {
                return "time to go to the west side market";
            }
        }

        public string Clean(bool isDirty)
        {
            if (isDirty)
            {
                isClean = true;
                return "I cleaned the fridge";
            }
            else
            {
                return "The fridge is already clean";
            }
        }
    }
}

//Get allows to see the value to print to console, see another class, etc
//Set allows us to set value 