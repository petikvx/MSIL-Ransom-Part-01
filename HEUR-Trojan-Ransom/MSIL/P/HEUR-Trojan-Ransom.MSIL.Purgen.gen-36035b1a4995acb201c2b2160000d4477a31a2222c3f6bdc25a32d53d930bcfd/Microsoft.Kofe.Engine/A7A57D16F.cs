using System.Runtime.CompilerServices;

namespace Microsoft.Kofe.Engine;

internal class A7A57D16F : BC94B3E09
{
	[CompilerGenerated]
	private readonly DF0AD6554 D9AD65B72;

	public Value A65364AC4;

	public DF0AD6554 CCB75B16A
	{
		[CompilerGenerated]
		get
		{
			return D9AD65B72;
		}
	}

	public A7A57D16F(DF0AD6554 t, Value v)
	{
		A65364AC4 = v;
		D9AD65B72 = t;
	}

	public override string B4730A7B3()
	{
		return A65364AC4.DisplayValue;
	}

	public override Value FB2A4274B(DD3247535 EDA8BBD27)
	{
		return A65364AC4;
	}

	public override FEC112558 E08EAAA8B(DD3247535 C3A2C58AB)
	{
		switch (CCB75B16A)
		{
		case DF0AD6554.IntegerLiteral:
		case DF0AD6554.FloatingLiteral:
		case DF0AD6554.BooleanLiteral:
		case DF0AD6554.CharacterLiteral:
			return new FEC112558(F18024EA9.Simple);
		case DF0AD6554.StringLiteral:
			return new FEC112558(F18024EA9.String);
		case DF0AD6554.NullLiteral:
			return new FEC112558(F18024EA9.Object);
		default:
			throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
		}
	}
}
