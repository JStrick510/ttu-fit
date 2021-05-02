using System;
using System.Collections.Generic;
using System.Text;

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

		public int Age { get; set; }
		public int CurrentWeight { get; set; } //In lbs
		public int GoalWeight { get; set; } //In lbs
		public int Height { get; set; } // given in inches
		public int DailyCals { get; set; }
		public Activity activity; // This is how often someone works out/is acitve per week
		public Gender gender;
		// A way we can implement saving is to use the email as a key to upload/download to database

		public Goal(int age, int currentweight, int goalweight, int height, int dailycal, Activity act, Gender gender) // Constucts goal
		{
			this.Age = age;
			this.CurrentWeight = currentweight;
			this.GoalWeight = goalweight;
			this.Height = height;
			this.DailyCals = dailycal;
			this.activity = act;
			this.gender = gender;
		}

		public Goal()
		{
		}

		public double CalculateBMR() // This calculates the Basal Metobolic Rate ,or resting calorise burned per day
		{
			double BMR;

			if (this.gender == Gender.Male)
			{
				BMR = 66 + (6.3 * CurrentWeight) + (12.9 * Height) - (6.8 * Age);
				return BMR;
			}
			else // Adult Female
			{
				BMR = 655 + (4.3 * CurrentWeight) + (4.7 * Height) - (4.7 * Age);
				return BMR;
			}
		}

		public double CalculateMaintenenceCal(double bmr) // This calcualtes how many calories the user burns per day Total daily Expenditure TDE
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

			if (this.GoalWeight < this.CurrentWeight) // User wants to lose weight
			{
				calDailyCals = mc * 7 - (perWeekLbs * 3500); // Weekly total Calories for weight loss
			}
			else if (this.GoalWeight == this.CurrentWeight) // User wants to maintain Weight
			{
				calDailyCals = mc * 7;
			}
			else // User wants to Gain weight
			{
				calDailyCals = mc * 7 + (perWeekLbs * 3500); // Weekly total Calories for weight gain
			}
			this.DailyCals = (int)calDailyCals / 7;
			return;
		}
	}
	public class Nutrition : Goal
	{
		public int FatGoalPercent { get; set; } // This value is a percentage of total calorie intake per day (goal)
		public int CarbGoalPercent { get; set; } // This value is a percentage of total calorie intake per day (goal)
		public int ProGoalPercent { get; set; } // This value is a percentage of total calorie intake per day (goal)
		public double CurrentCals { get; set; } // Current value of daily calorie intake
		public double CurrentFat { get; set; } // current fats total
		public double CurrentCarb { get; set; } // current carb total
		public double CurrentPro { get; set; } // current protien total

		// This class will house methods that will work with meal data updates and will display progress bars, charts, and graphs as well

		public Nutrition()
		{
			SetGoals(); // Automatically determine goals based on user information 

			// Starting value is 0 at the start of each day
			this.CurrentCals = 0;
			this.CurrentCarb = 0;
			this.CurrentFat = 0;
			this.CurrentPro = 0;
		}

		public void SetGoals() // Determine the goals of fat, carb, and proteins per day (Can be done after account creation)
		{
			// Info is from https://www.bodybuilding.com/fun/macronutrients_calculator.htm
			// Weight loss: 40/40/20 (carbohydrates/protein/fats)
			// Weight gain: 40 / 30 / 30
			// Weight maintenance: 40 / 30 / 30

			if (this.GoalWeight < this.CurrentWeight) // User wants to lose weight
			{
				this.CarbGoalPercent = 40;
				this.ProGoalPercent = 40;
				this.FatGoalPercent = 20;
			}
			else // User wants to Gain weight or maintain
			{
				this.CarbGoalPercent = 40;
				this.ProGoalPercent = 30;
				this.FatGoalPercent = 30;
			}
		}

		public void UpdateCurrentCals(double fats, double carbs, double protien) // update the current calories for the day for the food item being entered
		{
			// Protein: 4 calories
			// Carbs: 4 calories
			// Fats: 9 calories

			double fat = fats;
			double carb = carbs;
			double pro = protien;

			this.CurrentCals = fat * 9 + carb * 4 + pro * 4;
			UpdateCurrentMacros(fat, carb, pro); //update current macros as well
		}
		public void UpdateCurrentMacros(double fats, double carbs, double protien)
		{
			this.CurrentFat = fats;
			this.CurrentCarb = carbs;
			this.CurrentPro = protien;
		}
	}
}
