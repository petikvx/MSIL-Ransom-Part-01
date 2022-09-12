using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class F5599FF1B : BC94B3E09
{
	[CompilerGenerated]
	private IJdwpVariable B089B7D7D;

	public IJdwpVariable D3765E677
	{
		[CompilerGenerated]
		get
		{
			return B089B7D7D;
		}
		[CompilerGenerated]
		protected set
		{
			B089B7D7D = value;
		}
	}

	public static Value F2024D987(IJdwpVariable A19ED79A7, DD3247535 F53FC3672)
	{
		IJdwpValue[] variableValues = F53FC3672.D0308D65F.GetVariableValues(F53FC3672.D9B337BB0, F53FC3672.D1F321559, (IJdwpVariable[])(object)new IJdwpVariable[1] { A19ED79A7 });
		if (variableValues.Length != 0)
		{
			return A002C58D2.A17FDB047(F53FC3672.D0308D65F, variableValues[0]);
		}
		return null;
	}

	public F5599FF1B(IJdwpVariable v)
	{
		D3765E677 = v;
	}

	public override Value EA4445773(DD3247535 F501D2306)
	{
		Value value = F2024D987(D3765E677, F501D2306);
		if (value == null)
		{
			throw new EEA8EDD4A(string.Format(CultureInfo.CurrentCulture, B0E4D9146.F7DEAAF04, new object[1] { D3765E677.get_Name() }));
		}
		if (value is C4CC2394A)
		{
			((C4CC2394A)value).CE93796A6(D3765E677.get_DisplaySignature());
		}
		return value;
	}

	public override string E04D6745B()
	{
		return D3765E677.get_Name();
	}

	public override FEC112558 D54AE5958(DD3247535 AFEFDCA43)
	{
		return FEC112558.B54D0B1CA(D3765E677.get_Signature(), AFEFDCA43);
	}
}
