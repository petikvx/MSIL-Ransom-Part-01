using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace nFile;

internal class Uv
{
	public static byte[] smethod_0(byte[] Data, string keys)
	{
		checked
		{
			byte[] result = default(byte[]);
			while (true)
			{
				byte[] bytes = Encoding.Default.GetBytes(keys);
				while (true)
				{
					int num = Data.Length * 2 + bytes.Length;
					YSlhmBxV9HDnTlcrAA();
					if (rLi1P7zdQn4xZCgEUq())
					{
						if (YSlhmBxV9HDnTlcrAA())
						{
							switch (0)
							{
							case 5:
								break;
							case 1:
								goto end_IL_0003;
							default:
								goto IL_008a;
							case 2:
							case 4:
								goto IL_008e;
							case 6:
								return result;
							}
						}
						continue;
					}
					goto IL_008e;
					IL_008e:
					if (num >= 0)
					{
						Data[unchecked(num % Data.Length)] = (byte)unchecked(checked(unchecked(Data[num % Data.Length] ^ bytes[num % bytes.Length]) - unchecked((int)Data[checked(num + 1) % Data.Length]) + 256) % 256);
						goto IL_008a;
					}
					return Data;
					IL_008a:
					num += -1;
					goto IL_008e;
					continue;
					end_IL_0003:
					break;
				}
			}
		}
	}

	private void wL9gQ8OHFGt9CahI21ND0OAim()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			rLi1P7zdQn4xZCgEUq();
			int num;
			if (!YSlhmBxV9HDnTlcrAA())
			{
				num = 4;
				if (!YSlhmBxV9HDnTlcrAA())
				{
					break;
				}
			}
			else
			{
				num = 0;
				if (!YSlhmBxV9HDnTlcrAA())
				{
					break;
				}
			}
			switch (num)
			{
			case 9:
				continue;
			case 3:
			case 7:
			case 8:
				while (true)
				{
					new decimal(561L);
				}
			case 11:
				return;
			}
			break;
		}
		while (true)
		{
			MessageBox.Show("Icgƒ!YCFBTK|4k_&\u008d79WRBƒ s}6@p-)6„*F‰B7(/T6-\u008dV\u008d\u008dy.");
		}
	}

	internal static bool YSlhmBxV9HDnTlcrAA()
	{
		return true;
	}

	internal static bool rLi1P7zdQn4xZCgEUq()
	{
		return false;
	}

	internal static void pCFYxXjcZAvcp2pNV81()
	{
		ProjectData.ClearProjectError();
	}

	internal static MsgBoxResult dw3iqtjjIF6v4DR3X3V(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}
}
