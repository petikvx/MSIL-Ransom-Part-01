using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SchemaObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaObject()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralAuthentication()
	{
	}
}
