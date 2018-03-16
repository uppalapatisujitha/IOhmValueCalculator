using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OhmValueCalculator.Interfaces;

namespace OhmValueCalculator.Classes
{
    public class OhmValueCalculator : IOhmValueCalculator
    {

        public Dictionary<string, int> bandA = new Dictionary<string, int>
            {   
                { "Black", 0 },
                { "Brown", 1 },
                { "Red", 2 },
                { "Orange", 3 },
                { "Yellow", 4 },
                { "Green", 5 },
                { "Blue", 6 },
                { "Violet", 7 },
                { "Gray", 8 },
                { "White", 9 }
            };

        public Dictionary<string, int> bandB = new Dictionary<string, int>
            {
                { "Black", 0 },
                { "Brown", 1 },
                { "Red", 2 },
                { "Orange", 3 },
                { "Yellow", 4 },
                { "Green", 5 },
                { "Blue", 6 },
                { "Violet", 7 },
                { "Gray", 8 },
                { "White", 9 }
            };

        public Dictionary<string, int> bandMultiplier = new Dictionary<string, int>
            {
                {"Pink", -3},
                { "Silver", -2},
                { "Gold", -1 },              
                { "Black", 0 },
                { "Brown", 1 },
                { "Red", 2 },
                { "Orange", 3 },
                { "Yellow", 4 },
                { "Green", 5 },
                { "Blue", 6},
                { "Violet", 7 },
                { "Gray", 8 },
                { "White", 9 },
                
            };


        public Dictionary<string, float> bandTolerance = new Dictionary<string, float>
            {
                { "None", 0f },
                { "Silver", 0.1f },
                { "Gold", 0.05f },
                { "Brown", 0.01f },
                { "Red", 0.02f },
                { "Yellow", 0.04f },
                { "Green", 0.005f },
                { "Blue", 0.0025f },
                { "Violet", 0.0010f },
                { "Gray", 0.0005f }     
                
            };




        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
           
            var calculatedOHM = (bandA[bandAColor] * 10 + bandB[bandBColor]) * Math.Pow(10, bandMultiplier[bandCColor]) * (1 + bandTolerance[bandDColor]);
            return Convert.ToInt32(calculatedOHM);

             
        }
    }
}