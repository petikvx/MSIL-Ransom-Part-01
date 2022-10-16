using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadeObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeObject()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralListener()
	{
	}
}
