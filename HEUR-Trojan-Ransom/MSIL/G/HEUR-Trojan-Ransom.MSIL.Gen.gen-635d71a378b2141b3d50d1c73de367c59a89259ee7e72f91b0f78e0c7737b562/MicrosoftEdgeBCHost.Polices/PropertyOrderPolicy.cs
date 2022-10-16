using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PropertyOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceThread()
	{
	}
}
