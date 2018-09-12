namespace Oblig1_ELE107
{
    interface ISensor
    {
        double PosisonX
        {
            get;
            set;
        }

        double PosisonY
        {
            get;
            set;
        }

        void Maal();
        string ToString();
    }
}