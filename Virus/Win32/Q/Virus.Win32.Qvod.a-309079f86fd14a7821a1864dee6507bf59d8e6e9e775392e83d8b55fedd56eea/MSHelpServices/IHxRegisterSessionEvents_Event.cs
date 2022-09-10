using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComVisible(false)]
[ComEventInterface(typeof(IHxRegisterSessionEvents), typeof(IHxRegisterSessionEvents_EventProvider))]
public interface IHxRegisterSessionEvents_Event
{
	event IHxRegisterSessionEvents_FiltersChangedEventHandler FiltersChanged;
}
