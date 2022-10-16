using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralService()
	{
	}
}
