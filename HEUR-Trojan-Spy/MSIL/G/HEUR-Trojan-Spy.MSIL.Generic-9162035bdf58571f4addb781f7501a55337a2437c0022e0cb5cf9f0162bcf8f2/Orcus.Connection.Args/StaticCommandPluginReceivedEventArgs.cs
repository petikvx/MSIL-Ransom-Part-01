using System;

namespace Orcus.Connection.Args;

public class StaticCommandPluginReceivedEventArgs : EventArgs
{
	public string Filename { get; }

	public int PluginResourceId { get; }

	public StaticCommandPluginReceivedEventArgs(string filename, int pluginResourceId)
	{
		Filename = filename;
		PluginResourceId = pluginResourceId;
	}
}
