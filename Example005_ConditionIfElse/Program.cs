Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
    Console.WriteLine("Это же Настя");
}
else
{
   Console.Write("Привет "); 
   Console.Write(username); 
}
