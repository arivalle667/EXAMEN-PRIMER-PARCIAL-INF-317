using System;
using System.Collections.Generic;

public class ConvertidorInfijoAPrefijo
{
    // Función para convertir infijo a prefijo
    public string ConvertirInfijoAPrefijo(string infijo)
    {
        // Tokenizar la expresión para manejar correctamente números multi-dígito
        List<string> tokens = Tokenizar(infijo);
        tokens.Reverse(); // Invertir la lista de tokens

        // Ajustar paréntesis y procesar en prefijo
        Stack<string> pila = new Stack<string>();
        List<string> prefijo = new List<string>();

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out _)) // Es un número (multi-dígito permitido)
            {
                prefijo.Add(token);
            }
            else if (token == ")")
            {
                pila.Push(token);
            }
            else if (token == "(")
            {
                while (pila.Count > 0 && pila.Peek() != ")")
                {
                    prefijo.Add(pila.Pop());
                }
                pila.Pop(); // Quitar el paréntesis derecho correspondiente
            }
            else if (EsOperador(token))
            {
                while (pila.Count > 0 && Precedencia(pila.Peek()) >= Precedencia(token))
                {
                    prefijo.Add(pila.Pop());
                }
                pila.Push(token);
            }
        }

        while (pila.Count > 0)
        {
            prefijo.Add(pila.Pop());
        }

        prefijo.Reverse(); // Obtener el resultado en el orden correcto
        return string.Join(" ", prefijo);
    }

    // Función para dividir la expresión en tokens
    private List<string> Tokenizar(string expresion)
    {
        List<string> tokens = new List<string>();
        string numero = "";
        for (int i = 0; i < expresion.Length; i++)
        {
            char c = expresion[i];
            if (char.IsDigit(c) || c == ',') // Incluir números y coma decimal
            {
                numero += c;
            }
            else
            {
                if (numero != "")
                {
                    tokens.Add(numero);
                    numero = "";
                }
                if (EsOperador(c.ToString()) || c == '(' || c == ')')
                {
                    tokens.Add(c.ToString());
                }
            }
        }
        if (numero != "")
        {
            tokens.Add(numero);
        }
        return tokens;
    }

    // Función para determinar la precedencia de operadores
    private int Precedencia(string operador)
    {
        return operador == "+" || operador == "-" ? 1 : 2;
    }

    // Función para verificar si es un operador
    private bool EsOperador(string token)
    {
        return token == "+" || token == "-" || token == "*" || token == "/";
    }
}
