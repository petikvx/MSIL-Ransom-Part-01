using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;

internal class eb
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	public static object c;

	public static object d;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager a
	{
		get
		{
			if (object.ReferenceEquals(eb.m_a, null))
			{
				ResourceManager resourceManager = (eb.m_a = _003CModule_003E.a(_003CModule_003E.c(45406, 45822, (int)((nint)Type.EmptyTypes.LongLength + 137)), typeof(eb).Assembly));
			}
			return eb.m_a;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo a
	{
		get
		{
			return b;
		}
		set
		{
			b = value;
		}
	}

	internal static Icon a
	{
		get
		{
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			ResourceManager resourceManager = eb.a;
			int q = _003CModule_003E.q;
			int o = default(int);
			nint num2;
			if ((((uint)q % 7717426u) | 0x717FFFFF) != 1904214015)
			{
				o = _003CModule_003E.o;
				if (((uint)(8 * o + o * 8) >> 2) + 1476395008 == (uint)((o | 0x7CF73FFF) << 2))
				{
					if (~(~(2621440 * q)) == 524288 * (q + 1853))
					{
						int o2 = _003CModule_003E.o;
						int num;
						if (o2 - 18959872 == o2)
						{
							num = -470256559;
							num2 = num;
						}
						else
						{
							num = -312606723;
							num2 = num;
						}
					}
					else
					{
						num2 = (nint)Type.EmptyTypes.LongLength + 1209772649;
					}
				}
				else
				{
					num2 = 1878052363;
				}
			}
			else
			{
				num2 = 5250;
			}
			object @object = resourceManager.GetObject(_003CModule_003E.c((int)num2, (int)((((uint)(10 * o + 118 * o) ^ 0x8A74FCD8u) != 0) ? ((nint)Type.EmptyTypes.LongLength + 5679) : ((nint)Type.EmptyTypes.LongLength + 1763787124)), (int)((nint)Type.EmptyTypes.LongLength + 186)), b);
			return (Icon)@object;
		}
	}

	internal unsafe static Bitmap a
	{
		get
		{
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			ResourceManager resourceManager = eb.a;
			nint num = (nint)Type.EmptyTypes.LongLength + 5641;
			int q = _003CModule_003E.q;
			nint num2;
			if ((((uint)q / 452702160u) ^ 0xFFFFF0E6u) == 0)
			{
				int q2 = _003CModule_003E.q;
				num2 = ((134217728 * q2 - -687865856 != 134217728 * q2 << 24) ? ((nint)Type.EmptyTypes.LongLength + -1142680401) : ((q2 * 205472 != 4785) ? (sizeof(long) + 1499155639) : (sizeof(ulong) + 805159635)));
			}
			else
			{
				num2 = (nint)Type.EmptyTypes.LongLength + 6995;
			}
			object @object = resourceManager.GetObject(_003CModule_003E.c((int)num, (int)num2, (int)((nint)Type.EmptyTypes.LongLength + 179)), b);
			return (Bitmap)@object;
		}
	}

	internal eb()
	{
	}
}
