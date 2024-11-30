using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using StructuralPatterns.Flyweight;
using StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Adapter: Utilizando classes adaptadoras para adaptar a interface de SensorA, SensorB e SensorC para ITemperatureSensor,
            // visando unificar a interface de leitura de temperatura para o método ReadTemperature().

            Console.WriteLine("Adapter Pattern");
            ITemperatureSensor sensorA = new SensorAAdapter();
            ITemperatureSensor sensorB = new SensorBAdapter();
            ITemperatureSensor sensorC = new SensorCAdapter();

            ITemperatureSensor[] sensors = new ITemperatureSensor[] { sensorA, sensorB, sensorC };
            foreach (var sensor in sensors)
            {
                Console.WriteLine(sensor.ReadTemperature());
            }

            // Bridge: Permite a separação da abstração da implementação, permitindo que a implementação possa ser alterada de
            // forma independente da abstração. Garantindo alta flexibilidade e extensibilidade a classe.

            Console.WriteLine("Bridge Pattern");
            IColor redColor = new RedColor();
            IColor blueColor = new BlueColor();

            Shape redCircle = new Circle(redColor);
            Shape blueCircle = new Circle(blueColor);
            Shape redSquare = new Square(redColor);
            Shape blueSquare = new Square(blueColor);

            Shape[] shapes = new Shape[] { redCircle, blueCircle, redSquare, blueSquare };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            // Composite: Permite a composição de objetos em estruturas de árvore para representar hierarquias parte-todo.

            Console.WriteLine("Composite Pattern");
            IMenuComponent menu = new Menu("Menu");

            IMenuComponent bifeComFritas = new Menu("Bife com Fritas");
            bifeComFritas.Add(new MenuItem("Bife"));
            bifeComFritas.Add(new MenuItem("Fritas"));
            bifeComFritas.Add(new MenuItem("Arroz"));
            menu.Add(bifeComFritas);

            IMenuComponent pizzaMarguerita = new Menu("Pizza Marguerita");
            pizzaMarguerita.Add(new MenuItem("Molho caseiro"));
            pizzaMarguerita.Add(new MenuItem("Mussarela"));
            pizzaMarguerita.Add(new MenuItem("Manjericão"));
            pizzaMarguerita.Add(new MenuItem("Tomate"));
            menu.Add(pizzaMarguerita);

            menu.Add(new MenuItem("Coca-Cola"));

            menu.Display("");

            // Decorator: Permite adicionar responsabilidades a objetos de forma dinâmica, sem alterar a estrutura da classe original.

            Console.WriteLine("Decorator Pattern");
            INotification baseNotification = new BaseNotification();
            INotification emailDecorator = new EmailDecorator(baseNotification);
            INotification smsDecorator = new SMSDecorator(baseNotification);
            INotification pushDecorator = new PushDecorator(baseNotification);

            emailDecorator.Send("Mensagem por e-mail");
            smsDecorator.Send("Mensagem por SMS");
            pushDecorator.Send("Mensagem por push");

            // uso de múltiplos decoradores
            INotification emailSmsDecorator = new EmailDecorator(smsDecorator);
            emailSmsDecorator.Send("Mensagem por e-mail e SMS");

            // Facade: Permite a criação de uma interface unificada, de alto nível, para um conjunto de interfaces em um subsistema.
            Console.WriteLine("Facade Pattern");
            HomeTheaterFacade homeTheater = new HomeTheaterFacade();

            // Com duas chamadas, é possível controlar todo o subsistema do Home Theater.
            homeTheater.PlayMovie("Shrek 4 - O Retorno do Rei");
            homeTheater.EndMovie();

            // Flyweight: Permite o compartilhamento de objetos para minimizar o uso de memória ou custo computacional.

            Console.WriteLine("Flyweight Pattern");
            TreeFactory treeFactory = new TreeFactory();
            TreeType treeType = treeFactory.GetTreeType("Carvalho");

            // Apenas um objeto TreeType é criado para ambas as árvores, minimizando o uso de memória.
            Tree tree1 = new Tree(10, 20, treeType);
            tree1.Draw();
            Tree tree2 = new Tree(20, 30, treeType);
            tree2.Draw();

            // Proxy: Permite a criação de um objeto de controle para outro objeto, permitindo a adição de comportamentos
            // antes ou depois de delegar a chamada ao objeto real.

            Console.WriteLine("Proxy Pattern");

            IImage image = new ProxyImage();
            image.Display();
        }
    }
}
