using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicyClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyClass()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceThread()
	{
	}
}
