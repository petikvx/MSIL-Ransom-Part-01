using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

public sealed class ProgressLog : UserControl
{
	private delegate void LogMessageDelegate(Color color, string message);

	private delegate void ClearLogDelegate();

	private IContainer components;

	private RichTextBox richTextBoxLog;

	[NonSerialized]
	internal static GetString _0014;

	public string Text => ((Control)richTextBoxLog).get_Text();

	public ProgressLog()
	{
		InitializeComponent();
	}

	public void LogMessage(Color color, string message)
	{
		if (((Control)richTextBoxLog).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)new LogMessageDelegate(LogMessage), new object[2] { color, message });
		}
		else
		{
			((TextBoxBase)richTextBoxLog).set_SelectionStart(((TextBoxBase)richTextBoxLog).get_TextLength());
			richTextBoxLog.set_SelectionColor(color);
			((TextBoxBase)richTextBoxLog).AppendText(message);
			((TextBoxBase)richTextBoxLog).AppendText(Environment.NewLine);
		}
	}

	public void ClearLog()
	{
		if (((Control)richTextBoxLog).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)new ClearLogDelegate(ClearLog), new object[0]);
		}
		else
		{
			((TextBoxBase)richTextBoxLog).Clear();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		richTextBoxLog = new RichTextBox();
		((Control)this).SuspendLayout();
		((TextBoxBase)richTextBoxLog).set_BorderStyle((BorderStyle)0);
		((Control)richTextBoxLog).set_Dock((DockStyle)5);
		((Control)richTextBoxLog).set_Location(new Point(1, 1));
		((Control)richTextBoxLog).set_Name(_0014(107414444));
		((TextBoxBase)richTextBoxLog).set_ReadOnly(true);
		((Control)richTextBoxLog).set_Size(new Size(311, 129));
		((Control)richTextBoxLog).set_TabIndex(0);
		((Control)richTextBoxLog).set_Text(_0014(107399464));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ControlDarkDark);
		((Control)this).get_Controls().Add((Control)(object)richTextBoxLog);
		((Control)this).set_Name(_0014(107414391));
		((Control)this).set_Padding(new Padding(1));
		((Control)this).set_Size(new Size(313, 131));
		((Control)this).ResumeLayout(false);
	}

	static ProgressLog()
	{
		Strings.CreateGetStringDelegate(typeof(ProgressLog));
	}
}
