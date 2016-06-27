namespace TierTypeTallier.FileTallying
{
    /// <summary>
    /// Represents results for the completion of the FileTallier async operation.
    /// </summary>
    public class FileTallierResults
    {
        #region Properties
        /// <summary>
        /// Gets the FileTally's accumulated.
        /// </summary>
        public FileTally[] Tallies { get; private set; }

        /// <summary>
        /// Gets how many files were iterated.
        /// </summary>
        public int FilesIterated { get; private set; }

        /// <summary>
        /// Gets how many directories were iterated.
        /// </summary>
        public int DirectoriesIterated { get; private set; }

        /// <summary>
        /// Gets how many directories could not be iterated through 
        /// (does not include sub-directories).
        /// </summary>
        public int ErrorCount { get; private set; }

        /// <summary>
        /// Gets the statistics calculated for the file tallies.
        /// </summary>
        public FileTallyStatistics Statistics { get; private set; }

        /// <summary>
        /// Gets whether the operation has been canceled.
        /// </summary>
        public bool Cancelled { get; private set; }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="FileTallierResults"/> class
        /// with the specified arguments.
        /// </summary>
        /// <param name="tallies">The FileTally's accumulated.</param>
        /// <param name="filesIterated">How many files were iterated.</param>
        /// <param name="dirsIterated">How many directories were iterated.</param>
        /// <param name="errorCount">How many directories could not be iterated through.</param>
        /// <param name="cancelled">Whether the operation has been canceled.</param>
        public FileTallierResults(FileTally[] tallies, int filesIterated, int dirsIterated, int errorCount, bool cancelled)
        {
            Tallies = tallies;
            FilesIterated = filesIterated;
            DirectoriesIterated = dirsIterated;
            ErrorCount = errorCount;
            Statistics = new FileTallyStatistics(tallies);
            Cancelled = cancelled;
        }
    }
}
