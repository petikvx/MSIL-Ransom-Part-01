using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ObserverClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverClass()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceClass()
	{
	}
}
