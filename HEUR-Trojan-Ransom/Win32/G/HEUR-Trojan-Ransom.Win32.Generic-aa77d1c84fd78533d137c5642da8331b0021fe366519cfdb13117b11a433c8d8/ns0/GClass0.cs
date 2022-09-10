using System.IO;
using System.Runtime.CompilerServices;

namespace ns0;

public class GClass0
{
	private struct Struct0
	{
		public Stream stream_0;

		public GEnum3 genum3_0;

		public long long_0;
	}

	public enum GEnum0
	{

	}

	public object object_0;

	public object object_1;

	private Struct0 struct0_0;

	public GClass0(FileStream fileStream_0, GEnum3 genum3_0 = (GEnum3)1, long long_0 = 0L)
	{
		smethod_3();
		if (!smethod_2())
		{
			goto IL_0010;
		}
		goto IL_0057;
		IL_0010:
		while (true)
		{
			smethod_1(this, struct0_0);
			if (!smethod_3())
			{
				switch (9)
				{
				case 3:
				case 6:
					break;
				case 0:
				case 7:
					goto IL_0057;
				case 1:
					goto IL_005d;
				case 5:
					goto IL_0064;
				case 2:
					goto IL_006b;
				default:
					goto IL_0077;
				case 4:
					goto end_IL_0010;
				case 9:
					return;
				}
				continue;
			}
			break;
			continue;
			end_IL_0010:
			break;
		}
		goto IL_0083;
		IL_0083:
		struct0_0.long_0 = long_0;
		goto IL_0010;
		IL_0057:
		smethod_0(this);
		goto IL_005d;
		IL_005d:
		object_0 = null;
		goto IL_0064;
		IL_0064:
		object_1 = null;
		goto IL_006b;
		IL_006b:
		struct0_0.stream_0 = fileStream_0;
		goto IL_0077;
		IL_0077:
		struct0_0.genum3_0 = genum3_0;
		goto IL_0083;
	}

	public GClass0(string string_0, GEnum3 genum3_0 = (GEnum3)1, long long_0 = 0L)
	{
		_ = 0;
		if (!smethod_2())
		{
			if (smethod_3())
			{
			}
			switch (4)
			{
			case 0:
			case 7:
				break;
			case 8:
				goto IL_004d;
			case 2:
			case 4:
				goto IL_0054;
			case 3:
				goto IL_005b;
			default:
				goto IL_006f;
			case 6:
				goto IL_007b;
			case 5:
				goto IL_0087;
			case 9:
				return;
			}
		}
		smethod_0(this);
		goto IL_004d;
		IL_007b:
		struct0_0.long_0 = long_0;
		goto IL_0087;
		IL_0087:
		smethod_1(this, struct0_0);
		return;
		IL_006f:
		struct0_0.genum3_0 = genum3_0;
		goto IL_007b;
		IL_004d:
		object_0 = null;
		goto IL_0054;
		IL_0054:
		object_1 = null;
		goto IL_005b;
		IL_005b:
		struct0_0.stream_0 = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
		goto IL_006f;
	}

	public GClass0(byte[] byte_0, GEnum3 genum3_0 = (GEnum3)1, long long_0 = 0L)
	{
		smethod_2();
		if (!smethod_3())
		{
			if (smethod_3())
			{
				goto IL_007f;
			}
			switch (5)
			{
			case 0:
			case 5:
				smethod_0(this);
				break;
			case 1:
			case 2:
				break;
			case 4:
				goto IL_005b;
			case 7:
				goto IL_0062;
			default:
				goto IL_0073;
			case 6:
				goto IL_007f;
			case 3:
				goto IL_008b;
			case 9:
				return;
			}
		}
		object_0 = null;
		goto IL_005b;
		IL_0073:
		struct0_0.genum3_0 = genum3_0;
		goto IL_007f;
		IL_007f:
		struct0_0.long_0 = long_0;
		goto IL_008b;
		IL_008b:
		smethod_1(this, struct0_0);
		return;
		IL_0062:
		struct0_0.stream_0 = new MemoryStream(byte_0);
		goto IL_0073;
		IL_005b:
		object_1 = null;
		goto IL_0062;
	}

	public GClass0(Stream stream_0, GEnum3 genum3_0 = (GEnum3)1, long long_0 = 0L)
	{
		smethod_0(this);
		smethod_2();
		if (!smethod_3())
		{
			object_0 = null;
			object_1 = null;
			struct0_0.stream_0 = stream_0;
		}
		struct0_0.genum3_0 = genum3_0;
		struct0_0.long_0 = long_0;
		smethod_1(this, struct0_0);
	}

	public GClass0(MemoryStream memoryStream_0, GEnum3 genum3_0 = (GEnum3)1, long long_0 = 0L)
	{
		while (true)
		{
			smethod_0(this);
			while (true)
			{
				object_0 = null;
				int num = 1;
				if (smethod_3())
				{
					break;
				}
				while (true)
				{
					switch (num)
					{
					case 4:
					case 8:
						struct0_0.genum3_0 = genum3_0;
						num = 7;
						if (smethod_3())
						{
						}
						continue;
					case 5:
						struct0_0.stream_0 = memoryStream_0;
						goto default;
					default:
						smethod_2();
						if (!smethod_3())
						{
							goto case 4;
						}
						goto case 0;
					case 1:
						object_1 = null;
						goto case 5;
					case 2:
						break;
					case 3:
						goto end_IL_0073;
					case 7:
						struct0_0.long_0 = long_0;
						goto case 0;
					case 0:
					case 6:
						smethod_1(this, struct0_0);
						return;
					case 9:
						return;
					}
					break;
				}
				continue;
				end_IL_0073:
				break;
			}
		}
	}

	private void method_0(Struct0 struct0_1)
	{
		object_0 = new GClass1(struct0_1.stream_0, struct0_1.genum3_0, struct0_1.long_0);
		for (int num = 0; num == 0; num = 1)
		{
			object_1 = new GClass2(struct0_1.stream_0, struct0_1.genum3_0, struct0_1.long_0);
		}
	}

	[SpecialName]
	public void method_1(long long_0)
	{
		_ = 1;
		if (smethod_3())
		{
			if (!smethod_2())
			{
				goto IL_0046;
			}
			switch (3)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 3:
				goto IL_0046;
			default:
				goto IL_0052;
			case 5:
				return;
			}
		}
		struct0_0.long_0 = long_0;
		goto IL_0046;
		IL_0046:
		smethod_4(object_0, long_0);
		goto IL_0052;
		IL_0052:
		smethod_5(object_1, long_0);
	}

	[SpecialName]
	public long method_2()
	{
		return struct0_0.long_0;
	}

	[SpecialName]
	public long method_3()
	{
		return smethod_6(struct0_0.stream_0);
	}

	[SpecialName]
	public Stream method_4()
	{
		return struct0_0.stream_0;
	}

	[SpecialName]
	public void method_5(Stream stream_0)
	{
		int num = 3;
		if (!smethod_2())
		{
			goto IL_003a;
		}
		goto IL_0085;
		IL_0085:
		switch (num)
		{
		case 2:
		case 5:
			goto IL_0026;
		case 3:
			goto IL_003a;
		case 0:
			goto IL_0042;
		case 1:
			goto IL_00bb;
		case 6:
		case 8:
			goto IL_00c2;
		case 9:
			return;
		}
		goto IL_000f;
		IL_003a:
		Struct0 @struct = default(Struct0);
		goto IL_0042;
		IL_0042:
		if (smethod_6(stream_0) <= struct0_0.long_0)
		{
			smethod_2();
			if (!smethod_3())
			{
				goto IL_0026;
			}
			num = 8;
			if (!smethod_3())
			{
				goto IL_0085;
			}
			goto IL_00c2;
		}
		@struct.long_0 = 0L;
		goto IL_000f;
		IL_000f:
		smethod_7(this);
		num = 1;
		if (smethod_2())
		{
			goto IL_0085;
		}
		goto IL_00bb;
		IL_0026:
		@struct.long_0 = struct0_0.long_0;
		goto IL_000f;
		IL_00c2:
		smethod_1(this, struct0_0);
		return;
		IL_00bb:
		struct0_0 = @struct;
		goto IL_00c2;
	}

	[SpecialName]
	public GEnum3 method_6()
	{
		return struct0_0.genum3_0;
	}

	[SpecialName]
	public void method_7(GEnum3 genum3_0)
	{
		struct0_0.genum3_0 = genum3_0;
		_ = 1;
		if (!smethod_3())
		{
			((GClass1)object_0).genum3_0 = genum3_0;
		}
		((GClass2)object_1).genum3_0 = genum3_0;
	}

	public long method_8(GEnum0 genum0_0)
	{
		if (genum0_0 == (GEnum0)0)
		{
			return ((GClass2)object_1).long_0;
		}
		return ((GClass1)object_0).long_0;
	}

	public void method_9()
	{
		smethod_3();
		if (smethod_2())
		{
			goto IL_0033;
		}
		int num = 5;
		if (smethod_3())
		{
		}
		goto IL_003e;
		IL_006c:
		((GClass1)object_0).genum3_0 = smethod_8(this);
		goto IL_007d;
		IL_003e:
		switch (num)
		{
		case 2:
			break;
		case 0:
		case 1:
			goto IL_0033;
		default:
			goto IL_006c;
		case 6:
			goto IL_007d;
		case 7:
			return;
		}
		goto IL_001e;
		IL_0033:
		if (smethod_8(this) == (GEnum3)1)
		{
			goto IL_001e;
		}
		smethod_9(this, (GEnum3)1);
		goto IL_006c;
		IL_001e:
		smethod_9(this, (GEnum3)2);
		num = 4;
		if (smethod_3())
		{
		}
		goto IL_003e;
		IL_007d:
		((GClass2)object_1).genum3_0 = smethod_8(this);
	}

	public void method_10()
	{
		smethod_3();
		if (smethod_2())
		{
			if (smethod_2())
			{
				switch (2)
				{
				case 0:
				case 2:
					object_0 = null;
					break;
				case 6:
					break;
				case 5:
					goto IL_0051;
				default:
					goto IL_0061;
				case 3:
				case 4:
					goto IL_0070;
				case 7:
					return;
				}
			}
			object_1 = null;
			goto IL_0051;
		}
		goto IL_0070;
		IL_0051:
		smethod_10(struct0_0.stream_0);
		goto IL_0061;
		IL_0061:
		struct0_0 = default(Struct0);
		goto IL_0070;
		IL_0070:
		struct0_0.stream_0 = (Stream)smethod_11(this);
	}

	internal static void smethod_0(object object_2)
	{
		object_2._002Ector();
	}

	internal static void smethod_1(object object_2, Struct0 struct0_1)
	{
		((GClass0)object_2).method_0(struct0_1);
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static bool smethod_3()
	{
		return false;
	}

	internal static void smethod_4(object object_2, long long_0)
	{
		((GClass1)object_2).method_1(long_0);
	}

	internal static void smethod_5(object object_2, long long_0)
	{
		((GClass2)object_2).method_1(long_0);
	}

	internal static long smethod_6(object object_2)
	{
		return ((Stream)object_2).Length;
	}

	internal static void smethod_7(object object_2)
	{
		((GClass0)object_2).method_10();
	}

	internal static GEnum3 smethod_8(object object_2)
	{
		return ((GClass0)object_2).method_6();
	}

	internal static void smethod_9(object object_2, GEnum3 genum3_0)
	{
		((GClass0)object_2).method_7(genum3_0);
	}

	internal static void smethod_10(object object_2)
	{
		((Stream)object_2).Close();
	}

	internal static object smethod_11(object object_2)
	{
		return ((GClass0)object_2).method_4();
	}
}
