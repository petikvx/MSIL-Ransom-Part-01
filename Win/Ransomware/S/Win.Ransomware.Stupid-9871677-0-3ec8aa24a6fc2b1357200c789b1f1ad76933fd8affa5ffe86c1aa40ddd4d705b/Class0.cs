using System.Diagnostics;
using System.Runtime.CompilerServices;

internal abstract class Class0
{
	[CompilerGenerated]
	private bool bool_0;

	internal virtual bool Verbose
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	internal abstract bool Evaluate(string filename);

	[Conditional("SelectorTrace")]
	protected static void smethod_0(string string_0, params object[] object_0)
	{
	}

	internal abstract bool Evaluate(GClass8 entry);
}
