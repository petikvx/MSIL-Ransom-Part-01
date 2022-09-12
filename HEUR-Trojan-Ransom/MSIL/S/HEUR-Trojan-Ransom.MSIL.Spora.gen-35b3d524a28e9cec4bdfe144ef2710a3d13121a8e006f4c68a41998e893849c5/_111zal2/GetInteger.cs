using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace _111zal2;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal sealed class GetInteger
{
	private static ResourceManager ScanEnumerableQueryOperatorResults;

	private static CultureInfo XmlSchemaNotation;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager SystemIPv4InterfaceProperties
	{
		get
		{
			if (ScanEnumerableQueryOperatorResults == null)
			{
				object obj = new ResourceManager("_111zal2.Properties.Resources", typeof(GetInteger).Assembly);
				ScanEnumerableQueryOperatorResults = (ResourceManager)obj;
			}
			object scanEnumerableQueryOperatorResults = ScanEnumerableQueryOperatorResults;
			return (ResourceManager)scanEnumerableQueryOperatorResults;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo IIterable_00601
	{
		get
		{
			object xmlSchemaNotation = XmlSchemaNotation;
			return (CultureInfo)xmlSchemaNotation;
		}
		set
		{
			XmlSchemaNotation = value;
		}
	}

	internal GetInteger()
	{
	}
}
