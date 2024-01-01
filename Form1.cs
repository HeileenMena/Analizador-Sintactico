using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace Analizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void principal()
        {
            string Entrada = Analizadortxb.Text;
            char[] salto = { '\n' };
            char[] limitador = { ' ' };
            string[] RArray = Entrada.Split(salto);
            for (int i = 0; i < RArray.Length; i++)
            {
                string[] palabra = RArray[i].Split(limitador);
                for (int j = 0; j < palabra.Length; j++)
                {
                    palabra[j] = palabra[j].Replace("\n", "");
                    //Llena los DataGridView
                    if (palabra[j] != "")
                    {
                        //DataGridView del analizador lexico
                        Analizadordgv.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        DataGridViewRow row = (DataGridViewRow)Analizadordgv.Rows[0].Clone();
                        //Coloca la palabra o caracter en la tabla
                        row.Cells[0].Value = palabra[j];
                        //Dice el tipo de token que es
                        row.Cells[1].Value = analizar(palabra[j]);
                        //Menciona el patrón
                        row.Cells[2].Value = Patron(palabra[j]);
                        Analizadordgv.Rows.Add(row);

                        //DataGridView del analizador Sintactico
                        sintacticodgv.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        DataGridViewRow row1 = (DataGridViewRow)sintacticodgv.Rows[0].Clone();
                        //Coloca si es correcto o no la sentencia
                        row1.Cells[0].Value = Validacion(palabra[j]);
                        //Dice el tipo de token que es
                        row1.Cells[1].Value = TipoError(palabra[j]);
                        //Menciona la fila
                        row1.Cells[2].Value = i + 1;
                        //Menciona la columna
                        row1.Cells[3].Value = j + 1;
                        sintacticodgv.Rows.Add(row1);
                    }
                }
            }
        }

        //Llena la columna de Lexema
        public string analizar(string analizado)
        {
            string dato = "";
            switch (analizado)
            {
                case "=":
                case "<=":
                case "!=":
                case ">=":
                case "<":
                case ">":
                    dato = "Operador de asignación";
                    break;
                case "*":
                case "+":
                case "++":
                case "--":
                case "-":
                case "/":
                    dato = "Operador numérico";
                    break;
                case ";":
                case "(":
                case ")":
                case "[":
                case "]":
                case "{":
                case "}":
                    dato = "Delimitador";
                    break;
                case "while":
                case "for":
                case "foreach":
                case "do":
                case "if":
                case "else":
                case "switch":
                case "case":
                case "break":
                case "return":
                case "catch":
                case "try":
                case "decimal":
                case "float":
                case "int":
                case "null":
                case "object":
                case "default":
                case "in":
                case "long":
                case "event":
                case "explicit":
                case "true":
                case "false":
                case "extern":
                case "finally":
                case "internal":
                case "public":
                case "private":
                case "new":
                case "get":
                    dato = "Palabra reservada";
                    break;
                default:
                    int valor = 0;
                    int validar = 0;
                    //Si el dato es verdadero, da como resultado un número
                    if (int.TryParse(analizado, out valor))
                    {
                        dato = "Valor númerico";
                        validar = 1;
                    }
                    //Valida si se ingreso una cadena
                    if (analizado.StartsWith("'") && analizado.EndsWith("'"))
                    {
                        dato = "Cadena";
                        validar = 1;
                    }
                    //Pasa el dato como un identificador
                    if (analizado.StartsWith("v"))
                    {
                        dato = "Identificador";
                        validar = 1;
                    }

                    if (validar == 0)
                    {
                        dato = "ERROR";
                    }
                    break;

            }
            return dato;
        }

        //Llena la columna de Patron
        public string Patron(string analizado)
        {
            string dato = "";
            switch (analizado)
            {
                case "=":
                case "<=":
                case "!=":
                case ">=":
                case "<":
                case ">":
                    dato = "=, <, >, <=, >=, !=";
                    break;
                case "*":
                case "+":
                case "++":
                case "--":
                case "-":
                case "/":
                    dato = "+, -, /, *";
                    break;
                case ";":
                case "(":
                case ")":
                case "[":
                case "]":
                case "{":
                case "}":
                    dato = "(, ), [, ], {, }, ;";
                    break;
                case "while":
                case "for":
                case "foreach":
                case "do":
                case "if":
                case "else":
                case "switch":
                case "case":
                case "break":
                case "return":
                case "catch":
                case "try":
                case "decimal":
                case "float":
                case "int":
                case "null":
                case "object":
                case "default":
                case "in":
                case "long":
                case "event":
                case "explicit":
                case "true":
                case "false":
                case "extern":
                case "finally":
                case "internal":
                case "public":
                case "private":
                case "new":
                case "get":
                    dato = analizado;
                    break;
                default:
                    int valor = 0;
                    int validar = 0;
                    //Si el dato es verdadero, da como resultado un número
                    if (int.TryParse(analizado, out valor))
                    {
                        dato = "Número conformado por dígitos entre 0 - 9";
                        validar = 1;
                    }
                    //Valida si se ingreso una cadena
                    if (analizado.StartsWith("\"") && analizado.EndsWith("\""))
                    {
                        dato = "Conformado por carácteres alfanuméricos";
                        validar = 1;
                    }
                    //Pasa el dato como un identificador
                    if (analizado.StartsWith("v"))
                    {
                        dato = analizado;
                        validar = 1;
                    }

                    if (validar == 0)
                    {
                        dato = "Caracter no identificado";
                    }
                    break;
            }
            return dato;
        }

        //Llena la columna de estructura (Correcto o incorrecto)
        public string Validacion(string analizado)
        {
            string dato = "";
            int valor = 0;
            int validar = 0;
            switch (analizado)
            {
                case "=":
                case "<=":
                case "!=":
                case ">=":
                case "<":
                case ">":
                case "*":
                case "+":
                case "++":
                case "--":
                case "-":
                case "/":
                case ";":
                case "(":
                case ")":
                case "[":
                case "]":
                case "{":
                case "}":
                case "while":
                case "for":
                case "foreach":
                case "do":
                case "if":
                case "else":
                case "switch":
                case "case":
                case "break":
                case "return":
                case "catch":
                case "try":
                case "decimal":
                case "float":
                case "int":
                case "null":
                case "object":
                case "default":
                case "in":
                case "long":
                case "event":
                case "explicit":
                case "true":
                case "false":
                case "extern":
                case "finally":
                case "internal":
                case "public":
                case "private":
                case "new":
                case "get":
                    validar = 1;
                    dato = "CORRECTO";
                    break;
                default:
                    //Si el dato es verdadero, da como resultado un número
                    if (analizado.StartsWith("(") && analizado.EndsWith(")"))
                    {
                        dato = "CORRECTO";
                        validar = 1;
                    }
                    if (int.TryParse(analizado, out valor))
                    {
                        dato = "CORRECTO";
                        validar = 1;
                    }
                    //Valida si se ingreso una cadena
                    if (analizado.StartsWith("'") && analizado.EndsWith("'"))
                    {
                        dato = "CORRECTO";
                        validar = 1;
                    }
                    //Pasa el dato como un identificador
                    if (analizado.StartsWith("v"))
                    {
                        dato = "CORRECTO";
                        validar = 1;
                    }

                    if (validar == 0)
                    {
                        dato = "ERROR";
                                            }
                    break;

            }
            return dato;
        }

        //Llena la columna de estructura (Correcto o incorrecto)
        public string TipoError(string analizado)
        {
            string dato = "";
            int valor = 0;
            int validar = 0;
            string[] palabras = { "break", "case", "catch", "decimal", "default", "do", "else", "event", "explicit", "extern", "false", "finally", "float", "for", "foreach", "get", "if", "in", "int", "internal", "long", "new", "null", "object", "private", "public", "return", "switch", "true", "try", "while" };
            switch (analizado)
            {
                case "=":
                case "<=":
                case "!=":
                case ">=":
                case "<":
                case ">":
                    dato = "Operadores de asignacion";
                    break;
                case "*":
                case "+":
                case "++":
                case "--":
                case "-":
                case "/":
                    dato = "Operadores matematicos";
                    break;
                case ";":
                case "(":
                case ")":
                case "[":
                case "]":
                case "{":
                case "}":
                    dato = "Delimitadores";
                    
                    break;
                case "while":
                case "for":
                case "foreach":
                case "do":
                case "if":
                case "else":
                case "switch":
                case "case":
                case "break":
                case "return":
                case "catch":
                case "try":
                case "decimal":
                case "float":
                case "int":
                case "null":
                case "object":
                case "default":
                case "in":
                case "long":
                case "event":
                case "explicit":
                case "true":
                case "false":
                case "extern":
                case "finally":
                case "internal":
                case "public":
                case "private":
                case "new":
                case "get":
                    dato = "Palabra reservada";
                    break;
                default:
                    //Si el dato es verdadero, da como resultado un número
                    if (int.TryParse(analizado, out valor))
                    {
                        dato = "Valor numérico";
                        validar = 1;
                    }
                    //Valida si se ingreso una cadena
                    if (analizado.StartsWith("'") && analizado.EndsWith("'"))
                    {
                        dato = "Cadena de texto";
                        validar = 1;
                    }
                    //Pasa el dato como un identificador
                    if (analizado.StartsWith("v"))
                    {
                        dato = "Variable";
                        validar = 1;
                    }

                    if (validar == 0)
                    {
                        if (analizado.StartsWith("(") || analizado.EndsWith(")"))
                        {
                            dato = "Falta un parentesis";
                        }
                        if (analizado.StartsWith("{") || analizado.EndsWith("}"))
                        {
                            dato = "Falta una llave";
                        }
                        if (analizado.StartsWith("[") || analizado.EndsWith("]"))
                        {
                            dato = "Falta un parentesis";
                        }
                        foreach (char c in analizado)
                        {
                            string pal = analizado.ToLower();
                            for (int i = 0; i < palabras.Length; i++)
                            {
                                //Busca palabras reservadas
                                if (palabras[i] == pal)
                                {
                                    dato = "Palabra mal escrita. Intenta sustituir por: " + palabras[i];
                                    break;
                                }
                                //Busca Variables
                                if (!Char.IsLetter(c))
                                {
                                    dato = "Se ha ingresado un valor que mezcla letras y números sin ser variable. Coloca una v al inicio para solucionar";
                                }
                                //Busca las palabras reservadas
                                if (!Char.IsDigit(c))
                                {
                                    dato = "No se encuentra esta palabra dentro de nuestra librería. En caso de querer crear una variable coloca una v al inicio";
                                }
                            }
                        }
                    }
                    break;
            }
            return dato;
        }

        private void Analizadortxb_TextChanged(object sender, EventArgs e)
        {
            limpiar();
            principal();
        }

        private void limpiar()
        {
            Analizadordgv.Rows.Clear();
            sintacticodgv.Rows.Clear();
        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = Interaction.InputBox("Ingrese el nombre del archivo");
            using (var tw = new StreamWriter("C:\\Users\\Usuario\\Desktop\\Analizador\\Códigos guardados\\Léxico: " + nombre + ".txt"))
            {
                foreach (DataGridViewRow row in Analizadordgv.Rows)
                {
                    tw.WriteLine($"{row.Cells[0].Value}");
                }
            }
            using (var tw = new StreamWriter("C:\\Users\\Usuario\\Desktop\\Analizador\\Códigos guardados\\Sintáctico: " + nombre + ".txt"))
            {
                foreach (DataGridViewRow row in sintacticodgv.Rows)
                {
                    tw.WriteLine($"{row.Cells[0].Value}");
                }
            }
        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiarbtn_Click(object sender, EventArgs e)
        {
            Analizadordgv.Rows.Clear();
            sintacticodgv.Rows.Clear();
            Analizadortxb.Text = "";

        }
    }
}