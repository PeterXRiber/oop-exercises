// See https://aka.ms/new-console-template for more information



int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};
// increment

for (int i = 0 ; i < iterationer ; i++)
{
	try{
		array[i]++;
	} catch (IndexOutOfRangeException e) {
		break;
	}
}

// print
for (int i = 0 ; i < array.Length ; i++)
{
Console.WriteLine(array[i]);
}



// 5. Er dette den korrekte løsning på problemet, og hvorfor?
// 