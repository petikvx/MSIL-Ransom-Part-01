using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RecordPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceProcess()
	{
	}
}
