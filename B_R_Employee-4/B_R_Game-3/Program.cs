using System.Collections;
using B_R_Game_3;

List<Employee> emplist = new List<Employee>()
{  
    new Employee("Marina", "woman", 4500, 1, "yes"),
    new Employee("Mark", "men", 5500, 2, "yes"),
    new Employee("Markis", "men", 7500, 3, "yes"),
    new Employee("Danila", "men", 3500, 4, "no"),
    new Employee("Happy", "men", 5500, 5, "yes"),
    new Employee("Sarina", "woman", 5700, 6, "yes"),
    new Employee("Nastya", "woman", 4350, 7, "yes"),   
    new Employee("Sasha", "woman", 5800, 8, "yes"),
    new Employee("Adolf", "men", 9500, 9, "Too good"),
    new Employee("Dream", "men", 8200, 10, "no"),
};

void GetInfoPeople(List<Employee> employee)
{
    foreach (Employee emp in employee)
    {
        Console.WriteLine($"Id - {emp.Id}" + " ");
        Console.WriteLine($"Инициалы - {emp.Fio}" + "");
        Console.WriteLine($"Пол это Лава - {emp.Gender}" + " ");
        Console.WriteLine($"Зарплата - {emp.Salary}" + " ");
        Console.WriteLine($"Номер отдела - {emp.Departament}" + "");
        Console.WriteLine($"Описание персонала - {emp.Description}" + "\n");
    }
}

static double GetSum(List<Employee> employee)
{
    double sum = 0;
    foreach (Employee emp in employee)
    {
        sum += emp.Salary;
    }
    return sum;
}

void GetMax(List<Employee> employee)//Самая большая зарплата Adolf
{
    Employee MaxSalary;
    for (int i = 0; i < employee.Count; i++)
    {
        for (int ja = i + 1; ja < employee.Count; ja++)
        {
            if (employee[i].Salary > employee[ja].Salary)
            {
                MaxSalary = employee[i];
                employee[i] = employee[ja];
                employee[ja] = MaxSalary;
            }
        }
    }
    Console.WriteLine($"Id - {employee[employee.Count - 1].Id}" + " ");
    Console.WriteLine($"Инициалы - {employee[employee.Count - 1].Fio}" + " ");
    Console.WriteLine($"Пол - {employee[employee.Count - 1].Gender}" + " ");
    Console.WriteLine($"Отдел - {employee[employee.Count - 1].Departament}" + " ");
    Console.WriteLine($"Зарплата - {employee[employee.Count - 1].Salary}\n");
}

static void Min(List<Employee> employee)//Самая маленькая зарплата Danila   
{
    Employee MinSalary;
    for (int i = 0; i < employee.Count; i++) 
    {
        for(int ja = i + 1; ja < employee.Count; ja++)
        {
            if (employee[i].Salary > employee[ja].Salary) 
            {
                MinSalary = employee[i];
                employee[i] = employee[ja];
                employee[ja] = MinSalary;
            }
        }
    }
    Console.WriteLine($"Id - {employee[0].Id}" + " ");
    Console.WriteLine($"Инициалы - {employee[0].Fio}" + " ");
    Console.WriteLine($"Пол - {employee[0].Gender}" + " ");
    Console.WriteLine($"Отдел - {employee[0].Departament}" + " ");
    Console.WriteLine($"Зарплата - {employee[0].Salary}\n");
}

static void Average(List<Employee> employee)
{
    Console.WriteLine($"Состовляет - {GetSum(employee) / employee.Count}");
}

void Fio(List<Employee> employee)
{
    foreach(Employee emp in employee)
    {
        Console.WriteLine($"Инициал сотрудника - {emp.Fio}");
    }
}
bool pop = true;

while (pop)
{
    Console.WriteLine("№1-Список всех сотрудников\n" + "№2-Сумма затраты зарплат\n" +
        "№3-Минимальная зарплата\n" + "№4-Максимальная заралата\n" + "№5-Средняя зарплата\n" +
        "№6-Инициалы Ф.И.О.\n" + "№7-Выход\n");
    try
    {
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                GetInfoPeople(emplist);
                break;

            case 2:
                Console.WriteLine($"Затраты в месяц:{ GetSum(emplist)}");
                break;

            case 3:
                GetMax(emplist);
                break;

            case 4:
                Min(emplist);
                break;

            case 5:
                Average(emplist);
                break;

            case 6:
                Fio(emplist);
                break;

            case 7:
                pop = false;
                break;
        }
    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Вы выбрали другое значение.\n Попробуй снова!\n Нажмите на любую клавишу.");
        Console.ReadKey();
    }
}

/*GetInfoPeople(emplist);
GetSum(emplist);
GetMax(emplist);
Min(emplist);
Average(emplist);
*/
Console.WriteLine("Hi bro nice Ass");

