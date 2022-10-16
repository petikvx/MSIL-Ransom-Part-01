using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RecordOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceAuthentication()
	{
	}
}
