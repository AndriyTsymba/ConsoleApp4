using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee
    {
        // Поля класу
        private string fullName;
        private DateTime dateOfBirth;
        private string contactPhone;
        private string workEmail;
        private string position;
        private string jobDescription;

        // Конструктор за замовчуванням
        public Employee() { }

        // Конструктор з параметрами
        public Employee(string fullName, DateTime dateOfBirth, string contactPhone, string workEmail, string position, string jobDescription)
        {
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.contactPhone = contactPhone;
            this.workEmail = workEmail;
            this.position = position;
            this.jobDescription = jobDescription;
        }

        // Методи для введення даних
        public void SetFullName(string fullName)
        {
            this.fullName = fullName;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public void SetContactPhone(string contactPhone)
        {
            this.contactPhone = contactPhone;
        }

        public void SetWorkEmail(string workEmail)
        {
            this.workEmail = workEmail;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void SetJobDescription(string jobDescription)
        {
            this.jobDescription = jobDescription;
        }

        // Методи для отримання даних
        public string GetFullName()
        {
            return fullName;
        }

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public string GetWorkEmail()
        {
            return workEmail;
        }

        public string GetPosition()
        {
            return position;
        }

        public string GetJobDescription()
        {
            return jobDescription;
        }

        // Метод для виведення даних
        public void DisplayInfo()
        {
            Console.WriteLine($"ПІБ: {fullName}");
            Console.WriteLine($"Дата народження: {dateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Контактний телефон: {contactPhone}");
            Console.WriteLine($"Робочий email: {workEmail}");
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Опис обов'язків: {jobDescription}");
        }
    }

    // Демонстрація роботи класу
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            // Введення даних
            employee.SetFullName("Іваненко Іван Іванович");
            employee.SetDateOfBirth(new DateTime(2007, 9, 28));
            employee.SetContactPhone("+380501234567");
            employee.SetWorkEmail("ivan452@gmail.com");
            employee.SetPosition("Менеджер проектів");
            employee.SetJobDescription("Керування проектами, координація команди, звітність.");
            employee.DisplayInfo();
        }
    }

}

