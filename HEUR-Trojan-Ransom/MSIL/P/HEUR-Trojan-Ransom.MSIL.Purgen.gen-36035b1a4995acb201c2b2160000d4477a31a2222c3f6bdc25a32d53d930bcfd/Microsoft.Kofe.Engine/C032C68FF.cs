using System.Runtime.CompilerServices;

namespace Microsoft.Kofe.Engine;

internal class C032C68FF
{
	public readonly DF0AD6554 F45FA6838;

	public readonly string DD7E3AFEE;

	[CompilerGenerated]
	private Value F4169CB93;

	public Value C398153CC
	{
		[CompilerGenerated]
		get
		{
			return F4169CB93;
		}
		[CompilerGenerated]
		private set
		{
			F4169CB93 = value;
		}
	}

	public C032C68FF(DF0AD6554 k)
	{
		F45FA6838 = k;
	}

	public C032C68FF(DF0AD6554 k, string id)
		: this(k)
	{
		DD7E3AFEE = id;
	}

	public C032C68FF(DF0AD6554 k, Value v)
		: this(k)
	{
		C398153CC = v;
	}
}
