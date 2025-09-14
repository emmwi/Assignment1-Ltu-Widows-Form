namespace cashRegistry
{
    public partial class CashRegistryForm1 : Form
    {
        public CashRegistryForm1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // clear the list in the listbox when "räkna"- button is clicked. 
            listBox1.Items.Clear();

            int price;
            int paidMoney;
            int moneyBack;
            //setting all bill- and coin values to zero to make sure that no old text is still shown in the listbox.
            int oneCoin = 0;
            int fiveCoin = 0;
            int tenCoin = 0;

            int twentyBill = 0;
            int fiftyBill = 0;
            int hundredBill = 0;
            int twohundredBill = 0;
            int fivehundredBill = 0;

            string priceValue = textBox1.Text;
            string paidValue = textBox2.Text;
            price = int.Parse(priceValue);
            paidMoney = int.Parse(paidValue);


            if (paidMoney < price)
            {
                listBox1.Items.Add("Du har betalt för lite, vänligen försök igen.");
            }
            moneyBack = paidMoney - price;

            //If-statements to count how many bills or coins of each value is being used. 
            if (moneyBack >= 500)
            {

                fivehundredBill = moneyBack / 500;
                int reducePrice = fivehundredBill * 500;
                moneyBack = moneyBack - reducePrice;
            }

            if (moneyBack >= 200)
            {
                twohundredBill = moneyBack / 200;
                int reducePrice = twohundredBill * 200;
                moneyBack = moneyBack - reducePrice;
            }

            if (moneyBack >= 100)
            {
                hundredBill = moneyBack / 100;
                int reducePrice = hundredBill * 100;
                moneyBack = moneyBack - reducePrice;
            }

            if (moneyBack >= 50)
            {
                fiftyBill = moneyBack / 50;
                int reducePrice = fiftyBill * 50;
                moneyBack = moneyBack - reducePrice;
            }

            if (moneyBack >= 20)
            {
                twentyBill = moneyBack / 20;
                int reducePrice = twentyBill * 20;
                moneyBack = moneyBack - reducePrice;
            }

            if (moneyBack >= 10)
            {
                tenCoin = moneyBack / 10;
                int reducePrice = tenCoin * 10;
                moneyBack = moneyBack - reducePrice;
            }

            if (moneyBack >= 5)
            {
                fiveCoin = moneyBack / 5;
                int reducePrice = fiveCoin * 5;
                moneyBack = moneyBack - reducePrice;
            }

            if (moneyBack >= 1)
            {
                oneCoin = moneyBack / 1;
                int reducePrice = oneCoin * 1;
                moneyBack = moneyBack - reducePrice;
            }

            //values to put text depending on if its one bill/coin or more
            string fiveHundredText = fivehundredBill >= 2 ? "femhundralappar" : "femhundralapp";
            string twoHundredText = twohundredBill >= 2 ? "tvåhundralappar" : "tvåhundralapp";
            string oneHundredText = hundredBill >= 2 ? "hundralappar" : "hundralapp";
            string fiftyText = fiftyBill >= 2 ? "femtiolappar" : "femtiolapp";
            string twentyText = twentyBill >= 2 ? "tjugolappar" : "tjugolapp";
            string tenText = tenCoin >= 2 ? "tior" : "tia";
            string fiveText = fiveCoin >= 2 ? "femkronor" : "femkrona";
            string oneText = oneCoin >= 2 ? "enkronor" : "enkrona";

            //If-statements to show different text depending on what coins/bills the person should get back after they paid. 
            if (paidMoney == price)
            {
                listBox1.Items.Add($"Du har betalt med jämna pengar.");
            }

            if (paidMoney > price)
            {
                listBox1.Items.Add($"Växel tillbaka: ");
            }

            if (fivehundredBill > 0)
            {
                listBox1.Items.Add(fivehundredBill + " " + fiveHundredText);
            }

            if (twohundredBill > 0)
            {
                listBox1.Items.Add(twohundredBill + " " + twoHundredText);
            }

            if (hundredBill > 0)
            {
                listBox1.Items.Add(hundredBill + " " + oneHundredText);
            }

            if (fiftyBill > 0)
            {
                listBox1.Items.Add(fiftyBill + " " + fiftyText);
            }

            if (twentyBill > 0)
            {
                listBox1.Items.Add(twentyBill + " " + twentyText);
            }

            if (tenCoin > 0)
            {
                listBox1.Items.Add(tenCoin + " " + tenText);
            }

            if (fiveCoin > 0)
            {
                listBox1.Items.Add(fiveCoin + " " + fiveText);
            }

            if (oneCoin > 0)
            {
                listBox1.Items.Add(oneCoin + " " + oneText);
            }

        }
        //button to shut down the form. 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
