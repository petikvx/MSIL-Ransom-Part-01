using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SerializerAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralStruct()
	{
	}
}
