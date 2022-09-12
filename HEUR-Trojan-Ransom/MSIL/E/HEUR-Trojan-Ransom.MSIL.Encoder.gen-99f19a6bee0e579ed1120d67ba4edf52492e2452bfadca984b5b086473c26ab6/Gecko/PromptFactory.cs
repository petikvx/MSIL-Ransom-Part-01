using System;
using System.Runtime.InteropServices;

namespace Gecko;

public class PromptFactory : nsIPromptFactory
{
	public static Func<object> PromptServiceCreator { get; set; }

	static PromptFactory()
	{
		PromptServiceCreator = () => new PromptService();
	}

	public IntPtr GetPrompt(nsIDOMWindow aParent, ref Guid iid)
	{
		IntPtr ppv = IntPtr.Zero;
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(PromptServiceCreator());
		Marshal.QueryInterface(iUnknownForObject, ref iid, out ppv);
		Marshal.Release(iUnknownForObject);
		return ppv;
	}
}
