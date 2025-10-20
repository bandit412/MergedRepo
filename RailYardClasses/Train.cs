using RailYardClasses.AbstractClasses;

namespace RailYardClasses
{
    public class Train
    {
        private List<AbstractTrainCar> _Cars;

        internal List<AbstractTrainCar> Cars
        {
            get { return _Cars; }
            set { _Cars = value; }
        }

        #region "Constructors"
        public Train() { }

        public Train(List<AbstractTrainCar> cars)
        {
            Cars = cars;
        }
        #endregion
    }
}