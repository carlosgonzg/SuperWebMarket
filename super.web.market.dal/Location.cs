namespace super.web.market.dal
{
    public class Location
    {
        private float _latitude;
        private float _longitude;

        //constructor Location
        public Location(float latitude = 0, float longitude = 0)
        {
            this._latitude = latitude;
            this._longitude = longitude;
        }

        //property Latitude
        public float Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        //property Longitude
        public float Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
    }
}