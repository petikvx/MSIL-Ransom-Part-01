using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

internal sealed class Class13
{
	private static object object_0;

	private static BinaryReader binaryReader_0;

	private static MemoryStream memoryStream_0;

	private static BinaryWriter binaryWriter_0;

	private static MemoryStream memoryStream_1;

	private static List<object> list_0;

	private static Dictionary<Type, byte> dictionary_0;

	private static ICryptoTransform icryptoTransform_0;

	private static ICryptoTransform icryptoTransform_1;

	static Class13()
	{
		object_0 = RuntimeHelpers.GetObjectValue(new object());
		memoryStream_0 = new MemoryStream();
		binaryReader_0 = new BinaryReader(memoryStream_0);
		memoryStream_1 = new MemoryStream();
		binaryWriter_0 = new BinaryWriter(memoryStream_1);
		list_0 = new List<object>();
		dictionary_0 = new Dictionary<Type, byte>();
		dictionary_0.Add(typeof(bool), 0);
		dictionary_0.Add(typeof(byte), 1);
		dictionary_0.Add(typeof(byte[]), 2);
		dictionary_0.Add(typeof(char), 3);
		dictionary_0.Add(typeof(char[]), 4);
		dictionary_0.Add(typeof(decimal), 5);
		dictionary_0.Add(typeof(double), 6);
		dictionary_0.Add(typeof(int), 7);
		dictionary_0.Add(typeof(long), 8);
		dictionary_0.Add(typeof(sbyte), 9);
		dictionary_0.Add(typeof(short), 10);
		dictionary_0.Add(typeof(float), 11);
		dictionary_0.Add(typeof(string), 12);
		dictionary_0.Add(typeof(uint), 13);
		dictionary_0.Add(typeof(ulong), 14);
		dictionary_0.Add(typeof(ushort), 15);
		dictionary_0.Add(typeof(DateTime), 16);
		dictionary_0.Add(typeof(string[]), 17);
		dictionary_0.Add(typeof(Guid), 18);
		dictionary_0.Add(typeof(Size), 19);
		dictionary_0.Add(typeof(Rectangle), 20);
		dictionary_0.Add(typeof(Version), 21);
	}

	public static void smethod_0(byte[] byte_0)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.BlockSize = 64;
		dESCryptoServiceProvider.Key = byte_0;
		dESCryptoServiceProvider.IV = byte_0;
		icryptoTransform_0 = dESCryptoServiceProvider.CreateEncryptor();
		icryptoTransform_1 = dESCryptoServiceProvider.CreateDecryptor();
	}

	public static byte[] smethod_1(object[] object_1)
	{
		Guid guid_ = default(Guid);
		return smethod_3(bool_0: true, 0, 0, guid_, object_1);
	}

	public static object[] smethod_2(byte[] byte_0)
	{
		return smethod_4(byte_0).object_0;
	}

	public static byte[] smethod_3(bool bool_0, byte byte_0, byte byte_1, Guid guid_0, object[] object_1)
	{
		lock (memoryStream_1)
		{
			binaryWriter_0.Write(bool_0);
			binaryWriter_0.Write(byte_0);
			binaryWriter_0.Write(byte_1);
			Guid guid = default(Guid);
			if (guid_0 == guid)
			{
				binaryWriter_0.Write(value: false);
			}
			else
			{
				binaryWriter_0.Write(value: true);
				binaryWriter_0.Write(guid_0.ToByteArray());
			}
			if (object_1 != null)
			{
				int num = object_1.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Type type = object_1[i].GetType();
					if (type.IsEnum)
					{
						type = Enum.GetUnderlyingType(type);
					}
					byte b = dictionary_0[type];
					binaryWriter_0.Write(b);
					switch (b)
					{
					case 0:
						binaryWriter_0.Write((bool)object_1[i]);
						break;
					case 1:
						binaryWriter_0.Write((byte)object_1[i]);
						break;
					case 2:
						binaryWriter_0.Write(((byte[])object_1[i]).Length);
						binaryWriter_0.Write((byte[])object_1[i]);
						break;
					case 3:
						binaryWriter_0.Write((char)object_1[i]);
						break;
					case 4:
						binaryWriter_0.Write(((char[])object_1[i]).ToString());
						break;
					case 5:
						binaryWriter_0.Write((decimal)object_1[i]);
						break;
					case 6:
						binaryWriter_0.Write((double)object_1[i]);
						break;
					case 7:
						binaryWriter_0.Write((int)object_1[i]);
						break;
					case 8:
						binaryWriter_0.Write((long)object_1[i]);
						break;
					case 9:
						binaryWriter_0.Write((sbyte)object_1[i]);
						break;
					case 10:
						binaryWriter_0.Write((short)object_1[i]);
						break;
					case 11:
						binaryWriter_0.Write((float)object_1[i]);
						break;
					case 12:
						binaryWriter_0.Write((string)object_1[i]);
						break;
					case 13:
						binaryWriter_0.Write((uint)object_1[i]);
						break;
					case 14:
						binaryWriter_0.Write((ulong)object_1[i]);
						break;
					case 15:
						binaryWriter_0.Write((ushort)object_1[i]);
						break;
					case 16:
					{
						BinaryWriter binaryWriter2 = binaryWriter_0;
						DateTime dateTime = (DateTime)object_1[i];
						binaryWriter2.Write(dateTime.ToBinary());
						break;
					}
					case 17:
					{
						binaryWriter_0.Write(((string[])object_1[i]).Length);
						string[] array = (string[])object_1[i];
						foreach (string value in array)
						{
							binaryWriter_0.Write(value);
						}
						break;
					}
					case 18:
					{
						BinaryWriter binaryWriter = binaryWriter_0;
						Guid guid2 = (Guid)object_1[i];
						binaryWriter.Write(guid2.ToByteArray());
						break;
					}
					case 19:
					{
						Size size = (Size)object_1[i];
						binaryWriter_0.Write(size.Width);
						binaryWriter_0.Write(size.Height);
						break;
					}
					case 20:
					{
						Rectangle rectangle = (Rectangle)object_1[i];
						binaryWriter_0.Write(rectangle.X);
						binaryWriter_0.Write(rectangle.Y);
						binaryWriter_0.Write(rectangle.Width);
						binaryWriter_0.Write(rectangle.Height);
						break;
					}
					case 21:
						binaryWriter_0.Write(((Version)object_1[i]).ToString());
						break;
					}
				}
			}
			byte[] array2 = memoryStream_1.ToArray();
			memoryStream_1.SetLength(0L);
			if (bool_0 && array2.Length >= 860)
			{
				binaryWriter_0.Write(bool_0);
				binaryWriter_0.Write(array2.Length - 1);
				DeflateStream deflateStream = new DeflateStream(memoryStream_1, CompressionMode.Compress, leaveOpen: true);
				deflateStream.Write(array2, 1, array2.Length - 1);
				deflateStream.Close();
				array2 = memoryStream_1.ToArray();
				memoryStream_1.SetLength(0L);
			}
			else
			{
				array2[0] = 0;
			}
			byte[] buffer = icryptoTransform_0.TransformFinalBlock(array2, 0, array2.Length);
			binaryWriter_0.Write(buffer);
			array2 = memoryStream_1.ToArray();
			memoryStream_1.SetLength(0L);
			return array2;
		}
	}

	public static GStruct2 smethod_4(byte[] byte_0)
	{
		object obj = object_0;
		ObjectFlowControl.CheckForSyncLockOnValueType(obj);
		Monitor.Enter(obj);
		try
		{
			byte_0 = icryptoTransform_1.TransformFinalBlock(byte_0, 0, byte_0.Length);
			memoryStream_0 = new MemoryStream(byte_0);
			binaryReader_0 = new BinaryReader(memoryStream_0);
			if (binaryReader_0.ReadBoolean())
			{
				int num = binaryReader_0.ReadInt32();
				DeflateStream deflateStream = new DeflateStream(memoryStream_0, CompressionMode.Decompress, leaveOpen: false);
				byte[] array = new byte[num - 1 + 1];
				deflateStream.Read(array, 0, array.Length);
				deflateStream.Close();
				memoryStream_0 = new MemoryStream(array);
				binaryReader_0 = new BinaryReader(memoryStream_0);
			}
			GStruct2 gStruct = default(GStruct2);
			gStruct.byte_0 = binaryReader_0.ReadByte();
			gStruct.byte_1 = binaryReader_0.ReadByte();
			if (binaryReader_0.ReadBoolean())
			{
				ref Guid guid_ = ref gStruct.guid_0;
				guid_ = new Guid(binaryReader_0.ReadBytes(16));
			}
			while (memoryStream_0.Position != memoryStream_0.Length)
			{
				switch (binaryReader_0.ReadByte())
				{
				case 0:
					list_0.Add(binaryReader_0.ReadBoolean());
					break;
				case 1:
					list_0.Add(binaryReader_0.ReadByte());
					break;
				case 2:
					list_0.Add(binaryReader_0.ReadBytes(binaryReader_0.ReadInt32()));
					break;
				case 3:
					list_0.Add(binaryReader_0.ReadChar());
					break;
				case 4:
					list_0.Add(binaryReader_0.ReadString().ToCharArray());
					break;
				case 5:
					list_0.Add(binaryReader_0.ReadDecimal());
					break;
				case 6:
					list_0.Add(binaryReader_0.ReadDouble());
					break;
				case 7:
					list_0.Add(binaryReader_0.ReadInt32());
					break;
				case 8:
					list_0.Add(binaryReader_0.ReadInt64());
					break;
				case 9:
					list_0.Add(binaryReader_0.ReadSByte());
					break;
				case 10:
					list_0.Add(binaryReader_0.ReadInt16());
					break;
				case 11:
					list_0.Add(binaryReader_0.ReadSingle());
					break;
				case 12:
					list_0.Add(binaryReader_0.ReadString());
					break;
				case 13:
					list_0.Add(binaryReader_0.ReadUInt32());
					break;
				case 14:
					list_0.Add(binaryReader_0.ReadUInt64());
					break;
				case 15:
					list_0.Add(binaryReader_0.ReadUInt16());
					break;
				case 16:
					list_0.Add(DateTime.FromBinary(binaryReader_0.ReadInt64()));
					break;
				case 17:
				{
					string[] array2 = new string[binaryReader_0.ReadInt32() - 1 + 1];
					int num2 = array2.Length - 1;
					for (int i = 0; i <= num2; i++)
					{
						array2[i] = binaryReader_0.ReadString();
					}
					list_0.Add(array2);
					break;
				}
				case 18:
				{
					List<object> list3 = list_0;
					Guid guid = new Guid(binaryReader_0.ReadBytes(16));
					list3.Add(guid);
					break;
				}
				case 19:
				{
					List<object> list2 = list_0;
					Size size = new Size(binaryReader_0.ReadInt32(), binaryReader_0.ReadInt32());
					list2.Add(size);
					break;
				}
				case 20:
				{
					List<object> list = list_0;
					Rectangle rectangle = new Rectangle(binaryReader_0.ReadInt32(), binaryReader_0.ReadInt32(), binaryReader_0.ReadInt32(), binaryReader_0.ReadInt32());
					list.Add(rectangle);
					break;
				}
				case 21:
					list_0.Add(new Version(binaryReader_0.ReadString()));
					break;
				}
			}
			gStruct.object_0 = list_0.ToArray();
			GStruct2 result = gStruct;
			list_0.Clear();
			binaryReader_0.Close();
			return result;
		}
		finally
		{
			Monitor.Exit(obj);
		}
	}
}
