using System;
using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Sequential)]
public class nsACString : nsACStringBase, IDisposable
{
	public nsACString()
	{
		nsACStringBase.NS_CStringContainerInit(this);
	}

	public nsACString(string value)
		: this()
	{
		SetData(value);
	}

	~nsACString()
	{
		Dispose();
	}

	public void Dispose()
	{
		nsACStringBase.NS_CStringContainerFinish(this);
		GC.SuppressFinalize(this);
	}
}
