using System;
using Gecko.DOM;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko;

public class GeckoNode : IDisposable
{
	private static GeckoWrapperCache<nsIDOMNode, GeckoNode> m_nodeCache = new GeckoWrapperCache<nsIDOMNode, GeckoNode>(DOMSelector.CreateDomNodeWrapper);

	private ComPtr<nsIDOMNode> _domNode;

	private NodeType m_cachedType;

	public nsIDOMNode DomObject => _domNode.Instance;

	public string TextContent
	{
		get
		{
			return nsString.Get(_domNode.Instance.GetTextContentAttribute);
		}
		set
		{
			nsString.Set(_domNode.Instance.SetTextContentAttribute, value);
		}
	}

	public string NodeValue
	{
		get
		{
			return nsString.Get(_domNode.Instance.GetNodeValueAttribute);
		}
		set
		{
			nsString.Set(_domNode.Instance.SetNodeValueAttribute, value);
		}
	}

	public string NodeName => nsString.Get(_domNode.Instance.GetNodeNameAttribute);

	public GeckoNodeCollection ChildNodes => _domNode.Instance.GetChildNodesAttribute().Wrap(GeckoNodeCollection.Create);

	public GeckoNode FirstChild => _domNode.Instance.GetFirstChildAttribute().Wrap(Create);

	public GeckoNode LastChild => _domNode.Instance.GetLastChildAttribute().Wrap(Create);

	public GeckoNode NextSibling => _domNode.Instance.GetNextSiblingAttribute().Wrap(Create);

	public GeckoNode PreviousSibling => _domNode.Instance.GetPreviousSiblingAttribute().Wrap(Create);

	public bool HasChildNodes => _domNode.Instance.HasChildNodes();

	public virtual GeckoDocument OwnerDocument => GeckoDocument.Create(Xpcom.QueryInterface<nsIDOMHTMLDocument>(_domNode.Instance.GetOwnerDocumentAttribute()));

	public string NamespaceURI => nsString.Get(_domNode.Instance.GetNamespaceURIAttribute);

	public string Prefix => nsString.Get(_domNode.Instance.GetPrefixAttribute);

	public string LocalName => nsString.Get(_domNode.Instance.GetLocalNameAttribute);

	public NodeType NodeType
	{
		get
		{
			if (m_cachedType != 0)
			{
				return m_cachedType;
			}
			return m_cachedType = (NodeType)_domNode.Instance.GetNodeTypeAttribute();
		}
	}

	public GeckoNode ParentNode => _domNode.Instance.GetParentNodeAttribute().Wrap(Create);

	public GeckoElement ParentElement
	{
		get
		{
			nsIDOMNode parentNodeAttribute = _domNode.Instance.GetParentNodeAttribute();
			while (parentNodeAttribute != null && !(parentNodeAttribute is nsIDOMElement))
			{
				parentNodeAttribute = parentNodeAttribute.GetParentNodeAttribute();
			}
			return ((nsIDOMElement)parentNodeAttribute).Wrap(GeckoElement.CreateDomElementWrapper);
		}
	}

	internal GeckoNode(nsIDOMNode domObject)
	{
		_domNode = new ComPtr<nsIDOMNode>(domObject);
	}

	internal GeckoNode(object domObject)
	{
		if (!(domObject is nsIDOMNode))
		{
			throw new ArgumentException("domObject is not a nsIDOMNode");
		}
		_domNode = new ComPtr<nsIDOMNode>((nsIDOMNode)domObject);
	}

	~GeckoNode()
	{
		Xpcom.DisposeObject(ref _domNode);
	}

	public void Dispose()
	{
		Xpcom.DisposeObject(ref _domNode);
		GC.SuppressFinalize(this);
	}

	internal static GeckoNode Create(nsIDOMNode domObject)
	{
		return m_nodeCache.Get(domObject);
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (obj is GeckoNode)
		{
			return _domNode.GetHashCode() == ((GeckoNode)obj)._domNode.GetHashCode();
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _domNode.GetHashCode();
	}

	public GeckoNode AppendChild(GeckoNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		_domNode.Instance.AppendChild(node._domNode.Instance);
		return node;
	}

	public GeckoNode CloneNode(bool deep)
	{
		return Create(_domNode.Instance.CloneNode(deep, 1));
	}

	public GeckoNode InsertBefore(GeckoNode newChild, GeckoNode before)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (before == null)
		{
			throw new ArgumentNullException("before");
		}
		_domNode.Instance.InsertBefore(newChild._domNode.Instance, before._domNode.Instance);
		return newChild;
	}

	public GeckoNode RemoveChild(GeckoNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		_domNode.Instance.RemoveChild(node._domNode.Instance);
		return node;
	}

	public GeckoNode ReplaceChild(GeckoNode newChild, GeckoNode oldChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (oldChild == null)
		{
			throw new ArgumentNullException("oldChild");
		}
		_domNode.Instance.ReplaceChild(newChild._domNode.Instance, oldChild._domNode.Instance);
		return newChild;
	}

	private nsIXPathResult EvaluateXPathInternal(string xpath)
	{
		using ComPtr<nsIDOMXPathEvaluator> comPtr = Xpcom.CreateInstance2<nsIDOMXPathEvaluator>("@mozilla.org/dom/xpath-evaluator;1");
		nsIDOMNode domObject = DomObject;
		nsIDOMNode resolver = new XPathEvaluator(OwnerDocument.DefaultView.DomWindow, (nsISupports)OwnerDocument.DomObject).CreateNSResolver(domObject);
		return (nsIXPathResult)comPtr.Instance.Evaluate(new nsAString(xpath), domObject, resolver, 0, null);
	}

	public Gecko.DOM.XPathResult EvaluateXPath(string xpath)
	{
		nsIXPathResult xpathResult = EvaluateXPathInternal(xpath);
		return new Gecko.DOM.XPathResult(OwnerDocument.DefaultView.DomWindow, xpathResult);
	}

	public GeckoNode SelectFirst(string xpath)
	{
		nsIXPathResult obj = EvaluateXPathInternal(xpath);
		nsIDOMNode obj2 = null;
		using AutoJSContext autoJSContext = new AutoJSContext();
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject((nsISupports)obj);
		switch (SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "resultType").ToInteger())
		{
		case 8:
		case 9:
			obj2 = (nsIDOMNode)SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "singleNodeValue").ToComObject(autoJSContext.ContextPointer);
			break;
		case 4:
			obj2 = (nsIDOMNode)SpiderMonkey.JS_CallFunctionName(autoJSContext.ContextPointer, jsObject, "iterateNext", new JsVal[0]).ToComObject(autoJSContext.ContextPointer);
			break;
		}
		GeckoNode result = obj2.Wrap(Create);
		Xpcom.FreeComObject(ref obj);
		return result;
	}

	public GeckoNode SelectSingle(string xpath)
	{
		nsIXPathResult obj = EvaluateXPathInternal(xpath);
		nsIDOMNode obj2 = null;
		using (AutoJSContext autoJSContext = new AutoJSContext())
		{
			IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject((nsISupports)obj);
			switch (SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "resultType").ToInteger())
			{
			case 8:
			case 9:
				obj2 = (nsIDOMNode)SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, "singleNodeValue").ToComObject(autoJSContext.ContextPointer);
				break;
			case 4:
				obj2 = (nsIDOMNode)SpiderMonkey.JS_CallFunctionName(autoJSContext.ContextPointer, jsObject, "iterateNext", new JsVal[0]).ToComObject(autoJSContext.ContextPointer);
				if (!SpiderMonkey.JS_CallFunctionName(autoJSContext.ContextPointer, jsObject, "iterateNext", new JsVal[0]).IsNull)
				{
					Xpcom.FreeComObject(ref obj2);
					Xpcom.FreeComObject(ref obj);
					throw new GeckoDomException("There are more than 1 nodes in Single selection");
				}
				break;
			}
		}
		GeckoNode result = obj2.Wrap(Create);
		Xpcom.FreeComObject(ref obj);
		return result;
	}

	public DomEventTarget GetEventTarget()
	{
		nsIDOMEventTarget obj = Xpcom.QueryInterface<nsIDOMEventTarget>(_domNode.Instance);
		return obj.Wrap(DomEventTarget.Create);
	}
}
