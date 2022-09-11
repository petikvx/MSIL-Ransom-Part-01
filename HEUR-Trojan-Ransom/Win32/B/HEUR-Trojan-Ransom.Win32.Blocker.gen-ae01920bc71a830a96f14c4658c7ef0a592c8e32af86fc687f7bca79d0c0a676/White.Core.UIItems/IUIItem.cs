using System.Drawing;
using System.Windows;
using System.Windows.Automation;
using White.Core.Recording;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.Scrolling;
using White.Core.UIItems.WindowItems;
using White.Core.WindowsAPI;

namespace White.Core.UIItems;

public interface IUIItem : ActionListener
{
	AutomationElement AutomationElement { get; }

	bool Enabled { get; }

	WindowsFramework Framework { get; }

	Point Location { get; }

	Rect Bounds { get; }

	string Name { get; }

	Point ClickablePoint { get; }

	string AccessKey { get; }

	string Id { get; }

	bool Visible { get; }

	string PrimaryIdentification { get; }

	ActionListener ActionListener { get; }

	IScrollBars ScrollBars { get; }

	bool IsOffScreen { get; }

	bool IsFocussed { get; }

	Color BorderColor { get; }

	Bitmap VisibleImage { get; }

	bool ValueOfEquals(AutomationProperty property, object compareTo);

	void RightClickAt(Point point);

	void RightClick();

	void Focus();

	void Visit(WindowControlVisitor windowControlVisitor);

	string ErrorProviderMessage(Window window);

	bool NameMatches(string text);

	void Click();

	void DoubleClick();

	void KeyIn(KeyboardInput.SpecialKeys key);

	new bool Equals(object obj);

	new int GetHashCode();

	new string ToString();

	void UnHookEvents();

	void HookEvents(UIItemEventListener eventListener);

	void SetValue(object value);

	void LogStructure();

	AutomationElement GetElement(SearchCriteria searchCriteria);

	void Enter(string value);
}
