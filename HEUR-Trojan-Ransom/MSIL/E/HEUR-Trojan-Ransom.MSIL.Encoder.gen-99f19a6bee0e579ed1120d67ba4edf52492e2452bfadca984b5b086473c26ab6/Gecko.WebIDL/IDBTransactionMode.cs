using System.ComponentModel;

namespace Gecko.WebIDL;

public enum IDBTransactionMode
{
	[Description("readonly")]
	@readonly,
	[Description("readwrite")]
	readwrite,
	[Description("readwriteflush")]
	readwriteflush,
	[Description("versionchange")]
	versionchange
}
