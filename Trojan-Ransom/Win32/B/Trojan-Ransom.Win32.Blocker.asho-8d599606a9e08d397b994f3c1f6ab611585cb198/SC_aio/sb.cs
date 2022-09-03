using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class sb : Form
{
	private IContainer components;

	[AccessedThroughProperty("content")]
	private ListBox _content;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("shoutbox")]
	private TextBox _shoutbox;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("message")]
	private TextBox _message;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("spamletters")]
	private CheckBox _spamletters;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("spamprofanity")]
	private CheckBox _spamprofanity;

	[AccessedThroughProperty("randomuser")]
	private CheckBox _randomuser;

	private List<string> users;

	internal virtual ListBox content
	{
		get
		{
			return _content;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(content_KeyPress);
			if (_content != null)
			{
				((Control)_content).remove_KeyPress(val);
			}
			_content = value;
			if (_content != null)
			{
				((Control)_content).add_KeyPress(val);
			}
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

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox shoutbox
	{
		get
		{
			return _shoutbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_shoutbox = value;
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

	internal virtual TextBox message
	{
		get
		{
			return _message;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_message = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual CheckBox spamletters
	{
		get
		{
			return _spamletters;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_spamletters = value;
		}
	}

	internal virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBox spamprofanity
	{
		get
		{
			return _spamprofanity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_spamprofanity = value;
		}
	}

	internal virtual CheckBox randomuser
	{
		get
		{
			return _randomuser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_randomuser = value;
		}
	}

	public sb()
	{
		((Form)this).add_Load((EventHandler)sb_Load);
		users = new List<string>();
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
		content = new ListBox();
		Button1 = new Button();
		Button2 = new Button();
		shoutbox = new TextBox();
		Label1 = new Label();
		message = new TextBox();
		Label2 = new Label();
		spamletters = new CheckBox();
		Button3 = new Button();
		spamprofanity = new CheckBox();
		randomuser = new CheckBox();
		((Control)this).SuspendLayout();
		((ListControl)content).set_FormattingEnabled(true);
		ListBox obj = content;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)content).set_Name("content");
		content.set_SelectionMode((SelectionMode)3);
		ListBox obj2 = content;
		Size size = new Size(295, 277);
		((Control)obj2).set_Size(size);
		((Control)content).set_TabIndex(0);
		Button button = Button1;
		location = new Point(12, 403);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(209, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Get Posts");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(227, 403);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(80, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Get Users");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		TextBox obj3 = shoutbox;
		location = new Point(72, 299);
		((Control)obj3).set_Location(location);
		((Control)shoutbox).set_Name("shoutbox");
		TextBox obj4 = shoutbox;
		size = new Size(235, 20);
		((Control)obj4).set_Size(size);
		((Control)shoutbox).set_TabIndex(3);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(13, 302);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(53, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("shoutbox:");
		TextBox obj5 = message;
		location = new Point(72, 325);
		((Control)obj5).set_Location(location);
		((Control)message).set_Name("message");
		TextBox obj6 = message;
		size = new Size(235, 20);
		((Control)obj6).set_Size(size);
		((Control)message).set_TabIndex(5);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(12, 328);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(50, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(6);
		Label2.set_Text("Message");
		((ButtonBase)spamletters).set_AutoSize(true);
		CheckBox obj7 = spamletters;
		location = new Point(12, 351);
		((Control)obj7).set_Location(location);
		((Control)spamletters).set_Name("spamletters");
		CheckBox obj8 = spamletters;
		size = new Size(88, 17);
		((Control)obj8).set_Size(size);
		((Control)spamletters).set_TabIndex(7);
		((ButtonBase)spamletters).set_Text("Spam Letters");
		((ButtonBase)spamletters).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(12, 374);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(295, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(8);
		((ButtonBase)Button3).set_Text("Post");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)spamprofanity).set_AutoSize(true);
		CheckBox obj9 = spamprofanity;
		location = new Point(210, 351);
		((Control)obj9).set_Location(location);
		((Control)spamprofanity).set_Name("spamprofanity");
		CheckBox obj10 = spamprofanity;
		size = new Size(97, 17);
		((Control)obj10).set_Size(size);
		((Control)spamprofanity).set_TabIndex(9);
		((ButtonBase)spamprofanity).set_Text("Spam Profanity");
		((ButtonBase)spamprofanity).set_UseVisualStyleBackColor(true);
		((ButtonBase)randomuser).set_AutoSize(true);
		CheckBox obj11 = randomuser;
		location = new Point(104, 351);
		((Control)obj11).set_Location(location);
		((Control)randomuser).set_Name("randomuser");
		CheckBox obj12 = randomuser;
		size = new Size(100, 17);
		((Control)obj12).set_Size(size);
		((Control)randomuser).set_TabIndex(10);
		((ButtonBase)randomuser).set_Text("Random @user");
		((ButtonBase)randomuser).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(319, 433);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)randomuser);
		((Control)this).get_Controls().Add((Control)(object)spamprofanity);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)spamletters);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)message);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)shoutbox);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)content);
		((Control)this).set_Name("sb");
		((Form)this).set_Text("ShiftCode - Shoutbox Controller");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		content.get_Items().Clear();
		string text = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/shout/shout_mod.html", ""));
		string text2 = text;
		checked
		{
			while (text2.Contains("<b>"))
			{
				text2 = text2.Remove(0, text2.IndexOf("<b>") + 3);
				string[] array = text2.Split(new char[1] { '<' });
				string text3 = array[0];
				text2 = text2.Remove(0, text2.IndexOf("</a>") + 4);
				array = text2.Split(new char[1] { '<' });
				string text4 = array[0];
				content.get_Items().Add((object)(text3 + text4));
			}
		}
	}

	private void getusers()
	{
		users = new List<string>();
		string text = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/shout/shout_mod.html", ""));
		string text2 = text;
		checked
		{
			while (text2.Contains("<b>"))
			{
				text2 = text2.Remove(0, text2.IndexOf("<b>") + 3);
				string[] array = text2.Split(new char[1] { ':' });
				string item = array[0];
				text2 = text2.Remove(0, text2.IndexOf("</a>") + 4);
				array = text2.Split(new char[1] { '<' });
				if (!users.Contains(item))
				{
					users.Add(item);
				}
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		content.get_Items().Clear();
		getusers();
		if (users.Count > 0)
		{
			foreach (string user in users)
			{
				content.get_Items().Add((object)user);
			}
			return;
		}
		Interaction.MsgBox((object)"There were no users found!", (MsgBoxStyle)0, (object)null);
	}

	private void content_KeyPress(object sender, KeyPressEventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (e.get_KeyChar() != '\r')
		{
			return;
		}
		string text = "";
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = content.get_SelectedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text2 = Conversions.ToString(enumerator.Current);
				text = text + text2 + "\r\n";
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Computer)MyProject.Computer).get_Clipboard().SetText(text);
		Interaction.MsgBox((object)"Selected items copied to clipboard!", (MsgBoxStyle)0, (object)null);
	}

	private void sb_Load(object sender, EventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		if (randomuser.get_Checked())
		{
			getusers();
		}
		checked
		{
			if (spamletters.get_Checked())
			{
				for (int num = 10; num != 0; num--)
				{
					text = ((!randomuser.get_Checked()) ? Conversions.ToString(MyProject.Forms.aio.randLetters(255, 255)) : Conversions.ToString(Operators.AddObject((object)string.Concat("@" + users[MyProject.Forms.aio.rand.Next(users.Count - 1)], " - "), MyProject.Forms.aio.randLetters(240, 250))));
					MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/shout/post.php?session=" + shoutbox.get_Text() + "&name=name&msg=" + text + "&nocache=1338411754874", "");
				}
			}
			else if (spamprofanity.get_Checked())
			{
				for (int num2 = 10; num2 != 0; num2--)
				{
					text = ((!randomuser.get_Checked()) ? "" : ("@" + users[MyProject.Forms.aio.rand.Next(users.Count - 1)] + " - "));
					while (text.Length < 245)
					{
						string text2 = MyProject.Forms.aio.randSelect(MyProject.Forms.aio.profanity);
						string text3 = text2 + " ";
						text += text3;
					}
					MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/shout/post.php?session=" + shoutbox.get_Text() + "&name=name&msg=" + text + "&nocache=1338411754874", "");
				}
			}
			else
			{
				if (randomuser.get_Checked())
				{
					text = "@" + users[MyProject.Forms.aio.rand.Next(users.Count - 1)] + ": ";
				}
				string text4 = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/shout/post.php?session=" + shoutbox.get_Text() + "&name=name&msg=" + text + message.get_Text() + "&nocache=1338411754874", ""));
				if (Operators.CompareString(text4, "", false) != 0)
				{
					Interaction.MsgBox((object)text4, (MsgBoxStyle)0, (object)null);
				}
			}
		}
	}
}
