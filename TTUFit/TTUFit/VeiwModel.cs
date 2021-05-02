using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TTUFit
{
    class VeiwModel
    {
        public ObservableCollection<MealLog> MealLog { get; set; }

        public ViewModel()
        {
            this.MealLog = new ObservableCollection<MealLog>();
            GenerateOrders();
        }

        // Create Random values for testing
        private void GenerateOrders()
        {
            MealLog.Add(new MealLog("Canadian Bacon Pizza", 540, 36, 53, 22, 0.2));
            MealLog.Add(new MealLog("Chicken Pesto Pizza", 802, 46, 54, 46, 0.2));
            MealLog.Add(new MealLog("Margarita Pizza", 743, 33, 55, 46, 0.2));
            MealLog.Add(new MealLog("Pepperoni Pizza", 582, 29, 53, 30, 0.2));
            MealLog.Add(new MealLog("Buffalo Chicken", 540, 36, 53, 22, 0.2));
        }
    }
}
