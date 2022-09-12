using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public sealed class CopyMoveResult
{
	[NonSerialized]
	internal readonly Stopwatch _stopwatch;

	public TimeSpan Duration => TimeSpan.FromMilliseconds(_stopwatch.Elapsed.TotalMilliseconds);

	public string Destination { get; private set; }

	public int ErrorCode { get; internal set; }

	[SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
	public string ErrorMessage => new Win32Exception(ErrorCode).Message;

	public bool IsCanceled { get; internal set; }

	public bool IsCopy { get; private set; }

	public bool IsDirectory { get; private set; }

	public bool IsEmulatedMove { get; private set; }

	public bool IsFile => !IsDirectory;

	public bool IsMove => !IsCopy;

	public string Source { get; private set; }

	public bool TimestampsCopied { get; private set; }

	public long TotalBytes { get; internal set; }

	public string TotalBytesUnitSize => Utils.UnitSizeToText(TotalBytes);

	public long TotalFiles { get; internal set; }

	public long TotalFolders { get; internal set; }

	private CopyMoveResult(string source, string destination)
	{
		Source = source;
		Destination = destination;
		IsCopy = true;
		_stopwatch = Stopwatch.StartNew();
	}

	public CopyMoveResult(string source, string destination, bool isCopy, bool isFolder, bool preserveDates, bool emulatedMove)
		: this(source, destination)
	{
		IsEmulatedMove = emulatedMove;
		IsCopy = isCopy;
		IsDirectory = isFolder;
		TimestampsCopied = preserveDates;
	}
}
