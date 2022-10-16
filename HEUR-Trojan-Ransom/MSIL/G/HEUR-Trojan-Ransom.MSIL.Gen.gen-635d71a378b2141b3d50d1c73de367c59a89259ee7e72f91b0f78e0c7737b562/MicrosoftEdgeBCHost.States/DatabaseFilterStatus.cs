using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DatabaseFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralManager()
	{
	}
}
