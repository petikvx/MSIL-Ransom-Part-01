using System;
using System.Runtime.InteropServices;

namespace Gecko;

internal class DefaultPromptFactory
{
	private static nsIPromptFactory _factory;

	internal static void Init()
	{
		_factory = Xpcom.GetService<nsIPromptFactory>("@mozilla.org/prompter;1");
	}

	internal static void Shutdown()
	{
		if (_factory != null && Marshal.IsComObject(_factory))
		{
			Marshal.ReleaseComObject(_factory);
		}
		_factory = null;
	}

	public static IntPtr GetPrompt(nsIDOMWindow aParent, ref Guid iid)
	{
		return _factory.GetPrompt(aParent, ref iid);
	}

	public static TPrompt GetPrompt<TPrompt>(nsIDOMWindow aParent = null)
	{
		GuidAttribute guidAttribute = (GuidAttribute)typeof(TPrompt).GetCustomAttributes(typeof(GuidAttribute), inherit: false)[0];
		Guid iid = new Guid(guidAttribute.Value);
		IntPtr prompt = _factory.GetPrompt(aParent, ref iid);
		TPrompt result = ((!Xpcom.IsMono) ? ((TPrompt)Marshal.GetTypedObjectForIUnknown(prompt, typeof(TPrompt))) : ((TPrompt)Marshal.GetObjectForIUnknown(prompt)));
		Marshal.Release(prompt);
		return result;
	}
}
