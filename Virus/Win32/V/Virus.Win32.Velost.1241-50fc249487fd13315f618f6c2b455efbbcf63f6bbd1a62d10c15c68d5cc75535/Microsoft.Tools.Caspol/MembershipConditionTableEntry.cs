namespace Microsoft.Tools.Caspol;

internal class MembershipConditionTableEntry
{
	internal string option;

	internal MembershipConditionHandler handler;

	public MembershipConditionTableEntry(string option, MembershipConditionHandler handler)
	{
		this.option = option;
		this.handler = handler;
	}
}
