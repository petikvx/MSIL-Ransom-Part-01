using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskHelper()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralWriter()
	{
	}
}
