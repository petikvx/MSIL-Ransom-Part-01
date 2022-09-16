using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace LuminousForts.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager In6;

	private static CultureInfo unV;

	internal static Resources at;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager bcK
	{
		get
		{
			int num = 1;
			while (true)
			{
				bool flag = In6 == null;
				int num2 = 0;
				if (!Ff())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					continue;
				}
				if (flag)
				{
					ResourceManager resourceManager = (In6 = new ResourceManager("LuminousForts.Properties.Resources", wuG.kN(INq.kN(typeof(Resources).TypeHandle, INq.PN6), wuG.SuY)));
				}
				return In6;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Ncp
	{
		get
		{
			return unV;
		}
		set
		{
			unV = value;
		}
	}

	internal Resources()
	{
		OZ.kN(OZ.Ou);
		base._002Ector();
	}

	[SpecialName]
	internal static Bitmap pcB()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "Bitmap1", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap Xce()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "blank", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap fcw()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "blank2", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap fc8()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "canmove", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap Ycs()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "canmove2", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap ycz()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "canmovet", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap cnc()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "canmovet2", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap jnP()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "free_trial", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap inI()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = xvN.kN(Auz.kN(Auz.cvJ), "HJIJXt", unV, xvN.nvZ);
		return (Bitmap)obj;
	}

	internal static bool Ff()
	{
		return at == null;
	}

	internal static Resources oY()
	{
		return at;
	}
}
