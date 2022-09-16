using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SandboxDotNet.Helpers;
using SandboxDotNet.Perms;

namespace SandboxDotNet.UserInterface;

public class DevConsole : Form
{
	private readonly SandboxDotNet _sandboxUI;

	private readonly Logging _logging;

	private readonly List<string> _commandHistory = new List<string>();

	private int _lastCommandPos;

	private IContainer components = null;

	private RichTextBox consoleTextBox;

	private TableLayoutPanel devConsoleLayoutPanel;

	private TextBox consoleInputTextBox;

	private Panel inputPanel;

	private Button sendConsoleInputButton;

	private TableLayoutPanel devTogglesPanel;

	private CheckBox unlockDefaultPerms;

	private ToolTip toolTip;

	private TableLayoutPanel loggingTestLayout;

	private Button loggingTestButton;

	private TableLayoutPanel loggingTestSelectionLayout;

	private Label loggingTestLabel;

	private ComboBox loggingTestCombo;

	public DevConsole(SandboxDotNet sandboxUI, Logging logging)
	{
		_sandboxUI = sandboxUI;
		_logging = logging;
		InitializeComponent();
		((ListControl)loggingTestCombo).set_SelectedIndex(0);
	}

	private void CheckKeyword(string word, Color color, int startIndex)
	{
		if (((Control)consoleTextBox).get_Text().Contains(word))
		{
			int num = -1;
			int selectionStart = ((TextBoxBase)consoleTextBox).get_SelectionStart();
			while ((num = ((Control)consoleTextBox).get_Text().IndexOf(word, num + 1)) != -1)
			{
				((TextBoxBase)consoleTextBox).Select(num + startIndex, word.Length);
				consoleTextBox.set_SelectionColor(color);
				((TextBoxBase)consoleTextBox).Select(selectionStart, 0);
				consoleTextBox.set_SelectionColor(Color.Black);
			}
		}
	}

	private void AppendColourText(string text, Color color)
	{
		((TextBoxBase)consoleTextBox).set_SelectionStart(((TextBoxBase)consoleTextBox).get_TextLength());
		((TextBoxBase)consoleTextBox).set_SelectionLength(0);
		consoleTextBox.set_SelectionColor(color);
		((TextBoxBase)consoleTextBox).AppendText(text);
		consoleTextBox.set_SelectionColor(((Control)consoleTextBox).get_ForeColor());
	}

	private void LoadLastInput()
	{
		((Control)consoleInputTextBox).set_Text(_commandHistory[_lastCommandPos]);
		((TextBoxBase)consoleInputTextBox).set_SelectionStart(((TextBoxBase)consoleInputTextBox).get_TextLength());
		((TextBoxBase)consoleInputTextBox).set_SelectionLength(0);
	}

	private void ShowPermissionsUpdateMessage(string message)
	{
		_logging.Log("Updating permissions through the Developer Console can cause issues! Use with caution!", Logging.Severity.WARN);
		_logging.Log(message, Logging.Severity.DEBUG);
	}

	public void AppendToConsole(string message)
	{
		string text = Regex.Replace(message, "\\[((1[0-2]|0?[1-9]):([0-5][0-9]):([0-5][0-9]) ?([AaPp][Mm]))\\]", "").TrimStart(new char[1] { ' ' });
		string value = Regex.Match(message, "\\[((1[0-2]|0?[1-9]):([0-5][0-9]):([0-5][0-9]) ?([AaPp][Mm]))\\]").Value;
		message += Environment.NewLine;
		if (text.StartsWith("[DEBUG]"))
		{
			AppendColourText(message, Color.LightSkyBlue);
			CheckKeyword($"{value} [DEBUG]", Color.Cyan, 0);
		}
		else if (text.StartsWith("[INFO]"))
		{
			AppendColourText(message, Color.LightGreen);
			CheckKeyword($"{value} [INFO]", Color.Lime, 0);
		}
		else if (text.StartsWith("[WARN]"))
		{
			AppendColourText(message, Color.LightYellow);
			CheckKeyword($"{value} [WARN]", Color.Gold, 0);
		}
		else if (text.StartsWith("[ERROR]"))
		{
			AppendColourText(message, Color.PaleVioletRed);
			CheckKeyword($"{value} [ERROR]", Color.Red, 0);
		}
		((TextBoxBase)consoleTextBox).set_SelectionStart(((TextBoxBase)consoleTextBox).get_TextLength());
		((TextBoxBase)consoleTextBox).set_SelectionLength(0);
		((TextBoxBase)consoleTextBox).ScrollToCaret();
	}

	public void ConsoleVisibility(bool visible)
	{
		unlockDefaultPerms.set_Checked(!_sandboxUI.GetPermissions().DefaultPermissions);
		((Control)this).set_Visible(visible);
	}

	private void loggingTestButton_Click(object sender, EventArgs e)
	{
		switch (((ListControl)loggingTestCombo).get_SelectedIndex())
		{
		case 0:
			_logging.Log("Logging test message (DEBUG)", Logging.Severity.DEBUG);
			break;
		case 1:
			_logging.Log("Logging test message (INFO)");
			break;
		case 2:
			_logging.Log("Logging test message (WARN)", Logging.Severity.WARN);
			break;
		case 3:
			_logging.Log("Logging test message (ERROR)", Logging.Severity.ERROR);
			break;
		}
	}

	private void sendConsoleInputButton_Click(object sender, EventArgs e)
	{
		string text = ((Control)consoleInputTextBox).get_Text();
		_commandHistory.Add(text);
		_lastCommandPos = _commandHistory.Count;
		try
		{
			if (text.StartsWith("setpermissions") || text.StartsWith("setperms"))
			{
				text.Replace("permissions", "").Replace("perms", "");
				string[] array = SandboxUtils.ConvertStringArgsWithQuotes(text.ToLower());
				Permissions permissions = _sandboxUI.GetPermissions();
				if (array.Contains("all"))
				{
					permissions.GiveAllPermissions();
				}
				else if (array.Contains("none"))
				{
					permissions = new Permissions(includeDefaultPerms: false);
				}
				else if (array.Contains("default"))
				{
					permissions = new Permissions();
				}
				else
				{
					SandboxUtils.ExtractPermissions(ref permissions, array);
				}
				_sandboxUI.UpdatePermissions(permissions);
				ShowPermissionsUpdateMessage("Updated permissions! [Set]");
			}
			else if (text.StartsWith("addpermissions") || text.StartsWith("addperms"))
			{
				text.Replace("permissions", "").Replace("perms", "");
				string[] array2 = SandboxUtils.ConvertStringArgsWithQuotes(text.ToLower());
				Permissions permissions2 = _sandboxUI.GetPermissions();
				if (array2.Contains("all"))
				{
					permissions2.GiveAllPermissions();
				}
				else if (array2.Contains("none"))
				{
					permissions2 = new Permissions(includeDefaultPerms: false);
				}
				else if (array2.Contains("default"))
				{
					permissions2 = new Permissions();
				}
				else
				{
					SandboxUtils.ExtractPermissions(ref permissions2, array2);
				}
				_sandboxUI.UpdatePermissions(permissions2);
				ShowPermissionsUpdateMessage("Updated permissions! [Add]");
			}
			else if (text.StartsWith("resetpermissions") || text.StartsWith("resetperms"))
			{
				Permissions permissions3 = new Permissions();
				_sandboxUI.UpdatePermissions(permissions3);
				_logging.Log("Updated permissions! [Reset]", Logging.Severity.DEBUG);
			}
			else if (text.Equals("clear") || text.Equals("cls"))
			{
				((Control)consoleTextBox).ResetText();
			}
			else if (text.Equals("version") || text.Equals("ver"))
			{
				_logging.Log($"SandboxDotNet {DFHGUYV.GetVersion()}", Logging.Severity.DEBUG);
			}
			else if (text.Equals("clearfiles") || text.Equals("clearfilelist") || text.Equals("clearfileslist"))
			{
				_sandboxUI.ClearFileList();
				ShowPermissionsUpdateMessage("Cleared File I/O List!");
			}
			else if (text.StartsWith("addfile"))
			{
				string[] array3 = text.Replace("addfile", "").Trim().Split(new char[1] { ' ' });
				if (array3.Length == 2)
				{
					string path = SandboxUtils.ConvertStringArgsWithQuotes(array3[0])[0];
					if (File.Exists(path) || Directory.Exists(path))
					{
						if (SandboxUtils.IsFileReadWriteAppendRegex(array3[1]))
						{
							string source = array3[1];
							_sandboxUI.AddPathToList(path, Enumerable.Contains(source, 'r'), Enumerable.Contains(source, 'w'), Enumerable.Contains(source, 'a'));
						}
					}
					else
					{
						_logging.Log($"Invalid filepath provided! ({array3[0]})", Logging.Severity.DEBUG);
					}
				}
				else
				{
					_logging.Log("Too few arguments provided! (Requires: 2)", Logging.Severity.DEBUG);
				}
			}
			else if (text.Equals("runsandbox") || text.Equals("run"))
			{
				_sandboxUI.RunSandbox();
			}
			else if (text.Equals("abortsandbox") || text.Equals("abort"))
			{
				_sandboxUI.AbortSandbox();
			}
			else
			{
				_logging.Log($"Unknown command '{text}'", Logging.Severity.DEBUG);
			}
		}
		catch (Exception arg)
		{
			_logging.Log($"An unexpected error occurred parsing the command '{text}': {arg}", Logging.Severity.ERROR);
		}
		((Control)consoleInputTextBox).ResetText();
	}

	private void consoleInputTextBox_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 38 && _lastCommandPos > 0)
		{
			_lastCommandPos--;
			LoadLastInput();
		}
		else if ((int)e.get_KeyCode() == 40)
		{
			if (_lastCommandPos < _commandHistory.Count - 1)
			{
				_lastCommandPos++;
				LoadLastInput();
			}
			else
			{
				_lastCommandPos = _commandHistory.Count;
				((Control)consoleInputTextBox).ResetText();
			}
		}
	}

	private void unlockDefaultPerms_CheckedChanged(object sender, EventArgs e)
	{
		_sandboxUI.LockDefaultPermissions = !unlockDefaultPerms.get_Checked();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		((Form)this).OnFormClosing(e);
		((Control)this).Hide();
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected O, but got Unknown
		components = new Container();
		consoleTextBox = new RichTextBox();
		devConsoleLayoutPanel = new TableLayoutPanel();
		inputPanel = new Panel();
		consoleInputTextBox = new TextBox();
		sendConsoleInputButton = new Button();
		devTogglesPanel = new TableLayoutPanel();
		unlockDefaultPerms = new CheckBox();
		loggingTestLayout = new TableLayoutPanel();
		loggingTestButton = new Button();
		loggingTestSelectionLayout = new TableLayoutPanel();
		loggingTestLabel = new Label();
		loggingTestCombo = new ComboBox();
		toolTip = new ToolTip(components);
		((Control)devConsoleLayoutPanel).SuspendLayout();
		((Control)inputPanel).SuspendLayout();
		((Control)devTogglesPanel).SuspendLayout();
		((Control)loggingTestLayout).SuspendLayout();
		((Control)loggingTestSelectionLayout).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)consoleTextBox).set_BackColor(Color.Black);
		((Control)consoleTextBox).set_Dock((DockStyle)5);
		((Control)consoleTextBox).set_ForeColor(Color.White);
		((Control)consoleTextBox).set_Location(new Point(6, 6));
		((Control)consoleTextBox).set_Name("consoleTextBox");
		((TextBoxBase)consoleTextBox).set_ReadOnly(true);
		consoleTextBox.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)consoleTextBox).set_Size(new Size(422, 175));
		((Control)consoleTextBox).set_TabIndex(0);
		((Control)consoleTextBox).set_TabStop(false);
		((Control)consoleTextBox).set_Text("");
		devConsoleLayoutPanel.set_ColumnCount(1);
		devConsoleLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		devConsoleLayoutPanel.get_Controls().Add((Control)(object)consoleTextBox, 0, 0);
		devConsoleLayoutPanel.get_Controls().Add((Control)(object)inputPanel, 0, 1);
		devConsoleLayoutPanel.get_Controls().Add((Control)(object)devTogglesPanel, 0, 2);
		((Control)devConsoleLayoutPanel).set_Dock((DockStyle)5);
		((Control)devConsoleLayoutPanel).set_Location(new Point(0, 0));
		((Control)devConsoleLayoutPanel).set_Name("devConsoleLayoutPanel");
		((Control)devConsoleLayoutPanel).set_Padding(new Padding(3));
		devConsoleLayoutPanel.set_RowCount(3);
		devConsoleLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 65.96307f));
		devConsoleLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		devConsoleLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 34.03694f));
		((Control)devConsoleLayoutPanel).set_Size(new Size(434, 311));
		((Control)devConsoleLayoutPanel).set_TabIndex(1);
		((Control)inputPanel).get_Controls().Add((Control)(object)consoleInputTextBox);
		((Control)inputPanel).get_Controls().Add((Control)(object)sendConsoleInputButton);
		((Control)inputPanel).set_Dock((DockStyle)5);
		((Control)inputPanel).set_Location(new Point(6, 187));
		((Control)inputPanel).set_Name("inputPanel");
		((Control)inputPanel).set_Size(new Size(422, 24));
		((Control)inputPanel).set_TabIndex(2);
		((Control)consoleInputTextBox).set_BackColor(Color.Black);
		((Control)consoleInputTextBox).set_Dock((DockStyle)5);
		((Control)consoleInputTextBox).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)consoleInputTextBox).set_ForeColor(Color.White);
		((Control)consoleInputTextBox).set_Location(new Point(0, 0));
		((Control)consoleInputTextBox).set_Name("consoleInputTextBox");
		((Control)consoleInputTextBox).set_Size(new Size(347, 24));
		((Control)consoleInputTextBox).set_TabIndex(1);
		((Control)consoleInputTextBox).add_KeyUp(new KeyEventHandler(consoleInputTextBox_KeyUp));
		((Control)sendConsoleInputButton).set_Dock((DockStyle)4);
		((Control)sendConsoleInputButton).set_Location(new Point(347, 0));
		((Control)sendConsoleInputButton).set_Name("sendConsoleInputButton");
		((Control)sendConsoleInputButton).set_Size(new Size(75, 24));
		((Control)sendConsoleInputButton).set_TabIndex(2);
		((Control)sendConsoleInputButton).set_Text("Send");
		((ButtonBase)sendConsoleInputButton).set_UseVisualStyleBackColor(true);
		((Control)sendConsoleInputButton).add_Click((EventHandler)sendConsoleInputButton_Click);
		devTogglesPanel.set_ColumnCount(2);
		devTogglesPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		devTogglesPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		devTogglesPanel.get_Controls().Add((Control)(object)unlockDefaultPerms, 0, 0);
		devTogglesPanel.get_Controls().Add((Control)(object)loggingTestLayout, 1, 0);
		((Control)devTogglesPanel).set_Dock((DockStyle)5);
		((Control)devTogglesPanel).set_Location(new Point(6, 217));
		((Control)devTogglesPanel).set_Name("devTogglesPanel");
		devTogglesPanel.set_RowCount(4);
		devTogglesPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		devTogglesPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		devTogglesPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		devTogglesPanel.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		((Control)devTogglesPanel).set_Size(new Size(422, 88));
		((Control)devTogglesPanel).set_TabIndex(3);
		((Control)unlockDefaultPerms).set_AutoSize(true);
		((Control)unlockDefaultPerms).set_Dock((DockStyle)5);
		((Control)unlockDefaultPerms).set_Location(new Point(3, 3));
		((Control)unlockDefaultPerms).set_Name("unlockDefaultPerms");
		((Control)unlockDefaultPerms).set_Size(new Size(205, 24));
		((Control)unlockDefaultPerms).set_TabIndex(0);
		((Control)unlockDefaultPerms).set_Text("Unlock Permissions");
		toolTip.SetToolTip((Control)(object)unlockDefaultPerms, "Unlock all permissions. This allows the default three (Execution, Executable File I/O, and UI to be disabled).");
		((ButtonBase)unlockDefaultPerms).set_UseVisualStyleBackColor(true);
		unlockDefaultPerms.add_CheckedChanged((EventHandler)unlockDefaultPerms_CheckedChanged);
		loggingTestLayout.set_ColumnCount(2);
		loggingTestLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 75f));
		loggingTestLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		loggingTestLayout.get_Controls().Add((Control)(object)loggingTestButton, 1, 0);
		loggingTestLayout.get_Controls().Add((Control)(object)loggingTestSelectionLayout, 0, 0);
		((Control)loggingTestLayout).set_Dock((DockStyle)5);
		((Control)loggingTestLayout).set_Location(new Point(211, 0));
		((Control)loggingTestLayout).set_Margin(new Padding(0));
		((Control)loggingTestLayout).set_Name("loggingTestLayout");
		loggingTestLayout.set_RowCount(1);
		loggingTestLayout.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)loggingTestLayout).set_Size(new Size(211, 30));
		((Control)loggingTestLayout).set_TabIndex(1);
		((Control)loggingTestButton).set_Dock((DockStyle)5);
		((Control)loggingTestButton).set_Location(new Point(161, 3));
		((Control)loggingTestButton).set_Name("loggingTestButton");
		((Control)loggingTestButton).set_Size(new Size(47, 24));
		((Control)loggingTestButton).set_TabIndex(0);
		((Control)loggingTestButton).set_Text("Test");
		toolTip.SetToolTip((Control)(object)loggingTestButton, "Test the various severities that can be written to the log");
		((ButtonBase)loggingTestButton).set_UseVisualStyleBackColor(true);
		((Control)loggingTestButton).add_Click((EventHandler)loggingTestButton_Click);
		loggingTestSelectionLayout.set_ColumnCount(2);
		loggingTestSelectionLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		loggingTestSelectionLayout.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 66.66666f));
		loggingTestSelectionLayout.get_Controls().Add((Control)(object)loggingTestLabel, 0, 0);
		loggingTestSelectionLayout.get_Controls().Add((Control)(object)loggingTestCombo, 1, 0);
		((Control)loggingTestSelectionLayout).set_Dock((DockStyle)5);
		((Control)loggingTestSelectionLayout).set_Location(new Point(0, 0));
		((Control)loggingTestSelectionLayout).set_Margin(new Padding(0));
		((Control)loggingTestSelectionLayout).set_Name("loggingTestSelectionLayout");
		loggingTestSelectionLayout.set_RowCount(1);
		loggingTestSelectionLayout.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)loggingTestSelectionLayout).set_Size(new Size(158, 30));
		((Control)loggingTestSelectionLayout).set_TabIndex(1);
		((Control)loggingTestLabel).set_BackColor(Color.Transparent);
		((Control)loggingTestLabel).set_Dock((DockStyle)5);
		((Control)loggingTestLabel).set_Location(new Point(3, 0));
		((Control)loggingTestLabel).set_Name("loggingTestLabel");
		((Control)loggingTestLabel).set_Size(new Size(46, 30));
		((Control)loggingTestLabel).set_TabIndex(0);
		((Control)loggingTestLabel).set_Text("Log Type:");
		loggingTestLabel.set_TextAlign((ContentAlignment)32);
		toolTip.SetToolTip((Control)(object)loggingTestLabel, "Test the various severities that can be written to the log");
		((Control)loggingTestCombo).set_Dock((DockStyle)5);
		loggingTestCombo.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)loggingTestCombo).set_FormattingEnabled(true);
		loggingTestCombo.get_Items().AddRange(new object[4] { "DEBUG", "INFO", "WARN", "ERROR" });
		((Control)loggingTestCombo).set_Location(new Point(55, 3));
		loggingTestCombo.set_MaxDropDownItems(4);
		((Control)loggingTestCombo).set_Name("loggingTestCombo");
		((Control)loggingTestCombo).set_Size(new Size(100, 21));
		((Control)loggingTestCombo).set_TabIndex(1);
		((Form)this).set_AcceptButton((IButtonControl)(object)sendConsoleInputButton);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(434, 311));
		((Control)this).get_Controls().Add((Control)(object)devConsoleLayoutPanel);
		((Control)this).set_MinimumSize(new Size(450, 350));
		((Control)this).set_Name("DevConsole");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("SbDN: Developer Console");
		((Control)devConsoleLayoutPanel).ResumeLayout(false);
		((Control)inputPanel).ResumeLayout(false);
		((Control)inputPanel).PerformLayout();
		((Control)devTogglesPanel).ResumeLayout(false);
		((Control)devTogglesPanel).PerformLayout();
		((Control)loggingTestLayout).ResumeLayout(false);
		((Control)loggingTestSelectionLayout).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
