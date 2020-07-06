using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesParaCalculadora
{
    public class Calculadora
    {
        private float num1;
        private float num2;
        private DateTime fechaYHora;

        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }
        public DateTime FechaYHora { get => fechaYHora; set => fechaYHora = value; }

        public float Suma()
        {
            return Num1 + Num2;
        }

        public float Resta()
        {
            return Num1 - Num2;
        }

        public float Multiplicaion()
        {
            return Num1 * Num2;
        }

        public float Divicion()
        {
            if (Num2 != 0)
            {
                return Num1 / Num2;
            }
            else
            {
                Console.WriteLine("no se puede realizar la divicion");
                return 0;
            }
        }
        public float Calculador(string numero)
        {
            string ecuacion = numero;
            float REsult = 0;
            string[] dividir;
            foreach (char car in ecuacion)
            {
                switch (car)
                {
                    case '+':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Suma();
                        
                        break;
                    case '-':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Resta();
                        break;
                    case '*':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Multiplicaion();
                        break;
                    case '/':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Divicion();
                        break;
                    default: break;
                }
            }
            return REsult;
        }
        public string Mostrar(string numero)
        {
            string ecuacion = numero;
            float REsult = 0;
            string[] dividir;
            string mostrarResult = "";
            int num = 0;
            foreach (char car in ecuacion)
            {
                switch (car)
                {
                    case '+':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Suma();
                        FechaYHora = DateTime.Now.AddDays(num);
                        mostrarResult = FechaYHora + " - " + Num1 + car + Num2 + "=" + REsult;
                        break;
                    case '-':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Resta();
                        FechaYHora = DateTime.Now.AddDays(num);
                        mostrarResult = FechaYHora + " - " + Num1 + car + Num2 + "=" + REsult;
                        break;
                    case '*':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Multiplicaion();
                        FechaYHora = DateTime.Now.AddDays(num);
                        mostrarResult = FechaYHora + " - " + Num1 + car + Num2 + "=" + REsult; ;
                        break;
                    case '/':
                        dividir = ecuacion.Split(car);
                        Num1 = float.Parse(dividir[0]);
                        Num2 = float.Parse(dividir[1]);
                        REsult = Divicion();
                        FechaYHora = DateTime.Now.AddDays(num);
                        mostrarResult = FechaYHora + " - " + Num1 + car + Num2 + "=" + REsult;
                        break;
                    default: break;
                }
            }
            return mostrarResult;

        }
    }
}
