using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SerializerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceSchema()
	{
	}
}
