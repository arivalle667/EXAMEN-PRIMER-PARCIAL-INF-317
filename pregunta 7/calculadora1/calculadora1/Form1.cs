using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora1
{
    public partial class Form1 : Form
    {
        String valor1 = "";
        String valor2 = "";
        Boolean exoperador = false;
        String operador = "";
        Boolean v1dec = false;
        Boolean v2dec = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0

            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 0";
                    valor2 = "0";
                }
                else
                {
                    valor2 = valor2 + "0";
                    tbDisplay.Text = valor1 + " " + operador + " " +valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "0";
                    valor1 = "0";
                }
                else
                {
                    valor1 = valor1 + "0";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 1";
                    valor2 = "1";
                }
                else
                {
                    valor2 = valor2 + "1";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "1";
                    valor1 = "1";
                }
                else
                {
                    valor1 = valor1 + "1";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 2";
                    valor2 = "2";
                }
                else
                {
                    valor2 = valor2 + "2";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "2";
                    valor1 = "2";
                }
                else
                {
                    valor1 = valor1 + "2";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 3";
                    valor2 = "3";
                }
                else
                {
                    valor2 = valor2 + "3";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "3";
                    valor1 = "3";
                }
                else
                {
                    valor1 = valor1 + "3";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 4";
                    valor2 = "4";
                }
                else
                {
                    valor2 = valor2 + "4";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "4";
                    valor1 = "4";
                }
                else
                {
                    valor1 = valor1 + "4";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 5";
                    valor2 = "5";
                }
                else
                {
                    valor2 = valor2 + "5";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "5";
                    valor1 = "5";
                }
                else
                {
                    valor1 = valor1 + "5";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 6";
                    valor2 = "6";
                }
                else
                {
                    valor2 = valor2 + "6";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "6";
                    valor1 = "6";
                }
                else
                {
                    valor1 = valor1 + "6";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 7";
                    valor2 = "7";
                }
                else
                {
                    valor2 = valor2 + "7";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "7";
                    valor1 = "7";
                }
                else
                {
                    valor1 = valor1 + "7";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 8";
                    valor2 = "8";
                }
                else
                {
                    valor2 = valor2 + "8";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "8";
                    valor1 = "8";
                }
                else
                {
                    valor1 = valor1 + "8";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            if (exoperador)
            {
                if (valor2 == "0")
                {
                    tbDisplay.Text = valor1 + " " + operador + " 9";
                    valor2 = "9";
                }
                else
                {
                    valor2 = valor2 + "9";
                    tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                }
            }
            else
            {
                if (valor1 == "0")
                {
                    tbDisplay.Text = "9";
                    valor1 = "9";
                }
                else
                {
                    valor1 = valor1 + "9";
                    tbDisplay.Text = valor1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = "";
            valor2 = "";
            exoperador = false;
            operador = "";
            tbDisplay.Text = "";

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(valor1))
            {
                if (!exoperador)
                {
                    exoperador = true;
                    valor1 = tbDisplay.Text;
                    operador = "+";
                    tbDisplay.Text = valor1 + operador + " ";
                }
            }
        }

        private readonly CultureInfo culture = new CultureInfo("es-ES"); // Cultura con coma como separador decimal

        // Método para evaluar expresiones infijas
        public double EvaluarInfija(string expresion)
        {
            Stack<double> valores = new Stack<double>();
            Stack<char> operadores = new Stack<char>();

            for (int i = 0; i < expresion.Length; i++)
            {
                // Ignorar espacios en blanco
                if (expresion[i] == ' ')
                    continue;

                // Si es un número, añadirlo a la pila de valores
                if (char.IsDigit(expresion[i]) || expresion[i] == ',')
                {
                    string valor = "";
                    while (i < expresion.Length && (char.IsDigit(expresion[i]) || expresion[i] == ','))
                    {
                        valor += expresion[i++];
                    }
                    valores.Push(double.Parse(valor, culture));
                    i--; // Ajustar el índice
                }
                else if (expresion[i] == '(')
                {
                    operadores.Push(expresion[i]);
                }
                else if (expresion[i] == ')')
                {
                    while (operadores.Peek() != '(')
                        valores.Push(Operar(operadores.Pop(), valores.Pop(), valores.Pop()));
                    operadores.Pop();
                }
                else if (EsOperador(expresion[i]))
                {
                    while (operadores.Count > 0 && Precedencia(operadores.Peek()) >= Precedencia(expresion[i]))
                        valores.Push(Operar(operadores.Pop(), valores.Pop(), valores.Pop()));
                    operadores.Push(expresion[i]);
                }
            }

            while (operadores.Count > 0)
                valores.Push(Operar(operadores.Pop(), valores.Pop(), valores.Pop()));

            return valores.Pop();
        }

        // Método para evaluar expresiones prefijas
        public double EvaluarPrefija(string expresion)
        {
            Stack<double> pila = new Stack<double>();

            string[] tokens = expresion.Split(' ');
            Array.Reverse(tokens);

            foreach (string token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Float, culture, out double numero))
                {
                    pila.Push(numero);
                }
                else if (EsOperador(token[0]))
                {
                    double operando1 = pila.Pop();
                    double operando2 = pila.Pop();
                    double resultado = Operar(token[0], operando1, operando2);
                    pila.Push(resultado);
                }
            }

            return pila.Pop();
        }

        // Función para determinar si es un operador válido
        private bool EsOperador(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // Función para determinar la precedencia de los operadores
        private int Precedencia(char operador)
        {
            return operador == '+' || operador == '-' ? 1 : 2;
        }

        // Función para realizar las operaciones matemáticas
        private double Operar(char operador, double b, double a)
        {
            switch (operador)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: throw new ArgumentException("Operador no válido");
            }
        }

        // Método para devolver el resultado formateado con coma
        public string FormatearResultado(double resultado)
        {
            return resultado.ToString("N", culture); // Formateo usando coma como separador decimal
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(valor1))
            {
                if (!exoperador)
                {
                    exoperador = true;
                    valor1 = tbDisplay.Text;
                    operador = "-";
                    tbDisplay.Text = valor1 + operador + " ";
                }
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(valor1))
            {
                if (!exoperador)
                {
                    exoperador = true;
                    valor1 = tbDisplay.Text;
                    operador = "*";
                    tbDisplay.Text = valor1 + operador + " ";
                }
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(valor1))
            {
                if (!exoperador)
                {
                    exoperador = true;
                    valor1 = tbDisplay.Text;
                    operador = "/";
                    tbDisplay.Text = valor1 + operador + " ";
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(valor1) && !String.IsNullOrEmpty(valor2) && !String.IsNullOrEmpty(operador))
            {
                ConvertidorInfijoAPrefijo convertidor = new ConvertidorInfijoAPrefijo();
                tbDisplay2.Text = convertidor.ConvertirInfijoAPrefijo(tbDisplay.Text) + " = " + EvaluarInfija(tbDisplay.Text);
                tbDisplay.Text = tbDisplay.Text + " = " + EvaluarInfija(tbDisplay.Text);
                valor1 = "";
                valor2 = "";
                exoperador = false;
                operador = "";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(valor1))
            {
                if (!String.IsNullOrEmpty(valor2))
                {
                    if (!v2dec)
                    {
                        valor2 = valor2 + ",";
                        tbDisplay.Text = valor1 + " " + operador + " " + valor2;
                        v2dec = true;
                    }
                }
                else
                {
                    if (!v1dec)
                    {
                        valor1 = valor1 + ",";
                        tbDisplay.Text = valor1;
                        v1dec = true;
                    }
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }




    }
}
