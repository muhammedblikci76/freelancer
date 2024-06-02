// See https://aka.ms/new-console-template for more information
using freelancer.Entities;
using freelancer.Sevices;

Console.WriteLine("Hello, World!");

// customer(ıd,createdOn,FirstName,LastName,PhoneNumber)
// customer(ıd,createdOn,FirstName,LastName,PhoneNumber)
// customer(ıd,createdOn,FirstName,LastName,PhoneNumber)


#region Input
Console.WriteLine("Name: ");
string name = Console.ReadLine();

Console.WriteLine("Surname: ");
string lastname = Console.ReadLine();

Console.WriteLine("Phone Number: ");
string phoneNumber = Console.ReadLine();
#endregion

Customer customer1 = new Customer()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTimeOffset.Now,
    FirstName = name,
    LastName = lastname,
    PhoneNumber = phoneNumber
};


//

var freelancerInstance = new Freelancer()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "gökhan",
    LastName = "ÖVSENE",
    WorkExperience = "ıd3",
    Reviews = new List<Review>
    {
        new Review{ Text="Excellent freelancer",Rating=5},
        new Review{ Text="good",Rating=4},
    }

};



NotepadService notepadService = new();
notepadService.SaveToNotepad(freelancerInstance);

Console.WriteLine();

string data= notepadService.GetOnNotepad("C:\\Users\\USER\\source\\repos\\freelancer\\freelancer\\Database\\Freelancer.txt");
string[] splitedLines = data.Split("\n",StringSplitOptions.RemoveEmptyEntries);

foreach (var line in splitedLines) 
{
    Freelancer freelancer = new();
    freelancer.SetValuesCSV(line);
}