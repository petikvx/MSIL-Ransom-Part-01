using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SerializerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerContext()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceRules()
	{
	}
}
