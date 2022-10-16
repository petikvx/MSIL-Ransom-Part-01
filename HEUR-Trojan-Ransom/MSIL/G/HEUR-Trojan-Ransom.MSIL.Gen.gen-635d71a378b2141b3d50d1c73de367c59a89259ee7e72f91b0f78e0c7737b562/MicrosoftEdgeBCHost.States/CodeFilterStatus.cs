using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceDatabase()
	{
	}
}
