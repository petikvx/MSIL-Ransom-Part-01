using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AuthenticationSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralMapping()
	{
	}
}
