using System;
using System.IO;
using System.Text;

namespace HtmlAgilityPack;

public class MixedCodeDocument
{
	private enum ParseState
	{
		Text,
		Code
	}

	private int _c;

	internal MixedCodeDocumentFragmentList _codefragments;

	private MixedCodeDocumentFragment _currentfragment;

	internal MixedCodeDocumentFragmentList _fragments;

	private int _index;

	private int _line;

	private int _lineposition;

	private ParseState _state;

	private Encoding _streamencoding;

	internal string _text;

	internal MixedCodeDocumentFragmentList _textfragments;

	public string TokenCodeEnd = "%>";

	public string TokenCodeStart = "<%";

	public string TokenDirective = "@";

	public string TokenResponseWrite = "Response.Write ";

	private string TokenTextBlock = "TextBlock({0})";

	public string Code
	{
		get
		{
			string text = "";
			int num = 0;
			foreach (MixedCodeDocumentFragment fragment in _fragments)
			{
				switch (fragment._type)
				{
				case MixedCodeDocumentFragmentType.Text:
					text = text + TokenResponseWrite + string.Format(TokenTextBlock, num) + "\n";
					num++;
					break;
				case MixedCodeDocumentFragmentType.Code:
					text = text + ((MixedCodeDocumentCodeFragment)fragment).Code + "\n";
					break;
				}
			}
			return text;
		}
	}

	public MixedCodeDocumentFragmentList CodeFragments => _codefragments;

	public MixedCodeDocumentFragmentList Fragments => _fragments;

	public Encoding StreamEncoding => _streamencoding;

	public MixedCodeDocumentFragmentList TextFragments => _textfragments;

	public MixedCodeDocument()
	{
		_codefragments = new MixedCodeDocumentFragmentList(this);
		_textfragments = new MixedCodeDocumentFragmentList(this);
		_fragments = new MixedCodeDocumentFragmentList(this);
	}

	public MixedCodeDocumentCodeFragment CreateCodeFragment()
	{
		return (MixedCodeDocumentCodeFragment)CreateFragment(MixedCodeDocumentFragmentType.Code);
	}

	public MixedCodeDocumentTextFragment CreateTextFragment()
	{
		return (MixedCodeDocumentTextFragment)CreateFragment(MixedCodeDocumentFragmentType.Text);
	}

	public void Load(Stream stream)
	{
		Load(new StreamReader(stream));
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

	public void Load(string path)
	{
		Load(new StreamReader(path));
	}

	public void Load(string path, bool detectEncodingFromByteOrderMarks)
	{
		Load(new StreamReader(path, detectEncodingFromByteOrderMarks));
	}

	public void Load(string path, Encoding encoding)
	{
		Load(new StreamReader(path, encoding));
	}

	public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
	{
		Load(new StreamReader(path, encoding, detectEncodingFromByteOrderMarks));
	}

	public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
	{
		Load(new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, buffersize));
	}

	public void Load(TextReader reader)
	{
		_codefragments.Clear();
		_textfragments.Clear();
		using (StreamReader streamReader = reader as StreamReader)
		{
			if (streamReader != null)
			{
				_streamencoding = streamReader.CurrentEncoding;
			}
			_text = reader.ReadToEnd();
		}
		Parse();
	}

	public void LoadHtml(string html)
	{
		Load(new StringReader(html));
	}

	public void Save(Stream outStream)
	{
		StreamWriter writer = new StreamWriter(outStream, GetOutEncoding());
		Save(writer);
	}

	public void Save(Stream outStream, Encoding encoding)
	{
		StreamWriter writer = new StreamWriter(outStream, encoding);
		Save(writer);
	}

	public void Save(string filename)
	{
		StreamWriter writer = new StreamWriter(filename, append: false, GetOutEncoding());
		Save(writer);
	}

	public void Save(string filename, Encoding encoding)
	{
		StreamWriter writer = new StreamWriter(filename, append: false, encoding);
		Save(writer);
	}

	public void Save(StreamWriter writer)
	{
		Save((TextWriter)writer);
	}

	public void Save(TextWriter writer)
	{
		writer.Flush();
	}

	internal MixedCodeDocumentFragment CreateFragment(MixedCodeDocumentFragmentType type)
	{
		return type switch
		{
			MixedCodeDocumentFragmentType.Text => new MixedCodeDocumentTextFragment(this), 
			MixedCodeDocumentFragmentType.Code => new MixedCodeDocumentCodeFragment(this), 
			_ => throw new NotSupportedException(), 
		};
	}

	internal Encoding GetOutEncoding()
	{
		if (_streamencoding != null)
		{
			return _streamencoding;
		}
		return Encoding.UTF8;
	}

	private void IncrementPosition()
	{
		_index++;
		if (_c == 10)
		{
			_lineposition = 1;
			_line++;
		}
		else
		{
			_lineposition++;
		}
	}

	private void Parse()
	{
		_state = ParseState.Text;
		_index = 0;
		_currentfragment = CreateFragment(MixedCodeDocumentFragmentType.Text);
		while (_index < _text.Length)
		{
			_c = _text[_index];
			IncrementPosition();
			switch (_state)
			{
			case ParseState.Code:
				if (_index + TokenCodeEnd.Length < _text.Length && _text.Substring(_index - 1, TokenCodeEnd.Length) == TokenCodeEnd)
				{
					_state = ParseState.Text;
					_currentfragment.Length = _index + TokenCodeEnd.Length - _currentfragment.Index;
					_index += TokenCodeEnd.Length;
					_lineposition += TokenCodeEnd.Length;
					_currentfragment = CreateFragment(MixedCodeDocumentFragmentType.Text);
					SetPosition();
				}
				break;
			case ParseState.Text:
				if (_index + TokenCodeStart.Length < _text.Length && _text.Substring(_index - 1, TokenCodeStart.Length) == TokenCodeStart)
				{
					_state = ParseState.Code;
					_currentfragment.Length = _index - 1 - _currentfragment.Index;
					_currentfragment = CreateFragment(MixedCodeDocumentFragmentType.Code);
					SetPosition();
				}
				break;
			}
		}
		_currentfragment.Length = _index - _currentfragment.Index;
	}

	private void SetPosition()
	{
		_currentfragment.Line = _line;
		_currentfragment._lineposition = _lineposition;
		_currentfragment.Index = _index - 1;
		_currentfragment.Length = 0;
	}
}
