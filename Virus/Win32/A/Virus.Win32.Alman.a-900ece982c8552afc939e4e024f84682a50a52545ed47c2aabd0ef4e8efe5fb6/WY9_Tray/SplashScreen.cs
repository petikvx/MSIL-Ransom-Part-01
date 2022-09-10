using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using WY9_Tray.My;

namespace WY9_Tray;

[DesignerGenerated]
public sealed class SplashScreen : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("ApplicationTitle")]
	private Label _ApplicationTitle;

	[AccessedThroughProperty("Version")]
	private Label _Version;

	[AccessedThroughProperty("Copyright")]
	private Label _Copyright;

	[AccessedThroughProperty("MainLayoutPanel")]
	private TableLayoutPanel _MainLayoutPanel;

	[AccessedThroughProperty("DetailsLayoutPanel")]
	private TableLayoutPanel _DetailsLayoutPanel;

	private IContainer components;

	internal virtual Label ApplicationTitle
	{
		[DebuggerNonUserCode]
		get
		{
			return _ApplicationTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ApplicationTitle = value;
		}
	}

	internal virtual Label Version
	{
		[DebuggerNonUserCode]
		get
		{
			return _Version;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Version = value;
		}
	}

	internal virtual Label Copyright
	{
		[DebuggerNonUserCode]
		get
		{
			return _Copyright;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Copyright = value;
		}
	}

	internal virtual TableLayoutPanel MainLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _MainLayoutPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MainLayoutPanel = value;
		}
	}

	internal virtual TableLayoutPanel DetailsLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailsLayoutPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailsLayoutPanel = value;
		}
	}

	[DebuggerNonUserCode]
	public SplashScreen()
	{
		((Form)this).add_Load((EventHandler)SplashScreen1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SplashScreen));
		MainLayoutPanel = new TableLayoutPanel();
		DetailsLayoutPanel = new TableLayoutPanel();
		Version = new Label();
		Copyright = new Label();
		ApplicationTitle = new Label();
		((Control)MainLayoutPanel).SuspendLayout();
		((Control)DetailsLayoutPanel).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)MainLayoutPanel).set_BackgroundImage((Image)componentResourceManager.GetObject("MainLayoutPanel.BackgroundImage"));
		((Control)MainLayoutPanel).set_BackgroundImageLayout((ImageLayout)3);
		MainLayoutPanel.set_ColumnCount(2);
		MainLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 37f));
		MainLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 306f));
		MainLayoutPanel.get_Controls().Add((Control)(object)DetailsLayoutPanel, 1, 1);
		MainLayoutPanel.get_Controls().Add((Control)(object)ApplicationTitle, 1, 0);
		((Control)MainLayoutPanel).set_Dock((DockStyle)5);
		TableLayoutPanel mainLayoutPanel = MainLayoutPanel;
		Point location = new Point(0, 0);
		((Control)mainLayoutPanel).set_Location(location);
		((Control)MainLayoutPanel).set_Name("MainLayoutPanel");
		MainLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 218f));
		MainLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 38f));
		TableLayoutPanel mainLayoutPanel2 = MainLayoutPanel;
		Size size = new Size(496, 303);
		((Control)mainLayoutPanel2).set_Size(size);
		((Control)MainLayoutPanel).set_TabIndex(0);
		((Control)DetailsLayoutPanel).set_Anchor((AnchorStyles)0);
		((Control)DetailsLayoutPanel).set_BackColor(Color.Transparent);
		DetailsLayoutPanel.set_ColumnCount(1);
		DetailsLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 247f));
		DetailsLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 142f));
		DetailsLayoutPanel.get_Controls().Add((Control)(object)Version, 0, 0);
		DetailsLayoutPanel.get_Controls().Add((Control)(object)Copyright, 0, 1);
		TableLayoutPanel detailsLayoutPanel = DetailsLayoutPanel;
		location = new Point(143, 221);
		((Control)detailsLayoutPanel).set_Location(location);
		((Control)DetailsLayoutPanel).set_Name("DetailsLayoutPanel");
		DetailsLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		DetailsLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		TableLayoutPanel detailsLayoutPanel2 = DetailsLayoutPanel;
		size = new Size(247, 79);
		((Control)detailsLayoutPanel2).set_Size(size);
		((Control)DetailsLayoutPanel).set_TabIndex(1);
		((Control)Version).set_Anchor((AnchorStyles)0);
		((Control)Version).set_BackColor(Color.Transparent);
		((Control)Version).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label version = Version;
		location = new Point(3, 9);
		((Control)version).set_Location(location);
		((Control)Version).set_Name("Version");
		Label version2 = Version;
		size = new Size(241, 20);
		((Control)version2).set_Size(size);
		((Control)Version).set_TabIndex(1);
		Version.set_Text("版本 {0}.{1}.{2}.{3}");
		((Control)Copyright).set_Anchor((AnchorStyles)0);
		((Control)Copyright).set_BackColor(Color.Transparent);
		((Control)Copyright).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label copyright = Copyright;
		location = new Point(3, 39);
		((Control)copyright).set_Location(location);
		((Control)Copyright).set_Name("Copyright");
		Label copyright2 = Copyright;
		size = new Size(241, 40);
		((Control)copyright2).set_Size(size);
		((Control)Copyright).set_TabIndex(2);
		Copyright.set_Text("版权");
		((Control)ApplicationTitle).set_Anchor((AnchorStyles)0);
		((Control)ApplicationTitle).set_BackColor(Color.Transparent);
		((Control)ApplicationTitle).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label applicationTitle = ApplicationTitle;
		location = new Point(40, 0);
		((Control)applicationTitle).set_Location(location);
		((Control)ApplicationTitle).set_Name("ApplicationTitle");
		Label applicationTitle2 = ApplicationTitle;
		size = new Size(453, 218);
		((Control)applicationTitle2).set_Size(size);
		((Control)ApplicationTitle).set_TabIndex(0);
		ApplicationTitle.set_Text("应用程序标题");
		ApplicationTitle.set_TextAlign((ContentAlignment)256);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(496, 303);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)MainLayoutPanel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("SplashScreen");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)MainLayoutPanel).ResumeLayout(false);
		((Control)DetailsLayoutPanel).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void SplashScreen1_Load(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_Title(), "", false) != 0)
		{
			ApplicationTitle.set_Text("Guodian-Wuyi IEC61850 Server Tray");
		}
		else
		{
			ApplicationTitle.set_Text(Path.GetFileNameWithoutExtension(((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName()));
		}
		Version.set_Text(string.Format(Version.get_Text(), ((ApplicationBase)MyProject.Application).get_Info().get_Version().Major, ((ApplicationBase)MyProject.Application).get_Info().get_Version().Minor, ((ApplicationBase)MyProject.Application).get_Info().get_Version().Build, ((ApplicationBase)MyProject.Application).get_Info().get_Version().Revision));
		Copyright.set_Text(((ApplicationBase)MyProject.Application).get_Info().get_Copyright());
	}
}
