using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class RecordPageMessage
{
	private static ResourceManager _Event;

	private static CultureInfo template;

	internal static RecordPageMessage ConnectExpression;

	internal RecordPageMessage()
	{
	}

	internal static ResourceManager ViewPublisher()
	{
		if (_Event == null)
		{
			ResourceManager resourceManager = (_Event = new ResourceManager("Jdomtjvbhnkujumrsvis.Properties.Resources", typeof(RecordPageMessage).Assembly));
		}
		return _Event;
	}

	internal static CultureInfo StopPublisher()
	{
		return template;
	}

	internal static void UpdatePublisher(CultureInfo v)
	{
		template = v;
	}

	internal static byte[] DeletePublisher()
	{
		object @object = ViewPublisher().GetObject("Gtiyddimjwlwblld", template);
		return (byte[])@object;
	}

	internal static bool PublishExpression()
	{
		return ConnectExpression == null;
	}

	internal static RecordPageMessage CalculateExpression()
	{
		return ConnectExpression;
	}
}
