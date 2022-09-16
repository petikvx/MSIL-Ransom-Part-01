using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ns18;

public class GClass18 : IEnumerable
{
	private string string_0;

	private string string_1;

	private object object_0;

	private GEnum5 genum5_0;

	private GClass18 gclass18_0;

	private List<GClass18> list_0 = new List<GClass18>();

	private GClass17 gclass17_0;

	public string String_0
	{
		get
		{
			return method_24();
		}
		set
		{
			method_23(value);
		}
	}

	public long Int64_0
	{
		get
		{
			return method_13();
		}
		set
		{
			method_10(value);
		}
	}

	public double Double_0
	{
		get
		{
			return method_14();
		}
		set
		{
			method_27(value);
		}
	}

	public GClass17 GClass17_0
	{
		get
		{
			lock (this)
			{
				if (gclass17_0 == null)
				{
					gclass17_0 = new GClass17(this, list_0);
				}
			}
			return gclass17_0;
		}
	}

	public GEnum5 GEnum5_0 => genum5_0;

	private void method_0(string string_2)
	{
		string_0 = string_2;
		string_1 = string_0.ToLower();
	}

	private void method_1()
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			list_0[i].method_1();
		}
		list_0.Clear();
	}

	private GClass18 method_2()
	{
		GClass18 gClass = new GClass18();
		gClass.gclass18_0 = this;
		list_0.Add(gClass);
		return gClass;
	}

	private int method_3(string string_2)
	{
		int num = -1;
		int result = -1;
		string text = string_2.ToLower();
		foreach (GClass18 item in list_0)
		{
			num++;
			if (text.Equals(item.string_1))
			{
				return num;
			}
		}
		return result;
	}

	public GClass18 method_4(string string_2)
	{
		int num = method_3(string_2);
		if (num == -1)
		{
			return null;
		}
		return list_0[num];
	}

	private GClass18 method_5()
	{
		if (genum5_0 != GEnum5.const_2)
		{
			method_1();
			genum5_0 = GEnum5.const_2;
		}
		return method_2();
	}

	private GClass18 method_6()
	{
		if (genum5_0 != GEnum5.const_3)
		{
			method_1();
			genum5_0 = GEnum5.const_3;
		}
		return method_2();
	}

	public GClass18 method_7()
	{
		return method_6();
	}

	private void method_8(Stream stream_0)
	{
		int count = list_0.Count;
		if (count <= 15)
		{
			byte value = (byte)(128 + (byte)count);
			stream_0.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 222;
			stream_0.WriteByte(222);
			byte[] array = GClass15.smethod_4(BitConverter.GetBytes((short)count));
			stream_0.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 223;
			stream_0.WriteByte(223);
			byte[] array = GClass15.smethod_4(BitConverter.GetBytes(count));
			stream_0.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			Class87.smethod_1(stream_0, list_0[i].string_0);
			list_0[i].method_32(stream_0);
		}
	}

	private void method_9(Stream stream_0)
	{
		int count = list_0.Count;
		if (count <= 15)
		{
			byte value = (byte)(144 + (byte)count);
			stream_0.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 220;
			stream_0.WriteByte(220);
			byte[] array = GClass15.smethod_4(BitConverter.GetBytes((short)count));
			stream_0.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 221;
			stream_0.WriteByte(221);
			byte[] array = GClass15.smethod_4(BitConverter.GetBytes(count));
			stream_0.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			list_0[i].method_32(stream_0);
		}
	}

	public void method_10(long long_0)
	{
		object_0 = long_0;
		genum5_0 = GEnum5.const_5;
	}

	public void method_11(ulong ulong_0)
	{
		object_0 = ulong_0;
		genum5_0 = GEnum5.const_6;
	}

	public ulong method_12()
	{
		return genum5_0 switch
		{
			GEnum5.const_4 => ulong.Parse(object_0.ToString()!.Trim()), 
			GEnum5.const_5 => Convert.ToUInt64((long)object_0), 
			GEnum5.const_6 => (ulong)object_0, 
			GEnum5.const_8 => Convert.ToUInt64((double)object_0), 
			GEnum5.const_9 => Convert.ToUInt64((float)object_0), 
			GEnum5.const_10 => Convert.ToUInt64((DateTime)object_0), 
			_ => 0uL, 
		};
	}

	public long method_13()
	{
		return genum5_0 switch
		{
			GEnum5.const_4 => long.Parse(object_0.ToString()!.Trim()), 
			GEnum5.const_5 => (long)object_0, 
			GEnum5.const_6 => Convert.ToInt64((long)object_0), 
			GEnum5.const_8 => Convert.ToInt64((double)object_0), 
			GEnum5.const_9 => Convert.ToInt64((float)object_0), 
			GEnum5.const_10 => Convert.ToInt64((DateTime)object_0), 
			_ => 0L, 
		};
	}

	public double method_14()
	{
		return genum5_0 switch
		{
			GEnum5.const_4 => double.Parse((string)object_0), 
			GEnum5.const_5 => Convert.ToDouble((long)object_0), 
			GEnum5.const_8 => (double)object_0, 
			GEnum5.const_9 => (float)object_0, 
			GEnum5.const_10 => Convert.ToInt64((DateTime)object_0), 
			_ => 0.0, 
		};
	}

	public void method_15(byte[] byte_0)
	{
		object_0 = byte_0;
		genum5_0 = GEnum5.const_11;
	}

	public byte[] method_16()
	{
		return genum5_0 switch
		{
			GEnum5.const_4 => GClass15.smethod_0(object_0.ToString()), 
			GEnum5.const_5 => BitConverter.GetBytes((long)object_0), 
			GEnum5.const_8 => BitConverter.GetBytes((double)object_0), 
			GEnum5.const_9 => BitConverter.GetBytes((float)object_0), 
			GEnum5.const_10 => BitConverter.GetBytes(((DateTime)object_0).ToBinary()), 
			GEnum5.const_11 => (byte[])object_0, 
			_ => new byte[0], 
		};
	}

	public void method_17(string string_2, string string_3)
	{
		GClass18 gClass = method_6();
		gClass.string_0 = string_2;
		gClass.method_23(string_3);
	}

	public void method_18(string string_2, int int_0)
	{
		GClass18 gClass = method_6();
		gClass.string_0 = string_2;
		gClass.method_10(int_0);
	}

	public bool method_19(string string_2)
	{
		if (File.Exists(string_2))
		{
			byte[] array = null;
			FileStream fileStream = new FileStream(string_2, FileMode.Open, FileAccess.Read, FileShare.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Close();
			fileStream.Dispose();
			method_15(array);
			return true;
		}
		return false;
	}

	public bool method_20(string string_2)
	{
		if (object_0 != null)
		{
			FileStream fileStream = new FileStream(string_2, FileMode.Append);
			fileStream.Write((byte[])object_0, 0, ((byte[])object_0).Length);
			fileStream.Close();
			fileStream.Dispose();
			return true;
		}
		return false;
	}

	public GClass18 method_21(string string_2)
	{
		GClass18 gClass = this;
		string[] array = string_2.Trim().Split('.', '/', '\\');
		string text = null;
		if (array.Length == 0)
		{
			return null;
		}
		if (array.Length > 1)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				text = array[i];
				GClass18 gClass2 = gClass.method_4(text);
				if (gClass2 == null)
				{
					gClass = gClass.method_5();
					gClass.method_0(text);
				}
				else
				{
					gClass = gClass2;
				}
			}
		}
		text = array[^1];
		int num = gClass.method_3(text);
		if (num > -1)
		{
			return gClass.list_0[num];
		}
		gClass = gClass.method_5();
		gClass.method_0(text);
		return gClass;
	}

	public void method_22()
	{
		method_1();
		object_0 = null;
		genum5_0 = GEnum5.const_1;
	}

	public void method_23(string string_2)
	{
		object_0 = string_2;
		genum5_0 = GEnum5.const_4;
	}

	public string method_24()
	{
		if (object_0 == null)
		{
			return "";
		}
		return object_0.ToString();
	}

	public void method_25(bool bool_0)
	{
		genum5_0 = GEnum5.const_7;
		object_0 = bool_0;
	}

	public void method_26(float float_0)
	{
		genum5_0 = GEnum5.const_9;
		object_0 = float_0;
	}

	public void method_27(double double_0)
	{
		genum5_0 = GEnum5.const_8;
		object_0 = double_0;
	}

	public void method_28(byte[] byte_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte_0 = GClass19.smethod_0(byte_0);
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Position = 0L;
		method_30(memoryStream);
	}

	public void method_29(string string_2)
	{
		FileStream fileStream = new FileStream(string_2, FileMode.Open);
		method_30(fileStream);
		fileStream.Dispose();
	}

	public void method_30(Stream stream_0)
	{
		byte b = (byte)stream_0.ReadByte();
		byte[] array = null;
		int num = 0;
		int num2 = 0;
		if (b <= 127)
		{
			method_10(b);
			return;
		}
		if (b >= 128 && b <= 143)
		{
			method_1();
			genum5_0 = GEnum5.const_2;
			num = b - 128;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass18 gClass = method_2();
				gClass.method_0(Class86.smethod_1(stream_0));
				gClass.method_30(stream_0);
			}
			return;
		}
		if (b >= 144 && b <= 159)
		{
			method_1();
			genum5_0 = GEnum5.const_3;
			num = b - 144;
			for (num2 = 0; num2 < num; num2++)
			{
				method_2().method_30(stream_0);
			}
			return;
		}
		if (b >= 160 && b <= 191)
		{
			num = b - 160;
			method_23(Class86.smethod_0(stream_0, num));
			return;
		}
		if (b >= 224 && b <= byte.MaxValue)
		{
			method_10((sbyte)b);
			return;
		}
		switch (b)
		{
		case 192:
			method_22();
			return;
		case 193:
			throw new Exception("(never used) type $c1");
		case 194:
			method_25(bool_0: false);
			return;
		case 195:
			method_25(bool_0: true);
			return;
		case 196:
			num = stream_0.ReadByte();
			array = new byte[num];
			stream_0.Read(array, 0, num);
			method_15(array);
			return;
		case 197:
			array = new byte[2];
			stream_0.Read(array, 0, 2);
			array = GClass15.smethod_4(array);
			num = BitConverter.ToUInt16(array, 0);
			array = new byte[num];
			stream_0.Read(array, 0, num);
			method_15(array);
			return;
		case 198:
			array = new byte[4];
			stream_0.Read(array, 0, 4);
			array = GClass15.smethod_4(array);
			num = BitConverter.ToInt32(array, 0);
			array = new byte[num];
			stream_0.Read(array, 0, num);
			method_15(array);
			return;
		case 202:
			array = new byte[4];
			stream_0.Read(array, 0, 4);
			array = GClass15.smethod_4(array);
			method_26(BitConverter.ToSingle(array, 0));
			return;
		case 203:
			array = new byte[8];
			stream_0.Read(array, 0, 8);
			array = GClass15.smethod_4(array);
			method_27(BitConverter.ToDouble(array, 0));
			return;
		case 204:
			b = (byte)stream_0.ReadByte();
			method_10(b);
			return;
		case 205:
			array = new byte[2];
			stream_0.Read(array, 0, 2);
			array = GClass15.smethod_4(array);
			method_10(BitConverter.ToUInt16(array, 0));
			return;
		case 206:
			array = new byte[4];
			stream_0.Read(array, 0, 4);
			array = GClass15.smethod_4(array);
			method_10(BitConverter.ToUInt32(array, 0));
			return;
		case 207:
			array = new byte[8];
			stream_0.Read(array, 0, 8);
			array = GClass15.smethod_4(array);
			method_11(BitConverter.ToUInt64(array, 0));
			return;
		case 220:
			array = new byte[2];
			stream_0.Read(array, 0, 2);
			array = GClass15.smethod_4(array);
			num = BitConverter.ToInt16(array, 0);
			method_1();
			genum5_0 = GEnum5.const_3;
			for (num2 = 0; num2 < num; num2++)
			{
				method_2().method_30(stream_0);
			}
			return;
		case 221:
			array = new byte[4];
			stream_0.Read(array, 0, 4);
			array = GClass15.smethod_4(array);
			num = BitConverter.ToInt16(array, 0);
			method_1();
			genum5_0 = GEnum5.const_3;
			for (num2 = 0; num2 < num; num2++)
			{
				method_2().method_30(stream_0);
			}
			return;
		case 217:
			method_23(Class86.smethod_2(b, stream_0));
			return;
		case 222:
			array = new byte[2];
			stream_0.Read(array, 0, 2);
			array = GClass15.smethod_4(array);
			num = BitConverter.ToInt16(array, 0);
			method_1();
			genum5_0 = GEnum5.const_2;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass18 gClass2 = method_2();
				gClass2.method_0(Class86.smethod_1(stream_0));
				gClass2.method_30(stream_0);
			}
			return;
		case 199:
		case 200:
		case 201:
			throw new Exception("(ext8,ext16,ex32) type $c7,$c8,$c9");
		}
		switch (b)
		{
		case 222:
			array = new byte[2];
			stream_0.Read(array, 0, 2);
			array = GClass15.smethod_4(array);
			num = BitConverter.ToInt16(array, 0);
			method_1();
			genum5_0 = GEnum5.const_2;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass18 gClass4 = method_2();
				gClass4.method_0(Class86.smethod_1(stream_0));
				gClass4.method_30(stream_0);
			}
			break;
		case 223:
			array = new byte[4];
			stream_0.Read(array, 0, 4);
			array = GClass15.smethod_4(array);
			num = BitConverter.ToInt32(array, 0);
			method_1();
			genum5_0 = GEnum5.const_2;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass18 gClass3 = method_2();
				gClass3.method_0(Class86.smethod_1(stream_0));
				gClass3.method_30(stream_0);
			}
			break;
		case 218:
			method_23(Class86.smethod_2(b, stream_0));
			break;
		case 219:
			method_23(Class86.smethod_2(b, stream_0));
			break;
		case 208:
			method_10((sbyte)stream_0.ReadByte());
			break;
		case 209:
			array = new byte[2];
			stream_0.Read(array, 0, 2);
			array = GClass15.smethod_4(array);
			method_10(BitConverter.ToInt16(array, 0));
			break;
		case 210:
			array = new byte[4];
			stream_0.Read(array, 0, 4);
			array = GClass15.smethod_4(array);
			method_10(BitConverter.ToInt32(array, 0));
			break;
		case 211:
			array = new byte[8];
			stream_0.Read(array, 0, 8);
			array = GClass15.smethod_4(array);
			method_10(BitConverter.ToInt64(array, 0));
			break;
		}
	}

	public byte[] method_31()
	{
		using MemoryStream memoryStream = new MemoryStream();
		method_32(memoryStream);
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Position = 0L;
		memoryStream.Read(array, 0, (int)memoryStream.Length);
		return GClass19.smethod_1(array);
	}

	public void method_32(Stream stream_0)
	{
		switch (genum5_0)
		{
		default:
			Class87.smethod_0(stream_0);
			break;
		case GEnum5.const_0:
		case GEnum5.const_1:
			Class87.smethod_0(stream_0);
			break;
		case GEnum5.const_2:
			method_8(stream_0);
			break;
		case GEnum5.const_3:
			method_9(stream_0);
			break;
		case GEnum5.const_4:
			Class87.smethod_1(stream_0, (string)object_0);
			break;
		case GEnum5.const_5:
			Class87.smethod_7(stream_0, (long)object_0);
			break;
		case GEnum5.const_6:
			Class87.smethod_6(stream_0, (ulong)object_0);
			break;
		case GEnum5.const_7:
			Class87.smethod_5(stream_0, (bool)object_0);
			break;
		case GEnum5.const_8:
			Class87.smethod_3(stream_0, (double)object_0);
			break;
		case GEnum5.const_9:
			Class87.smethod_3(stream_0, (float)object_0);
			break;
		case GEnum5.const_10:
			Class87.smethod_7(stream_0, method_13());
			break;
		case GEnum5.const_11:
			Class87.smethod_2(stream_0, (byte[])object_0);
			break;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new GClass16(list_0);
	}
}
