// See https://aka.ms/new-console-template for more information
using DataAccess.Services;
using Newtonsoft.Json;

var time = DateTime.UtcNow;
var nextDate = time.AddSeconds(5);

var service = new StudentService();
int i = 0;

while (time <= nextDate)
{
    Console.WriteLine($"Saving Student #{i}");

	try
	{
		service.AddStudent(i++);
	}
	catch (Exception ex)
	{
		throw;
	}
}

Console.WriteLine("Saving Student");

foreach (var student in service.GetStudents())
{
    Console.WriteLine(JsonConvert.SerializeObject(student));
}
