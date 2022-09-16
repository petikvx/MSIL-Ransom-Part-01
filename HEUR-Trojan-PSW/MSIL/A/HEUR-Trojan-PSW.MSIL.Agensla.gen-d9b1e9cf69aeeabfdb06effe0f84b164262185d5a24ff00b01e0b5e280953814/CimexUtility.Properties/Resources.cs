using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CimexUtility.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager MLE;

	private static CultureInfo XLw;

	internal static Resources VD;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager bLv
	{
		get
		{
			if (MLE == null)
			{
				ResourceManager mLE = new ResourceManager("CimexUtility.Properties.Resources", zXv.nJ(aG.nJ(typeof(Resources).TypeHandle, aG.ta), zXv.gXH));
				int num = 0;
				if (wi() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				MLE = mLE;
			}
			return MLE;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo PLG
	{
		get
		{
			return XLw;
		}
		set
		{
			XLw = value;
		}
	}

	internal Resources()
	{
		G3.nJ(G3.By);
		base._002Ector();
	}

	[SpecialName]
	internal static Bitmap YLI()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "Bitmap1", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap HL5()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "blank", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap VL9()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "blank2", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap ELZ()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "canmove", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap WLe()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "canmove2", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap LLC()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "canmovet", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap LLo()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "canmovet2", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap VLP()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "free_trial", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	[SpecialName]
	internal static Bitmap WLN()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = SXe.nJ(YXn.nJ(YXn.yXo), "mCaBID", XLw, SXe.XXE);
		return (Bitmap)obj;
	}

	internal static bool yA()
	{
		return VD == null;
	}

	internal static Resources wi()
	{
		return VD;
	}
}
