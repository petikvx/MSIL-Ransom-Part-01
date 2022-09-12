using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public class ScpClient : BaseClient
{
	private static readonly Regex FileInfoRe = new Regex("C(?<mode>\\d{4}) (?<length>\\d+) (?<filename>.+)");

	private static readonly byte[] SuccessConfirmationCode = new byte[1];

	private static readonly byte[] ErrorConfirmationCode = new byte[1] { 1 };

	private IRemotePathTransformation _remotePathTransformation;

	private static readonly Regex DirectoryInfoRe = new Regex("D(?<mode>\\d{4}) (?<length>\\d+) (?<filename>.+)");

	private static readonly Regex TimestampRe = new Regex("T(?<mtime>\\d+) 0 (?<atime>\\d+) 0");

	public TimeSpan OperationTimeout { get; set; }

	public uint BufferSize { get; set; }

	public IRemotePathTransformation RemotePathTransformation
	{
		get
		{
			return _remotePathTransformation;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_remotePathTransformation = value;
		}
	}

	public event EventHandler<ScpDownloadEventArgs> Downloading;

	public event EventHandler<ScpUploadEventArgs> Uploading;

	public ScpClient(ConnectionInfo connectionInfo)
		: this(connectionInfo, ownsConnectionInfo: false)
	{
	}

	public ScpClient(string host, int port, string username, string password)
		: this(new PasswordConnectionInfo(host, port, username, password), ownsConnectionInfo: true)
	{
	}

	public ScpClient(string host, string username, string password)
		: this(host, ConnectionInfo.DefaultPort, username, password)
	{
	}

	public ScpClient(string host, int port, string username, params PrivateKeyFile[] keyFiles)
		: this(new PrivateKeyConnectionInfo(host, port, username, keyFiles), ownsConnectionInfo: true)
	{
	}

	public ScpClient(string host, string username, params PrivateKeyFile[] keyFiles)
		: this(host, ConnectionInfo.DefaultPort, username, keyFiles)
	{
	}

	private ScpClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo)
		: this(connectionInfo, ownsConnectionInfo, new ServiceFactory())
	{
	}

	internal ScpClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo, IServiceFactory serviceFactory)
		: base(connectionInfo, ownsConnectionInfo, serviceFactory)
	{
		OperationTimeout = Renci.SshNet.Session.InfiniteTimeSpan;
		BufferSize = 16384u;
		_remotePathTransformation = serviceFactory.CreateRemotePathDoubleQuoteTransformation();
	}

	public void Upload(Stream source, string path)
	{
		PipeStream input = base.ServiceFactory.CreatePipeStream();
		try
		{
			using IChannelSession channelSession = base.Session.CreateChannelSession();
			channelSession.DataReceived += delegate(object sender, ChannelDataEventArgs e)
			{
				input.Write(e.Data, 0, e.Data.Length);
			};
			channelSession.Open();
			if (!channelSession.SendExecRequest($"scp -t {_remotePathTransformation.Transform(path)}"))
			{
				throw SecureExecutionRequestRejectedException();
			}
			CheckReturnCode(input);
			UploadFileModeAndName(channelSession, input, source.Length, string.Empty);
			UploadFileContent(channelSession, input, source, PosixPath.GetFileName(path));
		}
		finally
		{
			if (input != null)
			{
				((IDisposable)input).Dispose();
			}
		}
	}

	public void Download(string filename, Stream destination)
	{
		if (filename.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("filename");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		PipeStream input = base.ServiceFactory.CreatePipeStream();
		try
		{
			using IChannelSession channelSession = base.Session.CreateChannelSession();
			channelSession.DataReceived += delegate(object sender, ChannelDataEventArgs e)
			{
				input.Write(e.Data, 0, e.Data.Length);
			};
			channelSession.Open();
			if (!channelSession.SendExecRequest($"scp -f {_remotePathTransformation.Transform(filename)}"))
			{
				throw SecureExecutionRequestRejectedException();
			}
			SendSuccessConfirmation(channelSession);
			string text = ReadString(input);
			Match match = FileInfoRe.Match(text);
			if (match.Success)
			{
				SendSuccessConfirmation(channelSession);
				long length = long.Parse(match.Result("${length}"));
				string filename2 = match.Result("${filename}");
				InternalDownload(channelSession, input, destination, filename2, length);
			}
			else
			{
				SendErrorConfirmation(channelSession, $"\"{text}\" is not valid protocol message.");
			}
		}
		finally
		{
			if (input != null)
			{
				((IDisposable)input).Dispose();
			}
		}
	}

	private void UploadFileModeAndName(IChannelSession channel, Stream input, long fileSize, string serverFileName)
	{
		SendData(channel, $"C0644 {fileSize} {serverFileName}\n");
		CheckReturnCode(input);
	}

	private void UploadFileContent(IChannelSession channel, Stream input, Stream source, string remoteFileName)
	{
		long length = source.Length;
		byte[] array = new byte[BufferSize];
		int num = source.Read(array, 0, array.Length);
		long num2 = 0L;
		while (num > 0)
		{
			SendData(channel, array, num);
			num2 += num;
			RaiseUploadingEvent(remoteFileName, length, num2);
			num = source.Read(array, 0, array.Length);
		}
		SendSuccessConfirmation(channel);
		CheckReturnCode(input);
	}

	private void InternalDownload(IChannel channel, Stream input, Stream output, string filename, long length)
	{
		byte[] buffer = new byte[Math.Min(length, BufferSize)];
		long num = length;
		do
		{
			int num2 = input.Read(buffer, 0, (int)Math.Min(num, BufferSize));
			output.Write(buffer, 0, num2);
			RaiseDownloadingEvent(filename, length, length - num);
			num -= num2;
		}
		while (num > 0L);
		output.Flush();
		RaiseDownloadingEvent(filename, length, length - num);
		SendSuccessConfirmation(channel);
		CheckReturnCode(input);
	}

	private void RaiseDownloadingEvent(string filename, long size, long downloaded)
	{
		if (this.Downloading != null)
		{
			this.Downloading(this, new ScpDownloadEventArgs(filename, size, downloaded));
		}
	}

	private void RaiseUploadingEvent(string filename, long size, long uploaded)
	{
		if (this.Uploading != null)
		{
			this.Uploading(this, new ScpUploadEventArgs(filename, size, uploaded));
		}
	}

	private static void SendSuccessConfirmation(IChannel channel)
	{
		SendData(channel, SuccessConfirmationCode);
	}

	private void SendErrorConfirmation(IChannel channel, string message)
	{
		SendData(channel, ErrorConfirmationCode);
		SendData(channel, message + "\n");
	}

	private void CheckReturnCode(Stream input)
	{
		if (ReadByte(input) > 0)
		{
			throw new ScpException(ReadString(input));
		}
	}

	private void SendData(IChannel channel, string command)
	{
		channel.SendData(base.ConnectionInfo.Encoding.GetBytes(command));
	}

	private static void SendData(IChannel channel, byte[] buffer, int length)
	{
		channel.SendData(buffer, 0, length);
	}

	private static void SendData(IChannel channel, byte[] buffer)
	{
		channel.SendData(buffer);
	}

	private static int ReadByte(Stream stream)
	{
		int num = stream.ReadByte();
		if (num == -1)
		{
			throw new SshException("Stream has been closed.");
		}
		return num;
	}

	private string ReadString(Stream stream)
	{
		bool flag = false;
		List<byte> list = new List<byte>();
		int num = ReadByte(stream);
		if (num == 1 || num == 2)
		{
			flag = true;
			num = ReadByte(stream);
		}
		while (num != 10)
		{
			list.Add((byte)num);
			num = ReadByte(stream);
		}
		byte[] array = list.ToArray();
		if (flag)
		{
			throw new ScpException(base.ConnectionInfo.Encoding.GetString(array, 0, array.Length));
		}
		return base.ConnectionInfo.Encoding.GetString(array, 0, array.Length);
	}

	private static SshException SecureExecutionRequestRejectedException()
	{
		throw new SshException("Secure copy execution request was rejected by the server. Please consult the server logs.");
	}

	public void Upload(FileInfo fileInfo, string path)
	{
		if (fileInfo == null)
		{
			throw new ArgumentNullException("fileInfo");
		}
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentException("path");
		}
		PipeStream input = base.ServiceFactory.CreatePipeStream();
		try
		{
			using IChannelSession channelSession = base.Session.CreateChannelSession();
			channelSession.DataReceived += delegate(object sender, ChannelDataEventArgs e)
			{
				input.Write(e.Data, 0, e.Data.Length);
			};
			channelSession.Open();
			if (!channelSession.SendExecRequest($"scp -t {_remotePathTransformation.Transform(path)}"))
			{
				throw SecureExecutionRequestRejectedException();
			}
			CheckReturnCode(input);
			using FileStream fileStream = fileInfo.OpenRead();
			UploadTimes(channelSession, input, fileInfo);
			UploadFileModeAndName(channelSession, input, fileStream.Length, string.Empty);
			UploadFileContent(channelSession, input, fileStream, fileInfo.Name);
		}
		finally
		{
			if (input != null)
			{
				((IDisposable)input).Dispose();
			}
		}
	}

	public void Upload(DirectoryInfo directoryInfo, string path)
	{
		if (directoryInfo == null)
		{
			throw new ArgumentNullException("directoryInfo");
		}
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentException("path");
		}
		PipeStream input = base.ServiceFactory.CreatePipeStream();
		try
		{
			using IChannelSession channelSession = base.Session.CreateChannelSession();
			channelSession.DataReceived += delegate(object sender, ChannelDataEventArgs e)
			{
				input.Write(e.Data, 0, e.Data.Length);
			};
			channelSession.Open();
			if (!channelSession.SendExecRequest($"scp -rt {_remotePathTransformation.Transform(path)}"))
			{
				throw SecureExecutionRequestRejectedException();
			}
			CheckReturnCode(input);
			UploadTimes(channelSession, input, directoryInfo);
			UploadDirectoryModeAndName(channelSession, input, ".");
			UploadDirectoryContent(channelSession, input, directoryInfo);
		}
		finally
		{
			if (input != null)
			{
				((IDisposable)input).Dispose();
			}
		}
	}

	public void Download(string filename, FileInfo fileInfo)
	{
		if (string.IsNullOrEmpty(filename))
		{
			throw new ArgumentException("filename");
		}
		if (fileInfo == null)
		{
			throw new ArgumentNullException("fileInfo");
		}
		PipeStream input = base.ServiceFactory.CreatePipeStream();
		try
		{
			using IChannelSession channelSession = base.Session.CreateChannelSession();
			channelSession.DataReceived += delegate(object sender, ChannelDataEventArgs e)
			{
				input.Write(e.Data, 0, e.Data.Length);
			};
			channelSession.Open();
			if (!channelSession.SendExecRequest($"scp -pf {_remotePathTransformation.Transform(filename)}"))
			{
				throw SecureExecutionRequestRejectedException();
			}
			SendSuccessConfirmation(channelSession);
			InternalDownload(channelSession, input, fileInfo);
		}
		finally
		{
			if (input != null)
			{
				((IDisposable)input).Dispose();
			}
		}
	}

	public void Download(string directoryName, DirectoryInfo directoryInfo)
	{
		if (string.IsNullOrEmpty(directoryName))
		{
			throw new ArgumentException("directoryName");
		}
		if (directoryInfo == null)
		{
			throw new ArgumentNullException("directoryInfo");
		}
		PipeStream input = base.ServiceFactory.CreatePipeStream();
		try
		{
			using IChannelSession channelSession = base.Session.CreateChannelSession();
			channelSession.DataReceived += delegate(object sender, ChannelDataEventArgs e)
			{
				input.Write(e.Data, 0, e.Data.Length);
			};
			channelSession.Open();
			if (!channelSession.SendExecRequest($"scp -prf {_remotePathTransformation.Transform(directoryName)}"))
			{
				throw SecureExecutionRequestRejectedException();
			}
			SendSuccessConfirmation(channelSession);
			InternalDownload(channelSession, input, directoryInfo);
		}
		finally
		{
			if (input != null)
			{
				((IDisposable)input).Dispose();
			}
		}
	}

	private void UploadTimes(IChannelSession channel, Stream input, FileSystemInfo fileOrDirectory)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
		long num = (long)(fileOrDirectory.LastWriteTimeUtc - dateTime).TotalSeconds;
		long num2 = (long)(fileOrDirectory.LastAccessTimeUtc - dateTime).TotalSeconds;
		SendData(channel, $"T{num} 0 {num2} 0\n");
		CheckReturnCode(input);
	}

	private void UploadDirectoryContent(IChannelSession channel, Stream input, DirectoryInfo directoryInfo)
	{
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			using FileStream fileStream = fileInfo.OpenRead();
			UploadTimes(channel, input, fileInfo);
			UploadFileModeAndName(channel, input, fileStream.Length, fileInfo.Name);
			UploadFileContent(channel, input, fileStream, fileInfo.Name);
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			UploadTimes(channel, input, directoryInfo2);
			UploadDirectoryModeAndName(channel, input, directoryInfo2.Name);
			UploadDirectoryContent(channel, input, directoryInfo2);
		}
		SendData(channel, "E\n");
		CheckReturnCode(input);
	}

	private void UploadDirectoryModeAndName(IChannelSession channel, Stream input, string directoryName)
	{
		SendData(channel, $"D0755 0 {directoryName}\n");
		CheckReturnCode(input);
	}

	private void InternalDownload(IChannelSession channel, Stream input, FileSystemInfo fileSystemInfo)
	{
		DateTime lastWriteTime = DateTime.Now;
		DateTime lastAccessTime = DateTime.Now;
		string fullName = fileSystemInfo.FullName;
		int num = 0;
		while (true)
		{
			string text = ReadString(input);
			if (!(text == "E"))
			{
				Match match = DirectoryInfoRe.Match(text);
				if (match.Success)
				{
					SendSuccessConfirmation(channel);
					string path = match.Result("${filename}");
					DirectoryInfo directoryInfo;
					if (num > 0)
					{
						directoryInfo = Directory.CreateDirectory(Path.Combine(fullName, path));
						directoryInfo.LastAccessTime = lastAccessTime;
						directoryInfo.LastWriteTime = lastWriteTime;
					}
					else
					{
						directoryInfo = fileSystemInfo as DirectoryInfo;
					}
					num++;
					fullName = directoryInfo.FullName;
					continue;
				}
				match = FileInfoRe.Match(text);
				if (match.Success)
				{
					SendSuccessConfirmation(channel);
					long length = long.Parse(match.Result("${length}"));
					string text2 = match.Result("${filename}");
					FileInfo fileInfo = fileSystemInfo as FileInfo;
					if (fileInfo == null)
					{
						fileInfo = new FileInfo(Path.Combine(fullName, text2));
					}
					using (FileStream output = fileInfo.OpenWrite())
					{
						InternalDownload(channel, input, output, text2, length);
					}
					fileInfo.LastAccessTime = lastAccessTime;
					fileInfo.LastWriteTime = lastWriteTime;
					if (num == 0)
					{
						break;
					}
				}
				else
				{
					match = TimestampRe.Match(text);
					if (match.Success)
					{
						SendSuccessConfirmation(channel);
						long num2 = long.Parse(match.Result("${mtime}"));
						long num3 = long.Parse(match.Result("${atime}"));
						DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
						lastWriteTime = dateTime.AddSeconds(num2);
						lastAccessTime = dateTime.AddSeconds(num3);
					}
					else
					{
						SendErrorConfirmation(channel, $"\"{text}\" is not valid protocol message.");
					}
				}
			}
			else
			{
				SendSuccessConfirmation(channel);
				num--;
				fullName = new DirectoryInfo(fullName).Parent!.FullName;
				if (num == 0)
				{
					break;
				}
			}
		}
	}
}
