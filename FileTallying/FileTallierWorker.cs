using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace TierTypeTallier.FileTallying
{
    // This partial, is intended only for the private worker definition.
    partial class FileTallier
    {
        /// <summary>
        /// Represents the core functionality of the containing FileTallier.
        /// </summary>
        private class FileTypeTallierWorker : BackgroundWorker
        {
            private readonly List<FileTally> tallies = new List<FileTally>();
            private int filesIterated, dirsIterated, reportProgressFreq, reportTracker, errorCount;

            protected override void OnDoWork(DoWorkEventArgs e)
            {
                Reset();
                var p = (FileTallierParams)e.Argument;
                reportProgressFreq = p.ReportFrequency;
                StackTraverseDirectory(p.Directory);

                e.Result = new FileTallierResults(tallies.ToArray(), filesIterated,
                    dirsIterated, errorCount, CancellationPending);
            }

            /// <summary>
            /// Resets the data for this instance so it can be reused.
            /// </summary>
            private void Reset()
            {
                tallies.Clear();
                filesIterated = 0;
                dirsIterated = 0;
                reportTracker = 0;
                errorCount = 0;
            }

            // I found stack based traversal with the static enumerate methods to be the most efficient.

            /// <summary>
            /// Walk a directory tree with stack based traversal.
            /// </summary>
            /// <param name="root">The top-level directory to start at.</param>
            private void StackTraverseDirectory(string root)
            {
                var dirs = new Stack<string>(20);
                dirs.Push(root);

                while (dirs.Count > 0)
                {
                    string currentDir = dirs.Pop();
                    IEnumerable<string> subDirs, fileNames;
                    dirsIterated++;

                    try
                    {
                        subDirs = Directory.EnumerateDirectories(currentDir);
                        fileNames = Directory.EnumerateFiles(currentDir);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        errorCount++;
                        continue;
                    }

                    foreach (string fileName in fileNames)
                    {
                        // Check for cancellation every file iteration
                        if (WorkerSupportsCancellation && CancellationPending) return;
                        filesIterated++;

                        // Progress reporting
                        if (WorkerReportsProgress)
                        {
                            if (reportTracker == reportProgressFreq)
                            {
                                reportTracker = 0;
                                ReportProgress(0, filesIterated);
                            }
                            else reportTracker++;
                        }

                        // Tallying
                        string ext = Path.GetExtension(fileName).ToLower();
                        var tally = tallies.Find(t => t.Extension == ext); // returns null if not found?

                        if (tally == null)
                        {
                            tallies.Add(new FileTally(ext));
                        }
                        else
                        {
                            FileTally.Increment(tally);
                        }
                    }

                    foreach (string dir in subDirs)
                        dirs.Push(dir);
                }
            }
        }
    }
}
