using Task2;

namespace Task2.Tests
{
    public class PersonTests
    {
        [Test]
        public void CheckIfStaffMemberIsCreated()
        {
            // Arrange
            var name = "Dirk";
            var age = 30;

            // Act
            var person = new Person(name, age);

            // Assert
            Assert.AreEqual(name, person.Name, "Constructor should initialize Age property.");
            Assert.AreEqual(age, person.Age, "Constructor should initialize Age property.");
        }

        [Test]
        public void CheckIfNameOfStaffMemberIsChangeable()
        {
            // Arrange
            var person = new Person("John Doe", 30);
            var newName = "Jane Doe";

            // Act
            person.Name = newName;

            // Assert
            Assert.AreEqual(newName, person.Name, "Name property should have a get and set property");
        }

        [Test]
        public void CheckIfAgeOfStaffMemberIsChaneable()
        {
            // Arrange
            var person = new Person("Jane Doe", 30);
            int newAge = 29;

            // Act
            person.Age = newAge;   

            // Assert
            Assert.AreEqual(newAge, person.Age, "Age property should have a get and set property");

        }
    }

    public class EmployeeTests()
    {
        [Test]
        public void CheckIfToStringIsImplemented()
        {
            // Arrange
            var employee = new Employee("John Doe", 30, "Developer");
            var expectedOut = $"Employee: {employee.Name}, Age: {employee.Age}, Job Title: {employee.JobTitle}";
                
            // Act
            var output = employee.ToString();

            // Assert
            Assert.AreEqual(expectedOut, output);
        }
    }
}