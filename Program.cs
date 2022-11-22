using System;
using System.Threading;

namespace Salud_Cardio_Vascular
{
    /*La cardiopatía coronaria (CHD, por sus siglas en inglés) es el tipo más común de enfermedad cardíaca y sucede cuando se 
     * acumula placa en las arterias que conducen al corazón. También se llama arteriopatía coronaria (CAD, por sus siglas en inglés). 
     * Cuando se estrechan las arterias, el corazón no puede recibir suficiente sangre y oxígeno. Una arteria bloqueada puede causar 
     * un ataque cardíaco. Con el tiempo, la CHD puede debilitar el miocardio y provocar insuficiencia cardíaca o arritmias.

     La insuficiencia cardíaca ocurre cuando el miocardio se vuelve rígido o débil. No puede bombear suficiente sangre oxigenada, 
     lo cual causa síntomas en todo el cuerpo. La enfermedad puede afectar solo el lado derecho o el lado izquierdo del corazón. 
     Es muy frecuente que ambos lados del corazón estén comprometidos. La preeion arterial alta y la CAD son causas comunes de la 
     insuficiencia cardíaca.

     Las arritmias son problemas con la frecuencia cardíaca (pulso) o el ritmo cardíaco. Esto ocurre cuando el sistema eléctrico 
     del corazón no funciona correctamente. El corazón puede palpitar demasiado rápido, demasiado lento o en forma irregular. Algunos 
     problemas del corazón, como un ataque cardíaco o una insuficiencia cardíaca, pueden causar problemas con el sistema eléctrico del 
     corazón. Algunas personas nacen con una arritmia.

     Las enfermedades de las válvulas cardíacas ocurren cuando una de las cuatro válvulas en el corazón no funciona correctamente. La 
     sangre puede escaparse a través de la válvula en la dirección equivocada (llamado regurgitación), o es posible que una válvula no se 
     abra lo suficiente y bloquee el flujo sanguíneo (llamado estenosis). Un latido cardíaco inusual, llamado soplo cardíaco, es el síntoma 
     más común. Algunos problemas del corazón, como un ataque cardíaco, una cardiopatía o una infección, pueden causar enfermedades de las 
     válvulas del corazón. Algunas personas nacen con problemas de válvulas cardíacas.

     La arteriopatía periférica ocurre cuando las arterias de las piernas y los pies se estrechan debido a la acumulación de placa. Las 
     arterias estrechas reducen o bloquean el flujo sanguíneo. Cuando la sangre y el oxígeno no pueden llegar a las piernas, esto puede lesionar 
     los nervios y tejidos.

     La presión arterial alta (hipertensión) es una enfermedad cardiovascular que puede conducir a otros problemas, tales como ataque cardíaco, 
     insuficiencia cardíaca y accidente cerebrovascular.

     Un accidente cerebrovascular es causado por la falta de flujo sanguíneo al cerebro. Esto puede suceder debido a un coágulo de sangre que 
     viaja a los vasos sanguíneos en el cerebro o un sangrado en el cerebro. El accidente cerebrovascular tiene muchos de los mismos factores de 
     riesgo que una cardiopatía.

     La cardiopatía congénita es un problema con la estructura y funcionamiento del corazón que está presente al nacer. Este término puede 
    describir muchos problemas diferentes que afectan el corazón. Es el tipo más común de anomalía congénita.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RCP =0, Ejercicio =0, Indicación =0, gravedad =0, presionb=0, presionA=0;
            float car =0, ins =0, arr =0, art =0, hip =0;
            string name = "", a = "", p = "", pa="";
            int age = 0, patologia=0;
            float peso = 0;
            Console.WriteLine("Enfermedades que afectan la salud cardiovascular\n");
            Console.WriteLine("1- Cardiopatía coronaria"); // 0.19
            Console.WriteLine("2- Insuficiencia cardíaca"); // 0.15
            Console.WriteLine("3- Arritmias"); //14
            Console.WriteLine("4- Arteriopatía periférica"); //14
            Console.WriteLine("5- Hipertensión"); // 13
            Console.WriteLine("\n");

            Console.Write("Ingrese Nombre: ");
            name = Console.ReadLine();
            Console.Write("Ingrese Edad: ");
            a = Console.ReadLine();
            int.TryParse(a, out age);
            Console.Write("Ingrese seleccione su Patologia (Enfermedad): ");
            pa = Console.ReadLine();
            int.TryParse(pa, out patologia);
            Console.Write("Ingrese Peso en Lbs: ");
            p = Console.ReadLine();
            float.TryParse(p, out peso);

            switch (patologia)
            {
                case 1:
                    car += 0.19f;
                    if (peso > 200)
                    {
                        car += 0.05f;
                    }
                    break;
                case 2:
                    car += 0.15f;
                    if (peso > 200)
                    {
                        car += 0.05f;
                    }
                    break;
                case 3:
                    car += 0.14f;
                    if (peso > 200)
                    {
                        car += 0.05f;
                    }
                    break;

                case 4:
                    car += 0.14f;
                    if (peso > 200)
                    {
                        car += 0.05f;
                    }
                    break;
                case 5:
                    car += 0.13f;
                    if (peso > 200)
                    {
                        car += 0.05f;
                    }
                    break;
                case 6:
                    break;
                default: Console.WriteLine("Opcion no valida");
                    break;
            }
            car *= 100;
            car /= 6;
            do
            {
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                presionb = random.Next(10, 190);
                presionb += (int)car;

                if (presionb < 40)
                {
                    Console.WriteLine("bradicardia sinusal, LPM bajos");
                    Console.WriteLine("Debes Asistir al doctor");
                    Indicación++;
                }
                else if (presionb > 100 && presionb < 150)
                {
                    Console.WriteLine("Tiene Taquicardia...");
                    Console.WriteLine("Debe relajarse para bajar su ritmo cardiaco");
                    Console.WriteLine("Debe asistir a un Doctor");
                    Indicación++;
                    Ejercicio++;
                }
                else if (presionb > 150 && presionb <= 160)
                {
                    Console.WriteLine("Nivel de gravedad en tendencia peligros");
                    Console.WriteLine("Alertando A familiar o Institucion");
                    gravedad++;
                }else if(presionb > 160)
                {
                    Console.WriteLine("Necesta RCP");
                    Console.WriteLine("Alertando A familiar o Institucion");
                    RCP++;
                }
                

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Persona persona = new Persona(name, age, patologia, peso);
            persona.Datos();
        }
        public class Persona
        {
            public string name { get; set; }
            public int age { get; set; }
            public int patologia { get; set; }
            public float peso { get; set; }

            public Persona(string name, int age, int patologia, float peso)
            {
                this.name = name;
                this.age = age;
                this.patologia = patologia;
                this.peso = peso;
            }
            public Persona()
            {
                this.name = "";
                this.age = 0;
                this.patologia = 0;
                this.peso = 0.0f;
            }

            public void Datos()
            {
                Console.WriteLine($"Nombre: {name}\nEdad: {age}\nPatologia: {patologia}\nPeso: {peso}");
            }

        }
    }
}
