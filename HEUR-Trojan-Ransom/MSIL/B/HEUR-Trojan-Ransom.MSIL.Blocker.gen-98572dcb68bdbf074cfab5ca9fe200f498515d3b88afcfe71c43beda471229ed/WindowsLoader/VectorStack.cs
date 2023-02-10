using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace WindowsLoader;

internal class VectorStack
{
	private static readonly object idEnabled;

	private static readonly int idEnabled;

	private static readonly int nextUri;

	private static readonly MemoryStream idEnabled;

	private static readonly MemoryStream nextUri;

	private static readonly byte idEnabled;

	static VectorStack()
	{
		VectorStack.idEnabled = null;
		nextUri = null;
		VectorStack.idEnabled = int.MaxValue;
		VectorStack.nextUri = int.MinValue;
		VectorStack.idEnabled = EditorProvider.RemovePane(0);
		nextUri = EditorProvider.RemovePane(0);
		VectorStack.idEnabled = OutlineResolver.RemovePane();
	}

	private static string RemovePane(Assembly idEnabled)
	{
		string result = StoreTree.RemovePane(idEnabled);
		int num = NetworkEditor.RemovePane(result, ',');
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
			result = PathQueue.RemovePane(result, 0, num);
		}
		return result;
	}

	private static byte[] RemovePane(Assembly idEnabled)
	{
		try
		{
			string text = StoreTree.RemovePane(idEnabled);
			int num = DirectoryProvider.RemovePane(text, "PublicKeyToken=");
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
				num = DirectoryProvider.RemovePane(text, "publickeytoken=");
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
						return null;
					}
				}
			}
			num += 15;
			if (TreeNodeLoader.RemovePane(text, num) != 'n')
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
				if (TreeNodeLoader.RemovePane(text, num) != 'N')
				{
					string text2 = PathQueue.RemovePane(text, num, 16);
					long num2 = ActivityEventArgs.RemovePane(text2, NumberStyles.HexNumber);
					byte[] result = TreeNodeConverter.RemovePane(num2);
					VectorQueue.RemovePane(result);
					return result;
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
			}
			return null;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] RemovePane(Stream idEnabled)
	{
		object obj;
		OptionsInvoker.RemovePane(obj = VectorStack.idEnabled);
		try
		{
			return Open(97L, idEnabled);
		}
		finally
		{
			BuilderList.RemovePane(obj);
		}
	}

	internal static byte[] RemovePane(long idEnabled, Stream nextUri)
	{
		try
		{
			return RemovePane(nextUri);
		}
		catch (HostProtectionException)
		{
			return Open(97L, nextUri);
		}
	}

	internal static byte[] Open(long idEnabled, Stream nextUri)
	{
		Stream stream = nextUri;
		MemoryStream memoryStream = null;
		ushort num = (ushort)QueueLayout.RemovePane(nextUri);
		num = (ushort)(~num);
		for (int i = 1; i < 3; i++)
		{
			QueueLayout.RemovePane(nextUri);
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
			if ((num & 2u) != 0)
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
				DESCryptoServiceProvider dESCryptoServiceProvider = ComponentTable.RemovePane();
				byte[] array = new byte[8];
				BitmapFactory.RemovePane(nextUri, array, 0, 8);
				QueueType.RemovePane(dESCryptoServiceProvider, array);
				byte[] array2 = new byte[8];
				BitmapFactory.RemovePane(nextUri, array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				int num2 = 0;
				while (true)
				{
					if (num2 < array3.Length)
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
						switch (2)
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
					array2 = VectorStack.RemovePane(Window.RemovePane());
				}
				CommandList.RemovePane(dESCryptoServiceProvider, array2);
				if (VectorStack.idEnabled == null)
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
					if (VectorStack.idEnabled == int.MaxValue)
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
						ControlLayout.RemovePane(VectorStack.idEnabled, (int)SelectionEventArgs.RemovePane(nextUri));
					}
					else
					{
						ControlLayout.RemovePane(VectorStack.idEnabled, VectorStack.idEnabled);
					}
				}
				DatabaseType.RemovePane(VectorStack.idEnabled, 0L);
				ICryptoTransform cryptoTransform = BookmarkStream.RemovePane(dESCryptoServiceProvider);
				int num3 = MethodInvoker.RemovePane(cryptoTransform);
				MenuAttribute.RemovePane(cryptoTransform);
				byte[] filterCache = new byte[MenuAttribute.RemovePane(cryptoTransform)];
				byte[] array4 = new byte[MethodInvoker.RemovePane(cryptoTransform)];
				int j;
				for (j = (int)ActivityDictionary.RemovePane(nextUri); j + num3 < SelectionEventArgs.RemovePane(nextUri); j += num3)
				{
					BitmapFactory.RemovePane(nextUri, array4, 0, num3);
					int parentFont = ActionScope.RemovePane(cryptoTransform, array4, 0, num3, filterCache, 0);
					ActivityLoader.RemovePane(VectorStack.idEnabled, filterCache, 0, parentFont);
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				BitmapFactory.RemovePane(nextUri, array4, 0, (int)(SelectionEventArgs.RemovePane(nextUri) - j));
				byte[] array5 = FunctionAttribute.RemovePane(cryptoTransform, array4, 0, (int)(SelectionEventArgs.RemovePane(nextUri) - j));
				ActivityLoader.RemovePane(VectorStack.idEnabled, array5, 0, array5.Length);
				stream = VectorStack.idEnabled;
				DatabaseType.RemovePane(stream, 0L);
				memoryStream = VectorStack.idEnabled;
			}
			if ((num & 8u) != 0)
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
				try
				{
					if (VectorStack.nextUri == null)
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
						if (VectorStack.nextUri == int.MinValue)
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
							ControlLayout.RemovePane(VectorStack.nextUri, (int)SelectionEventArgs.RemovePane(stream) * 2);
						}
						else
						{
							ControlLayout.RemovePane(VectorStack.nextUri, VectorStack.nextUri);
						}
					}
					DatabaseType.RemovePane(VectorStack.nextUri, 0L);
					DeflateStream deflateStream = MenuLayout.RemovePane(stream, CompressionMode.Decompress);
					int num4 = 1000;
					byte[] array6 = new byte[num4];
					int num5;
					do
					{
						num5 = BitmapFactory.RemovePane(deflateStream, array6, 0, num4);
						if (num5 <= 0)
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
						ActivityLoader.RemovePane(VectorStack.nextUri, array6, 0, num5);
					}
					while (num5 >= num4);
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						memoryStream = VectorStack.nextUri;
						break;
					}
				}
				catch (Exception)
				{
				}
			}
			if (memoryStream != null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						break;
					default:
						return FileInvoker.RemovePane(memoryStream);
					}
				}
			}
			byte[] array7 = new byte[SelectionEventArgs.RemovePane(nextUri) - ActivityDictionary.RemovePane(nextUri)];
			BitmapFactory.RemovePane(nextUri, array7, 0, array7.Length);
			return array7;
		}
	}
}
