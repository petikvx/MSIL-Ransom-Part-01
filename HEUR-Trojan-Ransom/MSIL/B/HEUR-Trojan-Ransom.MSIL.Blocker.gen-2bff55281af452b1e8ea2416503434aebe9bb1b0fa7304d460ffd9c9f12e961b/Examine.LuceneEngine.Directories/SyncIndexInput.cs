#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Threading;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

[SecurityCritical]
internal class SyncIndexInput : IndexInput
{
	private SyncDirectory _syncDirectory;

	private readonly string _name;

	private IndexInput _cacheDirIndexInput;

	private readonly Mutex _fileMutex;

	public Directory CacheDirectory => _syncDirectory.CacheDirectory;

	public Directory MasterDirectory => _syncDirectory.MasterDirectory;

	public SyncIndexInput(SyncDirectory directory, string name)
	{
		if (directory == null)
		{
			throw new ArgumentNullException("directory");
		}
		_name = name;
		_syncDirectory = directory;
		_fileMutex = SyncMutexManager.GrabMutex((Directory)(object)_syncDirectory, _name);
		_fileMutex.WaitOne();
		try
		{
			string name2 = _name;
			bool flag = false;
			if ((!CacheDirectory.FileExists(name2)) ? true : false)
			{
				SyncLocally(name2);
				_cacheDirIndexInput = CacheDirectory.OpenInput(name2);
			}
			else
			{
				_cacheDirIndexInput = CacheDirectory.OpenInput(name2);
			}
		}
		finally
		{
			_fileMutex.ReleaseMutex();
		}
	}

	public SyncIndexInput(SyncIndexInput cloneInput)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		_name = cloneInput._name;
		_syncDirectory = cloneInput._syncDirectory;
		if (string.IsNullOrWhiteSpace(_name))
		{
			throw new ArgumentNullException("_name");
		}
		if (_syncDirectory == null)
		{
			throw new ArgumentNullException("_syncDirectory");
		}
		_fileMutex = SyncMutexManager.GrabMutex((Directory)(object)cloneInput._syncDirectory, cloneInput._name);
		_fileMutex.WaitOne();
		try
		{
			_cacheDirIndexInput = (IndexInput)cloneInput._cacheDirIndexInput.Clone();
		}
		catch (Exception)
		{
			Trace.TraceError($"Dagnabbit, falling back to memory clone for {cloneInput._name}");
		}
		finally
		{
			_fileMutex.ReleaseMutex();
		}
	}

	private void SyncLocally(string fileName)
	{
		IndexInput val = null;
		try
		{
			val = MasterDirectory.OpenInput(fileName);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		if (val == null)
		{
			return;
		}
		IndexOutput val2 = null;
		try
		{
			val2 = CacheDirectory.CreateOutput(fileName);
			val.CopyTo(val2, fileName);
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

	private bool CompareExistingFileAttributes(string fileName)
	{
		long num = CacheDirectory.FileLength(fileName);
		long num2 = MasterDirectory.FileLength(fileName);
		if (num != num2)
		{
			return true;
		}
		long num3 = CacheDirectory.FileModified(fileName);
		long num4 = MasterDirectory.FileModified(fileName);
		DateTime dateTime = new DateTime(Convert.ToInt32(1961.003760478205 - Math.Tan(985.0)), 1, 1, 0, 0, 0, DateTimeKind.Utc);
		DateTime dateTime2 = dateTime.AddMilliseconds(num3).ToUniversalTime();
		DateTime dateTime3 = dateTime.AddMilliseconds(num4).ToUniversalTime();
		if (dateTime2 != dateTime3 && dateTime3.Subtract(dateTime2).TotalSeconds > 2.0)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	public override byte ReadByte()
	{
		return _cacheDirIndexInput.ReadByte();
	}

	[SecurityCritical]
	public override void ReadBytes(byte[] b, int offset, int len)
	{
		_cacheDirIndexInput.ReadBytes(b, offset, len);
	}

	[SecurityCritical]
	public override long GetFilePointer()
	{
		return _cacheDirIndexInput.GetFilePointer();
	}

	[SecurityCritical]
	public override void Seek(long pos)
	{
		_cacheDirIndexInput.Seek(pos);
	}

	[SecurityCritical]
	public override void Close()
	{
		_fileMutex.WaitOne();
		try
		{
			_cacheDirIndexInput.Close();
			_cacheDirIndexInput = null;
			_syncDirectory = null;
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
		return _cacheDirIndexInput.Length();
	}

	[SecuritySafeCritical]
	public override object Clone()
	{
		IndexInput result = null;
		try
		{
			_fileMutex.WaitOne();
			result = (IndexInput)(object)new SyncIndexInput(this);
			return result;
		}
		catch (Exception ex)
		{
			Trace.TraceError(ex.ToString());
			return result;
		}
		finally
		{
			_fileMutex.ReleaseMutex();
		}
	}
}
