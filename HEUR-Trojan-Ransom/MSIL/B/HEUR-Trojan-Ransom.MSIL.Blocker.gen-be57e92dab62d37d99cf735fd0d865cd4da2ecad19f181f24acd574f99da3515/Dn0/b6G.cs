using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cb8f;
using Microsoft.VisualBasic.CompilerServices;

namespace Dn0;

[DesignerGenerated]
public class b6G : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button med
	{
		[CompilerGenerated]
		get
		{
			return _med;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wj82;
			Button val = _med;
			if (val != null)
			{
				((Control)val).remove_MouseHover(eventHandler);
			}
			_med = value;
			val = _med;
			if (val != null)
			{
				((Control)val).add_MouseHover(eventHandler);
			}
		}
	}

	internal virtual Button Bill
	{
		[CompilerGenerated]
		get
		{
			return _Bill;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p3S0;
			Button bill = _Bill;
			if (bill != null)
			{
				((Control)bill).remove_Click(eventHandler);
			}
			_Bill = value;
			bill = _Bill;
			if (bill != null)
			{
				((Control)bill).add_Click(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip strip
	{
		[CompilerGenerated]
		get
		{
			return _strip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = w2LH;
			ContextMenuStrip val = _strip;
			if (val != null)
			{
				((ToolStripDropDown)val).remove_Opening(cancelEventHandler);
			}
			_strip = value;
			val = _strip;
			if (val != null)
			{
				((ToolStripDropDown)val).add_Opening(cancelEventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddElementToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddElementToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = w1HC;
			ToolStripMenuItem addElementToolStripMenuItem = _AddElementToolStripMenuItem;
			if (addElementToolStripMenuItem != null)
			{
				((ToolStripItem)addElementToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddElementToolStripMenuItem = value;
			addElementToolStripMenuItem = _AddElementToolStripMenuItem;
			if (addElementToolStripMenuItem != null)
			{
				((ToolStripItem)addElementToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CheckAvailabilityToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CheckAvailabilityToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Rp26;
			ToolStripMenuItem checkAvailabilityToolStripMenuItem = _CheckAvailabilityToolStripMenuItem;
			if (checkAvailabilityToolStripMenuItem != null)
			{
				((ToolStripItem)checkAvailabilityToolStripMenuItem).remove_Click(eventHandler);
			}
			_CheckAvailabilityToolStripMenuItem = value;
			checkAvailabilityToolStripMenuItem = _CheckAvailabilityToolStripMenuItem;
			if (checkAvailabilityToolStripMenuItem != null)
			{
				((ToolStripItem)checkAvailabilityToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem updateToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _updateToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a9BZ;
			ToolStripMenuItem val = _updateToolStripMenuItem;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			_updateToolStripMenuItem = value;
			val = _updateToolStripMenuItem;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	public b6G()
	{
		((Form)this).add_Load((EventHandler)y0HQ);
		Cd2();
	}

	[DebuggerNonUserCode]
	protected override void d5R(bool w5Z)
	{
		try
		{
			if (w5Z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w5Z);
		}
	}

	[DebuggerStepThrough]
	private void Cd2()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(b6G));
		Label1 = new Label();
		med = new Button();
		strip = new ContextMenuStrip(components);
		AddElementToolStripMenuItem = new ToolStripMenuItem();
		CheckAvailabilityToolStripMenuItem = new ToolStripMenuItem();
		updateToolStripMenuItem = new ToolStripMenuItem();
		Bill = new Button();
		((Control)strip).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Anchor((AnchorStyles)13);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Modern No. 20", 48f));
		((Control)Label1).set_ForeColor(SystemColors.HotTrack);
		Label1.set_ImeMode((ImeMode)0);
		((Control)Label1).set_Location(new Point(617, 65));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(588, 83));
		((Control)Label1).set_TabIndex(9);
		Label1.set_Text("I-Care Pharmacy");
		((Control)med).set_AllowDrop(true);
		((ButtonBase)med).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)med).set_ContextMenuStrip(strip);
		((Control)med).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)med).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)med).set_ImeMode((ImeMode)0);
		((Control)med).set_Location(new Point(631, 212));
		((Control)med).set_Name("med");
		((Control)med).set_Size(new Size(206, 44));
		((Control)med).set_TabIndex(7);
		((ButtonBase)med).set_Text("Medicines");
		((ButtonBase)med).set_UseVisualStyleBackColor(false);
		((ToolStrip)strip).set_AllowDrop(true);
		((ToolStrip)strip).set_BackColor(SystemColors.ActiveCaption);
		((ToolStripDropDown)strip).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ToolStrip)strip).set_ImageScalingSize(new Size(20, 20));
		((ToolStrip)strip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)AddElementToolStripMenuItem,
			(ToolStripItem)CheckAvailabilityToolStripMenuItem,
			(ToolStripItem)updateToolStripMenuItem
		});
		((Control)strip).set_Name("strip");
		((ToolStrip)strip).set_RenderMode((ToolStripRenderMode)2);
		((Control)strip).set_Size(new Size(254, 74));
		((ToolStripItem)AddElementToolStripMenuItem).set_Name("AddElementToolStripMenuItem");
		((ToolStripItem)AddElementToolStripMenuItem).set_Padding(new Padding(0));
		((ToolStripItem)AddElementToolStripMenuItem).set_Size(new Size(253, 22));
		((ToolStripItem)AddElementToolStripMenuItem).set_Text("Add Medicines");
		((ToolStripItem)CheckAvailabilityToolStripMenuItem).set_Name("CheckAvailabilityToolStripMenuItem");
		((ToolStripItem)CheckAvailabilityToolStripMenuItem).set_Size(new Size(253, 24));
		((ToolStripItem)CheckAvailabilityToolStripMenuItem).set_Text("Check Availability");
		((ToolStripItem)updateToolStripMenuItem).set_Name("updateToolStripMenuItem");
		((ToolStripItem)updateToolStripMenuItem).set_Size(new Size(253, 24));
		((ToolStripItem)updateToolStripMenuItem).set_Text("Update Medicines Data");
		((ButtonBase)Bill).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Bill).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Bill).set_ForeColor(SystemColors.ActiveCaptionText);
		((ButtonBase)Bill).set_ImeMode((ImeMode)0);
		((Control)Bill).set_Location(new Point(920, 212));
		((Control)Bill).set_Name("Bill");
		((Control)Bill).set_Size(new Size(219, 41));
		((Control)Bill).set_TabIndex(8);
		((ButtonBase)Bill).set_Text("Billing");
		((ButtonBase)Bill).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(1247, 568));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)med);
		((Control)this).get_Controls().Add((Control)(object)Bill);
		((Control)this).set_Name("Form31");
		((Form)this).set_Text("Pharmacy");
		((Control)strip).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Wj82(object t6SQ, EventArgs Wp3j)
	{
		((ToolStripDropDown)strip).Show((Control)(object)med, 0, ((Control)med).get_Height());
	}

	private void p3S0(object Qd8t, EventArgs Ti5n)
	{
		((Control)Ty0b.Forms.Form32).Show();
	}

	private void y0HQ(object Dz0a, EventArgs Zj91)
	{
	}

	private void w1HC(object Ew7r, EventArgs s2CJ)
	{
		((Control)Ty0b.Forms.Form33).Show();
	}

	private void a9BZ(object f8MH, EventArgs x2BF)
	{
		((Control)Ty0b.Forms.Form34).Show();
	}

	private void w2LH(object j9P6, CancelEventArgs Ae0g)
	{
	}

	private void Rp26(object w7EG, EventArgs g6B4)
	{
		((Control)Ty0b.Forms.Form35).Show();
	}
}
