using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

internal class Class47
{
	public static List<GEnum3> smethod_0(GClass16 gclass16_0)
	{
		byte[] array = smethod_3(gclass16_0.gclass19_0);
		if (array != null && array[0] == 5)
		{
			int num = Convert.ToInt32(array[1]);
			List<GEnum3> list = new List<GEnum3>();
			for (int i = 2; i < num + 2; i++)
			{
				switch (array[i])
				{
				case 0:
					list.Add((GEnum3)0);
					break;
				case 2:
					list.Add((GEnum3)2);
					break;
				}
			}
			return list;
		}
		return new List<GEnum3>();
	}

	public static GClass17 smethod_1(GClass16 gclass16_0)
	{
		gclass16_0.gclass19_0.method_7(new byte[2] { 5, 2 });
		byte[] array = smethod_3(gclass16_0.gclass19_0);
		if (array != null && array[0] == 1)
		{
			int num = Convert.ToInt32(array[1]);
			int count = Convert.ToInt32(array[num + 2]);
			string @string = Encoding.ASCII.GetString(array, 2, num);
			string string2 = Encoding.ASCII.GetString(array, num + 3, count);
			return new GClass17(@string, string2, (IPEndPoint)gclass16_0.gclass19_0.method_0().RemoteEndPoint);
		}
		return null;
	}

	public static GClass15 smethod_2(GClass16 gclass16_0)
	{
		byte[] array = smethod_3(gclass16_0.gclass19_0);
		if (array != null && array[0] == 5)
		{
			GEnum5 gEnum = (GEnum5)array[1];
			if (gEnum == (GEnum5)1)
			{
				int num = 4;
				string text = "";
				switch (array[3])
				{
				case 1:
				{
					for (int i = 4; i < 8; i++)
					{
						text = text + Convert.ToInt32(array[i]) + ((i != 7) ? "." : "");
					}
					num += 4;
					goto default;
				}
				case 3:
				{
					int num2 = Convert.ToInt32(array[4]);
					text += Encoding.ASCII.GetString(array, 5, num2);
					num += num2 + 1;
					goto default;
				}
				default:
				{
					byte[] array2 = new byte[2];
					Array.Copy(array, num, array2, 0, 2);
					short network = BitConverter.ToInt16(array2, 0);
					int num3 = Convert.ToInt32(IPAddress.NetworkToHostOrder(network));
					num3 = ((num3 < 1) ? (num3 + 65536) : num3);
					return new GClass15((GEnum5)1, (GEnum6)array[3], text, num3);
				}
				case 4:
					return null;
				}
			}
			return null;
		}
		return null;
	}

	public static byte[] smethod_3(GClass19 gclass19_0)
	{
		byte[] array = new byte[2048];
		int num = gclass19_0.method_3(array, 0, array.Length);
		if (num != -1)
		{
			return array;
		}
		return null;
	}

	public Class47()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
