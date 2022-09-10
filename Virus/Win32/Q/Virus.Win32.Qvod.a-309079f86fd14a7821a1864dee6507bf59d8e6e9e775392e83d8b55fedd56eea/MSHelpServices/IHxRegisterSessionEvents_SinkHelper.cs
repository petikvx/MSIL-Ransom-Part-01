using System.Runtime.InteropServices;

namespace MSHelpServices;

[ClassInterface(ClassInterfaceType.None)]
internal sealed class IHxRegisterSessionEvents_SinkHelper : IHxRegisterSessionEvents
{
	public int m_dwCookie;

	public IHxRegisterSessionEvents_FiltersChangedEventHandler m_FiltersChangedDelegate;

	internal IHxRegisterSessionEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_FiltersChangedDelegate = null;
	}

	public void FiltersChanged(object obj1, ref object objRef1)
	{
		if (m_FiltersChangedDelegate != null)
		{
			m_FiltersChangedDelegate(obj1, ref objRef1);
		}
	}
}
