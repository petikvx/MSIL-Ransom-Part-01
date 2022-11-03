using System;
using System.IO.Pipes;
using System.Threading.Tasks;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class NamedPipesAction : SubAction<NamedPipeResult>
{
	public static string Name = "NamedPipes";

	public override string ActionName => Name;

	protected override void Run()
	{
		foreach (string namedPipe in Policy.NamedPipes)
		{
			NamedPipeServerStream server = new NamedPipeServerStream(namedPipe);
			try
			{
				Task.Factory.StartNew(delegate
				{
					server.WaitForConnection();
				});
				Task.Delay(1000).Wait();
				NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(namedPipe);
				try
				{
					namedPipeClientStream.Connect(1000);
					NamedPipeResult.NamedPipe item = new NamedPipeResult.NamedPipe
					{
						Name = namedPipe
					};
					base.Result.NamedPipes.Add(item);
				}
				catch (Exception arg)
				{
					GeneralUtils.Log($"Generating named pipes {arg}");
				}
			}
			finally
			{
				if (server != null)
				{
					((IDisposable)server).Dispose();
				}
			}
		}
	}
}
