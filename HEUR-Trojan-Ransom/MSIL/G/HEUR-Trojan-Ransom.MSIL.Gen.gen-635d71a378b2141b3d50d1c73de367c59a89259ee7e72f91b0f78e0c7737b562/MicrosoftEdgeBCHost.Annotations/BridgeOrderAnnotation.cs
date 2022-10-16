using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BridgeOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralAccount()
	{
	}
}
