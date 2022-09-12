using System.ComponentModel;

namespace Gecko.WebIDL;

public enum XMLHttpRequestResponseType
{
	[Description("arraybuffer")]
	arraybuffer,
	[Description("blob")]
	blob,
	[Description("document")]
	document,
	[Description("json")]
	json,
	[Description("text")]
	text,
	[Description("moz-chunked-text")]
	mozchunkedtext,
	[Description("moz-chunked-arraybuffer")]
	mozchunkedarraybuffer,
	[Description("moz-blob")]
	mozblob
}
