// Insert Program Here
using template_csharp_class_of_your_choice;

Console.WriteLine("Please enter the name of the car.");
string name = Console.ReadLine();
Console.WriteLine("Please enter year of the car.");
int year = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter the how many miles until the next maintenance of the car.");
int maintDue = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter the services that are needed.");
string serviceNeeds = Console.ReadLine();
Console.WriteLine("Please enter the number of miles on the car.");
int miles = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter the number of day Next Maintenance.");
int maintDate = Int32.Parse(Console.ReadLine());

CarService car_Service = new CarService(name, year, maintDue, serviceNeeds, miles, maintDate);

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("1. Drive \n2. Fix \n3. new day \n4. Display details \n0. Quit");
    int input;
    try
    {
        input = Int32.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        input = -1;
    }


    switch (input)
    {
        case -1:
            Console.Clear();
            Console.WriteLine("Please type a numeric value.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            break;
        case 0:
            isRunning = false;
            break;
        case 1:
            car_Service.Drive();
            Console.Clear();
            Console.WriteLine(car_Service.MaintDue + " Miles to next maintenance \nThe miles on the car are now " + car_Service.Miles);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            break;
        case 2:
            car_Service.Fix();
            Console.Clear();
            Console.WriteLine(car_Service.ServiceNeeds + "\nPress enter to contiue.");
            Console.ReadLine();
            break;
        case 3:
            car_Service.tick();
            Console.Clear();
            Console.WriteLine(car_Service.MaintDue + " Miles and " + car_Service.MaintDate +" days to next maintenance");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Name: " + car_Service.Name + "\nYear: " + car_Service.Year + "\nMiles until the next maintenance of the car:" + car_Service.MaintDue);
            Console.WriteLine("Maintenance needed: " + car_Service.ServiceNeeds + "\nMiles on the car: " + car_Service.Miles + "\nDays until next maintenance: " + car_Service.MaintDate);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            break;
    }
}
