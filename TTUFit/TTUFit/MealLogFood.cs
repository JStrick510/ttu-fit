using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TTUFit
{
    public class MealLogFood : INotifyPropertyChanged
    {
        private string foodName;
        private int cals;
        private int fat;
        private int carb;
        private int pro;
        private double servingSize;

        public string FoodName
        {
            get { return foodName; }
            set
            {
                this.foodName = value;
                RaisePropertyChanged("FoodName");
            }
        }
        public int Cals
        {
            get { return cals; }
            set
            {
                this.cals = value;
                RaisePropertyChanged("Cals");
            }
        }

        public int Fat
        {
            get { return fat; }
            set
            {
                this.fat = value;
                RaisePropertyChanged("Fat");
            }
        }

        public int Carb
        {
            get { return carb; }
            set
            {
                this.carb = value;
                RaisePropertyChanged("Carb");
            }
        }

        public int Pro
        {
            get { return pro; }
            set
            {
                this.pro = value;
                RaisePropertyChanged("Pro");
            }
        }

        public double ServingSize
        {
            get { return servingSize; }
            set
            {
                this.servingSize = value;
                RaisePropertyChanged("ServingSize");
            }
        }


        public MealLogFood(string name, int cals, int fat, int carb, int pro, double serving)
        {
            this.FoodName = name;
            this.Cals = cals;
            this.Fat = fat;
            this.Carb = carb;
            this.Pro = pro;
            this.ServingSize = serving;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
