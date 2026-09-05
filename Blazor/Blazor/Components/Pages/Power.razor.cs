using System;
namespace Blazor.Components.Pages
{
    public partial class Power
    {
        double number = 0;
        double degree = 0;
        double result;
        void CalculatePower()
        {
            if (number == 0 && degree == 0) { result = 1; }
            else
            { result = Math.Pow(number, degree); }
        }
        void Reset()
        {
            result = 1;
            number = 0;
            degree = 0;
        }
    }
}
