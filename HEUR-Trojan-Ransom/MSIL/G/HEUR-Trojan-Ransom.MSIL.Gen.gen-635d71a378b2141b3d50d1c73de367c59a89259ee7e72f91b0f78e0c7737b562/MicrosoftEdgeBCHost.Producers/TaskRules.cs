using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskRules()
	{
		WriterPropertyProducer.ResolveStub();
		PushInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInitializer()
	{
	}
}
