using System;

namespace TierTypeTallier.FileTallying
{
    /// <summary>
    /// Represents a file type counter, intended to assess the file composition of a directory.
    /// </summary>
    internal partial class FileTallier : IDisposable
    {
        private readonly FileTypeTallierWorker worker = new FileTypeTallierWorker();

        /// <summary>
        /// Occurs when the tallier has completed (includes after cancellation).
        /// </summary>
        public event EventHandler<FileTallierResults> TallierCompleted = delegate { };

        /// <summary>
        /// Occurs when progress has been reported by the internal worker
        /// </summary>
        public event EventHandler<int> ProgressReport = delegate { };

        /// <summary>
        /// Initializes a new instance of <see cref="FileTallier"/>.
        /// </summary>
        public FileTallier()
        {
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            worker.ProgressChanged += (sender, args) =>
                ProgressReport(this, (int) args.UserState);

            worker.RunWorkerCompleted += (sender, args) =>
                TallierCompleted(this, (FileTallierResults)args.Result);
        }

        /// <summary>
        /// Runs the tallier asynchronously.
        /// </summary>
        /// <param name="dir">The directory to tally up.</param>
        /// <param name="reportFreq">How many files to iterate before reporting progress.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RunAsync(string dir, int reportFreq)
        {
            if (reportFreq < 1)
                throw new ArgumentOutOfRangeException(nameof(reportFreq));

            RunAsync(new FileTallierParams(dir, reportFreq));
        }

        /// <summary>
        /// Runs the tallier asynchronously.
        /// </summary>
        /// <param name="p">Specifies the desired behavior for the tallier.</param>
        public void RunAsync(FileTallierParams p)
        {
            worker.RunWorkerAsync(p);
        }

        /// <summary>
        /// Cancels the running asynchronous operation
        /// </summary>
        public void CancelAsync()
        {
            worker.CancelAsync();
        }

        public void Dispose()
        {
            worker.Dispose();
        }
    }
}
