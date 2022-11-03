using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XProcessingInstructionWrapper : XObjectWrapper
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

	public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
		: base((XObject?)(object)processingInstruction)
	{
	}
}
