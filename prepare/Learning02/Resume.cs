public class Resume(string name, List<Job> jobs)
{
    string _name=name;
    List<Job> _Jobs=jobs;

    public void Display()
    {

        Console.WriteLine($"Name: {_name} \n Jobs:\n ");
        foreach (Job interator in _Jobs)
        {

            interator.Display();
        }
    }
}