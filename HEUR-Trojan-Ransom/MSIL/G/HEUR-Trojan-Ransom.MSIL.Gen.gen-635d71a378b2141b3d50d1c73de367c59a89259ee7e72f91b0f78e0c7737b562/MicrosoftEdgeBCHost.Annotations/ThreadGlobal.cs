using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ThreadGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceComparator()
	{
	}
}
