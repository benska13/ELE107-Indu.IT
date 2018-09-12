using System;

namespace Oblig1_ELE107
{
    interface ISensor
    {
        double PosisjonX
        {
            get;
            set;
        }

        double PosisjonY
        {
            get;
            set;
        }

        void Maal(Random random);
        string ToString();
    }
}