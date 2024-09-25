// See https://aka.ms/new-console-template for more information


int[] accounts = { 903, 716, 67 };
int GetAccountNumber(){
Console.WriteLine("Enter an account number: ");

return Convert.ToInt32(Console.ReadLine());

}
void PrintAccountState(int accountId){
Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true)
{
	int accountId = GetAccountNumber();
	
	try{
		PrintAccountState(accountId);
	} catch (IndexOutOfRangeException e) {
		Console.WriteLine("That shit you typed was whack AF");
		break;
	}


}