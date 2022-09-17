string[] array1 = new string [4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string [4] {"1234", "1567", "-2", "computer science"};
string[] array3 = new string [4] {"Russia", "Denmark", "Kazan", "Sibir"};

int random = new Random().Next(2 ,4);
int rendomFile = (random);
if (rendomFile < 3)
{
    System.Console.Write(array1[random]);
    System.Console.Write(", ");
    System.Console.Write(array2[random]);
    System.Console.Write(", ");
}
else
{
    System.Console.Write(array1[random]);
    System.Console.Write(", ");
    System.Console.Write(array2[random]);
    System.Console.Write(", ");
    System.Console.Write(array3[random]);    
}
int random1 = new Random().Next(5);
int random2 = new Random().Next(5);
int random3 = new Random().Next(5);
