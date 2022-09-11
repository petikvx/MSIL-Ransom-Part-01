using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Syn;

internal sealed class Pack
{
	private Dictionary<Type, byte> Table;

	public Pack()
	{
		Table = new Dictionary<Type, byte>();
		Table.Add(typeof(bool), 0);
		Table.Add(typeof(byte), 1);
		Table.Add(typeof(byte[]), 2);
		Table.Add(typeof(char), 3);
		Table.Add(typeof(char[]), 4);
		Table.Add(typeof(decimal), 5);
		Table.Add(typeof(double), 6);
		Table.Add(typeof(int), 7);
		Table.Add(typeof(long), 8);
		Table.Add(typeof(sbyte), 9);
		Table.Add(typeof(short), 10);
		Table.Add(typeof(float), 11);
		Table.Add(typeof(string), 12);
		Table.Add(typeof(uint), 13);
		Table.Add(typeof(ulong), 14);
		Table.Add(typeof(ushort), 15);
		Table.Add(typeof(DateTime), 16);
	}

	public byte[] Serialize(params object[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.UTF8);
		byte b = 0;
		binaryWriter.Write(Convert.ToByte(data.Length));
		checked
		{
			int num = data.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				b = Table[data[i].GetType()];
				binaryWriter.Write(b);
				switch (b)
				{
				case 0:
					binaryWriter.Write((bool)data[i]);
					break;
				case 1:
					binaryWriter.Write((byte)data[i]);
					break;
				case 2:
					binaryWriter.Write(((byte[])data[i]).Length);
					binaryWriter.Write((byte[])data[i]);
					break;
				case 3:
					binaryWriter.Write((char)data[i]);
					break;
				case 4:
					binaryWriter.Write(((char[])data[i]).ToString());
					break;
				case 5:
					binaryWriter.Write((decimal)data[i]);
					break;
				case 6:
					binaryWriter.Write((double)data[i]);
					break;
				case 7:
					binaryWriter.Write((int)data[i]);
					break;
				case 8:
					binaryWriter.Write((long)data[i]);
					break;
				case 9:
					binaryWriter.Write((sbyte)data[i]);
					break;
				case 10:
					binaryWriter.Write((short)data[i]);
					break;
				case 11:
					binaryWriter.Write((float)data[i]);
					break;
				case 12:
					binaryWriter.Write((string)data[i]);
					break;
				case 13:
					binaryWriter.Write((uint)data[i]);
					break;
				case 14:
					binaryWriter.Write((ulong)data[i]);
					break;
				case 15:
					binaryWriter.Write((ushort)data[i]);
					break;
				case 16:
				{
					DateTime dateTime = (DateTime)data[i];
					binaryWriter.Write(dateTime.ToBinary());
					break;
				}
				}
			}
			binaryWriter.Close();
			return memoryStream.ToArray();
		}
	}

	public object[] Deserialize(byte[] data)
	{
		MemoryStream input = new MemoryStream(data);
		BinaryReader binaryReader = new BinaryReader(input, Encoding.UTF8);
		List<object> list = new List<object>();
		byte b = 0;
		byte b2 = binaryReader.ReadByte();
		checked
		{
			int num = unchecked((int)b2) - 1;
			for (int i = 0; i <= num; i++)
			{
				switch (binaryReader.ReadByte())
				{
				case 0:
					list.Add(binaryReader.ReadBoolean());
					break;
				case 1:
					list.Add(binaryReader.ReadByte());
					break;
				case 2:
					list.Add(binaryReader.ReadBytes(binaryReader.ReadInt32()));
					break;
				case 3:
					list.Add(binaryReader.ReadChar());
					break;
				case 4:
					list.Add(binaryReader.ReadString().ToCharArray());
					break;
				case 5:
					list.Add(binaryReader.ReadDecimal());
					break;
				case 6:
					list.Add(binaryReader.ReadDouble());
					break;
				case 7:
					list.Add(binaryReader.ReadInt32());
					break;
				case 8:
					list.Add(binaryReader.ReadInt64());
					break;
				case 9:
					list.Add(binaryReader.ReadSByte());
					break;
				case 10:
					list.Add(binaryReader.ReadInt16());
					break;
				case 11:
					list.Add(binaryReader.ReadSingle());
					break;
				case 12:
					list.Add(binaryReader.ReadString());
					break;
				case 13:
					list.Add(binaryReader.ReadUInt32());
					break;
				case 14:
					list.Add(binaryReader.ReadUInt64());
					break;
				case 15:
					list.Add(binaryReader.ReadUInt16());
					break;
				case 16:
					list.Add(DateTime.FromBinary(binaryReader.ReadInt64()));
					break;
				}
			}
			binaryReader.Close();
			return list.ToArray();
		}
	}
}
