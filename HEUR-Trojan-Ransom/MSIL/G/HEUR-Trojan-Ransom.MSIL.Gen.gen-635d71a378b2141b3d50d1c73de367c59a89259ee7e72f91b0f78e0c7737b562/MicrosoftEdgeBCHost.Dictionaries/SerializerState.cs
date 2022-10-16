using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerState()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceRecord()
	{
	}
}
