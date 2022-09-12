using System;
using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Sequential)]
public class nsAUTF8String : nsAUTF8StringBase, IDisposable
{
	public nsAUTF8String()
	{
		nsAUTF8StringBase.NS_CStringContainerInit(this);
	}

	public nsAUTF8String(string value)
		: this()
	{
		if (value != null)
		{
			SetData(value);
		}
		else
		{
			nsAUTF8StringBase.NS_CStringSetIsVoid(this, isVoid: true);
		}
	}

	~nsAUTF8String()
	{
		Dispose();
	}

	public void Dispose()
	{
		nsAUTF8StringBase.NS_CStringContainerFinish(this);
		GC.SuppressFinalize(this);
	}
}
