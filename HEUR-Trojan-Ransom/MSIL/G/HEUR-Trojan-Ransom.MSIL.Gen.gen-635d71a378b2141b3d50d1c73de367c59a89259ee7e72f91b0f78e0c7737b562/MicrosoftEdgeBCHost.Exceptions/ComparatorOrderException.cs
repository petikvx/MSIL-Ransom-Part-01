using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComparatorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceIdentifier()
	{
	}
}
