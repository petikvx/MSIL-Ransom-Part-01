using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterpreterBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AssetGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetGlobal()
	{
	}
}
