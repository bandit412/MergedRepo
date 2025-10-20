namespace RailYardClasses
{
    public class RailYard
    {
        private List<Train> _Trains;

        internal List<Train> Trains
        {
            get { return _Trains; }
            set { _Trains = value; }
        }

        #region "Constructors"
        public RailYard() { }

        public RailYard(List<Train> trains)
        {
            Trains = trains;
        }
        #endregion
    }
}
