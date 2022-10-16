using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class HelperSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralMapping()
	{
	}
}
