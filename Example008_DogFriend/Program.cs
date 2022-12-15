Console.Write("Введите расстояние в метрах ");
double Dist = double.Parse(Console.ReadLine());

Console.Write("Введите скорость собаки м/с ");
double DogSpeed = double.Parse(Console.ReadLine());

Console.Write("Введите скорость Первого друга м/с ");
double Friend1Speed = double.Parse(Console.ReadLine());

Console.Write("Введите скорость Вторгого друга м/с ");
double Friend2Speed = double.Parse(Console.ReadLine());

double Time = 0;
int RunFriend = 1, count = 0;

while(Dist > 10)
{
    if(RunFriend == 1)
    {
        RunFriend = 2;
        Time = Dist / (DogSpeed + Friend1Speed);            
    }
    else
    {
        RunFriend = 1;
        Time = Dist / (DogSpeed + Friend2Speed);
    }
    
    Dist = Dist - ((Friend1Speed + Friend2Speed) * Time);
    count++;
}
Console.Write("Собака успеет пробежать ");
Console.Write(count);
Console.Write(" раз");