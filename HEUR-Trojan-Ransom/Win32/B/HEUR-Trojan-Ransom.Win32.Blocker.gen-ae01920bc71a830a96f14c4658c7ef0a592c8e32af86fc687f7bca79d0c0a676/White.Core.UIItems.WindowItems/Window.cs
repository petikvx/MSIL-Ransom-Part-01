using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.InputDevices;
using White.Core.Recording;
using White.Core.Sessions;
using White.Core.UIA;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.MenuItems;
using White.Core.UIItems.WindowStripControls;
using White.Core.Utility;

namespace White.Core.UIItems.WindowItems;

public abstract class Window : UIItemContainer, IDisposable
{
	public delegate bool WaitTillDelegate();

	private static readonly Dictionary<DisplayState, WindowVisualState> WindowStates;

	private AutomationEventHandler handler;

	protected override ActionListener ChildrenActionListener => this;

	public virtual string Title
	{
		get
		{
			if (TitleBar != null)
			{
				return TitleBar.Name;
			}
			return Name;
		}
	}

	private WindowPattern WinPattern => (WindowPattern)Pattern(WindowPattern.Pattern);

	public virtual bool IsClosed
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				AutomationElementInformation current = automationElement.get_Current();
				return ((AutomationElementInformation)(ref current)).get_IsOffscreen();
			}
			catch (ElementNotAvailableException)
			{
				return true;
			}
			catch (InvalidOperationException)
			{
				return true;
			}
			catch (COMException)
			{
				return true;
			}
		}
	}

	public virtual DisplayState DisplayState
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			foreach (KeyValuePair<DisplayState, WindowVisualState> windowState in WindowStates)
			{
				object obj = windowState.Value;
				WindowPatternInformation current2 = WinPattern.get_Current();
				if (obj.Equals(((WindowPatternInformation)(ref current2)).get_WindowVisualState()))
				{
					return windowState.Key;
				}
			}
			throw new WhiteException("Not in any of the possible states, may be it is closed");
		}
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			if (!AlreadyInAskedState(value))
			{
				WinPattern.SetWindowVisualState(WindowStates[value]);
				ActionPerformed();
				WindowSession.LocationChanged(this);
				if (!AlreadyInAskedState(value) && TitleBar != null)
				{
					TitleBar.SetDisplayState(value);
					WindowSession.LocationChanged(this);
				}
			}
		}
	}

	public override ActionListener ActionListener => this;

	public virtual TitleBar TitleBar => factory.GetTitleBar(this);

	public virtual bool IsModal
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			WindowPatternInformation current = WinPattern.get_Current();
			return ((WindowPatternInformation)(ref current)).get_IsModal();
		}
	}

	public override VerticalSpan VerticalSpan => new VerticalSpan(Bounds).Minus(ScrollBars.Horizontal.Bounds);

	public abstract PopUpMenu Popup { get; }

	public virtual bool IsCurrentlyActive
	{
		get
		{
			AutomationElementCollection collection = automationElement.FindAll((TreeScope)5, Condition.TrueCondition);
			return collection.Contains(delegate(AutomationElement element)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_0011: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				AutomationElementInformation current = element.get_Current();
				if (((AutomationElementInformation)(ref current)).get_HasKeyboardFocus())
				{
					AutomationElementInformation current2 = element.get_Current();
					return !((object)((AutomationElementInformation)(ref current2)).get_ControlType()).Equals((object?)ControlType.Custom);
				}
				return false;
			});
		}
	}

	static Window()
	{
		WindowStates = new Dictionary<DisplayState, WindowVisualState>();
		WindowStates.Add(DisplayState.Maximized, (WindowVisualState)1);
		WindowStates.Add(DisplayState.Minimized, (WindowVisualState)2);
		WindowStates.Add(DisplayState.Restored, (WindowVisualState)0);
	}

	protected Window()
	{
	}

	protected Window(AutomationElement automationElement, InitializeOption initializeOption, WindowSession windowSession)
		: base(automationElement, new NullActionListener(), initializeOption, windowSession)
	{
		InitializeWindow();
	}

	private void InitializeWindow()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		ActionPerformed();
		Rect bounds = Desktop.Instance.Bounds;
		if (!((Rect)(ref bounds)).Contains(Bounds) && TitleBar != null && TitleBar.MinimizeButton != null)
		{
			logger.WarnFormat("Window with title: {0} whose dimensions are: {1}, is not contained completely on the desktop {2}. \nUI actions on window needing mouse would not work in area not falling under the desktop", (object)Title, (object)Bounds, (object)bounds);
		}
		WindowSession.Register(this);
	}

	public virtual void Close()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		WindowPattern val = (WindowPattern)Pattern(WindowPattern.Pattern);
		try
		{
			if (val == null && TitleBar != null && TitleBar.CloseButton != null)
			{
				TitleBar.CloseButton.Click();
			}
			else if (val != null)
			{
				val.Close();
				ActionPerformed();
			}
		}
		catch (ElementNotAvailableException)
		{
		}
	}

	public virtual StatusStrip StatusBar(InitializeOption initializeOption)
	{
		StatusStrip statusStrip = (StatusStrip)Get(SearchCriteria.ByControlType(ControlType.StatusBar));
		statusStrip.Cached = initializeOption;
		statusStrip.Associate(WindowSession);
		return statusStrip;
	}

	public virtual void WaitWhileBusy()
	{
		try
		{
			WaitForProcess();
			WaitForWindow();
			HourGlassWait();
			CustomWait();
		}
		catch (Exception ex)
		{
			if (!(ex is InvalidOperationException) && !(ex is ElementNotAvailableException))
			{
				throw new UIActionException(string.Format("Window didn't respond" + Constants.BusyMessage), ex);
			}
		}
	}

	private static void HourGlassWait()
	{
		if (!CoreAppXmlConfiguration.Instance.WaitBasedOnHourGlass)
		{
			return;
		}
		try
		{
			Retry.For(() => White.Core.InputDevices.Mouse.instance.Cursor, delegate(MouseCursor cursor)
			{
				if (MouseCursor.WaitCursors.Contains(cursor))
				{
					if (CoreAppXmlConfiguration.Instance.MoveMouseToGetStatusOfHourGlass)
					{
						White.Core.InputDevices.Mouse.instance.MoveOut();
					}
					return true;
				}
				return false;
			}, CoreAppXmlConfiguration.Instance.BusyTimeout());
		}
		catch (Exception)
		{
			throw new UIActionException($"Window in still wait mode. Cursor: {White.Core.InputDevices.Mouse.instance.Cursor}{Constants.BusyMessage}");
		}
	}

	private void WaitForWindow()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		WindowPattern windowPattern = (WindowPattern)Pattern(WindowPattern.Pattern);
		if (!CoreAppXmlConfiguration.Instance.InProc && !IsConsole() && windowPattern != null && !windowPattern.WaitForInputIdle(CoreAppXmlConfiguration.Instance.BusyTimeout))
		{
			throw new Exception($"Timeout occured{Constants.BusyMessage}");
		}
		if (windowPattern != null)
		{
			WindowInteractionState val = Retry.For(delegate
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				WindowPatternInformation current2 = windowPattern.get_Current();
				return ((WindowPatternInformation)(ref current2)).get_WindowInteractionState();
			}, (WindowInteractionState windowState) => (int)windowState == 4, CoreAppXmlConfiguration.Instance.BusyTimeout());
			if ((int)val == 4)
			{
				string busyMessage = Constants.BusyMessage;
				WindowPatternInformation current = windowPattern.get_Current();
				string message = $"Window didn't come out of WaitState{busyMessage} last state known was {((WindowPatternInformation)(ref current)).get_WindowInteractionState()}";
				throw new UIActionException(message);
			}
		}
	}

	private bool IsConsole()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		return "ConsoleWindowClass".Equals(((AutomationElementInformation)(ref current)).get_ClassName());
	}

	private void WaitForProcess()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		Process.GetProcessById(((AutomationElementInformation)(ref current)).get_ProcessId()).WaitForInputIdle();
	}

	public override void ActionPerformed(White.Core.UIItems.Actions.Action action)
	{
		action.Handle(this);
		ActionPerformed();
	}

	public abstract Window ModalWindow(string title, InitializeOption option);

	public virtual Window ModalWindow(string title)
	{
		return ModalWindow(title, InitializeOption.NoCache);
	}

	public abstract Window ModalWindow(SearchCriteria searchCriteria, InitializeOption option);

	public virtual Window ModalWindow(SearchCriteria searchCriteria)
	{
		return ModalWindow(searchCriteria, InitializeOption.NoCache);
	}

	public override void Visit(WindowControlVisitor windowControlVisitor)
	{
		windowControlVisitor.Accept(this);
		CurrentContainerItemFactory.Visit(windowControlVisitor);
	}

	public virtual void WaitTill(WaitTillDelegate waitTillDelegate)
	{
		if (!Retry.For(() => waitTillDelegate(), CoreAppXmlConfiguration.Instance.BusyTimeout()))
		{
			throw new UIActionException("Time out happened" + Constants.BusyMessage);
		}
	}

	public virtual void ReloadIfCached()
	{
		CurrentContainerItemFactory.ReloadIfCached();
	}

	private bool AlreadyInAskedState(DisplayState value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (value == DisplayState.Maximized)
		{
			WindowPatternInformation current = WinPattern.get_Current();
			if (!((WindowPatternInformation)(ref current)).get_CanMaximize())
			{
				return true;
			}
		}
		if (DisplayState.Minimized == value)
		{
			WindowPatternInformation current2 = WinPattern.get_Current();
			return !((WindowPatternInformation)(ref current2)).get_CanMinimize();
		}
		return false;
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		handler = (AutomationEventHandler)delegate
		{
		};
		Automation.AddAutomationEventHandler(AutomationElement.MenuOpenedEvent, automationElement, (TreeScope)4, handler);
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationEventHandler(AutomationElement.MenuOpenedEvent, automationElement, handler);
	}

	public override string ToString()
	{
		return Title;
	}

	public virtual void Dispose()
	{
		Close();
	}

	public virtual Window MessageBox(string title)
	{
		Window window = factory.ModalWindow(title, InitializeOption.NoCache, WindowSession.ModalWindowSession(InitializeOption.NoCache));
		if (window != null)
		{
			window.actionListener = this;
		}
		return window;
	}

	public virtual void Focus(DisplayState displayState)
	{
		DisplayState = displayState;
		base.Focus();
	}

	public virtual UIItemContainer MdiChild(SearchCriteria searchCriteria)
	{
		AutomationElementFinder automationElementFinder = new AutomationElementFinder(automationElement);
		AutomationElement val = automationElementFinder.Descendant(searchCriteria.AutomationCondition);
		if (!(val == (AutomationElement)null))
		{
			return new UIItemContainer(val, this, InitializeOption.NoCache, WindowSession);
		}
		return null;
	}

	public virtual List<Window> ModalWindows()
	{
		List<Window> list = new List<Window>();
		AutomationElementFinder automationElementFinder = new AutomationElementFinder(automationElement);
		List<AutomationElement> list2 = automationElementFinder.Descendants(AutomationSearchCondition.ByControlType(ControlType.Window));
		foreach (AutomationElement item in list2)
		{
			list.Add(ChildWindowFactory.Create(item, InitializeOption.NoCache, WindowSession.ModalWindowSession(InitializeOption.NoCache)));
		}
		return list;
	}

	public virtual Menu PopupMenu(params string[] path)
	{
		return Popup.Item(path);
	}

	public virtual bool HasPopup()
	{
		return Popup != null;
	}
}
