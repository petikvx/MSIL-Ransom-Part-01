using System.Collections.Generic;
using White.Core.UIItems;

namespace White.Core.Finder;

public class UIItemPositionComparer : PositionBasedComparer, IComparer<IUIItem>
{
	public virtual int Compare(IUIItem x, IUIItem y)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return PositionBasedComparer.Compare(x.Bounds, y.Bounds);
	}
}
