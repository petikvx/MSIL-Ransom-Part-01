using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceRepository()
	{
	}
}
