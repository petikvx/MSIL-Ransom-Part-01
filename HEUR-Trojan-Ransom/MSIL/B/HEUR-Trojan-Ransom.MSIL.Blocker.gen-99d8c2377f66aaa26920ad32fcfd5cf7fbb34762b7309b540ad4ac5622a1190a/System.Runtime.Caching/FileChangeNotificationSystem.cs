using System.Collections;
using System.IO;
using System.Runtime.Caching.Hosting;
using System.Runtime.Caching.Resources;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Caching;

internal sealed class FileChangeNotificationSystem : IFileChangeNotificationSystem
{
	internal class DirectoryMonitor
	{
		internal FileSystemWatcher Fsw;
	}

	internal class FileChangeEventTarget
	{
		private string _fileName;

		private OnChangedCallback _onChangedCallback;

		private FileSystemEventHandler _changedHandler;

		private ErrorEventHandler _errorHandler;

		private RenamedEventHandler _renamedHandler;

		internal FileSystemEventHandler ChangedHandler => _changedHandler;

		internal ErrorEventHandler ErrorHandler => _errorHandler;

		internal RenamedEventHandler RenamedHandler => _renamedHandler;

		private static bool EqualsIgnoreCase(string s1, string s2)
		{
			if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2))
			{
				return true;
			}
			if (!string.IsNullOrEmpty(s1) && !string.IsNullOrEmpty(s2))
			{
				if (s2.Length != s1.Length)
				{
					return false;
				}
				return string.Compare(s1, 0, s2, 0, s2.Length, StringComparison.OrdinalIgnoreCase) == 0;
			}
			return false;
		}

		private void OnChanged(object sender, FileSystemEventArgs e)
		{
			if (EqualsIgnoreCase(_fileName, e.Name))
			{
				_onChangedCallback(null);
			}
		}

		private void OnError(object sender, ErrorEventArgs e)
		{
			_onChangedCallback(null);
		}

		private void OnRenamed(object sender, RenamedEventArgs e)
		{
			if (EqualsIgnoreCase(_fileName, e.Name) || EqualsIgnoreCase(_fileName, e.OldName))
			{
				_onChangedCallback(null);
			}
		}

		internal FileChangeEventTarget(string fileName, OnChangedCallback onChangedCallback)
		{
			_fileName = fileName;
			_onChangedCallback = onChangedCallback;
			_changedHandler = OnChanged;
			_errorHandler = OnError;
			_renamedHandler = OnRenamed;
		}
	}

	private Hashtable _dirMonitors;

	private object _lock;

	internal FileChangeNotificationSystem()
	{
		_dirMonitors = Hashtable.Synchronized(new Hashtable(StringComparer.OrdinalIgnoreCase));
		_lock = new object();
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	void IFileChangeNotificationSystem.StartMonitoring(string filePath, OnChangedCallback onChangedCallback, out object state, out DateTimeOffset lastWriteTime, out long fileSize)
	{
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath");
		}
		if (onChangedCallback == null)
		{
			throw new ArgumentNullException("onChangedCallback");
		}
		FileInfo fileInfo = new FileInfo(filePath);
		string directoryName = Path.GetDirectoryName(filePath);
		DirectoryMonitor directoryMonitor = _dirMonitors[directoryName] as DirectoryMonitor;
		if (directoryMonitor == null)
		{
			lock (_lock)
			{
				directoryMonitor = _dirMonitors[directoryName] as DirectoryMonitor;
				if (directoryMonitor == null)
				{
					directoryMonitor = new DirectoryMonitor();
					directoryMonitor.Fsw = new FileSystemWatcher(directoryName);
					directoryMonitor.Fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.CreationTime | NotifyFilters.Security;
					directoryMonitor.Fsw.EnableRaisingEvents = true;
				}
				_dirMonitors[directoryName] = directoryMonitor;
			}
		}
		FileChangeEventTarget fileChangeEventTarget = new FileChangeEventTarget(fileInfo.Name, onChangedCallback);
		lock (directoryMonitor)
		{
			directoryMonitor.Fsw.Changed += fileChangeEventTarget.ChangedHandler;
			directoryMonitor.Fsw.Created += fileChangeEventTarget.ChangedHandler;
			directoryMonitor.Fsw.Deleted += fileChangeEventTarget.ChangedHandler;
			directoryMonitor.Fsw.Error += fileChangeEventTarget.ErrorHandler;
			directoryMonitor.Fsw.Renamed += fileChangeEventTarget.RenamedHandler;
		}
		state = fileChangeEventTarget;
		lastWriteTime = File.GetLastWriteTime(filePath);
		fileSize = (fileInfo.Exists ? fileInfo.Length : (-1L));
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	void IFileChangeNotificationSystem.StopMonitoring(string filePath, object state)
	{
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath");
		}
		if (state == null)
		{
			throw new ArgumentNullException("state");
		}
		if (!(state is FileChangeEventTarget fileChangeEventTarget))
		{
			throw new ArgumentException(R.Invalid_state, "state");
		}
		string directoryName = Path.GetDirectoryName(filePath);
		if (_dirMonitors[directoryName] is DirectoryMonitor directoryMonitor)
		{
			lock (directoryMonitor)
			{
				directoryMonitor.Fsw.Changed -= fileChangeEventTarget.ChangedHandler;
				directoryMonitor.Fsw.Created -= fileChangeEventTarget.ChangedHandler;
				directoryMonitor.Fsw.Deleted -= fileChangeEventTarget.ChangedHandler;
				directoryMonitor.Fsw.Error -= fileChangeEventTarget.ErrorHandler;
				directoryMonitor.Fsw.Renamed -= fileChangeEventTarget.RenamedHandler;
			}
		}
	}
}
