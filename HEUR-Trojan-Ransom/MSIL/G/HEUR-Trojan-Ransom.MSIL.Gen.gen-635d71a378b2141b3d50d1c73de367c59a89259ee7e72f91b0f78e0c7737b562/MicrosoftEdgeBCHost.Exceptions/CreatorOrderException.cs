using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceConnection()
	{
	}
}
