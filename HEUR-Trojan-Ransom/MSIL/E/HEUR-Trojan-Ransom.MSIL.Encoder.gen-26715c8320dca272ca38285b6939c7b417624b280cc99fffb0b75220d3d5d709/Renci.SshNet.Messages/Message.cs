using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Compression;

namespace Renci.SshNet.Messages;

public abstract class Message : SshData
{
	protected override int BufferCapacity => 1;

	protected override void WriteBytes(SshDataStream stream)
	{
		IEnumerator<MessageAttribute> enumerator = GetType().GetCustomAttributes<MessageAttribute>(inherit: true).GetEnumerator();
		try
		{
			if (!enumerator.MoveNext())
			{
				throw new SshException(string.Format(CultureInfo.CurrentCulture, "Type '{0}' is not a valid message type.", new object[1] { GetType().AssemblyQualifiedName }));
			}
			MessageAttribute current = enumerator.Current;
			stream.WriteByte(current.Number);
			base.WriteBytes(stream);
		}
		finally
		{
			enumerator.Dispose();
		}
	}

	internal byte[] GetPacket(byte paddingMultiplier, Compressor compressor)
	{
		int bufferCapacity = BufferCapacity;
		SshDataStream sshDataStream;
		if (bufferCapacity != -1 && compressor == null)
		{
			int num = bufferCapacity + 4 + 1;
			byte paddingLength = GetPaddingLength(paddingMultiplier, num);
			uint packetDataLength = GetPacketDataLength(bufferCapacity, paddingLength);
			sshDataStream = new SshDataStream(num + paddingLength + 4);
			sshDataStream.Seek(4L, SeekOrigin.Begin);
			sshDataStream.Write(packetDataLength);
			sshDataStream.WriteByte(paddingLength);
			WriteBytes(sshDataStream);
			byte[] array = new byte[paddingLength];
			CryptoAbstraction.GenerateRandom(array);
			sshDataStream.Write(array, 0, paddingLength);
		}
		else
		{
			sshDataStream = new SshDataStream(64);
			sshDataStream.Seek(9L, SeekOrigin.Begin);
			if (compressor != null)
			{
				SshDataStream sshDataStream2 = new SshDataStream((bufferCapacity != -1) ? bufferCapacity : 64);
				WriteBytes(sshDataStream2);
				byte[] array2 = compressor.Compress(sshDataStream2.ToArray());
				sshDataStream.Write(array2, 0, array2.Length);
			}
			else
			{
				WriteBytes(sshDataStream);
			}
			bufferCapacity = (int)sshDataStream.Length - 9;
			int num2 = bufferCapacity + 4 + 1;
			byte paddingLength2 = GetPaddingLength(paddingMultiplier, num2);
			byte[] array3 = new byte[paddingLength2];
			CryptoAbstraction.GenerateRandom(array3);
			sshDataStream.Write(array3, 0, paddingLength2);
			uint packetDataLength2 = GetPacketDataLength(bufferCapacity, paddingLength2);
			sshDataStream.Seek(4L, SeekOrigin.Begin);
			sshDataStream.Write(packetDataLength2);
			sshDataStream.WriteByte(paddingLength2);
		}
		return sshDataStream.ToArray();
	}

	private static uint GetPacketDataLength(int messageLength, byte paddingLength)
	{
		return (uint)(messageLength + paddingLength + 1);
	}

	private static byte GetPaddingLength(byte paddingMultiplier, long packetLength)
	{
		byte b = (byte)(-packetLength & (paddingMultiplier - 1));
		if (b < paddingMultiplier)
		{
			b = (byte)(b + paddingMultiplier);
		}
		return b;
	}

	public override string ToString()
	{
		IEnumerator<MessageAttribute> enumerator = GetType().GetCustomAttributes<MessageAttribute>(inherit: true).GetEnumerator();
		try
		{
			if (!enumerator.MoveNext())
			{
				return string.Format(CultureInfo.CurrentCulture, "'{0}' without Message attribute.", new object[1] { GetType().FullName });
			}
			return enumerator.Current.Name;
		}
		finally
		{
			enumerator.Dispose();
		}
	}

	internal abstract void Process(Session session);
}
