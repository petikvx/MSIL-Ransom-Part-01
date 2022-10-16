using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceConsumer()
	{
	}
}
