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
        bool SubGroupData = false;
        /// <summary>
        /// integer, 0-12 -- Which time scale we display; whole year (0) or specific months (1-12).
        /// </summary>
        int TimeMode = 0;
        /// <summary>
        /// integer, 0-2 -- How we are displaying precipitation (show, highlight,filter out) -- master variable for the other two weather-related variables.
        /// </summary>
        int PrecipitationMode = 0;
        /// <summary>
        /// integer, 0-2 -- How we display rain (show, highlight, filter out).
        /// </summary>
        int RainMode = 0;
        /// <summary>
        /// integer, 0-2 -- How we display snow (show, highlight, filter out).
        /// </summary>
        int SnowMode = 0;
    }
}
