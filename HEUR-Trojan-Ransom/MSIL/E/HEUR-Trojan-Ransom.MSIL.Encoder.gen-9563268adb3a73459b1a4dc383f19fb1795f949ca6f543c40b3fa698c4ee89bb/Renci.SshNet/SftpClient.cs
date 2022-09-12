using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet;

public class SftpClient : BaseClient
{
	private static readonly Encoding Utf8NoBOM = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

	private ISftpSession _sftpSession;

	private int _operationTimeout;

	private uint _bufferSize;

	public TimeSpan OperationTimeout
	{
		get
		{
			CheckDisposed();
			return TimeSpan.FromMilliseconds(_operationTimeout);
		}
		set
		{
			CheckDisposed();
			double totalMilliseconds = value.TotalMilliseconds;
			if (totalMilliseconds < -1.0 || totalMilliseconds > 2147483647.0)
			{
				throw new ArgumentOutOfRangeException("value", "The timeout must represent a value between -1 and Int32.MaxValue, inclusive.");
			}
			_operationTimeout = (int)totalMilliseconds;
		}
	}

	public uint BufferSize
	{
		get
		{
			CheckDisposed();
			return _bufferSize;
		}
		set
		{
			CheckDisposed();
			_bufferSize = value;
		}
	}

	public string WorkingDirectory
	{
		get
		{
			CheckDisposed();
			if (_sftpSession == null)
			{
				throw new SshConnectionException("Client not connected.");
			}
			return _sftpSession.WorkingDirectory;
		}
	}

	public int ProtocolVersion
	{
		get
		{
			CheckDisposed();
			if (_sftpSession == null)
			{
				throw new SshConnectionException("Client not connected.");
			}
			return (int)_sftpSession.ProtocolVersion;
		}
	}

	internal ISftpSession SftpSession => _sftpSession;

	public SftpClient(ConnectionInfo connectionInfo)
		: this(connectionInfo, ownsConnectionInfo: false)
	{
	}

	public SftpClient(string host, int port, string username, string password)
		: this(new PasswordConnectionInfo(host, port, username, password), ownsConnectionInfo: true)
	{
	}

	public SftpClient(string host, string username, string password)
		: this(host, ConnectionInfo.DefaultPort, username, password)
	{
	}

	public SftpClient(string host, int port, string username, params PrivateKeyFile[] keyFiles)
		: this(new PrivateKeyConnectionInfo(host, port, username, keyFiles), ownsConnectionInfo: true)
	{
	}

	public SftpClient(string host, string username, params PrivateKeyFile[] keyFiles)
		: this(host, ConnectionInfo.DefaultPort, username, keyFiles)
	{
	}

	private SftpClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo)
		: this(connectionInfo, ownsConnectionInfo, new ServiceFactory())
	{
	}

	internal SftpClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo, IServiceFactory serviceFactory)
		: base(connectionInfo, ownsConnectionInfo, serviceFactory)
	{
		_operationTimeout = Renci.SshNet.Session.Infinite;
		_bufferSize = 32768u;
	}

	public void ChangeDirectory(string path)
	{
		CheckDisposed();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		_sftpSession.ChangeDirectory(path);
	}

	public void ChangePermissions(string path, short mode)
	{
		Get(path).SetPermissions(mode);
	}

	public void CreateDirectory(string path)
	{
		CheckDisposed();
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException(path);
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		_sftpSession.RequestMkDir(canonicalPath);
	}

	public void DeleteDirectory(string path)
	{
		CheckDisposed();
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		_sftpSession.RequestRmDir(canonicalPath);
	}

	public void DeleteFile(string path)
	{
		CheckDisposed();
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		_sftpSession.RequestRemove(canonicalPath);
	}

	public void RenameFile(string oldPath, string newPath)
	{
		RenameFile(oldPath, newPath, isPosix: false);
	}

	public void RenameFile(string oldPath, string newPath, bool isPosix)
	{
		CheckDisposed();
		if (oldPath == null)
		{
			throw new ArgumentNullException("oldPath");
		}
		if (newPath == null)
		{
			throw new ArgumentNullException("newPath");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(oldPath);
		string canonicalPath2 = _sftpSession.GetCanonicalPath(newPath);
		if (isPosix)
		{
			_sftpSession.RequestPosixRename(canonicalPath, canonicalPath2);
		}
		else
		{
			_sftpSession.RequestRename(canonicalPath, canonicalPath2);
		}
	}

	public void SymbolicLink(string path, string linkPath)
	{
		CheckDisposed();
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		if (linkPath.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("linkPath");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		string canonicalPath2 = _sftpSession.GetCanonicalPath(linkPath);
		_sftpSession.RequestSymLink(canonicalPath, canonicalPath2);
	}

	public IEnumerable<SftpFile> ListDirectory(string path, Action<int> listCallback = null)
	{
		CheckDisposed();
		return InternalListDirectory(path, listCallback);
	}

	public IAsyncResult BeginListDirectory(string path, AsyncCallback asyncCallback, object state, Action<int> listCallback = null)
	{
		CheckDisposed();
		SftpListDirectoryAsyncResult asyncResult = new SftpListDirectoryAsyncResult(asyncCallback, state);
		ThreadAbstraction.ExecuteThread(delegate
		{
			try
			{
				IEnumerable<SftpFile> result = InternalListDirectory(path, delegate(int count)
				{
					asyncResult.Update(count);
					if (listCallback != null)
					{
						listCallback(count);
					}
				});
				asyncResult.SetAsCompleted(result, completedSynchronously: false);
			}
			catch (Exception exception)
			{
				asyncResult.SetAsCompleted(exception, completedSynchronously: false);
			}
		});
		return asyncResult;
	}

	public IEnumerable<SftpFile> EndListDirectory(IAsyncResult asyncResult)
	{
		if (!(asyncResult is SftpListDirectoryAsyncResult sftpListDirectoryAsyncResult) || sftpListDirectoryAsyncResult.EndInvokeCalled)
		{
			throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndExecute was called multiple times with the same IAsyncResult.");
		}
		return sftpListDirectoryAsyncResult.EndInvoke();
	}

	public SftpFile Get(string path)
	{
		CheckDisposed();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		SftpFileAttributes attributes = _sftpSession.RequestLStat(canonicalPath);
		return new SftpFile(_sftpSession, canonicalPath, attributes);
	}

	public bool Exists(string path)
	{
		CheckDisposed();
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		try
		{
			_sftpSession.RequestLStat(canonicalPath);
			return true;
		}
		catch (SftpPathNotFoundException)
		{
			return false;
		}
	}

	public void DownloadFile(string path, Stream output, Action<ulong> downloadCallback = null)
	{
		CheckDisposed();
		InternalDownloadFile(path, output, null, downloadCallback);
	}

	public IAsyncResult BeginDownloadFile(string path, Stream output)
	{
		return BeginDownloadFile(path, output, null, null);
	}

	public IAsyncResult BeginDownloadFile(string path, Stream output, AsyncCallback asyncCallback)
	{
		return BeginDownloadFile(path, output, asyncCallback, null);
	}

	public IAsyncResult BeginDownloadFile(string path, Stream output, AsyncCallback asyncCallback, object state, Action<ulong> downloadCallback = null)
	{
		CheckDisposed();
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		SftpDownloadAsyncResult asyncResult = new SftpDownloadAsyncResult(asyncCallback, state);
		ThreadAbstraction.ExecuteThread(delegate
		{
			try
			{
				InternalDownloadFile(path, output, asyncResult, delegate(ulong offset)
				{
					asyncResult.Update(offset);
					if (downloadCallback != null)
					{
						downloadCallback(offset);
					}
				});
				asyncResult.SetAsCompleted(null, completedSynchronously: false);
			}
			catch (Exception exception)
			{
				asyncResult.SetAsCompleted(exception, completedSynchronously: false);
			}
		});
		return asyncResult;
	}

	public void EndDownloadFile(IAsyncResult asyncResult)
	{
		if (!(asyncResult is SftpDownloadAsyncResult sftpDownloadAsyncResult) || sftpDownloadAsyncResult.EndInvokeCalled)
		{
			throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndExecute was called multiple times with the same IAsyncResult.");
		}
		sftpDownloadAsyncResult.EndInvoke();
	}

	public void UploadFile(Stream input, string path, Action<ulong> uploadCallback = null)
	{
		UploadFile(input, path, canOverride: true, uploadCallback);
	}

	public void UploadFile(Stream input, string path, bool canOverride, Action<ulong> uploadCallback = null)
	{
		CheckDisposed();
		Flags flags = Flags.Write | Flags.Truncate;
		flags = ((!canOverride) ? (flags | Flags.CreateNew) : (flags | Flags.CreateNewOrOpen));
		InternalUploadFile(input, path, flags, null, uploadCallback);
	}

	public IAsyncResult BeginUploadFile(Stream input, string path)
	{
		return BeginUploadFile(input, path, canOverride: true, null, null);
	}

	public IAsyncResult BeginUploadFile(Stream input, string path, AsyncCallback asyncCallback)
	{
		return BeginUploadFile(input, path, canOverride: true, asyncCallback, null);
	}

	public IAsyncResult BeginUploadFile(Stream input, string path, AsyncCallback asyncCallback, object state, Action<ulong> uploadCallback = null)
	{
		return BeginUploadFile(input, path, canOverride: true, asyncCallback, state, uploadCallback);
	}

	public IAsyncResult BeginUploadFile(Stream input, string path, bool canOverride, AsyncCallback asyncCallback, object state, Action<ulong> uploadCallback = null)
	{
		CheckDisposed();
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		Flags flags = Flags.Write | Flags.Truncate;
		if (canOverride)
		{
			flags |= Flags.CreateNewOrOpen;
		}
		else
		{
			flags |= Flags.CreateNew;
		}
		SftpUploadAsyncResult asyncResult = new SftpUploadAsyncResult(asyncCallback, state);
		ThreadAbstraction.ExecuteThread(delegate
		{
			try
			{
				InternalUploadFile(input, path, flags, asyncResult, delegate(ulong offset)
				{
					asyncResult.Update(offset);
					if (uploadCallback != null)
					{
						uploadCallback(offset);
					}
				});
				asyncResult.SetAsCompleted(null, completedSynchronously: false);
			}
			catch (Exception exception)
			{
				asyncResult.SetAsCompleted(exception, completedSynchronously: false);
			}
		});
		return asyncResult;
	}

	public void EndUploadFile(IAsyncResult asyncResult)
	{
		if (!(asyncResult is SftpUploadAsyncResult sftpUploadAsyncResult) || sftpUploadAsyncResult.EndInvokeCalled)
		{
			throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndExecute was called multiple times with the same IAsyncResult.");
		}
		sftpUploadAsyncResult.EndInvoke();
	}

	public SftpFileSytemInformation GetStatus(string path)
	{
		CheckDisposed();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		return _sftpSession.RequestStatVfs(canonicalPath);
	}

	public void AppendAllLines(string path, IEnumerable<string> contents)
	{
		CheckDisposed();
		if (contents == null)
		{
			throw new ArgumentNullException("contents");
		}
		using StreamWriter streamWriter = AppendText(path);
		foreach (string content in contents)
		{
			streamWriter.WriteLine(content);
		}
	}

	public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
	{
		CheckDisposed();
		if (contents == null)
		{
			throw new ArgumentNullException("contents");
		}
		using StreamWriter streamWriter = AppendText(path, encoding);
		foreach (string content in contents)
		{
			streamWriter.WriteLine(content);
		}
	}

	public void AppendAllText(string path, string contents)
	{
		using StreamWriter streamWriter = AppendText(path);
		streamWriter.Write(contents);
	}

	public void AppendAllText(string path, string contents, Encoding encoding)
	{
		using StreamWriter streamWriter = AppendText(path, encoding);
		streamWriter.Write(contents);
	}

	public StreamWriter AppendText(string path)
	{
		return AppendText(path, Utf8NoBOM);
	}

	public StreamWriter AppendText(string path, Encoding encoding)
	{
		CheckDisposed();
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		return new StreamWriter(new SftpFileStream(_sftpSession, path, FileMode.Append, FileAccess.Write, (int)_bufferSize), encoding);
	}

	public SftpFileStream Create(string path)
	{
		CheckDisposed();
		return new SftpFileStream(_sftpSession, path, FileMode.Create, FileAccess.ReadWrite, (int)_bufferSize);
	}

	public SftpFileStream Create(string path, int bufferSize)
	{
		CheckDisposed();
		return new SftpFileStream(_sftpSession, path, FileMode.Create, FileAccess.ReadWrite, bufferSize);
	}

	public StreamWriter CreateText(string path)
	{
		return CreateText(path, Utf8NoBOM);
	}

	public StreamWriter CreateText(string path, Encoding encoding)
	{
		CheckDisposed();
		return new StreamWriter(OpenWrite(path), encoding);
	}

	public void Delete(string path)
	{
		Get(path).Delete();
	}

	public DateTime GetLastAccessTime(string path)
	{
		return Get(path).LastAccessTime;
	}

	public DateTime GetLastAccessTimeUtc(string path)
	{
		return GetLastAccessTime(path).ToUniversalTime();
	}

	public DateTime GetLastWriteTime(string path)
	{
		return Get(path).LastWriteTime;
	}

	public DateTime GetLastWriteTimeUtc(string path)
	{
		return GetLastWriteTime(path).ToUniversalTime();
	}

	public SftpFileStream Open(string path, FileMode mode)
	{
		return Open(path, mode, FileAccess.ReadWrite);
	}

	public SftpFileStream Open(string path, FileMode mode, FileAccess access)
	{
		CheckDisposed();
		return new SftpFileStream(_sftpSession, path, mode, access, (int)_bufferSize);
	}

	public SftpFileStream OpenRead(string path)
	{
		return Open(path, FileMode.Open, FileAccess.Read);
	}

	public StreamReader OpenText(string path)
	{
		return new StreamReader(OpenRead(path), Encoding.UTF8);
	}

	public SftpFileStream OpenWrite(string path)
	{
		CheckDisposed();
		return new SftpFileStream(_sftpSession, path, FileMode.OpenOrCreate, FileAccess.Write, (int)_bufferSize);
	}

	public byte[] ReadAllBytes(string path)
	{
		using SftpFileStream sftpFileStream = OpenRead(path);
		byte[] array = new byte[sftpFileStream.Length];
		sftpFileStream.Read(array, 0, array.Length);
		return array;
	}

	public string[] ReadAllLines(string path)
	{
		return ReadAllLines(path, Encoding.UTF8);
	}

	public string[] ReadAllLines(string path, Encoding encoding)
	{
		List<string> list = new List<string>();
		using (StreamReader streamReader = new StreamReader(OpenRead(path), encoding))
		{
			while (!streamReader.EndOfStream)
			{
				list.Add(streamReader.ReadLine());
			}
		}
		return list.ToArray();
	}

	public string ReadAllText(string path)
	{
		return ReadAllText(path, Encoding.UTF8);
	}

	public string ReadAllText(string path, Encoding encoding)
	{
		using StreamReader streamReader = new StreamReader(OpenRead(path), encoding);
		return streamReader.ReadToEnd();
	}

	public IEnumerable<string> ReadLines(string path)
	{
		return ReadAllLines(path);
	}

	public IEnumerable<string> ReadLines(string path, Encoding encoding)
	{
		return ReadAllLines(path, encoding);
	}

	[Obsolete("Note: This method currently throws NotImplementedException because it has not yet been implemented.")]
	public void SetLastAccessTime(string path, DateTime lastAccessTime)
	{
		throw new NotImplementedException();
	}

	[Obsolete("Note: This method currently throws NotImplementedException because it has not yet been implemented.")]
	public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
	{
		throw new NotImplementedException();
	}

	[Obsolete("Note: This method currently throws NotImplementedException because it has not yet been implemented.")]
	public void SetLastWriteTime(string path, DateTime lastWriteTime)
	{
		throw new NotImplementedException();
	}

	[Obsolete("Note: This method currently throws NotImplementedException because it has not yet been implemented.")]
	public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
	{
		throw new NotImplementedException();
	}

	public void WriteAllBytes(string path, byte[] bytes)
	{
		using SftpFileStream sftpFileStream = OpenWrite(path);
		sftpFileStream.Write(bytes, 0, bytes.Length);
	}

	public void WriteAllLines(string path, IEnumerable<string> contents)
	{
		WriteAllLines(path, contents, Utf8NoBOM);
	}

	public void WriteAllLines(string path, string[] contents)
	{
		WriteAllLines(path, contents, Utf8NoBOM);
	}

	public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
	{
		using StreamWriter streamWriter = CreateText(path, encoding);
		foreach (string content in contents)
		{
			streamWriter.WriteLine(content);
		}
	}

	public void WriteAllLines(string path, string[] contents, Encoding encoding)
	{
		using StreamWriter streamWriter = CreateText(path, encoding);
		foreach (string value in contents)
		{
			streamWriter.WriteLine(value);
		}
	}

	public void WriteAllText(string path, string contents)
	{
		using StreamWriter streamWriter = CreateText(path);
		streamWriter.Write(contents);
	}

	public void WriteAllText(string path, string contents, Encoding encoding)
	{
		using StreamWriter streamWriter = CreateText(path, encoding);
		streamWriter.Write(contents);
	}

	public SftpFileAttributes GetAttributes(string path)
	{
		CheckDisposed();
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		return _sftpSession.RequestLStat(canonicalPath);
	}

	public void SetAttributes(string path, SftpFileAttributes fileAttributes)
	{
		CheckDisposed();
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		_sftpSession.RequestSetStat(canonicalPath, fileAttributes);
	}

	public IEnumerable<FileInfo> SynchronizeDirectories(string sourcePath, string destinationPath, string searchPattern)
	{
		if (sourcePath == null)
		{
			throw new ArgumentNullException("sourcePath");
		}
		if (destinationPath.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("destinationPath");
		}
		return InternalSynchronizeDirectories(sourcePath, destinationPath, searchPattern, null);
	}

	public IAsyncResult BeginSynchronizeDirectories(string sourcePath, string destinationPath, string searchPattern, AsyncCallback asyncCallback, object state)
	{
		if (sourcePath == null)
		{
			throw new ArgumentNullException("sourcePath");
		}
		if (destinationPath.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("destDir");
		}
		SftpSynchronizeDirectoriesAsyncResult asyncResult = new SftpSynchronizeDirectoriesAsyncResult(asyncCallback, state);
		ThreadAbstraction.ExecuteThread(delegate
		{
			try
			{
				IEnumerable<FileInfo> result = InternalSynchronizeDirectories(sourcePath, destinationPath, searchPattern, asyncResult);
				asyncResult.SetAsCompleted(result, completedSynchronously: false);
			}
			catch (Exception exception)
			{
				asyncResult.SetAsCompleted(exception, completedSynchronously: false);
			}
		});
		return asyncResult;
	}

	public IEnumerable<FileInfo> EndSynchronizeDirectories(IAsyncResult asyncResult)
	{
		if (!(asyncResult is SftpSynchronizeDirectoriesAsyncResult sftpSynchronizeDirectoriesAsyncResult) || sftpSynchronizeDirectoriesAsyncResult.EndInvokeCalled)
		{
			throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndExecute was called multiple times with the same IAsyncResult.");
		}
		return sftpSynchronizeDirectoriesAsyncResult.EndInvoke();
	}

	private IEnumerable<FileInfo> InternalSynchronizeDirectories(string sourcePath, string destinationPath, string searchPattern, SftpSynchronizeDirectoriesAsyncResult asynchResult)
	{
		if (!Directory.Exists(sourcePath))
		{
			throw new FileNotFoundException($"Source directory not found: {sourcePath}");
		}
		List<FileInfo> list = new List<FileInfo>();
		List<FileInfo> list2 = FileSystemAbstraction.EnumerateFiles(new DirectoryInfo(sourcePath), searchPattern).ToList();
		if (list2.Count == 0)
		{
			return list;
		}
		IEnumerable<SftpFile> enumerable = InternalListDirectory(destinationPath, null);
		Dictionary<string, SftpFile> dictionary = new Dictionary<string, SftpFile>();
		foreach (SftpFile item in enumerable)
		{
			if (!item.IsDirectory)
			{
				dictionary.Add(item.Name, item);
			}
		}
		foreach (FileInfo item2 in list2)
		{
			bool flag;
			if (!(flag = !dictionary.ContainsKey(item2.Name)))
			{
				SftpFile sftpFile = dictionary[item2.Name];
				flag = item2.Length != sftpFile.Length;
			}
			if (!flag)
			{
				continue;
			}
			string text = string.Format(CultureInfo.InvariantCulture, "{0}/{1}", new object[2] { destinationPath, item2.Name });
			try
			{
				using (FileStream input = File.OpenRead(item2.FullName))
				{
					InternalUploadFile(input, text, Flags.Write | Flags.CreateNewOrOpen | Flags.Truncate, null, null);
				}
				list.Add(item2);
				asynchResult?.Update(list.Count);
			}
			catch (Exception innerException)
			{
				throw new Exception($"Failed to upload {item2.FullName} to {text}", innerException);
			}
		}
		return list;
	}

	private IEnumerable<SftpFile> InternalListDirectory(string path, Action<int> listCallback)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		byte[] handle = _sftpSession.RequestOpenDir(canonicalPath);
		string basePath = canonicalPath;
		if (!basePath.EndsWith("/"))
		{
			basePath = $"{canonicalPath}/";
		}
		List<SftpFile> result = new List<SftpFile>();
		for (KeyValuePair<string, SftpFileAttributes>[] array = _sftpSession.RequestReadDir(handle); array != null; array = _sftpSession.RequestReadDir(handle))
		{
			result.AddRange(array.Select(delegate(KeyValuePair<string, SftpFileAttributes> f)
			{
				ISftpSession sftpSession = _sftpSession;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				object[] obj = new object[2] { basePath, null };
				KeyValuePair<string, SftpFileAttributes> keyValuePair = f;
				obj[1] = keyValuePair.Key;
				string fullName = string.Format(invariantCulture, "{0}{1}", obj);
				keyValuePair = f;
				return new SftpFile(sftpSession, fullName, keyValuePair.Value);
			}));
			if (listCallback != null)
			{
				ThreadAbstraction.ExecuteThread(delegate
				{
					listCallback(result.Count);
				});
			}
		}
		_sftpSession.RequestClose(handle);
		return result;
	}

	private void InternalDownloadFile(string path, Stream output, SftpDownloadAsyncResult asyncResult, Action<ulong> downloadCallback)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		using ISftpFileReader sftpFileReader = base.ServiceFactory.CreateSftpFileReader(canonicalPath, _sftpSession, _bufferSize);
		ulong num = 0uL;
		while (asyncResult == null || !asyncResult.IsDownloadCanceled)
		{
			byte[] array = sftpFileReader.Read();
			if (array.Length == 0)
			{
				break;
			}
			output.Write(array, 0, array.Length);
			num += (ulong)array.Length;
			if (downloadCallback != null)
			{
				ulong downloadOffset = num;
				ThreadAbstraction.ExecuteThread(delegate
				{
					downloadCallback(downloadOffset);
				});
			}
		}
	}

	private void InternalUploadFile(Stream input, string path, Flags flags, SftpUploadAsyncResult asyncResult, Action<ulong> uploadCallback)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (path.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("path");
		}
		if (_sftpSession == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		string canonicalPath = _sftpSession.GetCanonicalPath(path);
		byte[] handle = _sftpSession.RequestOpen(canonicalPath, flags);
		ulong num = 0uL;
		byte[] array = new byte[_sftpSession.CalculateOptimalWriteLength(_bufferSize, handle)];
		int num2 = input.Read(array, 0, array.Length);
		int expectedResponses = 0;
		AutoResetEvent responseReceivedWaitHandle = new AutoResetEvent(initialState: false);
		while (asyncResult == null || !asyncResult.IsUploadCanceled)
		{
			if (num2 > 0)
			{
				ulong writtenBytes = num + (ulong)num2;
				_sftpSession.RequestWrite(handle, num, array, 0, num2, null, delegate(SftpStatusResponse s)
				{
					if (s.StatusCode == StatusCodes.Ok)
					{
						Interlocked.Decrement(ref expectedResponses);
						responseReceivedWaitHandle.Set();
						if (uploadCallback != null)
						{
							ThreadAbstraction.ExecuteThread(delegate
							{
								uploadCallback(writtenBytes);
							});
						}
					}
				});
				Interlocked.Increment(ref expectedResponses);
				num += (ulong)num2;
				num2 = input.Read(array, 0, array.Length);
			}
			else if (expectedResponses > 0)
			{
				_sftpSession.WaitOnHandle(responseReceivedWaitHandle, _operationTimeout);
			}
			if (expectedResponses <= 0 && num2 <= 0)
			{
				break;
			}
		}
		_sftpSession.RequestClose(handle);
	}

	protected override void OnConnected()
	{
		base.OnConnected();
		_sftpSession = CreateAndConnectToSftpSession();
	}

	protected override void OnDisconnecting()
	{
		base.OnDisconnecting();
		ISftpSession sftpSession = _sftpSession;
		if (sftpSession != null)
		{
			_sftpSession = null;
			sftpSession.Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			ISftpSession sftpSession = _sftpSession;
			if (sftpSession != null)
			{
				_sftpSession = null;
				sftpSession.Dispose();
			}
		}
	}

	private ISftpSession CreateAndConnectToSftpSession()
	{
		ISftpSession sftpSession = base.ServiceFactory.CreateSftpSession(base.Session, _operationTimeout, base.ConnectionInfo.Encoding, base.ServiceFactory.CreateSftpResponseFactory());
		try
		{
			sftpSession.Connect();
			return sftpSession;
		}
		catch
		{
			sftpSession.Dispose();
			throw;
		}
	}
}
