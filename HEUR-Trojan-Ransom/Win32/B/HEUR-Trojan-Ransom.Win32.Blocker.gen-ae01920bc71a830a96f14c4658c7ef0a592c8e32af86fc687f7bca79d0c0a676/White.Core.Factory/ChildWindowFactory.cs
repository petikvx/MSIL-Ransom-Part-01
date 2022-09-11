using System;
using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Sessions;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;
using White.Core.Utility;

namespace White.Core.Factory;

public abstract class ChildWindowFactory
{
	protected readonly AutomationElementFinder Finder;

	protected static readonly List<SpecializedWindowFactory> SpecializedWindowFactories = new List<SpecializedWindowFactory>();

	protected ChildWindowFactory(AutomationElementFinder finder)
	{
		Finder = finder;
	}

	public virtual Window ModalWindow(string title, InitializeOption option, WindowSession windowSession)
	{
		return ModalWindow(() => Finder.FindWindow(title, 0), option, windowSession);
	}

	private static Window ModalWindow(Func<AutomationElement> find, InitializeOption option, WindowSession windowSession)
	{
		AutomationElement val = Retry.For(find, (AutomationElement e) => e == (AutomationElement)null, CoreAppXmlConfiguration.Instance.BusyTimeout());
		if (!(val == (AutomationElement)null))
		{
			return Create(val, option, windowSession);
		}
		return null;
	}

	public virtual Window ModalWindow(SearchCriteria searchCriteria, InitializeOption option, WindowSession windowSession)
	{
		return ModalWindow(() => Finder.FindWindow(searchCriteria), option, windowSession);
	}

	internal static Window Create(AutomationElement element, InitializeOption option, WindowSession windowSession)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		SpecializedWindowFactory specializedWindowFactory = SpecializedWindowFactories.Find((SpecializedWindowFactory factory) => factory.DoesSpecializeInThis(element));
		if (specializedWindowFactory != null)
		{
			return specializedWindowFactory.Create(element, option, windowSession);
		}
		AutomationElementInformation current = element.get_Current();
		WindowsFramework windowsFramework = new WindowsFramework(((AutomationElementInformation)(ref current)).get_FrameworkId());
		if (windowsFramework.WinForm)
		{
			return new WinFormWindow(element, option, windowSession);
		}
		if (windowsFramework.WPF)
		{
			return new WPFWindow(element, WindowFactory.Desktop, option, windowSession);
		}
		if (windowsFramework.Win32)
		{
			return new Win32Window(element, WindowFactory.Desktop, option, windowSession);
		}
		if (!windowsFramework.UIAutomationBug)
		{
			throw new UIItemSearchException($"{windowsFramework} is not supported yet.");
		}
		return null;
	}
}
