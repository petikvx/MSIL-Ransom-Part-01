namespace Gecko.WebIDL;

public class Document : WebIDLBase
{
	public nsISupports Implementation => GetProperty<nsISupports>("implementation");

	public string URL => GetProperty<string>("URL");

	public string DocumentURI => GetProperty<string>("documentURI");

	public string CompatMode => GetProperty<string>("compatMode");

	public string CharacterSet => GetProperty<string>("characterSet");

	public string Charset => GetProperty<string>("charset");

	public string InputEncoding => GetProperty<string>("inputEncoding");

	public string ContentType => GetProperty<string>("contentType");

	public nsISupports Doctype => GetProperty<nsISupports>("doctype");

	public nsIDOMElement DocumentElement => GetProperty<nsIDOMElement>("documentElement");

	public nsIDOMLocation Location => GetProperty<nsIDOMLocation>("location");

	public string Referrer => GetProperty<string>("referrer");

	public string LastModified => GetProperty<string>("lastModified");

	public string ReadyState => GetProperty<string>("readyState");

	public string Title
	{
		get
		{
			return GetProperty<string>("title");
		}
		set
		{
			SetProperty("title", value);
		}
	}

	public string Dir
	{
		get
		{
			return GetProperty<string>("dir");
		}
		set
		{
			SetProperty("dir", value);
		}
	}

	public nsIDOMWindow DefaultView => GetProperty<nsIDOMWindow>("defaultView");

	public nsIDOMElement ActiveElement => GetProperty<nsIDOMElement>("activeElement");

	public bool MozSyntheticDocument => GetProperty<bool>("mozSyntheticDocument");

	public nsIDOMElement CurrentScript => GetProperty<nsIDOMElement>("currentScript");

	public nsISupports DocumentURIObject => GetProperty<nsISupports>("documentURIObject");

	public uint ReferrerPolicy => GetProperty<uint>("referrerPolicy");

	public bool MozFullScreenEnabled => GetProperty<bool>("mozFullScreenEnabled");

	public nsIDOMElement MozFullScreenElement => GetProperty<nsIDOMElement>("mozFullScreenElement");

	public bool MozFullScreen => GetProperty<bool>("mozFullScreen");

	public nsIDOMElement MozPointerLockElement => GetProperty<nsIDOMElement>("mozPointerLockElement");

	public bool Hidden => GetProperty<bool>("hidden");

	public bool MozHidden => GetProperty<bool>("mozHidden");

	public VisibilityState VisibilityState => GetProperty<VisibilityState>("visibilityState");

	public VisibilityState MozVisibilityState => GetProperty<VisibilityState>("mozVisibilityState");

	public nsISupports StyleSheets => GetProperty<nsISupports>("styleSheets");

	public string SelectedStyleSheetSet
	{
		get
		{
			return GetProperty<string>("selectedStyleSheetSet");
		}
		set
		{
			SetProperty("selectedStyleSheetSet", value);
		}
	}

	public string LastStyleSheetSet => GetProperty<string>("lastStyleSheetSet");

	public string PreferredStyleSheetSet => GetProperty<string>("preferredStyleSheetSet");

	public nsISupports StyleSheetSets => GetProperty<nsISupports>("styleSheetSets");

	public nsISupports UndoManager => GetProperty<nsISupports>("undoManager");

	public nsISupports Timeline => GetProperty<nsISupports>("timeline");

	public bool StyleSheetChangeEventsEnabled
	{
		get
		{
			return GetProperty<bool>("styleSheetChangeEventsEnabled");
		}
		set
		{
			SetProperty("styleSheetChangeEventsEnabled", value);
		}
	}

	public nsISupports DocShell => GetProperty<nsISupports>("docShell");

	public string ContentLanguage => GetProperty<string>("contentLanguage");

	public nsISupports DocumentLoadGroup => GetProperty<nsISupports>("documentLoadGroup");

	public bool IsSrcdocDocument => GetProperty<bool>("isSrcdocDocument");

	public bool UserHasInteracted => GetProperty<bool>("userHasInteracted");

	public Document(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetElementsByTagName(string localName)
	{
		return CallMethod<nsISupports>("getElementsByTagName", new object[1] { localName });
	}

	public nsISupports GetElementsByTagNameNS(string @namespace, string localName)
	{
		return CallMethod<nsISupports>("getElementsByTagNameNS", new object[2] { @namespace, localName });
	}

	public nsISupports GetElementsByClassName(string classNames)
	{
		return CallMethod<nsISupports>("getElementsByClassName", new object[1] { classNames });
	}

	public nsIDOMElement GetElementById(string elementId)
	{
		return CallMethod<nsIDOMElement>("getElementById", new object[1] { elementId });
	}

	public nsIDOMElement CreateElement(string localName)
	{
		return CallMethod<nsIDOMElement>("createElement", new object[1] { localName });
	}

	public nsIDOMElement CreateElementNS(string @namespace, string qualifiedName)
	{
		return CallMethod<nsIDOMElement>("createElementNS", new object[2] { @namespace, qualifiedName });
	}

	public nsISupports CreateDocumentFragment()
	{
		return CallMethod<nsISupports>("createDocumentFragment", new object[0]);
	}

	public nsIDOMText CreateTextNode(string data)
	{
		return CallMethod<nsIDOMText>("createTextNode", new object[1] { data });
	}

	public nsISupports CreateComment(string data)
	{
		return CallMethod<nsISupports>("createComment", new object[1] { data });
	}

	public nsISupports CreateProcessingInstruction(string target, string data)
	{
		return CallMethod<nsISupports>("createProcessingInstruction", new object[2] { target, data });
	}

	public nsIDOMNode ImportNode(nsIDOMNode node)
	{
		return CallMethod<nsIDOMNode>("importNode", new object[1] { node });
	}

	public nsIDOMNode ImportNode(nsIDOMNode node, bool deep)
	{
		return CallMethod<nsIDOMNode>("importNode", new object[2] { node, deep });
	}

	public nsIDOMNode AdoptNode(nsIDOMNode node)
	{
		return CallMethod<nsIDOMNode>("adoptNode", new object[1] { node });
	}

	public nsIDOMEvent CreateEvent(string @interface)
	{
		return CallMethod<nsIDOMEvent>("createEvent", new object[1] { @interface });
	}

	public nsISupports CreateRange()
	{
		return CallMethod<nsISupports>("createRange", new object[0]);
	}

	public nsISupports CreateNodeIterator(nsIDOMNode root)
	{
		return CallMethod<nsISupports>("createNodeIterator", new object[1] { root });
	}

	public nsISupports CreateNodeIterator(nsIDOMNode root, uint whatToShow)
	{
		return CallMethod<nsISupports>("createNodeIterator", new object[2] { root, whatToShow });
	}

	public nsISupports CreateNodeIterator(nsIDOMNode root, uint whatToShow, nsISupports filter)
	{
		return CallMethod<nsISupports>("createNodeIterator", new object[3] { root, whatToShow, filter });
	}

	public nsISupports CreateTreeWalker(nsIDOMNode root)
	{
		return CallMethod<nsISupports>("createTreeWalker", new object[1] { root });
	}

	public nsISupports CreateTreeWalker(nsIDOMNode root, uint whatToShow)
	{
		return CallMethod<nsISupports>("createTreeWalker", new object[2] { root, whatToShow });
	}

	public nsISupports CreateTreeWalker(nsIDOMNode root, uint whatToShow, nsISupports filter)
	{
		return CallMethod<nsISupports>("createTreeWalker", new object[3] { root, whatToShow, filter });
	}

	public nsISupports CreateCDATASection(string data)
	{
		return CallMethod<nsISupports>("createCDATASection", new object[1] { data });
	}

	public nsISupports CreateAttribute(string name)
	{
		return CallMethod<nsISupports>("createAttribute", new object[1] { name });
	}

	public nsISupports CreateAttributeNS(string @namespace, string name)
	{
		return CallMethod<nsISupports>("createAttributeNS", new object[2] { @namespace, name });
	}

	public bool HasFocus()
	{
		return CallMethod<bool>("hasFocus", new object[0]);
	}

	public void ReleaseCapture()
	{
		CallVoidMethod("releaseCapture");
	}

	public void MozSetImageElement(string aImageElementId, nsIDOMElement aImageElement)
	{
		CallVoidMethod("mozSetImageElement", aImageElementId, aImageElement);
	}

	public void MozCancelFullScreen()
	{
		CallVoidMethod("mozCancelFullScreen");
	}

	public void MozExitPointerLock()
	{
		CallVoidMethod("mozExitPointerLock");
	}

	public object RegisterElement(string name)
	{
		return CallMethod<object>("registerElement", new object[1] { name });
	}

	public object RegisterElement(string name, object options)
	{
		return CallMethod<object>("registerElement", new object[2] { name, options });
	}

	public nsIDOMElement CreateElement(string localName, string typeExtension)
	{
		return CallMethod<nsIDOMElement>("createElement", new object[2] { localName, typeExtension });
	}

	public nsIDOMElement CreateElementNS(string @namespace, string qualifiedName, string typeExtension)
	{
		return CallMethod<nsIDOMElement>("createElementNS", new object[3] { @namespace, qualifiedName, typeExtension });
	}

	public void EnableStyleSheetsForSet(string name)
	{
		CallVoidMethod("enableStyleSheetsForSet", name);
	}

	public nsIDOMElement ElementFromPoint(float x, float y)
	{
		return CallMethod<nsIDOMElement>("elementFromPoint", new object[2] { x, y });
	}

	public nsISupports CaretPositionFromPoint(float x, float y)
	{
		return CallMethod<nsISupports>("caretPositionFromPoint", new object[2] { x, y });
	}

	public nsIDOMElement QuerySelector(string selectors)
	{
		return CallMethod<nsIDOMElement>("querySelector", new object[1] { selectors });
	}

	public nsISupports QuerySelectorAll(string selectors)
	{
		return CallMethod<nsISupports>("querySelectorAll", new object[1] { selectors });
	}

	public nsISupports GetAnonymousNodes(nsIDOMElement elt)
	{
		return CallMethod<nsISupports>("getAnonymousNodes", new object[1] { elt });
	}

	public nsIDOMElement GetAnonymousElementByAttribute(nsIDOMElement elt, string attrName, string attrValue)
	{
		return CallMethod<nsIDOMElement>("getAnonymousElementByAttribute", new object[3] { elt, attrName, attrValue });
	}

	public nsIDOMElement GetBindingParent(nsIDOMNode node)
	{
		return CallMethod<nsIDOMElement>("getBindingParent", new object[1] { node });
	}

	public void LoadBindingDocument(string documentURL)
	{
		CallVoidMethod("loadBindingDocument", documentURL);
	}

	public nsISupports CreateTouch()
	{
		return CallMethod<nsISupports>("createTouch", new object[0]);
	}

	public nsISupports CreateTouch(nsIDOMWindow view)
	{
		return CallMethod<nsISupports>("createTouch", new object[1] { view });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target)
	{
		return CallMethod<nsISupports>("createTouch", new object[2] { view, target });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier)
	{
		return CallMethod<nsISupports>("createTouch", new object[3] { view, target, identifier });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX)
	{
		return CallMethod<nsISupports>("createTouch", new object[4] { view, target, identifier, pageX });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY)
	{
		return CallMethod<nsISupports>("createTouch", new object[5] { view, target, identifier, pageX, pageY });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX)
	{
		return CallMethod<nsISupports>("createTouch", new object[6] { view, target, identifier, pageX, pageY, screenX });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY)
	{
		return CallMethod<nsISupports>("createTouch", new object[7] { view, target, identifier, pageX, pageY, screenX, screenY });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX)
	{
		return CallMethod<nsISupports>("createTouch", new object[8] { view, target, identifier, pageX, pageY, screenX, screenY, clientX });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY)
	{
		return CallMethod<nsISupports>("createTouch", new object[9] { view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX)
	{
		return CallMethod<nsISupports>("createTouch", new object[10] { view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX });
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY)
	{
		return CallMethod<nsISupports>("createTouch", new object[11]
		{
			view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX,
			radiusY
		});
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle)
	{
		return CallMethod<nsISupports>("createTouch", new object[12]
		{
			view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX,
			radiusY, rotationAngle
		});
	}

	public nsISupports CreateTouch(nsIDOMWindow view, nsISupports target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle, float force)
	{
		return CallMethod<nsISupports>("createTouch", new object[13]
		{
			view, target, identifier, pageX, pageY, screenX, screenY, clientX, clientY, radiusX,
			radiusY, rotationAngle, force
		});
	}

	public nsISupports CreateTouchList(nsISupports touch, nsISupports touches)
	{
		return CallMethod<nsISupports>("createTouchList", new object[2] { touch, touches });
	}

	public nsISupports CreateTouchList()
	{
		return CallMethod<nsISupports>("createTouchList", new object[0]);
	}

	public nsISupports CreateTouchList(nsISupports[] touches)
	{
		return CallMethod<nsISupports>("createTouchList", touches);
	}

	public void ObsoleteSheet(nsISupports sheetURI)
	{
		CallVoidMethod("obsoleteSheet", sheetURI);
	}

	public void ObsoleteSheet(string sheetURI)
	{
		CallVoidMethod("obsoleteSheet", sheetURI);
	}

	public nsISupports InsertAnonymousContent(nsIDOMElement aElement)
	{
		return CallMethod<nsISupports>("insertAnonymousContent", new object[1] { aElement });
	}

	public void RemoveAnonymousContent(nsISupports aContent)
	{
		CallVoidMethod("removeAnonymousContent", aContent);
	}
}
