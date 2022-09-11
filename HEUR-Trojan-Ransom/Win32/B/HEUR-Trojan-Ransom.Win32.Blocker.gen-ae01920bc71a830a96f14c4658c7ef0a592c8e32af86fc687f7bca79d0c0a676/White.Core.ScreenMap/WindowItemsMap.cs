using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Serialization;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.UIA;
using White.Core.UIItems.Finders;
using Xstream.Core;
using log4net;

namespace White.Core.ScreenMap;

public class WindowItemsMap : List<UIItemLocation>
{
	private readonly string fileLocation;

	[XmlIgnore]
	private bool dirty;

	[XmlIgnore]
	private bool loadedFromFile;

	private Point lastWindowPosition = RectX.UnlikelyWindowPosition;

	[XmlIgnore]
	private Point currentWindowPosition;

	private static readonly ILog Logger = LogManager.GetLogger(typeof(WindowItemsMap));

	public virtual bool LoadedFromFile => loadedFromFile;

	public virtual Point CurrentWindowPosition
	{
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			currentWindowPosition = value;
		}
	}

	protected WindowItemsMap()
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0006: Unknown result type (might be due to invalid IL or missing references)


	private WindowItemsMap(string fileLocation, Point windowPosition)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		this.fileLocation = fileLocation;
		currentWindowPosition = windowPosition;
	}

	public static WindowItemsMap Create(InitializeOption initializeOption, Point currentWindowPosition)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (initializeOption.NoIdentification)
		{
			return new NullWindowItemsMap();
		}
		string text = FileLocation(initializeOption);
		if (File.Exists(text))
		{
			Logger.DebugFormat("[PositionBasedSearch] Loading WindowItemsMap for: {0}, from {1}", (object)initializeOption.Identifier, (object)text);
			WindowItemsMap windowItemsMap = (WindowItemsMap)CreateFileXStream(text).FromFile();
			windowItemsMap.currentWindowPosition = currentWindowPosition;
			windowItemsMap.loadedFromFile = true;
			return windowItemsMap;
		}
		Logger.DebugFormat("[PositionBasedSearch] Creating new WindowItemsMap for: {0}", (object)initializeOption.Identifier);
		return new WindowItemsMap(text, currentWindowPosition);
	}

	public virtual void Add(Point point, SearchCriteria searchCriteria)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		UIItemLocation item = new UIItemLocation(point, searchCriteria);
		UIItemLocation uIItemLocation = this.FirstOrDefault((UIItemLocation obj) => obj.Has(searchCriteria));
		UIItemLocation uIItemLocation2 = this.FirstOrDefault(delegate(UIItemLocation obj)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			Point point2 = obj.Point;
			return ((Point)(ref point2)).Equals(point);
		});
		if (uIItemLocation != null)
		{
			Logger.Debug((object)$"[PositionBasedSearch] Found another UIItem {searchCriteria} at {uIItemLocation}");
			Remove(uIItemLocation);
		}
		else if (uIItemLocation2 != null)
		{
			Logger.Debug((object)$"[PositionBasedSearch] UIItem {searchCriteria} at {point} changed");
			Remove(uIItemLocation2);
		}
		Add(item);
		dirty = true;
	}

	public virtual Point GetItemLocation(SearchCriteria searchCriteria)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		UIItemLocation uIItemLocation = Find((UIItemLocation obj) => obj.Has(searchCriteria));
		if (uIItemLocation == null)
		{
			return RectX.UnlikelyWindowPosition;
		}
		double xOffset = ((Point)(ref currentWindowPosition)).get_X() - ((Point)(ref lastWindowPosition)).get_X();
		double yOffset = ((Point)(ref currentWindowPosition)).get_Y() - ((Point)(ref lastWindowPosition)).get_Y();
		return Offset(uIItemLocation.Point, xOffset, yOffset);
	}

	private static Point Offset(Point point, double xOffset, double yOffset)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return new Point(((Point)(ref point)).get_X() + xOffset, ((Point)(ref point)).get_Y() + yOffset);
	}

	private static string FileLocation(InitializeOption initializeOption)
	{
		return $"{CoreAppXmlConfiguration.Instance.WorkSessionLocation}\\{initializeOption.Identifier}.xml";
	}

	public virtual void Save()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (dirty)
		{
			lastWindowPosition = currentWindowPosition;
			CreateFileXStream(fileLocation).ToXml((object)this);
		}
	}

	private static FileXStream CreateFileXStream(string fileLocation)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		FileXStream val = new FileXStream(fileLocation);
		val.AddConverter((IConverter)(object)new ControlTypeConverter());
		val.AddIgnoreAttribute(typeof(XmlIgnoreAttribute));
		return val;
	}
}
