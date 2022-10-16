using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SerializerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceManager()
	{
	}
}
