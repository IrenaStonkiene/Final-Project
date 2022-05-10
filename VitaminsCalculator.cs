using System;

namespace Final_Project
{
    public class VitaminsCalculator : ProductContent
    {
        public void Add(Product product, double quantity)
        {
            VitaminAQuantity += product.VitaminAQuantity * quantity / 100;
            VitaminB1Quantity += product.VitaminB1Quantity * quantity / 100;
            VitaminB2Quantity += product.VitaminB2Quantity * quantity / 100;
            VitaminB3Quantity += product.VitaminB3Quantity * quantity / 100;
            VitaminB5Quantity += product.VitaminB5Quantity * quantity / 100;
            VitaminB6Quantity += product.VitaminB6Quantity * quantity / 100;
            VitaminB7Quantity += product.VitaminB7Quantity * quantity / 100;
            VitaminB12Quantity += product.VitaminB12Quantity * quantity / 100;
            VitaminCQuantity += product.VitaminCQuantity * quantity / 100;
            VitaminDQuantity += product.VitaminDQuantity * quantity / 100;
            VitaminEQuantity += product.VitaminEQuantity * quantity / 100;
        }

        public void Deficite(DailyRecommendation recommendation)
        {
            Notify(VitaminAQuantity, recommendation.VitaminAQuantity, "Vitamin A");
            Notify(VitaminB1Quantity, recommendation.VitaminB1Quantity, "Vitamin B1");
            Notify(VitaminB2Quantity, recommendation.VitaminB2Quantity, "Vitamin B2");
            Notify(VitaminB3Quantity, recommendation.VitaminB3Quantity, "Vitamin B3");
            Notify(VitaminB5Quantity, recommendation.VitaminB5Quantity, "Vitamin B5");
            Notify(VitaminB6Quantity, recommendation.VitaminB6Quantity, "Vitamin B6");
            Notify(VitaminB7Quantity, recommendation.VitaminB7Quantity, "Vitamin B7");
            Notify(VitaminB12Quantity, recommendation.VitaminB12Quantity, "Vitamin B12");
            Notify(VitaminCQuantity, recommendation.VitaminCQuantity, "Vitamin C");
            Notify(VitaminDQuantity, recommendation.VitaminDQuantity, "Vitamin D");
            Notify(VitaminEQuantity, recommendation.VitaminEQuantity, "Vitamin E");
        }
        
        private void Notify(double vitaminQuantity, double recommendedQuantity, string vitaminName)
        {
            if (vitaminQuantity < recommendedQuantity)
            {
                Console.WriteLine($"You need to consume {recommendedQuantity - vitaminQuantity} mcg of {vitaminName}");
            }
        }
    }
}
