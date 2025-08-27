// Practice 5


/*Sum of Odd digits*/

int sum = 0;
int i = 1;

while (i <= 10)
{
    if (i % 2 != 0)
    { 
      sum += i;
    i++;
    }
   
}
Console.Write(sum);