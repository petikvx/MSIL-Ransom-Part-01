namespace Gecko.WebIDL;

public class ScrollBoxObject : WebIDLBase
{
	public int PositionX => GetProperty<int>("positionX");

	public int PositionY => GetProperty<int>("positionY");

	public int ScrolledWidth => GetProperty<int>("scrolledWidth");

	public int ScrolledHeight => GetProperty<int>("scrolledHeight");

	public ScrollBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void ScrollTo(int x, int y)
	{
		CallVoidMethod("scrollTo", x, y);
	}

	public void ScrollBy(int dx, int dy)
	{
		CallVoidMethod("scrollBy", dx, dy);
	}

	public void ScrollByLine(int dlines)
	{
		CallVoidMethod("scrollByLine", dlines);
	}

	public void ScrollByIndex(int dindexes)
	{
		CallVoidMethod("scrollByIndex", dindexes);
	}

	public void ScrollToLine(int line)
	{
		CallVoidMethod("scrollToLine", line);
	}

	public void ScrollToElement(nsIDOMElement child)
	{
		CallVoidMethod("scrollToElement", child);
	}

	public void ScrollToIndex(int index)
	{
		CallVoidMethod("scrollToIndex", index);
	}

	public void GetPosition(object x, object y)
	{
		CallVoidMethod("getPosition", x, y);
	}

	public void GetScrolledSize(object width, object height)
	{
		CallVoidMethod("getScrolledSize", width, height);
	}

	public void EnsureElementIsVisible(nsIDOMElement child)
	{
		CallVoidMethod("ensureElementIsVisible", child);
	}

	public void EnsureIndexIsVisible(int index)
	{
		CallVoidMethod("ensureIndexIsVisible", index);
	}

	public void EnsureLineIsVisible(int line)
	{
		CallVoidMethod("ensureLineIsVisible", line);
	}
}
