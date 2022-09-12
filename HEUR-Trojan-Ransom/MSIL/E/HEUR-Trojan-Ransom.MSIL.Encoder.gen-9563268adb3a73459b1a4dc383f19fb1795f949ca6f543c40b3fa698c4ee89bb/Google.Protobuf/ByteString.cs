using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Protobuf;

public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString>, IEnumerable
{
	internal static class Unsafe
	{
		internal static ByteString FromBytes(byte[] bytes)
		{
			return new ByteString(bytes);
		}

		internal static byte[] GetBuffer(ByteString bytes)
		{
			return bytes.bytes;
		}
	}

	private static readonly ByteString empty = new ByteString(new byte[0]);

	private readonly byte[] bytes;

	public static ByteString Empty => empty;

	public int Length => bytes.Length;

	public bool IsEmpty => Length == 0;

	public byte this[int index] => bytes[index];

	internal static ByteString AttachBytes(byte[] bytes)
	{
		return new ByteString(bytes);
	}

	private ByteString(byte[] bytes)
	{
		this.bytes = bytes;
	}

	public byte[] ToByteArray()
	{
		return (byte[])bytes.Clone();
	}

	public string ToBase64()
	{
		return Convert.ToBase64String(bytes);
	}

	public static ByteString FromBase64(string bytes)
	{
		if (!(bytes == ""))
		{
			return new ByteString(Convert.FromBase64String(bytes));
		}
		return Empty;
	}

	public static ByteString FromStream(Stream stream)
	{
		ProtoPreconditions.CheckNotNull(stream, "stream");
		MemoryStream memoryStream = new MemoryStream(stream.CanSeek ? checked((int)(stream.Length - stream.Position)) : 0);
		stream.CopyTo(memoryStream);
		return AttachBytes((memoryStream.Length == memoryStream.Capacity) ? memoryStream.GetBuffer() : memoryStream.ToArray());
	}

	public static async Task<ByteString> FromStreamAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		ProtoPreconditions.CheckNotNull(stream, "stream");
		int capacity = (stream.CanSeek ? checked((int)(stream.Length - stream.Position)) : 0);
		MemoryStream memoryStream = new MemoryStream(capacity);
		await stream.CopyToAsync(memoryStream, 81920, cancellationToken);
		return AttachBytes((memoryStream.Length == memoryStream.Capacity) ? memoryStream.GetBuffer() : memoryStream.ToArray());
	}

	public static ByteString CopyFrom(params byte[] bytes)
	{
		return new ByteString((byte[])bytes.Clone());
	}

	public static ByteString CopyFrom(byte[] bytes, int offset, int count)
	{
		byte[] dst = new byte[count];
		ByteArray.Copy(bytes, offset, dst, 0, count);
		return new ByteString(dst);
	}

	public static ByteString CopyFrom(string text, Encoding encoding)
	{
		return new ByteString(encoding.GetBytes(text));
	}

	public static ByteString CopyFromUtf8(string text)
	{
		return CopyFrom(text, Encoding.UTF8);
	}

	public string ToString(Encoding encoding)
	{
		return encoding.GetString(bytes, 0, bytes.Length);
	}

	public string ToStringUtf8()
	{
		return ToString(Encoding.UTF8);
	}

	public IEnumerator<byte> GetEnumerator()
	{
		return ((IEnumerable<byte>)bytes).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public CodedInputStream CreateCodedInput()
	{
		return new CodedInputStream(bytes);
	}

	public static bool operator ==(ByteString lhs, ByteString rhs)
	{
		if ((object)lhs == rhs)
		{
			return true;
		}
		if ((object)lhs != null && (object)rhs != null)
		{
			if (lhs.bytes.Length != rhs.bytes.Length)
			{
				return false;
			}
			int num = 0;
			while (true)
			{
				if (num < lhs.Length)
				{
					if (rhs.bytes[num] != lhs.bytes[num])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static bool operator !=(ByteString lhs, ByteString rhs)
	{
		return !(lhs == rhs);
	}

	public override bool Equals(object obj)
	{
		return this == obj as ByteString;
	}

	public override int GetHashCode()
	{
		int num = 23;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			num = num * 31 + b;
		}
		return num;
	}

	public bool Equals(ByteString other)
	{
		return this == other;
	}

	internal void WriteRawBytesTo(CodedOutputStream outputStream)
	{
		outputStream.WriteRawBytes(bytes, 0, bytes.Length);
	}

	public void CopyTo(byte[] array, int position)
	{
		ByteArray.Copy(bytes, 0, array, position, bytes.Length);
	}

	public void WriteTo(Stream outputStream)
	{
		outputStream.Write(bytes, 0, bytes.Length);
	}
}
