using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[ComImport]
[ComEventInterface(typeof(_WMPOCXEvents), typeof(_WMPOCXEvents))]
[CompilerGenerated]
[TypeIdentifier("6bf52a50-394a-11d3-b153-00c04f79faa6", "WMPLib._WMPOCXEvents_Event")]
public interface _WMPOCXEvents_Event
{
	event _WMPOCXEvents_PlayStateChangeEventHandler PlayStateChange;

	void _VtblGap1_2();
}
