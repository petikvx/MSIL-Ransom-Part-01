using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class FEC112558
{
	[CompilerGenerated]
	private readonly IJdwpClass F1B5A1DCA;

	[CompilerGenerated]
	private readonly F18024EA9 A64F449CA;

	public IJdwpClass D60DB5B8A
	{
		[CompilerGenerated]
		get
		{
			return F1B5A1DCA;
		}
	}

	public F18024EA9 C4D58B9F7
	{
		[CompilerGenerated]
		get
		{
			return A64F449CA;
		}
	}

	public FEC112558(F18024EA9 k, IJdwpClass r = null)
	{
		A64F449CA = k;
		F1B5A1DCA = r;
	}

	public static FEC112558 B54D0B1CA(string A5266C684, DD3247535 D86EE38D5)
	{
		switch (A5266C684[0])
		{
		case 'B':
		case 'C':
		case 'D':
		case 'F':
		case 'I':
		case 'J':
		case 'S':
		case 'V':
		case 'Z':
			return new FEC112558(F18024EA9.Simple);
		case 'L':
		{
			int num = A5266C684.IndexOf(';');
			if (num == -1)
			{
				throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
			}
			string text = A5266C684.Substring(1, num - 1).Replace('/', '.');
			return new FEC112558(F18024EA9.Object, D86EE38D5.D0308D65F.GetClass(text));
		}
		case '[':
		{
			FEC112558 fEC = B54D0B1CA(A5266C684.Substring(1), D86EE38D5);
			return new FEC112558(F18024EA9.Array, fEC.D60DB5B8A);
		}
		default:
			throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
		}
	}
}
