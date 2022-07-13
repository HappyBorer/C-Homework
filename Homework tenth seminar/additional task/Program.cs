/* 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка. 
 До каждого бара идти примерно 15-20 минут, каждый пьет пинту за 15 минут. У первого друга 
 лимит выпитого 1.1 литра, у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. 
 Необходимо выяснить, до скольки баров смогут дойти каждый из друзей(Пройденное расстояние (в барах)), 
 пока не упадет. И сколько всего времени будет потрачено на выпивку. */

using static System.Console;
Clear();

// Методы.


// Мой код.

int bars = 12;
int drinkingTime = 15;
double pintInGrams = 570;
double[] friendsDrinkLimit = { 1.1, 1.5, 2.2, 3.3 };
int friendException = 0;
double gulp = 0;
while (bars > 0 && friendException != friendsDrinkLimit.Length)
{
    gulp += pintInGrams;
    for (int i = friendException; i < friendsDrinkLimit.Length; i++)
    {
        if(gulp >= friendsDrinkLimit[i] * 1000)
        {
            Write($"Друг {i + 1} прошёл баров {(int)(gulp / pintInGrams)} ");
            WriteLine($"и потратил время на выпивку {(int)(gulp / (pintInGrams / drinkingTime))} минут");
            friendException++;
        }
    }
    bars--;
}

