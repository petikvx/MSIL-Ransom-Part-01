using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("2C29B0BD-4F77-4743-A72A-B91F6D0EAD16")]
[ComVisible(true)]
public sealed class GEventArgs3 : GEventArgs2
{
	internal GEventArgs3()
	{
	}

	public override string ToString()
	{
		if (Delegate181.smethod_0(this) == null && 0 == 0)
		{
			return "<no error>";
		}
		return Delegate181.smethod_0(this).ToString();
	}
}
