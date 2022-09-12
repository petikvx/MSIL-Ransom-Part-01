namespace HtmlAgilityPack;

public class MixedCodeDocumentTextFragment : MixedCodeDocumentFragment
{
	public string Text
	{
		get
		{
			return base.FragmentText;
		}
		set
		{
			base.FragmentText = value;
		}
	}

	internal MixedCodeDocumentTextFragment(MixedCodeDocument doc)
		: base(doc, MixedCodeDocumentFragmentType.Text)
	{
	}
}
