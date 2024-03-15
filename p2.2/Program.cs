class train
{
    public string direction;
    public int trainNumber;
    public DateTime departureTime;
    public void outputInformationTrain()
    {
        Console.WriteLine($"номер поезда: {trainNumber}");
        Console.WriteLine($"направление: {direction}");
        Console.WriteLine($"время отправления: {departureTime}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("введите количество поездов, которые хотите добавить: ");
        int quantityTrain = int.Parse(Console.ReadLine());
        train[] trains = new train[quantityTrain];

        for (int i = 0; i < quantityTrain; i++)
        {
            train train = new train();

            Console.WriteLine($"введите информацию о поезде {i + 1}: ");
            Console.Write("пункт назначения: ");
            train.direction = Console.ReadLine();
            Console.Write("номер поезда: ");
            train.trainNumber = int.Parse(Console.ReadLine());
            Console.Write("время отправления (гггг-мм-дд чч:мм:сс): ");
            train.departureTime = DateTime.Parse(Console.ReadLine());

            trains[i] = train;
            Console.WriteLine();
            Console.WriteLine("информация о поезде добавлена.");
        }

        Console.WriteLine("введите номер поезда, чтобы получить информацию:");
        int numberTrains = int.Parse(Console.ReadLine());

        train SelectedTrain = null;

        foreach (var train in trains)
        {
            if (train.trainNumber == numberTrains)
            {
                SelectedTrain = train;
                break;
            }
        }

        Console.WriteLine("ИНФОРМАЦИЯ О ПОЕЗДЕ");
        SelectedTrain.outputInformationTrain();
    }
}