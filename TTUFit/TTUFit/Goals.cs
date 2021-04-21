using System;

namespace TTUFit
{
	public class Goal
	{
		public enum Gender // this can come fom acount creation/information and can not be modifued
		{
			Female,// = 0
			Male // = 1
		}
		public enum Activity // Activity level as determined by user based on the following calories
		{
			Sedentary = 1, // Little to no exersize
			LightlyActive = 2, // Light exersize/ or sports 1-3 days a week
			ModerateleyActive = 3, // Moderate exersize/ or sports 3-5 days a week
			VeryActive = 4, // Hard exersize/ or sports 6-7 days a week
			ExtremleyActive = 5 // Very hard exersize/ or sports & physical job. (i.e 2x training)
		}
		public int age { get; set; }
		public int currentWeight { get; set; } //In lbs
		public int goalWeight { get; set; } //In lbs
		public int height { get; set; } // given in inches
		public int dailyCals { get; set; }
		public Activity activity; // This is how often someone works out/is acitve per week
		public Gender gender;
		// A way we can implement saving is to use the email as a key to upload/download to database

		public Goal(int age, int currentweight, int goalweight, int height, int dailycal, Activity act, Gender gender) // Constucts goal
		{
			this.age = age;
			this.currentWeight = currentweight;
			this.goalWeight = goalweight;
			this.height = height;
			this.dailyCals = dailycal;
			this.activity = act;
			this.gender = gender;
		}

		//public Goal()
		//{
		//}

		public class Nutrition
		{
			public int FatGoal { get; set; }
			public int CarbGoal { get; set; }
			public int ProGoal { get; set; }
			public int CurrentCals { get; set; }
			public int CurrentFat { get; set; }
			public int CurrentCarb { get; set; }
			public int CurrentPro { get; set; }

			// This class will house methods that will work with meal data updates and will display progress bars, charts, and graphs as well

		}

		public double CalculateBMR() // This calculates the Basal Metobolic Rate ,or resting calorise burned per day
		{
			double BMR;

			if (this.gender == Gender.Male) // Adult Male (unsure if syntax is correct) 
			{
				BMR = 66 + (6.3 * currentWeight) + (12.9 * height) - (6.8 * age);
				return BMR;
			}
			else // Adult Female
			{
				BMR = 655 + (4.3 * currentWeight) + (4.7 * height) - (4.7 * age);
				return BMR;
			}
		}

		public double CalculateMaintenenceCal(double bmr) // This calcualtes how many calories the user burns per day (unsure if syntax is correct as well) 
		{
			int caseSwitch = (int)this.activity;
			double BMR = bmr;
			double mainCal = 0;
			switch (caseSwitch)
			{
				case 1: // Seditary
					mainCal = BMR * 1.2;
					break;
				case 2: // LightlyActive
					mainCal = BMR * 1.375;
					break;
				case 3: // ModerateleyActive:
					mainCal = BMR * 1.55;
					break;
				case 4: // VeryActive:
					mainCal = BMR * 1.725;
					break;
				case 5: // ExtremleyActive:
					mainCal = BMR * 1.9;
					break;
			}
			return mainCal;
		}

		public void CalculateDialyCals(double mainCal, float perweekLbs) //This calulates the daily calories the user needs per day based on their goals; updates dailyCals
		{
			double calDailyCals = 0;
			double mc = mainCal; // The user's maintenance calories
			float perWeekLbs = perweekLbs; // This will  be the users specfic goal on how many pounds a week they want to lose/Gain

			// 3500 cal in a lb of fat, thus -3500 cals a week = lose 1 pound a week. -7000 per week is 2 lbs and so on
			// Come up with question of how many pounds a week do you want to lose, and take that number and multiply times 3500 and subtract it by maintence calories * 7 (for the week)
			// then divie the value by 7 to find daily calories
			// We will assume weight gain is adding to the maintenance calories

			if (this.goalWeight < this.currentWeight) // User wants to lose weight
			{
				calDailyCals = mc * 7 - (perWeekLbs * 3500); // Weekly total Calories for weight loss
			}
			else if (this.goalWeight == this.currentWeight) // User wants to maintain Weight
			{
				calDailyCals = mc * 7;
			}
			else // User wants to Gain weight
			{
				calDailyCals = mc * 7 + (perWeekLbs * 3500); // Weekly total Calories for weight gain
			}
			this.dailyCals = (int)calDailyCals / 7;
			return;
		}
	}
}
