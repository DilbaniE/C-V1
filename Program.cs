internal class Program
{
    private static void Main(string[] args)
    {
        /*
        //------------------VARIABLES CONSOLA
           string nombre = "Dilbani";
          int edad = 24;
          float estatura = 1.64f;
          decimal num = 1.3m;
          double num2 = 1.2d;
          bool respuesta = true;
          Console.WriteLine("Mi nombre es: " + nombre + "" +
              " y tengo " + edad + " años " + " mi estatura es "
              + estatura + ", tienes gatos? " + respuesta);
          Console.WriteLine("aquie esta un valor {0}, y el otro valor {1}, estos valores son {2} ", num, num2, respuesta);
          Console.ReadKey(); */

        /*
        //------------------OPERADORES
        byte num1 = 100;
        byte num2 = 90;

        int suma = num1 + num2;
        int resta = num1 - num2;
        int multi = num1 * num2;
        int divi = num1 / num2;

        Console.WriteLine("suma {0}", suma);
        Console.WriteLine("resta {0}", resta);
        Console.WriteLine("multi {0}", multi);
        Console.WriteLine("divi {0}", divi);*/


        /*
        //----------------DATOS DE ENTRADA
        string nombre;
        int edad;
        double estatura;

        Console.WriteLine("Ingrese nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Su nombre es:{0} ", nombre);

        Console.WriteLine("Ingrese edad");
        edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Su edad es: {0}", edad);

        Console.WriteLine("Ingrese estatura");
        estatura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Su estatura es: {0}", estatura);
        */

        /*
        //Comparasion IF
        int a = 12;
        int b = 15;

        if (a != b) {
            Console.WriteLine("los numeros son diferenets");
        }
        Console.ReadKey();
         */



        /*
        //-----------------ejemplo1
        int num1, num2;
        Console.WriteLine("ingrese numero 1");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (num1 + num2 <= 20)
        {
            Console.WriteLine("la suma es menor");
        }
        Console.ReadKey();
        */


        /*
        //---------ejemplo 2

        double nota1, nota2, resul;

        Console.WriteLine("ingrese numero 1");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        resul = (nota1 + nota2) / 2;

        if (resul <= 5)
        {
            Console.WriteLine("aprobo y tu nota es: {0}", resul);
        }
        Console.ReadKey();
        */

        /*
        //----------------- IF ELSE
        int n1, n2;
        Console.WriteLine("ingrese numero 1");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (n1 < n2)
        {
            Console.WriteLine("{0} es menor que  {1}", n1,n2);
        }
        else
        {
            Console.WriteLine("{0} es mayor que {1}", n1, n2);
        }
        Console.ReadKey();
        */


        /* int n1, n2, n3;
        Console.WriteLine("@Biendvenido");
        Console.WriteLine("ingrese numero 1");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 3");
        n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");


            if (n1 > n2 && n1 > n3){
                Console.WriteLine("{0} es mayor que {1} y {2} ",n1, n2, n3);
            }
            else{
                if(n2 > n1 && n2 > n3)
                { 
                    Console.WriteLine("{0} es mayor ",n2);

                }
                else
                {
                    Console.WriteLine("{0} es mayor", n3);
                }

            }

            Console.ReadKey();*/



        /*------------------------ imprimiendo datos
         int num1 = 1;
        decimal num2 = 0.5m;
        float num3 = 1.5f;
        double num4 = 5.5;
        string nombre = "estudiante";

        Console.WriteLine("int {0}", num1);
        Console.WriteLine("decimal {0}", num2);
        Console.WriteLine("float {0}", num3);
        Console.WriteLine("double {0}", num4);
        Console.WriteLine("string {0}", nombre);*/




        /*--------------- de celcuis a fahrenheit
          int celcuis;
        double Fahrenheit;
        double result;

        Console.WriteLine("Ingrese celcuis");
        celcuis = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese Fahrenheit");
        Fahrenheit = Convert.ToDouble(Console.ReadLine());

        result = Convert.ToDouble(Fahrenheit * celcuis) + 32;
        Console.WriteLine(" fare" + result);
        Console.ReadKey();*/


        /*---------------promedio sacando 
        double num1, num2, num3, promedio;
        Console.WriteLine("ingrese numero 1");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        num3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        promedio = Convert.ToDouble((num1 + num2 + num3) / 3);
        Console.WriteLine("promerdio es: {0}", promedio);*/



        /*-----------------Area de un triangulo
         double baseTriangulo, alturaTriangulo, areaTriangulo;
        Console.WriteLine("ingrese numero 1");
        baseTriangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        alturaTriangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("ingrese numero 2");
        areaTriangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        areaTriangulo = Convert.ToDouble((alturaTriangulo * baseTriangulo ) / 2);
        Console.WriteLine("promerdio es: {0}", areaTriangulo); */


        /* ----------calcular edad
        DateTime ahoraFecha = DateTime.Now;
        Console.WriteLine("ingrese  su fech");
        DateTime  edad = Convert.ToDateTime(Console.ReadLine());

        int edadAhora = ahoraFecha.Year - edad.Year;

        if (ahoraFecha.Month < edad.Month || (ahoraFecha.Month == edad.Month && ahoraFecha.Day < edad.Day))
        {
            edadAhora--;
        }

        Console.WriteLine("Edad: " + edadAhora);*/


        string contra = "secreto1234";

        Console.WriteLine("ingrese la contraseña");
        contra = Console.ReadLine();

        if (contra == "secreto1234")
        {
            Console.WriteLine("¡Contraseña correcta! ");
        }
        else
        {
            Console.WriteLine("Acceso denegado ");
        }



    }
}