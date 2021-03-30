using System;

public class goal
{
	public enum Gender // this can come fom acount creation/information and can not be modifued
    {
		Female;
		Male;
    };
	public enum Activity // Activity level as determined by user based on the following calories
	{
		Seditary; // Little to no exersize
		LightlyActive; // Light exersize/ or sports 1-3 days a week
		ModerateleyActive; // Moderate exersize/ or sports 3-5 days a week
		VeryActive; // Hard exersize/ or sports 6-7 days a week
		ExtremleyActive; // Very hard exersize/ or sports & physical job. (i.e 2x training)
	};
	public int age { get; set; }
	public int currentWeight { get; set; } //In lbs
	public int goalWeight { get; set; } //In lbs
	public int height { get; set; } // given in inches
	public dailyCals { get; set; }
	public Activity activity; // This is how often someone works out/is acitve per week
	public readonly Gender gender;
	// A way we can implement saving is to use the email as a key to upload/download to database

	public goal(int a, int cw, int gw, int h, int dcal, Activity act, Gender gn) // Constucts goal
	{
		this.age = a;
		this.currentWeight = cw;
		this.goalWeight = gw;
		this.height = h;
		this.dailyCals = dcal;
		this.activity = act;
		this.gender = gn;
	}

	public class nutrition
    {
		public int fatGoal { get; set; }
		public int carbGoal { get; set; }
		public int proGoal { get; set; }
		public int currentCals { get; set; }
		public int currentFat { get; set; }
		public int currentCarb { get; set; }
		public int currentPro { get; set; }
		
		// This class will house methods that will work with meal data updates and will display progress bars, charts, and graphs as well

	}

	// some of the funtions could possibly be combined/optimized later on 
	
	public double calculateBMR() // This calculates the Basal Metobolic Rate ,or resting calorise burned per day
		{
			int BMR;

			if (goal.gender == Gender.Male) // Adult Male (unsure if syntax is correct) 
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

	public double calculateMaintenenceCal(double bmr) // This calcualtes how many calories the user burns per day (unsure if syntax is correct as well) 
		{
			enum caseSwitch = activity;
			double = mainCal;
			double BMR = bmr;
			switch (caseSwitch)
			{
				case Activity.Seditary:
					mainCal = BMR * 1.2;
					break;
				case Activity.LightlyActive:
					mainCal = BMR* 1.375;
					break;
				case Activity.ModerateleyActive:
					mainCal = BMR* 1.55;
					break;
				case Activity.VeryActive:
					mainCal = BMR* 1.725;
					break;
				case Activity.ExtremleyActive:
					mainCal = BMR* 1.9;
					break;
			}
			return mainCal;
		}

	public void calculateDialyCals() //This calulates the daily calories the user needs per day based on their goals; updates dailyCals
    {
	double calDailyCals;
	// 3500 cal in a lb of fat, thus -3500 cals a week = lose 1 pound a week. -7000 per week is 2 lbs and so on
	// Come up with question of how many pounds a week do you want to lose, and take that number and multiply times 3500 and subtract it by maintence calories * 7 (for the week)
	// then divie the value by 7 to find daily calories
	dailyCals = calDailyCals;
	return;
    }
}
