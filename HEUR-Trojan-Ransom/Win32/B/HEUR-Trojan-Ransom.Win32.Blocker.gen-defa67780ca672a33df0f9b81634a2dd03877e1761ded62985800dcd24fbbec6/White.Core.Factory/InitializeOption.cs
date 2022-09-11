namespace White.Core.Factory;

public class InitializeOption
{
	private bool cached;

	private string identifier;

	public static InitializeOption WithCache => new InitializeOption(cached: true);

	public static InitializeOption NoCache => new InitializeOption(cached: false);

	public virtual bool Cached => cached;

	public virtual string Identifier => identifier;

	public virtual bool NoIdentification => string.IsNullOrEmpty(identifier);

	private InitializeOption(bool cached)
	{
		this.cached = cached;
	}

	public virtual InitializeOption AndIdentifiedBy(string identifier)
	{
		this.identifier = identifier;
		return this;
	}

	public override string ToString()
	{
		return "Cached=" + cached;
	}

	public virtual void NonCached()
	{
		cached = false;
	}
}
