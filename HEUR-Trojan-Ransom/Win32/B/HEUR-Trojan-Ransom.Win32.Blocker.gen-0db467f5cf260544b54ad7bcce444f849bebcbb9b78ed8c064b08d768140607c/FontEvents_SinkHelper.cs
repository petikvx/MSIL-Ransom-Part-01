using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.None)]
internal sealed class FontEvents_SinkHelper : FontEvents
{
	public FontEvents_FontChangedEventHandler m_FontChangedDelegate;

	public int m_dwCookie;

	public override void FontChanged(string A_1)
	{
		if (m_FontChangedDelegate != null)
		{
			m_FontChangedDelegate(A_1);
		}
	}

	internal FontEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_FontChangedDelegate = null;
	}
}
