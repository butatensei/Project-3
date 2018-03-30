using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3Groep1
{
    /// <summary>
    /// Class that holds all the variables needed for visualization.
    /// </summary>
    class ChartConfig
    {
        /// <summary>
        /// boolean -- Which subgroup's data we are displaying; fietsendiefstal (false) or straatroof (true).
        /// </summary>
        public bool SubGroupData;
        /// <summary>
        /// integer, 0-12 -- Which time scale we display; whole year (0) or specific months (1-12).
        /// </summary>
        public int TimeMode;
        /// <summary>
        /// integer, 0-2 -- How we are displaying precipitation (show, highlight,filter out) -- master variable for the other two weather-related variables.
        /// </summary>
        public int PrecipitationMode;
        /// <summary>
        /// integer, 0-2 -- How we display rain (show, highlight, filter out).
        /// </summary>
        public int RainMode;
        /// <summary>
        /// integer, 0-2 -- How we display snow (show, highlight, filter out).
        /// </summary>
        public int SnowMode;

        /// <summary>
        /// integer, 0-2 -- How we are displaying sunny weather (aka not precipitation) (show, highlight,filter out)
        /// </summary>
        public int SunMode;

        /// <summary>
        /// constructor for chart config.
        /// </summary>
        public ChartConfig()
        {
            Initialize();
        }
        private bool Initialize()
        {
            SubGroupData = false;
            TimeMode = 0;
            PrecipitationMode = 0;
            RainMode = 0;
            SnowMode = 0;
            return true;
        }

        public string BuildQuery()
        {
            string returnQuery = "";
            string myTableUsed = "";
            string myPrecipitation = "";
            string myRain = "";
            string myFrost = "";
            string myTimeFrame = "";
            if (SubGroupData)
            {
                myTableUsed = "fietsendiefstal";
            }
            else
            {
                myTableUsed = "straatroof";
            }
            if (SunMode == 2 && PrecipitationMode == 2)
            {
                myPrecipitation = myPrecipitation + "and (Neerslag = -2) ";
            }
            else 
                if (SunMode == 2)
                {
                    myPrecipitation = myPrecipitation + "and (Regen = 1 or Sneeuw = 1) ";
                }
            if (PrecipitationMode != 2)
            {
                if (SnowMode == 2)
                {
                    myFrost = "and Sneeuw = 0 ";
                }
                if (RainMode == 2)
                {
                    myRain = "and Regen = 0 ";
                }
            }
            if (PrecipitationMode == 2)
            { myPrecipitation = myPrecipitation + "and Sneeuw = 0 and Regen = 0 "; }
            if (TimeMode != 0)
            {
                myTimeFrame = "and weer.Maand = " + Convert.ToString(TimeMode);
            }
            returnQuery =
                    "Select count(ID), Temperatuur, Neerslag, Regen, Sneeuw " +
                    "From " + myTableUsed + ", weer " +
                    "Where " + myTableUsed + ".Dag = weer.Dag and "
                    + myTableUsed + ".Maand = weer.Maand and "
                     + myTableUsed + ".Jaar = weer.Jaar and " + myTableUsed + 
                     ".Tijd = weer.Tijd and " + myTableUsed + ".Jaar = 2011 "
                    + myTimeFrame + myPrecipitation + myRain + myFrost +
                    "Group by Temperatuur;";

            return returnQuery;
        }
    }
}
