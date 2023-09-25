namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            var cells = line.Split(',');
            logger.LogWarning("Less than three items. Incomplete data.");

            if (cells.Length < 3)
            {
                logger.LogWarning("Less than three items. Incomplete data.");  
                return null; // TODO Implement
            }

            var latitude = double.Parse(cells[0]);
           
            var longitude = double.Parse(cells[1]);
          
            var name = cells[2];
            // DONE0-Your going to need to parse your string as a `double`
            // DONEO-which is similar to parsing a string as an `int`

            // DONEO-You'll need to create a TacoBell class
            // DONE0-that conforms to ITrackable
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;
            // DONEO-Then, you'll need an instance of the TacoBell class
            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;
            
            // DONEO-With the name and point set correctly

            // DONEO-Then, return the instance of your TacoBell class
            // DONEO-Since it conforms to ITrackable

            return tacoBell;
        }
    }
}