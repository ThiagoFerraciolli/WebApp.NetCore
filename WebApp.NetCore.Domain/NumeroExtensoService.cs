using System;

namespace WebApp.NetCore.Domain
{
    public class NumeroExtensoService : INumeroExtensoService
    {
        public NumeroExtenso Validar(int valor)
        {
            string valorAux = valor.ToString("000000");
            string resultado = null;
            if (valorAux[0].Equals('-'))
            {
                resultado = "menos ";
                valorAux = valorAux.Substring(1, valorAux.Length - 1);
            }
            if (valor == 0)
                return new NumeroExtenso() { Extenso = "zero" };
            for (int i = 0; i < valorAux.Length; i += 3)
            {
                if (Convert.ToInt32(valorAux.Substring(i, i + 3 > valorAux.Length - 1 ? 3 : i + 3)) > 0)
                {
                    if ((i == 0 & Convert.ToInt32(valorAux.Substring(i, i + 3 > valorAux.Length - 1 ? 3 : i + 3)) > 1) | i > 0)
                        resultado += RetornarExtenso(Convert.ToInt32(valorAux.Substring(i, i + 3 > valorAux.Length - 1 ? 3 : i + 3)));
                    if (Convert.ToInt32(valorAux) > 999 & i == 0)
                    {
                        resultado += " mil e ";
                    }
                }
            }

            NumeroExtenso numeroExtenso = new NumeroExtenso()
            {
                Extenso = resultado
            };
            return numeroExtenso;
        }

        private string RetornarExtenso(int valor)
        {
            string resultado = null;
            string ValorAux = valor.ToString("000");
            int a = Convert.ToInt32(ValorAux.Substring(0, 1));
            int b = Convert.ToInt32(ValorAux.Substring(1, 1));
            int c = Convert.ToInt32(ValorAux.Substring(2, 1));
            if (a > 0)
            {
                switch (a)
                {
                    case 1:
                        resultado = (b + c == 0) ? "cem" : "cento";
                        break;
                    case 2:
                        resultado = "duzentos";
                        break;
                    case 3:
                        resultado = "trezentos";
                        break;
                    case 4:
                        resultado = "quatrocentos";
                        break;
                    case 5:
                        resultado = "quinhentos";
                        break;
                    case 6:
                        resultado = "seiscentos";
                        break;
                    case 7:
                        resultado = "setecentos";
                        break;
                    case 8:
                        resultado = "oitocentos";
                        break;
                    case 9:
                        resultado = "novecentos";
                        break;
                }
            }
            if (b > 0)
            {
                if (b == 1)
                {
                    if (a > 0)
                        resultado += " e ";
                    switch (c)
                    {
                        case 0:
                            resultado += "dez";
                            break;
                        case 1:
                            resultado += "onze";
                            break;
                        case 2:
                            resultado += "doze";
                            break;
                        case 3:
                            resultado += "treze";
                            break;
                        case 4:
                            resultado += "quatorze";
                            break;
                        case 5:
                            resultado += "quinze";
                            break;
                        case 6:
                            resultado += "dezesseis";
                            break;
                        case 7:
                            resultado += "dezessete";
                            break;
                        case 8:
                            resultado += "dezoito";
                            break;
                        case 9:
                            resultado += "dezenove";
                            break;
                    }
                }
                else
                {
                    if (a > 0)
                        resultado += " e ";
                    switch (b)
                    {
                        case 2:
                            resultado += "vinte";
                            break;
                        case 3:
                            resultado += "trinta";
                            break;
                        case 4:
                            resultado += "quarenta";
                            break;
                        case 5:
                            resultado += "cinquenta";
                            break;
                        case 6:
                            resultado += "sessenta";
                            break;
                        case 7:
                            resultado += "setenta";
                            break;
                        case 8:
                            resultado += "oitenta";
                            break;
                        case 9:
                            resultado += "noventa";
                            break;
                    }
                }
            }
            if (c > 0 & (b > 1 | b == 0))
            {
                if (!String.IsNullOrEmpty(resultado))
                    resultado += " e ";
                switch (c)
                {
                    case 1:
                        resultado += "um";
                        break;
                    case 2:
                        resultado += "dois";
                        break;
                    case 3:
                        resultado += "três";
                        break;
                    case 4:
                        resultado += "quatro";
                        break;
                    case 5:
                        resultado += "cinco";
                        break;
                    case 6:
                        resultado += "seis";
                        break;
                    case 7:
                        resultado += "sete";
                        break;
                    case 8:
                        resultado += "oito";
                        break;
                    case 9:
                        resultado += "nove";
                        break;
                }
            }
            return resultado;
        }
    }
}
