using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;

namespace HtmlAgilityPack;

public class HtmlDocument : IXPathNavigable
{
	private enum ParseState
	{
		Text,
		WhichTag,
		Tag,
		BetweenAttributes,
		EmptyTag,
		AttributeName,
		AttributeBeforeEquals,
		AttributeAfterEquals,
		AttributeValue,
		Comment,
		QuotedAttributeValue,
		ServerSideCode,
		PcData
	}

	internal static bool _disableBehaviorTagP = true;

	private static int _maxDepthLevel = int.MaxValue;

	private int _c;

	private Crc32 _crc32;

	private HtmlAttribute _currentattribute;

	private HtmlNode _currentnode;

	private Encoding _declaredencoding;

	private HtmlNode _documentnode;

	private bool _fullcomment;

	private int _index;

	internal Dictionary<string, HtmlNode> Lastnodes = new Dictionary<string, HtmlNode>();

	private HtmlNode _lastparentnode;

	private int _line;

	private int _lineposition;

	private int _maxlineposition;

	internal Dictionary<string, HtmlNode> Nodesid;

	private ParseState _oldstate;

	private bool _onlyDetectEncoding;

	internal Dictionary<int, HtmlNode> Openednodes;

	private List<HtmlParseError> _parseerrors = new List<HtmlParseError>();

	private string _remainder;

	private int _remainderOffset;

	private ParseState _state;

	private Encoding _streamencoding;

	private bool _useHtmlEncodingForStream;

	public string Text;

	public bool BackwardCompatibility = true;

	public bool OptionAddDebuggingAttributes;

	public bool OptionAutoCloseOnEnd;

	public bool OptionCheckSyntax = true;

	public bool OptionComputeChecksum;

	public bool OptionEmptyCollection;

	public bool DisableServerSideCode;

	public Encoding OptionDefaultStreamEncoding;

	public bool OptionExtractErrorSourceText;

	public int OptionExtractErrorSourceTextMaxLength = 100;

	public bool OptionFixNestedTags;

	public bool OptionOutputAsXml;

	public bool OptionPreserveXmlNamespaces;

	public bool OptionOutputOptimizeAttributeValues;

	public bool OptionOutputOriginalCase;

	public bool OptionOutputUpperCase;

	public bool OptionReadEncoding = true;

	public string OptionStopperNodeName;

	public bool OptionUseIdAttribute = true;

	public bool OptionWriteEmptyNodes;

	public int OptionMaxNestedChildNodes;

	internal static readonly string HtmlExceptionRefNotChild = "Reference node must be a child of this node";

	internal static readonly string HtmlExceptionUseIdAttributeFalse = "You need to set UseIdAttribute property to true to enable this feature";

	internal static readonly string HtmlExceptionClassDoesNotExist = "Class name doesn't exist";

	internal static readonly string HtmlExceptionClassExists = "Class name already exists";

	internal static readonly Dictionary<string, string[]> HtmlResetters = new Dictionary<string, string[]>
	{
		{
			"li",
			new string[2] { "ul", "ol" }
		},
		{
			"tr",
			new string[1] { "table" }
		},
		{
			"th",
			new string[2] { "tr", "table" }
		},
		{
			"td",
			new string[2] { "tr", "table" }
		}
	};

	private static List<string> BlockAttributes = new List<string> { "\"", "'" };

	public static bool DisableBehaviorTagP
	{
		get
		{
			return _disableBehaviorTagP;
		}
		set
		{
			if (value)
			{
				if (HtmlNode.ElementsFlags.ContainsKey("p"))
				{
					HtmlNode.ElementsFlags.Remove("p");
				}
			}
			else if (!HtmlNode.ElementsFlags.ContainsKey("p"))
			{
				HtmlNode.ElementsFlags.Add("p", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
			}
			_disableBehaviorTagP = value;
		}
	}

	public static Action<HtmlDocument> DefaultBuilder { get; set; }

	public Action<HtmlDocument> ParseExecuting { get; set; }

	public string ParsedText => Text;

	public static int MaxDepthLevel
	{
		get
		{
			return _maxDepthLevel;
		}
		set
		{
			_maxDepthLevel = value;
		}
	}

	public int CheckSum
	{
		get
		{
			if (_crc32 != null)
			{
				return (int)_crc32.CheckSum;
			}
			return 0;
		}
	}

	public Encoding DeclaredEncoding => _declaredencoding;

	public HtmlNode DocumentNode => _documentnode;

	public Encoding Encoding => GetOutEncoding();

	public IEnumerable<HtmlParseError> ParseErrors => _parseerrors;

	public string Remainder => _remainder;

	public int RemainderOffset => _remainderOffset;

	public Encoding StreamEncoding => _streamencoding;

	public HtmlDocument()
	{
		if (DefaultBuilder != null)
		{
			DefaultBuilder(this);
		}
		_documentnode = CreateNode(HtmlNodeType.Document, 0);
		OptionDefaultStreamEncoding = Encoding.Default;
	}

	public static string GetXmlName(string name)
	{
		return GetXmlName(name, isAttribute: false, preserveXmlNamespaces: false);
	}

	public void UseAttributeOriginalName(string tagName)
	{
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)DocumentNode.SelectNodes("//" + tagName))
		{
			foreach (HtmlAttribute item2 in (IEnumerable<HtmlAttribute>)item.Attributes)
			{
				item2.UseOriginalName = true;
			}
		}
	}

	public static string GetXmlName(string name, bool isAttribute, bool preserveXmlNamespaces)
	{
		string text = string.Empty;
		bool flag = true;
		for (int i = 0; i < name.Length; i++)
		{
			if ((name[i] < 'a' || name[i] > 'z') && (name[i] < 'A' || name[i] > 'Z') && (name[i] < '0' || name[i] > '9') && (!(isAttribute || preserveXmlNamespaces) || name[i] != ':') && name[i] != '_' && name[i] != '-' && name[i] != '.')
			{
				flag = false;
				byte[] bytes = Encoding.UTF8.GetBytes(new char[1] { name[i] });
				for (int j = 0; j < bytes.Length; j++)
				{
					text += bytes[j].ToString("x2");
				}
				text += "_";
			}
			else
			{
				text += name[i];
			}
		}
		if (flag)
		{
			return text;
		}
		return "_" + text;
	}

	public static string HtmlEncode(string html)
	{
		return HtmlEncodeWithCompatibility(html);
	}

	internal static string HtmlEncodeWithCompatibility(string html, bool backwardCompatibility = true)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		return (backwardCompatibility ? new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;))", RegexOptions.IgnoreCase) : new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;)|(nbsp;)|(reg;))", RegexOptions.IgnoreCase)).Replace(html, "&amp;").Replace("<", "&lt;").Replace(">", "&gt;")
			.Replace("\"", "&quot;");
	}

	public static bool IsWhiteSpace(int c)
	{
		if (c != 10 && c != 13 && c != 32 && c != 9)
		{
			return false;
		}
		return true;
	}

	public HtmlAttribute CreateAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		HtmlAttribute htmlAttribute = CreateAttribute();
		htmlAttribute.Name = name;
		return htmlAttribute;
	}

	public HtmlAttribute CreateAttribute(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		HtmlAttribute htmlAttribute = CreateAttribute(name);
		htmlAttribute.Value = value;
		return htmlAttribute;
	}

	public HtmlCommentNode CreateComment()
	{
		return (HtmlCommentNode)CreateNode(HtmlNodeType.Comment);
	}

	public HtmlCommentNode CreateComment(string comment)
	{
		if (comment == null)
		{
			throw new ArgumentNullException("comment");
		}
		HtmlCommentNode htmlCommentNode = CreateComment();
		htmlCommentNode.Comment = comment;
		return htmlCommentNode;
	}

	public HtmlNode CreateElement(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		HtmlNode htmlNode = CreateNode(HtmlNodeType.Element);
		htmlNode.Name = name;
		return htmlNode;
	}

	public HtmlTextNode CreateTextNode()
	{
		return (HtmlTextNode)CreateNode(HtmlNodeType.Text);
	}

	public HtmlTextNode CreateTextNode(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		HtmlTextNode htmlTextNode = CreateTextNode();
		htmlTextNode.Text = text;
		return htmlTextNode;
	}

	public Encoding DetectEncoding(Stream stream)
	{
		return DetectEncoding(stream, checkHtml: false);
	}

	public Encoding DetectEncoding(Stream stream, bool checkHtml)
	{
		_useHtmlEncodingForStream = checkHtml;
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		return DetectEncoding(new StreamReader(stream));
	}

	public Encoding DetectEncoding(TextReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		_onlyDetectEncoding = true;
		if (OptionCheckSyntax)
		{
			Openednodes = new Dictionary<int, HtmlNode>();
		}
		else
		{
			Openednodes = null;
		}
		if (OptionUseIdAttribute)
		{
			Nodesid = new Dictionary<string, HtmlNode>(StringComparer.OrdinalIgnoreCase);
		}
		else
		{
			Nodesid = null;
		}
		if (reader is StreamReader streamReader && !_useHtmlEncodingForStream)
		{
			Text = streamReader.ReadToEnd();
			_streamencoding = streamReader.CurrentEncoding;
			return _streamencoding;
		}
		_streamencoding = null;
		_declaredencoding = null;
		Text = reader.ReadToEnd();
		_documentnode = CreateNode(HtmlNodeType.Document, 0);
		try
		{
			Parse();
		}
		catch (EncodingFoundException ex)
		{
			return ex.Encoding;
		}
		return _streamencoding;
	}

	public Encoding DetectEncodingHtml(string html)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		using StringReader reader = new StringReader(html);
		return DetectEncoding(reader);
	}

	public HtmlNode GetElementbyId(string id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (Nodesid == null)
		{
			throw new Exception(HtmlExceptionUseIdAttributeFalse);
		}
		if (!Nodesid.ContainsKey(id))
		{
			return null;
		}
		return Nodesid[id];
	}

	public void Load(Stream stream)
	{
		Load(new StreamReader(stream, OptionDefaultStreamEncoding));
	}

	public void Load(Stream stream, bool detectEncodingFromByteOrderMarks)
	{
		Load(new StreamReader(stream, detectEncodingFromByteOrderMarks));
	}

	public void Load(Stream stream, Encoding encoding)
	{
		Load(new StreamReader(stream, encoding));
	}

	public void Load(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
		Load(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks));
	}

	public void Load(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
	{
		Load(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, buffersize));
	}

	public void Load(TextReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		_onlyDetectEncoding = false;
		if (OptionCheckSyntax)
		{
			Openednodes = new Dictionary<int, HtmlNode>();
		}
		else
		{
			Openednodes = null;
		}
		if (OptionUseIdAttribute)
		{
			Nodesid = new Dictionary<string, HtmlNode>(StringComparer.OrdinalIgnoreCase);
		}
		else
		{
			Nodesid = null;
		}
		if (reader is StreamReader streamReader)
		{
			try
			{
				streamReader.Peek();
			}
			catch (Exception)
			{
			}
			_streamencoding = streamReader.CurrentEncoding;
		}
		else
		{
			_streamencoding = null;
		}
		_declaredencoding = null;
		Text = reader.ReadToEnd();
		_documentnode = CreateNode(HtmlNodeType.Document, 0);
		Parse();
		if (!OptionCheckSyntax || Openednodes == null)
		{
			return;
		}
		foreach (HtmlNode value in Openednodes.Values)
		{
			if (!value._starttag)
			{
				continue;
			}
			string text;
			if (OptionExtractErrorSourceText)
			{
				text = value.OuterHtml;
				if (text.Length > OptionExtractErrorSourceTextMaxLength)
				{
					text = text.Substring(0, OptionExtractErrorSourceTextMaxLength);
				}
			}
			else
			{
				text = string.Empty;
			}
			AddError(HtmlParseErrorCode.TagNotClosed, value._line, value._lineposition, value._streamposition, text, "End tag </" + value.Name + "> was not found");
		}
		Openednodes.Clear();
	}

	public void LoadHtml(string html)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		using StringReader reader = new StringReader(html);
		Load(reader);
	}

	public void Save(Stream outStream)
	{
		StreamWriter writer = new StreamWriter(outStream, GetOutEncoding());
		Save(writer);
	}

	public void Save(Stream outStream, Encoding encoding)
	{
		if (outStream == null)
		{
			throw new ArgumentNullException("outStream");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		StreamWriter writer = new StreamWriter(outStream, encoding);
		Save(writer);
	}

	public void Save(StreamWriter writer)
	{
		Save((TextWriter)writer);
	}

	public void Save(TextWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		DocumentNode.WriteTo(writer);
		writer.Flush();
	}

	public void Save(XmlWriter writer)
	{
		DocumentNode.WriteTo(writer);
		writer.Flush();
	}

	internal HtmlAttribute CreateAttribute()
	{
		return new HtmlAttribute(this);
	}

	internal HtmlNode CreateNode(HtmlNodeType type)
	{
		return CreateNode(type, -1);
	}

	internal HtmlNode CreateNode(HtmlNodeType type, int index)
	{
		return type switch
		{
			HtmlNodeType.Text => new HtmlTextNode(this, index), 
			HtmlNodeType.Comment => new HtmlCommentNode(this, index), 
			_ => new HtmlNode(type, this, index), 
		};
	}

	internal Encoding GetOutEncoding()
	{
		return _declaredencoding ?? _streamencoding ?? OptionDefaultStreamEncoding;
	}

	internal HtmlNode GetXmlDeclaration()
	{
		if (!_documentnode.HasChildNodes)
		{
			return null;
		}
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)_documentnode._childnodes)
		{
			if (item.Name == "?xml")
			{
				return item;
			}
		}
		return null;
	}

	internal void SetIdForNode(HtmlNode node, string id)
	{
		if (OptionUseIdAttribute && Nodesid != null && id != null)
		{
			if (node == null)
			{
				Nodesid.Remove(id);
			}
			else
			{
				Nodesid[id] = node;
			}
		}
	}

	internal void UpdateLastParentNode()
	{
		do
		{
			if (_lastparentnode.Closed)
			{
				_lastparentnode = _lastparentnode.ParentNode;
			}
		}
		while (_lastparentnode != null && _lastparentnode.Closed);
		if (_lastparentnode == null)
		{
			_lastparentnode = _documentnode;
		}
	}

	private void AddError(HtmlParseErrorCode code, int line, int linePosition, int streamPosition, string sourceText, string reason)
	{
		HtmlParseError item = new HtmlParseError(code, line, linePosition, streamPosition, sourceText, reason);
		_parseerrors.Add(item);
	}

	private void CloseCurrentNode()
	{
		if (_currentnode.Closed)
		{
			return;
		}
		bool flag = false;
		HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault(Lastnodes, _currentnode.Name);
		if (dictionaryValueOrDefault == null)
		{
			if (HtmlNode.IsClosedElement(_currentnode.Name))
			{
				_currentnode.CloseNode(_currentnode);
				if (_lastparentnode != null)
				{
					HtmlNode htmlNode = null;
					Stack<HtmlNode> stack = new Stack<HtmlNode>();
					HtmlNode htmlNode2 = _lastparentnode.LastChild;
					while (htmlNode2 != null)
					{
						if (!(htmlNode2.Name == _currentnode.Name) || htmlNode2.HasChildNodes)
						{
							stack.Push(htmlNode2);
							htmlNode2 = htmlNode2.PreviousSibling;
							continue;
						}
						htmlNode = htmlNode2;
						break;
					}
					if (htmlNode != null)
					{
						while (stack.Count != 0)
						{
							HtmlNode htmlNode3 = stack.Pop();
							_lastparentnode.RemoveChild(htmlNode3);
							htmlNode.AppendChild(htmlNode3);
						}
					}
					else
					{
						_lastparentnode.AppendChild(_currentnode);
					}
				}
			}
			else if (HtmlNode.CanOverlapElement(_currentnode.Name))
			{
				HtmlNode htmlNode4 = CreateNode(HtmlNodeType.Text, _currentnode._outerstartindex);
				htmlNode4._outerlength = _currentnode._outerlength;
				((HtmlTextNode)htmlNode4).Text = ((HtmlTextNode)htmlNode4).Text.ToLowerInvariant();
				if (_lastparentnode != null)
				{
					_lastparentnode.AppendChild(htmlNode4);
				}
			}
			else if (HtmlNode.IsEmptyElement(_currentnode.Name))
			{
				AddError(HtmlParseErrorCode.EndTagNotRequired, _currentnode._line, _currentnode._lineposition, _currentnode._streamposition, _currentnode.OuterHtml, "End tag </" + _currentnode.Name + "> is not required");
			}
			else
			{
				AddError(HtmlParseErrorCode.TagNotOpened, _currentnode._line, _currentnode._lineposition, _currentnode._streamposition, _currentnode.OuterHtml, "Start tag <" + _currentnode.Name + "> was not found");
				flag = true;
			}
		}
		else
		{
			if (OptionFixNestedTags && FindResetterNodes(dictionaryValueOrDefault, GetResetters(_currentnode.Name)))
			{
				AddError(HtmlParseErrorCode.EndTagInvalidHere, _currentnode._line, _currentnode._lineposition, _currentnode._streamposition, _currentnode.OuterHtml, "End tag </" + _currentnode.Name + "> invalid here");
				flag = true;
			}
			if (!flag)
			{
				Lastnodes[_currentnode.Name] = dictionaryValueOrDefault._prevwithsamename;
				dictionaryValueOrDefault.CloseNode(_currentnode);
			}
		}
		if (!flag && _lastparentnode != null && (!HtmlNode.IsClosedElement(_currentnode.Name) || _currentnode._starttag))
		{
			UpdateLastParentNode();
		}
	}

	private string CurrentNodeName()
	{
		return Text.Substring(_currentnode._namestartindex, _currentnode._namelength);
	}

	private void DecrementPosition()
	{
		_index--;
		if (_lineposition == 0)
		{
			_lineposition = _maxlineposition;
			_line--;
		}
		else
		{
			_lineposition--;
		}
	}

	private HtmlNode FindResetterNode(HtmlNode node, string name)
	{
		HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault(Lastnodes, name);
		if (dictionaryValueOrDefault == null)
		{
			return null;
		}
		if (dictionaryValueOrDefault.Closed)
		{
			return null;
		}
		if (dictionaryValueOrDefault._streamposition < node._streamposition)
		{
			return null;
		}
		return dictionaryValueOrDefault;
	}

	private bool FindResetterNodes(HtmlNode node, string[] names)
	{
		if (names == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < names.Length)
			{
				if (FindResetterNode(node, names[num]) != null)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private void FixNestedTag(string name, string[] resetters)
	{
		if (resetters != null)
		{
			HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault(Lastnodes, _currentnode.Name);
			if (dictionaryValueOrDefault != null && !Lastnodes[name].Closed && !FindResetterNodes(dictionaryValueOrDefault, resetters))
			{
				HtmlNode htmlNode = new HtmlNode(dictionaryValueOrDefault.NodeType, this, -1);
				htmlNode._endnode = htmlNode;
				dictionaryValueOrDefault.CloseNode(htmlNode);
			}
		}
	}

	private void FixNestedTags()
	{
		if (_currentnode._starttag)
		{
			string name = CurrentNodeName();
			FixNestedTag(name, GetResetters(name));
		}
	}

	private string[] GetResetters(string name)
	{
		if (!HtmlResetters.TryGetValue(name, out var value))
		{
			return null;
		}
		return value;
	}

	private void IncrementPosition()
	{
		if (_crc32 != null)
		{
			_crc32.AddToCRC32(_c);
		}
		_index++;
		_maxlineposition = _lineposition;
		if (_c == 10)
		{
			_lineposition = 0;
			_line++;
		}
		else
		{
			_lineposition++;
		}
	}

	private bool IsValidTag()
	{
		if (_c == 60 && _index < Text.Length)
		{
			if (!char.IsLetter(Text[_index]) && Text[_index] != '/' && Text[_index] != '?' && Text[_index] != '!')
			{
				return Text[_index] == '%';
			}
			return true;
		}
		return false;
	}

	private bool NewCheck()
	{
		if (_c == 60 && IsValidTag())
		{
			if (_index < Text.Length && Text[_index] == '%')
			{
				if (DisableServerSideCode)
				{
					return false;
				}
				switch (_state)
				{
				case ParseState.AttributeAfterEquals:
					PushAttributeValueStart(_index - 1);
					break;
				case ParseState.BetweenAttributes:
					PushAttributeNameStart(_index - 1, _lineposition - 1);
					break;
				case ParseState.WhichTag:
					PushNodeNameStart(starttag: true, _index - 1);
					_state = ParseState.Tag;
					break;
				}
				_oldstate = _state;
				_state = ParseState.ServerSideCode;
				return true;
			}
			if (!PushNodeEnd(_index - 1, close: true))
			{
				_index = Text.Length;
				return true;
			}
			_state = ParseState.WhichTag;
			if (_index - 1 <= Text.Length - 2 && (Text[_index] == '!' || Text[_index] == '?'))
			{
				PushNodeStart(HtmlNodeType.Comment, _index - 1, _lineposition - 1);
				PushNodeNameStart(starttag: true, _index);
				PushNodeNameEnd(_index + 1);
				_state = ParseState.Comment;
				if (_index < Text.Length - 2)
				{
					if (Text[_index + 1] == '-' && Text[_index + 2] == '-')
					{
						_fullcomment = true;
					}
					else
					{
						_fullcomment = false;
					}
				}
				return true;
			}
			PushNodeStart(HtmlNodeType.Element, _index - 1, _lineposition - 1);
			return true;
		}
		return false;
	}

	private void Parse()
	{
		if (ParseExecuting != null)
		{
			ParseExecuting(this);
		}
		int num = 0;
		if (OptionComputeChecksum)
		{
			_crc32 = new Crc32();
		}
		Lastnodes = new Dictionary<string, HtmlNode>();
		_c = 0;
		_fullcomment = false;
		_parseerrors = new List<HtmlParseError>();
		_line = 1;
		_lineposition = 0;
		_maxlineposition = 0;
		_state = ParseState.Text;
		_oldstate = _state;
		_documentnode._innerlength = Text.Length;
		_documentnode._outerlength = Text.Length;
		_remainderOffset = Text.Length;
		_lastparentnode = _documentnode;
		_currentnode = CreateNode(HtmlNodeType.Text, 0);
		_currentattribute = null;
		_index = 0;
		PushNodeStart(HtmlNodeType.Text, 0, _lineposition);
		while (_index < Text.Length)
		{
			_c = Text[_index];
			IncrementPosition();
			switch (_state)
			{
			case ParseState.Text:
				if (!NewCheck())
				{
				}
				break;
			case ParseState.WhichTag:
				if (!NewCheck())
				{
					if (_c == 47)
					{
						PushNodeNameStart(starttag: false, _index);
					}
					else
					{
						PushNodeNameStart(starttag: true, _index - 1);
						DecrementPosition();
					}
					_state = ParseState.Tag;
				}
				break;
			case ParseState.Tag:
				if (NewCheck())
				{
					break;
				}
				if (IsWhiteSpace(_c))
				{
					CloseParentImplicitExplicitNode();
					PushNodeNameEnd(_index - 1);
					if (_state == ParseState.Tag)
					{
						_state = ParseState.BetweenAttributes;
					}
				}
				else if (_c == 47)
				{
					CloseParentImplicitExplicitNode();
					PushNodeNameEnd(_index - 1);
					if (_state == ParseState.Tag)
					{
						_state = ParseState.EmptyTag;
					}
				}
				else
				{
					if (_c != 62)
					{
						break;
					}
					CloseParentImplicitExplicitNode();
					PushNodeNameEnd(_index - 1);
					if (_state == ParseState.Tag)
					{
						if (!PushNodeEnd(_index, close: false))
						{
							_index = Text.Length;
						}
						else if (_state == ParseState.Tag)
						{
							_state = ParseState.Text;
							PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
						}
					}
				}
				break;
			case ParseState.BetweenAttributes:
				if (NewCheck() || IsWhiteSpace(_c))
				{
					break;
				}
				if (_c != 47 && _c != 63)
				{
					if (_c == 62)
					{
						if (!PushNodeEnd(_index, close: false))
						{
							_index = Text.Length;
						}
						else if (_state == ParseState.BetweenAttributes)
						{
							_state = ParseState.Text;
							PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
						}
					}
					else
					{
						PushAttributeNameStart(_index - 1, _lineposition - 1);
						_state = ParseState.AttributeName;
					}
				}
				else
				{
					_state = ParseState.EmptyTag;
				}
				break;
			case ParseState.EmptyTag:
				if (NewCheck())
				{
					break;
				}
				if (_c == 62)
				{
					if (!PushNodeEnd(_index, close: true))
					{
						_index = Text.Length;
					}
					else if (_state == ParseState.EmptyTag)
					{
						_state = ParseState.Text;
						PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
					}
				}
				else if (!IsWhiteSpace(_c))
				{
					DecrementPosition();
					_state = ParseState.BetweenAttributes;
				}
				else
				{
					_state = ParseState.BetweenAttributes;
				}
				break;
			case ParseState.AttributeName:
				if (NewCheck())
				{
					break;
				}
				if (IsWhiteSpace(_c))
				{
					PushAttributeNameEnd(_index - 1);
					_state = ParseState.AttributeBeforeEquals;
				}
				else if (_c == 61)
				{
					PushAttributeNameEnd(_index - 1);
					_state = ParseState.AttributeAfterEquals;
				}
				else if (_c == 62)
				{
					PushAttributeNameEnd(_index - 1);
					if (!PushNodeEnd(_index, close: false))
					{
						_index = Text.Length;
					}
					else if (_state == ParseState.AttributeName)
					{
						_state = ParseState.Text;
						PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
					}
				}
				break;
			case ParseState.AttributeBeforeEquals:
				if (NewCheck() || IsWhiteSpace(_c))
				{
					break;
				}
				if (_c == 62)
				{
					if (!PushNodeEnd(_index, close: false))
					{
						_index = Text.Length;
					}
					else if (_state == ParseState.AttributeBeforeEquals)
					{
						_state = ParseState.Text;
						PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
					}
				}
				else if (_c == 61)
				{
					_state = ParseState.AttributeAfterEquals;
				}
				else
				{
					_state = ParseState.BetweenAttributes;
					DecrementPosition();
				}
				break;
			case ParseState.AttributeAfterEquals:
				if (NewCheck() || IsWhiteSpace(_c))
				{
					break;
				}
				if (_c != 39 && _c != 34)
				{
					if (_c == 62)
					{
						if (!PushNodeEnd(_index, close: false))
						{
							_index = Text.Length;
						}
						else if (_state == ParseState.AttributeAfterEquals)
						{
							_state = ParseState.Text;
							PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
						}
					}
					else
					{
						PushAttributeValueStart(_index - 1);
						_state = ParseState.AttributeValue;
					}
				}
				else
				{
					_state = ParseState.QuotedAttributeValue;
					PushAttributeValueStart(_index, _c);
					num = _c;
				}
				break;
			case ParseState.AttributeValue:
				if (NewCheck())
				{
					break;
				}
				if (IsWhiteSpace(_c))
				{
					PushAttributeValueEnd(_index - 1);
					_state = ParseState.BetweenAttributes;
				}
				else if (_c == 62)
				{
					PushAttributeValueEnd(_index - 1);
					if (!PushNodeEnd(_index, close: false))
					{
						_index = Text.Length;
					}
					else if (_state == ParseState.AttributeValue)
					{
						_state = ParseState.Text;
						PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
					}
				}
				break;
			case ParseState.Comment:
				if (_c == 62 && (!_fullcomment || (Text[_index - 2] == '-' && Text[_index - 3] == '-') || (Text[_index - 2] == '!' && Text[_index - 3] == '-' && Text[_index - 4] == '-')))
				{
					if (!PushNodeEnd(_index, close: false))
					{
						_index = Text.Length;
						break;
					}
					_state = ParseState.Text;
					PushNodeStart(HtmlNodeType.Text, _index, _lineposition);
				}
				break;
			case ParseState.QuotedAttributeValue:
				if (_c == num)
				{
					PushAttributeValueEnd(_index - 1);
					_state = ParseState.BetweenAttributes;
				}
				else if (_c == 60 && _index < Text.Length && Text[_index] == '%')
				{
					_oldstate = _state;
					_state = ParseState.ServerSideCode;
				}
				break;
			case ParseState.ServerSideCode:
				if (_c == 37)
				{
					if (_index < Text.Length && Text[_index] == '>')
					{
						switch (_oldstate)
						{
						case ParseState.AttributeAfterEquals:
							_state = ParseState.AttributeValue;
							break;
						default:
							_state = _oldstate;
							break;
						case ParseState.BetweenAttributes:
							PushAttributeNameEnd(_index + 1);
							_state = ParseState.BetweenAttributes;
							break;
						}
						IncrementPosition();
					}
				}
				else if (_oldstate == ParseState.QuotedAttributeValue && _c == num)
				{
					_state = _oldstate;
					DecrementPosition();
				}
				break;
			case ParseState.PcData:
			{
				if (_currentnode._namelength + 3 > Text.Length - (_index - 1) || string.Compare(Text.Substring(_index - 1, _currentnode._namelength + 2), "</" + _currentnode.Name, StringComparison.OrdinalIgnoreCase) != 0)
				{
					break;
				}
				int num2 = Text[_index - 1 + 2 + _currentnode.Name.Length];
				if (num2 == 62 || IsWhiteSpace(num2))
				{
					HtmlNode htmlNode = CreateNode(HtmlNodeType.Text, _currentnode._outerstartindex + _currentnode._outerlength);
					htmlNode._outerlength = _index - 1 - htmlNode._outerstartindex;
					htmlNode._streamposition = htmlNode._outerstartindex;
					htmlNode._line = _currentnode.Line;
					htmlNode._lineposition = _currentnode.LinePosition + _currentnode._namelength + 2;
					_currentnode.AppendChild(htmlNode);
					if (_currentnode.Name.ToLowerInvariant().Equals("script") || _currentnode.Name.ToLowerInvariant().Equals("style"))
					{
						_currentnode._isHideInnerText = true;
					}
					PushNodeStart(HtmlNodeType.Element, _index - 1, _lineposition - 1);
					PushNodeNameStart(starttag: false, _index - 1 + 2);
					_state = ParseState.Tag;
					IncrementPosition();
				}
				break;
			}
			}
		}
		if (_currentnode._namestartindex > 0)
		{
			PushNodeNameEnd(_index);
		}
		PushNodeEnd(_index, close: false);
		Lastnodes.Clear();
	}

	private void PushAttributeNameEnd(int index)
	{
		_currentattribute._namelength = index - _currentattribute._namestartindex;
		if (_currentattribute.Name != null && !BlockAttributes.Contains(_currentattribute.Name))
		{
			_currentnode.Attributes.Append(_currentattribute);
		}
	}

	private void PushAttributeNameStart(int index, int lineposition)
	{
		_currentattribute = CreateAttribute();
		_currentattribute._namestartindex = index;
		_currentattribute.Line = _line;
		_currentattribute._lineposition = lineposition;
		_currentattribute._streamposition = index;
	}

	private void PushAttributeValueEnd(int index)
	{
		_currentattribute._valuelength = index - _currentattribute._valuestartindex;
	}

	private void PushAttributeValueStart(int index)
	{
		PushAttributeValueStart(index, 0);
	}

	private void CloseParentImplicitExplicitNode()
	{
		bool flag = true;
		while (flag && !_lastparentnode.Closed)
		{
			flag = false;
			bool flag2 = false;
			if (IsParentImplicitEnd())
			{
				if (OptionOutputAsXml)
				{
					flag2 = true;
				}
				else
				{
					CloseParentImplicitEnd();
					flag = true;
				}
			}
			if (flag2 || IsParentExplicitEnd())
			{
				CloseParentExplicitEnd();
				flag = true;
			}
		}
	}

	private bool IsParentImplicitEnd()
	{
		if (!_currentnode._starttag)
		{
			return false;
		}
		bool result = false;
		string name = _lastparentnode.Name;
		string text = Text.Substring(_currentnode._namestartindex, _index - _currentnode._namestartindex - 1).ToLowerInvariant();
		switch (name)
		{
		case "option":
			result = text == "option";
			break;
		case "p":
			if (DisableBehaviorTagP)
			{
				int num;
				switch (text)
				{
				default:
					num = ((text == "ul") ? 1 : 0);
					break;
				case "address":
				case "article":
				case "aside":
				case "blockquote":
				case "dir":
				case "div":
				case "dl":
				case "fieldset":
				case "footer":
				case "form":
				case "h1":
				case "h2":
				case "h3":
				case "h4":
				case "h5":
				case "h6":
				case "header":
				case "hr":
				case "menu":
				case "nav":
				case "ol":
				case "p":
				case "pre":
				case "section":
				case "table":
					num = 1;
					break;
				}
				result = (byte)num != 0;
			}
			else
			{
				result = text == "p";
			}
			break;
		case "li":
			result = text == "li";
			break;
		case "dt":
			result = text == "dt" || text == "dd";
			break;
		case "dd":
			result = text == "dt" || text == "dd";
			break;
		case "a":
			result = text == "a";
			break;
		}
		return result;
	}

	private bool IsParentExplicitEnd()
	{
		if (!_currentnode._starttag)
		{
			return false;
		}
		bool result = false;
		string name = _lastparentnode.Name;
		string text = Text.Substring(_currentnode._namestartindex, _index - _currentnode._namestartindex - 1).ToLowerInvariant();
		switch (name)
		{
		case "th":
			result = text == "td" || text == "th" || text == "tr";
			break;
		case "td":
			result = text == "td" || text == "th" || text == "tr";
			break;
		case "h5":
		{
			int num3;
			switch (text)
			{
			default:
				num3 = ((text == "h4") ? 1 : 0);
				break;
			case "h1":
			case "h2":
			case "h3":
				num3 = 1;
				break;
			}
			result = (byte)num3 != 0;
			break;
		}
		case "table":
			result = text == "table";
			break;
		case "tr":
			result = text == "tr";
			break;
		case "h2":
		{
			int num5;
			switch (text)
			{
			default:
				num5 = ((text == "h5") ? 1 : 0);
				break;
			case "h1":
			case "h3":
			case "h4":
				num5 = 1;
				break;
			}
			result = (byte)num5 != 0;
			break;
		}
		case "h3":
		{
			int num4;
			switch (text)
			{
			default:
				num4 = ((text == "h5") ? 1 : 0);
				break;
			case "h1":
			case "h2":
			case "h4":
				num4 = 1;
				break;
			}
			result = (byte)num4 != 0;
			break;
		}
		case "h4":
		{
			int num2;
			switch (text)
			{
			default:
				num2 = ((text == "h5") ? 1 : 0);
				break;
			case "h1":
			case "h2":
			case "h3":
				num2 = 1;
				break;
			}
			result = (byte)num2 != 0;
			break;
		}
		case "p":
			result = text == "div";
			break;
		case "title":
			result = text == "title";
			break;
		case "h1":
		{
			int num;
			switch (text)
			{
			default:
				num = ((text == "h5") ? 1 : 0);
				break;
			case "h2":
			case "h3":
			case "h4":
				num = 1;
				break;
			}
			result = (byte)num != 0;
			break;
		}
		}
		return result;
	}

	private void CloseParentImplicitEnd()
	{
		HtmlNode htmlNode = new HtmlNode(_lastparentnode.NodeType, this, -1);
		htmlNode._endnode = htmlNode;
		htmlNode._isImplicitEnd = true;
		_lastparentnode._isImplicitEnd = true;
		_lastparentnode.CloseNode(htmlNode);
	}

	private void CloseParentExplicitEnd()
	{
		HtmlNode htmlNode = new HtmlNode(_lastparentnode.NodeType, this, -1);
		htmlNode._endnode = htmlNode;
		_lastparentnode.CloseNode(htmlNode);
	}

	private void PushAttributeValueStart(int index, int quote)
	{
		_currentattribute._valuestartindex = index;
		if (quote == 39)
		{
			_currentattribute.QuoteType = AttributeValueQuote.SingleQuote;
		}
	}

	private bool PushNodeEnd(int index, bool close)
	{
		_currentnode._outerlength = index - _currentnode._outerstartindex;
		if (_currentnode._nodetype != HtmlNodeType.Text && _currentnode._nodetype != HtmlNodeType.Comment)
		{
			if (_currentnode._starttag && _lastparentnode != _currentnode)
			{
				if (_lastparentnode != null)
				{
					_lastparentnode.AppendChild(_currentnode);
				}
				ReadDocumentEncoding(_currentnode);
				HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault(Lastnodes, _currentnode.Name);
				_currentnode._prevwithsamename = dictionaryValueOrDefault;
				Lastnodes[_currentnode.Name] = _currentnode;
				if (_currentnode.NodeType == HtmlNodeType.Document || _currentnode.NodeType == HtmlNodeType.Element)
				{
					_lastparentnode = _currentnode;
				}
				if (HtmlNode.IsCDataElement(CurrentNodeName()))
				{
					_state = ParseState.PcData;
					return true;
				}
				if (HtmlNode.IsClosedElement(_currentnode.Name) || HtmlNode.IsEmptyElement(_currentnode.Name))
				{
					close = true;
				}
			}
		}
		else if (_currentnode._outerlength > 0)
		{
			_currentnode._innerlength = _currentnode._outerlength;
			_currentnode._innerstartindex = _currentnode._outerstartindex;
			if (_lastparentnode != null)
			{
				_lastparentnode.AppendChild(_currentnode);
			}
		}
		if (close || !_currentnode._starttag)
		{
			if (OptionStopperNodeName != null && _remainder == null && string.Compare(_currentnode.Name, OptionStopperNodeName, StringComparison.OrdinalIgnoreCase) == 0)
			{
				_remainderOffset = index;
				_remainder = Text.Substring(_remainderOffset);
				CloseCurrentNode();
				return false;
			}
			CloseCurrentNode();
		}
		return true;
	}

	private void PushNodeNameEnd(int index)
	{
		_currentnode._namelength = index - _currentnode._namestartindex;
		if (OptionFixNestedTags)
		{
			FixNestedTags();
		}
	}

	private void PushNodeNameStart(bool starttag, int index)
	{
		_currentnode._starttag = starttag;
		_currentnode._namestartindex = index;
	}

	private void PushNodeStart(HtmlNodeType type, int index, int lineposition)
	{
		_currentnode = CreateNode(type, index);
		_currentnode._line = _line;
		_currentnode._lineposition = lineposition;
		_currentnode._streamposition = index;
	}

	private void ReadDocumentEncoding(HtmlNode node)
	{
		if (!OptionReadEncoding || node._namelength != 4 || node.Name != "meta")
		{
			return;
		}
		string text = null;
		HtmlAttribute htmlAttribute = node.Attributes["http-equiv"];
		if (htmlAttribute != null)
		{
			if (string.Compare(htmlAttribute.Value, "content-type", StringComparison.OrdinalIgnoreCase) != 0)
			{
				return;
			}
			HtmlAttribute htmlAttribute2 = node.Attributes["content"];
			if (htmlAttribute2 != null)
			{
				text = NameValuePairList.GetNameValuePairsValue(htmlAttribute2.Value, "charset");
			}
		}
		else
		{
			htmlAttribute = node.Attributes["charset"];
			if (htmlAttribute != null)
			{
				text = htmlAttribute.Value;
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			if (string.Equals(text, "utf8", StringComparison.OrdinalIgnoreCase))
			{
				text = "utf-8";
			}
			try
			{
				_declaredencoding = Encoding.GetEncoding(text);
			}
			catch (ArgumentException)
			{
				_declaredencoding = null;
			}
			if (_onlyDetectEncoding)
			{
				throw new EncodingFoundException(_declaredencoding);
			}
			if (_streamencoding != null && _declaredencoding != null && _declaredencoding.CodePage != _streamencoding.CodePage)
			{
				AddError(HtmlParseErrorCode.CharsetMismatch, _line, _lineposition, _index, node.OuterHtml, "Encoding mismatch between StreamEncoding: " + _streamencoding.WebName + " and DeclaredEncoding: " + _declaredencoding.WebName);
			}
		}
	}

	public void DetectEncodingAndLoad(string path)
	{
		DetectEncodingAndLoad(path, detectEncoding: true);
	}

	public void DetectEncodingAndLoad(string path, bool detectEncoding)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		Encoding encoding = ((!detectEncoding) ? null : DetectEncoding(path));
		if (encoding == null)
		{
			Load(path);
		}
		else
		{
			Load(path, encoding);
		}
	}

	public Encoding DetectEncoding(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		using StreamReader reader = new StreamReader(path, OptionDefaultStreamEncoding);
		return DetectEncoding(reader);
	}

	public void Load(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		using StreamReader reader = new StreamReader(path, OptionDefaultStreamEncoding);
		Load(reader);
	}

	public void Load(string path, bool detectEncodingFromByteOrderMarks)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		using StreamReader reader = new StreamReader(path, detectEncodingFromByteOrderMarks);
		Load(reader);
	}

	public void Load(string path, Encoding encoding)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		using StreamReader reader = new StreamReader(path, encoding);
		Load(reader);
	}

	public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		using StreamReader reader = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks);
		Load(reader);
	}

	public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		using StreamReader reader = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, buffersize);
		Load(reader);
	}

	public void Save(string filename)
	{
		using StreamWriter writer = new StreamWriter(filename, append: false, GetOutEncoding());
		Save(writer);
	}

	public void Save(string filename, Encoding encoding)
	{
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		using StreamWriter writer = new StreamWriter(filename, append: false, encoding);
		Save(writer);
	}

	public XPathNavigator CreateNavigator()
	{
		return new HtmlNodeNavigator(this, _documentnode);
	}
}
