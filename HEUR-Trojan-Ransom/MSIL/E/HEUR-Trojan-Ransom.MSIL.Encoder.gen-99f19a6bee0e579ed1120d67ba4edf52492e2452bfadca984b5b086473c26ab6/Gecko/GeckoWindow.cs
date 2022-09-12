using System;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko;

public class GeckoWindow : IEquatable<GeckoWindow>, IDisposable
{
	private ComPtr<nsIDOMWindow> _domWindow;

	public nsIDOMWindow DomWindow => _domWindow.Instance;

	public WindowUtils WindowUtils
	{
		get
		{
			nsIDOMWindowUtils obj = Xpcom.QueryInterface<nsIDOMWindowUtils>(DomWindow);
			return obj.Wrap(WindowUtils.Create);
		}
	}

	public GeckoDomDocument Document => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).Document.Wrap(GeckoDomDocument.CreateDomDocumentWraper);

	public GeckoWindow Parent => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).Parent.Wrap((nsIDOMWindow x) => new GeckoWindow(x));

	public int ScrollX => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollX;

	public int ScrollY => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollY;

	public int ScrollMinX => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollMinX;

	public int ScrollMinY => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollMinY;

	public int ScrollMaxX => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollMaxX;

	public int ScrollMaxY => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollMaxY;

	public GeckoWindow Top => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).Top.Wrap((nsIDOMWindow x) => new GeckoWindow(x));

	public string Name
	{
		get
		{
			return new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).Name;
		}
		set
		{
			new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).Name = value;
		}
	}

	public ulong MozPaintCount => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).MozPaintCount;

	public object Content => new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).Content;

	public GeckoSelection Selection => GeckoSelection.Create(new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).GetSelection());

	public GeckoWindow(nsIDOMWindow window, bool ownRCW = true)
	{
		_domWindow = new ComPtr<nsIDOMWindow>(window, ownRCW);
	}

	~GeckoWindow()
	{
		Xpcom.DisposeObject(ref _domWindow);
	}

	public void Dispose()
	{
		Xpcom.DisposeObject(ref _domWindow);
		GC.SuppressFinalize(this);
	}

	public void ScrollTo(int xScroll, int yScroll)
	{
		new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollTo(xScroll, yScroll);
	}

	public void ScrollBy(double xScrollDif, double yScrollDif)
	{
		new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollBy(xScrollDif, yScrollDif);
	}

	public void ScrollByLines(int numLines)
	{
		new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollByLines(numLines);
	}

	public void ScrollByPages(int numPages)
	{
		new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).ScrollByPages(numPages);
	}

	public void SizeToContent()
	{
		new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).SizeToContent();
	}

	public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
	{
		return new Window(_domWindow.Instance, (nsISupports)_domWindow.Instance).Find(str, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames, showDialog);
	}

	public void Print()
	{
		nsIWebBrowserPrint nsIWebBrowserPrint2 = Xpcom.QueryInterface<nsIWebBrowserPrint>(_domWindow.Instance);
		try
		{
			nsIWebBrowserPrint2.Print(null, null);
		}
		catch (COMException ex)
		{
			if (ex.ErrorCode != -2147467260)
			{
				throw;
			}
		}
		Marshal.ReleaseComObject(nsIWebBrowserPrint2);
	}

	public bool Equals(GeckoWindow other)
	{
		if (this == other)
		{
			return true;
		}
		if (other == null)
		{
			return false;
		}
		return _domWindow.Instance.GetHashCode() == other._domWindow.Instance.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (obj == null)
		{
			return false;
		}
		return _domWindow.Instance.GetHashCode() == ((GeckoWindow)obj)._domWindow.Instance.GetHashCode();
	}

	public override int GetHashCode()
	{
		return _domWindow.Instance.GetHashCode();
	}
}
