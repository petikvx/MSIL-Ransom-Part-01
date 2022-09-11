using System.Windows;

namespace White.Core.Finder;

public class PositionBasedComparer
{
	protected static int Compare(Rect rectX, Rect rectY)
	{
		if (((Rect)(ref rectX)).get_Top().Equals(((Rect)(ref rectY)).get_Top()))
		{
			return ((Rect)(ref rectX)).get_Left().CompareTo(((Rect)(ref rectY)).get_Left());
		}
		return ((Rect)(ref rectX)).get_Top().CompareTo(((Rect)(ref rectY)).get_Top());
	}
}
