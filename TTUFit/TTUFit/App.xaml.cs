using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTUFit
{
    public partial class App : Application
    {
        public static Boolean debug = true;
        public static Boolean IsUserLoggedIn = false;
        public static User user = new User();
        public static DBHandle.Set_Up SE = new DBHandle.Set_Up();
        public static Nutrition nutri = new Nutrition(20, 220, 200, 70, 1.5, Goal.Activity.ModerateleyActive, Goal.Gender.Male); //test data

        public App()
        {
            InitializeComponent();
            SE.ReadTxtFile();

            //--Test Meal Plan stuff --> For Jalen to use as an example
            DBHandle.Generate_Meal_Plan GMP = new DBHandle.Generate_Meal_Plan(SE.get_TTU_Meal_Data());
            int TCal = 3000;
            int TPro = 180;
            int TCar = 400;
            int TFat = 80;
            int totalMeals = 4;
            Console.WriteLine("---------------Testing Meal Plan-----------------");
            DBHandle.Food[] MealPlan = GMP.Request_Meal_Plan(TCal, TPro, TCar, TFat, totalMeals);
            for (int a = 0; a < MealPlan.Length; a++)
            {
                DBHandle.Food Item = MealPlan[a];
                Item.Print_All();
            }
            //---------------------------------------------------------------

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
