using System;
using System.Linq;

namespace TierTypeTallier.FileTallying
{
    /// <summary>
    /// Represents statistics for an array of <see cref="FileTally"/>.
    /// </summary>
    public class FileTallyStatistics
    {
        private readonly FileTally[] tallies;

        #region Properties
        /// <summary>
        /// Gets the longest extension among the FileTallys.
        /// </summary>
        public string LongestExtension
        {
            get
            {
                string longest = string.Empty;
                foreach (var tally in tallies)
                {
                    if (tally.Extension.Length > longest.Length)
                        longest = tally.Extension;
                }
                return longest;
            }
        }

        /// <summary>
        /// Gets the FileTally with the highest file count.
        /// </summary>
        public FileTally HighestQuantity
        {
            get
            {
                FileTally highest = null;

                foreach (var tally in tallies)
                {
                    if (highest == null || tally.Count > highest.Count)
                        highest = tally;
                }
                return highest;
            }
        }

        /// <summary>
        /// Gets the average quantity.
        /// </summary>
        public int MeanQuantity
        {
            get { return tallies.Sum(t => t.Count) / tallies.Length; }
        }

        /// <summary>
        /// Gets the total amount of compressed/packaged files.
        /// </summary>
        public int CompressedFileCount
        {
            get
            {
                const string COMPRESSED_EXT =
                    "arc .ace .arj .as .b64 .btoa .bz .cab .cpt .gz .hqx .iso .lha .lzh .mim .mme "
                    +".pak .pf .rar .sea .sit .sitx .targz .tbz .tbz2 .tgz .uu .uue .z .zip .zoo";
                string[] extensions = COMPRESSED_EXT.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                return tallies.Count(tally => extensions.Any(t => tally.Extension == t));
            }
        }

        /// <summary>
        /// Gets the files that have no extension.
        /// </summary>
        public int NoExtensionCount
        {
            get
            {
                var tally = tallies.FirstOrDefault(t => t.Extension.Length == 0);
                return tally == null ? 0 : tally.Count;
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of <see cref="FileTallyStatistics"/> 
        /// with the specified argument.
        /// </summary>
        /// <param name="tallies">The tallies to generate statistics for.</param>
        public FileTallyStatistics(FileTally[] tallies)
        {
            this.tallies = tallies;
        }

        /// <summary>
        /// Gets a quantitative percent, of the tally specified in relation to the other.
        /// </summary>
        public double GetPercent(FileTally tally)
        {
            return (double)tally.Count / tallies.Sum(t => t.Count) * 100;
        }
    }
}