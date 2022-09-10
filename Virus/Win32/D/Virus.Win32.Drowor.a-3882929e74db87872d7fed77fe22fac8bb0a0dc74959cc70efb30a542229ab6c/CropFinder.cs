using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class CropFinder : Form
{
	private GClass6 gclass6_0;

	private List<GStruct3> list_0;

	private IContainer icontainer_0;

	private Button btnLogin;

	private TextBox tbServer;

	private Label label1;

	private Label lblLogin;

	private TextBox tbPassword;

	private TextBox tbLogin;

	private Label lblPassword;

	private TextBox tbOutput;

	private Label label2;

	private TextBox tbX;

	private Label label3;

	private Label label4;

	private TextBox tbY;

	private Button btnClearOutput;

	private Button btnSearch;

	private Label lblSearchRadius;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private ComboBox cbSearchRadius;

	private Button btnStop;

	private TextBox tbDelay;

	private Label label5;

	private Panel panel1;

	private Label label7;

	private Label label6;

	private Panel panel2;

	private Label label9;

	private Label label8;

	private GroupBox groupBox3;

	private CheckBox cbf1;

	private CheckBox cbf6;

	private CheckBox cbf5;

	private CheckBox cbf4;

	private CheckBox cbf3;

	private CheckBox cbf2;

	private Panel panel3;

	private Label label10;

	private Label label11;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private Label lblSearching;

	private CheckBox cbOase;

	private Button btnViewResults;

	private ToolStripMenuItem toolsToolStripMenuItem;

	private ToolStripMenuItem optionsToolStripMenuItem;

	private Label label12;

	private StatusStrip statusStrip1;

	private ToolStripProgressBar tsProgressBar;

	private ToolStripStatusLabel tsStatusLabel;

	private TabControl tabControlMain;

	private TabPage tabPageCropFinder;

	private TabPage tabPageCombat;

	private DateTimePicker tbTimeOfAttack;

	private GroupBox groupBox4;

	private Label label13;

	private Button btnCalculatorGenerate;

	private Label label14;

	private Panel pnlTimeStamp;

	private Label lblSendDate;

	private Label label15;

	private Button btnCalculatorSaveTimeStamp;

	private Label label16;

	private TextBox tbTimeStampName;

	private Button btnClearCombatTimes;

	private TextBox tbTimeStampList;

	private MaskedTextBox tbTroopTravelTime;

	private Panel panel4;

	private Label lblCombatCalculatorText;

	private Button btnLogout;

	public CropFinder()
	{
		InitializeComponent();
		method_8();
		method_5();
		list_0 = new List<GStruct3>();
		gclass6_0 = new GClass6(tsProgressBar, tsStatusLabel);
		gclass6_0.method_0(method_4);
		method_11();
		method_1();
		method_0();
	}

	private void method_0()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (gclass6_0 != null && gclass6_0.method_15())
		{
			MessageBox.Show("A new version of Travian crop-finder is available. Please visit http://www.cs-network.dk to obtain the latest version.");
		}
	}

	private void method_1()
	{
		GClass0 gclass0_ = GClass0.gclass0_0;
		string text = gclass0_.method_6(GClass0.GEnum0.const_10.ToString());
		string text2 = gclass0_.method_6(GClass0.GEnum0.const_8.ToString());
		string text3 = gclass0_.method_6(GClass0.GEnum0.const_9.ToString());
		if (text != null && text != "")
		{
			((Control)tbServer).set_Text(text);
		}
		if (text2 != null)
		{
			((Control)tbLogin).set_Text(text2);
		}
		if (text3 != null)
		{
			((Control)tbPassword).set_Text(text3);
		}
	}

	private void method_2()
	{
		GClass0 gclass0_ = GClass0.gclass0_0;
		gclass0_.method_7(GClass0.GEnum0.const_10.ToString(), ((Control)tbServer).get_Text());
		gclass0_.method_7(GClass0.GEnum0.const_8.ToString(), ((Control)tbLogin).get_Text());
		gclass0_.method_7(GClass0.GEnum0.const_9.ToString(), ((Control)tbPassword).get_Text());
	}

	private bool method_3()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)tbServer).get_Text() == "")
		{
			MessageBox.Show("Please specify Travian server");
			return false;
		}
		if (((Control)tbLogin).get_Text() == "")
		{
			MessageBox.Show("Please specify login information");
			return false;
		}
		if (((Control)tbPassword).get_Text() == "")
		{
			MessageBox.Show("Please specify password information");
			return false;
		}
		return true;
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (method_3())
		{
			gclass6_0.method_13(((Control)tbServer).get_Text());
			string text = ((Control)tbLogin).get_Text();
			string text2 = ((Control)tbPassword).get_Text();
			bool flag = false;
			try
			{
				flag = gclass6_0.method_19(text, text2);
				method_2();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			if (flag)
			{
				method_7("Login was successful. Connected to '" + gclass6_0.method_12() + "' as " + text);
			}
			else
			{
				method_7("Login failed, please make sure server, username, and password is correct");
			}
			method_5();
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		try
		{
			num = Convert.ToInt32(((Control)tbX).get_Text());
			num2 = Convert.ToInt32(((Control)tbY).get_Text());
		}
		catch
		{
			MessageBox.Show("Please specify an X and Y coordinate (numeric values).", "Error.", (MessageBoxButtons)0);
			return;
		}
		list_0.Clear();
		((Control)lblSearching).set_Visible(true);
		method_7("");
		method_7("");
		method_7("Coords     FieldType             Status");
		method_7("--------------------------------------------------------------------");
		Application.DoEvents();
		try
		{
			gclass6_0.method_22(num, num2, method_6());
		}
		catch (Exception ex)
		{
			method_7(ex.Message);
		}
		finally
		{
			method_7("");
			method_7("----------------------------- DONE -----------------------------");
		}
		((Control)lblSearching).set_Visible(false);
		((Control)btnViewResults).set_Enabled(true);
		method_5();
	}

	private void btnStop_Click(object sender, EventArgs e)
	{
		gclass6_0.method_11(bool_1: true);
		method_5();
	}

	private void btnClearOutput_Click(object sender, EventArgs e)
	{
		((Control)tbOutput).set_Text("");
		method_5();
	}

	protected void method_4(string string_0, string string_1, string string_2, string string_3)
	{
		if (string_0 == "$$")
		{
			method_7(string_1);
			return;
		}
		Regex regex = new Regex("\\<div class=\"ddb\"\\>([\\w]*|[\\|]*|[\\s]*|[&#%@£$]*)*\\</div\\>");
		Regex regex2 = new Regex("([-]*[0-9]*)\\|([-]*[0-9]*)", RegexOptions.IgnoreCase);
		Regex regex3 = new Regex("[\\(]*[\\)]*", RegexOptions.IgnoreCase);
		Match match = regex.Match(string_2);
		Match match2 = regex2.Match(string_1);
		string text = "";
		if (match.Success)
		{
			text = match.Value.Replace("<div class=\"ddb\">", "").Replace("</div>", "");
		}
		else
		{
			text = regex2.Replace(string_1, "");
			text = regex3.Replace(text, "");
		}
		if (text.Trim() == "")
		{
			text = "Taken";
		}
		if (method_9(string_0.Trim().ToLower()))
		{
			string text2 = method_10(string_0.Trim().ToLower());
			method_7("( " + match2.Value + " ) :      " + text2 + "      " + text);
			GStruct3 item = default(GStruct3);
			item.string_0 = text2;
			item.string_1 = text;
			item.int_2 = Convert.ToInt32(((Control)tbX).get_Text());
			item.int_3 = Convert.ToInt32(((Control)tbY).get_Text());
			string[] array = match2.Value.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 2)
			{
				try
				{
					item.int_0 = Convert.ToInt32(array[0]);
					item.int_1 = Convert.ToInt32(array[1]);
				}
				catch
				{
					return;
				}
			}
			list_0.Add(item);
		}
		if (int.TryParse(((Control)tbDelay).get_Text(), out var result) && result >= 0)
		{
			Random random = new Random(DateTime.Now.Millisecond);
			int num = random.Next(Math.Max(result - 1, 0), result + 2);
			int num2 = 500;
			if (result > 0)
			{
				Thread.Sleep(num * num2);
			}
		}
		else
		{
			Thread.Sleep(1000);
		}
	}

	private void tbDelay_KeyPress(object sender, KeyPressEventArgs e)
	{
		string text = "-1234567890\b";
		if (text.IndexOf(e.get_KeyChar()) < 0)
		{
			e.set_Handled(true);
		}
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		About about = new About();
		((Form)about).ShowDialog();
	}

	private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Settings settings = new Settings();
		((Form)settings).ShowDialog();
	}

	private void method_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		ToolTip val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnStop, "Click a couple of times to stop the current search");
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnSearch, "Search for specific map fields");
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnClearOutput, "Clear the textbox below");
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnLogin, "Logon to Travian-server with specified username and password");
		val = new ToolTip();
		val.set_InitialDelay(0);
		val.SetToolTip((Control)(object)btnViewResults, "Display results in sorted order starting with the field closest to (X, Y)");
	}

	private int method_6()
	{
		return ((ListControl)cbSearchRadius).get_SelectedIndex();
	}

	private void method_7(string string_0)
	{
		if (((Control)tbOutput).get_Text() != "")
		{
			TextBox obj = tbOutput;
			((Control)obj).set_Text(((Control)obj).get_Text() + Environment.NewLine);
		}
		TextBox obj2 = tbOutput;
		((Control)obj2).set_Text(((Control)obj2).get_Text() + string_0);
	}

	private void method_8()
	{
		cbSearchRadius.get_Items().Add((object)"7x7");
		cbSearchRadius.get_Items().Add((object)"21x21");
		cbSearchRadius.get_Items().Add((object)"35x35");
		cbSearchRadius.get_Items().Add((object)"49x49");
		cbSearchRadius.get_Items().Add((object)"63x63");
		cbSearchRadius.get_Items().Add((object)"77x77");
		((ListControl)cbSearchRadius).set_SelectedIndex(0);
	}

	private bool method_9(string string_0)
	{
		return string_0 switch
		{
			"f1" => cbf1.get_Checked(), 
			"f2" => cbf2.get_Checked(), 
			"f3" => cbf3.get_Checked(), 
			"f4" => cbf4.get_Checked(), 
			"f5" => cbf5.get_Checked(), 
			"f6" => cbf6.get_Checked(), 
			"f?" => cbOase.get_Checked(), 
			_ => false, 
		};
	}

	private string method_10(string string_0)
	{
		return string_0 switch
		{
			"f1" => "3W_3C_3I_9C", 
			"f2" => "3W_4C_5I_6C", 
			"f3" => "4W_4C_4I_6C", 
			"f4" => "4W_5C_3I_6C", 
			"f5" => "5W_3C_4I_6C", 
			"f6" => "1W_1C_1I_15C", 
			_ => "-____Oasis___-", 
		};
	}

	private void btnViewResults_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		SortedResults sortedResults = new SortedResults();
		if (list_0.Count == 0)
		{
			MessageBox.Show("There are currently no results to display", "Warning", (MessageBoxButtons)0);
			return;
		}
		sortedResults.method_0(list_0);
		((Control)sortedResults).Show();
	}

	private void tbTroopTravelTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ToolTip val = new ToolTip();
		val.set_ToolTipTitle("Invalid Input");
		val.Show("We're sorry, but only digits (0-9) are allowed", (IWin32Window)(object)tbTroopTravelTime, ((Control)tbTroopTravelTime).get_Location(), 5000);
	}

	private void btnCalculatorGenerate_Click(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		tbTimeOfAttack.get_Value();
		if (((Control)tbTroopTravelTime).get_Text() == "")
		{
			MessageBox.Show("Please make sure attack time and travel time is specified before generating a timestamp.");
			return;
		}
		DateTime value = tbTimeOfAttack.get_Value();
		string[] array = ((Control)tbTroopTravelTime).get_Text().Split(new string[1] { ":" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 3 && !(array[0].Trim() == "") && !(array[1].Trim() == "") && !(array[2].Trim() == ""))
		{
			if (int.TryParse(array[0], out var result) && int.TryParse(array[1], out var result2) && int.TryParse(array[2], out var result3))
			{
				if (result2 <= 60 && result3 <= 60)
				{
					TimeSpan timeSpan = new TimeSpan(result, result2, result3);
					DateTime dateTime = value - timeSpan;
					((Control)lblSendDate).set_Text(dateTime.ToLongDateString() + "   " + dateTime.ToLongTimeString());
					((Control)pnlTimeStamp).set_Visible(true);
				}
				else
				{
					MessageBox.Show("Either minutes or seconds of the travel time is invalid, please make sure its a digit between 0 and 60.");
				}
			}
			else
			{
				MessageBox.Show("Please make sure travel time is fully specified (hh:mm:ss) before generating a timestamp.");
			}
		}
		else
		{
			MessageBox.Show("Please make sure travel time is fully specified (hh:mm:ss) before generating a timestamp.");
		}
	}

	private void btnCalculatorSaveTimeStamp_Click(object sender, EventArgs e)
	{
		string text = ((Control)tbTimeStampName).get_Text();
		if (((Control)tbTimeStampList).get_Text() != "")
		{
			TextBox obj = tbTimeStampList;
			((Control)obj).set_Text(((Control)obj).get_Text() + Environment.NewLine);
		}
		if (text.Trim() != "")
		{
			text = "(" + text + ")";
		}
		((TextBoxBase)tbTimeStampList).AppendText(((Control)lblSendDate).get_Text() + "  " + text);
	}

	private void btnClearCombatTimes_Click(object sender, EventArgs e)
	{
		((TextBoxBase)tbTimeStampList).Clear();
	}

	private void method_11()
	{
		((Control)lblCombatCalculatorText).set_Text("This is a small attack time calculator utility.");
		Label obj = lblCombatCalculatorText;
		((Control)obj).set_Text(((Control)obj).get_Text() + Environment.NewLine);
		Label obj2 = lblCombatCalculatorText;
		((Control)obj2).set_Text(((Control)obj2).get_Text() + Environment.NewLine);
		Label obj3 = lblCombatCalculatorText;
		((Control)obj3).set_Text(((Control)obj3).get_Text() + "Enter a time of attack, how long it takes your troops to walk the distance, and click Generate. The result will be a timestamp of when to send your troops.");
		Label obj4 = lblCombatCalculatorText;
		((Control)obj4).set_Text(((Control)obj4).get_Text() + Environment.NewLine);
		Label obj5 = lblCombatCalculatorText;
		((Control)obj5).set_Text(((Control)obj5).get_Text() + "It is also possible to cache the result under a given name so you can list the attack times for all your cities. This is done by entering a name (e.g. city name) and clicking the 'Cache timestamp' button.");
	}

	private void btnLogout_Click(object sender, EventArgs e)
	{
		if (gclass6_0.method_21())
		{
			method_7("Logout was successful.");
		}
		else
		{
			method_7("Logout failed, please try again or close the application.");
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected O, but got Unknown
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected O, but got Unknown
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Expected O, but got Unknown
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected O, but got Unknown
		//IL_11d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e0: Expected O, but got Unknown
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		//IL_130e: Expected O, but got Unknown
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_138f: Expected O, but got Unknown
		//IL_1412: Unknown result type (might be due to invalid IL or missing references)
		//IL_141c: Expected O, but got Unknown
		//IL_1638: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Expected O, but got Unknown
		//IL_189a: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a4: Expected O, but got Unknown
		//IL_19bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c5: Expected O, but got Unknown
		//IL_1a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a52: Expected O, but got Unknown
		//IL_1d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d61: Expected O, but got Unknown
		//IL_2098: Unknown result type (might be due to invalid IL or missing references)
		//IL_2124: Unknown result type (might be due to invalid IL or missing references)
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2345: Expected O, but got Unknown
		//IL_23f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fe: Expected O, but got Unknown
		//IL_2711: Unknown result type (might be due to invalid IL or missing references)
		//IL_271b: Expected O, but got Unknown
		//IL_27a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ac: Expected O, but got Unknown
		btnLogin = new Button();
		tbServer = new TextBox();
		label1 = new Label();
		lblLogin = new Label();
		tbPassword = new TextBox();
		tbLogin = new TextBox();
		lblPassword = new Label();
		tbOutput = new TextBox();
		label2 = new Label();
		tbX = new TextBox();
		label3 = new Label();
		label4 = new Label();
		tbY = new TextBox();
		btnClearOutput = new Button();
		btnSearch = new Button();
		lblSearchRadius = new Label();
		groupBox1 = new GroupBox();
		btnLogout = new Button();
		groupBox2 = new GroupBox();
		tbDelay = new TextBox();
		label5 = new Label();
		btnStop = new Button();
		cbSearchRadius = new ComboBox();
		btnViewResults = new Button();
		panel1 = new Panel();
		label7 = new Label();
		label6 = new Label();
		panel2 = new Panel();
		label12 = new Label();
		label9 = new Label();
		label8 = new Label();
		groupBox3 = new GroupBox();
		cbOase = new CheckBox();
		cbf6 = new CheckBox();
		cbf5 = new CheckBox();
		cbf4 = new CheckBox();
		cbf3 = new CheckBox();
		cbf2 = new CheckBox();
		cbf1 = new CheckBox();
		panel3 = new Panel();
		label10 = new Label();
		label11 = new Label();
		menuStrip1 = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		exitToolStripMenuItem = new ToolStripMenuItem();
		toolsToolStripMenuItem = new ToolStripMenuItem();
		optionsToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		lblSearching = new Label();
		statusStrip1 = new StatusStrip();
		tsProgressBar = new ToolStripProgressBar();
		tsStatusLabel = new ToolStripStatusLabel();
		tabControlMain = new TabControl();
		tabPageCropFinder = new TabPage();
		tabPageCombat = new TabPage();
		groupBox4 = new GroupBox();
		panel4 = new Panel();
		lblCombatCalculatorText = new Label();
		tbTroopTravelTime = new MaskedTextBox();
		btnClearCombatTimes = new Button();
		tbTimeStampList = new TextBox();
		pnlTimeStamp = new Panel();
		btnCalculatorSaveTimeStamp = new Button();
		label16 = new Label();
		tbTimeStampName = new TextBox();
		lblSendDate = new Label();
		label15 = new Label();
		btnCalculatorGenerate = new Button();
		label14 = new Label();
		label13 = new Label();
		tbTimeOfAttack = new DateTimePicker();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)menuStrip1).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((Control)tabControlMain).SuspendLayout();
		((Control)tabPageCropFinder).SuspendLayout();
		((Control)tabPageCombat).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)pnlTimeStamp).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btnLogin).set_Location(new Point(22, 111));
		((Control)btnLogin).set_Name("btnLogin");
		((Control)btnLogin).set_Size(new Size(105, 23));
		((Control)btnLogin).set_TabIndex(4);
		((Control)btnLogin).set_Text("Login");
		((ButtonBase)btnLogin).set_UseVisualStyleBackColor(true);
		((Control)btnLogin).add_Click((EventHandler)btnLogin_Click);
		((Control)tbServer).set_Location(new Point(107, 18));
		((Control)tbServer).set_Name("tbServer");
		((Control)tbServer).set_Size(new Size(290, 20));
		((Control)tbServer).set_TabIndex(1);
		((Control)tbServer).set_Text("http://s2.travian.dk");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(19, 21));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(82, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Server (http):");
		((Control)lblLogin).set_AutoSize(true);
		((Control)lblLogin).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblLogin).set_Location(new Point(19, 47));
		((Control)lblLogin).set_Name("lblLogin");
		((Control)lblLogin).set_Size(new Size(42, 13));
		((Control)lblLogin).set_TabIndex(4);
		((Control)lblLogin).set_Text("Login:");
		((Control)tbPassword).set_Location(new Point(107, 70));
		((Control)tbPassword).set_Name("tbPassword");
		tbPassword.set_PasswordChar('*');
		((Control)tbPassword).set_Size(new Size(187, 20));
		((Control)tbPassword).set_TabIndex(3);
		((Control)tbLogin).set_Location(new Point(107, 44));
		((Control)tbLogin).set_Name("tbLogin");
		((Control)tbLogin).set_Size(new Size(187, 20));
		((Control)tbLogin).set_TabIndex(2);
		((Control)lblPassword).set_AutoSize(true);
		((Control)lblPassword).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblPassword).set_Location(new Point(19, 73));
		((Control)lblPassword).set_Name("lblPassword");
		((Control)lblPassword).set_Size(new Size(65, 13));
		((Control)lblPassword).set_TabIndex(7);
		((Control)lblPassword).set_Text("Password:");
		((Control)tbOutput).set_Anchor((AnchorStyles)15);
		((Control)tbOutput).set_Location(new Point(7, 422));
		((TextBoxBase)tbOutput).set_Multiline(true);
		((Control)tbOutput).set_Name("tbOutput");
		tbOutput.set_ScrollBars((ScrollBars)2);
		((Control)tbOutput).set_Size(new Size(599, 108));
		((Control)tbOutput).set_TabIndex(8);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(7, 403));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(49, 13));
		((Control)label2).set_TabIndex(9);
		((Control)label2).set_Text("Output:");
		((Control)tbX).set_Location(new Point(311, 22));
		((Control)tbX).set_Name("tbX");
		((Control)tbX).set_Size(new Size(86, 20));
		((Control)tbX).set_TabIndex(7);
		((Control)tbX).set_Text("0");
		((Control)tbX).add_KeyPress(new KeyPressEventHandler(tbDelay_KeyPress));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label3).set_Location(new Point(288, 25));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(19, 13));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("X:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label4).set_Location(new Point(288, 63));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(19, 13));
		((Control)label4).set_TabIndex(13);
		((Control)label4).set_Text("Y:");
		((Control)tbY).set_Location(new Point(311, 60));
		((Control)tbY).set_Name("tbY");
		((Control)tbY).set_Size(new Size(86, 20));
		((Control)tbY).set_TabIndex(8);
		((Control)tbY).set_Text("0");
		((Control)tbY).add_KeyPress(new KeyPressEventHandler(tbDelay_KeyPress));
		((Control)btnClearOutput).set_Anchor((AnchorStyles)9);
		((Control)btnClearOutput).set_Location(new Point(511, 398));
		((Control)btnClearOutput).set_Name("btnClearOutput");
		((Control)btnClearOutput).set_Size(new Size(95, 23));
		((Control)btnClearOutput).set_TabIndex(17);
		((Control)btnClearOutput).set_Text("Clear output");
		((ButtonBase)btnClearOutput).set_UseVisualStyleBackColor(true);
		((Control)btnClearOutput).add_Click((EventHandler)btnClearOutput_Click);
		((Control)btnSearch).set_Anchor((AnchorStyles)6);
		((Control)btnSearch).set_Location(new Point(22, 101));
		((Control)btnSearch).set_Name("btnSearch");
		((Control)btnSearch).set_Size(new Size(105, 23));
		((Control)btnSearch).set_TabIndex(9);
		((Control)btnSearch).set_Text("Search");
		((ButtonBase)btnSearch).set_UseVisualStyleBackColor(true);
		((Control)btnSearch).add_Click((EventHandler)btnSearch_Click);
		((Control)lblSearchRadius).set_AutoSize(true);
		((Control)lblSearchRadius).set_Location(new Point(19, 63));
		((Control)lblSearchRadius).set_Name("lblSearchRadius");
		((Control)lblSearchRadius).set_Size(new Size(87, 13));
		((Control)lblSearchRadius).set_TabIndex(16);
		((Control)lblSearchRadius).set_Text("Search distance:");
		((Control)groupBox1).set_Anchor((AnchorStyles)13);
		((Control)groupBox1).get_Controls().Add((Control)(object)btnLogout);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)tbServer);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblLogin);
		((Control)groupBox1).get_Controls().Add((Control)(object)tbPassword);
		((Control)groupBox1).get_Controls().Add((Control)(object)tbLogin);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblPassword);
		((Control)groupBox1).get_Controls().Add((Control)(object)btnLogin);
		((Control)groupBox1).set_Location(new Point(7, 0));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(410, 140));
		((Control)groupBox1).set_TabIndex(18);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Travian access");
		((Control)btnLogout).set_Location(new Point(133, 111));
		((Control)btnLogout).set_Name("btnLogout");
		((Control)btnLogout).set_Size(new Size(105, 23));
		((Control)btnLogout).set_TabIndex(8);
		((Control)btnLogout).set_Text("Logout");
		((ButtonBase)btnLogout).set_UseVisualStyleBackColor(true);
		((Control)btnLogout).add_Click((EventHandler)btnLogout_Click);
		((Control)groupBox2).set_Anchor((AnchorStyles)13);
		((Control)groupBox2).get_Controls().Add((Control)(object)tbDelay);
		((Control)groupBox2).get_Controls().Add((Control)(object)label5);
		((Control)groupBox2).get_Controls().Add((Control)(object)btnStop);
		((Control)groupBox2).get_Controls().Add((Control)(object)cbSearchRadius);
		((Control)groupBox2).get_Controls().Add((Control)(object)tbX);
		((Control)groupBox2).get_Controls().Add((Control)(object)label3);
		((Control)groupBox2).get_Controls().Add((Control)(object)tbY);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblSearchRadius);
		((Control)groupBox2).get_Controls().Add((Control)(object)label4);
		((Control)groupBox2).get_Controls().Add((Control)(object)btnSearch);
		((Control)groupBox2).set_Location(new Point(7, 146));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(410, 130));
		((Control)groupBox2).set_TabIndex(19);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Map parameters");
		((Control)tbDelay).set_Location(new Point(157, 23));
		((Control)tbDelay).set_Name("tbDelay");
		((Control)tbDelay).set_Size(new Size(81, 20));
		((Control)tbDelay).set_TabIndex(5);
		((Control)tbDelay).set_Text("0");
		((Control)tbDelay).add_KeyPress(new KeyPressEventHandler(tbDelay_KeyPress));
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(19, 25));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(132, 13));
		((Control)label5).set_TabIndex(20);
		((Control)label5).set_Text("Search delay (in seconds):");
		((Control)btnStop).set_Anchor((AnchorStyles)6);
		((Control)btnStop).set_Location(new Point(133, 101));
		((Control)btnStop).set_Name("btnStop");
		((Control)btnStop).set_Size(new Size(105, 23));
		((Control)btnStop).set_TabIndex(10);
		((Control)btnStop).set_Text("Stop");
		((ButtonBase)btnStop).set_UseVisualStyleBackColor(true);
		((Control)btnStop).add_Click((EventHandler)btnStop_Click);
		cbSearchRadius.get_AutoCompleteCustomSource().AddRange(new string[4] { "7x7", "21x21", "35x35", "49x49" });
		cbSearchRadius.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbSearchRadius).set_FormattingEnabled(true);
		((Control)cbSearchRadius).set_Location(new Point(157, 60));
		((Control)cbSearchRadius).set_Name("cbSearchRadius");
		((Control)cbSearchRadius).set_Size(new Size(81, 21));
		((Control)cbSearchRadius).set_TabIndex(6);
		((Control)btnViewResults).set_Anchor((AnchorStyles)9);
		((Control)btnViewResults).set_Enabled(false);
		((Control)btnViewResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnViewResults).set_Location(new Point(354, 398));
		((Control)btnViewResults).set_Name("btnViewResults");
		((Control)btnViewResults).set_Size(new Size(153, 23));
		((Control)btnViewResults).set_TabIndex(21);
		((Control)btnViewResults).set_Text("View Sorted Results");
		((ButtonBase)btnViewResults).set_UseVisualStyleBackColor(true);
		((Control)btnViewResults).add_Click((EventHandler)btnViewResults_Click);
		((Control)panel1).set_Anchor((AnchorStyles)9);
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).set_Location(new Point(423, 6));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(183, 134));
		((Control)panel1).set_TabIndex(20);
		((Control)label7).set_Anchor((AnchorStyles)9);
		((Control)label7).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(11, 30));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(167, 60));
		((Control)label7).set_TabIndex(1);
		((Control)label7).set_Text("Enter a Travian-server (http address) and  specify your login and password.");
		label7.set_TextAlign((ContentAlignment)16);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)label6).set_Location(new Point(69, 10));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(48, 15));
		((Control)label6).set_TabIndex(0);
		((Control)label6).set_Text("Step 1");
		((Control)panel2).set_Anchor((AnchorStyles)9);
		panel2.set_BorderStyle((BorderStyle)1);
		((Control)panel2).get_Controls().Add((Control)(object)label12);
		((Control)panel2).get_Controls().Add((Control)(object)label9);
		((Control)panel2).get_Controls().Add((Control)(object)label8);
		((Control)panel2).set_Location(new Point(423, 152));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(183, 124));
		((Control)panel2).set_TabIndex(21);
		((Control)label12).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_Location(new Point(9, 71));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(160, 45));
		((Control)label12).set_TabIndex(3);
		((Control)label12).set_Text("Select a search radius from the combobox and click Search.");
		((Control)label9).set_Anchor((AnchorStyles)9);
		((Control)label9).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_Location(new Point(9, 35));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(165, 34));
		((Control)label9).set_TabIndex(2);
		((Control)label9).set_Text("Enter map coordinates defining the center of the search area.");
		label9.set_TextAlign((ContentAlignment)16);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)label8).set_Location(new Point(69, 11));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(48, 15));
		((Control)label8).set_TabIndex(1);
		((Control)label8).set_Text("Step 2");
		((Control)groupBox3).set_Anchor((AnchorStyles)13);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbOase);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf6);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf5);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf4);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf3);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf2);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf1);
		((Control)groupBox3).set_Location(new Point(7, 282));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(410, 95));
		((Control)groupBox3).set_TabIndex(22);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Field filter");
		((Control)cbOase).set_AutoSize(true);
		((Control)cbOase).set_Location(new Point(322, 66));
		((Control)cbOase).set_Name("cbOase");
		((Control)cbOase).set_Size(new Size(52, 17));
		((Control)cbOase).set_TabIndex(17);
		((Control)cbOase).set_Text("Oasis");
		((ButtonBase)cbOase).set_UseVisualStyleBackColor(true);
		((Control)cbf6).set_AutoSize(true);
		cbf6.set_Checked(true);
		cbf6.set_CheckState((CheckState)1);
		((Control)cbf6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)cbf6).set_Location(new Point(190, 20));
		((Control)cbf6).set_Name("cbf6");
		((Control)cbf6).set_Size(new Size(160, 17));
		((Control)cbf6).set_TabIndex(12);
		((Control)cbf6).set_Text("1W 1C 1I 15C (15-crop)");
		((ButtonBase)cbf6).set_UseVisualStyleBackColor(true);
		((Control)cbf5).set_AutoSize(true);
		((Control)cbf5).set_Location(new Point(190, 66));
		((Control)cbf5).set_Name("cbf5");
		((Control)cbf5).set_Size(new Size(87, 17));
		((Control)cbf5).set_TabIndex(16);
		((Control)cbf5).set_Text("5W 3C 4I 6C");
		((ButtonBase)cbf5).set_UseVisualStyleBackColor(true);
		((Control)cbf4).set_AutoSize(true);
		((Control)cbf4).set_Location(new Point(190, 43));
		((Control)cbf4).set_Name("cbf4");
		((Control)cbf4).set_Size(new Size(87, 17));
		((Control)cbf4).set_TabIndex(14);
		((Control)cbf4).set_Text("4W 5C 3I 6C");
		((ButtonBase)cbf4).set_UseVisualStyleBackColor(true);
		((Control)cbf3).set_AutoSize(true);
		((Control)cbf3).set_Location(new Point(22, 66));
		((Control)cbf3).set_Name("cbf3");
		((Control)cbf3).set_Size(new Size(87, 17));
		((Control)cbf3).set_TabIndex(15);
		((Control)cbf3).set_Text("4W 4C 4I 6C");
		((ButtonBase)cbf3).set_UseVisualStyleBackColor(true);
		((Control)cbf2).set_AutoSize(true);
		((Control)cbf2).set_Location(new Point(22, 43));
		((Control)cbf2).set_Name("cbf2");
		((Control)cbf2).set_Size(new Size(87, 17));
		((Control)cbf2).set_TabIndex(13);
		((Control)cbf2).set_Text("3W 4C 5I 6C");
		((ButtonBase)cbf2).set_UseVisualStyleBackColor(true);
		((Control)cbf1).set_AutoSize(true);
		cbf1.set_Checked(true);
		cbf1.set_CheckState((CheckState)1);
		((Control)cbf1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)cbf1).set_Location(new Point(22, 20));
		((Control)cbf1).set_Name("cbf1");
		((Control)cbf1).set_Size(new Size(146, 17));
		((Control)cbf1).set_TabIndex(11);
		((Control)cbf1).set_Text("3W 3C 3I 9C (9-crop)");
		((ButtonBase)cbf1).set_UseVisualStyleBackColor(true);
		((Control)panel3).set_Anchor((AnchorStyles)9);
		panel3.set_BorderStyle((BorderStyle)1);
		((Control)panel3).get_Controls().Add((Control)(object)label10);
		((Control)panel3).get_Controls().Add((Control)(object)label11);
		((Control)panel3).set_Location(new Point(423, 289));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(183, 88));
		((Control)panel3).set_TabIndex(22);
		((Control)label10).set_Anchor((AnchorStyles)9);
		((Control)label10).set_Font(new Font("Verdana", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_Location(new Point(13, 37));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(156, 33));
		((Control)label10).set_TabIndex(2);
		((Control)label10).set_Text("Specify the type of fields to search for.");
		label10.set_TextAlign((ContentAlignment)16);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)label11).set_Location(new Point(44, 11));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(94, 15));
		((Control)label11).set_TabIndex(1);
		((Control)label11).set_Text("Optional Step");
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)toolsToolStripMenuItem,
			(ToolStripItem)helpToolStripMenuItem
		});
		((Control)menuStrip1).set_Location(new Point(0, 0));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Size(new Size(642, 24));
		((Control)menuStrip1).set_TabIndex(23);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)exitToolStripMenuItem });
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(35, 20));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(103, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ToolStripDropDownItem)toolsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)optionsToolStripMenuItem });
		((ToolStripItem)toolsToolStripMenuItem).set_Name("toolsToolStripMenuItem");
		((ToolStripItem)toolsToolStripMenuItem).set_Size(new Size(44, 20));
		((ToolStripItem)toolsToolStripMenuItem).set_Text("Tools");
		((ToolStripItem)optionsToolStripMenuItem).set_Name("optionsToolStripMenuItem");
		((ToolStripItem)optionsToolStripMenuItem).set_Size(new Size(136, 22));
		((ToolStripItem)optionsToolStripMenuItem).set_Text("Settings...");
		((ToolStripItem)optionsToolStripMenuItem).add_Click((EventHandler)optionsToolStripMenuItem_Click);
		((ToolStripDropDownItem)helpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)aboutToolStripMenuItem });
		((ToolStripItem)helpToolStripMenuItem).set_Name("helpToolStripMenuItem");
		((ToolStripItem)helpToolStripMenuItem).set_Size(new Size(40, 20));
		((ToolStripItem)helpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(196, 22));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About CS Cropfinder...");
		((ToolStripItem)aboutToolStripMenuItem).add_Click((EventHandler)aboutToolStripMenuItem_Click);
		((Control)lblSearching).set_Anchor((AnchorStyles)1);
		((Control)lblSearching).set_AutoSize(true);
		((Control)lblSearching).set_Font(new Font("Arial Black", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblSearching).set_ForeColor(Color.Green);
		((Control)lblSearching).set_Location(new Point(114, 401));
		((Control)lblSearching).set_Name("lblSearching");
		((Control)lblSearching).set_Size(new Size(209, 18));
		((Control)lblSearching).set_TabIndex(24);
		((Control)lblSearching).set_Text("Searching, please wait...");
		((Control)lblSearching).set_Visible(false);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)tsProgressBar,
			(ToolStripItem)tsStatusLabel
		});
		((Control)statusStrip1).set_Location(new Point(0, 592));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(642, 22));
		((Control)statusStrip1).set_TabIndex(25);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)tsProgressBar).set_Name("tsProgressBar");
		((ToolStripItem)tsProgressBar).set_Size(new Size(200, 16));
		((ToolStripItem)tsStatusLabel).set_AutoSize(false);
		tsStatusLabel.set_BorderSides((ToolStripStatusLabelBorderSides)15);
		tsStatusLabel.set_BorderStyle((Border3DStyle)2);
		((ToolStripItem)tsStatusLabel).set_ImageAlign((ContentAlignment)16);
		((ToolStripItem)tsStatusLabel).set_Name("tsStatusLabel");
		((ToolStripItem)tsStatusLabel).set_Size(new Size(150, 17));
		((Control)tabControlMain).set_Anchor((AnchorStyles)15);
		((Control)tabControlMain).get_Controls().Add((Control)(object)tabPageCropFinder);
		((Control)tabControlMain).get_Controls().Add((Control)(object)tabPageCombat);
		((Control)tabControlMain).set_Location(new Point(12, 27));
		tabControlMain.set_Multiline(true);
		((Control)tabControlMain).set_Name("tabControlMain");
		tabControlMain.set_SelectedIndex(0);
		((Control)tabControlMain).set_Size(new Size(620, 562));
		((Control)tabControlMain).set_TabIndex(26);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)panel1);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)tbOutput);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)btnViewResults);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)label2);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)lblSearching);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)btnClearOutput);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)panel3);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)groupBox1);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)groupBox3);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)groupBox2);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)panel2);
		tabPageCropFinder.set_Location(new Point(4, 22));
		((Control)tabPageCropFinder).set_Name("tabPageCropFinder");
		((Control)tabPageCropFinder).set_Padding(new Padding(3));
		((Control)tabPageCropFinder).set_Size(new Size(612, 536));
		tabPageCropFinder.set_TabIndex(0);
		((Control)tabPageCropFinder).set_Text("Crop finder");
		tabPageCropFinder.set_UseVisualStyleBackColor(true);
		((Control)tabPageCombat).get_Controls().Add((Control)(object)groupBox4);
		tabPageCombat.set_Location(new Point(4, 22));
		((Control)tabPageCombat).set_Name("tabPageCombat");
		((Control)tabPageCombat).set_Padding(new Padding(3));
		((Control)tabPageCombat).set_Size(new Size(612, 536));
		tabPageCombat.set_TabIndex(1);
		((Control)tabPageCombat).set_Text("Combat auxiliary");
		tabPageCombat.set_UseVisualStyleBackColor(true);
		((Control)groupBox4).set_Anchor((AnchorStyles)13);
		((Control)groupBox4).get_Controls().Add((Control)(object)panel4);
		((Control)groupBox4).get_Controls().Add((Control)(object)tbTroopTravelTime);
		((Control)groupBox4).get_Controls().Add((Control)(object)btnClearCombatTimes);
		((Control)groupBox4).get_Controls().Add((Control)(object)tbTimeStampList);
		((Control)groupBox4).get_Controls().Add((Control)(object)pnlTimeStamp);
		((Control)groupBox4).get_Controls().Add((Control)(object)btnCalculatorGenerate);
		((Control)groupBox4).get_Controls().Add((Control)(object)label14);
		((Control)groupBox4).get_Controls().Add((Control)(object)label13);
		((Control)groupBox4).get_Controls().Add((Control)(object)tbTimeOfAttack);
		((Control)groupBox4).set_Location(new Point(6, 6));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(600, 386));
		((Control)groupBox4).set_TabIndex(1);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("Attack-time calculator");
		((Control)panel4).set_Anchor((AnchorStyles)13);
		panel4.set_BorderStyle((BorderStyle)1);
		((Control)panel4).get_Controls().Add((Control)(object)lblCombatCalculatorText);
		((Control)panel4).set_Location(new Point(15, 19));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(573, 109));
		((Control)panel4).set_TabIndex(12);
		((Control)lblCombatCalculatorText).set_Anchor((AnchorStyles)15);
		((Control)lblCombatCalculatorText).set_Font(new Font("Verdana", 7f));
		((Control)lblCombatCalculatorText).set_Location(new Point(10, 10));
		((Control)lblCombatCalculatorText).set_Name("lblCombatCalculatorText");
		((Control)lblCombatCalculatorText).set_Size(new Size(552, 88));
		((Control)lblCombatCalculatorText).set_TabIndex(0);
		((Control)tbTroopTravelTime).set_Location(new Point(114, 174));
		tbTroopTravelTime.set_Mask("00:00:00");
		((Control)tbTroopTravelTime).set_Name("tbTroopTravelTime");
		((Control)tbTroopTravelTime).set_Size(new Size(200, 20));
		((Control)tbTroopTravelTime).set_TabIndex(11);
		tbTroopTravelTime.add_MaskInputRejected(new MaskInputRejectedEventHandler(tbTroopTravelTime_MaskInputRejected));
		((Control)btnClearCombatTimes).set_Anchor((AnchorStyles)9);
		((Control)btnClearCombatTimes).set_Location(new Point(464, 351));
		((Control)btnClearCombatTimes).set_Name("btnClearCombatTimes");
		((Control)btnClearCombatTimes).set_Size(new Size(124, 23));
		((Control)btnClearCombatTimes).set_TabIndex(10);
		((Control)btnClearCombatTimes).set_Text("Clear timestamp list");
		((ButtonBase)btnClearCombatTimes).set_UseVisualStyleBackColor(true);
		((Control)btnClearCombatTimes).add_Click((EventHandler)btnClearCombatTimes_Click);
		((Control)tbTimeStampList).set_Anchor((AnchorStyles)15);
		((Control)tbTimeStampList).set_Location(new Point(322, 134));
		((TextBoxBase)tbTimeStampList).set_Multiline(true);
		((Control)tbTimeStampList).set_Name("tbTimeStampList");
		tbTimeStampList.set_ScrollBars((ScrollBars)2);
		((Control)tbTimeStampList).set_Size(new Size(266, 211));
		((Control)tbTimeStampList).set_TabIndex(9);
		pnlTimeStamp.set_BorderStyle((BorderStyle)1);
		((Control)pnlTimeStamp).get_Controls().Add((Control)(object)btnCalculatorSaveTimeStamp);
		((Control)pnlTimeStamp).get_Controls().Add((Control)(object)label16);
		((Control)pnlTimeStamp).get_Controls().Add((Control)(object)tbTimeStampName);
		((Control)pnlTimeStamp).get_Controls().Add((Control)(object)lblSendDate);
		((Control)pnlTimeStamp).get_Controls().Add((Control)(object)label15);
		((Control)pnlTimeStamp).set_Location(new Point(15, 240));
		((Control)pnlTimeStamp).set_Name("pnlTimeStamp");
		((Control)pnlTimeStamp).set_Size(new Size(299, 135));
		((Control)pnlTimeStamp).set_TabIndex(5);
		((Control)pnlTimeStamp).set_Visible(false);
		((Control)btnCalculatorSaveTimeStamp).set_Location(new Point(15, 104));
		((Control)btnCalculatorSaveTimeStamp).set_Name("btnCalculatorSaveTimeStamp");
		((Control)btnCalculatorSaveTimeStamp).set_Size(new Size(104, 23));
		((Control)btnCalculatorSaveTimeStamp).set_TabIndex(4);
		((Control)btnCalculatorSaveTimeStamp).set_Text("Cache timestamp");
		((ButtonBase)btnCalculatorSaveTimeStamp).set_UseVisualStyleBackColor(true);
		((Control)btnCalculatorSaveTimeStamp).add_Click((EventHandler)btnCalculatorSaveTimeStamp_Click);
		((Control)label16).set_Location(new Point(12, 70));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(104, 23));
		((Control)label16).set_TabIndex(3);
		((Control)label16).set_Text("Timestamp name:");
		label16.set_TextAlign((ContentAlignment)16);
		((Control)tbTimeStampName).set_Location(new Point(122, 73));
		((Control)tbTimeStampName).set_Name("tbTimeStampName");
		((Control)tbTimeStampName).set_Size(new Size(161, 20));
		((Control)tbTimeStampName).set_TabIndex(2);
		((Control)lblSendDate).set_Anchor((AnchorStyles)13);
		((Control)lblSendDate).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblSendDate).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)lblSendDate).set_Location(new Point(12, 34));
		((Control)lblSendDate).set_Name("lblSendDate");
		((Control)lblSendDate).set_Size(new Size(272, 23));
		((Control)lblSendDate).set_TabIndex(1);
		lblSendDate.set_TextAlign((ContentAlignment)16);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_Location(new Point(12, 10));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(107, 13));
		((Control)label15).set_TabIndex(0);
		((Control)label15).set_Text("Send your troops:");
		((Control)btnCalculatorGenerate).set_Location(new Point(15, 207));
		((Control)btnCalculatorGenerate).set_Name("btnCalculatorGenerate");
		((Control)btnCalculatorGenerate).set_Size(new Size(98, 23));
		((Control)btnCalculatorGenerate).set_TabIndex(4);
		((Control)btnCalculatorGenerate).set_Text("Generate");
		((ButtonBase)btnCalculatorGenerate).set_UseVisualStyleBackColor(true);
		((Control)btnCalculatorGenerate).add_Click((EventHandler)btnCalculatorGenerate_Click);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(12, 174));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(89, 13));
		((Control)label14).set_TabIndex(3);
		((Control)label14).set_Text("Troop travel time:");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Location(new Point(12, 137));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(78, 13));
		((Control)label13).set_TabIndex(1);
		((Control)label13).set_Text("Time of attack:");
		tbTimeOfAttack.set_CustomFormat("HH:mm:ss - dd.MM.yyyy");
		tbTimeOfAttack.set_Format((DateTimePickerFormat)8);
		((Control)tbTimeOfAttack).set_Location(new Point(114, 134));
		((Control)tbTimeOfAttack).set_Name("tbTimeOfAttack");
		((Control)tbTimeOfAttack).set_Size(new Size(200, 20));
		((Control)tbTimeOfAttack).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(642, 614));
		((Control)this).get_Controls().Add((Control)(object)tabControlMain);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Control)this).set_MinimumSize(new Size(650, 600));
		((Control)this).set_Name("CropFinder");
		((Form)this).set_SizeGripStyle((SizeGripStyle)1);
		((Control)this).set_Text("Travian Cropfinder (CS - production) Version 1.0");
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)tabControlMain).ResumeLayout(false);
		((Control)tabPageCropFinder).ResumeLayout(false);
		((Control)tabPageCropFinder).PerformLayout();
		((Control)tabPageCombat).ResumeLayout(false);
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)pnlTimeStamp).ResumeLayout(false);
		((Control)pnlTimeStamp).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
