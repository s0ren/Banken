using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    public class Konto
    {
        public Konto(double startSaldo)
        {
            saldo = startSaldo;
        }

        public double saldo { get; private set; }

        public void Indsæt(double beløb)
        {
            this.saldo += beløb;
        }

        public void Hæv(double beløb)
        {
            if (saldo >= beløb)
            {
                saldo -= beløb;
            }
        }

    }

    public class Forbrugslån : Konto
    {
        public Forbrugslån(double saldo) : base(saldo)
        {

        }
    }
}
