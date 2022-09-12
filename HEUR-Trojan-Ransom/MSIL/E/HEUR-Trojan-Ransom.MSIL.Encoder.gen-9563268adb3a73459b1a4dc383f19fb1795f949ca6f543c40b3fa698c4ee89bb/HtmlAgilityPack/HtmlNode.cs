using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace HtmlAgilityPack;

[DebuggerDisplay("Name: {OriginalName}")]
public class HtmlNode : IXPathNavigable
{
	internal const string DepthLevelExceptionMessage = "The document is too complex to parse";

	internal HtmlAttributeCollection _attributes;

	internal HtmlNodeCollection _childnodes;

	internal HtmlNode _endnode;

	private bool _changed;

	internal string _innerhtml;

	internal int _innerlength;

	internal int _innerstartindex;

	internal int _line;

	internal int _lineposition;

	private string _name;

	internal int _namelength;

	internal int _namestartindex;

	internal HtmlNode _nextnode;

	internal HtmlNodeType _nodetype;

	internal string _outerhtml;

	internal int _outerlength;

	internal int _outerstartindex;

	private string _optimizedName;

	internal HtmlDocument _ownerdocument;

	internal HtmlNode _parentnode;

	internal HtmlNode _prevnode;

	internal HtmlNode _prevwithsamename;

	internal bool _starttag;

	internal int _streamposition;

	internal bool _isImplicitEnd;

	internal bool _isHideInnerText;

	public static readonly string HtmlNodeTypeNameComment;

	public static readonly string HtmlNodeTypeNameDocument;

	public static readonly string HtmlNodeTypeNameText;

	public static Dictionary<string, HtmlElementFlag> ElementsFlags;

	public HtmlAttributeCollection Attributes
	{
		get
		{
			if (!HasAttributes)
			{
				_attributes = new HtmlAttributeCollection(this);
			}
			return _attributes;
		}
		internal set
		{
			_attributes = value;
		}
	}

	public HtmlNodeCollection ChildNodes
	{
		get
		{
			return _childnodes ?? (_childnodes = new HtmlNodeCollection(this));
		}
		internal set
		{
			_childnodes = value;
		}
	}

	public bool Closed => _endnode != null;

	public HtmlAttributeCollection ClosingAttributes
	{
		get
		{
			if (HasClosingAttributes)
			{
				return _endnode.Attributes;
			}
			return new HtmlAttributeCollection(this);
		}
	}

	public HtmlNode EndNode => _endnode;

	public HtmlNode FirstChild
	{
		get
		{
			if (HasChildNodes)
			{
				return _childnodes[0];
			}
			return null;
		}
	}

	public bool HasAttributes
	{
		get
		{
			if (_attributes == null)
			{
				return false;
			}
			if (_attributes.Count <= 0)
			{
				return false;
			}
			return true;
		}
	}

	public bool HasChildNodes
	{
		get
		{
			if (_childnodes == null)
			{
				return false;
			}
			if (_childnodes.Count <= 0)
			{
				return false;
			}
			return true;
		}
	}

	public bool HasClosingAttributes
	{
		get
		{
			if (_endnode != null && _endnode != this)
			{
				if (_endnode._attributes == null)
				{
					return false;
				}
				if (_endnode._attributes.Count <= 0)
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}

	public string Id
	{
		get
		{
			if (_ownerdocument.Nodesid == null)
			{
				throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
			}
			return GetId();
		}
		set
		{
			if (_ownerdocument.Nodesid == null)
			{
				throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetId(value);
		}
	}

	public virtual string InnerHtml
	{
		get
		{
			if (_changed)
			{
				UpdateHtml();
				return _innerhtml;
			}
			if (_innerhtml != null)
			{
				return _innerhtml;
			}
			if (_innerstartindex >= 0 && _innerlength >= 0)
			{
				return _ownerdocument.Text.Substring(_innerstartindex, _innerlength);
			}
			return string.Empty;
		}
		set
		{
			HtmlDocument htmlDocument = new HtmlDocument();
			htmlDocument.LoadHtml(value);
			RemoveAllChildren();
			AppendChildren(htmlDocument.DocumentNode.ChildNodes);
		}
	}

	public virtual string InnerText
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			string name = Name;
			if (name != null)
			{
				name = name.ToLowerInvariant();
				bool isDisplayScriptingText = name == "head" || name == "script" || name == "style";
				InternalInnerText(stringBuilder, isDisplayScriptingText);
			}
			else
			{
				InternalInnerText(stringBuilder, isDisplayScriptingText: false);
			}
			return stringBuilder.ToString();
		}
	}

	public HtmlNode LastChild
	{
		get
		{
			if (HasChildNodes)
			{
				return _childnodes[_childnodes.Count - 1];
			}
			return null;
		}
	}

	public int Line
	{
		get
		{
			return _line;
		}
		internal set
		{
			_line = value;
		}
	}

	public int LinePosition
	{
		get
		{
			return _lineposition;
		}
		internal set
		{
			_lineposition = value;
		}
	}

	public int InnerStartIndex => _innerstartindex;

	public int InnerLength => InnerHtml.Length;

	public int OuterLength => OuterHtml.Length;

	public string Name
	{
		get
		{
			if (_optimizedName == null)
			{
				if (_name == null)
				{
					Name = _ownerdocument.Text.Substring(_namestartindex, _namelength);
				}
				if (_name == null)
				{
					_optimizedName = string.Empty;
				}
				else
				{
					_optimizedName = _name.ToLowerInvariant();
				}
			}
			return _optimizedName;
		}
		set
		{
			_name = value;
			_optimizedName = null;
		}
	}

	public HtmlNode NextSibling
	{
		get
		{
			return _nextnode;
		}
		internal set
		{
			_nextnode = value;
		}
	}

	public HtmlNodeType NodeType
	{
		get
		{
			return _nodetype;
		}
		internal set
		{
			_nodetype = value;
		}
	}

	public string OriginalName => _name;

	public virtual string OuterHtml
	{
		get
		{
			if (_changed)
			{
				UpdateHtml();
				return _outerhtml;
			}
			if (_outerhtml != null)
			{
				return _outerhtml;
			}
			if (_outerstartindex >= 0 && _outerlength >= 0)
			{
				return _ownerdocument.Text.Substring(_outerstartindex, _outerlength);
			}
			return string.Empty;
		}
	}

	public HtmlDocument OwnerDocument
	{
		get
		{
			return _ownerdocument;
		}
		internal set
		{
			_ownerdocument = value;
		}
	}

	public HtmlNode ParentNode
	{
		get
		{
			return _parentnode;
		}
		internal set
		{
			_parentnode = value;
		}
	}

	public HtmlNode PreviousSibling
	{
		get
		{
			return _prevnode;
		}
		internal set
		{
			_prevnode = value;
		}
	}

	public int StreamPosition => _streamposition;

	public string XPath => ((ParentNode == null || ParentNode.NodeType == HtmlNodeType.Document) ? "/" : (ParentNode.XPath + "/")) + GetRelativeXpath();

	public int Depth { get; set; }

	static HtmlNode()
	{
		HtmlNodeTypeNameComment = "#comment";
		HtmlNodeTypeNameDocument = "#document";
		HtmlNodeTypeNameText = "#text";
		ElementsFlags = new Dictionary<string, HtmlElementFlag>(StringComparer.OrdinalIgnoreCase);
		ElementsFlags.Add("script", HtmlElementFlag.CData);
		ElementsFlags.Add("style", HtmlElementFlag.CData);
		ElementsFlags.Add("noxhtml", HtmlElementFlag.CData);
		ElementsFlags.Add("textarea", HtmlElementFlag.CData);
		ElementsFlags.Add("title", HtmlElementFlag.CData);
		ElementsFlags.Add("base", HtmlElementFlag.Empty);
		ElementsFlags.Add("link", HtmlElementFlag.Empty);
		ElementsFlags.Add("meta", HtmlElementFlag.Empty);
		ElementsFlags.Add("isindex", HtmlElementFlag.Empty);
		ElementsFlags.Add("hr", HtmlElementFlag.Empty);
		ElementsFlags.Add("col", HtmlElementFlag.Empty);
		ElementsFlags.Add("img", HtmlElementFlag.Empty);
		ElementsFlags.Add("param", HtmlElementFlag.Empty);
		ElementsFlags.Add("embed", HtmlElementFlag.Empty);
		ElementsFlags.Add("frame", HtmlElementFlag.Empty);
		ElementsFlags.Add("wbr", HtmlElementFlag.Empty);
		ElementsFlags.Add("bgsound", HtmlElementFlag.Empty);
		ElementsFlags.Add("spacer", HtmlElementFlag.Empty);
		ElementsFlags.Add("keygen", HtmlElementFlag.Empty);
		ElementsFlags.Add("area", HtmlElementFlag.Empty);
		ElementsFlags.Add("input", HtmlElementFlag.Empty);
		ElementsFlags.Add("basefont", HtmlElementFlag.Empty);
		ElementsFlags.Add("source", HtmlElementFlag.Empty);
		ElementsFlags.Add("form", HtmlElementFlag.CanOverlap);
		ElementsFlags.Add("br", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
		if (!HtmlDocument.DisableBehaviorTagP)
		{
			ElementsFlags.Add("p", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
		}
	}

	public HtmlNode(HtmlNodeType type, HtmlDocument ownerdocument, int index)
	{
		_nodetype = type;
		_ownerdocument = ownerdocument;
		_outerstartindex = index;
		switch (type)
		{
		case HtmlNodeType.Document:
			Name = HtmlNodeTypeNameDocument;
			_endnode = this;
			break;
		case HtmlNodeType.Comment:
			Name = HtmlNodeTypeNameComment;
			_endnode = this;
			break;
		case HtmlNodeType.Text:
			Name = HtmlNodeTypeNameText;
			_endnode = this;
			break;
		}
		if (_ownerdocument.Openednodes != null && !Closed && -1 != index)
		{
			_ownerdocument.Openednodes.Add(index, this);
		}
		if (-1 == index && type != HtmlNodeType.Comment && type != HtmlNodeType.Text)
		{
			SetChanged();
		}
	}

	internal virtual void InternalInnerText(StringBuilder sb, bool isDisplayScriptingText)
	{
		if (!_ownerdocument.BackwardCompatibility)
		{
			if (HasChildNodes)
			{
				AppendInnerText(sb, isDisplayScriptingText);
			}
			else
			{
				sb.Append(GetCurrentNodeText());
			}
		}
		else if (_nodetype == HtmlNodeType.Text)
		{
			sb.Append(((HtmlTextNode)this).Text);
		}
		else
		{
			if (_nodetype == HtmlNodeType.Comment || !HasChildNodes || (_isHideInnerText && !isDisplayScriptingText))
			{
				return;
			}
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)ChildNodes)
			{
				item.InternalInnerText(sb, isDisplayScriptingText);
			}
		}
	}

	public virtual string GetDirectInnerText()
	{
		if (!_ownerdocument.BackwardCompatibility)
		{
			if (HasChildNodes)
			{
				StringBuilder stringBuilder = new StringBuilder();
				AppendDirectInnerText(stringBuilder);
				return stringBuilder.ToString();
			}
			return GetCurrentNodeText();
		}
		if (_nodetype == HtmlNodeType.Text)
		{
			return ((HtmlTextNode)this).Text;
		}
		if (_nodetype == HtmlNodeType.Comment)
		{
			return "";
		}
		if (!HasChildNodes)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)ChildNodes)
		{
			if (item._nodetype == HtmlNodeType.Text)
			{
				stringBuilder2.Append(((HtmlTextNode)item).Text);
			}
		}
		return stringBuilder2.ToString();
	}

	internal string GetCurrentNodeText()
	{
		if (_nodetype == HtmlNodeType.Text)
		{
			string text = ((HtmlTextNode)this).Text;
			if (ParentNode.Name != "pre")
			{
				text = text.Replace("\n", "").Replace("\r", "").Replace("\t", "");
			}
			return text;
		}
		return "";
	}

	internal void AppendDirectInnerText(StringBuilder sb)
	{
		if (_nodetype == HtmlNodeType.Text)
		{
			sb.Append(GetCurrentNodeText());
		}
		if (!HasChildNodes)
		{
			return;
		}
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)ChildNodes)
		{
			sb.Append(item.GetCurrentNodeText());
		}
	}

	internal void AppendInnerText(StringBuilder sb, bool isShowHideInnerText)
	{
		if (_nodetype == HtmlNodeType.Text)
		{
			sb.Append(GetCurrentNodeText());
		}
		if (!HasChildNodes || (_isHideInnerText && !isShowHideInnerText))
		{
			return;
		}
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)ChildNodes)
		{
			item.AppendInnerText(sb, isShowHideInnerText);
		}
	}

	public static bool CanOverlapElement(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!ElementsFlags.TryGetValue(name, out var value))
		{
			return false;
		}
		return (value & HtmlElementFlag.CanOverlap) != 0;
	}

	public static HtmlNode CreateNode(string html)
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(html);
		if (!htmlDocument.DocumentNode.IsSingleElementNode())
		{
			throw new Exception("Multiple node elments can't be created.");
		}
		HtmlNode htmlNode = htmlDocument.DocumentNode.FirstChild;
		while (true)
		{
			if (htmlNode != null)
			{
				if (htmlNode.NodeType == HtmlNodeType.Element && htmlNode.OuterHtml != "\r\n")
				{
					break;
				}
				htmlNode = htmlNode.NextSibling;
				continue;
			}
			return htmlDocument.DocumentNode.FirstChild;
		}
		return htmlNode;
	}

	public static bool IsCDataElement(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!ElementsFlags.TryGetValue(name, out var value))
		{
			return false;
		}
		return (value & HtmlElementFlag.CData) != 0;
	}

	public static bool IsClosedElement(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!ElementsFlags.TryGetValue(name, out var value))
		{
			return false;
		}
		return (value & HtmlElementFlag.Closed) != 0;
	}

	public static bool IsEmptyElement(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			return true;
		}
		if ('!' == name[0])
		{
			return true;
		}
		if ('?' == name[0])
		{
			return true;
		}
		if (!ElementsFlags.TryGetValue(name, out var value))
		{
			return false;
		}
		return (value & HtmlElementFlag.Empty) != 0;
	}

	public static bool IsOverlappedClosingElement(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (text.Length <= 4)
		{
			return false;
		}
		if (text[0] == '<' && text[text.Length - 1] == '>' && text[1] == '/')
		{
			return CanOverlapElement(text.Substring(2, text.Length - 3));
		}
		return false;
	}

	public IEnumerable<HtmlNode> Ancestors()
	{
		HtmlNode node = ParentNode;
		if (node != null)
		{
			yield return node;
			while (node.ParentNode != null)
			{
				yield return node.ParentNode;
				node = node.ParentNode;
			}
		}
	}

	public IEnumerable<HtmlNode> Ancestors(string name)
	{
		for (HtmlNode i = ParentNode; i != null; i = i.ParentNode)
		{
			if (i.Name == name)
			{
				yield return i;
			}
		}
	}

	public IEnumerable<HtmlNode> AncestorsAndSelf()
	{
		for (HtmlNode i = this; i != null; i = i.ParentNode)
		{
			yield return i;
		}
	}

	public IEnumerable<HtmlNode> AncestorsAndSelf(string name)
	{
		for (HtmlNode i = this; i != null; i = i.ParentNode)
		{
			if (i.Name == name)
			{
				yield return i;
			}
		}
	}

	public HtmlNode AppendChild(HtmlNode newChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		ChildNodes.Append(newChild);
		_ownerdocument.SetIdForNode(newChild, newChild.GetId());
		SetChildNodesId(newChild);
		SetChanged();
		return newChild;
	}

	public void SetChildNodesId(HtmlNode chilNode)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)chilNode.ChildNodes)
		{
			_ownerdocument.SetIdForNode(item, item.GetId());
			SetChildNodesId(item);
		}
	}

	public void AppendChildren(HtmlNodeCollection newChildren)
	{
		if (newChildren == null)
		{
			throw new ArgumentNullException("newChildren");
		}
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)newChildren)
		{
			AppendChild(item);
		}
	}

	public IEnumerable<HtmlAttribute> ChildAttributes(string name)
	{
		return Attributes.AttributesWithName(name);
	}

	public HtmlNode Clone()
	{
		return CloneNode(deep: true);
	}

	public HtmlNode CloneNode(string newName)
	{
		return CloneNode(newName, deep: true);
	}

	public HtmlNode CloneNode(string newName, bool deep)
	{
		if (newName == null)
		{
			throw new ArgumentNullException("newName");
		}
		HtmlNode htmlNode = CloneNode(deep);
		htmlNode.Name = newName;
		return htmlNode;
	}

	public HtmlNode CloneNode(bool deep)
	{
		HtmlNode htmlNode = _ownerdocument.CreateNode(_nodetype);
		htmlNode.Name = OriginalName;
		switch (_nodetype)
		{
		default:
			if (HasAttributes)
			{
				foreach (HtmlAttribute item in (IEnumerable<HtmlAttribute>)_attributes)
				{
					HtmlAttribute newAttribute = item.Clone();
					htmlNode.Attributes.Append(newAttribute);
				}
			}
			if (HasClosingAttributes)
			{
				htmlNode._endnode = _endnode.CloneNode(deep: false);
				foreach (HtmlAttribute item2 in (IEnumerable<HtmlAttribute>)_endnode._attributes)
				{
					HtmlAttribute newAttribute2 = item2.Clone();
					htmlNode._endnode._attributes.Append(newAttribute2);
				}
			}
			if (!deep)
			{
				return htmlNode;
			}
			if (!HasChildNodes)
			{
				return htmlNode;
			}
			{
				foreach (HtmlNode item3 in (IEnumerable<HtmlNode>)_childnodes)
				{
					HtmlNode newChild = item3.CloneNode(deep);
					htmlNode.AppendChild(newChild);
				}
				return htmlNode;
			}
		case HtmlNodeType.Text:
			((HtmlTextNode)htmlNode).Text = ((HtmlTextNode)this).Text;
			return htmlNode;
		case HtmlNodeType.Comment:
			((HtmlCommentNode)htmlNode).Comment = ((HtmlCommentNode)this).Comment;
			return htmlNode;
		}
	}

	public void CopyFrom(HtmlNode node)
	{
		CopyFrom(node, deep: true);
	}

	public void CopyFrom(HtmlNode node, bool deep)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		Attributes.RemoveAll();
		if (node.HasAttributes)
		{
			foreach (HtmlAttribute item in (IEnumerable<HtmlAttribute>)node.Attributes)
			{
				HtmlAttribute newAttribute = item.Clone();
				Attributes.Append(newAttribute);
			}
		}
		if (!deep)
		{
			return;
		}
		RemoveAllChildren();
		if (!node.HasChildNodes)
		{
			return;
		}
		foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)node.ChildNodes)
		{
			AppendChild(item2.CloneNode(deep: true));
		}
	}

	[Obsolete("Use Descendants() instead, the results of this function will change in a future version")]
	public IEnumerable<HtmlNode> DescendantNodes(int level = 0)
	{
		if (level > HtmlDocument.MaxDepthLevel)
		{
			throw new ArgumentException("The document is too complex to parse");
		}
		foreach (HtmlNode node in (IEnumerable<HtmlNode>)ChildNodes)
		{
			yield return node;
			foreach (HtmlNode item in node.DescendantNodes(level + 1))
			{
				yield return item;
			}
		}
	}

	[Obsolete("Use DescendantsAndSelf() instead, the results of this function will change in a future version")]
	public IEnumerable<HtmlNode> DescendantNodesAndSelf()
	{
		return DescendantsAndSelf();
	}

	public IEnumerable<HtmlNode> Descendants()
	{
		return Descendants(0);
	}

	public IEnumerable<HtmlNode> Descendants(int level)
	{
		if (level > HtmlDocument.MaxDepthLevel)
		{
			throw new ArgumentException("The document is too complex to parse");
		}
		foreach (HtmlNode node in (IEnumerable<HtmlNode>)ChildNodes)
		{
			yield return node;
			foreach (HtmlNode item in node.Descendants(level + 1))
			{
				yield return item;
			}
		}
	}

	public IEnumerable<HtmlNode> Descendants(string name)
	{
		foreach (HtmlNode item in Descendants())
		{
			if (string.Equals(item.Name, name, StringComparison.OrdinalIgnoreCase))
			{
				yield return item;
			}
		}
	}

	public IEnumerable<HtmlNode> DescendantsAndSelf()
	{
		yield return this;
		foreach (HtmlNode item in Descendants())
		{
			if (item != null)
			{
				yield return item;
			}
		}
	}

	public IEnumerable<HtmlNode> DescendantsAndSelf(string name)
	{
		yield return this;
		foreach (HtmlNode item in Descendants())
		{
			if (item.Name == name)
			{
				yield return item;
			}
		}
	}

	public HtmlNode Element(string name)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)ChildNodes)
		{
			if (item.Name == name)
			{
				return item;
			}
		}
		return null;
	}

	public IEnumerable<HtmlNode> Elements(string name)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)ChildNodes)
		{
			if (item.Name == name)
			{
				yield return item;
			}
		}
	}

	public HtmlAttribute GetDataAttribute(string key)
	{
		return Attributes.Hashitems.SingleOrDefault((KeyValuePair<string, HtmlAttribute> x) => x.Key.Equals("data-" + key, StringComparison.OrdinalIgnoreCase))!.Value;
	}

	public IEnumerable<HtmlAttribute> GetDataAttributes()
	{
		return (from x in Attributes.Hashitems
			where x.Key.StartsWith("data-", StringComparison.OrdinalIgnoreCase)
			select x.Value).ToList();
	}

	public IEnumerable<HtmlAttribute> GetAttributes()
	{
		return Attributes.items;
	}

	public IEnumerable<HtmlAttribute> GetAttributes(params string[] attributeNames)
	{
		List<HtmlAttribute> list = new List<HtmlAttribute>();
		foreach (string name in attributeNames)
		{
			list.Add(Attributes[name]);
		}
		return list;
	}

	public string GetAttributeValue(string name, string def)
	{
		return this.GetAttributeValue<string>(name, def);
	}

	public int GetAttributeValue(string name, int def)
	{
		return this.GetAttributeValue<int>(name, def);
	}

	public bool GetAttributeValue(string name, bool def)
	{
		return this.GetAttributeValue<bool>(name, def);
	}

	public T GetAttributeValue<T>(string name, T def)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!HasAttributes)
		{
			return def;
		}
		HtmlAttribute htmlAttribute = Attributes[name];
		if (htmlAttribute == null)
		{
			return def;
		}
		TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
		try
		{
			if (converter != null && converter.CanConvertTo(htmlAttribute.Value.GetType()))
			{
				return (T)converter.ConvertTo(htmlAttribute.Value, typeof(T));
			}
			return (T)(object)htmlAttribute.Value;
		}
		catch
		{
			return def;
		}
	}

	public HtmlNode InsertAfter(HtmlNode newChild, HtmlNode refChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (refChild == null)
		{
			return PrependChild(newChild);
		}
		if (newChild == refChild)
		{
			return newChild;
		}
		int num = -1;
		if (_childnodes != null)
		{
			num = _childnodes[refChild];
		}
		if (num == -1)
		{
			throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
		}
		if (_childnodes != null)
		{
			_childnodes.Insert(num + 1, newChild);
		}
		_ownerdocument.SetIdForNode(newChild, newChild.GetId());
		SetChildNodesId(newChild);
		SetChanged();
		return newChild;
	}

	public HtmlNode InsertBefore(HtmlNode newChild, HtmlNode refChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (refChild == null)
		{
			return AppendChild(newChild);
		}
		if (newChild == refChild)
		{
			return newChild;
		}
		int num = -1;
		if (_childnodes != null)
		{
			num = _childnodes[refChild];
		}
		if (num == -1)
		{
			throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
		}
		if (_childnodes != null)
		{
			_childnodes.Insert(num, newChild);
		}
		_ownerdocument.SetIdForNode(newChild, newChild.GetId());
		SetChildNodesId(newChild);
		SetChanged();
		return newChild;
	}

	public HtmlNode PrependChild(HtmlNode newChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		ChildNodes.Prepend(newChild);
		_ownerdocument.SetIdForNode(newChild, newChild.GetId());
		SetChildNodesId(newChild);
		SetChanged();
		return newChild;
	}

	public void PrependChildren(HtmlNodeCollection newChildren)
	{
		if (newChildren == null)
		{
			throw new ArgumentNullException("newChildren");
		}
		for (int num = newChildren.Count - 1; num >= 0; num--)
		{
			PrependChild(newChildren[num]);
		}
	}

	public void Remove()
	{
		if (ParentNode != null)
		{
			ParentNode.ChildNodes.Remove(this);
		}
	}

	public void RemoveAll()
	{
		RemoveAllChildren();
		if (HasAttributes)
		{
			_attributes.Clear();
		}
		if (_endnode != null && _endnode != this && _endnode._attributes != null)
		{
			_endnode._attributes.Clear();
		}
		SetChanged();
	}

	public void RemoveAllChildren()
	{
		if (!HasChildNodes)
		{
			return;
		}
		if (_ownerdocument.OptionUseIdAttribute)
		{
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)_childnodes)
			{
				_ownerdocument.SetIdForNode(null, item.GetId());
				RemoveAllIDforNode(item);
			}
		}
		_childnodes.Clear();
		SetChanged();
	}

	public void RemoveAllIDforNode(HtmlNode node)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)node.ChildNodes)
		{
			_ownerdocument.SetIdForNode(null, item.GetId());
			RemoveAllIDforNode(item);
		}
	}

	public HtmlNode RemoveChild(HtmlNode oldChild)
	{
		if (oldChild == null)
		{
			throw new ArgumentNullException("oldChild");
		}
		int num = -1;
		if (_childnodes != null)
		{
			num = _childnodes[oldChild];
		}
		if (num == -1)
		{
			throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
		}
		if (_childnodes != null)
		{
			_childnodes.Remove(num);
		}
		_ownerdocument.SetIdForNode(null, oldChild.GetId());
		RemoveAllIDforNode(oldChild);
		SetChanged();
		return oldChild;
	}

	public HtmlNode RemoveChild(HtmlNode oldChild, bool keepGrandChildren)
	{
		if (oldChild == null)
		{
			throw new ArgumentNullException("oldChild");
		}
		if (oldChild._childnodes != null && keepGrandChildren)
		{
			HtmlNode refChild = oldChild.PreviousSibling;
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)oldChild._childnodes)
			{
				refChild = InsertAfter(item, refChild);
			}
		}
		RemoveChild(oldChild);
		SetChanged();
		return oldChild;
	}

	public HtmlNode ReplaceChild(HtmlNode newChild, HtmlNode oldChild)
	{
		if (newChild == null)
		{
			return RemoveChild(oldChild);
		}
		if (oldChild == null)
		{
			return AppendChild(newChild);
		}
		int num = -1;
		if (_childnodes != null)
		{
			num = _childnodes[oldChild];
		}
		if (num == -1)
		{
			throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
		}
		if (_childnodes != null)
		{
			_childnodes.Replace(num, newChild);
		}
		_ownerdocument.SetIdForNode(null, oldChild.GetId());
		RemoveAllIDforNode(oldChild);
		_ownerdocument.SetIdForNode(newChild, newChild.GetId());
		SetChildNodesId(newChild);
		SetChanged();
		return newChild;
	}

	public HtmlAttribute SetAttributeValue(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		HtmlAttribute htmlAttribute = Attributes[name];
		if (htmlAttribute == null)
		{
			return Attributes.Append(_ownerdocument.CreateAttribute(name, value));
		}
		htmlAttribute.Value = value;
		return htmlAttribute;
	}

	public void WriteContentTo(TextWriter outText, int level = 0)
	{
		if (level > HtmlDocument.MaxDepthLevel)
		{
			throw new ArgumentException("The document is too complex to parse");
		}
		if (_childnodes == null)
		{
			return;
		}
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)_childnodes)
		{
			item.WriteTo(outText, level + 1);
		}
	}

	public string WriteContentTo()
	{
		StringWriter stringWriter = new StringWriter();
		WriteContentTo(stringWriter);
		stringWriter.Flush();
		return stringWriter.ToString();
	}

	public virtual void WriteTo(TextWriter outText, int level = 0)
	{
		switch (_nodetype)
		{
		case HtmlNodeType.Document:
			if (_ownerdocument.OptionOutputAsXml)
			{
				outText.Write("<?xml version=\"1.0\" encoding=\"" + _ownerdocument.GetOutEncoding().BodyName + "\"?>");
				if (_ownerdocument.DocumentNode.HasChildNodes)
				{
					int num = _ownerdocument.DocumentNode._childnodes.Count;
					if (num > 0)
					{
						if (_ownerdocument.GetXmlDeclaration() != null)
						{
							num--;
						}
						if (num > 1)
						{
							if (!_ownerdocument.BackwardCompatibility)
							{
								WriteContentTo(outText, level);
							}
							else if (_ownerdocument.OptionOutputUpperCase)
							{
								outText.Write("<SPAN>");
								WriteContentTo(outText, level);
								outText.Write("</SPAN>");
							}
							else
							{
								outText.Write("<span>");
								WriteContentTo(outText, level);
								outText.Write("</span>");
							}
							break;
						}
					}
				}
			}
			WriteContentTo(outText, level);
			break;
		case HtmlNodeType.Element:
		{
			string text2 = (_ownerdocument.OptionOutputUpperCase ? Name.ToUpperInvariant() : Name);
			if (_ownerdocument.OptionOutputOriginalCase)
			{
				text2 = OriginalName;
			}
			if (_ownerdocument.OptionOutputAsXml)
			{
				if (text2.Length <= 0 || text2[0] == '?' || text2.Trim().Length == 0)
				{
					break;
				}
				text2 = HtmlDocument.GetXmlName(text2, isAttribute: false, _ownerdocument.OptionPreserveXmlNamespaces);
			}
			outText.Write("<" + text2);
			WriteAttributes(outText, closing: false);
			if (HasChildNodes)
			{
				outText.Write(">");
				bool flag = false;
				if (_ownerdocument.OptionOutputAsXml && IsCDataElement(Name))
				{
					flag = true;
					outText.Write("\r\n//<![CDATA[\r\n");
				}
				if (flag)
				{
					if (HasChildNodes)
					{
						ChildNodes[0].WriteTo(outText, level);
					}
					outText.Write("\r\n//]]>//\r\n");
				}
				else
				{
					WriteContentTo(outText, level);
				}
				if (_ownerdocument.OptionOutputAsXml || !_isImplicitEnd)
				{
					outText.Write("</" + text2);
					if (!_ownerdocument.OptionOutputAsXml)
					{
						WriteAttributes(outText, closing: true);
					}
					outText.Write(">");
				}
			}
			else if (IsEmptyElement(Name))
			{
				if (!_ownerdocument.OptionWriteEmptyNodes && !_ownerdocument.OptionOutputAsXml)
				{
					if (Name.Length > 0 && Name[0] == '?')
					{
						outText.Write("?");
					}
					outText.Write(">");
				}
				else
				{
					outText.Write(" />");
				}
			}
			else if (!_isImplicitEnd)
			{
				outText.Write("></" + text2 + ">");
			}
			else
			{
				outText.Write(">");
			}
			break;
		}
		case HtmlNodeType.Comment:
		{
			string text = ((HtmlCommentNode)this).Comment;
			if (_ownerdocument.OptionOutputAsXml)
			{
				HtmlCommentNode htmlCommentNode = (HtmlCommentNode)this;
				if (!_ownerdocument.BackwardCompatibility && htmlCommentNode.Comment.ToLowerInvariant().StartsWith("<!doctype"))
				{
					outText.Write(htmlCommentNode.Comment);
				}
				else
				{
					outText.Write("<!--" + GetXmlComment(htmlCommentNode) + " -->");
				}
			}
			else
			{
				outText.Write(text);
			}
			break;
		}
		case HtmlNodeType.Text:
		{
			string text = ((HtmlTextNode)this).Text;
			outText.Write(_ownerdocument.OptionOutputAsXml ? HtmlDocument.HtmlEncodeWithCompatibility(text, _ownerdocument.BackwardCompatibility) : text);
			break;
		}
		}
	}

	public void WriteTo(XmlWriter writer)
	{
		switch (_nodetype)
		{
		case HtmlNodeType.Document:
			writer.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"" + _ownerdocument.GetOutEncoding().BodyName + "\"");
			if (!HasChildNodes)
			{
				break;
			}
			{
				foreach (HtmlNode item in (IEnumerable<HtmlNode>)ChildNodes)
				{
					item.WriteTo(writer);
				}
				break;
			}
		case HtmlNodeType.Element:
		{
			string localName = (_ownerdocument.OptionOutputUpperCase ? Name.ToUpperInvariant() : Name);
			if (_ownerdocument.OptionOutputOriginalCase)
			{
				localName = OriginalName;
			}
			writer.WriteStartElement(localName);
			WriteAttributes(writer, this);
			if (HasChildNodes)
			{
				foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)ChildNodes)
				{
					item2.WriteTo(writer);
				}
			}
			writer.WriteEndElement();
			break;
		}
		case HtmlNodeType.Comment:
			writer.WriteComment(GetXmlComment((HtmlCommentNode)this));
			break;
		case HtmlNodeType.Text:
		{
			string text = ((HtmlTextNode)this).Text;
			writer.WriteString(text);
			break;
		}
		}
	}

	public string WriteTo()
	{
		using StringWriter stringWriter = new StringWriter();
		WriteTo(stringWriter);
		stringWriter.Flush();
		return stringWriter.ToString();
	}

	public void SetParent(HtmlNode parent)
	{
		if (parent == null)
		{
			return;
		}
		ParentNode = parent;
		if (OwnerDocument.OptionMaxNestedChildNodes > 0)
		{
			Depth = parent.Depth + 1;
			if (Depth > OwnerDocument.OptionMaxNestedChildNodes)
			{
				throw new Exception($"Document has more than {OwnerDocument.OptionMaxNestedChildNodes} nested tags. This is likely due to the page not closing tags properly.");
			}
		}
	}

	internal void SetChanged()
	{
		_changed = true;
		if (ParentNode != null)
		{
			ParentNode.SetChanged();
		}
	}

	private void UpdateHtml()
	{
		_innerhtml = WriteContentTo();
		_outerhtml = WriteTo();
		_changed = false;
	}

	internal static string GetXmlComment(HtmlCommentNode comment)
	{
		string comment2 = comment.Comment;
		return comment2.Substring(4, comment2.Length - 7).Replace("--", " - -");
	}

	internal static void WriteAttributes(XmlWriter writer, HtmlNode node)
	{
		if (!node.HasAttributes)
		{
			return;
		}
		foreach (HtmlAttribute value in node.Attributes.Hashitems.Values)
		{
			writer.WriteAttributeString(value.XmlName, value.Value);
		}
	}

	internal void UpdateLastNode()
	{
		HtmlNode htmlNode = null;
		if (_prevwithsamename != null && _prevwithsamename._starttag)
		{
			htmlNode = _prevwithsamename;
		}
		else if (_ownerdocument.Openednodes != null)
		{
			foreach (KeyValuePair<int, HtmlNode> openednode in _ownerdocument.Openednodes)
			{
				if ((openednode.Key < _outerstartindex || openednode.Key > _outerstartindex + _outerlength) && openednode.Value._name == _name)
				{
					if (htmlNode == null && openednode.Value._starttag)
					{
						htmlNode = openednode.Value;
					}
					else if (htmlNode != null && htmlNode.InnerStartIndex < openednode.Key && openednode.Value._starttag)
					{
						htmlNode = openednode.Value;
					}
				}
			}
		}
		if (htmlNode != null)
		{
			_ownerdocument.Lastnodes[htmlNode.Name] = htmlNode;
		}
	}

	internal void CloseNode(HtmlNode endnode, int level = 0)
	{
		if (level > HtmlDocument.MaxDepthLevel)
		{
			throw new ArgumentException("The document is too complex to parse");
		}
		if (!_ownerdocument.OptionAutoCloseOnEnd && _childnodes != null)
		{
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)_childnodes)
			{
				if (!item.Closed)
				{
					HtmlNode htmlNode = new HtmlNode(NodeType, _ownerdocument, -1);
					htmlNode._endnode = htmlNode;
					item.CloseNode(htmlNode, level + 1);
				}
			}
		}
		if (Closed)
		{
			return;
		}
		_endnode = endnode;
		if (_ownerdocument.Openednodes != null)
		{
			_ownerdocument.Openednodes.Remove(_outerstartindex);
		}
		if (Utilities.GetDictionaryValueOrDefault(_ownerdocument.Lastnodes, Name) == this)
		{
			_ownerdocument.Lastnodes.Remove(Name);
			_ownerdocument.UpdateLastParentNode();
			if (_starttag && !string.IsNullOrEmpty(Name))
			{
				UpdateLastNode();
			}
		}
		if (endnode != this)
		{
			_innerstartindex = _outerstartindex + _outerlength;
			_innerlength = endnode._outerstartindex - _innerstartindex;
			_outerlength = endnode._outerstartindex + endnode._outerlength - _outerstartindex;
		}
	}

	internal string GetId()
	{
		HtmlAttribute htmlAttribute = Attributes["id"];
		if (htmlAttribute != null)
		{
			return htmlAttribute.Value;
		}
		return string.Empty;
	}

	internal void SetId(string id)
	{
		HtmlAttribute htmlAttribute = Attributes["id"] ?? _ownerdocument.CreateAttribute("id");
		htmlAttribute.Value = id;
		_ownerdocument.SetIdForNode(this, htmlAttribute.Value);
		Attributes["id"] = htmlAttribute;
		SetChanged();
	}

	internal void WriteAttribute(TextWriter outText, HtmlAttribute att)
	{
		if (att.Value == null)
		{
			return;
		}
		string text = ((att.QuoteType == AttributeValueQuote.DoubleQuote) ? "\"" : "'");
		string text2;
		if (_ownerdocument.OptionOutputAsXml)
		{
			text2 = (_ownerdocument.OptionOutputUpperCase ? att.XmlName.ToUpperInvariant() : att.XmlName);
			if (_ownerdocument.OptionOutputOriginalCase)
			{
				text2 = att.OriginalName;
			}
			outText.Write(" " + text2 + "=" + text + HtmlDocument.HtmlEncodeWithCompatibility(att.XmlValue, _ownerdocument.BackwardCompatibility) + text);
			return;
		}
		text2 = (_ownerdocument.OptionOutputUpperCase ? att.Name.ToUpperInvariant() : att.Name);
		if (_ownerdocument.OptionOutputOriginalCase)
		{
			text2 = att.OriginalName;
		}
		if (att.Name.Length >= 4 && att.Name[0] == '<' && att.Name[1] == '%' && att.Name[att.Name.Length - 1] == '>' && att.Name[att.Name.Length - 2] == '%')
		{
			outText.Write(" " + text2);
			return;
		}
		string text3 = ((att.QuoteType != AttributeValueQuote.DoubleQuote) ? att.Value.Replace("'", "&#39;") : ((!att.Value.StartsWith("@")) ? att.Value.Replace("\"", "&quot;") : att.Value));
		if (_ownerdocument.OptionOutputOptimizeAttributeValues)
		{
			if (att.Value.IndexOfAny(new char[4] { '\n', '\r', '\t', ' ' }) < 0)
			{
				outText.Write(" " + text2 + "=" + att.Value);
				return;
			}
			outText.Write(" " + text2 + "=" + text + text3 + text);
		}
		else
		{
			outText.Write(" " + text2 + "=" + text + text3 + text);
		}
	}

	internal void WriteAttributes(TextWriter outText, bool closing)
	{
		if (_ownerdocument.OptionOutputAsXml)
		{
			if (_attributes == null)
			{
				return;
			}
			{
				foreach (HtmlAttribute value in _attributes.Hashitems.Values)
				{
					WriteAttribute(outText, value);
				}
				return;
			}
		}
		if (!closing)
		{
			if (_attributes != null)
			{
				foreach (HtmlAttribute item in (IEnumerable<HtmlAttribute>)_attributes)
				{
					WriteAttribute(outText, item);
				}
			}
			if (!_ownerdocument.OptionAddDebuggingAttributes)
			{
				return;
			}
			WriteAttribute(outText, _ownerdocument.CreateAttribute("_closed", Closed.ToString()));
			WriteAttribute(outText, _ownerdocument.CreateAttribute("_children", ChildNodes.Count.ToString()));
			int num = 0;
			{
				foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)ChildNodes)
				{
					WriteAttribute(outText, _ownerdocument.CreateAttribute("_child_" + num, item2.Name));
					num++;
				}
				return;
			}
		}
		if (_endnode == null || _endnode._attributes == null || _endnode == this)
		{
			return;
		}
		foreach (HtmlAttribute item3 in (IEnumerable<HtmlAttribute>)_endnode._attributes)
		{
			WriteAttribute(outText, item3);
		}
		if (_ownerdocument.OptionAddDebuggingAttributes)
		{
			WriteAttribute(outText, _ownerdocument.CreateAttribute("_closed", Closed.ToString()));
			WriteAttribute(outText, _ownerdocument.CreateAttribute("_children", ChildNodes.Count.ToString()));
		}
	}

	private string GetRelativeXpath()
	{
		if (ParentNode == null)
		{
			return Name;
		}
		if (NodeType == HtmlNodeType.Document)
		{
			return string.Empty;
		}
		int num = 1;
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)ParentNode.ChildNodes)
		{
			if (!(item.Name != Name))
			{
				if (item == this)
				{
					break;
				}
				num++;
			}
		}
		return Name + "[" + num + "]";
	}

	private bool IsSingleElementNode()
	{
		int num = 0;
		for (HtmlNode htmlNode = FirstChild; htmlNode != null; htmlNode = htmlNode.NextSibling)
		{
			if (htmlNode.NodeType == HtmlNodeType.Element && htmlNode.OuterHtml != "\r\n")
			{
				num++;
			}
		}
		if (num > 1)
		{
			return false;
		}
		return true;
	}

	public void AddClass(string name)
	{
		AddClass(name, throwError: false);
	}

	public void AddClass(string name, bool throwError)
	{
		IEnumerable<HtmlAttribute> enumerable = Attributes.AttributesWithName("class");
		if (!IsEmpty(enumerable))
		{
			foreach (HtmlAttribute item in enumerable)
			{
				if (item.Value != null && item.Value.Split(new char[1] { ' ' }).ToList().Any((string x) => x.Equals(name)))
				{
					if (throwError)
					{
						throw new Exception(HtmlDocument.HtmlExceptionClassExists);
					}
				}
				else
				{
					SetAttributeValue(item.Name, item.Value + " " + name);
				}
			}
			return;
		}
		HtmlAttribute newAttribute = _ownerdocument.CreateAttribute("class", name);
		Attributes.Append(newAttribute);
	}

	public void RemoveClass()
	{
		RemoveClass(throwError: false);
	}

	public void RemoveClass(bool throwError)
	{
		IEnumerable<HtmlAttribute> enumerable = Attributes.AttributesWithName("class");
		if (IsEmpty(enumerable) && throwError)
		{
			throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
		}
		foreach (HtmlAttribute item in enumerable)
		{
			Attributes.Remove(item);
		}
	}

	public void RemoveClass(string name)
	{
		RemoveClass(name, throwError: false);
	}

	public void RemoveClass(string name, bool throwError)
	{
		IEnumerable<HtmlAttribute> enumerable = Attributes.AttributesWithName("class");
		if (IsEmpty(enumerable) && throwError)
		{
			throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
		}
		foreach (HtmlAttribute item in enumerable)
		{
			if (item.Value == null)
			{
				continue;
			}
			if (item.Value.Equals(name))
			{
				Attributes.Remove(item);
			}
			else if (item.Value != null && item.Value.Split(new char[1] { ' ' }).ToList().Any((string x) => x.Equals(name)))
			{
				string[] array = item.Value.Split(new char[1] { ' ' });
				string text = "";
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (!text2.Equals(name))
					{
						text = text + text2 + " ";
					}
				}
				text = text.Trim();
				SetAttributeValue(item.Name, text);
			}
			else if (throwError)
			{
				throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
			}
			if (string.IsNullOrEmpty(item.Value))
			{
				Attributes.Remove(item);
			}
		}
	}

	public void ReplaceClass(string newClass, string oldClass)
	{
		ReplaceClass(newClass, oldClass, throwError: false);
	}

	public void ReplaceClass(string newClass, string oldClass, bool throwError)
	{
		if (string.IsNullOrEmpty(newClass))
		{
			RemoveClass(oldClass);
		}
		if (string.IsNullOrEmpty(oldClass))
		{
			AddClass(newClass);
		}
		IEnumerable<HtmlAttribute> enumerable = Attributes.AttributesWithName("class");
		if (IsEmpty(enumerable) && throwError)
		{
			throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
		}
		foreach (HtmlAttribute item in enumerable)
		{
			if (item.Value == null)
			{
				continue;
			}
			if (!item.Value.Equals(oldClass) && !item.Value.Contains(oldClass))
			{
				if (throwError)
				{
					throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
				}
			}
			else
			{
				string value = item.Value.Replace(oldClass, newClass);
				SetAttributeValue(item.Name, value);
			}
		}
	}

	public IEnumerable<string> GetClasses()
	{
		IEnumerable<HtmlAttribute> enumerable = Attributes.AttributesWithName("class");
		foreach (HtmlAttribute item in enumerable)
		{
			string[] array = item.Value.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				yield return array2[i];
			}
		}
	}

	public bool HasClass(string className)
	{
		foreach (string @class in GetClasses())
		{
			string[] array = @class.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == className)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool IsEmpty(IEnumerable en)
	{
		IEnumerator enumerator = en.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				_ = enumerator.Current;
				return false;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		return true;
	}

	public T GetEncapsulatedData<T>()
	{
		return (T)GetEncapsulatedData(typeof(T));
	}

	public T GetEncapsulatedData<T>(HtmlDocument htmlDocument)
	{
		return (T)GetEncapsulatedData(typeof(T), htmlDocument);
	}

	public object GetEncapsulatedData(Type targetType, HtmlDocument htmlDocument = null)
	{
		if (targetType == null)
		{
			throw new ArgumentNullException("Parameter targetType is null");
		}
		HtmlDocument htmlDocument2 = ((htmlDocument != null) ? htmlDocument : OwnerDocument);
		if (!targetType.IsInstantiable())
		{
			throw new MissingMethodException("Parameterless Constructor excpected for " + targetType.FullName);
		}
		object obj = Activator.CreateInstance(targetType);
		if (targetType.IsDefinedAttribute(typeof(HasXPathAttribute)))
		{
			IEnumerable<PropertyInfo> propertiesDefinedXPath = targetType.GetPropertiesDefinedXPath();
			if (propertiesDefinedXPath.CountOfIEnumerable() == 0)
			{
				throw new MissingXPathException("Type " + targetType.FullName + " defined HasXPath Attribute but it does not have any property with XPath Attribte.");
			}
			{
				foreach (PropertyInfo item in propertiesDefinedXPath)
				{
					XPathAttribute xPathAttribute = ((IList)item.GetCustomAttributes(typeof(XPathAttribute), inherit: false))[0] as XPathAttribute;
					if (!item.IsIEnumerable())
					{
						HtmlNode htmlNode = null;
						try
						{
							htmlNode = htmlDocument2.DocumentNode.SelectSingleNode(xPathAttribute.XPath);
						}
						catch (XPathException ex)
						{
							throw new XPathException(ex.Message + " That means you have a syntax error in XPath property of this Property : " + item.PropertyType.FullName + " " + item.Name);
						}
						catch (Exception inner)
						{
							throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + item.PropertyType.FullName + " " + item.Name, inner);
						}
						if (htmlNode == null)
						{
							if (!item.IsDefined(typeof(SkipNodeNotFoundAttribute), inherit: false))
							{
								throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + item.PropertyType.FullName + " " + item.Name);
							}
							continue;
						}
						if (item.PropertyType.IsDefinedAttribute(typeof(HasXPathAttribute)))
						{
							HtmlDocument htmlDocument3 = new HtmlDocument();
							htmlDocument3.LoadHtml(htmlNode.InnerHtml);
							object encapsulatedData = GetEncapsulatedData(item.PropertyType, htmlDocument3);
							item.SetValue(obj, encapsulatedData, null);
							continue;
						}
						string empty = string.Empty;
						empty = ((xPathAttribute.AttributeName != null) ? htmlNode.GetAttributeValue(xPathAttribute.AttributeName, null) : Tools.GetNodeValueBasedOnXPathReturnType<string>(htmlNode, xPathAttribute));
						if (empty != null)
						{
							object value;
							try
							{
								value = Convert.ChangeType(empty, item.PropertyType);
							}
							catch (FormatException)
							{
								throw new FormatException("Can not convert Invalid string to " + item.PropertyType.FullName + " " + item.Name);
							}
							catch (Exception ex3)
							{
								throw new Exception("Unhandled Exception : " + ex3.Message);
							}
							item.SetValue(obj, value, null);
							continue;
						}
						throw new NodeAttributeNotFoundException("Can not find " + xPathAttribute.AttributeName + " Attribute in " + htmlNode.Name + " related to " + item.PropertyType.FullName + " " + item.Name);
					}
					if (item.GetGenericTypes() is IList<Type> list && list.Count != 0)
					{
						if (list.Count <= 1)
						{
							if (list.Count != 1)
							{
								continue;
							}
							HtmlNodeCollection htmlNodeCollection;
							try
							{
								htmlNodeCollection = htmlDocument2.DocumentNode.SelectNodes(xPathAttribute.XPath);
							}
							catch (XPathException ex4)
							{
								throw new XPathException(ex4.Message + " That means you have a syntax error in XPath property of this Property : " + item.PropertyType.FullName + " " + item.Name);
							}
							catch (Exception inner2)
							{
								throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + item.PropertyType.FullName + " " + item.Name, inner2);
							}
							if (htmlNodeCollection != null && htmlNodeCollection.Count != 0)
							{
								IList list2 = list[0].CreateIListOfType();
								if (list[0].IsDefinedAttribute(typeof(HasXPathAttribute)))
								{
									foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)htmlNodeCollection)
									{
										HtmlDocument htmlDocument4 = new HtmlDocument();
										htmlDocument4.LoadHtml(item2.InnerHtml);
										object encapsulatedData2 = GetEncapsulatedData(list[0], htmlDocument4);
										list2.Add(encapsulatedData2);
									}
								}
								else if (xPathAttribute.AttributeName == null)
								{
									try
									{
										list2 = Tools.GetNodesValuesBasedOnXPathReturnType(htmlNodeCollection, xPathAttribute, list[0]);
									}
									catch (FormatException)
									{
										throw new FormatException("Can not convert Invalid string in node collection to " + list[0].FullName + " " + item.Name);
									}
									catch (Exception ex6)
									{
										throw new Exception("Unhandled Exception : " + ex6.Message);
									}
								}
								else
								{
									foreach (HtmlNode item3 in (IEnumerable<HtmlNode>)htmlNodeCollection)
									{
										string attributeValue = item3.GetAttributeValue(xPathAttribute.AttributeName, null);
										if (attributeValue != null)
										{
											object value2;
											try
											{
												value2 = Convert.ChangeType(attributeValue, list[0]);
											}
											catch (FormatException)
											{
												throw new FormatException("Can not convert Invalid string to " + list[0].FullName + " " + item.Name);
											}
											catch (Exception ex8)
											{
												throw new Exception("Unhandled Exception : " + ex8.Message);
											}
											list2.Add(value2);
											continue;
										}
										throw new NodeAttributeNotFoundException("Can not find " + xPathAttribute.AttributeName + " Attribute in " + item3.Name + " related to " + item.PropertyType.FullName + " " + item.Name);
									}
								}
								if (list2 == null || list2.Count == 0)
								{
									throw new Exception("Cannot fill " + item.PropertyType.FullName + " " + item.Name + " because it is null.");
								}
								item.SetValue(obj, list2, null);
							}
							else if (!item.IsDefined(typeof(SkipNodeNotFoundAttribute), inherit: false))
							{
								throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + item.PropertyType.FullName + " " + item.Name);
							}
							continue;
						}
						throw new ArgumentException(item.Name + " should have one generic argument.");
					}
					throw new ArgumentException(item.Name + " should have one generic argument.");
				}
				return obj;
			}
		}
		throw new MissingXPathException("Type T must define HasXPath attribute and include properties with XPath attribute.");
	}

	public XPathNavigator CreateNavigator()
	{
		return new HtmlNodeNavigator(OwnerDocument, this);
	}

	public XPathNavigator CreateRootNavigator()
	{
		return new HtmlNodeNavigator(OwnerDocument, OwnerDocument.DocumentNode);
	}

	public HtmlNodeCollection SelectNodes(string xpath)
	{
		HtmlNodeCollection htmlNodeCollection = new HtmlNodeCollection(null);
		XPathNodeIterator xPathNodeIterator = new HtmlNodeNavigator(OwnerDocument, this).Select(xpath);
		while (xPathNodeIterator.MoveNext())
		{
			HtmlNodeNavigator htmlNodeNavigator = (HtmlNodeNavigator)xPathNodeIterator.Current;
			htmlNodeCollection.Add(htmlNodeNavigator.CurrentNode, setParent: false);
		}
		if (htmlNodeCollection.Count == 0 && !OwnerDocument.OptionEmptyCollection)
		{
			return null;
		}
		return htmlNodeCollection;
	}

	public HtmlNodeCollection SelectNodes(XPathExpression xpath)
	{
		HtmlNodeCollection htmlNodeCollection = new HtmlNodeCollection(null);
		XPathNodeIterator xPathNodeIterator = new HtmlNodeNavigator(OwnerDocument, this).Select(xpath);
		while (xPathNodeIterator.MoveNext())
		{
			HtmlNodeNavigator htmlNodeNavigator = (HtmlNodeNavigator)xPathNodeIterator.Current;
			htmlNodeCollection.Add(htmlNodeNavigator.CurrentNode, setParent: false);
		}
		if (htmlNodeCollection.Count == 0 && !OwnerDocument.OptionEmptyCollection)
		{
			return null;
		}
		return htmlNodeCollection;
	}

	public HtmlNode SelectSingleNode(string xpath)
	{
		if (xpath == null)
		{
			throw new ArgumentNullException("xpath");
		}
		XPathNodeIterator xPathNodeIterator = new HtmlNodeNavigator(OwnerDocument, this).Select(xpath);
		if (!xPathNodeIterator.MoveNext())
		{
			return null;
		}
		return ((HtmlNodeNavigator)xPathNodeIterator.Current).CurrentNode;
	}

	public HtmlNode SelectSingleNode(XPathExpression xpath)
	{
		if (xpath == null)
		{
			throw new ArgumentNullException("xpath");
		}
		XPathNodeIterator xPathNodeIterator = new HtmlNodeNavigator(OwnerDocument, this).Select(xpath);
		if (!xPathNodeIterator.MoveNext())
		{
			return null;
		}
		return ((HtmlNodeNavigator)xPathNodeIterator.Current).CurrentNode;
	}
}
