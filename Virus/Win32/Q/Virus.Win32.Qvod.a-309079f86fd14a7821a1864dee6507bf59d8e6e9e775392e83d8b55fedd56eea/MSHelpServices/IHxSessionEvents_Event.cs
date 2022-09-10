using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComEventInterface(typeof(IHxSessionEvents), typeof(IHxSessionEvents_EventProvider))]
[ComVisible(false)]
public interface IHxSessionEvents_Event
{
	event IHxSessionEvents_IndexMergeStatusEventHandler IndexMergeStatus;

	event IHxSessionEvents_MergeIndexFileNameEventHandler MergeIndexFileName;

	event IHxSessionEvents_PrintMergeStatusEventHandler PrintMergeStatus;

	event IHxSessionEvents_QueryCancelEventHandler QueryCancel;
}
