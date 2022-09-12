using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns17;

[DesignerGenerated]
public class QuitForm : Form
{
	private IContainer icontainer_0;

	[field: AccessedThroughProperty("lblHeader")]
	internal virtual Label lblHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnYes
	{
		[CompilerGenerated]
		get
		{
			return _btnYes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnYes_Click;
			Button val = _btnYes;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnYes = value;
			val = _btnYes;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnNo
	{
		[CompilerGenerated]
		get
		{
			return _btnNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BtnNo_Click;
			Button val = _btnNo;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnNo = value;
			val = _btnNo;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnJoke
	{
		[CompilerGenerated]
		get
		{
			return _btnJoke;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnJoke_Click;
			Button val = _btnJoke;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnJoke = value;
			val = _btnJoke;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public QuitForm()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		lblHeader = new Label();
		btnYes = new Button();
		btnNo = new Button();
		btnJoke = new Button();
		((Control)this).SuspendLayout();
		lblHeader.set_AutoSize(true);
		((Control)lblHeader).set_BackColor(Color.Transparent);
		((Control)lblHeader).set_Location(new Point(32, 31));
		((Control)lblHeader).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblHeader).set_Name("lblHeader");
		((Control)lblHeader).set_Size(new Size(248, 17));
		((Control)lblHeader).set_TabIndex(0);
		lblHeader.set_Text("Are you sure you want to quit, Buddy?");
		((ButtonBase)btnYes).set_BackColor(Color.DarkOrange);
		((Control)btnYes).set_Location(new Point(123, 343));
		((Control)btnYes).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnYes).set_Name("btnYes");
		((Control)btnYes).set_Size(new Size(100, 28));
		((Control)btnYes).set_TabIndex(1);
		((ButtonBase)btnYes).set_Text("Yes");
		((ButtonBase)btnYes).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnNo).set_BackColor(Color.DarkOrange);
		((Control)btnNo).set_Location(new Point(231, 343));
		((Control)btnNo).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnNo).set_Name("btnNo");
		((Control)btnNo).set_Size(new Size(100, 28));
		((Control)btnNo).set_TabIndex(2);
		((ButtonBase)btnNo).set_Text("No");
		((ButtonBase)btnNo).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnJoke).set_BackColor(Color.DarkOrange);
		((Control)btnJoke).set_Location(new Point(339, 343));
		((Control)btnJoke).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnJoke).set_Name("btnJoke");
		((Control)btnJoke).set_Size(new Size(219, 28));
		((Control)btnJoke).set_TabIndex(3);
		((ButtonBase)btnJoke).set_Text("I'm not your Buddy, Guy");
		((ButtonBase)btnJoke).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ControlDarkDark);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(573, 386));
		((Control)this).get_Controls().Add((Control)(object)btnJoke);
		((Control)this).get_Controls().Add((Control)(object)btnNo);
		((Control)this).get_Controls().Add((Control)(object)btnYes);
		((Control)this).get_Controls().Add((Control)(object)lblHeader);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("QuitForm");
		((Form)this).set_Text("QuitForm");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void BtnNo_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnJoke_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)btnJoke).get_Text(), "I'm not your Buddy, Guy", false) == 0)
		{
			lblHeader.set_Text("I'M NOT YOUR GUY, FRIEND");
			((ButtonBase)btnJoke).set_Text("I'M NOT YOUR FRIEND, PAL");
		}
		else if (Operators.CompareString(((ButtonBase)btnJoke).get_Text(), "I'M NOT YOUR FRIEND, PAL", false) == 0)
		{
			lblHeader.set_Text("I'M NOT YOUR PAL, Guy");
			((ButtonBase)btnJoke).set_Text("I'm not your Guy, Friend");
		}
		else if (Operators.CompareString(((ButtonBase)btnJoke).get_Text(), "I'm not your Guy, Friend", false) == 0)
		{
			lblHeader.set_Text("I'M NOT YOUR Friend, Buddy");
			((ButtonBase)btnJoke).set_Text("I'm not your Buddy, Guy");
		}
	}

	private void btnYes_Click(object sender, EventArgs e)
	{
		((Form)Class2.Forms.Form1).Close();
		((Form)Class2.Forms.MultiPlayer).Close();
		((Control)Class2.Forms.MainMenu).Show();
		((Form)this).Close();
	}
}
