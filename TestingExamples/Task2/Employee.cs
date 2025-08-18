namespace Task2
{
    public class Employee : Person
    {
        public string JobTitle { get; set; }

        public Employee(string name, int age, string jobTitle) : base(name, age)
        {
            JobTitle = jobTitle;
        }

        public override string ToString()
        {
            return base.ToString() + $"Job Title: {JobTitle}";
        }
    }
}