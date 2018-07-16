using System;
using Xunit;
using WindowsFormsApp1;

namespace Tests
{
    public class UdarnoscTests
    {

        CharpyCalc calc = new CharpyCalc();
        [Fact(DisplayName = "Liczeni udarności na podstawie excela")]
        public void LiczUdarnoscTestPozytywny()
        {
            Assert.Equal(166.666666666667f, calc.Licz_udarnosc(1f,2f,3f));

        }
        [Fact(DisplayName="Dzielenie przez 0")]
        public void LiczUdarnoscTestNegatywny()
        {
            Assert.Equal(0, calc.Licz_udarnosc(1,2,0));
        }
    }
}
