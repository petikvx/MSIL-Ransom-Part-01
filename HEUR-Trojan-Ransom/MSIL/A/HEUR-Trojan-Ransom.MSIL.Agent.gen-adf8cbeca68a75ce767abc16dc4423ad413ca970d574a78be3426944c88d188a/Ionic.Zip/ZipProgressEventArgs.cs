using System;

namespace Ionic.Zip;

public class ZipProgressEventArgs : EventArgs
{
	private int _entriesTotal;

	private bool _cancel;

	private ZipEntry _latestEntry;

	private ZipProgressEventType _flavor;

	private string _archiveName;

	private long _bytesTransferred;

	private long _totalBytesToTransfer;

	public int EntriesTotal
	{
		get
		{
			return _entriesTotal;
		}
		set
		{
			_entriesTotal = value;
		}
	}

	public ZipEntry CurrentEntry
	{
		get
		{
			return _latestEntry;
		}
		set
		{
			_latestEntry = value;
		}
	}

	public bool Cancel
	{
		get
		{
			return _cancel;
		}
		set
		{
			_cancel |= value;
		}
	}

	public ZipProgressEventType EventType
	{
		get
		{
			return _flavor;
		}
		set
		{
			_flavor = value;
		}
	}

	public string ArchiveName
	{
		get
		{
			return _archiveName;
		}
		set
		{
			_archiveName = value;
		}
	}

	public long BytesTransferred
	{
		get
		{
			return _bytesTransferred;
		}
		set
		{
			_bytesTransferred = value;
		}
	}

	public long TotalBytesToTransfer
	{
		get
		{
			return _totalBytesToTransfer;
		}
		set
		{
			_totalBytesToTransfer = value;
		}
	}

	internal ZipProgressEventArgs()
	{
	}

	internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor)
	{
		_archiveName = archiveName;
		_flavor = flavor;
	}
}
