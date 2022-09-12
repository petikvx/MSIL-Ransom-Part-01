using System;
using System.Collections.Generic;
using System.Globalization;
using Renci.SshNet.Common;
using Renci.SshNet.Messages;
using Renci.SshNet.Messages.Authentication;
using Renci.SshNet.Messages.Connection;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet;

internal class SshMessageFactory
{
	internal abstract class MessageMetadata
	{
		public readonly byte Id;

		public readonly string Name;

		public readonly byte Number;

		protected MessageMetadata(byte id, string name, byte number)
		{
			Id = id;
			Name = name;
			Number = number;
		}

		public abstract Message Create();
	}

	internal class MessageMetadata<T> : MessageMetadata where T : Message, new()
	{
		public MessageMetadata(byte id, string name, byte number)
			: base(id, name, number)
		{
		}

		public override Message Create()
		{
			return new T();
		}
	}

	private readonly MessageMetadata[] _enabledMessagesByNumber;

	private readonly bool[] _activatedMessagesById;

	internal static readonly MessageMetadata[] AllMessages;

	private static readonly IDictionary<string, MessageMetadata> MessagesByName;

	internal const byte HighestMessageNumber = 100;

	internal const int TotalMessageCount = 32;

	static SshMessageFactory()
	{
		AllMessages = new MessageMetadata[32]
		{
			new MessageMetadata<KeyExchangeInitMessage>(0, "SSH_MSG_KEXINIT", 20),
			new MessageMetadata<NewKeysMessage>(1, "SSH_MSG_NEWKEYS", 21),
			new MessageMetadata<RequestFailureMessage>(2, "SSH_MSG_REQUEST_FAILURE", 82),
			new MessageMetadata<ChannelOpenFailureMessage>(3, "SSH_MSG_CHANNEL_OPEN_FAILURE", 92),
			new MessageMetadata<ChannelFailureMessage>(4, "SSH_MSG_CHANNEL_FAILURE", 100),
			new MessageMetadata<ChannelExtendedDataMessage>(5, "SSH_MSG_CHANNEL_EXTENDED_DATA", 95),
			new MessageMetadata<ChannelDataMessage>(6, "SSH_MSG_CHANNEL_DATA", 94),
			new MessageMetadata<ChannelRequestMessage>(7, "SSH_MSG_CHANNEL_REQUEST", 98),
			new MessageMetadata<BannerMessage>(8, "SSH_MSG_USERAUTH_BANNER", 53),
			new MessageMetadata<InformationResponseMessage>(9, "SSH_MSG_USERAUTH_INFO_RESPONSE", 61),
			new MessageMetadata<FailureMessage>(10, "SSH_MSG_USERAUTH_FAILURE", 51),
			new MessageMetadata<DebugMessage>(11, "SSH_MSG_DEBUG", 4),
			new MessageMetadata<GlobalRequestMessage>(12, "SSH_MSG_GLOBAL_REQUEST", 80),
			new MessageMetadata<ChannelOpenMessage>(13, "SSH_MSG_CHANNEL_OPEN", 90),
			new MessageMetadata<ChannelOpenConfirmationMessage>(14, "SSH_MSG_CHANNEL_OPEN_CONFIRMATION", 91),
			new MessageMetadata<InformationRequestMessage>(15, "SSH_MSG_USERAUTH_INFO_REQUEST", 60),
			new MessageMetadata<UnimplementedMessage>(16, "SSH_MSG_UNIMPLEMENTED", 3),
			new MessageMetadata<RequestSuccessMessage>(17, "SSH_MSG_REQUEST_SUCCESS", 81),
			new MessageMetadata<ChannelSuccessMessage>(18, "SSH_MSG_CHANNEL_SUCCESS", 99),
			new MessageMetadata<PasswordChangeRequiredMessage>(19, "SSH_MSG_USERAUTH_PASSWD_CHANGEREQ", 60),
			new MessageMetadata<DisconnectMessage>(20, "SSH_MSG_DISCONNECT", 1),
			new MessageMetadata<SuccessMessage>(21, "SSH_MSG_USERAUTH_SUCCESS", 52),
			new MessageMetadata<PublicKeyMessage>(22, "SSH_MSG_USERAUTH_PK_OK", 60),
			new MessageMetadata<IgnoreMessage>(23, "SSH_MSG_IGNORE", 2),
			new MessageMetadata<ChannelWindowAdjustMessage>(24, "SSH_MSG_CHANNEL_WINDOW_ADJUST", 93),
			new MessageMetadata<ChannelEofMessage>(25, "SSH_MSG_CHANNEL_EOF", 96),
			new MessageMetadata<ChannelCloseMessage>(26, "SSH_MSG_CHANNEL_CLOSE", 97),
			new MessageMetadata<ServiceAcceptMessage>(27, "SSH_MSG_SERVICE_ACCEPT", 6),
			new MessageMetadata<KeyExchangeDhGroupExchangeGroup>(28, "SSH_MSG_KEX_DH_GEX_GROUP", 31),
			new MessageMetadata<KeyExchangeDhReplyMessage>(29, "SSH_MSG_KEXDH_REPLY", 31),
			new MessageMetadata<KeyExchangeDhGroupExchangeReply>(30, "SSH_MSG_KEX_DH_GEX_REPLY", 33),
			new MessageMetadata<KeyExchangeEcdhReplyMessage>(31, "SSH_MSG_KEX_ECDH_REPLY", 31)
		};
		MessagesByName = new Dictionary<string, MessageMetadata>(AllMessages.Length);
		for (int i = 0; i < AllMessages.Length; i++)
		{
			MessageMetadata messageMetadata = AllMessages[i];
			MessagesByName.Add(messageMetadata.Name, messageMetadata);
		}
	}

	public SshMessageFactory()
	{
		_activatedMessagesById = new bool[32];
		_enabledMessagesByNumber = new MessageMetadata[101];
	}

	public void Reset()
	{
		Array.Clear(_activatedMessagesById, 0, _activatedMessagesById.Length);
		Array.Clear(_enabledMessagesByNumber, 0, _enabledMessagesByNumber.Length);
	}

	public Message Create(byte messageNumber)
	{
		if (messageNumber > 100)
		{
			throw CreateMessageTypeNotSupportedException(messageNumber);
		}
		MessageMetadata messageMetadata = _enabledMessagesByNumber[messageNumber];
		if (messageMetadata == null)
		{
			MessageMetadata messageMetadata2 = null;
			for (int i = 0; i < AllMessages.Length; i++)
			{
				MessageMetadata messageMetadata3 = AllMessages[i];
				if (messageMetadata3.Number == messageNumber)
				{
					messageMetadata2 = messageMetadata3;
					break;
				}
			}
			if (messageMetadata2 == null)
			{
				throw CreateMessageTypeNotSupportedException(messageNumber);
			}
			throw new SshException(string.Format(CultureInfo.InvariantCulture, "Message type {0} is not valid in the current context.", new object[1] { messageNumber }));
		}
		return messageMetadata.Create();
	}

	public void DisableNonKeyExchangeMessages()
	{
		for (int i = 0; i < AllMessages.Length; i++)
		{
			byte number = AllMessages[i].Number;
			if ((number > 2 && number < 20) || number > 30)
			{
				_enabledMessagesByNumber[number] = null;
			}
		}
	}

	public void EnableActivatedMessages()
	{
		int num = 0;
		MessageMetadata messageMetadata;
		MessageMetadata messageMetadata2;
		while (true)
		{
			if (num >= AllMessages.Length)
			{
				return;
			}
			messageMetadata = AllMessages[num];
			if (_activatedMessagesById[messageMetadata.Id])
			{
				messageMetadata2 = _enabledMessagesByNumber[messageMetadata.Number];
				if (messageMetadata2 != null && messageMetadata2 != messageMetadata)
				{
					break;
				}
				_enabledMessagesByNumber[messageMetadata.Number] = messageMetadata;
			}
			num++;
		}
		throw CreateMessageTypeAlreadyEnabledForOtherMessageException(messageMetadata.Number, messageMetadata.Name, messageMetadata2.Name);
	}

	public void EnableAndActivateMessage(string messageName)
	{
		if (messageName == null)
		{
			throw new ArgumentNullException("messageName");
		}
		lock (this)
		{
			if (!MessagesByName.TryGetValue(messageName, out var value))
			{
				throw CreateMessageNotSupportedException(messageName);
			}
			MessageMetadata messageMetadata = _enabledMessagesByNumber[value.Number];
			if (messageMetadata != null && messageMetadata != value)
			{
				throw CreateMessageTypeAlreadyEnabledForOtherMessageException(value.Number, value.Name, messageMetadata.Name);
			}
			_enabledMessagesByNumber[value.Number] = value;
			_activatedMessagesById[value.Id] = true;
		}
	}

	public void DisableAndDeactivateMessage(string messageName)
	{
		if (messageName == null)
		{
			throw new ArgumentNullException("messageName");
		}
		lock (this)
		{
			if (!MessagesByName.TryGetValue(messageName, out var value))
			{
				throw CreateMessageNotSupportedException(messageName);
			}
			MessageMetadata messageMetadata = _enabledMessagesByNumber[value.Number];
			if (messageMetadata != null && messageMetadata != value)
			{
				throw CreateMessageTypeAlreadyEnabledForOtherMessageException(value.Number, value.Name, messageMetadata.Name);
			}
			_activatedMessagesById[value.Id] = false;
			_enabledMessagesByNumber[value.Number] = null;
		}
	}

	private static SshException CreateMessageTypeNotSupportedException(byte messageNumber)
	{
		throw new SshException(string.Format(CultureInfo.InvariantCulture, "Message type {0} is not supported.", new object[1] { messageNumber }));
	}

	private static SshException CreateMessageNotSupportedException(string messageName)
	{
		throw new SshException(string.Format(CultureInfo.InvariantCulture, "Message '{0}' is not supported.", new object[1] { messageName }));
	}

	private static SshException CreateMessageTypeAlreadyEnabledForOtherMessageException(byte messageNumber, string messageName, string currentEnabledForMessageName)
	{
		throw new SshException(string.Format(CultureInfo.InvariantCulture, "Cannot enable message '{0}'. Message type {1} is already enabled for '{2}'.", new object[3] { messageName, messageNumber, currentEnabledForMessageName }));
	}
}
