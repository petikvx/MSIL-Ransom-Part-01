using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class CINGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

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

	[DebuggerNonUserCode]
	public CINGR()
	{
		((Form)this).add_Load((EventHandler)CIN_Load);
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CINGR));
		ListView1 = new ListView();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader1 = new ColumnHeader();
		ImageList1 = new ImageList(components);
		((Control)this).SuspendLayout();
		ListView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader2, ColumnHeader1 });
		((Control)ListView1).set_Dock((DockStyle)5);
		((Control)ListView1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		ListView1.set_FullRowSelect(true);
		ListView1.set_LargeImageList(ImageList1);
		ListView listView = ListView1;
		Point location = new Point(0, 0);
		((Control)listView).set_Location(location);
		ListView listView2 = ListView1;
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(4, 4, 4, 4);
		((Control)listView2).set_Margin(margin);
		((Control)ListView1).set_Name("ListView1");
		ListView listView3 = ListView1;
		Size size = new Size(709, 415);
		((Control)listView3).set_Size(size);
		ListView1.set_SmallImageList(ImageList1);
		((Control)ListView1).set_TabIndex(0);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		ColumnHeader2.set_Text("");
		ColumnHeader2.set_Width(167);
		ColumnHeader1.set_Text(" ");
		ColumnHeader1.set_Width(355);
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "0.png");
		ImageList1.get_Images().SetKeyName(1, "1.png");
		ImageList1.get_Images().SetKeyName(2, "2.png");
		ImageList1.get_Images().SetKeyName(3, "3.png");
		ImageList1.get_Images().SetKeyName(4, "4.png");
		ImageList1.get_Images().SetKeyName(5, "5.png");
		ImageList1.get_Images().SetKeyName(6, "6.png");
		ImageList1.get_Images().SetKeyName(7, "7.png");
		ImageList1.get_Images().SetKeyName(8, "8.png");
		ImageList1.get_Images().SetKeyName(9, "9.png");
		ImageList1.get_Images().SetKeyName(10, "10.png");
		ImageList1.get_Images().SetKeyName(11, "11.png");
		ImageList1.get_Images().SetKeyName(12, "12.png");
		SizeF autoScaleDimensions = new SizeF(8f, 16f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(709, 415);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Padding)(ref margin))._002Ector(4, 4, 4, 4);
		((Form)this).set_Margin(margin);
		((Control)this).set_Name("CIN");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CIN");
		((Control)this).ResumeLayout(false);
	}

	private void CIN_Load(object sender, EventArgs e)
	{
	}
}
