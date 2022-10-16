using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CreatorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterDatabase()
	{
	}
}
