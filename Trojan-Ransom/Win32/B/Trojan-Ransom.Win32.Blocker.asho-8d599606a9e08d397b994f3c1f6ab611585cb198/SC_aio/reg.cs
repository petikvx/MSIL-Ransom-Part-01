using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class reg : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("refu")]
	private TextBox _refu;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("profanity")]
	private CheckBox _profanity;

	[AccessedThroughProperty("spoof")]
	private CheckBox _spoof;

	[AccessedThroughProperty("randomemail")]
	private CheckBox _randomemail;

	private Random rand;

	private string status;

	private int done;

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual TextBox refu
	{
		get
		{
			return _refu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_refu = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual CheckBox profanity
	{
		get
		{
			return _profanity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_profanity = value;
		}
	}

	internal virtual CheckBox spoof
	{
		get
		{
			return _spoof;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_spoof = value;
		}
	}

	internal virtual CheckBox randomemail
	{
		get
		{
			return _randomemail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_randomemail = value;
		}
	}

	public reg()
	{
		rand = new Random();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		Button1 = new Button();
		Label1 = new Label();
		refu = new TextBox();
		Timer1 = new Timer(components);
		profanity = new CheckBox();
		spoof = new CheckBox();
		randomemail = new CheckBox();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(12, 12);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(281, 69);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		Button button = Button1;
		location = new Point(12, 134);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(281, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Register");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(12, 91);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(96, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Referral username:");
		TextBox obj = refu;
		location = new Point(114, 88);
		((Control)obj).set_Location(location);
		((Control)refu).set_Name("refu");
		TextBox obj2 = refu;
		size = new Size(179, 20);
		((Control)obj2).set_Size(size);
		((Control)refu).set_TabIndex(3);
		((ButtonBase)profanity).set_AutoSize(true);
		CheckBox obj3 = profanity;
		location = new Point(15, 111);
		((Control)obj3).set_Location(location);
		((Control)profanity).set_Name("profanity");
		CheckBox obj4 = profanity;
		size = new Size(70, 17);
		((Control)obj4).set_Size(size);
		((Control)profanity).set_TabIndex(5);
		((ButtonBase)profanity).set_Text("Profanity ");
		((ButtonBase)profanity).set_UseVisualStyleBackColor(true);
		((ButtonBase)spoof).set_AutoSize(true);
		CheckBox obj5 = spoof;
		location = new Point(226, 111);
		((Control)obj5).set_Location(location);
		((Control)spoof).set_Name("spoof");
		CheckBox obj6 = spoof;
		size = new Size(67, 17);
		((Control)obj6).set_Size(size);
		((Control)spoof).set_TabIndex(6);
		((ButtonBase)spoof).set_Text("Spoof IP");
		((ButtonBase)spoof).set_UseVisualStyleBackColor(true);
		((ButtonBase)randomemail).set_AutoSize(true);
		CheckBox obj7 = randomemail;
		location = new Point(106, 111);
		((Control)obj7).set_Location(location);
		((Control)randomemail).set_Name("randomemail");
		CheckBox obj8 = randomemail;
		size = new Size(94, 17);
		((Control)obj8).set_Size(size);
		((Control)randomemail).set_TabIndex(7);
		((ButtonBase)randomemail).set_Text("Random Email");
		((ButtonBase)randomemail).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(305, 161);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)randomemail);
		((Control)this).get_Controls().Add((Control)(object)spoof);
		((Control)this).get_Controls().Add((Control)(object)profanity);
		((Control)this).get_Controls().Add((Control)(object)refu);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_Name("reg");
		((Form)this).set_Text("ShiftCode - Registration");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public string register(string dom, string @ref)
	{
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		if (spoof.get_Checked())
		{
			MyProject.Forms.aio.spoofip();
		}
		else
		{
			MyProject.Forms.aio.sip = "";
		}
		if (MyProject.Forms.aio.scmembert.get_Text().Length >= 1)
		{
			MyProject.Forms.aio.scmembert.set_Text("");
			MyProject.Forms.aio.Button1.PerformClick();
		}
		checked
		{
			try
			{
				string text2 = (Versioned.IsNumeric((object)@ref) ? ("?refid=" + @ref) : ((@ref.Length < 4) ? "" : ("?ref=" + @ref)));
				string text3 = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + dom + "/members/register.php" + text2, ""));
				string text4 = "next=1&path=&remember=1&terms=1&mailinglist=0";
				string text5 = "";
				string text6 = text3;
				string text7 = "graynearme";
				string text8 = "";
				int length = text7.Length;
				string text9 = "";
				int num = 2 + rand.Next(5);
				if (randomemail.get_Checked())
				{
					while (num > 0)
					{
						text8 = ((rand.Next(2) != 1) ? (text8 + MyProject.Forms.aio.randSelect(MyProject.Forms.aio.words)) : (text8 + MyProject.Forms.aio.rand.Next(9)));
						num--;
					}
					text8 = text8 + "@" + MyProject.Forms.aio.randSelect(MyProject.Forms.aio.emaildomains);
					text8 = text8.ToLower();
				}
				else
				{
					int i = default(int);
					for (; i != length; i++)
					{
						text8 += text7.Substring(i, 1);
						if (rand.Next(0, 2) == 1)
						{
							text8 += ".";
						}
					}
					text8 = ((rand.Next(0, 2) != 1) ? (text8 + "@googlemail.com") : (text8 + "@gmail.com"));
				}
				string text10 = "none";
				while (text6.Contains("<input"))
				{
					text6 = text6.Remove(0, text6.IndexOf("<input"));
					text6 = text6.Remove(0, text6.IndexOf("name=") + 6);
					string[] array = text6.Split(new char[1] { '"' });
					string text11 = array[0];
					if ((Operators.CompareString(text11, "password", false) == 0) | (Operators.CompareString(text11, "password2", false) == 0))
					{
						text9 = "leet123";
						text5 = text9;
					}
					else if (Operators.CompareString(text11, "first", false) == 0)
					{
						text5 = MyProject.Forms.aio.randSelect(MyProject.Forms.aio.firstnames);
					}
					else if (Operators.CompareString(text11, "last", false) == 0)
					{
						text5 = MyProject.Forms.aio.randSelect(MyProject.Forms.aio.lastnames);
					}
					else if ((Operators.CompareString(text11, "email", false) == 0) | (Operators.CompareString(text11, "email2", false) == 0))
					{
						text5 = text8;
					}
					else
					{
						switch (text11)
						{
						case "username":
							if (profanity.get_Checked())
							{
								text = MyProject.Forms.aio.randSelect(MyProject.Forms.aio.profanity);
							}
							else
							{
								text = MyProject.Forms.aio.randSelect(MyProject.Forms.aio.words);
								if ((text.Length < 4) | (MyProject.Forms.aio.rand.Next(1, 5) == 1))
								{
									text += rand.Next(1, 9999);
								}
								else if (MyProject.Forms.aio.rand.Next(1, 3) == 1)
								{
									text += rand.Next(1, 99);
								}
							}
							text5 = text;
							break;
						case "billingAddress1":
							text5 = rand.Next(1, 50) + " " + MyProject.Forms.aio.randSelect(MyProject.Forms.aio.addresses) + " " + MyProject.Forms.aio.randSelect(MyProject.Forms.aio.roads);
							break;
						case "billingAddress2":
							text5 = "";
							break;
						case "billingState":
							text5 = (1 + MyProject.Forms.aio.rand.Next(62)).ToString();
							break;
						case "billingZip":
							text5 = (10000 + MyProject.Forms.aio.rand.Next(32999)).ToString();
							break;
						case "billingCity":
							text5 = MyProject.Forms.aio.randSelect(MyProject.Forms.aio.cities);
							break;
						case "secID":
						{
							text5 = text6.Remove(0, text6.IndexOf("value=") + 7);
							string[] array2 = text5.Split(new char[1] { '"' });
							text5 = array2[0];
							text10 = text5;
							break;
						}
						case "secCode":
							text5 = "captchahere";
							break;
						case "ref":
							text5 = ((@ref.Length < 4) ? "" : @ref);
							break;
						default:
							text5 = Conversions.ToString(MyProject.Forms.aio.randLetters(4, 12));
							break;
						}
					}
					if (!text4.Contains(text11))
					{
						text4 = text4 + "&" + text11 + "=" + text5;
					}
				}
				text6 = text3;
				while (text6.Contains("<select"))
				{
					text6 = text6.Remove(0, text6.IndexOf("<select"));
					text6 = text6.Remove(0, text6.IndexOf("name=") + 6);
					string[] array = text6.Split(new char[1] { '"' });
					string text11 = array[0];
					if (text11.Contains("Month"))
					{
						text5 = Conversions.ToString(MyProject.Forms.aio.rand.Next(1, 12));
					}
					else if (text11.Contains("Day"))
					{
						text5 = Conversions.ToString(MyProject.Forms.aio.rand.Next(1, 28));
					}
					else if (text11.Contains("Year"))
					{
						text5 = Conversions.ToString(MyProject.Forms.aio.rand.Next(1935, 1992));
					}
					else if (Operators.CompareString(text11, "billingState", false) != 0)
					{
						text5 = Conversions.ToString(MyProject.Forms.aio.randLetters(4, 12));
					}
					if (!text4.Contains(text11))
					{
						text4 = text4 + "&" + text11 + "=" + text5;
					}
				}
				text6 = text3;
				while (text6.Contains("<textarea"))
				{
					text6 = text6.Remove(0, text6.IndexOf("<textarea"));
					text6 = text6.Remove(0, text6.IndexOf("name=") + 6);
					string[] array = text6.Split(new char[1] { '"' });
					string text11 = array[0];
					if (!text11.Contains("nothing"))
					{
						text5 = Conversions.ToString(MyProject.Forms.aio.randLetters(4, 12));
					}
					if (!text4.Contains(text11))
					{
						text4 = text4 + "&" + text11 + "=" + text5;
					}
				}
				if (Operators.CompareString(text10, "none", false) != 0)
				{
					text4 = text4.Replace("captchahere", Conversions.ToString(MyProject.Forms.captcha.solve("http://" + dom + "/security/image.php?id=" + text10)));
				}
				string text12 = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + dom + "/members/register.php" + text2, text4));
				if (text12.Contains("<th>Error"))
				{
					text12 = text12.Remove(0, text12.IndexOf("<th>Error"));
					text12 = text12.Remove(0, text12.IndexOf("<li>") + 4);
					string[] array = text12.Split(new char[1] { '<' });
					return "Error: " + array[0];
				}
				if (text12.Contains("Confirm"))
				{
					text12 = text12.Remove(0, text12.IndexOf("&mid=") + 5);
					string[] array = text12.Split(new char[1] { '"' });
					string text13 = array[0];
					string text14 = "fail";
					int num2 = 25;
					while (Operators.CompareString(text14, "fail", false) == 0)
					{
						text14 = Conversions.ToString(MyProject.Forms.aio.sendPost("http://incent.tv/email.php?email=" + text8, ""));
						Thread.Sleep(1000);
						num2--;
						if (num2 == 0)
						{
							return "Error: Unable to confirm email.";
						}
					}
					text12 = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + dom + "/members/welcome.php?confirm&mid=" + text13, "code=" + text14 + "&do=Confirm"));
				}
				if (MyProject.Forms.aio.scmembert.get_Text().Length == 0)
				{
					MyProject.Forms.aio.scmembert.set_Text(text + "%3A12f2011d1a78cb2376c55f573362fb2b");
					MyProject.Forms.aio.Button1.PerformClick();
				}
				if (MyProject.Forms.aio.autocontrolled)
				{
					int num3 = 5;
					while (!MyProject.Forms.aio.signuptosite(text) && num3 != 0)
					{
						num3--;
					}
				}
				return "Successfully signed up as " + text + ".";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (MyProject.Forms.aio.autocontrolled)
				{
					string result = ex2.ToString();
					ProjectData.ClearProjectError();
					return result;
				}
				Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			return "Fail";
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		ListBox1.get_Items().Add((object)register(MyProject.Forms.aio.domain, refu.get_Text()));
		ListBox1.set_SelectedIndex(checked(ListBox1.get_Items().get_Count() - 1));
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(status, "", false) != 0)
		{
			ListBox1.get_Items().Add((object)status);
			ListBox1.set_SelectedItem((object)checked(ListBox1.get_Items().get_Count() - 1));
			status = "";
		}
	}
}
