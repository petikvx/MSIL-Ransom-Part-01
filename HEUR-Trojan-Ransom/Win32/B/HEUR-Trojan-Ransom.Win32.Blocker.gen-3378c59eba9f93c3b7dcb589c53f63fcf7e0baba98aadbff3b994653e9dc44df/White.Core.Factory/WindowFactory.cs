using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Sessions;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.MenuItems;
using White.Core.UIItems.WindowItems;
using White.Core.Utility;
using log4net;

namespace White.Core.Factory;

public class WindowFactory : ChildWindowFactory
{
	private readonly ILog logger = LogManager.GetLogger(typeof(WindowFactory));

	public static WindowFactory Desktop => new WindowFactory(new AutomationElementFinder(AutomationElement.get_RootElement()));

	private WindowFactory(AutomationElementFinder automationElementFinder)
		: base(automationElementFinder)
	{
	}

	public virtual PopUpMenu PopUp(ActionListener actionListener)
	{
		return new PopUpMenu(Finder.AutomationElement, actionListener);
	}

	private static AutomationElement WaitTillFound(Func<AutomationElement> find, string message)
	{
		AutomationElement val = Retry.For(find, CoreAppXmlConfiguration.Instance.BusyTimeout());
		if (val == (AutomationElement)null)
		{
			throw new UIActionException(message + Debug.GetAllWindows());
		}
		return val;
	}

	private AutomationElement FindWindowElement(Process process, string title)
	{
		return WaitTillFound(() => Finder.FindWindow(title, process.Id), $"Couldn't find window with title {title} in process {process.Id}{Constants.BusyMessage}");
	}

	public virtual List<Window> DesktopWindows(Process process, ApplicationSession applicationSession)
	{
		List<AutomationElement> list = FindAllWindowElements(process);
		List<Window> list2 = new List<Window>();
		foreach (AutomationElement item in list)
		{
			InitializeOption noCache = InitializeOption.NoCache;
			list2.Add(ChildWindowFactory.Create(item, noCache, applicationSession.WindowSession(noCache)));
		}
		return list2;
	}

	private List<AutomationElement> FindAllWindowElements(Process process)
	{
		List<AutomationElement> list2 = Retry.For(delegate
		{
			List<AutomationElement> list3 = new List<AutomationElement>();
			FindDescendantWindowElements(Finder, process, list3);
			if (list3.Count == 0)
			{
				logger.Warn((object)"Could not find any windows for this application.");
			}
			return list3;
		}, (List<AutomationElement> list) => list.Count == 0, CoreAppXmlConfiguration.Instance.UIAutomationZeroWindowBugTimeout());
		return list2 ?? new List<AutomationElement>();
	}

	private void FindDescendantWindowElements(AutomationElementFinder windowFinder, Process process, List<AutomationElement> windowElements)
	{
		List<AutomationElement> list = windowFinder.Children(AutomationSearchCondition.ByControlType(ControlType.Window).WithProcessId(process.Id));
		windowElements.AddRange(list);
		foreach (AutomationElement item in list)
		{
			FindDescendantWindowElements(new AutomationElementFinder(item), process, windowElements);
		}
	}

	public virtual Window SplashWindow(Process process)
	{
		AutomationSearchCondition automationSearchCondition = AutomationSearchCondition.ByControlType(ControlType.Pane).WithProcessId(process.Id);
		AutomationElement automationElement = WaitTillFound(() => Finder.Child(automationSearchCondition), "No control found matching the condition " + AutomationSearchCondition.ToString(new AutomationSearchCondition[1] { automationSearchCondition }) + Constants.BusyMessage);
		return new SplashWindow(automationElement, InitializeOption.NoCache);
	}

	public virtual Window CreateWindow(string title, Process process, InitializeOption option, WindowSession windowSession)
	{
		return ChildWindowFactory.Create(FindWindowElement(process, title), option, windowSession);
	}

	public virtual Window CreateWindow(SearchCriteria searchCriteria, Process process, InitializeOption option, WindowSession windowSession)
	{
		string message = $"Couldn't find window with SearchCriteria {searchCriteria} in process {process.Id}{Constants.BusyMessage}";
		AutomationElement element = WaitTillFound(() => Finder.FindWindow(searchCriteria, process.Id), message);
		return ChildWindowFactory.Create(element, option, windowSession);
	}

	public virtual Window FindWindow(Process process, Predicate<string> match, InitializeOption initializeOption, WindowSession windowSession)
	{
		string message = $"Could not find window matching condition. ProcessName: {process.ProcessName}, ProcessId: {process.Id}, MatchingConditionMethod: {match.Method}, MatchingConditionTarget: {match.Target}";
		AutomationElement element = WaitTillFound(() => FindWindowElement(process, match), message);
		return ChildWindowFactory.Create(element, initializeOption, windowSession);
	}

	private AutomationElement FindWindowElement(Process process, Predicate<string> match)
	{
		List<AutomationElement> list = FindAllWindowElements(process);
		return list.Find(delegate(AutomationElement obj)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			Predicate<string> predicate = match;
			AutomationElementInformation current = obj.get_Current();
			if (predicate(((AutomationElementInformation)(ref current)).get_Name()))
			{
				return true;
			}
			AutomationElement val = new AutomationElementFinder(obj).Child(AutomationSearchCondition.ByControlType(ControlType.TitleBar));
			if (val == (AutomationElement)null)
			{
				return false;
			}
			Predicate<string> predicate2 = match;
			AutomationElementInformation current2 = val.get_Current();
			return predicate2(((AutomationElementInformation)(ref current2)).get_Name());
		});
	}

	public virtual Window FindModalWindow(string title, Process process, InitializeOption option, AutomationElement parentWindowElement, WindowSession windowSession)
	{
		AutomationElementFinder windowFinder = new AutomationElementFinder(parentWindowElement);
		try
		{
			AutomationElement element = WaitTillFound(() => windowFinder.FindWindow(title, process.Id) ?? Finder.FindWindow(title, process.Id), "Could not find modal window with title: " + title);
			return ChildWindowFactory.Create(element, option, windowSession);
		}
		catch (UIActionException ex)
		{
			logger.Debug((object)ex.ToString());
			return null;
		}
	}

	public virtual Window FindModalWindow(SearchCriteria searchCriteria, InitializeOption option, AutomationElement parentWindowElement, WindowSession windowSession)
	{
		AutomationElementFinder windowFinder = new AutomationElementFinder(parentWindowElement);
		try
		{
			AutomationElement element = WaitTillFound(() => windowFinder.FindWindow(searchCriteria) ?? Finder.FindWindow(searchCriteria), "Could not find modal window with SearchCriteria: " + searchCriteria);
			return ChildWindowFactory.Create(element, option, windowSession);
		}
		catch (UIActionException ex)
		{
			logger.Debug((object)ex.ToString());
			return null;
		}
	}

	public virtual List<Window> DesktopWindows()
	{
		List<Window> list = new List<Window>();
		AddWindowsBy(list, ControlType.Window);
		AddWindowsBy(list, ControlType.Pane);
		return list;
	}

	private void AddWindowsBy(List<Window> windows, ControlType controlType)
	{
		List<AutomationElement> list = Finder.Children(AutomationSearchCondition.ByControlType(controlType));
		foreach (AutomationElement item in list)
		{
			windows.Add(ChildWindowFactory.Create(item, InitializeOption.NoCache, new NullWindowSession()));
		}
	}

	public static void AddSpecializedWindowFactory(SpecializedWindowFactory specializedWindowFactory)
	{
		ChildWindowFactory.SpecializedWindowFactories.Add(specializedWindowFactory);
	}
}
