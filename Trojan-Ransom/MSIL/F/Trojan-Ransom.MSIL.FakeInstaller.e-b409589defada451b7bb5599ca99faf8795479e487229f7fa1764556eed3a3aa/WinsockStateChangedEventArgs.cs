using System;

public class WinsockStateChangedEventArgs : EventArgs
{
	private WinsockStates m_OldState;

	private WinsockStates m_NewState;

	public WinsockStates Old_State => m_OldState;

	public WinsockStates New_State => m_NewState;

	public WinsockStateChangedEventArgs(WinsockStates oldState, WinsockStates newState)
	{
		m_OldState = oldState;
		m_NewState = newState;
	}
}
