using System;
using System.Drawing;
using System.Threading;
using System.Windows;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.InputDevices;
using White.Core.Recording;
using White.Core.UIA;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.Scrolling;
using White.Core.UIItems.WindowItems;
using White.Core.WindowsAPI;
using log4net;

namespace White.Core.UIItems;

public class UIItem : ActionListener, IUIItem
{
	protected readonly AutomationElement automationElement;

	protected ActionListener actionListener;

	internal static readonly Mouse mouse = Mouse.instance;

	protected readonly PrimaryUIItemFactory factory;

	internal readonly Keyboard keyboard = Keyboard.Instance;

	protected IScrollBars scrollBars;

	private AutomationEventHandler handler;

	protected readonly ILog logger = LogManager.GetLogger(typeof(UIItem));

	public virtual AutomationElement AutomationElement => automationElement;

	public virtual bool Enabled
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_IsEnabled();
		}
	}

	public virtual WindowsFramework Framework
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return new WindowsFramework(((AutomationElementInformation)(ref current)).get_FrameworkId());
		}
	}

	public virtual Point Location
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			Rect boundingRectangle = ((AutomationElementInformation)(ref current)).get_BoundingRectangle();
			return ((Rect)(ref boundingRectangle)).get_TopLeft();
		}
	}

	public virtual Rect Bounds
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_BoundingRectangle();
		}
	}

	public virtual string Name
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				AutomationElementInformation current = automationElement.get_Current();
				return ((AutomationElementInformation)(ref current)).get_Name();
			}
			catch (InvalidOperationException)
			{
				AutomationElementInformation current2 = automationElement.get_Current();
				return ((AutomationElementInformation)(ref current2)).get_Name();
			}
		}
	}

	public virtual Point ClickablePoint => (Point)Property(AutomationElement.ClickablePointProperty);

	public virtual string AccessKey
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_AccessKey();
		}
	}

	public virtual string Id
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_AutomationId();
		}
	}

	public virtual bool Visible
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return !((AutomationElementInformation)(ref current)).get_IsOffscreen();
		}
	}

	public virtual string PrimaryIdentification
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			if (!((AutomationElementInformation)(ref current)).get_FrameworkId().Equals("Win32"))
			{
				return Id;
			}
			return Name;
		}
	}

	public virtual ActionListener ActionListener => actionListener;

	public virtual IScrollBars ScrollBars => scrollBars ?? (scrollBars = ScrollerFactory.CreateBars(automationElement, actionListener));

	public virtual bool IsOffScreen
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_IsOffscreen();
		}
	}

	public virtual bool IsFocussed
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_HasKeyboardFocus();
		}
	}

	public virtual Color BorderColor => VisibleImage.GetPixel(0, 0);

	public virtual Bitmap VisibleImage
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			AutomationElementInformation current = automationElement.get_Current();
			DisplayedItem displayedItem = new DisplayedItem(new IntPtr(((AutomationElementInformation)(ref current)).get_NativeWindowHandle()));
			Image visibleImage = (Image)(object)displayedItem.GetVisibleImage();
			return new Bitmap(visibleImage);
		}
	}

	protected UIItem()
	{
	}

	public UIItem(AutomationElement automationElement, ActionListener actionListener)
	{
		if ((AutomationElement)null == automationElement)
		{
			throw new NullReferenceException();
		}
		this.automationElement = automationElement;
		this.actionListener = actionListener;
		factory = new PrimaryUIItemFactory(new AutomationElementFinder(automationElement));
	}

	protected virtual object Property(AutomationProperty automationProperty)
	{
		return automationElement.GetCurrentPropertyValue(automationProperty);
	}

	protected virtual void ActionPerformed()
	{
		actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
	}

	public virtual bool ValueOfEquals(AutomationProperty property, object compareTo)
	{
		return Property(property).Equals(compareTo);
	}

	protected virtual BasePattern Pattern(AutomationPattern pattern)
	{
		return Pattern(AutomationElement, pattern);
	}

	internal static BasePattern Pattern(AutomationElement automationElement, AutomationPattern pattern)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		object obj = default(object);
		if (automationElement.TryGetCurrentPattern(pattern, ref obj))
		{
			return (BasePattern)obj;
		}
		return null;
	}

	public virtual void RightClickAt(Point point)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(this);
		mouse.RightClick(point, actionListener);
	}

	public virtual void RightClick()
	{
		RightClickOnCenter();
	}

	private void RightClickOnCenter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		RightClickAt(Bounds.Center());
	}

	public virtual void Focus()
	{
		actionListener.ActionPerforming(this);
		try
		{
			automationElement.SetFocus();
			ActionPerformed();
		}
		catch
		{
			logger.Debug((object)("Could not set focus on " + automationElement.Display()));
		}
	}

	public virtual void Visit(WindowControlVisitor windowControlVisitor)
	{
		windowControlVisitor.Accept(this);
	}

	public virtual string ErrorProviderMessage(Window window)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		AutomationElement val = AutomationElement.FromPoint(((AutomationElementInformation)(ref current)).get_BoundingRectangle().ImmediateExteriorEast());
		if (val == (AutomationElement)null)
		{
			return null;
		}
		AutomationElementInformation current2 = val.get_Current();
		Rect boundingRectangle = ((AutomationElementInformation)(ref current2)).get_BoundingRectangle();
		AutomationElementInformation current3 = automationElement.get_Current();
		Rect boundingRectangle2 = ((AutomationElementInformation)(ref current3)).get_BoundingRectangle();
		if (((Rect)(ref boundingRectangle2)).get_Right() != ((Rect)(ref boundingRectangle)).get_Left())
		{
			return null;
		}
		mouse.Location = boundingRectangle.Center();
		actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
		return window.ToolTip.Text;
	}

	public virtual bool NameMatches(string text)
	{
		return Name.Equals(text);
	}

	public virtual void Click()
	{
		actionListener.ActionPerforming(this);
		PerformIfValid(PerformClick);
	}

	private void PerformIfValid(System.Action action)
	{
		DateTime now = DateTime.Now;
		int num = CoreAppXmlConfiguration.Instance.BusyTimeout / 1000;
		while (true)
		{
			if (DateTime.Now.Subtract(now).TotalSeconds < (double)num)
			{
				if (Enabled && !IsOffScreen)
				{
					break;
				}
				Thread.Sleep(500);
				continue;
			}
			string arg = null;
			if (!Enabled)
			{
				arg = "element not enabled";
			}
			else if (IsOffScreen)
			{
				arg = "element is offscreen";
			}
			throw new AutomationException($"Cannot perform action on {this}, {arg}", Debug.Details(AutomationElement));
		}
		action();
	}

	internal virtual void PerformClick()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (!Enabled)
		{
			logger.WarnFormat("Clicked on disabled item: {0}", (object)ToString());
		}
		mouse.Click(Bounds.Center(), actionListener);
	}

	public virtual void DoubleClick()
	{
		actionListener.ActionPerforming(this);
		PerformIfValid(delegate
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			mouse.DoubleClick(Bounds.Center(), actionListener);
		});
	}

	public virtual void KeyIn(KeyboardInput.SpecialKeys key)
	{
		actionListener.ActionPerforming(this);
		keyboard.PressSpecialKey(key, actionListener);
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (!(obj is UIItem uIItem))
		{
			return false;
		}
		return object.Equals(automationElement, uIItem.AutomationElement);
	}

	public override int GetHashCode()
	{
		return ((object)automationElement).GetHashCode();
	}

	public override string ToString()
	{
		return $"{GetType().Name}. {automationElement.Display()}";
	}

	protected virtual void HookClickEvent(UIItemEventListener eventListener)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		handler = (AutomationEventHandler)delegate
		{
			eventListener.EventOccured(new UIItemClickEvent(this));
		};
		Automation.AddAutomationEventHandler(InvokePattern.InvokedEvent, automationElement, (TreeScope)1, handler);
	}

	protected virtual void UnHookClickEvent()
	{
		Automation.RemoveAutomationEventHandler(InvokePattern.InvokedEvent, automationElement, handler);
	}

	public virtual void UnHookEvents()
	{
	}

	public virtual void HookEvents(UIItemEventListener eventListener)
	{
	}

	public virtual void SetValue(object value)
	{
	}

	public virtual void ActionPerforming(UIItem uiItem)
	{
	}

	public virtual void ActionPerformed(White.Core.UIItems.Actions.Action action)
	{
		actionListener.ActionPerformed(action);
	}

	public virtual void LogStructure()
	{
		logger.Info((object)Debug.Details(automationElement));
	}

	public virtual AutomationElement GetElement(SearchCriteria searchCriteria)
	{
		return new AutomationElementFinder(automationElement).FindDescendantRaw(searchCriteria.AutomationSearchCondition);
	}

	public virtual void Enter(string value)
	{
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.HOME);
		keyboard.HoldKey(KeyboardInput.SpecialKeys.SHIFT);
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.END);
		keyboard.LeaveKey(KeyboardInput.SpecialKeys.SHIFT);
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.DELETE);
		if (!string.IsNullOrEmpty(value))
		{
			BasePattern obj = Pattern(ValuePattern.Pattern);
			ValuePattern val = (ValuePattern)(object)((obj is ValuePattern) ? obj : null);
			if (val != null)
			{
				val.SetValue(string.Empty);
			}
			actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
			EnterData(value);
		}
	}

	protected virtual void EnterData(string value)
	{
		keyboard.Send(value, actionListener);
	}

	internal virtual UIItemContainer AsContainer()
	{
		return new UIItemContainer(AutomationElement, actionListener);
	}

	public virtual void RaiseClickEvent()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		InvokePattern val = (InvokePattern)Pattern(InvokePattern.Pattern);
		if (val != null)
		{
			val.Invoke();
		}
	}
}
