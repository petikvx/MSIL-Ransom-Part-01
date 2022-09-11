using System.Windows;
using System.Windows.Automation;
using White.Core.InputDevices;
using White.Core.UIItems;
using White.Core.UIItems.ListViewItems;
using White.Core.Utility;

namespace White.Core.UIItemEvents;

public class ListViewEvent : UserEvent
{
	private static readonly string Select;

	private readonly object[] parameters;

	private static readonly string TryUnSelectAll;

	private readonly string actionName;

	public override object[] ActionParameters => parameters;

	static ListViewEvent()
	{
		Select = MethodNameResolver.NameFor((ListView l) => l.Select(0));
		TryUnSelectAll = MethodNameResolver.NameFor((ListView l) => l.TryUnSelectAll());
	}

	private ListViewEvent(IUIItem listView, string action, object[] parameters)
		: base(listView)
	{
		actionName = action;
		this.parameters = parameters;
	}

	protected override string ActionName(EventOption eventOption)
	{
		return actionName;
	}

	public static UserEvent Create(ListView listView, AutomationPropertyChangedEventArgs eventArgs)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Point location = Mouse.instance.Location;
		int columnPosition = (int)((Point)(ref location)).get_X();
		if (listView.SelectedRows.Count == 0)
		{
			return new ListViewEvent(listView, TryUnSelectAll, new object[0]);
		}
		if (true.Equals(eventArgs.get_NewValue()))
		{
			string text = null;
			if (listView.Header != null)
			{
				ListViewColumn listViewColumn = listView.Header.Columns.Find(delegate(ListViewColumn obj)
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					//IL_001f: Unknown result type (might be due to invalid IL or missing references)
					//IL_0024: Unknown result type (might be due to invalid IL or missing references)
					Rect bounds = obj.Bounds;
					if (((Rect)(ref bounds)).get_Left() < (double)columnPosition)
					{
						double num = columnPosition;
						Rect bounds2 = obj.Bounds;
						return num < ((Rect)(ref bounds2)).get_Right();
					}
					return false;
				});
				text = listViewColumn.Text;
			}
			string text2 = ((text == null) ? listView.SelectedRows[0].Cells[0].Text : listView.SelectedRows[0].Cells[text].Text);
			return new ListViewEvent(listView, Select, new object[2] { text, text2 });
		}
		return null;
	}
}
