namespace TierTypeTallier.FileTallying
{
    /// <summary>
    /// Represents a tally of a specific file-type
    /// </summary>
    public class FileTally
    {
        /// <summary>
        /// Gets or sets the count of the file-type
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets or sets the extension for the file-type
        /// </summary>
        public string Extension { get; private set; }

        /// <summary>
        /// Initializes a new instance of the FileTally type and sets the count to 1.
        /// </summary>
        /// <param name="extension">The extension of the file-type to be tallied</param>
        public FileTally(string extension)
        {
            Extension = extension;
            Count = 1;
        }

        public static void Increment(FileTally tally)
        {
            tally.Count++;
        }
    }
}
