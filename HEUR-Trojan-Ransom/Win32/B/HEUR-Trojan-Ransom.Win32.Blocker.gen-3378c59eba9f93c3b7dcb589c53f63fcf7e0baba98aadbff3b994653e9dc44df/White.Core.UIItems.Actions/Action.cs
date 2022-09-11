using System.Collections.Generic;
using White.Core.UIItems.WindowItems;

namespace White.Core.UIItems.Actions;

public class Action
{
	private readonly List<ActionType> types = new List<ActionType>();

	public static readonly Action WindowMessage;

	public static readonly Action Scroll;

	public Action(params ActionType[] actionTypes)
	{
		types.AddRange(actionTypes);
	}

	public virtual void Handle(Window window)
	{
		window.WaitWhileBusy();
		if (types.Contains(ActionType.NewControls))
		{
			window.ReloadIfCached();
		}
	}

	static Action()
	{
		ActionType[] actionTypes = new ActionType[1];
		WindowMessage = new Action(actionTypes);
		Scroll = new Action(ActionType.Scroll);
	}
}
