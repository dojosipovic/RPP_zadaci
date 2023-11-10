namespace PametnaKuca2
{
    public abstract class Sensor
    {
        public int ID { get; set; }
        public virtual string Unit { get; set; }

        public Sensor(int id, string unit)
        {
            ID = id;
            Unit = unit;
        }

        public abstract double GetValue();
    }
}