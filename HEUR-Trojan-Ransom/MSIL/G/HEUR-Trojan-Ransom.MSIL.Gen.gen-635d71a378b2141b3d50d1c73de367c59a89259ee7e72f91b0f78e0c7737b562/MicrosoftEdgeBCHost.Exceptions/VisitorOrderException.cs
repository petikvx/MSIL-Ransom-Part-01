using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class VisitorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceMapping()
	{
	}
}
