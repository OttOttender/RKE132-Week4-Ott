
using System.Security.AccessControl;

Random rnd = new Random();

int myRandomNum; //v22rtuse deklareerimine
int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);//0 kuni 10ni
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"My random sum total: {randomSum}");