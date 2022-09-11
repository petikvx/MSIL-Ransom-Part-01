using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("42861F26-1ECA-43BA-8A43-ADF3291D8C81")]
[ComVisible(true)]
public sealed class GEventArgs0 : EventArgs
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private bool bool_0;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	internal GEventArgs0(string string_1, bool bool_1)
	{
		Delegate174.smethod_0(this, string_1);
		Delegate175.smethod_0(this, bool_1);
	}

	public override string ToString()
	{
		return Delegate176.smethod_0(this);
	}
}
