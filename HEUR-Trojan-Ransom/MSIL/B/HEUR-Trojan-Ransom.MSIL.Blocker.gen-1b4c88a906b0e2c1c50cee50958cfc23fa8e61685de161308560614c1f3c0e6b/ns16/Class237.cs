using System.Xml.Linq;
using ns0;

namespace ns16;

internal class Class237 : Class229
{
	private XProcessingInstruction ProcessingInstruction => (XProcessingInstruction)base.WrappedNode;

	public override string? LocalName => ProcessingInstruction.get_Target();

	public override string? Value
	{
		get
		{
			return ProcessingInstruction.get_Data();
		}
		set
		{
			ProcessingInstruction.set_Data(value);
		}
	}

	public Class237(XProcessingInstruction xprocessingInstruction_0)
		: base((XObject?)(object)xprocessingInstruction_0)
	{
	}
}
