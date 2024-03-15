class Student
{
    public string surname;
    public DateOnly birthday;
    public string numberGroup;
    public int[] grade = new int[5];
    public void changingSurname(string newSurname)
    {
        surname = newSurname;
    }
    public void changingBirthday(DateOnly newBirthday)
    {
        birthday = newBirthday;
    }
    public void changingNumberGroup(string newNumberGroup)
    {
        numberGroup = newNumberGroup;
    }
    public void outputInformationAboutStudents()
    {
        Console.WriteLine($"информация о студенте: \nфамилия: {surname} \nдата рождения: {birthday} \nномер группы: {numberGroup} \nуспеваемость: {string.Join(", ", grade)}");

    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        Console.Write("введите фамилию студента: ");
        student.surname = Console.ReadLine();
        Console.Write("введите дату рождения студента(гггг.мм.дд): ");
        student.birthday = DateOnly.Parse(Console.ReadLine());
        Console.Write("введите номер группы студента: ");
        student.numberGroup = Console.ReadLine();

        Console.WriteLine("введите успеваемость студента(5 чисел через пробел): ");
        string[] gradeInput = Console.ReadLine().Split(' ');
        for (int i = 0; i < 5; ++i)
        {
            student.grade[i] = int.Parse(gradeInput[i]);
        }
        student.outputInformationAboutStudents();

        Console.WriteLine("\nвведите цифру того, что вы хотите изменить: ");
        Console.WriteLine("1 - фамилия");
        Console.WriteLine("2 - день рождения");
        Console.WriteLine("3 - номер группы");
        int change = int.Parse(Console.ReadLine());
        switch (change)
        {
            case 1:
                Console.WriteLine("введите новую фамилию: ");
                student.changingSurname(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("введите новую дату рождения (гггг.мм.дд): ");
                student.changingBirthday(DateOnly.Parse(Console.ReadLine()));
                break;
            case 3:
                Console.WriteLine("введите новый номер группы:");
                student.changingNumberGroup(Console.ReadLine());
                break;
        }

        Console.WriteLine("\nизмененная информация о студенте: ");
        student.outputInformationAboutStudents();
    }
}