using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace XW;

[Serializable]
public struct X8<qn, hX, ib>
{
	private readonly qn RiQ;

	private readonly ib QiN;

	private readonly hX iim;

	public qn Key => RiQ;

	public hX Value => iim;

	[SpecialName]
	public ib ni6()
	{
		return QiN;
	}

	public X8(qn MR, hX dO, ib gM)
	{
		G3.nJ(G3.By);
		RiQ = MR;
		QiN = gM;
		iim = dO;
	}

	public override string ToString()
	{
		StringBuilder object_ = new StringBuilder();
		cui.nJ(object_, '[', cui.wu0);
		if (Key != null)
		{
			MXh.nJ(object_, Key.ToString(), MXh.cXM);
		}
		MXh.nJ(object_, ", ", MXh.cXM);
		if (Value != null)
		{
			MXh.nJ(object_, Value.ToString(), MXh.cXM);
		}
		MXh.nJ(object_, ", ", MXh.cXM);
		if (ni6() != null)
		{
			MXh.nJ(object_, ni6().ToString(), MXh.cXM);
		}
		cui.nJ(object_, ']', cui.wu0);
		return Xi.nJ(object_, Xi.l0);
	}

	internal static bool pq5()
	{
		return true;
	}

	internal static object Rqu()
	{
		return null;
	}
}
