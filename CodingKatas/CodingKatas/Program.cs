using CodingKatas.Kata1;
using CodingKatas.Kata2;
using CodingKatas.Kata3;
using CodingKatas.Kata4;
using CodingKatas.Kata5;
using CodingKatas.Kata6;

namespace CodingKatas;

public class Program
{
    static void Main()
    {
        #region KATA 1
        #region ConsoleProblemKata1
        Console.WriteLine("----------Console print problem Kata 1----------");
        IAnimal bird = new Bird();
        IAnimal fish = new Fish();
        IAnimal dog = new Dog();

        bird.Fly();
        dog.Run();
        fish.Swim();

        //fish.Run();  //Lanza excepción
        //bird.Swim();//Lanza excepción
        Console.WriteLine("----------Console print problem Kata 1----------");
        #endregion

        Console.WriteLine("\n");

        #region ConsoleSolutionKata1
        Console.WriteLine("----------Console print solution Kata 1----------");
        IFlyable birdFlyer = new BirdSolution();
        IRunnable birdRunner = new BirdSolution();
        ISwimmable fishSwims = new FishSolution();
        IRunnable dogRunner = new DogSolution();
        ISwimmable dogSwimmer = new DogSolution();

        birdFlyer.Fly();
        birdRunner.Run();
        fish.Swim();
        dogRunner.Run();
        dogSwimmer.Swim();
        Console.WriteLine("----------Console print solution Kata 1----------");
        #endregion
        #endregion

        Console.WriteLine("\n");
        Console.WriteLine("=================================================");
        Console.WriteLine("\n");

        #region KATA 2
        #region ConsoleProblemKata2
        Console.WriteLine("----------Console print problem Kata 2----------");
        ILegacyPrinter printer = new BasicPrinter();
        printer.Print();

        // Las siguientes llamadas lanzarían excepciones
        // printer.Scan();
        // printer.Fax();
        Console.WriteLine("----------Console print problem Kata 2----------");
        #endregion

        Console.WriteLine("\n");

        #region ConsoleSolutionKata2
        Console.WriteLine("----------Console print solution Kata 2----------");
        IPrintable basic = new BasicPrinterSolution();
        basic.Print();

        Console.WriteLine("---");

        IPrintable allInOne = new AllInOnePrinter();
        IScannable scanner = new AllInOnePrinter();
        IFaxable faxer = new AllInOnePrinter();

        allInOne.Print();
        scanner.Scan();
        faxer.Fax();
        Console.WriteLine("----------Console print solution Kata 2----------");
        #endregion
        #endregion

        Console.WriteLine("\n");
        Console.WriteLine("=================================================");
        Console.WriteLine("\n");

        #region KATA 3
        #region ConsoleProblemKata3
        Console.WriteLine("----------Console print problem Kata 3----------");
        IVehicle car = new Car();
        car.Drive();
        // car.Fly(); // Lanzaría excepción

        IVehicle plane = new Plane();
        plane.Fly();
        // plane.Drive(); // Lanzaría excepción

        IVehicle boat = new Boat();
        boat.Sail();
        // boat.Fly(); // Lanzaría excepción
        Console.WriteLine("----------Console print problem Kata 3----------");
        #endregion

        Console.WriteLine("\n");

        #region ConsoleSolutionKata3
        Console.WriteLine("----------Console print solution Kata 3----------");
        IDrivable carSolutionKata3 = new CarSolution();
        car.Drive();

        IFlyableSolutionKata3 planeSolutionKata3 = new PlaneSolution();
        plane.Fly();

        ISailable boatSolutionKata3 = new BoatSolution();
        boat.Sail();
        Console.WriteLine("----------Console print solution Kata 3----------");
        #endregion
        #endregion

        Console.WriteLine("\n");
        Console.WriteLine("=================================================");
        Console.WriteLine("\n");

        #region KATA 4
        #region ConsoleProblemKata3
        Console.WriteLine("----------Console print problem Kata 4----------");
        ISensor tempSensor = new TemperatureSensor();
        Console.WriteLine($"Temperature: {tempSensor.ReadTemperature()}°C");

        ISensor pressureSensor = new PressureSensor();
        Console.WriteLine($"Pressure: {pressureSensor.ReadPressure()} hPa");

        ISensor humiditySensor = new HumiditySensor();
        Console.WriteLine($"Humidity: {humiditySensor.ReadHumidity()}%");

        //Console.WriteLine("--ExcepcionError:");
        //tempSensor.ReadHumidity();
        //pressureSensor.ReadTemperature();
        Console.WriteLine("----------Console print problem Kata 4----------");
        #endregion

        Console.WriteLine("\n");

        #region ConsoleSolutionKata4
        Console.WriteLine("----------Console print solution Kata 4----------");
        ITemperatureReadable tempSensorSol = new TemperatureSensorSolution(30.5);
        Console.WriteLine($"Temperature: {tempSensorSol.ReadTemperature()}°C");

        IPressureReadable pressureSensorSol = new PressureSensorSolution(1100.2);
        Console.WriteLine($"Pressure: {pressureSensorSol.ReadPressure()} hPa");

        IHumidityReadable humiditySensorSol = new HumiditySensorSolution(30.5);
        Console.WriteLine($"Humidity: {humiditySensorSol.ReadHumidity()}%");
        Console.WriteLine("----------Console print solution Kata 4----------");
        #endregion
        #endregion

        Console.WriteLine("\n");
        Console.WriteLine("=================================================");
        Console.WriteLine("\n");

        #region KATA 5
        #region ConsoleProblemKata5
        Console.WriteLine("----------Console print problem Kata 5----------");
        ISmartDevice light = new SmartLight();
        light.TurnOn();
        light.ConnectToWiFi();
        // light.PlayMusic(); // Esto lanzaría excepción

        ISmartDevice speaker = new SmartSpeaker();
        speaker.TurnOn();
        speaker.ConnectToWiFi();
        speaker.PlayMusic();
        Console.WriteLine("----------Console print problem Kata 5----------");
        #endregion

        Console.WriteLine("\n");

        #region ConsoleSolutionKata5
        Console.WriteLine("----------Console print solution Kata 5----------");
        IPowerControllable lightPower = new SmartLightSolution();
        IWiFiConnectable lightWiFi = new SmartLightSolution();
        lightPower.TurnOn();
        lightWiFi.ConnectToWiFi();

        Console.WriteLine("---");

        IPowerControllable speakerPower = new SmartSpeakerSolution();
        IWiFiConnectable speakerWiFi = new SmartSpeakerSolution();
        IMusicPlayable speakerMusic = new SmartSpeakerSolution();

        speakerPower.TurnOn();
        speakerWiFi.ConnectToWiFi();
        speakerMusic.PlayMusic();
        Console.WriteLine("----------Console print solution Kata 5----------");
        #endregion
        #endregion

        Console.WriteLine("\n");
        Console.WriteLine("=================================================");
        Console.WriteLine("\n");

        #region KATA 6
        #region ConsoleProblemKata6
        Console.WriteLine("----------Console print problem Kata 6----------");
        IPaymentProcessor processor = new CreditCardProcessor();
        processor.ProcessCreditCard();

        // processor.ProcessPayPal(); // Lanza excepción
        Console.WriteLine("----------Console print problem Kata 6----------");
        #endregion

        Console.WriteLine("\n");

        #region ConsoleSolutionKata6
        Console.WriteLine("----------Console print solution Kata 6----------");
        ICreditCardPayment credit = new CreditCardProcessorSolution();
        credit.ProcessCreditCard();

        IPayPalPayment paypal = new PayPalProcessorSolution();
        paypal.ProcessPayPal();

        ICryptoPayment crypto = new CryptoProcessorSolution();
        crypto.ProcessCrypto();
        Console.WriteLine("----------Console print solution Kata 6----------");
        #endregion
        #endregion
    }
}