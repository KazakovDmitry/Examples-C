// Задача с собакой и друзьями
int count = 0;
int distance = 10000;
int firstFriendsSpeed = 1;
int secondFriendsSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendsSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendsSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendsSpeed + secondFriendsSpeed) * time;
    count++;
}
Console.WriteLine("Собака пробежит " + count + " раз");