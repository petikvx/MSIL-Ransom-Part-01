using System.Windows;
using White.Core.UIItems.Finders;

namespace White.Core.ScreenMap;

public class UIItemLocation
{
	private readonly Point point;

	private readonly SearchCriteria searchCriteria;

	public virtual Point Point => point;

	public virtual SearchCriteria SearchCriteria => searchCriteria;

	private UIItemLocation()
	{
	}

	public UIItemLocation(Point point, SearchCriteria searchCriteria)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		this.point = point;
		this.searchCriteria = searchCriteria;
	}

	public virtual bool Has(SearchCriteria criteria)
	{
		return criteria.Equals(searchCriteria);
	}

	public override string ToString()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return $"{searchCriteria} at point {point}";
	}
}
