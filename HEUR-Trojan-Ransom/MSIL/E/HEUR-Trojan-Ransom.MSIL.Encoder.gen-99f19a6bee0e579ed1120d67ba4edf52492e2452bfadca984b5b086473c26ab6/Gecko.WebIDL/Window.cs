namespace Gecko.WebIDL;

public class Window : WebIDLBase
{
	public nsIDOMWindow WindowAttribute => GetProperty<nsIDOMWindow>("window");

	public nsIDOMWindow Self => GetProperty<nsIDOMWindow>("self");

	public nsIDOMDocument Document => GetProperty<nsIDOMDocument>("document");

	public string Name
	{
		get
		{
			return GetProperty<string>("name");
		}
		set
		{
			SetProperty("name", value);
		}
	}

	public nsIDOMLocation Location => GetProperty<nsIDOMLocation>("location");

	public nsIDOMHistory History => GetProperty<nsIDOMHistory>("history");

	public nsISupports Locationbar => GetProperty<nsISupports>("locationbar");

	public nsISupports Menubar => GetProperty<nsISupports>("menubar");

	public nsISupports Personalbar => GetProperty<nsISupports>("personalbar");

	public nsISupports Scrollbars => GetProperty<nsISupports>("scrollbars");

	public nsISupports Statusbar => GetProperty<nsISupports>("statusbar");

	public nsISupports Toolbar => GetProperty<nsISupports>("toolbar");

	public string Status
	{
		get
		{
			return GetProperty<string>("status");
		}
		set
		{
			SetProperty("status", value);
		}
	}

	public bool Closed => GetProperty<bool>("closed");

	public nsIDOMWindow Frames => GetProperty<nsIDOMWindow>("frames");

	public uint Length => GetProperty<uint>("length");

	public nsIDOMWindow Top => GetProperty<nsIDOMWindow>("top");

	public nsIDOMWindow PrivateRoot => GetProperty<nsIDOMWindow>("privateRoot");

	public object Opener
	{
		get
		{
			return GetProperty<object>("opener");
		}
		set
		{
			SetProperty("opener", value);
		}
	}

	public nsIDOMWindow Parent => GetProperty<nsIDOMWindow>("parent");

	public nsIDOMElement FrameElement => GetProperty<nsIDOMElement>("frameElement");

	public nsIDOMNavigator Navigator => GetProperty<nsIDOMNavigator>("navigator");

	public nsISupports ApplicationCache => GetProperty<nsISupports>("applicationCache");

	public nsISupports Screen => GetProperty<nsISupports>("screen");

	public object InnerWidth
	{
		get
		{
			return GetProperty<object>("innerWidth");
		}
		set
		{
			SetProperty("innerWidth", value);
		}
	}

	public object InnerHeight
	{
		get
		{
			return GetProperty<object>("innerHeight");
		}
		set
		{
			SetProperty("innerHeight", value);
		}
	}

	public int ScrollX => GetProperty<int>("scrollX");

	public int PageXOffset => GetProperty<int>("pageXOffset");

	public int ScrollY => GetProperty<int>("scrollY");

	public int PageYOffset => GetProperty<int>("pageYOffset");

	public object ScreenX
	{
		get
		{
			return GetProperty<object>("screenX");
		}
		set
		{
			SetProperty("screenX", value);
		}
	}

	public object ScreenY
	{
		get
		{
			return GetProperty<object>("screenY");
		}
		set
		{
			SetProperty("screenY", value);
		}
	}

	public object OuterWidth
	{
		get
		{
			return GetProperty<object>("outerWidth");
		}
		set
		{
			SetProperty("outerWidth", value);
		}
	}

	public object OuterHeight
	{
		get
		{
			return GetProperty<object>("outerHeight");
		}
		set
		{
			SetProperty("outerHeight", value);
		}
	}

	public nsISupports Performance => GetProperty<nsISupports>("performance");

	public nsISupports Caches => GetProperty<nsISupports>("caches");

	public nsISupports Controllers => GetProperty<nsISupports>("controllers");

	public nsIDOMElement RealFrameElement => GetProperty<nsIDOMElement>("realFrameElement");

	public float MozInnerScreenX => GetProperty<float>("mozInnerScreenX");

	public float MozInnerScreenY => GetProperty<float>("mozInnerScreenY");

	public float DevicePixelRatio => GetProperty<float>("devicePixelRatio");

	public int ScrollMinX => GetProperty<int>("scrollMinX");

	public int ScrollMinY => GetProperty<int>("scrollMinY");

	public int ScrollMaxX => GetProperty<int>("scrollMaxX");

	public int ScrollMaxY => GetProperty<int>("scrollMaxY");

	public bool FullScreen
	{
		get
		{
			return GetProperty<bool>("fullScreen");
		}
		set
		{
			SetProperty("fullScreen", value);
		}
	}

	public ulong MozPaintCount => GetProperty<ulong>("mozPaintCount");

	public nsISupports MozSelfSupport => GetProperty<nsISupports>("MozSelfSupport");

	public object Content => GetProperty<object>("content");

	public object __content => GetProperty<object>("__content");

	public nsIDOMEventTarget WindowRoot => GetProperty<nsIDOMEventTarget>("windowRoot");

	public nsISupports Console => GetProperty<nsISupports>("console");

	public Window(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public void Stop()
	{
		CallVoidMethod("stop");
	}

	public void Focus()
	{
		CallVoidMethod("focus");
	}

	public void Blur()
	{
		CallVoidMethod("blur");
	}

	public nsIDOMWindow Open()
	{
		return CallMethod<nsIDOMWindow>("open", new object[0]);
	}

	public nsIDOMWindow Open(string url)
	{
		return CallMethod<nsIDOMWindow>("open", new object[1] { url });
	}

	public nsIDOMWindow Open(string url, string target)
	{
		return CallMethod<nsIDOMWindow>("open", new object[2] { url, target });
	}

	public nsIDOMWindow Open(string url, string target, string features)
	{
		return CallMethod<nsIDOMWindow>("open", new object[3] { url, target, features });
	}

	public void Alert()
	{
		CallVoidMethod("alert");
	}

	public void Alert(string message)
	{
		CallVoidMethod("alert", message);
	}

	public bool Confirm()
	{
		return CallMethod<bool>("confirm", new object[0]);
	}

	public bool Confirm(string message)
	{
		return CallMethod<bool>("confirm", new object[1] { message });
	}

	public string Prompt()
	{
		return CallMethod<string>("prompt", new object[0]);
	}

	public string Prompt(string message)
	{
		return CallMethod<string>("prompt", new object[1] { message });
	}

	public string Prompt(string message, string @default)
	{
		return CallMethod<string>("prompt", new object[2] { message, @default });
	}

	public void Print()
	{
		CallVoidMethod("print");
	}

	public object ShowModalDialog(string url)
	{
		return CallMethod<object>("showModalDialog", new object[1] { url });
	}

	public object ShowModalDialog(string url, object argument)
	{
		return CallMethod<object>("showModalDialog", new object[2] { url, argument });
	}

	public object ShowModalDialog(string url, object argument, string options)
	{
		return CallMethod<object>("showModalDialog", new object[3] { url, argument, options });
	}

	public void PostMessage(object message, string targetOrigin)
	{
		CallVoidMethod("postMessage", message, targetOrigin);
	}

	public void PostMessage(object message, string targetOrigin, object[] transfer)
	{
		CallVoidMethod("postMessage", message, targetOrigin, transfer);
	}

	public void CaptureEvents()
	{
		CallVoidMethod("captureEvents");
	}

	public void ReleaseEvents()
	{
		CallVoidMethod("releaseEvents");
	}

	public nsISelection GetSelection()
	{
		return CallMethod<nsISelection>("getSelection", new object[0]);
	}

	public nsIDOMCSSStyleDeclaration GetComputedStyle(nsIDOMElement elt)
	{
		return CallMethod<nsIDOMCSSStyleDeclaration>("getComputedStyle", new object[1] { elt });
	}

	public nsIDOMCSSStyleDeclaration GetComputedStyle(nsIDOMElement elt, string pseudoElt)
	{
		return CallMethod<nsIDOMCSSStyleDeclaration>("getComputedStyle", new object[2] { elt, pseudoElt });
	}

	public nsISupports MatchMedia(string query)
	{
		return CallMethod<nsISupports>("matchMedia", new object[1] { query });
	}

	public void MoveTo(int x, int y)
	{
		CallVoidMethod("moveTo", x, y);
	}

	public void MoveBy(int x, int y)
	{
		CallVoidMethod("moveBy", x, y);
	}

	public void ResizeTo(int x, int y)
	{
		CallVoidMethod("resizeTo", x, y);
	}

	public void ResizeBy(int x, int y)
	{
		CallVoidMethod("resizeBy", x, y);
	}

	public void Scroll(double x, double y)
	{
		CallVoidMethod("scroll", x, y);
	}

	public void Scroll()
	{
		CallVoidMethod("scroll");
	}

	public void Scroll(object options)
	{
		CallVoidMethod("scroll", options);
	}

	public void ScrollTo(double x, double y)
	{
		CallVoidMethod("scrollTo", x, y);
	}

	public void ScrollTo()
	{
		CallVoidMethod("scrollTo");
	}

	public void ScrollTo(object options)
	{
		CallVoidMethod("scrollTo", options);
	}

	public void ScrollBy(double x, double y)
	{
		CallVoidMethod("scrollBy", x, y);
	}

	public void ScrollBy()
	{
		CallVoidMethod("scrollBy");
	}

	public void ScrollBy(object options)
	{
		CallVoidMethod("scrollBy", options);
	}

	public void MozScrollSnap()
	{
		CallVoidMethod("mozScrollSnap");
	}

	public void CancelAnimationFrame(int handle)
	{
		CallVoidMethod("cancelAnimationFrame", handle);
	}

	public nsIDOMCSSStyleDeclaration GetDefaultComputedStyle(nsIDOMElement elt)
	{
		return CallMethod<nsIDOMCSSStyleDeclaration>("getDefaultComputedStyle", new object[1] { elt });
	}

	public nsIDOMCSSStyleDeclaration GetDefaultComputedStyle(nsIDOMElement elt, string pseudoElt)
	{
		return CallMethod<nsIDOMCSSStyleDeclaration>("getDefaultComputedStyle", new object[2] { elt, pseudoElt });
	}

	public void ScrollByLines(int numLines)
	{
		CallVoidMethod("scrollByLines", numLines);
	}

	public void ScrollByLines(int numLines, object options)
	{
		CallVoidMethod("scrollByLines", numLines, options);
	}

	public void ScrollByPages(int numPages)
	{
		CallVoidMethod("scrollByPages", numPages);
	}

	public void ScrollByPages(int numPages, object options)
	{
		CallVoidMethod("scrollByPages", numPages, options);
	}

	public void SizeToContent()
	{
		CallVoidMethod("sizeToContent");
	}

	public void Back()
	{
		CallVoidMethod("back");
	}

	public void Forward()
	{
		CallVoidMethod("forward");
	}

	public void Home()
	{
		CallVoidMethod("home");
	}

	public void UpdateCommands(string action)
	{
		CallVoidMethod("updateCommands", action);
	}

	public void UpdateCommands(string action, nsISelection sel)
	{
		CallVoidMethod("updateCommands", action, sel);
	}

	public void UpdateCommands(string action, nsISelection sel, short reason)
	{
		CallVoidMethod("updateCommands", action, sel, reason);
	}

	public bool Find()
	{
		return CallMethod<bool>("find", new object[0]);
	}

	public bool Find(string str)
	{
		return CallMethod<bool>("find", new object[1] { str });
	}

	public bool Find(string str, bool caseSensitive)
	{
		return CallMethod<bool>("find", new object[2] { str, caseSensitive });
	}

	public bool Find(string str, bool caseSensitive, bool backwards)
	{
		return CallMethod<bool>("find", new object[3] { str, caseSensitive, backwards });
	}

	public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround)
	{
		return CallMethod<bool>("find", new object[4] { str, caseSensitive, backwards, wrapAround });
	}

	public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord)
	{
		return CallMethod<bool>("find", new object[5] { str, caseSensitive, backwards, wrapAround, wholeWord });
	}

	public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames)
	{
		return CallMethod<bool>("find", new object[6] { str, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames });
	}

	public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
	{
		return CallMethod<bool>("find", new object[7] { str, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames, showDialog });
	}

	public void Dump(string str)
	{
		CallVoidMethod("dump", str);
	}

	public void SetResizable(bool resizable)
	{
		CallVoidMethod("setResizable", resizable);
	}

	public nsIDOMWindow OpenDialog()
	{
		return CallMethod<nsIDOMWindow>("openDialog", new object[0]);
	}

	public nsIDOMWindow OpenDialog(string url)
	{
		return CallMethod<nsIDOMWindow>("openDialog", new object[1] { url });
	}

	public nsIDOMWindow OpenDialog(string url, string name)
	{
		return CallMethod<nsIDOMWindow>("openDialog", new object[2] { url, name });
	}

	public nsIDOMWindow OpenDialog(string url, string name, string options)
	{
		return CallMethod<nsIDOMWindow>("openDialog", new object[3] { url, name, options });
	}

	public nsIDOMWindow OpenDialog(string url, string name, string options, object extraArguments)
	{
		return CallMethod<nsIDOMWindow>("openDialog", new object[4] { url, name, options, extraArguments });
	}

	public object GetInterface(nsISupports iid)
	{
		return CallMethod<object>("getInterface", new object[1] { iid });
	}
}
