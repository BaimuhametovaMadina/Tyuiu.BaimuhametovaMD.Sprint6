﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaimuhametovaMD.Sprint6.Task0.V17.Lib
{
    public class DataService: ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            double y = Math.Pow(Math.E, x) / x;
            return Math.Round(y, 3);
        }
    }
}
