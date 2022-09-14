using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class ClassCalculator
    {
        public double portion;
        public double ingredients;
        public decimal cost_Of_Portion;
        public decimal cost_Of_Ingredients;
        public double IngridientsOfStock;
        public double RemainsOfIngr;

        public static double? Remains(double ingredients, double IngridientsOfStock)
        {
            if (ingredients > IngridientsOfStock)
            {
                MessageBox.Show("Вы не можете использовать столько ингридиентов");
            }
            else
            {
                double RemainsOfIngr = IngridientsOfStock - ingredients;
                return RemainsOfIngr;
            }

            return null;
            
        }



    }

}


