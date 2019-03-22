namespace _8._3._1_nasljedivanje
{
    internal class Pilot : Vozac
    {
        public bool Kategorija_x { get; internal set; }

        public override string ToString()
        {
            if (this.Kategorija_x)
            {
                return base.ToString() + "X";
            }
            else
            {
                return base.ToString();
            }

        }
    }
}