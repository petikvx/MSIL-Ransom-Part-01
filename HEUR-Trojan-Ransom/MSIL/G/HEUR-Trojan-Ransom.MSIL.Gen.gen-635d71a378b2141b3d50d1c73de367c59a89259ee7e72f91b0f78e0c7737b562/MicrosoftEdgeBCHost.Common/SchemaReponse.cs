using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralIssuer()
	{
	}
}
