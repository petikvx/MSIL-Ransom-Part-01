using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ProfileTimelineWorkerOperationType
{
	[Description("serializeDataOffMainThread")]
	serializeDataOffMainThread,
	[Description("serializeDataOnMainThread")]
	serializeDataOnMainThread,
	[Description("deserializeDataOffMainThread")]
	deserializeDataOffMainThread,
	[Description("deserializeDataOnMainThread")]
	deserializeDataOnMainThread
}
