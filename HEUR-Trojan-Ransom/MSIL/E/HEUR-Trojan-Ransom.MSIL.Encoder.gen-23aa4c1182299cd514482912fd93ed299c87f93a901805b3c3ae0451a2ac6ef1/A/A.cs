using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace A;

internal sealed class A
{
	private static readonly object m_D;

	private static readonly int m_D;

	private static readonly int m_Y;

	private static readonly MemoryStream m_D;

	private static readonly MemoryStream m_Y;

	private static readonly byte m_D;

	static A()
	{
		A.m_D = YY.D;
		A.m_Y = YY.D;
		A.m_D = int.MaxValue;
		A.m_Y = int.MinValue;
		A.m_D = new MemoryStream(0);
		A.m_Y = new MemoryStream(0);
		A.m_D = new object();
	}

	private static string D(Assembly P_0)
	{
		string text = P_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] D(Assembly P_0)
	{
		try
		{
			string fullName = P_0.FullName;
			int num = fullName.IndexOf("PublicKeyToken=");
			if (num < 0)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				num = fullName.IndexOf("publickeytoken=");
			}
			if (num < 0)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						break;
					default:
						return G.D;
					}
				}
			}
			num += 15;
			if (fullName[num] != 'n')
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (fullName[num] != 'N')
				{
					string s = fullName.Substring(num, 16);
					long value = long.Parse(s, NumberStyles.HexNumber);
					byte[] bytes = BitConverter.GetBytes(value);
					Array.Reverse((Array)bytes);
					return bytes;
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			return G.D;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] D(Stream P_0)
	{
		lock (A.m_D)
		{
			return Y(97L, P_0);
		}
	}

	internal static byte[] D(long P_0, Stream P_1)
	{
		try
		{
			return D(P_1);
		}
		catch (HostProtectionException)
		{
			return Y(97L, P_1);
		}
	}

	internal static byte[] Y(long P_0, Stream P_1)
	{
		Stream stream = P_1;
		MemoryStream memoryStream = YY.D;
		for (int i = 1; i < 4; i++)
		{
			P_1.ReadByte();
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			ushort num = (ushort)P_1.ReadByte();
			num = (ushort)(~num);
			if ((num & 2u) != 0)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = J.D(8);
				P_1.Read(array, 0, 8);
				dESCryptoServiceProvider.IV = array;
				byte[] array2 = J.D(8);
				P_1.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				int num2 = 0;
				while (true)
				{
					if (num2 < (int)(nuint)E.D(array3))
					{
						if (array3[num2] != 0)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							flag = false;
							break;
						}
						num2++;
						continue;
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					break;
				}
				if (flag)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					array2 = A.D(Assembly.GetExecutingAssembly());
				}
				dESCryptoServiceProvider.Key = array2;
				if (A.m_D == null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (A.m_D == int.MaxValue)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						A.m_D.Capacity = (int)P_1.Length;
					}
					else
					{
						A.m_D.Capacity = A.m_D;
					}
				}
				A.m_D.Position = 0L;
				ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				int inputBlockSize = cryptoTransform.InputBlockSize;
				_ = cryptoTransform.OutputBlockSize;
				byte[] array4 = J.D(cryptoTransform.OutputBlockSize);
				byte[] array5 = J.D(cryptoTransform.InputBlockSize);
				int j;
				for (j = (int)P_1.Position; j + inputBlockSize < P_1.Length; j += inputBlockSize)
				{
					P_1.Read(array5, 0, inputBlockSize);
					int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
					A.m_D.Write(array4, 0, count);
				}
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				P_1.Read(array5, 0, (int)(P_1.Length - j));
				byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(P_1.Length - j));
				A.m_D.Write(array6, 0, (int)(nuint)E.D(array6));
				stream = A.m_D;
				stream.Position = 0L;
				memoryStream = A.m_D;
			}
			if ((num & 8u) != 0)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (A.m_Y == null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (A.m_Y == int.MinValue)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						A.m_Y.Capacity = (int)stream.Length * 2;
					}
					else
					{
						A.m_Y.Capacity = A.m_Y;
					}
				}
				A.m_Y.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer = J.D(num3);
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer, 0, num3);
					if (num4 <= 0)
					{
						continue;
					}
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					A.m_Y.Write(buffer, 0, num4);
				}
				while (num4 >= num3);
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				memoryStream = A.m_Y;
			}
			if (memoryStream != null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						break;
					default:
						return memoryStream.ToArray();
					}
				}
			}
			byte[] array7 = J.D((int)checked((nint)unchecked(P_1.Length - P_1.Position)));
			P_1.Read(array7, 0, (int)(nuint)E.D(array7));
			return array7;
		}
	}
}
