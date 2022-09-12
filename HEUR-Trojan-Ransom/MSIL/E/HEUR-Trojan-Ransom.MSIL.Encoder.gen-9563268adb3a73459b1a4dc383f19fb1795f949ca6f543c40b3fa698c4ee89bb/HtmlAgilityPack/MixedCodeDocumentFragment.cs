namespace HtmlAgilityPack;

public abstract class MixedCodeDocumentFragment
{
	internal MixedCodeDocument Doc;

	private string _fragmentText;

	internal int Index;

	internal int Length;

	private int _line;

	internal int _lineposition;

	internal MixedCodeDocumentFragmentType _type;

	public string FragmentText
	{
		get
		{
			if (_fragmentText == null)
			{
				_fragmentText = Doc._text.Substring(Index, Length);
			}
			return _fragmentText;
		}
		internal set
		{
			_fragmentText = value;
		}
	}

	public MixedCodeDocumentFragmentType FragmentType => _type;

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

	public int LinePosition => _lineposition;

	public int StreamPosition => Index;

	internal MixedCodeDocumentFragment(MixedCodeDocument doc, MixedCodeDocumentFragmentType type)
	{
		Doc = doc;
		_type = type;
		switch (type)
		{
		case MixedCodeDocumentFragmentType.Text:
			Doc._textfragments.Append(this);
			break;
		case MixedCodeDocumentFragmentType.Code:
			Doc._codefragments.Append(this);
			break;
		}
		Doc._fragments.Append(this);
	}
}
