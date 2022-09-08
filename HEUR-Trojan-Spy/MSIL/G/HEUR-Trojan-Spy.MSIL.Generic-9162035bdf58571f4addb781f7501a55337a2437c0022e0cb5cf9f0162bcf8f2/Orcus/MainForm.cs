using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Orcus.Config;
using Orcus.Connection;
using Orcus.Core;
using Orcus.Shared.Settings;

namespace Orcus;

public class MainForm : Form
{
	private readonly Client _client;

	private IContainer components;

	private Button KillButton;

	private Button UninstallButton;

	private Label ConnectedLabel;

	private Label label3;

	private Label label2;

	private Label label1;

	internal MainForm(Client client)
	{
		InitializeComponent();
		((Form)this).add_Closing((CancelEventHandler)Form1_Closing);
		_client = client;
		_client.Connected += _client_Connected;
		_client.Disconnected += _client_Disconnected;
		if (_client.IsConnected)
		{
			Connected(_client);
		}
		else
		{
			Disconnected();
		}
		((Control)UninstallButton).set_Enabled(Settings.GetBuilderProperty<InstallBuilderProperty>().get_Install());
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
	}

	private void _client_Disconnected(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (((Control)this).get_IsHandleCreated())
		{
			((Control)this).Invoke((Delegate)new MethodInvoker(Disconnected));
		}
	}

	private void Connected(Client client)
	{
		IPEndPoint iPEndPoint = (IPEndPoint)client.Connection.TcpClient.Client.RemoteEndPoint;
		((Control)ConnectedLabel).set_Text($"Connected to {iPEndPoint.Address}:{iPEndPoint.Port}");
		((Control)ConnectedLabel).set_ForeColor(Color.DarkGreen);
	}

	private void Disconnected()
	{
		((Control)ConnectedLabel).set_Text("Not connected");
		((Control)ConnectedLabel).set_ForeColor(Color.DarkRed);
	}

	private void _client_Connected(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((Control)this).Invoke((Delegate)(MethodInvoker)delegate
		{
			Connected(_client);
		});
	}

	private void KillButton_Click(object sender, EventArgs e)
	{
		Program.Exit();
	}

	private void UninstallButton_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			UninstallHelper.UninstallAndClose();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		KillButton = new Button();
		UninstallButton = new Button();
		ConnectedLabel = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)KillButton).set_Location(new Point(11, 101));
		((Control)KillButton).set_Name("KillButton");
		((Control)KillButton).set_Size(new Size(75, 23));
		((Control)KillButton).set_TabIndex(2);
		((Control)KillButton).set_Text("Close");
		((ButtonBase)KillButton).set_UseVisualStyleBackColor(true);
		((Control)KillButton).add_Click((EventHandler)KillButton_Click);
		((Control)UninstallButton).set_Location(new Point(92, 101));
		((Control)UninstallButton).set_Name("UninstallButton");
		((Control)UninstallButton).set_Size(new Size(75, 23));
		((Control)UninstallButton).set_TabIndex(3);
		((Control)UninstallButton).set_Text("Uninstall");
		((ButtonBase)UninstallButton).set_UseVisualStyleBackColor(true);
		((Control)UninstallButton).add_Click((EventHandler)UninstallButton_Click);
		((Control)ConnectedLabel).set_AutoSize(true);
		((Control)ConnectedLabel).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ConnectedLabel).set_ForeColor(Color.DarkRed);
		((Control)ConnectedLabel).set_Location(new Point(57, 69));
		((Control)ConnectedLabel).set_Name("ConnectedLabel");
		((Control)ConnectedLabel).set_Size(new Size(83, 13));
		((Control)ConnectedLabel).set_TabIndex(4);
		((Control)ConnectedLabel).set_Text("Not connected");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(11, 69));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(42, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Status:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI Semibold", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(156, 13));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Publisher: Orcus Technologies");
		((Control)label1).set_Font(new Font("Segoe UI", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(11, 35));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(561, 32));
		((Control)label1).set_TabIndex(8);
		((Control)label1).set_Text("Orcus is a Remote Administration Tool for Windows. It allows the administrator to make changes to this system remotely.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(585, 136));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)ConnectedLabel);
		((Control)this).get_Controls().Add((Control)(object)UninstallButton);
		((Control)this).get_Controls().Add((Control)(object)KillButton);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Orcus Client");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
