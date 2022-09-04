namespace Lexplorer;

internal class Class2
{
	private const string ALPHABET = "0123456789abcdefghijklmnopqrstuvwxyz";

	private const int MIN_NAME_LENGTH = 16;

	private const int MAX_NAME_LENGTH = 32;

	private int _state;

	public int Seed { get; private set; }

	public Class2(int seed)
	{
		Seed = seed;
		_state = Seed;
	}

	public string NextDomainName()
	{
		string text = "";
		int num = NextRandom(16, 32);
		for (int i = 0; i < num; i++)
		{
			text += "0123456789abcdefghijklmnopqrstuvwxyz"[NextRandom(0, "0123456789abcdefghijklmnopqrstuvwxyz".Length - 1)];
		}
		return text;
	}

	protected int NextRandom()
	{
		return ((_state = 214013 * _state + 2531011) & 0x7FFFFFFF) >> 16;
	}

	protected int NextRandom(int min, int max)
	{
		return NextRandom() % (max - min) + min;
	}
}
