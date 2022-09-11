using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Automation;
using Castle.DynamicProxy;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.InputDevices;
using White.Core.Interceptors;
using White.Core.Sessions;
using White.Core.UIA;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Container;
using White.Core.UIItems.Custom;
using White.Core.UIItems.Finders;
using White.Core.UIItems.Scrolling;
using White.Core.UIItems.TabItems;
using White.Core.UIItems.WindowStripControls;
using White.Core.Utility;

namespace White.Core.UIItems;

public class UIItemContainer : UIItem, ActionListener, IUIItem, IUIItemContainer, VerticalSpanProvider
{
	protected readonly CurrentContainerItemFactory CurrentContainerItemFactory;

	protected WindowSession WindowSession = new NullWindowSession();

	protected virtual ActionListener ChildrenActionListener
	{
		get
		{
			if (!HasActionInterceptionBehaviour())
			{
				return actionListener;
			}
			return this;
		}
	}

	public virtual UIItemCollection Items => CurrentContainerItemFactory.FindAll();

	public virtual AttachedKeyboard Keyboard => new AttachedKeyboard(this, keyboard);

	public virtual AttachedMouse Mouse => new AttachedMouse(UIItem.mouse, this);

	public virtual VerticalSpan VerticalSpan => new VerticalSpan(Bounds);

	public virtual MenuBar MenuBar => (MenuBar)Get(SearchCriteria.ForMenuBar(Framework));

	public virtual List<MenuBar> MenuBars => new List<MenuBar>(GetMultiple(SearchCriteria.ForMenuBar(Framework)).OfType<MenuBar>());

	public virtual ToolTip ToolTip => factory.ToolTip;

	public virtual ToolStrip ToolStrip
	{
		get
		{
			Focus();
			return (ToolStrip)Get(SearchCriteria.ByControlType(ControlType.ToolBar));
		}
	}

	public virtual List<Tab> Tabs => CurrentContainerItemFactory.FindAll<Tab>();

	protected UIItemContainer()
	{
	}

	public UIItemContainer(AutomationElement automationElement, ActionListener actionListener, InitializeOption initializeOption, WindowSession windowSession)
		: base(automationElement, actionListener)
	{
		WindowSession = windowSession;
		CurrentContainerItemFactory = new CurrentContainerItemFactory(factory, initializeOption, automationElement, ChildrenActionListener);
	}

	public UIItemContainer(AutomationElement automationElement, ActionListener actionListener)
		: this(automationElement, actionListener, InitializeOption.NoCache, new NullWindowSession())
	{
	}

	public virtual T Get<T>() where T : UIItem
	{
		return Get<T>(SearchCriteria.All);
	}

	public virtual T Get<T>(string primaryIdentification) where T : UIItem
	{
		return Get<T>(SearchCriteria.ByAutomationId(primaryIdentification));
	}

	public virtual T Get<T>(SearchCriteria searchCriteria) where T : UIItem
	{
		return (T)Get(searchCriteria.AndControlType(typeof(T)));
	}

	public virtual IUIItem Get(SearchCriteria searchCriteria)
	{
		try
		{
			IUIItem iUIItem = Retry.For(() => CurrentContainerItemFactory.Find(searchCriteria, WindowSession), (IUIItem b) => (bool)b.AutomationElement.GetCurrentPropertyValue(AutomationElement.IsOffscreenProperty, false), CoreAppXmlConfiguration.Instance.BusyTimeout());
			if (iUIItem == null)
			{
				string debugDetails = Debug.Details(automationElement);
				throw new AutomationException($"Failed to get {searchCriteria}", debugDetails);
			}
			HandleIfCustomUIItem(iUIItem);
			HandleIfUIItemContainer(iUIItem);
			return iUIItem;
		}
		catch (AutomationException)
		{
			throw;
		}
		catch (Exception innerException)
		{
			string debugDetails2 = Debug.Details(automationElement);
			throw new WhiteException($"Error occured while geting {searchCriteria}", debugDetails2, innerException);
		}
	}

	private void HandleIfUIItemContainer(IUIItem uiItem)
	{
		if (uiItem is UIItemContainer uIItemContainer)
		{
			uIItemContainer.Associate(WindowSession);
		}
	}

	private void HandleIfCustomUIItem(IUIItem uiItem)
	{
		if (uiItem is CustomUIItem customUIItem)
		{
			FieldInfo field = customUIItem.GetType().GetField("__interceptors", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			IInterceptor[] array = (IInterceptor[])field.GetValue(customUIItem);
			CustomUIItem customUIItem2 = (CustomUIItem)((CoreInterceptor)(object)array[0]).Context.UiItem;
			customUIItem2.SetContainer(new UIItemContainer(customUIItem.AutomationElement, ChildrenActionListener, InitializeOption.NoCache, WindowSession));
		}
	}

	public virtual void ReInitialize(InitializeOption option)
	{
		CurrentContainerItemFactory.ReInitialize(option);
	}

	private bool HasActionInterceptionBehaviour()
	{
		return ScrollBars.CanScroll;
	}

	public virtual IUIItem[] GetMultiple(SearchCriteria criteria)
	{
		return CurrentContainerItemFactory.FindAll(criteria).ToArray();
	}

	internal virtual void Associate(WindowSession session)
	{
		WindowSession = session;
	}

	public override void ActionPerforming(UIItem uiItem)
	{
		Focus();
		ScreenItem screenItem = new ScreenItem(uiItem, ScrollBars);
		screenItem.MakeVisible(this);
	}

	public virtual MenuBar GetMenuBar(SearchCriteria searchCriteria)
	{
		return (MenuBar)Get(SearchCriteria.ForMenuBar(Framework).Merge(searchCriteria));
	}

	public virtual ToolTip GetToolTipOn(UIItem uiItem)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Mouse.Location = uiItem.Bounds.Center();
		AutomationElementFinder finder = new AutomationElementFinder(automationElement);
		return ToolTipFinder.FindToolTip(() => finder.Descendant(AutomationSearchCondition.ByControlType(ControlType.ToolTip)));
	}

	public virtual ToolStrip GetToolStrip(string primaryIdentification)
	{
		ToolStrip toolStrip = (ToolStrip)Get(SearchCriteria.ByAutomationId(primaryIdentification));
		if (toolStrip == null)
		{
			return null;
		}
		toolStrip.Associate(WindowSession);
		return toolStrip;
	}

	public virtual List<UIItem> ItemsWithin(UIItem containingItem)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		UIItemCollection source = factory.ItemsWithin(containingItem.Bounds, this);
		return source.Where((IUIItem item) => !item.Equals(containingItem)).Cast<UIItem>().ToList();
	}

	protected virtual void CustomWait()
	{
		if (CoreAppXmlConfiguration.Instance.AdditionalWaitHook != null)
		{
			CoreAppXmlConfiguration.Instance.AdditionalWaitHook.WaitFor(this);
		}
	}
}
