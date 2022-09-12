using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SupportedType
{
	[Description("text/html")]
	texthtml,
	[Description("text/xml")]
	textxml,
	[Description("application/xml")]
	applicationxml,
	[Description("application/xhtml+xml")]
	applicationxhtmlxml,
	[Description("image/svg+xml")]
	imagesvgxml
}
