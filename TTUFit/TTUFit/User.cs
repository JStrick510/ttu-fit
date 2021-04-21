using System;
using System.Collections.Generic;
using System.Text;

namespace TTUFit
{
    class User
    {
        public String Username { get; set; }

        public String Password { get; set; }

        public int age { get; set; }

        public double goalWeight { get; set; }

        public double currentWeight { get; set; }

        public double heightInches { get; set; }

        public int dailyCals { get; set; }

        public enum Gender { Female, Male }
        public Gender gender { get; set; }

        public enum Activity {  Seditary, LightlyActive, ModeratelyActive, VeryActive, ExtermelyActive }
        public Activity activity { get; set; }

        public double weightChangeWeek { get; set; }

        public double fatPercentage { get; set; }

        public double carbPercentage { get; set; }

        public double proteinPercentage { get; set; }
    }
}
