using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace HtmlAgilityPack;

public class HtmlNodeNavigator : XPathNavigator
{
	private int _attindex;

	private HtmlNode _currentnode;

	private readonly HtmlDocument _doc;

	private readonly HtmlNameTable _nametable;

	internal bool Trace;

	public override string BaseURI => _nametable.GetOrAdd(string.Empty);

	public HtmlDocument CurrentDocument => _doc;

	public HtmlNode CurrentNode => _currentnode;

	public override bool HasAttributes => _currentnode.Attributes.Count > 0;

	public override bool HasChildren => _currentnode.ChildNodes.Count > 0;

	public override bool IsEmptyElement => !HasChildren;

	public override string LocalName
	{
		get
		{
			if (_attindex != -1)
			{
				return _nametable.GetOrAdd(_currentnode.Attributes[_attindex].Name);
			}
			return _nametable.GetOrAdd(_currentnode.Name);
		}
	}

	public override string Name => _nametable.GetOrAdd(_currentnode.Name);

	public override string NamespaceURI => _nametable.GetOrAdd(string.Empty);

	public override XmlNameTable NameTable => _nametable;

	public override XPathNodeType NodeType
	{
		get
		{
			switch (_currentnode.NodeType)
			{
			default:
				throw new NotImplementedException("Internal error: Unhandled HtmlNodeType: " + _currentnode.NodeType);
			case HtmlNodeType.Document:
				return XPathNodeType.Root;
			case HtmlNodeType.Element:
				if (_attindex != -1)
				{
					return XPathNodeType.Attribute;
				}
				return XPathNodeType.Element;
			case HtmlNodeType.Comment:
				return XPathNodeType.Comment;
			case HtmlNodeType.Text:
				return XPathNodeType.Text;
			}
		}
	}

	public override string Prefix => _nametable.GetOrAdd(string.Empty);

	public override string Value
	{
		get
		{
			switch (_currentnode.NodeType)
			{
			default:
				throw new NotImplementedException("Internal error: Unhandled HtmlNodeType: " + _currentnode.NodeType);
			case HtmlNodeType.Document:
				return "";
			case HtmlNodeType.Element:
				if (_attindex != -1)
				{
					return _currentnode.Attributes[_attindex].Value;
				}
				return _currentnode.InnerText;
			case HtmlNodeType.Comment:
				return ((HtmlCommentNode)_currentnode).Comment;
			case HtmlNodeType.Text:
				return ((HtmlTextNode)_currentnode).Text;
			}
		}
	}

	public override string XmlLang => _nametable.GetOrAdd(string.Empty);

	internal HtmlNodeNavigator()
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		Reset();
	}

	internal HtmlNodeNavigator(HtmlDocument doc, HtmlNode currentNode)
	{
		if (currentNode == null)
		{
			throw new ArgumentNullException("currentNode");
		}
		if (currentNode.OwnerDocument != doc)
		{
			throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
		}
		if (doc == null)
		{
			throw new Exception("Oops! The HtmlDocument cannot be null.");
		}
		_doc = doc;
		_nametable = new HtmlNameTable();
		Reset();
		_currentnode = currentNode;
	}

	private HtmlNodeNavigator(HtmlNodeNavigator nav)
	{
		if (nav == null)
		{
			throw new ArgumentNullException("nav");
		}
		_doc = nav._doc;
		_currentnode = nav._currentnode;
		_attindex = nav._attindex;
		_nametable = nav._nametable;
	}

	public HtmlNodeNavigator(Stream stream)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(stream);
		Reset();
	}

	public HtmlNodeNavigator(Stream stream, bool detectEncodingFromByteOrderMarks)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(stream, detectEncodingFromByteOrderMarks);
		Reset();
	}

	public HtmlNodeNavigator(Stream stream, Encoding encoding)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(stream, encoding);
		Reset();
	}

	public HtmlNodeNavigator(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(stream, encoding, detectEncodingFromByteOrderMarks);
		Reset();
	}

	public HtmlNodeNavigator(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(stream, encoding, detectEncodingFromByteOrderMarks, buffersize);
		Reset();
	}

	public HtmlNodeNavigator(TextReader reader)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(reader);
		Reset();
	}

	public HtmlNodeNavigator(string path)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(path);
		Reset();
	}

	public HtmlNodeNavigator(string path, bool detectEncodingFromByteOrderMarks)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(path, detectEncodingFromByteOrderMarks);
		Reset();
	}

	public HtmlNodeNavigator(string path, Encoding encoding)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(path, encoding);
		Reset();
	}

	public HtmlNodeNavigator(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(path, encoding, detectEncodingFromByteOrderMarks);
		Reset();
	}

	public HtmlNodeNavigator(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
	{
		_doc = new HtmlDocument();
		_nametable = new HtmlNameTable();
		_doc.Load(path, encoding, detectEncodingFromByteOrderMarks, buffersize);
		Reset();
	}

	public override XPathNavigator Clone()
	{
		return new HtmlNodeNavigator(this);
	}

	public override string GetAttribute(string localName, string namespaceURI)
	{
		return _currentnode.Attributes[localName]?.Value;
	}

	public override string GetNamespace(string name)
	{
		return string.Empty;
	}

	public override bool IsSamePosition(XPathNavigator other)
	{
		if (!(other is HtmlNodeNavigator htmlNodeNavigator))
		{
			return false;
		}
		return htmlNodeNavigator._currentnode == _currentnode;
	}

	public override bool MoveTo(XPathNavigator other)
	{
		if (!(other is HtmlNodeNavigator htmlNodeNavigator))
		{
			return false;
		}
		if (htmlNodeNavigator._doc == _doc)
		{
			_currentnode = htmlNodeNavigator._currentnode;
			_attindex = htmlNodeNavigator._attindex;
			return true;
		}
		return false;
	}

	public override bool MoveToAttribute(string localName, string namespaceURI)
	{
		int attributeIndex = _currentnode.Attributes.GetAttributeIndex(localName);
		if (attributeIndex == -1)
		{
			return false;
		}
		_attindex = attributeIndex;
		return true;
	}

	public override bool MoveToFirst()
	{
		if (_currentnode.ParentNode == null)
		{
			return false;
		}
		if (_currentnode.ParentNode.FirstChild == null)
		{
			return false;
		}
		_currentnode = _currentnode.ParentNode.FirstChild;
		return true;
	}

	public override bool MoveToFirstAttribute()
	{
		if (!HasAttributes)
		{
			return false;
		}
		_attindex = 0;
		return true;
	}

	public override bool MoveToFirstChild()
	{
		if (!_currentnode.HasChildNodes)
		{
			return false;
		}
		_currentnode = _currentnode.ChildNodes[0];
		return true;
	}

	public override bool MoveToFirstNamespace(XPathNamespaceScope scope)
	{
		return false;
	}

	public override bool MoveToId(string id)
	{
		HtmlNode elementbyId = _doc.GetElementbyId(id);
		if (elementbyId == null)
		{
			return false;
		}
		_currentnode = elementbyId;
		return true;
	}

	public override bool MoveToNamespace(string name)
	{
		return false;
	}

	public override bool MoveToNext()
	{
		if (_currentnode.NextSibling == null)
		{
			return false;
		}
		_currentnode = _currentnode.NextSibling;
		return true;
	}

	public override bool MoveToNextAttribute()
	{
		if (_attindex >= _currentnode.Attributes.Count - 1)
		{
			return false;
		}
		_attindex++;
		return true;
	}

	public override bool MoveToNextNamespace(XPathNamespaceScope scope)
	{
		return false;
	}

	public override bool MoveToParent()
	{
		if (_currentnode.ParentNode == null)
		{
			return false;
		}
		_currentnode = _currentnode.ParentNode;
		return true;
	}

	public override bool MoveToPrevious()
	{
		if (_currentnode.PreviousSibling == null)
		{
			return false;
		}
		_currentnode = _currentnode.PreviousSibling;
		return true;
	}

	public override void MoveToRoot()
	{
		_currentnode = _doc.DocumentNode;
	}

	private void Reset()
	{
		_currentnode = _doc.DocumentNode;
		_attindex = -1;
	}
}
