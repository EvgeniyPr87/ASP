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
          result = Math.Pow(number, degree);
        }
        void Reset()
        {
            result = 0;
            number = 0;
            degree = 0;
        }
    }
}
