using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TTUFit
{
    class ViewModel
    {
        public ObservableCollection<MealLogFood> MealLogFood { get; set; }

        public ViewModel()
        {
            this.MealLogFood = new ObservableCollection<MealLogFood>();
            GenerateOrders();
        }

        // Create Random values for testing
        private void GenerateOrders()
        {
            MealLogFood.Add(new MealLogFood("Canadian Bacon Pizza", 540, 36, 53, 22, 0.2));
            MealLogFood.Add(new MealLogFood("Chicken Pesto Pizza", 802, 46, 54, 46, 0.2));
            MealLogFood.Add(new MealLogFood("Margarita Pizza", 743, 33, 55, 46, 0.2));
            MealLogFood.Add(new MealLogFood("Pepperoni Pizza", 582, 29, 53, 30, 0.2));
            MealLogFood.Add(new MealLogFood("Buffalo Chicken", 540, 36, 53, 22, 0.2));
        }
    }
}
