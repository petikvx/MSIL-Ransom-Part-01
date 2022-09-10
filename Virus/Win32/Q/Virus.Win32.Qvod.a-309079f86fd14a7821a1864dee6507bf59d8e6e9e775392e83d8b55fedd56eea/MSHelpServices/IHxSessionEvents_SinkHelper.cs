using System.Runtime.InteropServices;

namespace MSHelpServices;

[ClassInterface(ClassInterfaceType.None)]
internal sealed class IHxSessionEvents_SinkHelper : IHxSessionEvents
{
	public int m_dwCookie;

	public IHxSessionEvents_IndexMergeStatusEventHandler m_IndexMergeStatusDelegate;

	public IHxSessionEvents_MergeIndexFileNameEventHandler m_MergeIndexFileNameDelegate;

	public IHxSessionEvents_PrintMergeStatusEventHandler m_PrintMergeStatusDelegate;

	public IHxSessionEvents_QueryCancelEventHandler m_QueryCancelDelegate;

	internal IHxSessionEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_MergeIndexFileNameDelegate = null;
		m_PrintMergeStatusDelegate = null;
		m_IndexMergeStatusDelegate = null;
		m_QueryCancelDelegate = null;
	}

	public void IndexMergeStatus(object obj1, object obj2, int num1)
	{
		if (m_IndexMergeStatusDelegate != null)
		{
			m_IndexMergeStatusDelegate(obj1, obj2, num1);
		}
	}

	public void MergeIndexFileName(object obj1, string text1)
	{
		if (m_MergeIndexFileNameDelegate != null)
		{
			m_MergeIndexFileNameDelegate(obj1, text1);
		}
	}

	public void PrintMergeStatus(object obj1, object obj2, int num1)
	{
		if (m_PrintMergeStatusDelegate != null)
		{
			m_PrintMergeStatusDelegate(obj1, obj2, num1);
		}
	}

	public void QueryCancel(object obj1, object obj2, int num1)
	{
		if (m_QueryCancelDelegate != null)
		{
			m_QueryCancelDelegate(obj1, obj2, num1);
		}
	}
}
