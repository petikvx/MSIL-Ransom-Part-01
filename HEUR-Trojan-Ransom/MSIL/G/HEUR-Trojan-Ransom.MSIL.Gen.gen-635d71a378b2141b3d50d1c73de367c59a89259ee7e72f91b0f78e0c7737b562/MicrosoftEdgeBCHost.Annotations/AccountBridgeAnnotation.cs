using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupProccesor()
	{
	}
}
