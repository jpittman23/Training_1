using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        // STATES:

        //fields:
        private readonly string _imageUrl = "";
        private double Diameter = 0;
        public string Size {get;}
        private List<string> _toppings = new List<string>();
        public string Crust {get;}

        //properties - (prop)
        public string SizeP { get; }
        public List<string> Toppings
        {
            get
            {
                return _toppings;
            }
        }
        //BEHAVIORS:
        //methods
        void AddToppings(string topping)
        {
            Toppings.Add(topping);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach(var t in Toppings)
            {
                sb.Append(t);
            }

            return $"{Size} {Crust} {sb}";
        }
        //constructors
        public Pizza(string size, string crust, List<string> toppings)
        {
            Size = size;
            Crust = crust;
            Toppings.AddRange(toppings);
        }
        public Pizza()
        {
            Size = "Large";
            Crust = "Stuffed Crust";
            //may be empty to write
        }
        //finalizers or destructors
    }
}