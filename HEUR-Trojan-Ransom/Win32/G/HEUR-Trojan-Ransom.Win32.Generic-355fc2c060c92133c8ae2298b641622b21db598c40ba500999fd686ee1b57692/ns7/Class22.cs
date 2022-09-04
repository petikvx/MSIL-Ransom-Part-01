using System.Text;
using ns3;
using ns6;

namespace ns7;

internal sealed class Class22
{
	internal Class21.Struct2 struct2_0 = Class21.Struct2.smethod_0();

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"FILEVERSION {(ushort)((struct2_0.uint_2 & 0xFFFF0000u) >> 16)},{(ushort)(struct2_0.uint_2 & 0xFFFFu)},{(ushort)((struct2_0.uint_3 & 0xFFFF0000u) >> 16)},{(ushort)(struct2_0.uint_3 & 0xFFFFu)}");
		stringBuilder.AppendLine($"PRODUCTVERSION {(ushort)((struct2_0.uint_4 & 0xFFFF0000u) >> 16)},{(ushort)(struct2_0.uint_4 & 0xFFFFu)},{(ushort)((struct2_0.uint_5 & 0xFFFF0000u) >> 16)},{(ushort)(struct2_0.uint_5 & 0xFFFFu)}");
		if (struct2_0.uint_6 == 63)
		{
			stringBuilder.AppendLine("FILEFLAGSMASK VS_FFI_FILEFLAGSMASK");
		}
		else
		{
			stringBuilder.AppendLine($"FILEFLAGSMASK 0x{struct2_0.uint_6.ToString():x}");
		}
		stringBuilder.AppendLine(string.Format("FILEFLAGS {0}", (struct2_0.uint_7 == 0) ? "0" : Class12.smethod_2<Class1.Enum0>(struct2_0.uint_7)));
		stringBuilder.AppendLine($"FILEOS {Class12.smethod_2<Class1.Enum1>(struct2_0.uint_7)}");
		stringBuilder.AppendLine($"FILETYPE {Class12.smethod_2<Class1.Enum2>(struct2_0.uint_9)}");
		stringBuilder.AppendLine($"FILESUBTYPE {Class12.smethod_2<Class1.Enum3>(struct2_0.uint_10)}");
		return stringBuilder.ToString();
	}
}
