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

namespace ClientG;

[DesignerGenerated]
public class ProLGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

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

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
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

	internal virtual ToolStripMenuItem DeleteToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeleteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DeleteToolStripMenuItem_Click;
			if (_DeleteToolStripMenuItem != null)
			{
				((ToolStripItem)_DeleteToolStripMenuItem).remove_Click(eventHandler);
			}
			_DeleteToolStripMenuItem = value;
			if (_DeleteToolStripMenuItem != null)
			{
				((ToolStripItem)_DeleteToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public ProLGR()
	{
		((Form)this).add_Load((EventHandler)PL_Load);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		components = new Container();
		ListView1 = new ListView();
		ColumnHeader1 = new ColumnHeader();
		Button1 = new Button();
		Button2 = new Button();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		DeleteToolStripMenuItem = new ToolStripMenuItem();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		ListView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { ColumnHeader1 });
		((Control)ListView1).set_ContextMenuStrip(ContextMenuStrip1);
		ListView1.set_FullRowSelect(true);
		ListView1.set_GridLines(true);
		ListView listView = ListView1;
		Point location = new Point(0, 1);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		Size size = new Size(218, 236);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(0);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		ColumnHeader1.set_Text("Profile Name");
		ColumnHeader1.set_Width(206);
		Button button = Button1;
		location = new Point(34, 240);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(57, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Cancel");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(92, 240);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(126, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Load Selected Profile");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)DeleteToolStripMenuItem });
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(153, 48);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)DeleteToolStripMenuItem).set_Image((Image)(object)Resources._1484282771_DeleteRed);
		((ToolStripItem)DeleteToolStripMenuItem).set_Name("DeleteToolStripMenuItem");
		ToolStripMenuItem deleteToolStripMenuItem = DeleteToolStripMenuItem;
		size = new Size(152, 22);
		((ToolStripItem)deleteToolStripMenuItem).set_Size(size);
		((ToolStripItem)DeleteToolStripMenuItem).set_Text("Delete");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(220, 267);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ProL");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Builder Profiles");
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void PL_Load(object sender, EventArgs e)
	{
		ListView1.get_Items().Clear();
		string[] files = Directory.GetFiles(Application.get_StartupPath() + "\\Profiles\\");
		checked
		{
			int num = files.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string path = files[num2];
					if (Operators.CompareString(Path.GetExtension(path)!.ToLower(), ".ini", false) == 0)
					{
						ListView1.get_Items().Add(Path.GetFileNameWithoutExtension(path));
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (ListView1.get_SelectedItems().get_Count() > 0)
		{
			MyProject.Forms.FrmMAINGR.loadprofile(ListView1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text());
			((Form)this).Close();
		}
	}

	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListView1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					File.Delete(Application.get_StartupPath() + "\\Profiles\\" + val.get_SubItems().get_Item(0).get_Text() + ".ini");
					val.Remove();
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
	}
}
