// See https://aka.ms/new-console-template for more information

long secondsSinceNewyear1970 = 1726659242;
long secondsToYearFrom1970 = secondsSinceNewyear1970/31556926;
long secondsInADay = 86400;
/*
long January = 30;
long February = 60;
long March = 90;
long April = 120;
long May = 150;
long June = 180;
long July = 210;
long August = 240;
long September = 270;
*/

long currentDaysInSeconds = 266 * secondsInADay;


long currentDays = currentDaysInSeconds / secondsInADay;

long secondsSinceNewyear = 23033366;

//long secondsSinceNewYearInDays = secondsSinceNewyear / secondsInADay;
long secondsSinceNewYearInDays = 354;
if (secondsSinceNewYearInDays > 240 && secondsSinceNewYearInDays < 269) {
	Console.WriteLine("The current month is September");
} 	else if (secondsSinceNewYearInDays > 0 && secondsSinceNewYearInDays < 30) {
	Console.WriteLine("The current month is January");
} 	else if (secondsSinceNewYearInDays == 354) {
		Console.WriteLine("Merry Christmas!");
	}
		

// 26. sep 
// Find en måde at vise måneder på. Gerne i et interval. Hvis current day er mellem disse måneders værdi, print hvilken måned det er + dagen 




Console.WriteLine("Amount of years since New Year 1970: " + secondsToYearFrom1970);

Console.WriteLine("Current days in 2024: "+currentDays);

Console.WriteLine("Days since new year 2024: "+secondsSinceNewYearInDays);



