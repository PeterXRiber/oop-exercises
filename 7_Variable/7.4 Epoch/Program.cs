// See https://aka.ms/new-console-template for more information

long secondsSinceNewyear1970 = 1726659242;
long secondsToYearConverterFrom1970 = secondsSinceNewyear1970/31556926;
long secondsToDay = 86400;

long currentDaysInSeconds = 264 * secondsToDay;

long currentDaysInSecondsToDays = currentDaysInSeconds / secondsToDay;



Console.WriteLine(secondsToYearConverterFrom1970);

Console.WriteLine("Current days in 2024: "+currentDaysInSecondsToDays);


