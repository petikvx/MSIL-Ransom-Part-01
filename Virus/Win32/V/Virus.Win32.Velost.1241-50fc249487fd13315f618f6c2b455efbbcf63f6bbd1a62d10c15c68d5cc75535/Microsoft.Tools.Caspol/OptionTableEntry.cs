namespace Microsoft.Tools.Caspol;

internal class OptionTableEntry
{
	internal string option;

	internal OptionHandler handler;

	internal string sameAs;

	internal bool list;

	internal bool displayMShip;

	public OptionTableEntry(string option, OptionHandler handler, string sameAs, bool list)
	{
		this.option = option;
		this.handler = handler;
		this.sameAs = sameAs;
		this.list = list;
		displayMShip = false;
	}

	public OptionTableEntry(string option, OptionHandler handler, string sameAs, bool list, bool displayMShip)
	{
		this.option = option;
		this.handler = handler;
		this.sameAs = sameAs;
		this.list = list;
		this.displayMShip = displayMShip;
	}
}
