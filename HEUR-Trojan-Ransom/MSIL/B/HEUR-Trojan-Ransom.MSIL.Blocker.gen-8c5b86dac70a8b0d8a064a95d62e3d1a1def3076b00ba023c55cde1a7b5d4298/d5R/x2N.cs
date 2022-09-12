using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Es9r;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace d5R;

[DesignerGenerated]
public class x2N : Form
{
	private IContainer components;

	private int m_ChildFormNumber;

	[field: AccessedThroughProperty("ToolTip")]
	internal virtual ToolTip ToolTip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusStrip")]
	internal virtual StatusStrip StatusStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AddNewToolStripMenuItem")]
	internal virtual ToolStripMenuItem AddNewToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InformationToolStripMenuItem")]
	internal virtual ToolStripMenuItem InformationToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AddNewStudentToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddNewStudentToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ri8;
			ToolStripMenuItem addNewStudentToolStripMenuItem = _AddNewStudentToolStripMenuItem;
			if (addNewStudentToolStripMenuItem != null)
			{
				((ToolStripItem)addNewStudentToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewStudentToolStripMenuItem = value;
			addNewStudentToolStripMenuItem = _AddNewStudentToolStripMenuItem;
			if (addNewStudentToolStripMenuItem != null)
			{
				((ToolStripItem)addNewStudentToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddNewSubjectToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddNewSubjectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Xi1;
			ToolStripMenuItem addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewSubjectToolStripMenuItem = value;
			addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddNewClassToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddNewClassToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wk9;
			ToolStripMenuItem addNewClassToolStripMenuItem = _AddNewClassToolStripMenuItem;
			if (addNewClassToolStripMenuItem != null)
			{
				((ToolStripItem)addNewClassToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewClassToolStripMenuItem = value;
			addNewClassToolStripMenuItem = _AddNewClassToolStripMenuItem;
			if (addNewClassToolStripMenuItem != null)
			{
				((ToolStripItem)addNewClassToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SearchStudentToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SearchStudentToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r1S;
			ToolStripMenuItem searchStudentToolStripMenuItem = _SearchStudentToolStripMenuItem;
			if (searchStudentToolStripMenuItem != null)
			{
				((ToolStripItem)searchStudentToolStripMenuItem).remove_Click(eventHandler);
			}
			_SearchStudentToolStripMenuItem = value;
			searchStudentToolStripMenuItem = _SearchStudentToolStripMenuItem;
			if (searchStudentToolStripMenuItem != null)
			{
				((ToolStripItem)searchStudentToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FindStudentDetailsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FindStudentDetailsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Kq0;
			ToolStripMenuItem findStudentDetailsToolStripMenuItem = _FindStudentDetailsToolStripMenuItem;
			if (findStudentDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findStudentDetailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_FindStudentDetailsToolStripMenuItem = value;
			findStudentDetailsToolStripMenuItem = _FindStudentDetailsToolStripMenuItem;
			if (findStudentDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findStudentDetailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SearchSubjectToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SearchSubjectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x9Z;
			ToolStripMenuItem searchSubjectToolStripMenuItem = _SearchSubjectToolStripMenuItem;
			if (searchSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)searchSubjectToolStripMenuItem).remove_Click(eventHandler);
			}
			_SearchSubjectToolStripMenuItem = value;
			searchSubjectToolStripMenuItem = _SearchSubjectToolStripMenuItem;
			if (searchSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)searchSubjectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FindClassDetailsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FindClassDetailsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d5X;
			ToolStripMenuItem findClassDetailsToolStripMenuItem = _FindClassDetailsToolStripMenuItem;
			if (findClassDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findClassDetailsToolStripMenuItem).remove_Click(eventHandler);
			}
			_FindClassDetailsToolStripMenuItem = value;
			findClassDetailsToolStripMenuItem = _FindClassDetailsToolStripMenuItem;
			if (findClassDetailsToolStripMenuItem != null)
			{
				((ToolStripItem)findClassDetailsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddNewSubjectToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _AddNewSubjectToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Dy1;
			ToolStripMenuItem addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem1;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddNewSubjectToolStripMenuItem1 = value;
			addNewSubjectToolStripMenuItem = _AddNewSubjectToolStripMenuItem1;
			if (addNewSubjectToolStripMenuItem != null)
			{
				((ToolStripItem)addNewSubjectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yo8;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UserToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _UserToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Qi8;
			ToolStripMenuItem userToolStripMenuItem = _UserToolStripMenuItem;
			if (userToolStripMenuItem != null)
			{
				((ToolStripItem)userToolStripMenuItem).remove_Click(eventHandler);
			}
			_UserToolStripMenuItem = value;
			userToolStripMenuItem = _UserToolStripMenuItem;
			if (userToolStripMenuItem != null)
			{
				((ToolStripItem)userToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	public x2N()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		((Form)this).add_AutoSizeChanged((EventHandler)Lk7);
		((Form)this).add_FormClosed(new FormClosedEventHandler(x5W));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Wt5));
		((Form)this).add_Load((EventHandler)Ni2);
		b9P();
	}

	[DebuggerNonUserCode]
	protected override void j4R(bool o9C)
	{
		try
		{
			if (o9C && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o9C);
		}
	}

	[DebuggerStepThrough]
	private void b9P()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
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
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(x2N));
		StatusStrip = new StatusStrip();
		ToolStripStatusLabel = new ToolStripStatusLabel();
		ToolTip = new ToolTip(components);
		MenuStrip1 = new MenuStrip();
		AddNewToolStripMenuItem = new ToolStripMenuItem();
		AddNewStudentToolStripMenuItem = new ToolStripMenuItem();
		AddNewSubjectToolStripMenuItem = new ToolStripMenuItem();
		AddNewClassToolStripMenuItem = new ToolStripMenuItem();
		AddNewSubjectToolStripMenuItem1 = new ToolStripMenuItem();
		InformationToolStripMenuItem = new ToolStripMenuItem();
		SearchStudentToolStripMenuItem = new ToolStripMenuItem();
		FindStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
		SearchSubjectToolStripMenuItem = new ToolStripMenuItem();
		FindClassDetailsToolStripMenuItem = new ToolStripMenuItem();
		Button1 = new Button();
		UserToolStripMenuItem = new ToolStripMenuItem();
		((Control)StatusStrip).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		((Control)StatusStrip).set_Location(new Point(0, 395));
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip.set_Padding(new Padding(2, 0, 19, 0));
		((Control)StatusStrip).set_Size(new Size(786, 22));
		((Control)StatusStrip).set_TabIndex(7);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		((ToolStripItem)ToolStripStatusLabel).set_Size(new Size(39, 17));
		((ToolStripItem)ToolStripStatusLabel).set_Text("Status");
		((ToolStrip)MenuStrip1).set_BackColor(Color.LightSkyBlue);
		((ToolStrip)MenuStrip1).set_Font(new Font("Segoe UI", 9f, (FontStyle)1));
		MenuStrip1.set_GripStyle((ToolStripGripStyle)1);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)AddNewToolStripMenuItem,
			(ToolStripItem)InformationToolStripMenuItem,
			(ToolStripItem)UserToolStripMenuItem
		});
		((Control)MenuStrip1).set_Location(new Point(0, 0));
		((Control)MenuStrip1).set_Name("MenuStrip1");
		((Control)MenuStrip1).set_Padding(new Padding(8, 2, 0, 2));
		((ToolStrip)MenuStrip1).set_RenderMode((ToolStripRenderMode)2);
		((Control)MenuStrip1).set_Size(new Size(786, 24));
		((Control)MenuStrip1).set_TabIndex(9);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)AddNewToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)AddNewStudentToolStripMenuItem,
			(ToolStripItem)AddNewSubjectToolStripMenuItem,
			(ToolStripItem)AddNewClassToolStripMenuItem,
			(ToolStripItem)AddNewSubjectToolStripMenuItem1
		});
		((ToolStripItem)AddNewToolStripMenuItem).set_Name("AddNewToolStripMenuItem");
		((ToolStripItem)AddNewToolStripMenuItem).set_Size(new Size(70, 20));
		((ToolStripItem)AddNewToolStripMenuItem).set_Text("Add New");
		((ToolStripItem)AddNewStudentToolStripMenuItem).set_Name("AddNewStudentToolStripMenuItem");
		((ToolStripItem)AddNewStudentToolStripMenuItem).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewStudentToolStripMenuItem).set_Text("Add New Student");
		((ToolStripItem)AddNewSubjectToolStripMenuItem).set_Name("AddNewSubjectToolStripMenuItem");
		((ToolStripItem)AddNewSubjectToolStripMenuItem).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewSubjectToolStripMenuItem).set_Text("Add New Subject");
		((ToolStripItem)AddNewClassToolStripMenuItem).set_Name("AddNewClassToolStripMenuItem");
		((ToolStripItem)AddNewClassToolStripMenuItem).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewClassToolStripMenuItem).set_Text("Add New Class");
		((ToolStripItem)AddNewSubjectToolStripMenuItem1).set_Name("AddNewSubjectToolStripMenuItem1");
		((ToolStripItem)AddNewSubjectToolStripMenuItem1).set_Size(new Size(173, 22));
		((ToolStripItem)AddNewSubjectToolStripMenuItem1).set_Text("Add New Course");
		((ToolStripDropDownItem)InformationToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)SearchStudentToolStripMenuItem,
			(ToolStripItem)FindStudentDetailsToolStripMenuItem,
			(ToolStripItem)SearchSubjectToolStripMenuItem,
			(ToolStripItem)FindClassDetailsToolStripMenuItem
		});
		((ToolStripItem)InformationToolStripMenuItem).set_Name("InformationToolStripMenuItem");
		((ToolStripItem)InformationToolStripMenuItem).set_Size(new Size(86, 20));
		((ToolStripItem)InformationToolStripMenuItem).set_Text("Information");
		((ToolStripItem)SearchStudentToolStripMenuItem).set_Name("SearchStudentToolStripMenuItem");
		((ToolStripItem)SearchStudentToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)SearchStudentToolStripMenuItem).set_Text("Find Student ");
		((ToolStripItem)FindStudentDetailsToolStripMenuItem).set_Name("FindStudentDetailsToolStripMenuItem");
		((ToolStripItem)FindStudentDetailsToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)FindStudentDetailsToolStripMenuItem).set_Text("Find Student Details");
		((ToolStripItem)SearchSubjectToolStripMenuItem).set_Name("SearchSubjectToolStripMenuItem");
		((ToolStripItem)SearchSubjectToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)SearchSubjectToolStripMenuItem).set_Text("Find Subject Details");
		((ToolStripItem)FindClassDetailsToolStripMenuItem).set_Name("FindClassDetailsToolStripMenuItem");
		((ToolStripItem)FindClassDetailsToolStripMenuItem).set_Size(new Size(186, 22));
		((ToolStripItem)FindClassDetailsToolStripMenuItem).set_Text("Find Class Details");
		((Control)Button1).set_Anchor((AnchorStyles)9);
		((ButtonBase)Button1).set_AutoSize(true);
		((ButtonBase)Button1).set_BackColor(Color.LightSkyBlue);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(2);
		((ButtonBase)Button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(676, 0));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(105, 29));
		((Control)Button1).set_TabIndex(11);
		((ButtonBase)Button1).set_Text("Logout");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ToolStripItem)UserToolStripMenuItem).set_Name("UserToolStripMenuItem");
		((ToolStripItem)UserToolStripMenuItem).set_Size(new Size(45, 20));
		((ToolStripItem)UserToolStripMenuItem).set_Text("User");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(786, 417));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("MENUS");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("MENUS");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)StatusStrip).ResumeLayout(false);
		((Control)StatusStrip).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void c5R(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		checked
		{
			m_ChildFormNumber++;
			val.set_Text("Window " + Conversions.ToString(m_ChildFormNumber));
			((Control)val).Show();
		}
	}

	private void Mz6(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)We04.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	internal static byte[] n1D(int To3, int Ki9)
	{
		if (To3 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Ki9 + 1];
			for (int i = 0; i <= Ki9; i++)
			{
				int num = To3 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Gx9(array, Ki9);
		}
	}

	private void y8Z(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)We04.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void Hz8(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Ab3(object sender, EventArgs e)
	{
	}

	private void Xp1(object sender, EventArgs e)
	{
	}

	private void f6M(object sender, EventArgs e)
	{
	}

	internal static byte[] Gx9(int[] Lj8, int e4Q)
	{
		checked
		{
			byte[] array = new byte[e4Q + 1];
			int num = Lj8.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Lj8[i];
			}
			return array;
		}
	}

	private void b6G(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void f1B(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void Fd1(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void Ji3(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void Ma9(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}

	private void Ri8(object sender, EventArgs e)
	{
		((Form)We04.Forms.AddmisionForm).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.AddmisionForm).Show();
	}

	private void Lk7(object sender, EventArgs e)
	{
	}

	private void x5W(object sender, FormClosedEventArgs e)
	{
		((Control)We04.Forms.LoginForm1).Show();
		((Control)this).Hide();
	}

	private void Wt5(object sender, FormClosingEventArgs e)
	{
		((Control)We04.Forms.LoginForm1).Show();
		((Control)this).Hide();
	}

	private void Ni2(object sender, EventArgs e)
	{
		((ButtonBase)Button1).set_Text(We04.Forms.LoginForm1.UsernameTextBox.get_Text() + " Logout");
	}

	private void Xi1(object sender, EventArgs e)
	{
		((Form)We04.Forms.Subject).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.Subject).Show();
	}

	private void Wk9(object sender, EventArgs e)
	{
		((Form)We04.Forms.ClassDetail).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.ClassDetail).Show();
	}

	private void r1S(object sender, EventArgs e)
	{
		((Form)We04.Forms.SearchForm).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.SearchForm).Show();
	}

	private void Kq0(object sender, EventArgs e)
	{
		((Form)We04.Forms.AddmisionForm1).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.AddmisionForm1).Show();
	}

	private void x9Z(object sender, EventArgs e)
	{
		((Form)We04.Forms.Subject1).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.Subject1).Show();
	}

	private void d5X(object sender, EventArgs e)
	{
		((Form)We04.Forms.ClassDetail1).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.ClassDetail1).Show();
	}

	private void Dy1(object sender, EventArgs e)
	{
		((Form)We04.Forms.Course).set_MdiParent((Form)(object)this);
		((Control)We04.Forms.Course).Show();
	}

	private void Yo8(object sender, EventArgs e)
	{
		((TextBoxBase)We04.Forms.LoginForm1.TextBox1).Clear();
		We04.Forms.LoginForm1.ComboBox1.ResetText();
		((TextBoxBase)We04.Forms.LoginForm1.UsernameTextBox).Clear();
		((Control)We04.Forms.LoginForm1).Show();
		((Form)this).Close();
	}

	internal static byte a5A(byte Xg5, byte[] An0, int Gj9, int Qn1)
	{
		Xg5 = (byte)(Xg5 ^ checked((byte)(An0[unchecked(Qn1 % An0.Length)] ^ ((Qn1 + unchecked(Gj9 % An0.Length)) & Gj9))));
		return Xg5;
	}

	private void Qi8(object sender, EventArgs e)
	{
		((Control)We04.Forms.AddUser).Show();
	}
}
