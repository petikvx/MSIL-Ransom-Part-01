using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StateClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateClass()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceThread()
	{
	}
}
