using System;

namespace SimpleChessApp.Game;

public class ActionEventArgs : EventArgs
{
	public UserAction Action;

	public ActionEventArgs(UserAction u)
	{
		Action = u;
	}
}
