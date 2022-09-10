using System.Collections;
using System.Drawing;
using System.Xml;
using TGaER2JO;
using iiraiv39;
using ns4;
using yer6kF3B;

namespace ns2;

internal class Class10
{
	public int int_0;

	public string QWpErio2;

	public Point point_0;

	public int JoYbdrTC;

	public int PNOsylp4;

	public ArrayList VfG3y3Ly;

	public string String_0
	{
		get
		{
			return int_0.ToString();
		}
		set
		{
			int_0 = ivlgLlId.PluO6Q6e(value, 37974);
		}
	}

	public string VvXLYHZf
	{
		get
		{
			return QWpErio2;
		}
		set
		{
			QWpErio2 = value;
		}
	}

	public ArrayList sRuOk0dX()
	{
		return VfG3y3Ly;
	}

	public Class10()
	{
		VfG3y3Ly = new ArrayList();
	}

	public void method_0(ref XmlTextWriter GrBPuO0y, string pFzVy2rx)
	{
		ivlgLlId.NvtwUSYD(GrBPuO0y, pFzVy2rx, 29799);
		ivlgLlId.smethod_2(GrBPuO0y, "localId", int_0.ToString(), 35368);
		ivlgLlId.NvtwUSYD(GrBPuO0y, "position", 29799);
		ivlgLlId.smethod_2(GrBPuO0y, "x", point_0.X.ToString(), 35368);
		ivlgLlId.smethod_2(GrBPuO0y, "y", point_0.Y.ToString(), 35368);
		sSR2WoR5.QgTGUBli(GrBPuO0y, 36767);
		if (ivlgLlId.smethod_3(QWpErio2, "", bool_0: false, 3221) != 0)
		{
			ivlgLlId.smethod_2(GrBPuO0y, "documentation", QWpErio2, 35369);
		}
		sSR2WoR5.QgTGUBli(GrBPuO0y, 36767);
	}

	public void method_1(ref XmlTextReader QiBzEMQL)
	{
		int num = Class16.pjIk8vHc(QiBzEMQL, 35887);
		if (Class16.sORddYuc(QiBzEMQL, "localId", 20104))
		{
			int_0 = ivlgLlId.PluO6Q6e(Class16.xRdCrvAc(QiBzEMQL, 52718), 37974);
		}
		Class16.smethod_0(QiBzEMQL, 27853);
		while (Class16.pjIk8vHc(QiBzEMQL, 35887) > num)
		{
			string string_ = Class16.xRdCrvAc(QiBzEMQL, 52719);
			if (ivlgLlId.smethod_3(string_, "position", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(string_, "connectionPointIn", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(string_, "documentation", bool_0: false, 3221) == 0 && wBNSfNgl.HULRl21P(QiBzEMQL, 4203) == XmlNodeType.Element)
			{
				QWpErio2 = Class16.xRdCrvAc(QiBzEMQL, 52718);
			}
			Class16.smethod_0(QiBzEMQL, 27853);
		}
	}
}
