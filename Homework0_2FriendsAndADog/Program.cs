// See https://aka.ms/new-console-template for more information
int count = 0;
double distance = new Random().Next(1000,10000);
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;


Console.WriteLine("initial distance is " + distance);
while(distance > 10)
{

    if (friend == 1)
        {
            time = distance/(firstFriendSpeed+dogSpeed);
            friend = 2;
        }
        else
        {
            time = distance/(dogSpeed+secondFriendSpeed);
            friend = 1;
        }
    distance = distance - (firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}
Console.WriteLine("dog will run " + count  + "times");