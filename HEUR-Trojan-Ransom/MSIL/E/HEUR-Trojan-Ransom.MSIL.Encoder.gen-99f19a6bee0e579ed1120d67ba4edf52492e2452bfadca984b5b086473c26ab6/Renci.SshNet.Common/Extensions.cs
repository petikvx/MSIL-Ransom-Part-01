using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Messages;

namespace Renci.SshNet.Common;

internal static class Extensions
{
	public static bool IsNullOrWhiteSpace(this string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return true;
		}
		int num = 0;
		while (true)
		{
			if (num < value.Length)
			{
				if (!char.IsWhiteSpace(value[num]))
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

	internal static byte[] ToArray(this ServiceName serviceName)
	{
		return serviceName switch
		{
			ServiceName.Connection => SshData.Ascii.GetBytes("ssh-connection"), 
			ServiceName.UserAuthentication => SshData.Ascii.GetBytes("ssh-userauth"), 
			_ => throw new NotSupportedException($"Service name '{serviceName}' is not supported."), 
		};
	}

	internal static ServiceName ToServiceName(this byte[] data)
	{
		string @string = SshData.Ascii.GetString(data, 0, data.Length);
		if (!(@string == "ssh-userauth"))
		{
			if (!(@string == "ssh-connection"))
			{
				throw new NotSupportedException($"Service name '{@string}' is not supported.");
			}
			return ServiceName.Connection;
		}
		return ServiceName.UserAuthentication;
	}

	internal static BigInteger ToBigInteger(this byte[] data)
	{
		byte[] array = new byte[data.Length];
		Buffer.BlockCopy(data, 0, array, 0, data.Length);
		return new BigInteger(array.Reverse());
	}

	internal static T[] Reverse<T>(this T[] array)
	{
		Array.Reverse((Array)array);
		return array;
	}

	internal static void DebugPrint(this IEnumerable<byte> bytes)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte @byte in bytes)
		{
			stringBuilder.AppendFormat(CultureInfo.CurrentCulture, "0x{0:x2}, ", new object[1] { @byte });
		}
	}

	internal static T CreateInstance<T>(this Type type) where T : class
	{
		if (type == null)
		{
			return null;
		}
		return Activator.CreateInstance(type) as T;
	}

	internal static void ValidatePort(this uint value, string argument)
	{
		if (value > 65535)
		{
			throw new ArgumentOutOfRangeException(argument, string.Format(CultureInfo.InvariantCulture, "Specified value cannot be greater than {0}.", new object[1] { 65535 }));
		}
	}

	internal static void ValidatePort(this int value, string argument)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException(argument, string.Format(CultureInfo.InvariantCulture, "Specified value cannot be less than {0}.", new object[1] { 0 }));
		}
		if (value > 65535)
		{
			throw new ArgumentOutOfRangeException(argument, string.Format(CultureInfo.InvariantCulture, "Specified value cannot be greater than {0}.", new object[1] { 65535 }));
		}
	}

	public static byte[] Take(this byte[] value, int offset, int count)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (count == 0)
		{
			return Array<byte>.Empty;
		}
		if (offset == 0 && value.Length == count)
		{
			return value;
		}
		byte[] array = new byte[count];
		Buffer.BlockCopy(value, offset, array, 0, count);
		return array;
	}

	public static byte[] Take(this byte[] value, int count)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (count == 0)
		{
			return Array<byte>.Empty;
		}
		if (value.Length == count)
		{
			return value;
		}
		byte[] array = new byte[count];
		Buffer.BlockCopy(value, 0, array, 0, count);
		return array;
	}

	public static bool IsEqualTo(this byte[] left, byte[] right)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		if (left == right)
		{
			return true;
		}
		if (left.Length != right.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < left.Length)
			{
				if (left[num] != right[num])
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

	public static byte[] TrimLeadingZeros(this byte[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = 0;
		while (true)
		{
			if (num < value.Length)
			{
				if (value[num] != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return value;
		}
		if (num == 0)
		{
			return value;
		}
		int num2 = value.Length - num;
		byte[] array = new byte[num2];
		Buffer.BlockCopy(value, num, array, 0, num2);
		return array;
	}

	public static byte[] Concat(this byte[] first, byte[] second)
	{
		if (first != null && first.Length != 0)
		{
			if (second != null && second.Length != 0)
			{
				byte[] array = new byte[first.Length + second.Length];
				Buffer.BlockCopy(first, 0, array, 0, first.Length);
				Buffer.BlockCopy(second, 0, array, first.Length, second.Length);
				return array;
			}
			return first;
		}
		return second;
	}

	internal static bool CanRead(this Socket socket)
	{
		return SocketAbstraction.CanRead(socket);
	}

	internal static bool CanWrite(this Socket socket)
	{
		return SocketAbstraction.CanWrite(socket);
	}

	internal static bool IsConnected(this Socket socket)
	{
		return socket?.Connected ?? false;
	}
}
