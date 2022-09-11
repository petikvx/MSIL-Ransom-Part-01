using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;

internal class k
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	public static object c;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager a
	{
		get
		{
			if (k.m_a == null)
			{
				nint num = (nint)Type.EmptyTypes.LongLength + 23785;
				int p = _003CModule_003E.p;
				ResourceManager resourceManager = (k.m_a = _003CModule_003E.a(_003CModule_003E.c((int)num, ((p & 0x300000) != ((p ^ -716518593) & 0x300000)) ? 1821931516 : 21344, 12), typeof(k).Assembly));
			}
			return k.m_a;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo b
	{
		get
		{
			return k.m_b;
		}
		set
		{
			k.m_b = value;
		}
	}

	internal unsafe static Bitmap c
	{
		get
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			ResourceManager resourceManager = a;
			int int_ = sizeof(double) + 46333;
			int num = _003CModule_003E.l;
			object @object = resourceManager.GetObject(_003CModule_003E.c(int_, (int)((((4402 + (uint)num % 3u) & 0xD80) == 256) ? ((nint)Type.EmptyTypes.LongLength + 47975) : (((0x2210 & ((uint)(2050879488 * num) | ~((uint)num / 750566609u))) != 8720) ? (sizeof(uint) + 1429811240) : (sizeof(short) + 1792832524))), (int)(((num & 0x100C) - 7418 != -1927539615) ? ((nint)Type.EmptyTypes.LongLength + 130) : ((nint)Type.EmptyTypes.LongLength + 1044111576))), k.m_b);
			return (Bitmap)@object;
		}
	}

	internal k()
	{
	}
}
