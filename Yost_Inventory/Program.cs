//Kathy Yost
//IT112
//Notes
//bEHAVIORS NOT IMPLEMENTED AND WHY: ANY partss of the assignment not completed?
namespace Yost_Inventory
{
    public partial class program
    {
        private static bool Exit = false;
        private static Shipper shipper = new Shipper();
        static void Main(string[] args)
        {
            while (!Exit)
            {
                Console.WriteLine(GetPrompt());
                string arg = Console.ReadLine();
                string output = "";
                switch (arg)
                {
                    case "1":
                        output = shipper.Add(new Bicycles());
                        break;
                    case "2":
                        output = shipper.Add(new Lawn_Mowers());
                        break;
                    case "3":
                        output = shipper.Add(new Baseball_Gloves());
                        break;
                    case "4":
                        output = shipper.Add(new Crackers());
                        break;
                    case "5":
                        output = shipper.ListShipmentItems();
                        break;
                    case "6":
                        output = shipper.ComputeShippingCharges();
                        break;
                    case "7":
                        Exit = true;
                        break;
                }

                if (!string.IsNullOrEmpty(output))
                {
                    Console.WriteLine(output);
                }
            }
        }

        private static string GetPrompt()
        {
            string prompt = @"
Choose from the following options:
1. Add a Bicycle to the shipment
2. Add a Lawn Mower to the Shipment
3. Add a Baseball Glove to the shipment
4. Add Crackers to the shipment
5. List Shipment Items
6. Compute Shipping Charges
7. Exit";
            return prompt;
        }




    }
}