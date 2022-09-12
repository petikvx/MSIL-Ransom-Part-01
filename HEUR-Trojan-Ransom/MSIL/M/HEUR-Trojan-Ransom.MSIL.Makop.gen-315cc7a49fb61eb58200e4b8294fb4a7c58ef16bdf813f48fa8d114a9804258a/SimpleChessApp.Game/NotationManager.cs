using System.ComponentModel;

namespace SimpleChessApp.Game;

public class NotationManager
{
	public BindingList<Turn> Moves { get; set; }

	public NotationManager()
	{
		Moves = new BindingList<Turn>();
	}

	internal void Clear()
	{
		Moves.Clear();
	}
}
