namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declarar variable
            int acumulador;
            int cantidad;
            int valor = 0;
            int valormaximo = 0, valorminimo = 0;
            double promedio=0;
            #endregion

            #region iniciar contador y acumulador
            acumulador = 0;
            #endregion
            #region solicitar cantidad de ingresos
            Console.WriteLine("Ingrese la cantidad de números a entrar");
            cantidad = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region iterar
            for (int n = 0; n < cantidad; n++)
            {

                #region Solicitar valor
                Console.WriteLine($"Ingrese el número");
                valor = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region acumular valor
                //acumulador=acumulador+valor;
                acumulador += valor;
                #endregion

                #region verifico valor es maximo o primer valor
                if (valor > valormaximo || n == 0)
                {
                    valormaximo = valor;
                }
                #endregion

                #region verifico valor es mínimo o primer valor

                if (valor < valorminimo || n == 0)
                {
                    valorminimo = valor;
                }
                #endregion

                #region verificar si hubo ingresos
                if (cantidad > 0)
                {
                    promedio = 1.0 * acumulador / cantidad;
                }
                #endregion
            }
            #endregion
            #region mostrar maximo,minimo y promedio
            if (cantidad > 0)
            {
                Console.WriteLine($"El valor máximo es {valormaximo}");
                Console.WriteLine($"El valor mínimo es {valorminimo}");
                Console.WriteLine($"El promedio es {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron valores");
            }
            #endregion
        }
    }
}

