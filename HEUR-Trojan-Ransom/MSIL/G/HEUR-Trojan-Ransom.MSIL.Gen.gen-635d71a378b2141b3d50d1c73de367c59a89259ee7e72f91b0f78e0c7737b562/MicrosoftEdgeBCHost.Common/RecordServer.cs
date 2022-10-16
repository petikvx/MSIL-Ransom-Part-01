using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RecordServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordServer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralFacade()
	{
	}
}
