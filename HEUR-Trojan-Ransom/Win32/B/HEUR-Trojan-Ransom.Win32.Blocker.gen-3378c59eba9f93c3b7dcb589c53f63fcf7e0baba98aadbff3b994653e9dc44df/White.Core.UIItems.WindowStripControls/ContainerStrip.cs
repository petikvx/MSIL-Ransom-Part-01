using System.Windows.Automation;
using White.Core.Factory;
using White.Core.Sessions;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.WindowStripControls;

public class ContainerStrip : UIItemContainer
{
	internal virtual InitializeOption Cached
	{
		set
		{
			ReInitialize(value);
		}
	}

	protected ContainerStrip()
	{
	}

	protected ContainerStrip(AutomationElement element, ActionListener listener)
		: base(element, listener, InitializeOption.NoCache, new NullWindowSession())
	{
	}

	public virtual UIItem GetLabel(string text)
	{
		return Get<TextBox>(SearchCriteria.ByText(text));
	}

	public virtual StatusStripSplitButton GetSplitButton(string name)
	{
		TextBox textBox = Get<TextBox>(SearchCriteria.ByText(name));
		if (textBox == null)
		{
			return null;
		}
		return new StatusStripSplitButton(textBox);
	}

	public virtual StatusStripDropDownButton GetDropDownButton(string name)
	{
		TextBox textBox = Get<TextBox>(SearchCriteria.ByText(name));
		if (textBox == null)
		{
			return null;
		}
		return new StatusStripDropDownButton(textBox);
	}

	public virtual ProgressBar GetProgressBar()
	{
		return Get<ProgressBar>(SearchCriteria.ByText(string.Empty));
	}

	public virtual ProgressBar GetProgressBar(int index)
	{
		return Get<ProgressBar>(SearchCriteria.ByText(string.Empty).AndIndex(index));
	}
}
