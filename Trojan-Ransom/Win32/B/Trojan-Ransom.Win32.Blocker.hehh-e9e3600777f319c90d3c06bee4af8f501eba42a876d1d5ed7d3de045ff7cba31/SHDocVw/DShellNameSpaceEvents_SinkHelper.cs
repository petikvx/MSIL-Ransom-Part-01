using System.Runtime.InteropServices;

namespace SHDocVw;

[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public sealed class DShellNameSpaceEvents_SinkHelper : DShellNameSpaceEvents
{
	public DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler m_FavoritesSelectionChangeDelegate;

	public DShellNameSpaceEvents_SelectionChangeEventHandler m_SelectionChangeDelegate;

	public DShellNameSpaceEvents_DoubleClickEventHandler m_DoubleClickDelegate;

	public DShellNameSpaceEvents_InitializedEventHandler m_InitializedDelegate;

	public int m_dwCookie;

	public override void FavoritesSelectionChange(int param0, int param1, string param2, string param3, int param4, string param5, int param6)
	{
		if (m_FavoritesSelectionChangeDelegate != null)
		{
			m_FavoritesSelectionChangeDelegate(param0, param1, param2, param3, param4, param5, param6);
		}
	}

	public override void SelectionChange()
	{
		if (m_SelectionChangeDelegate != null)
		{
			m_SelectionChangeDelegate();
		}
	}

	public override void DoubleClick()
	{
		if (m_DoubleClickDelegate != null)
		{
			m_DoubleClickDelegate();
		}
	}

	public override void Initialized()
	{
		if (m_InitializedDelegate != null)
		{
			m_InitializedDelegate();
		}
	}

	internal DShellNameSpaceEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_FavoritesSelectionChangeDelegate = null;
		m_SelectionChangeDelegate = null;
		m_DoubleClickDelegate = null;
		m_InitializedDelegate = null;
	}
}
