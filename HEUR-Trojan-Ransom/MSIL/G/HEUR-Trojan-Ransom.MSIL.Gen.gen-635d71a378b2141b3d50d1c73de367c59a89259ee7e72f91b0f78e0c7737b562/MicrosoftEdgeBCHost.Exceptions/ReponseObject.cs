using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ReponseObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseObject()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralOrder()
	{
	}
}
