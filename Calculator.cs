using System;

namespace Final_Project
{
    public class Calculator
    {
     public double totalUserQuantityOfVitaminsA { get; set; }
     public double totalUserQuantityOfVitaminsB1 { get; set; }
     public double totalUserQuantityOfVitaminsB2 { get; set; }
     public double totalUserQuantityOfVitaminsB3 { get; set; }
     public double totalUserQuantityOfVitaminsB5 { get; set; }
     public double totalUserQuantityOfVitaminsB6 { get; set; }
     public double totalUserQuantityOfVitaminsB7 { get; set; }
     public double totalUserQuantityOfVitaminsB12 { get; set; }
     public double totalUserQuantityOfVitaminsC { get; set; }
     public double totalUserQuantityOfVitaminsD { get; set; }
     public double totalUserQuantityOfVitaminsE { get; set; }

     public double optimalNutritionPerDayVitaminA { get; set; }
     public double optimalNutritionPerDayVitaminB1 { get; set; }
     public double optimalNutritionPerDayVitaminB2 { get; set; }
     public double optimalNutritionPerDayVitaminB3 { get; set; }
     public double optimalNutritionPerDayVitaminB5 { get; set; }
     public double optimalNutritionPerDayVitaminB6 { get; set; }
     public double optimalNutritionPerDayVitaminB7 { get; set; }
     public double optimalNutritionPerDayVitaminB12 { get; set; }
     public double optimalNutritionPerDayVitaminC { get; set; }
     public double optimalNutritionPerDayVitaminD { get; set; }
     public double optimalNutritionPerDayVitaminE { get; set; }

     public String messageToUser = "";

    public void compareOptimalConsumedVitamins()
           {
          calculateTotalUserQuantityOfVitamins();

          if (optimalNutritionPerDayVitaminA < totalUserQuantityOfVitaminsA)
              messageToUser = "Take 10 mg of vitamin A";
          else if (optimalNutritionPerDayVitaminA == totalUserQuantityOfVitaminsA)
              messageToUser = "No need to take vitamin A";

          if (optimalNutritionPerDayVitaminB1 < totalUserQuantityOfVitaminsB1)
              messageToUser = "Take 10 mg of vitamin B1";
          else if (optimalNutritionPerDayVitaminB1 == totalUserQuantityOfVitaminsB1)
              messageToUser = "No need to take vitamin B1";

          if (optimalNutritionPerDayVitaminB2 < totalUserQuantityOfVitaminsB2)
              messageToUser = "Take 10 mg of vitamin B2";
          else if (optimalNutritionPerDayVitaminB2 == totalUserQuantityOfVitaminsB2)
              messageToUser = "No need to take vitamin B2";

          if (optimalNutritionPerDayVitaminB3 < totalUserQuantityOfVitaminsB3)
              messageToUser = "Take 10 mg of vitamin B3";
          else if (optimalNutritionPerDayVitaminB3 == totalUserQuantityOfVitaminsB3)
              messageToUser = "No need to take vitamin B3";

          if (optimalNutritionPerDayVitaminB5 < totalUserQuantityOfVitaminsB5)
              messageToUser = "Take 10 mg of vitamin B5";
          else if (optimalNutritionPerDayVitaminB5 == totalUserQuantityOfVitaminsB5)
              messageToUser = "No need to take vitamin B5";

           if (optimalNutritionPerDayVitaminB6 < totalUserQuantityOfVitaminsB6)
              messageToUser = "Take 10 mg of vitamin B6";
           else if (optimalNutritionPerDayVitaminB6 == totalUserQuantityOfVitaminsB6)
              messageToUser = "No need to take vitamin B6";

           if (optimalNutritionPerDayVitaminB7 < totalUserQuantityOfVitaminsB7)
              messageToUser = "Take 10 mg of vitamin B7";
           else if (optimalNutritionPerDayVitaminB7 == totalUserQuantityOfVitaminsB7)
              messageToUser = "No need to take vitamin B7";

           if (optimalNutritionPerDayVitaminB12 < totalUserQuantityOfVitaminsB12)
              messageToUser = "Take 10 mg of vitamin 12";
           else if (optimalNutritionPerDayVitaminB12 == totalUserQuantityOfVitaminsB12)
              messageToUser = "No need to take vitamin B12";

           if (optimalNutritionPerDayVitaminC < totalUserQuantityOfVitaminsC)
              messageToUser = "Take 10 mg of vitamin C";
           else if (optimalNutritionPerDayVitaminC == totalUserQuantityOfVitaminsC)
              messageToUser = "No need to take vitamin C";

           if (optimalNutritionPerDayVitaminD < totalUserQuantityOfVitaminsD)
              messageToUser = "Take 10 mg of vitamin D";
           else if (optimalNutritionPerDayVitaminD == totalUserQuantityOfVitaminsD)
              messageToUser = "No need to take vitamin D";

           if (optimalNutritionPerDayVitaminE < totalUserQuantityOfVitaminsE)
              messageToUser = "Take 10 mg of vitamin E";
           else if (optimalNutritionPerDayVitaminE == totalUserQuantityOfVitaminsE)
              messageToUser = "No need to take vitamin E";
            }

            public void calculateTotalUserQuantityOfVitamins()
            {
                var userProducts = new List<Product>();

                foreach (var userProduct in userProducts)
                {
                    totalUserQuantityOfVitaminsA += userProduct.VitaminAQuantity;
                    totalUserQuantityOfVitaminsB1 += userProduct.VitaminB1Quantity;
                    totalUserQuantityOfVitaminsB2 += userProduct.VitaminB2Quantity;
                    totalUserQuantityOfVitaminsB3 += userProduct.VitaminB3Quantity;
                    totalUserQuantityOfVitaminsB5 += userProduct.VitaminB5Quantity;
                    totalUserQuantityOfVitaminsB6 += userProduct.VitaminB6Quantity;
                    totalUserQuantityOfVitaminsB7 += userProduct.VitaminB7Quantity;
                    totalUserQuantityOfVitaminsB12 += userProduct.VitaminB12Quantity;
                    totalUserQuantityOfVitaminsC += userProduct.VitaminCQuantity;
                    totalUserQuantityOfVitaminsD += userProduct.VitaminDQuantity;
                    totalUserQuantityOfVitaminsE += userProduct.VitaminEQuantity;
                }
            }


    }
}
