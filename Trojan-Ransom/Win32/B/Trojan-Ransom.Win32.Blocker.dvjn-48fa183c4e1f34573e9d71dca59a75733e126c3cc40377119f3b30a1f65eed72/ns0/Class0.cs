using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.ApplicationServices;
using ns10;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Class0 : ApplicationBase
{
	static Class0()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (!Class12.StrongNameSignatureVerificationEx_7(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
		{
			throw new SecurityException(Class32.smethod_0(255));
		}
	}

	internal static bool cQdywGKaskZfQoc0kh()
	{
		return true;
	}

	internal static bool LfBZwtkrlDklX36ZXH()
	{
		return false;
	}
}
