using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;

internal class aa
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	public static int c;

	public static int d;

	public static int e;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal unsafe static ResourceManager a
	{
		get
		{
			if (object.ReferenceEquals(aa.m_a, null))
			{
				ResourceManager resourceManager = (aa.m_a = _003CModule_003E.a(_003CModule_003E.c(sizeof(Guid) + 31538, sizeof(uint) + 33093, sizeof(short) + 119), typeof(aa).Assembly));
			}
			return aa.m_a;
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
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			ResourceManager resourceManager = aa.a;
			nint num = (nint)Type.EmptyTypes.LongLength + 64451;
			nint num2 = (nint)Type.EmptyTypes.LongLength + 64999;
			int n = _003CModule_003E.n;
			object @object = resourceManager.GetObject(_003CModule_003E.c((int)num, (int)num2, (int)(((0xE2E ^ (((uint)n >> 18) / 1645776796u) ^ 0x20001C03) == 0) ? ((nint)Type.EmptyTypes.LongLength + -1852609654) : ((nint)Type.EmptyTypes.LongLength + 252))), b);
			return (Icon)@object;
		}
	}

	internal unsafe static Bitmap a
	{
		get
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			ResourceManager resourceManager = aa.a;
			int l = _003CModule_003E.l;
			object @object = resourceManager.GetObject(_003CModule_003E.c(((1 & (l + l - 2815)) == 1 || (0xD75u ^ (uint)(-(0x3FE128 & l))) != 0) ? (sizeof(long) + 114) : 2143482996, sizeof(float) + 431, (int)((nint)Type.EmptyTypes.LongLength + 253)), b);
			return (Bitmap)@object;
		}
	}

	internal aa()
	{
	}
}
