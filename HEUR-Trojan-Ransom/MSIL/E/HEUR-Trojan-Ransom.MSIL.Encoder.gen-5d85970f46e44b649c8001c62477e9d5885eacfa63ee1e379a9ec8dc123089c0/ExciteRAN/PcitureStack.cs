using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace ExciteRAN;

internal sealed class PcitureStack
{
	private static readonly object lastHandler;

	private static readonly int urlHeader;

	private static readonly int logCollection;

	private static readonly MemoryStream handlerDisposed;

	private static readonly MemoryStream childLine;

	private static readonly byte colorAvailable;

	static PcitureStack()
	{
		handlerDisposed = PathStack.lastHandler;
		childLine = PathStack.lastHandler;
		urlHeader = int.MaxValue;
		logCollection = int.MinValue;
		handlerDisposed = DatabaseResolver.SaveNetwork(0);
		childLine = DatabaseResolver.SaveNetwork(0);
		lastHandler = ViewTable.SaveNetwork();
	}

	private static string ReplaceDevice(Assembly P_0)
	{
		string text = ImageInvoker.SaveNetwork(P_0);
		int num = PageAttribute.SaveNetwork(text, ',');
		if (num >= 0)
		{
			while (true)
			{
				switch (5)
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
			text = DirectoryList.SaveNetwork(text, 0, num);
		}
		return text;
	}

	private static byte[] FreeDatabase(Assembly P_0)
	{
		try
		{
			string text = ImageInvoker.SaveNetwork(P_0);
			int num = DomainList.SaveNetwork(text, "PublicKeyToken=");
			if (num < 0)
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
				num = DomainList.SaveNetwork(text, "publickeytoken=");
			}
			if (num < 0)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						break;
					default:
						return WindowEventArgs.lastHandler;
					}
				}
			}
			num += 15;
			if (Method.ChangeEditor(text, num) != 'n')
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
				if (Method.ChangeEditor(text, num) != 'N')
				{
					string text2 = DirectoryList.SaveNetwork(text, num, 16);
					long num2 = PathProvider.SaveNetwork(text2, NumberStyles.HexNumber);
					byte[] array = IconHelper.SaveNetwork(num2);
					PluginService.SaveNetwork(array);
					return array;
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
			return WindowEventArgs.lastHandler;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] RegisterComponent(Stream P_0)
	{
		object obj;
		TemplateOptions.SaveNetwork(obj = lastHandler);
		try
		{
			return ReplaceResource(97L, P_0);
		}
		finally
		{
			DialogTable.SaveNetwork(obj);
		}
	}

	internal static byte[] InsertProcess(long P_0, Stream P_1)
	{
		try
		{
			return RegisterComponent(P_1);
		}
		catch
		{
			return ReplaceResource(97L, P_1);
		}
	}

	internal static byte[] ReplaceResource(long P_0, object P_1)
	{
		Stream stream = DialogInfo.ResolveFile(P_1);
		Stream stream2 = stream;
		MemoryStream memoryStream = PathStack.lastHandler;
		for (int i = 1; i < 4; i++)
		{
			WindowResolver.SaveNetwork(stream);
		}
		while (true)
		{
			switch (1)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			ushort num = (ushort)WindowResolver.SaveNetwork(stream);
			num = (ushort)(~num);
			if ((num & 2u) != 0)
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
				DESCryptoServiceProvider dESCryptoServiceProvider = ConditionConverter.SaveNetwork();
				byte[] array = MemoryHelper.ResolveFile(8);
				ResourceLoader.SaveNetwork(stream, array, 0, 8);
				ContextToken.SaveNetwork(dESCryptoServiceProvider, array);
				byte[] array2 = MemoryHelper.ResolveFile(8);
				ResourceLoader.SaveNetwork(stream, array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				int num2 = 0;
				while (true)
				{
					if (num2 < (int)(nuint)ReferenceSerializer.ResolveFile(array3))
					{
						if (array3[num2] != 0)
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
							flag = false;
							break;
						}
						num2++;
						continue;
					}
					while (true)
					{
						switch (7)
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
					array2 = FreeDatabase(TreeNodeList.SaveNetwork());
				}
				ViewLoader.SaveNetwork(dESCryptoServiceProvider, array2);
				if (handlerDisposed == null)
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
					if (urlHeader == int.MaxValue)
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
						PcitureTable.SaveNetwork(handlerDisposed, (int)StubStream.SaveNetwork(stream));
					}
					else
					{
						PcitureTable.SaveNetwork(handlerDisposed, urlHeader);
					}
				}
				RegistryDictionary.SaveNetwork(handlerDisposed, 0L);
				ICryptoTransform cryptoTransform = ProjectTable.SaveNetwork(dESCryptoServiceProvider);
				int num3 = EditorProvider.SaveNetwork(cryptoTransform);
				AssemblyEditor.SaveNetwork(cryptoTransform);
				byte[] array4 = MemoryHelper.ResolveFile(AssemblyEditor.SaveNetwork(cryptoTransform));
				byte[] array5 = MemoryHelper.ResolveFile(EditorProvider.SaveNetwork(cryptoTransform));
				int j;
				for (j = (int)ComponentHelper.SaveNetwork(stream); j + num3 < StubStream.SaveNetwork(stream); j += num3)
				{
					ResourceLoader.SaveNetwork(stream, array5, 0, num3);
					int num4 = ConnectionTree.SaveNetwork(cryptoTransform, array5, 0, num3, array4, 0);
					QueueScope.SaveNetwork(handlerDisposed, array4, 0, num4);
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
				ResourceLoader.SaveNetwork(stream, array5, 0, (int)(StubStream.SaveNetwork(stream) - j));
				byte[] array6 = BitmapInfo.SaveNetwork(cryptoTransform, array5, 0, (int)(StubStream.SaveNetwork(stream) - j));
				QueueScope.SaveNetwork(handlerDisposed, array6, 0, (int)(nuint)ReferenceSerializer.ResolveFile(array6));
				stream2 = handlerDisposed;
				RegistryDictionary.SaveNetwork(stream2, 0L);
				memoryStream = handlerDisposed;
			}
			if ((num & 8u) != 0)
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
				if (childLine == null)
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
					if (logCollection == int.MinValue)
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
						PcitureTable.SaveNetwork(childLine, (int)StubStream.SaveNetwork(stream2) * 2);
					}
					else
					{
						PcitureTable.SaveNetwork(childLine, logCollection);
					}
				}
				RegistryDictionary.SaveNetwork(childLine, 0L);
				DeflateStream deflateStream = TreeNodeConverter.SaveNetwork(stream2, CompressionMode.Decompress);
				int num5 = 1000;
				byte[] array7 = MemoryHelper.ResolveFile(num5);
				int num6;
				do
				{
					num6 = ResourceLoader.SaveNetwork(deflateStream, array7, 0, num5);
					if (num6 <= 0)
					{
						continue;
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
					QueueScope.SaveNetwork(childLine, array7, 0, num6);
				}
				while (num6 >= num5);
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				memoryStream = childLine;
			}
			if (memoryStream != null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						break;
					default:
						return QueueConverter.SaveNetwork(memoryStream);
					}
				}
			}
			byte[] array8 = MemoryHelper.ResolveFile((int)checked((nint)unchecked(StubStream.SaveNetwork(stream) - ComponentHelper.SaveNetwork(stream))));
			ResourceLoader.SaveNetwork(stream, array8, 0, (int)(nuint)ReferenceSerializer.ResolveFile(array8));
			return array8;
		}
	}
}
