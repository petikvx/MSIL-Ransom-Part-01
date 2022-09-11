using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

public class ChainPolicyType
{
	public static string SafeThreadHandle(string NodeKeyValueEnumerator, int NetWebProxyFinder)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream("0x90");
		if (stream == null)
		{
			return null;
		}
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		byte[] bytes = Encoding.ASCII.GetBytes(NetWebProxyFinder.ToString());
		MemoryStream input = new MemoryStream(array);
		BinaryReader binaryReader = new BinaryReader(input, Encoding.UTF8);
		List<object> list = new List<object>();
		byte b = 0;
		int num = binaryReader.ReadInt32();
		for (int i = 0; i <= num - 1; i++)
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
		object[] array2 = list.ToArray();
		byte[] array3 = Convert.FromBase64String((string)array2[(object)NodeKeyValueEnumerator]);
		int num2 = 11;
		int num3 = 13;
		int num4 = 257;
		for (int j = 0; j < bytes.Length; j++)
		{
			num4 += num4 % (bytes[j] + 1);
		}
		byte[] array4 = new byte[array3.Length];
		for (int j = 0; j < array3.Length; j++)
		{
			num4 = bytes[j % bytes.Length] + num4;
			num2 = (num4 + 5) * (num2 & 0xFF) + (num2 >> 8);
			num3 = (num4 + 7) * (num3 & 0xFF) + (num3 >> 8);
			num4 = ((num2 << 8) + num3) & 0xFF;
			array4[j] = (byte)(array3[j] ^ (byte)num4);
		}
		return Encoding.ASCII.GetString(array4);
	}
}
