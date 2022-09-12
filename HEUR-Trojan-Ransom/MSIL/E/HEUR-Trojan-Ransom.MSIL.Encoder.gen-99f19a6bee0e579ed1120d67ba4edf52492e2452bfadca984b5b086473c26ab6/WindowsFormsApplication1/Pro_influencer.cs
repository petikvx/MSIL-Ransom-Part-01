using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace WindowsFormsApplication1;

public class Pro_influencer : UserControl
{
	private IContainer components = null;

	private MetroLabel label51;

	private MetroLabel label35;

	private MetroTextBox textBox2_delay_like_commet;

	private MetroTextBox textBox4_comment_text;

	private MetroTextBox textBox3_comment_or_like_counts;

	private MetroTextBox textBox2_keyword_for_like_comment;

	private MetroLabel label28;

	private MetroLabel label27;

	private MetroLabel label26;

	private MetroCheckBox checkBox1_like_Or_comment;

	private MetroLabel label24;

	private MetroLabel label23;

	private MetroLabel label22;

	public Pro_influencer()
	{
		InitializeComponent();
	}

	public bool check_required_things()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		if (((Control)textBox2_keyword_for_like_comment).get_Text() == "" || ((Control)textBox3_comment_or_like_counts).get_Text() == "")
		{
			MetroTextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__1_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide Count value and Keyword in Poshmark Influencer\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__1_0 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			return false;
		}
		if (((Control)textBox2_delay_like_commet).get_Text() == "")
		{
			MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
			object obj2 = _003C_003Ec._003C_003E9__1_1;
			if (obj2 == null)
			{
				MethodInvoker val2 = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide Delay value in Poshmark Influencer\r\n");
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__1_1 = val2;
			}
			((Control)status_textBox2).Invoke((Delegate)obj2);
			return false;
		}
		if (!((CheckBox)checkBox1_like_Or_comment).get_Checked() && ((Control)textBox4_comment_text).get_Text() == "")
		{
			MetroTextBox status_textBox3 = Form1.mainform.status_textBox1;
			object obj3 = _003C_003Ec._003C_003E9__1_2;
			if (obj3 == null)
			{
				MethodInvoker val3 = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide Comment text in Poshmark Influencer\r\n");
				};
				obj3 = (object)val3;
				_003C_003Ec._003C_003E9__1_2 = val3;
			}
			((Control)status_textBox3).Invoke((Delegate)obj3);
			return false;
		}
		return true;
	}

	public void start_poshmark__influencer()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		string text = ((Control)textBox2_keyword_for_like_comment).get_Text();
		string text2 = ((Control)textBox3_comment_or_like_counts).get_Text();
		string text3 = ((Control)textBox4_comment_text).get_Text();
		string text4 = ((Control)textBox2_delay_like_commet).get_Text();
		bool comment_it = false;
		if (text == "" || text2 == "")
		{
			MetroTextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__2_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide Count value and Keyword in Poshmark Influencer\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__2_0 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			return;
		}
		if (!((CheckBox)checkBox1_like_Or_comment).get_Checked())
		{
			if (text3 == "")
			{
				MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
				object obj2 = _003C_003Ec._003C_003E9__2_1;
				if (obj2 == null)
				{
					MethodInvoker val2 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("Provide Comment text in Poshmark Influencer\r\n");
					};
					obj2 = (object)val2;
					_003C_003Ec._003C_003E9__2_1 = val2;
				}
				((Control)status_textBox2).Invoke((Delegate)obj2);
				return;
			}
			comment_it = true;
		}
		like_comment_people_profile(text, text2, text3, comment_it, text4);
	}

	public void like_comment_people_profile(string keyword, string count_oflikesORcomment, string comment_text, bool comment_it, string delay_afte_each_like_or_comment)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01dd: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		object obj = _003C_003Ec._003C_003E9__3_0;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Initializing Like/Comment\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__3_0 = val;
		}
		MethodInvoker val2 = (MethodInvoker)obj;
		((Control)this).Invoke((Delegate)(object)val2);
		object obj2 = _003C_003Ec._003C_003E9__3_1;
		if (obj2 == null)
		{
			MethodInvoker val3 = delegate
			{
				((Control)Form1.mainform.Log_textBox1).set_Text("");
			};
			obj2 = (object)val3;
			_003C_003Ec._003C_003E9__3_1 = val3;
		}
		val2 = (MethodInvoker)obj2;
		((Control)this).Invoke((Delegate)(object)val2);
		string token = Form1.ed.return_csrf_token(Form1.ck);
		List<string> list2 = new List<string>();
		list2 = Form1.ed.get_listings_based_on_keyword(count_oflikesORcomment, keyword.TrimStart(new char[0]).TrimEnd(new char[0]), ref token, ref Form1.ck, return_listings: true);
		int total_like_comment_done = 0;
		int like_comment_performed = 0;
		MethodInvoker val4 = default(MethodInvoker);
		foreach (string list in list2)
		{
			string status = "";
			string comment = comment_text;
			try
			{
				string[] source = Regex.Split(comment_text, "\r\n");
				source = source.Where((string x) => !string.IsNullOrEmpty(x)).ToArray();
				Random random = new Random();
				int num = random.Next(0, source.Length - 1);
				comment = source[num].TrimStart(new char[0]).TrimEnd(new char[0]);
			}
			catch
			{
			}
			if (Form1.ed.like_comment_these_leads(list, comment, comment_it, ref token, ref Form1.ck, ref status))
			{
				val2 = (MethodInvoker)delegate
				{
					Form1.mainform.Log_textBox1.AppendText("successfully Liked/commented: " + list + "\r\n");
				};
				((Control)this).Invoke((Delegate)(object)val2);
				total_like_comment_done++;
			}
			else
			{
				val2 = (MethodInvoker)delegate
				{
					Form1.mainform.Log_textBox1.AppendText("Liked Liked/commented: " + list + " Reason " + status + "\r\n");
				};
				((Control)this).Invoke((Delegate)(object)val2);
			}
			like_comment_performed++;
			MethodInvoker obj4 = val4;
			if (obj4 == null)
			{
				MethodInvoker val5 = delegate
				{
					Form1.mainform.status_textBox1.AppendText("Follow Stats: Total Like/Commented " + total_like_comment_done + "\r\nTotal Like/Commented Attempts: " + like_comment_performed + "\r\n");
				};
				MethodInvoker val6 = val5;
				val4 = val5;
				obj4 = val6;
			}
			val2 = obj4;
			((Control)this).Invoke((Delegate)(object)val2);
			int num2 = Form1.ed.delay_value_getter(delay_afte_each_like_or_comment);
			if (total_like_comment_done % 15 == 0)
			{
				object obj5 = _003C_003Ec._003C_003E9__3_6;
				if (obj5 == null)
				{
					MethodInvoker val7 = delegate
					{
						Form1.mainform.status_textBox1.AppendText("App in Sleep for 15 seconds to avoid from captcha\r\n");
					};
					obj5 = (object)val7;
					_003C_003Ec._003C_003E9__3_6 = val7;
				}
				val2 = (MethodInvoker)obj5;
				((Control)this).Invoke((Delegate)(object)val2);
				Thread.Sleep(15000);
			}
			Thread.Sleep(num2 * 1000);
		}
		MetroTextBox status_textBox = Form1.mainform.status_textBox1;
		object obj6 = _003C_003Ec._003C_003E9__3_7;
		if (obj6 == null)
		{
			MethodInvoker val8 = delegate
			{
				Form1.mainform.status_textBox1.AppendText("Follow Completed\r\n");
			};
			obj6 = (object)val8;
			_003C_003Ec._003C_003E9__3_7 = val8;
		}
		((Control)status_textBox).Invoke((Delegate)obj6);
	}

	private void textBox2_delay_like_commet_KeyPress(object sender, KeyPressEventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		string name = ((Control)metroTextBox).get_Name();
		if (name.Contains("delay"))
		{
			if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != ',')
			{
				e.set_Handled(true);
			}
		}
		else if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()))
		{
			e.set_Handled(true);
		}
	}

	private void textBox2_delay_like_commet_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
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
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		label51 = new MetroLabel();
		label35 = new MetroLabel();
		textBox2_delay_like_commet = new MetroTextBox();
		textBox4_comment_text = new MetroTextBox();
		textBox3_comment_or_like_counts = new MetroTextBox();
		textBox2_keyword_for_like_comment = new MetroTextBox();
		label28 = new MetroLabel();
		label27 = new MetroLabel();
		label26 = new MetroLabel();
		checkBox1_like_Or_comment = new MetroCheckBox();
		label24 = new MetroLabel();
		label23 = new MetroLabel();
		label22 = new MetroLabel();
		((Control)this).SuspendLayout();
		((Control)label51).set_AutoSize(true);
		((Control)label51).set_Cursor(Cursors.get_Hand());
		((Control)label51).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label51).set_Location(new Point(503, 4));
		((Control)label51).set_Name("label51");
		((Control)label51).set_Size(new Size(201, 19));
		label51.Style = MetroColorStyle.Brown;
		((Control)label51).set_TabIndex(42);
		((Control)label51).set_Text("How to use Influencer? Click here");
		label51.UseStyleColors = true;
		((Control)label35).set_AutoSize(true);
		((Control)label35).set_BackColor(Color.Transparent);
		((Control)label35).set_Location(new Point(69, 225));
		((Control)label35).set_Name("label35");
		((Control)label35).set_Size(new Size(265, 38));
		label35.Style = MetroColorStyle.Brown;
		((Control)label35).set_TabIndex(41);
		((Control)label35).set_Text("(Give Multiple comments, each on new line, \r\napp will post random comment)");
		label35.UseStyleColors = true;
		((Control)textBox2_delay_like_commet).set_Location(new Point(448, 130));
		((Control)textBox2_delay_like_commet).set_Name("textBox2_delay_like_commet");
		((Control)textBox2_delay_like_commet).set_Size(new Size(154, 20));
		textBox2_delay_like_commet.Style = MetroColorStyle.Brown;
		((Control)textBox2_delay_like_commet).set_TabIndex(40);
		textBox2_delay_like_commet.UseStyleColors = true;
		((Control)textBox2_delay_like_commet).add_Click((EventHandler)textBox2_delay_like_commet_Click);
		((Control)textBox2_delay_like_commet).add_KeyPress(new KeyPressEventHandler(textBox2_delay_like_commet_KeyPress));
		((Control)textBox4_comment_text).set_Location(new Point(448, 202));
		textBox4_comment_text.Multiline = true;
		((Control)textBox4_comment_text).set_Name("textBox4_comment_text");
		((Control)textBox4_comment_text).set_Size(new Size(154, 96));
		textBox4_comment_text.Style = MetroColorStyle.Brown;
		((Control)textBox4_comment_text).set_TabIndex(37);
		((Control)textBox4_comment_text).set_Text("Ex:\r\nNice\r\nGreat product\r\nLoved it\r\nAmazing\r\n....");
		textBox4_comment_text.UseStyleColors = true;
		((Control)textBox4_comment_text).add_Click((EventHandler)textBox2_delay_like_commet_Click);
		((Control)textBox3_comment_or_like_counts).set_Location(new Point(448, 98));
		((Control)textBox3_comment_or_like_counts).set_Name("textBox3_comment_or_like_counts");
		((Control)textBox3_comment_or_like_counts).set_Size(new Size(154, 20));
		textBox3_comment_or_like_counts.Style = MetroColorStyle.Brown;
		((Control)textBox3_comment_or_like_counts).set_TabIndex(34);
		textBox3_comment_or_like_counts.UseStyleColors = true;
		((Control)textBox3_comment_or_like_counts).add_Click((EventHandler)textBox2_delay_like_commet_Click);
		((Control)textBox3_comment_or_like_counts).add_KeyPress(new KeyPressEventHandler(textBox2_delay_like_commet_KeyPress));
		((Control)textBox2_keyword_for_like_comment).set_Location(new Point(448, 66));
		((Control)textBox2_keyword_for_like_comment).set_Name("textBox2_keyword_for_like_comment");
		((Control)textBox2_keyword_for_like_comment).set_Size(new Size(154, 20));
		textBox2_keyword_for_like_comment.Style = MetroColorStyle.Brown;
		((Control)textBox2_keyword_for_like_comment).set_TabIndex(31);
		textBox2_keyword_for_like_comment.UseStyleColors = true;
		((Control)textBox2_keyword_for_like_comment).add_Click((EventHandler)textBox2_delay_like_commet_Click);
		((Control)label28).set_AutoSize(true);
		((Control)label28).set_Location(new Point(7, 136));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(268, 19));
		label28.Style = MetroColorStyle.Brown;
		((Control)label28).set_TabIndex(39);
		((Control)label28).set_Text("Provide Delay between next likes/Comments");
		label28.UseStyleColors = true;
		((Control)label27).set_AutoSize(true);
		((Control)label27).set_Location(new Point(7, 205));
		((Control)label27).set_Name("label27");
		((Control)label27).set_Size(new Size(94, 19));
		label27.Style = MetroColorStyle.Brown;
		((Control)label27).set_TabIndex(38);
		((Control)label27).set_Text("Comment Text");
		label27.UseStyleColors = true;
		((Control)label26).set_AutoSize(true);
		((Control)label26).set_Location(new Point(153, 305));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(233, 19));
		label26.Style = MetroColorStyle.Brown;
		((Control)label26).set_TabIndex(36);
		((Control)label26).set_Text("(Select to like or unselect to comment)");
		label26.UseStyleColors = true;
		((Control)checkBox1_like_Or_comment).set_AutoSize(true);
		((Control)checkBox1_like_Or_comment).set_Location(new Point(11, 304));
		((Control)checkBox1_like_Or_comment).set_Name("checkBox1_like_Or_comment");
		((Control)checkBox1_like_Or_comment).set_Size(new Size(103, 15));
		checkBox1_like_Or_comment.Style = MetroColorStyle.Brown;
		((Control)checkBox1_like_Or_comment).set_TabIndex(35);
		((Control)checkBox1_like_Or_comment).set_Text("Like/Comment");
		checkBox1_like_Or_comment.UseStyleColors = true;
		((ButtonBase)checkBox1_like_Or_comment).set_UseVisualStyleBackColor(true);
		((Control)label24).set_AutoSize(true);
		((Control)label24).set_Location(new Point(7, 104));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(206, 19));
		label24.Style = MetroColorStyle.Brown;
		((Control)label24).set_TabIndex(33);
		((Control)label24).set_Text("Provide Count of likes/Comments");
		label24.UseStyleColors = true;
		((Control)label23).set_AutoSize(true);
		((Control)label23).set_Location(new Point(7, 66));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(303, 19));
		label23.Style = MetroColorStyle.Brown;
		((Control)label23).set_TabIndex(32);
		((Control)label23).set_Text("Provide keyword/brand to like/comment in listings");
		label23.UseStyleColors = true;
		((Control)label22).set_AutoSize(true);
		((Control)label22).set_Location(new Point(3, 28));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(160, 19));
		label22.Style = MetroColorStyle.Brown;
		((Control)label22).set_TabIndex(30);
		((Control)label22).set_Text("Like/ Comment to Listings");
		label22.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label51);
		((Control)this).get_Controls().Add((Control)(object)label35);
		((Control)this).get_Controls().Add((Control)(object)textBox2_delay_like_commet);
		((Control)this).get_Controls().Add((Control)(object)textBox4_comment_text);
		((Control)this).get_Controls().Add((Control)(object)textBox3_comment_or_like_counts);
		((Control)this).get_Controls().Add((Control)(object)textBox2_keyword_for_like_comment);
		((Control)this).get_Controls().Add((Control)(object)label28);
		((Control)this).get_Controls().Add((Control)(object)label27);
		((Control)this).get_Controls().Add((Control)(object)label26);
		((Control)this).get_Controls().Add((Control)(object)checkBox1_like_Or_comment);
		((Control)this).get_Controls().Add((Control)(object)label24);
		((Control)this).get_Controls().Add((Control)(object)label23);
		((Control)this).get_Controls().Add((Control)(object)label22);
		((Control)this).set_Name("Pro_influencer");
		((Control)this).set_Size(new Size(741, 464));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
