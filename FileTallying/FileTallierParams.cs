using System.Text;

namespace TierTypeTallier.FileTallying
{
    /// <summary>
    /// Represents parameters for the FileTallier
    /// </summary>
    public class FileTallierParams
    {
        /// <summary>
        /// Gets the directory to begin the tally.
        /// </summary>
        public string Directory { get; private set; }

        /// <summary>
        /// Gets the desired progress report frequency.
        /// </summary>
        public int ReportFrequency { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileTallierParams"/> class
        /// with the specified arguments.
        /// </summary>
        /// <param name="dir">The directory to begin the tally.</param>
        /// <param name="reportFreq">The desired progress report frequency.</param>
        public FileTallierParams(string dir, int reportFreq)
        {
            Directory = dir;
            ReportFrequency = reportFreq;
        }
    }
}
