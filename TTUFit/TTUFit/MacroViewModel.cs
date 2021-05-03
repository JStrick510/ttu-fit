using System.Collections.Generic;

namespace TTUFit
{
    class MacroViewModel
    {
        public List<PieHandler> PieData { get; set; }

        public MacroViewModel()
        {
            PieData = new List<PieHandler>();

            //Use data from nutri located in App.xaml
            //Nutrition(20, 220, 200, 70, 1.5, Goal.Activity.ModerateleyActive, Goal.Gender.Male);

            PieData.Add(new PieHandler { GoalPercent = App.nutri.FatGoalPercent, MacroName = "Fats Goal" });
            PieData.Add(new PieHandler { GoalPercent = App.nutri.CarbGoalPercent, MacroName = "Carbs Goal" });
            PieData.Add(new PieHandler { GoalPercent = App.nutri.ProGoalPercent, MacroName = "Protien Goal" });
        }
    }
}