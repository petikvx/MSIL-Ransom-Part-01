using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValClass()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceWriter()
	{
	}
}
