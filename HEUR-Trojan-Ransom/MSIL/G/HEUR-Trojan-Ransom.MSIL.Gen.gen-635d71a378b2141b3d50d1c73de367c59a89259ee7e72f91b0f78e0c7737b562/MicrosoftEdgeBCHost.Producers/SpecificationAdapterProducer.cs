using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SpecificationAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralConfiguration()
	{
	}
}
