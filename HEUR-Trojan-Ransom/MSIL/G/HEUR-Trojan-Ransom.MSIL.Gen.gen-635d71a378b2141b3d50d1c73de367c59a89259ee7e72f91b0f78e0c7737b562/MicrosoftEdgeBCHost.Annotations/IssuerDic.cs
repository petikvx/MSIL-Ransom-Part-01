using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IssuerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralStub()
	{
	}
}
