using System;
namespace Blazor.Components.Pages
{
    public partial class Power
    {
        double number = 1;
        double degree = 1;
        double result;
        void CalculatePower()
        {
          result = Math.Pow(number, degree);
        }
    }
}
