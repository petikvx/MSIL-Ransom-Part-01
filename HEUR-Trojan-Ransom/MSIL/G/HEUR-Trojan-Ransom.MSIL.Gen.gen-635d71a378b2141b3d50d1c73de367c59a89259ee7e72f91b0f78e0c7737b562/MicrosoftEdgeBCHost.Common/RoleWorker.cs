using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RoleWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleWorker()
	{
		WriterPropertyProducer.ResolveStub();
		WriteWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteWriter()
	{
	}
}
