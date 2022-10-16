using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExceptionValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceDic()
	{
	}
}
