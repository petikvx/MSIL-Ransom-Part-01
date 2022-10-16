using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class QueueGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceParameter()
	{
	}
}
