using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class _SearchAssistantEvents_SinkHelper : _SearchAssistantEvents
{
	public _SearchAssistantEvents_OnNextMenuSelectEventHandler m_OnNextMenuSelectDelegate;

	public _SearchAssistantEvents_OnNewSearchEventHandler m_OnNewSearchDelegate;

	public int m_dwCookie;

	public override void OnNextMenuSelect(int param0)
	{
		if (m_OnNextMenuSelectDelegate != null)
		{
			m_OnNextMenuSelectDelegate(param0);
		}
	}

	public override void OnNewSearch()
	{
		if (m_OnNewSearchDelegate != null)
		{
			m_OnNewSearchDelegate();
		}
	}

	internal _SearchAssistantEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_OnNextMenuSelectDelegate = null;
		m_OnNewSearchDelegate = null;
	}
}
