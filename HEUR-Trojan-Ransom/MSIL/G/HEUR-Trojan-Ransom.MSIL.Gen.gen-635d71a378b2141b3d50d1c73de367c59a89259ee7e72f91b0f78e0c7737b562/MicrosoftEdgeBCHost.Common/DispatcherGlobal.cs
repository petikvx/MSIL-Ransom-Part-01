using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DispatcherGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceAuthentication()
	{
	}
}
