// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

long secSinceNewyear = 21816000;
long secSinceNewyearInDays = secSinceNewyear / 86400;
double priceInDK = 599.95;

double priceDiscounted = 599.95 * 0.70;
// 334 = days until 1. of december
if (secSinceNewyearInDays < 334) {
	Console.WriteLine("Womp womp no discount yet. The price is still: " + priceInDK);
} else if (secSinceNewyearInDays > 334) {
	Console.WriteLine("The product is discounted with 30%. The current price is now: " + (priceDiscounted));
}

Console.WriteLine(secSinceNewyearInDays);
Console.WriteLine(priceDiscounted);