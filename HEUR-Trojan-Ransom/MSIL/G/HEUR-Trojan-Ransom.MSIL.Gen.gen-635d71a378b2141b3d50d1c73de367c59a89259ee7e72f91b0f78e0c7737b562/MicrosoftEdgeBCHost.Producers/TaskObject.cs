using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskObject()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralPage()
	{
	}
}
