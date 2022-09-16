namespace _0xHHor1e1hoe1;

public class _0xH4rboretum
{
	public string _0xHDerivati4ns { get; private set; }

	public string _0xHRecon4irms { get; private set; }

	public string _0xHS0yroc0eting { get; private set; }

	public bool _0xHTe5mitic { get; private set; }

	public _0xH4rboretum(string title, string description, string cancelButtonContent)
		: this(title, description, cancelButtonContent, cancelVisible: true)
	{
	}

	public _0xH4rboretum(string title, string description, string cancelButtonContent, bool cancelVisible)
	{
		_0xHDerivati4ns = title;
		_0xHRecon4irms = description;
		_0xHS0yroc0eting = cancelButtonContent;
		_0xHTe5mitic = cancelVisible;
	}
}
