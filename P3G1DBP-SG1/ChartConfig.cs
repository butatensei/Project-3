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
    }
}
