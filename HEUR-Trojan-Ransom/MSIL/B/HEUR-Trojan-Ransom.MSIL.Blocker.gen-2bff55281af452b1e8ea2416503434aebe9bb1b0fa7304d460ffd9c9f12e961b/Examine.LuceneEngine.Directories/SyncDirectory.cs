#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security;
using Lucene.Net.Index;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

[SecurityCritical]
public class SyncDirectory : Directory
{
	private readonly Directory _masterDirectory;

	private readonly Directory _cacheDirectory;

	private readonly MultiIndexLockFactory _lockFactory;

	private volatile bool _dirty = true;

	private bool _inSync;

	private readonly object _locker = new object();

	internal static readonly HashSet<string> RemoteOnlyFiles = new HashSet<string> { "segments.gen" };

	public Directory CacheDirectory => _cacheDirectory;

	public Directory MasterDirectory => _masterDirectory;

	public SyncDirectory(Directory masterDirectory, Directory cacheDirectory)
	{
		if (masterDirectory == null)
		{
			throw new ArgumentNullException("masterDirectory");
		}
		if (cacheDirectory == null)
		{
			throw new ArgumentNullException("cacheDirectory");
		}
		_masterDirectory = masterDirectory;
		_cacheDirectory = cacheDirectory;
		_lockFactory = new MultiIndexLockFactory(_masterDirectory, _cacheDirectory);
	}

	public void ClearCache()
	{
		string[] array = _cacheDirectory.ListAll();
		foreach (string text in array)
		{
			_cacheDirectory.DeleteFile(text);
		}
	}

	[SecurityCritical]
	[Obsolete("For some Directory implementations (FSDirectory}, and its subclasses), this method silently filters its results to include only index files.  Please use ListAll instead, which does no filtering. ")]
	public override string[] List()
	{
		return ((Directory)this).ListAll();
	}

	[SecurityCritical]
	public override string[] ListAll()
	{
		CheckDirty();
		if (!_inSync)
		{
			return _masterDirectory.ListAll();
		}
		return _cacheDirectory.ListAll();
	}

	[SecurityCritical]
	public override bool FileExists(string name)
	{
		CheckDirty();
		if (_inSync)
		{
			if (!_cacheDirectory.FileExists(name))
			{
				return _masterDirectory.FileExists(name);
			}
			return true;
		}
		return _masterDirectory.FileExists(name);
	}

	[SecurityCritical]
	public override long FileModified(string name)
	{
		CheckDirty();
		if (!_inSync)
		{
			return _masterDirectory.FileModified(name);
		}
		return _cacheDirectory.FileModified(name);
	}

	[Obsolete("This is actually never used")]
	[SecurityCritical]
	public override void TouchFile(string name)
	{
		_cacheDirectory.TouchFile(name);
		SetDirty();
	}

	[SecurityCritical]
	public override void DeleteFile(string name)
	{
		try
		{
			if (_cacheDirectory.FileExists(name))
			{
				_cacheDirectory.DeleteFile(name);
				SetDirty();
			}
		}
		catch (IOException)
		{
			throw;
		}
		_masterDirectory.DeleteFile(name);
		SetDirty();
	}

	[Obsolete("This is actually never used")]
	[SecurityCritical]
	public override void RenameFile(string from, string to)
	{
		try
		{
			_masterDirectory.RenameFile(from, to);
			SetDirty();
		}
		catch (Exception ex)
		{
			Trace.TraceError("Could not rename file on master index; " + ex);
		}
		try
		{
			if (_cacheDirectory.FileExists(from))
			{
				_cacheDirectory.RenameFile(from, to);
				SetDirty();
			}
		}
		catch (Exception ex2)
		{
			Trace.TraceError("Could not rename file on local index; " + ex2);
		}
	}

	[SecurityCritical]
	public override long FileLength(string name)
	{
		CheckDirty();
		if (!_inSync)
		{
			return _masterDirectory.FileLength(name);
		}
		return _cacheDirectory.FileLength(name);
	}

	[SecurityCritical]
	public override IndexOutput CreateOutput(string name)
	{
		SetDirty();
		return (IndexOutput)(object)new SyncIndexOutput(this, name);
	}

	[SecurityCritical]
	public override IndexInput OpenInput(string name)
	{
		if (RemoteOnlyFiles.Contains(name))
		{
			return _masterDirectory.OpenInput(name);
		}
		try
		{
			return (IndexInput)(object)new SyncIndexInput(this, name);
		}
		catch (Exception innerException)
		{
			throw new FileNotFoundException(name, innerException);
		}
	}

	[SecurityCritical]
	public override Lock MakeLock(string name)
	{
		return ((LockFactory)_lockFactory).MakeLock(name);
	}

	[SecurityCritical]
	public override void ClearLock(string name)
	{
		((LockFactory)_lockFactory).ClearLock(name);
	}

	[SecurityCritical]
	public override LockFactory GetLockFactory()
	{
		return (LockFactory)(object)_lockFactory;
	}

	[SecurityCritical]
	public override string GetLockID()
	{
		return _masterDirectory.GetLockID() + _cacheDirectory.GetLockID();
	}

	[SecurityCritical]
	public override void Close()
	{
		_masterDirectory.Close();
		_cacheDirectory.Close();
	}

	[SecuritySafeCritical]
	public override void Dispose()
	{
		((Directory)this).Close();
	}

	internal StreamInput OpenCachedInputAsStream(string name)
	{
		return new StreamInput(CacheDirectory.OpenInput(name));
	}

	internal StreamOutput CreateCachedOutputAsStream(string name)
	{
		return new StreamOutput(CacheDirectory.CreateOutput(name));
	}

	private void CheckDirty()
	{
		if (!_dirty)
		{
			return;
		}
		lock (_locker)
		{
			if (_dirty)
			{
				long currentSegmentGeneration = SegmentInfos.GetCurrentSegmentGeneration(_masterDirectory);
				long currentSegmentGeneration2 = SegmentInfos.GetCurrentSegmentGeneration(_cacheDirectory);
				_inSync = currentSegmentGeneration == currentSegmentGeneration2 && currentSegmentGeneration != -1L;
				_dirty = false;
			}
		}
	}

	private void SetDirty()
	{
		lock (_locker)
		{
			_dirty = true;
		}
	}
}
