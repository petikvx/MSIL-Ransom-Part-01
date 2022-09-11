using System.Windows;
using White.Core.UIA;
using White.Core.UIItems.Finders;

namespace White.Core.ScreenMap;

public class NullWindowItemsMap : WindowItemsMap
{
	public override bool LoadedFromFile => false;

	public override Point CurrentWindowPosition
	{
		set
		{
		}
	}

	public override void Add(Point point, SearchCriteria searchCriteria)
	{
	}

	public override Point GetItemLocation(SearchCriteria searchCriteria)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return RectX.UnlikelyWindowPosition;
	}

	public override void Save()
	{
	}
}
