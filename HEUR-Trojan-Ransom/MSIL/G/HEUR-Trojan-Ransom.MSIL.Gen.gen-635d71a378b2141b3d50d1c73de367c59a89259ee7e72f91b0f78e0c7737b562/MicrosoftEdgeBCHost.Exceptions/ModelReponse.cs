using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ModelReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelReponse()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralObject()
	{
	}
}
