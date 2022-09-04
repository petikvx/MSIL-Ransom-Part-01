using System.Runtime.InteropServices;

namespace SHDocVw;

[ComEventInterface(typeof(_SearchAssistantEvents), typeof(_SearchAssistantEvents_EventProvider))]
[TypeLibType(16)]
[ComVisible(false)]
public interface _SearchAssistantEvents_Event
{
	event _SearchAssistantEvents_OnNextMenuSelectEventHandler OnNextMenuSelect;

	event _SearchAssistantEvents_OnNewSearchEventHandler OnNewSearch;
}
