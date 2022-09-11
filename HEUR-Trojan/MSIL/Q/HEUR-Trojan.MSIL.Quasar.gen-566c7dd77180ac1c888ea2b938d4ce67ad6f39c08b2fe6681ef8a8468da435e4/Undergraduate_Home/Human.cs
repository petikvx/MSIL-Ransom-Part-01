namespace Undergraduate_Home;

public abstract class Human
{
	private string name;

	private string middlename;

	private string surname;

	public unsafe Human(string name, string middlename, string surname)
	{
		//Discarded unreachable code: IL_000b, IL_0010
		//IL_0001: Expected native int or pointer, but got O
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_0004: stloc 0 (out-of-bounds)*/;
		*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public extern string GetAllFIO();
}
