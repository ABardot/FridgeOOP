namespace FridgeOOP
{
    public class Fridge
    {
        //Fields
        private int isClean;
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
            get { return this.DispenserType; }
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

        //Constructor
        public Fridge()
        {
            //Default
        }

        public Fridge(int isClean, string dispenserType, int foodAmount, bool bulbWorks)
        {
        }

        //Methods()
    }
}

//Get allows to see the value to print to console, see another class, etc
//Set allows us to set value 