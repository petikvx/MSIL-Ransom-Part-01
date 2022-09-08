using System;
using Orcus.Shared.Commands.FileExplorer;

namespace Orcus.Commands.FileExplorer;

public class ProcessingEntriesChangedEventArgs : EventArgs
{
	public string FolderPath { get; }

	public ProcessingEntry ProcessingEntry { get; }

	public EntryUpdateMode EntryUpdateMode { get; }

	public ProcessingEntriesChangedEventArgs(string folderPath, ProcessingEntry processingEntry, EntryUpdateMode entryUpdateMode)
	{
		FolderPath = folderPath;
		ProcessingEntry = processingEntry;
		EntryUpdateMode = entryUpdateMode;
	}
}
