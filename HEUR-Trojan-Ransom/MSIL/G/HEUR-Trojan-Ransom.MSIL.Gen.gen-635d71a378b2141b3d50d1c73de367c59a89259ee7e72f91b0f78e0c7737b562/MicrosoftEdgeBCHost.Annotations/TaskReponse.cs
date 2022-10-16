using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TaskReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralConnection()
	{
	}
}
