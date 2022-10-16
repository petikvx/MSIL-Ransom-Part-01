using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InvocationGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceComparator()
	{
	}
}
