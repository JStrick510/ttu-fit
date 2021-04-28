namespace TTUFit
{
    public partial class Goal
	{
        public enum Activity // Activity level as determined by user based on the following calories
		{
			Sedentary = 1, // Little to no exersize
            LightlyActive = 2, // Light exersize/ or sports 1-3 days a week
			ModerateleyActive = 3, // Moderate exersize/ or sports 3-5 days a week
			VeryActive = 4, // Hard exersize/ or sports 6-7 days a week
			ExtremleyActive = 5 // Very hard exersize/ or sports & physical job. (i.e 2x training)
		}
	}
}
