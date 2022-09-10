using System.Security.Policy;

namespace Microsoft.Tools.Caspol;

internal class CodeGroupAttributeTableEntry
{
	internal string label;

	internal bool display;

	internal PolicyStatementAttribute value;

	internal string description;

	internal CodeGroupAttributeHandler handler;

	public CodeGroupAttributeTableEntry(string label, PolicyStatementAttribute value, string description)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		this.label = label;
		this.value = value;
		this.description = description;
		display = true;
		handler = null;
	}

	public CodeGroupAttributeTableEntry(string label, CodeGroupAttributeHandler handler, bool display)
	{
		this.label = label;
		this.handler = handler;
		this.display = display;
		description = null;
	}
}
