// See https://aka.ms/new-console-template for more information

long secondsSinceNewyear1970 = 1726659242;
long secondsToYearFrom1970 = secondsSinceNewyear1970/31556926;
long secondsInADay = 86400;
/*
 LEAP YEAR 2024
long January = 31;
long February = 60;
long March = 91;
long April = 121;
long May = 152;
long June = 182;
long July = 213;
long August = 244;
long September = 274;
*/

long August = 244;

long currentDaysInSeconds = 267 * secondsInADay;


long currentDays = currentDaysInSeconds / secondsInADay;

long secondsSinceNewyear = 267 * secondsInADay;
long secondsToMonth = secondsSinceNewyear/86400;
//long secondsInYear = 31556926;

//long secondsSinceNewYearInDays = secondsSinceNewyear / secondsInADay;
long secondsSinceNewYearInDays = secondsSinceNewyear / secondsInADay;

long month;
long currentDayInMonth = secondsSinceNewYearInDays - month;

if (secondsSinceNewYearInDays > 240 && secondsSinceNewYearInDays < 269) {
	month = August;
	Console.WriteLine("The current month is September " + secondsSinceNewYearInDays);
	Console.WriteLine("The current amount of days: " + month);
	
} 	else if (secondsSinceNewYearInDays > 0 && secondsSinceNewYearInDays < 30) {
	Console.WriteLine("The current month is January");
} 	else if (secondsSinceNewYearInDays == 354) {
		Console.WriteLine("Merry Christmas!");
	}
		

// 26. sep 
// Find en måde at vise måneder på. Gerne i et interval. Hvis current day er mellem disse måneders værdi, print hvilken måned det er + dagen 
// Print dagen: for at finde den specifikke dag, skal currentDaysInSeconds bruges med modulus-operator og resten skal så printes i dage



Console.WriteLine("Amount of years since New Year 1970: " + secondsToYearFrom1970);

Console.WriteLine("Current days in 2024: "+currentDays);

Console.WriteLine("Days since new year 2024: "+secondsSinceNewYearInDays);


