using System.Drawing;
using System.Runtime.InteropServices;

namespace Gecko.DOM;

public static class GeckoElementExtensionMethods
{
	public static Rectangle GetBoundingClientRect(this GeckoElement element)
	{
		nsIDOMClientRect boundingClientRect = element.DOMElement.GetBoundingClientRect();
		if (boundingClientRect == null)
		{
			return Rectangle.Empty;
		}
		Rectangle result = new Rectangle((int)boundingClientRect.GetLeftAttribute(), (int)boundingClientRect.GetTopAttribute(), (int)boundingClientRect.GetWidthAttribute(), (int)boundingClientRect.GetHeightAttribute());
		Marshal.ReleaseComObject(boundingClientRect);
		return result;
	}
}
