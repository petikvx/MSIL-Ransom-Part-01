using System;
using System.Windows;
using System.Windows.Automation;
using White.Core.Factory;
using White.Core.ScreenMap;
using White.Core.UIA;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Container;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;
using log4net;

namespace White.Core.Sessions;

public class WindowSession : IDisposable
{
	private readonly ApplicationSession applicationSession;

	private readonly WindowItemsMap windowItemsMap;

	private readonly InitializeOption initializeOption;

	private readonly ILog logger = LogManager.GetLogger(typeof(WindowSession));

	public WindowSession(ApplicationSession applicationSession, InitializeOption initializeOption)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		this.applicationSession = applicationSession;
		windowItemsMap = WindowItemsMap.Create(initializeOption, RectX.UnlikelyWindowPosition);
		if (windowItemsMap.LoadedFromFile)
		{
			initializeOption.NonCached();
		}
		this.initializeOption = initializeOption;
	}

	protected WindowSession()
	{
	}

	public virtual WindowSession ModalWindowSession(InitializeOption modalInitializeOption)
	{
		return applicationSession.WindowSession(modalInitializeOption);
	}

	public virtual IUIItem Get(ContainerItemFactory containerItemFactory, SearchCriteria searchCriteria, ActionListener actionListener)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		logger.DebugFormat("Finding item based on criteria: ({0}) on ({1})", (object)searchCriteria, (object)initializeOption.Identifier);
		Point itemLocation = windowItemsMap.GetItemLocation(searchCriteria);
		if (((Point)(ref itemLocation)).Equals(RectX.UnlikelyWindowPosition))
		{
			logger.Debug((object)"[PositionBasedSearch] Could not find based on position, finding using search.");
			return Create(containerItemFactory, searchCriteria, actionListener);
		}
		AutomationElement automationElementFromPoint = AutomationElementX.GetAutomationElementFromPoint(itemLocation);
		if (automationElementFromPoint != (AutomationElement)null && searchCriteria.AppliesTo(automationElementFromPoint))
		{
			IUIItem item = new DictionaryMappedItemFactory().Create(automationElementFromPoint, actionListener, searchCriteria.CustomItemType);
			return UIItemProxyFactory.Create(item, actionListener);
		}
		logger.DebugFormat("[PositionBasedSearch] UIItem {0} changed its position, finding using search.", (object)searchCriteria);
		return Create(containerItemFactory, searchCriteria, actionListener);
	}

	private IUIItem Create(ContainerItemFactory containerItemFactory, SearchCriteria searchCriteria, ActionListener actionListener)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		IUIItem iUIItem = containerItemFactory.Get(searchCriteria, actionListener);
		if (iUIItem == null)
		{
			return null;
		}
		windowItemsMap.Add(iUIItem.Location, searchCriteria);
		return iUIItem;
	}

	public virtual void Dispose()
	{
		windowItemsMap.Save();
	}

	public virtual void Register(Window window)
	{
		window.Focus();
		LocationChanged(window);
	}

	public virtual void LocationChanged(Window window)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		windowItemsMap.CurrentWindowPosition = window.Location;
	}
}
