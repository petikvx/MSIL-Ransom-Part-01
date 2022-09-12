using System;
using System.Runtime.CompilerServices;

public sealed class a : GInterface11<a.CardFace, a.CardSuit>, GInterface0<a>
{
	public enum CardFace
	{
		Ace = 1,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King
	}

	public enum CardSuit
	{
		Hearts = 1,
		Clubs,
		Diamonds,
		Spades
	}

	protected CardFace cardFace_0;

	protected CardSuit cardSuit_0;

	public a(CardFace cardFace_1, CardSuit cardSuit_1)
	{
		cardFace_0 = cardFace_1;
		cardSuit_0 = cardSuit_1;
	}

	public override string ToString()
	{
		return string.Format(Class7.smethod_0(-1566193515), Enum.GetName(typeof(CardFace), imethod_0()), Enum.GetName(typeof(CardSuit), imethod_1()));
	}

	[SpecialName]
	public CardFace imethod_0()
	{
		return cardFace_0;
	}

	[SpecialName]
	public CardSuit imethod_1()
	{
		return cardSuit_0;
	}

	public int CompareTo(a other)
	{
		return imethod_0().CompareTo(other.imethod_0());
	}
}
