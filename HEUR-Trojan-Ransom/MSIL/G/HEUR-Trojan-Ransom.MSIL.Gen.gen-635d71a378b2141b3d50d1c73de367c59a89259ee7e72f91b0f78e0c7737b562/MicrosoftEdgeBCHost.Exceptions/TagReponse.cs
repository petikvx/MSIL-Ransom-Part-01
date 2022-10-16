using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TagReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralObject()
	{
	}
}
