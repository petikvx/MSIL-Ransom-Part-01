using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralAccount()
	{
	}
}
