using System;

namespace TierTypeTallier.FileTallying
{
    /// <summary>
    /// Represents a file type counter, intended to assess the file composition of a directory
    /// </summary>
    partial class FileTallier : IDisposable
    {
        private readonly FileTypeTallierWorker _worker = new FileTypeTallierWorker();

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
            _worker.WorkerSupportsCancellation = true;
            _worker.WorkerReportsProgress = true;

            _worker.ProgressChanged += (sender, args) =>
                ProgressReport(this, (int) args.UserState);

            _worker.RunWorkerCompleted += (sender, args) =>
                TallierCompleted(this, (FileTallierResults)args.Result);
        }

        /// <summary>
        /// Runs the tallier asyncronously
        /// </summary>
        /// <param name="dir">The directory to tally up</param>
        /// <param name="reportFreq">How many files to iterate before reporting progress</param>
        public void RunAsync(string dir, int reportFreq)
        {
            if (reportFreq < 1)
                throw new ArgumentOutOfRangeException("reportFreq");

            RunAsync(new FileTallierParams(dir, reportFreq));
        }

        /// <summary>
        /// Runs the tallier asyncronously.
        /// </summary>
        /// <param name="p">Specifies the desired behavior for the tallier.</param>
        public void RunAsync(FileTallierParams p)
        {
            _worker.RunWorkerAsync(p);
        }

        /// <summary>
        /// Cancels the running asyncronous operation
        /// </summary>
        public void CancelAsync()
        {
            _worker.CancelAsync();
        }

        public void Dispose()
        {
            _worker.Dispose();
        }
    }
}
