using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace ExciteRAN;

internal class StreamTree
{
	private static readonly object windowPosition;

	private static readonly int parentLog;

	private static readonly int containerToken;

	private static readonly MemoryStream lineHandle;

	private static readonly MemoryStream currentContainer;

	private static readonly byte parentOptions;

	static StreamTree()
	{
		lineHandle = DatabaseSite.windowPosition;
		currentContainer = DatabaseSite.windowPosition;
		parentLog = int.MaxValue;
		containerToken = int.MinValue;
		lineHandle = new MemoryStream(0);
		currentContainer = new MemoryStream(0);
		windowPosition = new object();
	}

	private static string JoinServer(Assembly windowPosition)
	{
		string text = windowPosition.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
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
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] OpenOutline(Assembly windowPosition)
	{
		try
		{
			string fullName = windowPosition.FullName;
			int num = fullName.IndexOf("PublicKeyToken=");
			if (num < 0)
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
					switch (1)
					{
					case 0:
						break;
					default:
						return StreamHelper.windowPosition;
					}
				}
			}
			num += 15;
			if (fullName[num] != 'n')
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
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			return StreamHelper.windowPosition;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] ConnectNetwork(Stream windowPosition)
	{
		lock (StreamTree.windowPosition)
		{
			return EditDialog(97L, windowPosition);
		}
	}

	internal static byte[] SaveFile(long windowPosition, Stream parentLog)
	{
		try
		{
			return ConnectNetwork(parentLog);
		}
		catch
		{
			return EditDialog(97L, parentLog);
		}
	}

	internal static byte[] EditDialog(long windowPosition, object parentLog)
	{
		Stream stream = SolutionResolver.CleanAssistant(parentLog);
		Stream stream2 = stream;
		MemoryStream memoryStream = DatabaseSite.windowPosition;
		for (int i = 1; i < 4; i++)
		{
			stream.ReadByte();
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			ushort num = (ushort)stream.ReadByte();
			num = (ushort)(~num);
			if ((num & 2u) != 0)
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
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = AssistantResolver.CleanAssistant(8);
				stream.Read(array, 0, 8);
				dESCryptoServiceProvider.IV = array;
				byte[] array2 = AssistantResolver.CleanAssistant(8);
				stream.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				int num2 = 0;
				while (true)
				{
					if (num2 < (int)(nuint)RegistryLayout.CleanAssistant(array3))
					{
						if (array3[num2] != 0)
						{
							while (true)
							{
								switch (2)
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
						switch (5)
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
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					array2 = OpenOutline(Assembly.GetExecutingAssembly());
				}
				dESCryptoServiceProvider.Key = array2;
				if (lineHandle == null)
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
					if (StreamTree.parentLog == int.MaxValue)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						lineHandle.Capacity = (int)stream.Length;
					}
					else
					{
						lineHandle.Capacity = StreamTree.parentLog;
					}
				}
				lineHandle.Position = 0L;
				ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				int inputBlockSize = cryptoTransform.InputBlockSize;
				_ = cryptoTransform.OutputBlockSize;
				byte[] array4 = AssistantResolver.CleanAssistant(cryptoTransform.OutputBlockSize);
				byte[] array5 = AssistantResolver.CleanAssistant(cryptoTransform.InputBlockSize);
				int j;
				for (j = (int)stream.Position; j + inputBlockSize < stream.Length; j += inputBlockSize)
				{
					stream.Read(array5, 0, inputBlockSize);
					int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
					lineHandle.Write(array4, 0, count);
				}
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				stream.Read(array5, 0, (int)(stream.Length - j));
				byte[] buffer = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream.Length - j));
				lineHandle.Write(buffer, 0, (int)(nuint)RegistryLayout.CleanAssistant(buffer));
				stream2 = lineHandle;
				stream2.Position = 0L;
				memoryStream = lineHandle;
			}
			if ((num & 8u) != 0)
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
				if (currentContainer == null)
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
					if (containerToken == int.MinValue)
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
						currentContainer.Capacity = (int)stream2.Length * 2;
					}
					else
					{
						currentContainer.Capacity = containerToken;
					}
				}
				currentContainer.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer2 = AssistantResolver.CleanAssistant(num3);
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer2, 0, num3);
					if (num4 <= 0)
					{
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
					currentContainer.Write(buffer2, 0, num4);
				}
				while (num4 >= num3);
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				memoryStream = currentContainer;
			}
			if (memoryStream != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						break;
					default:
						return memoryStream.ToArray();
					}
				}
			}
			byte[] array6 = AssistantResolver.CleanAssistant((int)checked((nint)unchecked(stream.Length - stream.Position)));
			stream.Read(array6, 0, (int)(nuint)RegistryLayout.CleanAssistant(array6));
			return array6;
		}
	}
}
