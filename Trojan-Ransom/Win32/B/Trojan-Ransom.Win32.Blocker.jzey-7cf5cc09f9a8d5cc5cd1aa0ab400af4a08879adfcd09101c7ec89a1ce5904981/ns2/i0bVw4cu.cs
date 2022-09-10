using System;
using System.Collections;
using System.Drawing;
using System.Xml;
using IoSuaiAb;
using Y7FbhctW;

namespace ns2;

[Serializable]
internal class i0bVw4cu : ArrayList
{
	public Class10 Pg0Le74X(int int_0, string CG4EnLp6, Point FnIXZIPA, ArrayList dhMQworv, int lkymiPAF, int jZ8hDlR3)
	{
		Class10 @class = new Class10();
		@class.int_0 = int_0;
		@class.QWpErio2 = CG4EnLp6;
		@class.point_0 = FnIXZIPA;
		@class.JoYbdrTC = lkymiPAF;
		@class.PNOsylp4 = jZ8hDlR3;
		@class.VfG3y3Ly = dhMQworv;
		U0nDFthS.cEC971DY(this, @class, 32367);
		return @class;
	}

	public void RU5Qp6Yn(ref XmlTextWriter O44zsmre, string ezj3d3OQ)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = U0nDFthS.asPgdGWu(this, 17234);
			while (U0nDFthS.PLVhCXAS(enumerator, 4045))
			{
				((Class10)U0nDFthS.GUtqfq8v(enumerator, 40408)).method_0(ref O44zsmre, ezj3d3OQ);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				O4s9Dog1.On3jH8m9(enumerator as IDisposable, 63973);
			}
		}
	}

	public void M3E0zxXS(ref XmlTextReader pIYCiB6e)
	{
		Class10 @class = new Class10();
		@class.method_1(ref pIYCiB6e);
		U0nDFthS.cEC971DY(this, @class, 32367);
	}

	public Class10 mbydK1cX(int yU231OQO)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = U0nDFthS.asPgdGWu(this, 17234);
			while (U0nDFthS.PLVhCXAS(enumerator, 4045))
			{
				Class10 @class = (Class10)U0nDFthS.GUtqfq8v(enumerator, 40408);
				if (@class.int_0 == yU231OQO)
				{
					return @class;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				O4s9Dog1.On3jH8m9(enumerator as IDisposable, 63973);
			}
		}
		return null;
	}
}
