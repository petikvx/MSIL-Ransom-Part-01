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

public class Pro_leads : UserControl
{
	private IContainer components = null;

	private MetroLabel label21;

	public MetroTextBox quantity_pro_leads_textBox1;

	public MetroTextBox delay_pro_leads_textBox5;

	public MetroTextBox keyword_pro_leads_textBox6;

	private MetroLabel label14;

	private MetroLabel label15;

	private MetroLabel Keyword;

	public MetroCheckBox follow_new_poshers_metroCheckBox1;

	public MetroCheckBox followback_metroCheckBox1;

	public Pro_leads()
	{
		InitializeComponent();
	}

	public bool check_required_things()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		if (((Control)keyword_pro_leads_textBox6).get_Text() != "" && ((Control)delay_pro_leads_textBox5).get_Text() != "" && ((Control)quantity_pro_leads_textBox1).get_Text() != "")
		{
			return true;
		}
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj = _003C_003Ec._003C_003E9__1_0;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Provide All values in poshmark pro leads\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__1_0 = val;
		}
		((Control)status_textBox).Invoke((Delegate)obj);
		return false;
	}

	public void start_poshmark_pro_leads()
	{
		string text = ((Control)keyword_pro_leads_textBox6).get_Text();
		string text2 = ((Control)delay_pro_leads_textBox5).get_Text();
		string text3 = ((Control)quantity_pro_leads_textBox1).get_Text();
		follow_the_people_on_keyword(text, text2, text3);
	}

	public void follow_the_people_on_keyword(string keyword, string delay_in_follow, string follows_required)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected O, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected O, but got Unknown
		//IL_08e4: Expected O, but got Unknown
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected O, but got Unknown
		object obj = _003C_003Ec._003C_003E9__3_0;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Initializing Follow\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__3_0 = val;
		}
		MethodInvoker val2 = (MethodInvoker)obj;
		((Control)Form1.mainform).Invoke((Delegate)(object)val2);
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
		((Control)Form1.mainform).Invoke((Delegate)(object)val2);
		int total_follow_done = 0;
		int follow_performed = 0;
		string token = Form1.ed.return_csrf_token(Form1.ck);
		string posh_market = Form1.ed.return_poshmarket(Form1.ck);
		if (posh_market != "All")
		{
			try
			{
				((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Your Poshmarket is not selected to ALL --> " + posh_market + ".\tSelect Poshmarket To all for all shares/follows, Other options limits results\r\n");
				});
				if (((CheckBox)Form1.pro_configuration_class.poshmark_checkbox).get_Checked() && Form1.ed.set_posh_market(Form1.ck, token))
				{
					posh_market = Form1.ed.return_poshmarket(Form1.ck);
				}
			}
			catch
			{
			}
		}
		List<string> list = new List<string>();
		new List<string>();
		string[] array = Regex.Split(keyword, ",");
		if (keyword.ToLower() == "follow back closets")
		{
			list = Form1.ed.extract_closet_from_news(follows_required, ref token, ref Form1.ck, share_follow: false);
			list = list.Distinct().ToList();
		}
		else if (keyword.ToLower() != "new poshers")
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				List<string> list2 = new List<string>();
				list2 = Form1.ed.get_listings_based_on_keyword(follows_required, text.TrimStart(new char[0]).TrimEnd(new char[0]), ref token, ref Form1.ck, return_listings: false);
				list.AddRange(list2);
				list = list.Distinct().ToList();
				if (list.Count > int.Parse(follows_required))
				{
					break;
				}
			}
		}
		else
		{
			list = Form1.ed.extract_closet_of_new_poshers(follows_required, ref token, ref Form1.ck);
			List<string> list3 = new List<string>();
			foreach (string item in list)
			{
				list3.Add("/closet/" + item);
			}
			list = list3;
		}
		object obj4 = _003C_003Ec._003C_003E9__3_3;
		if (obj4 == null)
		{
			MethodInvoker val4 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Going For Follow Leads \r\n");
			};
			obj4 = (object)val4;
			_003C_003Ec._003C_003E9__3_3 = val4;
		}
		val2 = (MethodInvoker)obj4;
		((Control)Form1.mainform).Invoke((Delegate)(object)val2);
		string uid = Form1.ed.return_login_uid(Form1.ck);
		MethodInvoker val8 = default(MethodInvoker);
		foreach (string item2 in list)
		{
			string status = "";
			string text2 = item2;
			if (!text2.Contains("/closet/"))
			{
				text2 = "/closet/" + item2;
			}
			if (!item2.Contains("------"))
			{
				dynamic val5 = Form1.ed.extract_closet_page_date(item2);
				if (val5 != null)
				{
					try
					{
						dynamic val6 = val5["$_closet"]["closetUserInfo"]["data"]["id"];
						if (!(bool)val5["$_closet"]["isUserFollowed"])
						{
							text2 = text2 + "------" + val6;
							goto IL_0810;
						}
					}
					catch
					{
						try
						{
							dynamic val7 = val5["closet_det_id"];
							if (!(bool)val5["user_already_following"])
							{
								text2 = text2 + "------" + val7;
								goto end_IL_0670;
							}
							goto end_IL_066f;
							end_IL_0670:;
						}
						catch
						{
						}
						goto IL_0810;
						end_IL_066f:;
					}
					continue;
				}
			}
			goto IL_0810;
			IL_0810:
			if (!text2.Contains("------"))
			{
				continue;
			}
			string _profile_name = Regex.Split(text2, "------")[0].Replace("/closet/", "");
			if (Form1.ed.follow_these_leads(text2, ref token, ref Form1.ck, ref status, "true", uid))
			{
				val2 = (MethodInvoker)delegate
				{
					((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("successfully followed: " + _profile_name + "\r\n");
				};
				((Control)Form1.mainform).Invoke((Delegate)(object)val2);
				total_follow_done++;
			}
			else
			{
				val2 = (MethodInvoker)delegate
				{
					((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("unsuccessfully followed: " + _profile_name + " Reason " + status + "\r\n");
				};
				((Control)Form1.mainform).Invoke((Delegate)(object)val2);
			}
			follow_performed++;
			MethodInvoker obj7 = val8;
			if (obj7 == null)
			{
				MethodInvoker val9 = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Follow Stats: Total Followed " + total_follow_done + "\r\nTotal follow Attempts: " + follow_performed + "\r\n");
				};
				MethodInvoker val10 = val9;
				val8 = val9;
				obj7 = val10;
			}
			val2 = obj7;
			((Control)Form1.mainform).Invoke((Delegate)(object)val2);
			Form1.ed.delay_value_getter(delay_in_follow);
			if (((CheckBox)Form1.pro_configuration_class.delay_protection_checkBox1).get_Checked() && total_follow_done % 15 == 0 && total_follow_done != 0)
			{
				object obj8 = _003C_003Ec._003C_003E9__3_7;
				if (obj8 == null)
				{
					MethodInvoker val11 = delegate
					{
						((TextBoxBase)Form1.mainform.status_textBox1).AppendText("App in Sleep for 15 seconds to avoid from captcha\r\n");
					};
					obj8 = (object)val11;
					_003C_003Ec._003C_003E9__3_7 = val11;
				}
				val2 = (MethodInvoker)obj8;
				((Control)Form1.mainform).Invoke((Delegate)(object)val2);
				Thread.Sleep(15000);
			}
			if (total_follow_done >= int.Parse(follows_required))
			{
				break;
			}
		}
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj9 = _003C_003Ec._003C_003E9__3_8;
		if (obj9 == null)
		{
			MethodInvoker val12 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Follow Completed\r\n");
			};
			obj9 = (object)val12;
			_003C_003Ec._003C_003E9__3_8 = val12;
		}
		((Control)status_textBox).Invoke((Delegate)obj9);
	}

	private void quantity_pro_leads_textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

	private void quantity_pro_leads_textBox1_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
	}

	private void follow_new_poshers_metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)follow_new_poshers_metroCheckBox1).get_Checked())
		{
			((CheckBox)followback_metroCheckBox1).set_Checked(false);
			((Control)keyword_pro_leads_textBox6).set_Enabled(false);
			((Control)keyword_pro_leads_textBox6).set_Text("New Poshers");
		}
		else
		{
			((Control)keyword_pro_leads_textBox6).set_Enabled(true);
			((Control)keyword_pro_leads_textBox6).set_Text("Anthropologie, Prada, Gucci");
		}
	}

	private void followback_metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)followback_metroCheckBox1).get_Checked())
		{
			((CheckBox)follow_new_poshers_metroCheckBox1).set_Checked(false);
			((Control)keyword_pro_leads_textBox6).set_Text("Follow Back Closets");
			((Control)keyword_pro_leads_textBox6).set_Enabled(false);
		}
		else
		{
			((Control)keyword_pro_leads_textBox6).set_Enabled(true);
			((Control)keyword_pro_leads_textBox6).set_Text("Anthropologie, Prada, Gucci");
		}
	}

	private void followback_metroCheckBox1_Leave(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Control val = (Control)((sender is Control) ? sender : null);
			if (val is CheckBox)
			{
				if (((CheckBox)val).get_Checked())
				{
					Form1.update_backup_data(((object)this).GetType().Name + "______;" + ((Control)(CheckBox)val).get_Name(), "T");
				}
				else
				{
					Form1.update_backup_data(((object)this).GetType().Name + "______;" + ((Control)(CheckBox)val).get_Name(), "F");
				}
			}
			else if (val is MetroCheckBox)
			{
				if (((CheckBox)(MetroCheckBox)(object)val).get_Checked())
				{
					Form1.update_backup_data(((object)this).GetType().Name + "______;" + ((Control)(MetroCheckBox)(object)val).get_Name(), "T");
				}
				else
				{
					Form1.update_backup_data(((object)this).GetType().Name + "______;" + ((Control)(MetroCheckBox)(object)val).get_Name(), "F");
				}
			}
			else if (val is MetroTextBox && ((Control)(MetroTextBox)(object)val).get_Text() != "")
			{
				Form1.update_backup_data(((object)this).GetType().Name + "______;" + ((Control)(MetroTextBox)(object)val).get_Name(), ((Control)(MetroTextBox)(object)val).get_Text());
			}
		}
		catch
		{
		}
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		label21 = new MetroLabel();
		quantity_pro_leads_textBox1 = new MetroTextBox();
		delay_pro_leads_textBox5 = new MetroTextBox();
		keyword_pro_leads_textBox6 = new MetroTextBox();
		label14 = new MetroLabel();
		label15 = new MetroLabel();
		Keyword = new MetroLabel();
		follow_new_poshers_metroCheckBox1 = new MetroCheckBox();
		followback_metroCheckBox1 = new MetroCheckBox();
		((Control)this).SuspendLayout();
		((Control)label21).set_AutoSize(true);
		((Control)label21).set_Location(new Point(309, 88));
		((Control)label21).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(100, 19));
		label21.Style = MetroColorStyle.Brown;
		((Control)label21).set_TabIndex(25);
		((Control)label21).set_Text("Ex: 1,4 Seconds ");
		label21.UseStyleColors = true;
		((Control)quantity_pro_leads_textBox1).set_ForeColor(Color.LightGray);
		((Control)quantity_pro_leads_textBox1).set_Location(new Point(516, 117));
		((Control)quantity_pro_leads_textBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)quantity_pro_leads_textBox1).set_Name("quantity_pro_leads_textBox1");
		((Control)quantity_pro_leads_textBox1).set_Size(new Size(388, 31));
		quantity_pro_leads_textBox1.Style = MetroColorStyle.Brown;
		((Control)quantity_pro_leads_textBox1).set_TabIndex(24);
		((Control)quantity_pro_leads_textBox1).set_Text("300");
		quantity_pro_leads_textBox1.UseStyleColors = true;
		((Control)quantity_pro_leads_textBox1).add_Click((EventHandler)quantity_pro_leads_textBox1_Click);
		((Control)quantity_pro_leads_textBox1).add_KeyPress(new KeyPressEventHandler(quantity_pro_leads_textBox1_KeyPress));
		((Control)quantity_pro_leads_textBox1).add_Leave((EventHandler)followback_metroCheckBox1_Leave);
		((Control)delay_pro_leads_textBox5).set_ForeColor(Color.LightGray);
		((Control)delay_pro_leads_textBox5).set_Location(new Point(516, 62));
		((Control)delay_pro_leads_textBox5).set_Margin(new Padding(4, 5, 4, 5));
		((Control)delay_pro_leads_textBox5).set_Name("delay_pro_leads_textBox5");
		((Control)delay_pro_leads_textBox5).set_Size(new Size(388, 31));
		delay_pro_leads_textBox5.Style = MetroColorStyle.Brown;
		((Control)delay_pro_leads_textBox5).set_TabIndex(22);
		((Control)delay_pro_leads_textBox5).set_Text("7,11");
		delay_pro_leads_textBox5.UseStyleColors = true;
		((Control)delay_pro_leads_textBox5).add_Click((EventHandler)quantity_pro_leads_textBox1_Click);
		((Control)delay_pro_leads_textBox5).add_KeyPress(new KeyPressEventHandler(quantity_pro_leads_textBox1_KeyPress));
		((Control)delay_pro_leads_textBox5).add_Leave((EventHandler)followback_metroCheckBox1_Leave);
		((Control)keyword_pro_leads_textBox6).set_ForeColor(Color.LightGray);
		((Control)keyword_pro_leads_textBox6).set_Location(new Point(516, 20));
		((Control)keyword_pro_leads_textBox6).set_Margin(new Padding(4, 5, 4, 5));
		((Control)keyword_pro_leads_textBox6).set_Name("keyword_pro_leads_textBox6");
		((Control)keyword_pro_leads_textBox6).set_Size(new Size(388, 31));
		keyword_pro_leads_textBox6.Style = MetroColorStyle.Brown;
		((Control)keyword_pro_leads_textBox6).set_TabIndex(20);
		((Control)keyword_pro_leads_textBox6).set_Text("Anthropologie, Prada, Gucci");
		keyword_pro_leads_textBox6.UseStyleColors = true;
		((Control)keyword_pro_leads_textBox6).add_Click((EventHandler)quantity_pro_leads_textBox1_Click);
		((Control)keyword_pro_leads_textBox6).add_Leave((EventHandler)followback_metroCheckBox1_Leave);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(22, 122));
		((Control)label14).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(177, 19));
		label14.Style = MetroColorStyle.Brown;
		((Control)label14).set_TabIndex(23);
		((Control)label14).set_Text("Number of closet's to follow ");
		label14.UseStyleColors = true;
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Location(new Point(22, 62));
		((Control)label15).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(238, 19));
		label15.Style = MetroColorStyle.Brown;
		((Control)label15).set_TabIndex(21);
		((Control)label15).set_Text("Follow next closet every X to X seconds");
		label15.UseStyleColors = true;
		((Control)Keyword).set_AutoSize(true);
		((Control)Keyword).set_Location(new Point(22, 20));
		((Control)Keyword).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Keyword).set_Name("Keyword");
		((Control)Keyword).set_Size(new Size(59, 19));
		Keyword.Style = MetroColorStyle.Brown;
		((Control)Keyword).set_TabIndex(19);
		((Control)Keyword).set_Text("Keyword");
		Keyword.UseStyleColors = true;
		((Control)follow_new_poshers_metroCheckBox1).set_AutoSize(true);
		((Control)follow_new_poshers_metroCheckBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)follow_new_poshers_metroCheckBox1).set_Location(new Point(22, 185));
		((Control)follow_new_poshers_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)follow_new_poshers_metroCheckBox1).set_Name("follow_new_poshers_metroCheckBox1");
		((Control)follow_new_poshers_metroCheckBox1).set_Size(new Size(129, 15));
		follow_new_poshers_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)follow_new_poshers_metroCheckBox1).set_TabIndex(98);
		((Control)follow_new_poshers_metroCheckBox1).set_Text("Follow New poshers");
		follow_new_poshers_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)follow_new_poshers_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)follow_new_poshers_metroCheckBox1).add_CheckedChanged((EventHandler)follow_new_poshers_metroCheckBox1_CheckedChanged);
		((Control)follow_new_poshers_metroCheckBox1).add_Leave((EventHandler)followback_metroCheckBox1_Leave);
		((Control)followback_metroCheckBox1).set_AutoSize(true);
		((Control)followback_metroCheckBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)followback_metroCheckBox1).set_Location(new Point(22, 234));
		((Control)followback_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)followback_metroCheckBox1).set_Name("followback_metroCheckBox1");
		((Control)followback_metroCheckBox1).set_Size(new Size(222, 15));
		followback_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)followback_metroCheckBox1).set_TabIndex(100);
		((Control)followback_metroCheckBox1).set_Text("Follow X closets Who Followed Closet");
		followback_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)followback_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)followback_metroCheckBox1).add_CheckedChanged((EventHandler)followback_metroCheckBox1_CheckedChanged);
		((Control)followback_metroCheckBox1).add_Leave((EventHandler)followback_metroCheckBox1_Leave);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)followback_metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)follow_new_poshers_metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)label21);
		((Control)this).get_Controls().Add((Control)(object)quantity_pro_leads_textBox1);
		((Control)this).get_Controls().Add((Control)(object)delay_pro_leads_textBox5);
		((Control)this).get_Controls().Add((Control)(object)keyword_pro_leads_textBox6);
		((Control)this).get_Controls().Add((Control)(object)label14);
		((Control)this).get_Controls().Add((Control)(object)label15);
		((Control)this).get_Controls().Add((Control)(object)Keyword);
		((Control)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Pro_leads");
		((Control)this).set_Size(new Size(927, 606));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
