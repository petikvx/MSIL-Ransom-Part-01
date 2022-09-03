using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class co : Form
{
	private IContainer components;

	[AccessedThroughProperty("offerbox")]
	private ListBox _offerbox;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	public Array offers;

	private string offid;

	internal virtual ListBox offerbox
	{
		get
		{
			return _offerbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_offerbox = value;
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

	public co()
	{
		((Form)this).add_Load((EventHandler)co_Load);
		offers = new string[1] { "CashRocketGPT" };
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
		offerbox = new ListBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		((Control)this).SuspendLayout();
		((ListControl)offerbox).set_FormattingEnabled(true);
		ListBox obj = offerbox;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)offerbox).set_Name("offerbox");
		ListBox obj2 = offerbox;
		Size size = new Size(260, 212);
		((Control)obj2).set_Size(size);
		((Control)offerbox).set_TabIndex(0);
		Button button = Button1;
		location = new Point(12, 227);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(260, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Complete selected offer");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(12, 256);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(260, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Complete all offers");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(12, 284);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(260, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(3);
		((ButtonBase)Button3).set_Text("Mark all offers as pending");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 319);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)offerbox);
		((Control)this).set_Name("co");
		((Form)this).set_Text("ShiftCode - Complete Offers");
		((Control)this).ResumeLayout(false);
	}

	private void co_Load(object sender, EventArgs e)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = offers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text = Conversions.ToString(enumerator.Current);
				offerbox.get_Items().Add((object)text);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public object completeoffer(string offer)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/members/signupPTS.php?q=" + offer, ""));
			text = text.Remove(0, checked(text.IndexOf("signupPTS.php?signup&ptsID=") + 27));
			string[] array = text.Split(new char[1] { '&' });
			offid = array[0];
			if (!Operators.ConditionalCompareObjectLessEqual(Conversion.Int((object)offid), (object)0, false))
			{
				text = Conversions.ToString(MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/members/pts/click.php?ptsID=" + offid, ""));
				switch (offer)
				{
				case "Simple Online Media":
					MyProject.Forms.aio.sendPost("http://aqualeads.com/t/13761_1421166393741d174f57c9.js", "");
					break;
				case "Gpt Instant Rewardz":
					MyProject.Forms.aio.sendPost("http://loyalpubs.com/t/3067_cc70799d58e4190d445f6d.js", "");
					break;
				case "Meprizes gpt":
					MyProject.Forms.aio.sendPost("http://aqualeads.com/t/27518_857473d2b3eedef9e726f6.js", "");
					break;
				case "Real Prizes and Giveaways - Registration - All Countries":
					MyProject.Forms.reg.register("realprizesandgiveaways.com", "");
					MyProject.Forms.aio.sendPost("http://adz20.com/t/4391_4791b74fb6639b9f158f4d.js", "");
					MyProject.Forms.aio.sendPost("http://aqualeads.com/t/27976_b2166f518a7f91e4e5396d.js", "");
					break;
				}
				return "Successfully completed " + offer;
			}
			Interaction.MsgBox((object)"Offer does not exist or already completed.", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = offer + " could not be completed, either not found or malfunction.";
			ProjectData.ClearProjectError();
			return result;
		}
		return "Not in offer complete list.";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox(RuntimeHelpers.GetObjectValue(completeoffer(Conversions.ToString(offerbox.get_SelectedItem()))), (MsgBoxStyle)0, (object)null);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = offers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string offer = Conversions.ToString(enumerator.Current);
				text = Conversions.ToString(Operators.AddObject((object)text, Operators.AddObject(completeoffer(offer), (object)"\r\n")));
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)null);
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		string text = "Success";
		int num = default(int);
		while (text.Contains("Success"))
		{
			text = Conversions.ToString(completeoffer(""));
			MyProject.Forms.aio.sendPost("http://" + MyProject.Forms.aio.domain + "/members/signupPTS.php?signup&ptsID=" + offid, Conversions.ToString(Operators.AddObject((object)"loginID=", MyProject.Forms.aio.randLetters(5, 10))));
			num = checked(num + 1);
		}
		Interaction.MsgBox((object)("Marked " + num + " offers as pending!"), (MsgBoxStyle)0, (object)null);
	}
}
