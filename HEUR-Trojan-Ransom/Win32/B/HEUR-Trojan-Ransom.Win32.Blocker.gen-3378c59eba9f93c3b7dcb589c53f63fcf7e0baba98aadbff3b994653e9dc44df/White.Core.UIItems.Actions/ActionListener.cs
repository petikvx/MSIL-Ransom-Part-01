namespace White.Core.UIItems.Actions;

public interface ActionListener
{
	void ActionPerforming(UIItem uiItem);

	void ActionPerformed(Action action);
}
