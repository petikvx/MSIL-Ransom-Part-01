using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AccountWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountWorker()
	{
		WriterPropertyProducer.ResolveStub();
		WriteCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteCreator()
	{
	}
}
