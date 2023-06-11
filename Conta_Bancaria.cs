using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta_Bancaria
    {
        private string _titular;
        public int Codigo { get; private set; }
        public double Saldo { get; private set; }

        public Conta_Bancaria(int codigo, string titular)
        {
            Codigo = codigo;
            _titular = titular;
        }

        public Conta_Bancaria(int codigo, string titular, double saldo):this(codigo, titular) {
            Saldo = saldo;
        }

        public string Nome {
            get { return _titular; }
            set { if (value != null && value.Length > 0) {
                    _titular = value;
                } 
            }
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Codigo
                + ", Titular: "
                + _titular  
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
