using System;
using System.IO;
using System.Security;
using System.Threading;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

[SecurityCritical]
internal class SyncIndexOutput : IndexOutput
{
	private readonly SyncDirectory _syncDirectory;

	private readonly string _name;

	private IndexOutput _cacheDirIndexOutput;

	private readonly Mutex _fileMutex;

	public Directory CacheDirectory => _syncDirectory.CacheDirectory;

	public Directory MasterDirectory => _syncDirectory.MasterDirectory;

	public SyncIndexOutput(SyncDirectory syncDirectory, string name)
	{
		if (syncDirectory == null)
		{
			throw new ArgumentNullException("syncDirectory");
		}
		_name = name;
		_syncDirectory = syncDirectory;
		_fileMutex = SyncMutexManager.GrabMutex((Directory)(object)_syncDirectory, _name);
		_fileMutex.WaitOne();
		try
		{
			_cacheDirIndexOutput = CacheDirectory.CreateOutput(_name);
		}
		finally
		{
			_fileMutex.ReleaseMutex();
		}
	}

	[SecurityCritical]
	public override void Flush()
	{
		_cacheDirIndexOutput.Flush();
	}

	[SecurityCritical]
	public override void Close()
	{
		_fileMutex.WaitOne();
		try
		{
			string name = _name;
			if (_cacheDirIndexOutput != null)
			{
				_cacheDirIndexOutput.Flush();
				_cacheDirIndexOutput.Close();
				IndexInput val = null;
				try
				{
					val = CacheDirectory.OpenInput(name);
				}
				catch (IOException)
				{
					throw;
				}
				if (val != null)
				{
					IndexOutput val2 = null;
					try
					{
						val2 = MasterDirectory.CreateOutput(name);
						val.CopyTo(val2, name);
					}
					finally
					{
						if (val2 != null)
						{
							val2.Close();
						}
						if (val != null)
						{
							val.Close();
						}
					}
				}
				_cacheDirIndexOutput = null;
			}
			GC.SuppressFinalize(this);
		}
		finally
		{
			_fileMutex.ReleaseMutex();
		}
	}

	[SecurityCritical]
	public override long Length()
	{
		return _cacheDirIndexOutput.Length();
	}

	[SecurityCritical]
	public override void WriteByte(byte b)
	{
		_cacheDirIndexOutput.WriteByte(b);
	}

	[SecurityCritical]
	public override void WriteBytes(byte[] b, int length)
	{
		_cacheDirIndexOutput.WriteBytes(b, length);
	}

	[SecurityCritical]
	public override void WriteBytes(byte[] b, int offset, int length)
	{
		_cacheDirIndexOutput.WriteBytes(b, offset, length);
	}

	[SecurityCritical]
	public override long GetFilePointer()
	{
		return _cacheDirIndexOutput.GetFilePointer();
	}

	[SecurityCritical]
	public override void Seek(long pos)
	{
		_cacheDirIndexOutput.Seek(pos);
	}
}
