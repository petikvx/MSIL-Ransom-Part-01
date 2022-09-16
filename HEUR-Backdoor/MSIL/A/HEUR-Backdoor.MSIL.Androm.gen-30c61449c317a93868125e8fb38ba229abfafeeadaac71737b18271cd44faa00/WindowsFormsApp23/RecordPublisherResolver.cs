using System;
using System.Reflection;
using System.Threading;

namespace WindowsFormsApp23;

internal class RecordPublisherResolver
{
	private static RecordPublisherResolver PrepareMapping;

	internal Assembly InitExporter()
	{
		return ((AppDomain)ReadMapping()).Load(Candidate.CollectExporter());
	}

	internal static object ReadMapping()
	{
		return Thread.GetDomain();
	}

	internal static bool CountMapping()
	{
		return PrepareMapping == null;
	}

	internal static RecordPublisherResolver InvokeMapping()
	{
		return PrepareMapping;
	}
}
