using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework;
using MetroFramework.Controls;
using Poshmark_tools;

namespace WindowsFormsApplication1;

public class Pro_tools : UserControl
{
	private struct closets_share_data
	{
		public string closet_name;

		public string loops;

		public string available_item;

		public string delay_between_share;

		public string delay_between_loop;

		public bool reverse_share;

		public bool part_share;
	}

	private IContainer components = null;

	private MetroTabPage metroTabPage1;

	public MetroTextBox shared_listings_quantity_who_shared_my_listings_textBox6textBox2;

	public MetroTextBox shared_listings_who_shared_my_listings_textBox6;

	public MetroTextBox share_listings_with_keywords_textBox5;

	public MetroCheckBox share_listings_who_shared_my_listings_checkBox6;

	public MetroCheckBox share_listings_with_keywords_checkBox5;

	public MetroCheckBox share_party_checkBox4;

	public MetroCheckBox reverse_share_checkBox3;

	public MetroCheckBox share_my_available_checkBox2;

	public MetroCheckBox share_my_feed_checkBox1;

	private MetroLabel metroLabel5;

	private MetroLabel metroLabel4;

	private MetroLabel metroLabel3;

	private MetroLabel metroLabel2;

	private MetroLabel metroLabel1;

	private MetroTabPage metroTabPage2;

	public MetroCheckBox unfollow_pro_tools_checkBox2;

	public MetroCheckBox follow_pro_tools_checkBox1;

	public MetroTextBox quantity_follow_textBox6;

	private MetroLabel label13;

	public MetroTextBox delay_follow_textBox5;

	private MetroLabel label12;

	public MetroTextBox closet_name_follow_textBox1;

	private MetroLabel label11;

	private MetroTabPage metroTabPage3;

	public MetroLabel label25;

	private DataGridView share_gridview;

	private MetroButton share_multi_closet_data_load_button1;

	private MetroButton share_multi_closet_data_save_button1;

	public MetroTabControl metroTabControl1;

	public MetroTextBox delay_share_textBox7;

	public MetroTextBox delayLoop_textBox8;

	public MetroTextBox share_item_textBox6;

	public MetroTextBox shareloop_TextBox5;

	public MetroTextBox Closet_name_textbox;

	private MetroLabel metroLabel7;

	public MetroCheckBox new_posher_metroCheckBox1;

	private Label label1;

	public MetroCheckBox partyback_share_metroCheckBox1;

	private MetroLabel metroLabel6;

	public Pro_tools()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		InitializeComponent();
		share_gridview.set_ColumnCount(5);
		share_gridview.get_Columns().get_Item(0).set_Name("Closet Name");
		share_gridview.get_Columns().get_Item(1).set_Name("Share loops");
		share_gridview.get_Columns().get_Item(2).set_Name("Available Items");
		share_gridview.get_Columns().get_Item(3).set_Name("Delay Between Shares (In Seconds)");
		share_gridview.get_Columns().get_Item(4).set_Name("Delay between loops (In Seconds)");
		DataGridViewCheckBoxColumn val = new DataGridViewCheckBoxColumn();
		((DataGridViewColumn)val).set_HeaderText("Reverse Share");
		((DataGridViewColumn)val).set_Name("reverse_share");
		((DataGridViewColumn)val).set_ValueType(typeof(bool));
		share_gridview.get_Columns().Add((DataGridViewColumn)(object)val);
		DataGridViewCheckBoxColumn val2 = new DataGridViewCheckBoxColumn();
		((DataGridViewColumn)val2).set_HeaderText("Party Share");
		((DataGridViewColumn)val2).set_Name("party_share");
		((DataGridViewColumn)val2).set_ValueType(typeof(bool));
		share_gridview.get_Columns().Add((DataGridViewColumn)(object)val2);
	}

	private void share_multi_closet_data_save_button1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SaveFileDialog val = new SaveFileDialog();
			DialogResult val2 = ((CommonDialog)val).ShowDialog();
			if ((int)val2 != 1)
			{
				return;
			}
			string fileName = ((FileDialog)val).get_FileName();
			if (fileName.Contains("."))
			{
				MessageBox.Show("Filename doesnot contains special characters like .");
				return;
			}
			fileName += ".pk";
			List<closets_share_data> list = return_closets_share_info();
			if (list.Count > 0)
			{
				try
				{
					if (File.Exists(fileName))
					{
						File.Delete(fileName);
					}
				}
				catch
				{
				}
				foreach (closets_share_data item in list)
				{
					string text = "0";
					if (item.reverse_share)
					{
						text = "1";
					}
					string text2 = "0";
					if (item.part_share)
					{
						text2 = "1";
					}
					File.AppendAllText(fileName, item.closet_name + "," + item.loops + "," + item.available_item + "," + item.delay_between_share + "," + item.delay_between_loop + "," + text + "," + text2 + "\r\n");
				}
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Share Multiple Closets backup done\r\n");
			}
			else
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("No Share Multiple Closets rows found\r\n");
			}
		}
		catch
		{
		}
	}

	private List<closets_share_data> return_closets_share_info()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		List<closets_share_data> list = new List<closets_share_data>();
		bool flag = false;
		foreach (DataGridViewRow item3 in (IEnumerable)share_gridview.get_Rows())
		{
			DataGridViewRow val = item3;
			if (((DataGridViewBand)val).get_Selected())
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			foreach (DataGridViewRow item4 in (IEnumerable)share_gridview.get_Rows())
			{
				DataGridViewRow val2 = item4;
				if (!((DataGridViewBand)val2).get_Selected())
				{
					continue;
				}
				try
				{
					closets_share_data item = default(closets_share_data);
					int i = 0;
					bool flag2 = false;
					for (; i < 5; i++)
					{
						if (val2.get_Cells().get_Item(i).get_Value() == null)
						{
							flag2 = true;
						}
						else if (val2.get_Cells().get_Item(i).get_Value()
							.ToString() == "")
						{
							flag2 = true;
						}
						if (flag2)
						{
							break;
						}
					}
					if (flag2)
					{
						continue;
					}
					item.closet_name = val2.get_Cells().get_Item(0).get_Value()
						.ToString();
					if (!(item.closet_name == ""))
					{
						item.loops = val2.get_Cells().get_Item(1).get_Value()
							.ToString();
						item.available_item = val2.get_Cells().get_Item(2).get_Value()
							.ToString();
						item.delay_between_share = val2.get_Cells().get_Item(3).get_Value()
							.ToString();
						item.delay_between_loop = val2.get_Cells().get_Item(4).get_Value()
							.ToString();
						if (Convert.ToBoolean(val2.get_Cells().get_Item(5).get_Value()))
						{
							item.reverse_share = true;
						}
						else
						{
							item.reverse_share = false;
						}
						if (Convert.ToBoolean(val2.get_Cells().get_Item(6).get_Value()))
						{
							item.part_share = true;
						}
						else
						{
							item.part_share = false;
						}
						list.Add(item);
					}
				}
				catch
				{
					MessageBox.Show("Provide All Values in Grid");
					list.RemoveRange(0, list.Count);
					return list;
				}
			}
		}
		else
		{
			foreach (DataGridViewRow item5 in (IEnumerable)share_gridview.get_Rows())
			{
				DataGridViewRow val3 = item5;
				try
				{
					closets_share_data item2 = default(closets_share_data);
					int j = 0;
					bool flag3 = false;
					for (; j < 5; j++)
					{
						if (val3.get_Cells().get_Item(j).get_Value() == null)
						{
							flag3 = true;
						}
						else if (val3.get_Cells().get_Item(j).get_Value()
							.ToString() == "")
						{
							flag3 = true;
						}
						if (flag3)
						{
							break;
						}
					}
					if (flag3)
					{
						continue;
					}
					item2.closet_name = val3.get_Cells().get_Item(0).get_Value()
						.ToString();
					if (!(item2.closet_name == ""))
					{
						item2.loops = val3.get_Cells().get_Item(1).get_Value()
							.ToString();
						item2.available_item = val3.get_Cells().get_Item(2).get_Value()
							.ToString();
						item2.delay_between_share = val3.get_Cells().get_Item(3).get_Value()
							.ToString();
						item2.delay_between_loop = val3.get_Cells().get_Item(4).get_Value()
							.ToString();
						if (Convert.ToBoolean(val3.get_Cells().get_Item(5).get_Value()))
						{
							item2.reverse_share = true;
						}
						else
						{
							item2.reverse_share = false;
						}
						if (Convert.ToBoolean(val3.get_Cells().get_Item(6).get_Value()))
						{
							item2.part_share = true;
						}
						else
						{
							item2.part_share = false;
						}
						list.Add(item2);
					}
				}
				catch
				{
					MessageBox.Show("Provide All Values in Grid");
					list.RemoveRange(0, list.Count);
					return list;
				}
			}
		}
		return list;
	}

	public bool check_required_things(string poshmark_protool_tab)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		switch (poshmark_protool_tab)
		{
		case "Share Closet":
		{
			if ((((CheckBox)share_listings_who_shared_my_listings_checkBox6).get_Checked() && ((Control)shared_listings_who_shared_my_listings_textBox6).get_Text() == "") || ((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).get_Text() == "")
			{
				TextBox status_textBox5 = Form1.mainform.status_textBox1;
				object obj5 = _003C_003Ec._003C_003E9__4_0;
				if (obj5 == null)
				{
					MethodInvoker val5 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("Provide count off how many recent closets need to share who shared your listings\r\n");
					};
					obj5 = (object)val5;
					_003C_003Ec._003C_003E9__4_0 = val5;
				}
				((Control)status_textBox5).Invoke((Delegate)obj5);
				return false;
			}
			if (((CheckBox)share_listings_with_keywords_checkBox5).get_Checked() && ((Control)share_listings_with_keywords_textBox5).get_Text() == "")
			{
				TextBox status_textBox6 = Form1.mainform.status_textBox1;
				object obj6 = _003C_003Ec._003C_003E9__4_1;
				if (obj6 == null)
				{
					MethodInvoker val6 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("Provide keywords for keyword specific sharing\r\n");
					};
					obj6 = (object)val6;
					_003C_003Ec._003C_003E9__4_1 = val6;
				}
				((Control)status_textBox6).Invoke((Delegate)obj6);
				return false;
			}
			if (!((CheckBox)new_posher_metroCheckBox1).get_Checked() && !((CheckBox)share_my_feed_checkBox1).get_Checked() && !((CheckBox)share_my_available_checkBox2).get_Checked() && !((CheckBox)share_listings_with_keywords_checkBox5).get_Checked() && !((CheckBox)share_listings_who_shared_my_listings_checkBox6).get_Checked() && ((Control)Closet_name_textbox).get_Text() == "")
			{
				TextBox status_textBox7 = Form1.mainform.status_textBox1;
				object obj7 = _003C_003Ec._003C_003E9__4_2;
				if (obj7 == null)
				{
					MethodInvoker val7 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("Provide Closet name for sharing listings or select any other option\r\n");
					};
					obj7 = (object)val7;
					_003C_003Ec._003C_003E9__4_2 = val7;
				}
				((Control)status_textBox7).Invoke((Delegate)obj7);
				return false;
			}
			if ((((CheckBox)new_posher_metroCheckBox1).get_Checked() && ((Control)shared_listings_who_shared_my_listings_textBox6).get_Text() == "") || ((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).get_Text() == "")
			{
				TextBox status_textBox8 = Form1.mainform.status_textBox1;
				object obj8 = _003C_003Ec._003C_003E9__4_3;
				if (obj8 == null)
				{
					MethodInvoker val8 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("Provide count off how many new posher listings need to be shared\r\n");
					};
					obj8 = (object)val8;
					_003C_003Ec._003C_003E9__4_3 = val8;
				}
				((Control)status_textBox8).Invoke((Delegate)obj8);
				return false;
			}
			if (((Control)shareloop_TextBox5).get_Text() != "" && ((Control)share_item_textBox6).get_Text() != "" && ((Control)delayLoop_textBox8).get_Text() != "" && ((Control)delay_share_textBox7).get_Text() != "")
			{
				return true;
			}
			TextBox status_textBox9 = Form1.mainform.status_textBox1;
			object obj9 = _003C_003Ec._003C_003E9__4_4;
			if (obj9 == null)
			{
				MethodInvoker val9 = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide All Loop and Delay values\r\n");
				};
				obj9 = (object)val9;
				_003C_003Ec._003C_003E9__4_4 = val9;
			}
			((Control)status_textBox9).Invoke((Delegate)obj9);
			return false;
		}
		case "Follow/Unfollow Profiles":
		{
			if (((Control)closet_name_follow_textBox1).get_Text() == "" && !((CheckBox)unfollow_pro_tools_checkBox2).get_Checked())
			{
				TextBox status_textBox2 = Form1.mainform.status_textBox1;
				object obj2 = _003C_003Ec._003C_003E9__4_5;
				if (obj2 == null)
				{
					MethodInvoker val2 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("Provide Closet name for following profiles\r\n");
					};
					obj2 = (object)val2;
					_003C_003Ec._003C_003E9__4_5 = val2;
				}
				((Control)status_textBox2).Invoke((Delegate)obj2);
				return false;
			}
			if (((Control)delay_follow_textBox5).get_Text() == "")
			{
				TextBox status_textBox3 = Form1.mainform.status_textBox1;
				object obj3 = _003C_003Ec._003C_003E9__4_6;
				if (obj3 == null)
				{
					MethodInvoker val3 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("Provide dealy between following profiles\r\n");
					};
					obj3 = (object)val3;
					_003C_003Ec._003C_003E9__4_6 = val3;
				}
				((Control)status_textBox3).Invoke((Delegate)obj3);
				return false;
			}
			if (!(((Control)quantity_follow_textBox6).get_Text() == ""))
			{
				break;
			}
			TextBox status_textBox4 = Form1.mainform.status_textBox1;
			object obj4 = _003C_003Ec._003C_003E9__4_7;
			if (obj4 == null)
			{
				MethodInvoker val4 = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide quantity of following profiles\r\n");
				};
				obj4 = (object)val4;
				_003C_003Ec._003C_003E9__4_7 = val4;
			}
			((Control)status_textBox4).Invoke((Delegate)obj4);
			return false;
		}
		case "Share Multiple Closets":
		{
			if (share_gridview.get_Rows().get_Count() > 1)
			{
				break;
			}
			TextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__4_8;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Add rows in Grid for sharing\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__4_8 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			return false;
		}
		}
		return true;
	}

	private void share_multi_closet_data_load_button1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Title("Browse Multi Closet Backup Files");
			((FileDialog)val).set_Filter("pk files (*.pk)|*.pk|All files (*.*)|*.*");
			((CommonDialog)val).ShowDialog();
			string fileName = ((FileDialog)val).get_FileName();
			if (fileName == string.Empty)
			{
				MessageBox.Show("You didn't select any file !", "No file was selected", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			string path = fileName;
			if (File.Exists(path))
			{
				share_gridview.get_Rows().Clear();
				List<string> list = File.ReadAllLines(path).ToList();
				if (list.Count > 0)
				{
					foreach (string item in list)
					{
						string[] array = Regex.Split(item, ",");
						bool flag = false;
						if (array[6] == "1")
						{
							flag = true;
						}
						bool flag2 = false;
						if (array[5] == "1")
						{
							flag2 = true;
						}
						share_gridview.get_Rows().Add(new object[7]
						{
							array[0],
							array[1],
							array[2],
							array[3],
							array[4],
							flag2,
							flag
						});
					}
				}
				else
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("No Share Multiple Closets backup rows found\r\n");
				}
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Share Multiple Closets backup loaded\r\n");
			}
			else
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("No Share Multiple Closets backup found\r\n");
			}
		}
		catch
		{
		}
	}

	public void start_poshmark_pro_tools()
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		switch ((string)((Control)this).Invoke((Delegate)(Func<string>)(() => ((Control)((TabControl)metroTabControl1).get_SelectedTab()).get_Text())))
		{
		case "Share Closet":
		{
			string closet_name2 = ((Control)Closet_name_textbox).get_Text();
			bool party2 = false;
			if (((CheckBox)share_party_checkBox4).get_Checked())
			{
				party2 = true;
			}
			string total_loop = ((Control)shareloop_TextBox5).get_Text();
			string text5 = ((Control)delayLoop_textBox8).get_Text();
			string text6 = ((Control)share_item_textBox6).get_Text();
			string text7 = ((Control)delay_share_textBox7).get_Text();
			if (((CheckBox)share_my_available_checkBox2).get_Checked())
			{
				string text8 = Form1.lg.check_who_is_logined(Form1.ck);
				if (text8 != null)
				{
					closet_name2 = text8.Substring(text8.LastIndexOf("/") + 1, text8.Length - (text8.LastIndexOf("/") + 1));
				}
				else
				{
					MessageBox.Show("Eror101");
				}
				text6 = Form1.ed.get_logined_available_items(Form1.ck);
				if (text6 == "0")
				{
					TextBox status_textBox = Form1.mainform.status_textBox1;
					object obj2 = _003C_003Ec._003C_003E9__6_1;
					if (obj2 == null)
					{
						MethodInvoker val2 = delegate
						{
							((Control)Form1.mainform.status_textBox1).set_Text("No Listings Found\r\n");
						};
						obj2 = (object)val2;
						_003C_003Ec._003C_003E9__6_1 = val2;
					}
					((Control)status_textBox).Invoke((Delegate)obj2);
					break;
				}
			}
			else if (((CheckBox)share_my_feed_checkBox1).get_Checked())
			{
				closet_name2 = "feed";
			}
			else if (((CheckBox)share_listings_with_keywords_checkBox5).get_Checked())
			{
				string text9 = Form1.lg.check_who_is_logined(Form1.ck);
				if (text9 != null)
				{
					closet_name2 = text9.Substring(text9.LastIndexOf("/") + 1, text9.Length - (text9.LastIndexOf("/") + 1));
				}
				else
				{
					MessageBox.Show("Eror101");
				}
			}
			else if (((CheckBox)share_listings_who_shared_my_listings_checkBox6).get_Checked())
			{
				total_loop = "1";
				text6 = ((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).get_Text();
			}
			else if (((CheckBox)new_posher_metroCheckBox1).get_Checked())
			{
				text6 = ((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).get_Text();
				closet_name2 = "new posher";
			}
			else if (((CheckBox)partyback_share_metroCheckBox1).get_Checked())
			{
				text6 = ((Control)share_item_textBox6).get_Text();
				closet_name2 = "party shareback";
			}
			share_some_listings_data(closet_name2, text6, text7, text5, total_loop, party2, reverse: false, default(EditSchdParameters.SchdParametersStruct));
			break;
		}
		case "Follow/ Unfollow Profiles":
		{
			string text = ((Control)closet_name_follow_textBox1).get_Text();
			string text2 = ((Control)quantity_follow_textBox6).get_Text();
			string text3 = ((Control)delay_follow_textBox5).get_Text();
			if (((CheckBox)follow_pro_tools_checkBox1).get_Checked())
			{
				follow_the_people(text, text3, text2, "true", follower_following: true);
				break;
			}
			if (!((CheckBox)follow_pro_tools_checkBox1).get_Checked() && !((CheckBox)unfollow_pro_tools_checkBox2).get_Checked())
			{
				follow_the_people(text, text3, text2, "true", follower_following: false);
				break;
			}
			string text4 = Form1.lg.check_who_is_logined(Form1.ck);
			if (text4 != null)
			{
				text = text4.Substring(text4.LastIndexOf("/") + 1, text4.Length - (text4.LastIndexOf("/") + 1));
				follow_the_people(text, text3, text2, "false", follower_following: false);
			}
			else
			{
				MessageBox.Show("Eror101");
			}
			break;
		}
		case "Share Multiple Closets":
		{
			List<closets_share_data> list = return_closets_share_info();
			int num = 0;
			foreach (closets_share_data item in list)
			{
				if (num < int.Parse(item.loops))
				{
					num = int.Parse(item.loops);
				}
			}
			for (int i = 1; i <= num; i++)
			{
				foreach (closets_share_data item2 in list)
				{
					string closet_name = item2.closet_name;
					bool party = false;
					if (item2.part_share)
					{
						party = true;
					}
					string loops = item2.loops;
					if (int.Parse(loops) < i)
					{
						continue;
					}
					loops = i + "multishare";
					string delay_between_loop = item2.delay_between_loop;
					string available_item = item2.available_item;
					string delay_between_share = item2.delay_between_share;
					foreach (DataGridViewRow item3 in (IEnumerable)share_gridview.get_Rows())
					{
						DataGridViewRow val = item3;
						try
						{
							if (val.get_Cells().get_Item(0).get_Value()
								.ToString() == closet_name)
							{
								((DataGridViewBand)val).get_DefaultCellStyle().set_BackColor(Color.Yellow);
							}
							else
							{
								((DataGridViewBand)val).get_DefaultCellStyle().set_BackColor(Color.White);
							}
						}
						catch
						{
						}
					}
					share_some_listings_data(closet_name, available_item, delay_between_share, delay_between_loop, loops, party, reverse: false, default(EditSchdParameters.SchdParametersStruct));
				}
			}
			break;
		}
		}
	}

	public void share_some_listings_data(string closet_name, string shares_required, string delay_in_share, string delay_after_loop, string total_loop, bool party, bool reverse, EditSchdParameters.SchdParametersStruct sc)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_04d1: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected O, but got Unknown
		//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Expected O, but got Unknown
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c79: Expected O, but got Unknown
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected O, but got Unknown
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Expected O, but got Unknown
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected O, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4e: Expected O, but got Unknown
		//IL_0d53: Expected O, but got Unknown
		//IL_0df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected O, but got Unknown
		//IL_0e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5d: Expected O, but got Unknown
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eea: Expected O, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected O, but got Unknown
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		JavaScriptSerializer val = new JavaScriptSerializer();
		object obj = _003C_003Ec._003C_003E9__7_0;
		if (obj == null)
		{
			MethodInvoker val2 = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Initializing Share\r\n");
			};
			obj = (object)val2;
			_003C_003Ec._003C_003E9__7_0 = val2;
		}
		MethodInvoker val3 = (MethodInvoker)obj;
		((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
		int successfully__shares_done = 0;
		int total_successfully_shares_done = 0;
		int share_performed = 0;
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
		string text = "";
		try
		{
			text = Form1.ed.get_eventid(Form1.ck, token);
			if (text.Contains("<head><title>Fee"))
			{
				text = "";
			}
		}
		catch
		{
		}
		if ((closet_name == "party shareback") & (text == ""))
		{
			object obj4 = _003C_003Ec._003C_003E9__7_2;
			if (obj4 == null)
			{
				MethodInvoker val4 = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("No Party Happening at the moment\r\n");
				};
				obj4 = (object)val4;
				_003C_003Ec._003C_003E9__7_2 = val4;
			}
			val3 = (MethodInvoker)obj4;
			return;
		}
		int total_loop_req = 0;
		int cur_loop = 1;
		if (total_loop.Contains("multishare"))
		{
			total_loop_req = int.Parse(total_loop.Replace("multishare", ""));
			cur_loop = total_loop_req;
		}
		else
		{
			total_loop_req = int.Parse(total_loop);
		}
		MethodInvoker val5 = default(MethodInvoker);
		string link;
		string res;
		MethodInvoker val12 = default(MethodInvoker);
		while (cur_loop <= total_loop_req)
		{
			List<extract_data.Listing_info> list = new List<extract_data.Listing_info>();
			if (((((CheckBox)share_listings_who_shared_my_listings_checkBox6).get_Checked() || ((CheckBox)new_posher_metroCheckBox1).get_Checked()) && ((Control)Form1.mainform.mainform_header).get_Text() == "Poshmark Pro Tools") || sc.type == "Share Back" || sc.type == "Share New Posher Listings")
			{
				string text2 = ((Control)shared_listings_who_shared_my_listings_textBox6).get_Text();
				try
				{
					List<string> list2 = new List<string>();
					if (((CheckBox)share_listings_who_shared_my_listings_checkBox6).get_Checked() || sc.type == "Share Back")
					{
						if (sc.type == "Share Back")
						{
							try
							{
								text2 = Regex.Split(sc.ShareBackLast, ",")[0];
								shares_required = Regex.Split(sc.ShareBackLast, ",")[1];
							}
							catch
							{
								text2 = "1";
								shares_required = "1";
							}
						}
						list2 = Form1.ed.extract_closet_from_news(text2, ref token, ref Form1.ck, share_follow: true);
					}
					else if (((CheckBox)new_posher_metroCheckBox1).get_Checked() || sc.type == "Share New Posher Listings")
					{
						if (sc.type == "Share New Posher Listings")
						{
							try
							{
								text2 = Regex.Split(sc.ShareNewPosher, ",")[0];
								shares_required = Regex.Split(sc.ShareNewPosher, ",")[1];
							}
							catch
							{
							}
						}
						list2 = Form1.ed.extract_closet_of_new_poshers(text2, ref token, ref Form1.ck);
					}
					int num = 0;
					foreach (string item in list2)
					{
						List<extract_data.Listing_info> list3 = new List<extract_data.Listing_info>();
						list3 = Form1.ed.extract_listings_from_closet(item.TrimStart(new char[0]).TrimEnd(new char[0]), shares_required, text, ref token, ref Form1.ck, sc);
						if (list3.Count > 0)
						{
							num++;
						}
						list.AddRange(list3);
						if (num < int.Parse(text2))
						{
							Thread.Sleep(500);
							continue;
						}
						break;
					}
					if (sc.type == "Share Back")
					{
						try
						{
							shares_required = (int.Parse(shares_required) * int.Parse(text2)).ToString();
						}
						catch
						{
						}
					}
				}
				catch (Exception ex)
				{
					if (!Directory.Exists("logs"))
					{
						Directory.CreateDirectory("logs");
					}
					File.AppendAllText("logs//logs.jk", "0569) " + ex.ToString() + "\r\n");
				}
			}
			else
			{
				list = Form1.ed.extract_listings_from_closet(closet_name.TrimStart(new char[0]).TrimEnd(new char[0]), shares_required, text, ref token, ref Form1.ck, sc);
			}
			MethodInvoker obj8 = val5;
			if (obj8 == null)
			{
				MethodInvoker val6 = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Going For Listings Share of " + closet_name + ", expected Shares " + shares_required + ", Loop " + cur_loop + " - " + total_loop_req + "\r\n");
				};
				MethodInvoker val7 = val6;
				val5 = val6;
				obj8 = val7;
			}
			val3 = obj8;
			((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
			successfully__shares_done = 0;
			if (((CheckBox)reverse_share_checkBox3).get_Checked() || reverse)
			{
				List<extract_data.Listing_info> list4 = new List<extract_data.Listing_info>();
				for (int num2 = list.Count - 1; num2 >= 0; num2--)
				{
					list4.Add(list[num2]);
				}
				list = list4;
			}
			int num3 = 0;
			int num4 = DateTime.Now.Hour;
			foreach (extract_data.Listing_info listing in list)
			{
				string listing_sub_name = listing.listing_name;
				string status = "";
				try
				{
					link = "https://poshmark.com/vm-rest/users/self/shared_posts/" + listing.listing_link;
					if (party)
					{
						int hour = DateTime.Now.Hour;
						if (hour != num4)
						{
							try
							{
								string text3 = Form1.ed.get_party_requirements(Form1.ck, text);
								dynamic val8 = val.Deserialize<object>(text3);
								if (!((val8["$_party"]["eventInfo"]["data"]["current_status"].ToString() == "ongoing") ? true : false))
								{
									text = "";
								}
							}
							catch
							{
							}
							num4 = hour;
						}
						if (text != "" && listing.listing_name.Contains("Party"))
						{
							link = link + "?event_ids=" + text;
						}
					}
					string text4 = "";
					try
					{
						text4 = Form1.ed.return_html_straight_put(link, Form1.ck, ref token);
						if (text4.Contains(">Page not found - Poshmark<"))
						{
							val3 = (MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Page Not found ---> " + link + "\r\n");
							};
							((Control)this).Invoke((Delegate)(object)val3);
							continue;
						}
						dynamic val9 = val.Deserialize<object>(text4);
						if (val9.Count == 1)
						{
							val3 = (MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("-successfully shared: " + listing.listing_name + "\r\n");
							};
							((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
							successfully__shares_done++;
						}
						else
						{
							res = val9["error"]["errorType"].ToString();
							if (res == "SuspectedBotError")
							{
								status = "Captcha in Share";
							}
							else if (res.Contains("SharePostRequestLimitExceededError"))
							{
								status = text4;
								if (num3 > 10)
								{
									val3 = (MethodInvoker)delegate
									{
										((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("-unsucc sh: -----(HIGH)-The USER is Blocked From SHARING-----Response: " + res + "\r\n");
									};
									((Control)this).Invoke((Delegate)(object)val3);
									int num5 = Form1.ed.delay_value_getter("3600,7200");
									Thread.Sleep(num5 * 1000);
								}
								if (num3 > 5)
								{
									val3 = (MethodInvoker)delegate
									{
										((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("-unsucc sh: ------(MEDIUM)-The USER is Blocked From SHARING-----Response: " + res + "\r\n");
									};
									((Control)this).Invoke((Delegate)(object)val3);
									int num6 = Form1.ed.delay_value_getter("1800,3600");
									Thread.Sleep(num6 * 1000);
								}
								else
								{
									val3 = (MethodInvoker)delegate
									{
										((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("-unsucc sh: ------(LOW)-The USER is Blocked From SHARING-----Response: " + res + "\r\n");
									};
									((Control)this).Invoke((Delegate)(object)val3);
									int num7 = Form1.ed.delay_value_getter("300,900");
									Thread.Sleep(num7 * 1000);
								}
								num3++;
							}
							else
							{
								status = text4;
								if (text4.Contains(">You are being <a"))
								{
									if (text4.Contains(">redirected<"))
									{
										object obj10 = _003C_003Ec._003C_003E9__7_9;
										if (obj10 == null)
										{
											MethodInvoker val10 = delegate
											{
												((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Sorry, You're logged out. Login Again <--\r\n");
											};
											obj10 = (object)val10;
											_003C_003Ec._003C_003E9__7_9 = val10;
										}
										val3 = (MethodInvoker)obj10;
										((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
										break;
									}
								}
								else if (text4.Contains("false") && text4.Contains("Sorry, You're logged out."))
								{
									object obj11 = _003C_003Ec._003C_003E9__7_10;
									if (obj11 == null)
									{
										MethodInvoker val11 = delegate
										{
											((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Sorry, You're logged out. Login Again\r\n");
										};
										obj11 = (object)val11;
										_003C_003Ec._003C_003E9__7_10 = val11;
									}
									val3 = (MethodInvoker)obj11;
									((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
									break;
								}
							}
							if (party)
							{
								if (text != "")
								{
									val3 = (MethodInvoker)delegate
									{
										((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("-unsucc sh: " + listing_sub_name + "Response: Item doesnot meet party Requirements\r\n");
									};
									((Control)this).Invoke((Delegate)(object)val3);
								}
							}
							else
							{
								val3 = (MethodInvoker)delegate
								{
									((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("-unsucc sh: " + listing_sub_name + "Response: " + status + "\r\n");
								};
								((Control)this).Invoke((Delegate)(object)val3);
							}
						}
						share_performed++;
						MethodInvoker obj12 = val12;
						if (obj12 == null)
						{
							MethodInvoker val13 = delegate
							{
								((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Share Stats: Successfully shared " + successfully__shares_done + " - Total Shared Attempts: " + share_performed + " - Loop " + cur_loop + "\r\n");
							};
							MethodInvoker val7 = val13;
							val12 = val13;
							obj12 = val7;
						}
						val3 = obj12;
						((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
						int num8 = Form1.ed.delay_value_getter(delay_in_share);
						Thread.Sleep(num8 * 1000);
						if (!((CheckBox)share_listings_who_shared_my_listings_checkBox6).get_Checked() && !((CheckBox)new_posher_metroCheckBox1).get_Checked() && int.Parse(shares_required) <= successfully__shares_done)
						{
							break;
						}
						if (successfully__shares_done % 15 == 0)
						{
							try
							{
								if (((CheckBox)Form1.pro_configuration_class.delay_protection_checkBox1).get_Checked())
								{
									object obj13 = _003C_003Ec._003C_003E9__7_14;
									if (obj13 == null)
									{
										MethodInvoker val14 = delegate
										{
											((TextBoxBase)Form1.mainform.status_textBox1).AppendText("App in Sleep for 30 seconds to avoid from being blocked" + DateTime.Now.ToString() + "\r\n");
										};
										obj13 = (object)val14;
										_003C_003Ec._003C_003E9__7_14 = val14;
									}
									val3 = (MethodInvoker)obj13;
									((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
									Thread.Sleep(30000);
								}
							}
							catch
							{
							}
						}
						if (successfully__shares_done % 50 != 0)
						{
							continue;
						}
						try
						{
							if (!((CheckBox)Form1.pro_configuration_class.delay_protection_checkBox1).get_Checked())
							{
								continue;
							}
							object obj15 = _003C_003Ec._003C_003E9__7_15;
							if (obj15 == null)
							{
								MethodInvoker val15 = delegate
								{
									((TextBoxBase)Form1.mainform.status_textBox1).AppendText("App in Sleep for 2 minute to avoid from being blocked " + DateTime.Now.ToString() + "\r\n");
								};
								obj15 = (object)val15;
								_003C_003Ec._003C_003E9__7_15 = val15;
							}
							val3 = (MethodInvoker)obj15;
							((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
							Thread.Sleep(120000);
						}
						catch
						{
						}
					}
					catch (Exception)
					{
					}
				}
				catch
				{
				}
			}
			total_successfully_shares_done += successfully__shares_done;
			cur_loop++;
			int delay_2 = Form1.ed.delay_value_getter(delay_after_loop);
			val3 = (MethodInvoker)delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Loop Delay: App in Sleep for " + delay_2 + " seconds \r\n");
			};
			((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(object)val3);
			Thread.Sleep(delay_2 * 1000);
		}
		((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Share Stats:\r\nShares Attempted: " + share_performed + "\r\nSuccessfully Shared: " + total_successfully_shares_done);
		});
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj18 = _003C_003Ec._003C_003E9__7_18;
		if (obj18 == null)
		{
			MethodInvoker val16 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nShare Completed\r\n");
			};
			obj18 = (object)val16;
			_003C_003Ec._003C_003E9__7_18 = val16;
		}
		((Control)status_textBox).Invoke((Delegate)obj18);
	}

	public void follow_the_people(string closet_name, string delay_in_follow, string follows_required, string follow_unfollow, bool follower_following)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0352: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		object obj = _003C_003Ec._003C_003E9__8_0;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Initializing Follow/Unfollow\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__8_0 = val;
		}
		MethodInvoker val2 = (MethodInvoker)obj;
		((Control)this).Invoke((Delegate)(object)val2);
		object obj2 = _003C_003Ec._003C_003E9__8_1;
		if (obj2 == null)
		{
			MethodInvoker val3 = delegate
			{
				((Control)Form1.mainform.Log_textBox1).set_Text("");
			};
			obj2 = (object)val3;
			_003C_003Ec._003C_003E9__8_1 = val3;
		}
		val2 = (MethodInvoker)obj2;
		((Control)this).Invoke((Delegate)(object)val2);
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
		List<string> list = Form1.ed.get_profiles_based_on_closet(follows_required, closet_name, ref token, ref Form1.ck, follow_unfollow, follower_following);
		object obj4 = _003C_003Ec._003C_003E9__8_3;
		if (obj4 == null)
		{
			MethodInvoker val4 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Going For Follow/Unfollow profiles \r\n");
			};
			obj4 = (object)val4;
			_003C_003Ec._003C_003E9__8_3 = val4;
		}
		val2 = (MethodInvoker)obj4;
		((Control)this).Invoke((Delegate)(object)val2);
		string text = Form1.ed.return_login_uid(Form1.ck);
		if (text != "")
		{
			int num = 0;
			MethodInvoker val6 = default(MethodInvoker);
			foreach (string item in list)
			{
				string _profile_name = Regex.Split(item, "------")[0];
				string status = "";
				try
				{
					if (Form1.ed.follow_these_leads(item, ref token, ref Form1.ck, ref status, follow_unfollow, text))
					{
						if (((CheckBox)follow_pro_tools_checkBox1).get_Checked() || follow_unfollow == "true")
						{
							((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("successfully followed: " + _profile_name + "\r\n");
							});
						}
						else
						{
							((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("successfully unfollowed: " + _profile_name + "\r\n");
							});
						}
						total_follow_done++;
					}
					else
					{
						if (status.Contains("RateLimitExceeded"))
						{
							val2 = (MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("-unsucc sh: ------(MEDIUM)-The USER is Blocked From Following/Unfollowing-----Response: " + status + "\r\n");
							};
							((Control)this).Invoke((Delegate)(object)val2);
							int num2 = Form1.ed.delay_value_getter("1800,3600");
							Thread.Sleep(num2 * 1000);
							((CheckBox)Form1.pro_configuration_class.delay_protection_checkBox1).set_Checked(true);
							num++;
						}
						if (num > 3)
						{
							object obj5 = _003C_003Ec._003C_003E9__8_7;
							if (obj5 == null)
							{
								MethodInvoker val5 = delegate
								{
									((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("---Stopped Following/Unfollowing: Reason Poshmark blocked user for further following/unfollowing\r\n");
								};
								obj5 = (object)val5;
								_003C_003Ec._003C_003E9__8_7 = val5;
							}
							val2 = (MethodInvoker)obj5;
							((Control)this).Invoke((Delegate)(object)val2);
							break;
						}
						if (((CheckBox)follow_pro_tools_checkBox1).get_Checked() || follow_unfollow == "true")
						{
							((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("unsuccessfully followed: " + _profile_name + " Reason " + status + "\r\n");
							});
						}
						else
						{
							((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("unsuccessfully unfollowed: " + _profile_name + " Reason " + status + "\r\n");
							});
						}
					}
				}
				catch
				{
				}
				follow_performed++;
				MethodInvoker obj7 = val6;
				if (obj7 == null)
				{
					MethodInvoker val7 = delegate
					{
						((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Follow/Unfollow Stats: Total Followed/Unfollowed " + total_follow_done + "\r\nTotal follow/unfollow Attempts: " + follow_performed + "\r\n");
					};
					MethodInvoker val8 = val7;
					val6 = val7;
					obj7 = val8;
				}
				val2 = obj7;
				((Control)this).Invoke((Delegate)(object)val2);
				if (total_follow_done >= int.Parse(follows_required))
				{
					break;
				}
				int num3 = Form1.ed.delay_value_getter(delay_in_follow);
				if (((CheckBox)Form1.pro_configuration_class.delay_protection_checkBox1).get_Checked() && follow_performed % 15 == 0)
				{
					object obj8 = _003C_003Ec._003C_003E9__8_11;
					if (obj8 == null)
					{
						MethodInvoker val9 = delegate
						{
							((TextBoxBase)Form1.mainform.status_textBox1).AppendText("App in Sleep for 15 seconds to avoid from captcha\r\n");
						};
						obj8 = (object)val9;
						_003C_003Ec._003C_003E9__8_11 = val9;
					}
					val2 = (MethodInvoker)obj8;
					((Control)this).Invoke((Delegate)(object)val2);
					Thread.Sleep(15000);
				}
				Thread.Sleep(num3 * 1000);
			}
		}
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj9 = _003C_003Ec._003C_003E9__8_12;
		if (obj9 == null)
		{
			MethodInvoker val10 = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Follow/Unfollow Completed\r\n");
			};
			obj9 = (object)val10;
			_003C_003Ec._003C_003E9__8_12 = val10;
		}
		((Control)status_textBox).Invoke((Delegate)obj9);
	}

	private void delay_share_textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

	private void Closet_name_textbox_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
	}

	private void share_my_feed_checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		MetroCheckBox metroCheckBox = sender as MetroCheckBox;
		foreach (Control item in (ArrangedElementCollection)((Control)metroTabPage1).get_Controls())
		{
			Control val = item;
			if (!(val is MetroCheckBox))
			{
				continue;
			}
			MetroCheckBox metroCheckBox2 = (MetroCheckBox)(object)val;
			if (!(((Control)metroCheckBox2).get_Text() == "Share To Party") && !(((Control)metroCheckBox2).get_Text() == "Share My Closet In Reverse"))
			{
				if (!(((Control)metroCheckBox).get_Text() == val.get_Text()) && ((CheckBox)metroCheckBox).get_Checked())
				{
					((CheckBox)metroCheckBox2).set_Checked(false);
				}
				if (((Control)metroCheckBox).get_Text() == "Share Specific Listings From My Closet")
				{
					((Control)share_listings_with_keywords_textBox5).set_Enabled(true);
				}
				else
				{
					((Control)share_listings_with_keywords_textBox5).set_Enabled(false);
				}
				if (((Control)metroCheckBox).get_Text() == "Share back the last [X] closets who shared my listings, and share back [X] of their listings each." || ((Control)metroCheckBox).get_Text() == "Share [X] New Posher [X] Listings")
				{
					((Control)shared_listings_who_shared_my_listings_textBox6).set_Enabled(true);
					((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Enabled(true);
				}
				else
				{
					((Control)shared_listings_who_shared_my_listings_textBox6).set_Enabled(false);
					((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Enabled(false);
				}
			}
		}
		if (((Control)metroCheckBox).get_Text() == "Share My Available Items (This will fetch all your closet items automatically)" && ((CheckBox)metroCheckBox).get_Checked())
		{
			((Control)share_item_textBox6).set_Enabled(false);
			((Control)share_item_textBox6).set_Text("9999");
		}
		else
		{
			((Control)share_item_textBox6).set_Enabled(true);
			((Control)share_item_textBox6).set_Text("999");
		}
		bool flag = true;
		foreach (Control item2 in (ArrangedElementCollection)((Control)metroTabPage1).get_Controls())
		{
			Control val2 = item2;
			if (val2 is MetroCheckBox)
			{
				MetroCheckBox metroCheckBox3 = (MetroCheckBox)(object)val2;
				if (!(((Control)metroCheckBox3).get_Text() == "Share To Party") && !(((Control)metroCheckBox3).get_Text() == "Share My Closet In Reverse") && ((CheckBox)metroCheckBox3).get_Checked())
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			((Control)Closet_name_textbox).set_Enabled(true);
		}
		else
		{
			((Control)Closet_name_textbox).set_Enabled(false);
		}
	}

	private void delay_follow_textBox5_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
	}

	private void unfollow_pro_tools_checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		MetroCheckBox metroCheckBox = sender as MetroCheckBox;
		foreach (Control item in (ArrangedElementCollection)((Control)metroTabPage2).get_Controls())
		{
			Control val = item;
			if (val is MetroCheckBox)
			{
				MetroCheckBox metroCheckBox2 = (MetroCheckBox)(object)val;
				if (!(((Control)metroCheckBox).get_Text() == val.get_Text()) && ((CheckBox)metroCheckBox).get_Checked())
				{
					((CheckBox)metroCheckBox2).set_Checked(false);
				}
			}
		}
	}

	private void metroLabel7_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/watch?v=xMXWDLp1Xxk");
	}

	private void Closet_name_textbox_Leave(object sender, EventArgs e)
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected O, but got Unknown
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected O, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected O, but got Unknown
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6f: Expected O, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected O, but got Unknown
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2e: Expected O, but got Unknown
		//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_136b: Expected O, but got Unknown
		//IL_13a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_143a: Expected O, but got Unknown
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1506: Expected O, but got Unknown
		//IL_153e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d2: Expected O, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d7: Expected O, but got Unknown
		//IL_16fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1842: Unknown result type (might be due to invalid IL or missing references)
		//IL_18db: Unknown result type (might be due to invalid IL or missing references)
		//IL_1960: Unknown result type (might be due to invalid IL or missing references)
		//IL_196a: Expected O, but got Unknown
		//IL_198b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a52: Expected O, but got Unknown
		//IL_1a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbe: Expected O, but got Unknown
		//IL_1be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d13: Expected O, but got Unknown
		//IL_1d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2057: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2183: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f6: Unknown result type (might be due to invalid IL or missing references)
		metroTabControl1 = new MetroTabControl();
		metroTabPage1 = new MetroTabPage();
		partyback_share_metroCheckBox1 = new MetroCheckBox();
		new_posher_metroCheckBox1 = new MetroCheckBox();
		metroLabel7 = new MetroLabel();
		shared_listings_quantity_who_shared_my_listings_textBox6textBox2 = new MetroTextBox();
		shared_listings_who_shared_my_listings_textBox6 = new MetroTextBox();
		share_listings_with_keywords_textBox5 = new MetroTextBox();
		share_listings_who_shared_my_listings_checkBox6 = new MetroCheckBox();
		share_listings_with_keywords_checkBox5 = new MetroCheckBox();
		share_party_checkBox4 = new MetroCheckBox();
		reverse_share_checkBox3 = new MetroCheckBox();
		share_my_available_checkBox2 = new MetroCheckBox();
		share_my_feed_checkBox1 = new MetroCheckBox();
		metroLabel5 = new MetroLabel();
		metroLabel4 = new MetroLabel();
		metroLabel3 = new MetroLabel();
		metroLabel2 = new MetroLabel();
		metroLabel1 = new MetroLabel();
		delay_share_textBox7 = new MetroTextBox();
		delayLoop_textBox8 = new MetroTextBox();
		share_item_textBox6 = new MetroTextBox();
		shareloop_TextBox5 = new MetroTextBox();
		Closet_name_textbox = new MetroTextBox();
		label1 = new Label();
		metroTabPage2 = new MetroTabPage();
		metroLabel6 = new MetroLabel();
		unfollow_pro_tools_checkBox2 = new MetroCheckBox();
		follow_pro_tools_checkBox1 = new MetroCheckBox();
		quantity_follow_textBox6 = new MetroTextBox();
		label13 = new MetroLabel();
		delay_follow_textBox5 = new MetroTextBox();
		label12 = new MetroLabel();
		closet_name_follow_textBox1 = new MetroTextBox();
		label11 = new MetroLabel();
		metroTabPage3 = new MetroTabPage();
		share_multi_closet_data_load_button1 = new MetroButton();
		share_multi_closet_data_save_button1 = new MetroButton();
		label25 = new MetroLabel();
		share_gridview = new DataGridView();
		((Control)metroTabControl1).SuspendLayout();
		((Control)metroTabPage1).SuspendLayout();
		((Control)metroTabPage2).SuspendLayout();
		((Control)metroTabPage3).SuspendLayout();
		((ISupportInitialize)share_gridview).BeginInit();
		((Control)this).SuspendLayout();
		((Control)metroTabControl1).get_Controls().Add((Control)(object)metroTabPage1);
		((Control)metroTabControl1).get_Controls().Add((Control)(object)metroTabPage2);
		((Control)metroTabControl1).get_Controls().Add((Control)(object)metroTabPage3);
		((Control)metroTabControl1).set_Dock((DockStyle)5);
		metroTabControl1.FontWeight = MetroTabControlWeight.Bold;
		((Control)metroTabControl1).set_Location(new Point(0, 0));
		((Control)metroTabControl1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)metroTabControl1).set_Name("metroTabControl1");
		((TabControl)metroTabControl1).set_SelectedIndex(0);
		((Control)metroTabControl1).set_Size(new Size(1012, 568));
		metroTabControl1.Style = MetroColorStyle.Red;
		((Control)metroTabControl1).set_TabIndex(0);
		metroTabControl1.UseStyleColors = true;
		((Control)metroTabPage1).get_Controls().Add((Control)(object)partyback_share_metroCheckBox1);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)new_posher_metroCheckBox1);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroLabel7);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)shared_listings_quantity_who_shared_my_listings_textBox6textBox2);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)shared_listings_who_shared_my_listings_textBox6);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)share_listings_with_keywords_textBox5);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)share_listings_who_shared_my_listings_checkBox6);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)share_listings_with_keywords_checkBox5);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)share_party_checkBox4);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)reverse_share_checkBox3);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)share_my_available_checkBox2);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)share_my_feed_checkBox1);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroLabel5);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroLabel4);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroLabel3);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroLabel2);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)metroLabel1);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)delay_share_textBox7);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)delayLoop_textBox8);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)share_item_textBox6);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)shareloop_TextBox5);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)Closet_name_textbox);
		((Control)metroTabPage1).get_Controls().Add((Control)(object)label1);
		metroTabPage1.HorizontalScrollbarBarColor = true;
		metroTabPage1.HorizontalScrollbarSize = 15;
		((TabPage)metroTabPage1).set_Location(new Point(4, 39));
		((Control)metroTabPage1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)metroTabPage1).set_Name("metroTabPage1");
		((Control)metroTabPage1).set_Size(new Size(1004, 525));
		metroTabPage1.Style = MetroColorStyle.Brown;
		((TabPage)metroTabPage1).set_TabIndex(0);
		((Control)metroTabPage1).set_Text("Share Closet");
		metroTabPage1.VerticalScrollbarBarColor = true;
		metroTabPage1.VerticalScrollbarSize = 15;
		((Control)partyback_share_metroCheckBox1).set_AutoSize(true);
		((Control)partyback_share_metroCheckBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)partyback_share_metroCheckBox1).set_Location(new Point(4, 443));
		((Control)partyback_share_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)partyback_share_metroCheckBox1).set_Name("partyback_share_metroCheckBox1");
		((Control)partyback_share_metroCheckBox1).set_Size(new Size(184, 15));
		partyback_share_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)partyback_share_metroCheckBox1).set_TabIndex(98);
		((Control)partyback_share_metroCheckBox1).set_Text("Share Back Listings From Party");
		partyback_share_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)partyback_share_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)partyback_share_metroCheckBox1).add_CheckedChanged((EventHandler)share_my_feed_checkBox1_CheckedChanged);
		((Control)partyback_share_metroCheckBox1).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)new_posher_metroCheckBox1).set_AutoSize(true);
		((Control)new_posher_metroCheckBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)new_posher_metroCheckBox1).set_Location(new Point(4, 411));
		((Control)new_posher_metroCheckBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)new_posher_metroCheckBox1).set_Name("new_posher_metroCheckBox1");
		((Control)new_posher_metroCheckBox1).set_Size(new Size(197, 15));
		new_posher_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)new_posher_metroCheckBox1).set_TabIndex(96);
		((Control)new_posher_metroCheckBox1).set_Text("Share [X] New Posher [X] Listings");
		new_posher_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)new_posher_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)new_posher_metroCheckBox1).add_CheckedChanged((EventHandler)share_my_feed_checkBox1_CheckedChanged);
		((Control)new_posher_metroCheckBox1).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)metroLabel7).set_AutoSize(true);
		((Control)metroLabel7).set_Cursor(Cursors.get_Hand());
		((Control)metroLabel7).set_Location(new Point(604, 22));
		((Control)metroLabel7).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel7).set_Name("metroLabel7");
		((Control)metroLabel7).set_Size(new Size(215, 19));
		metroLabel7.Style = MetroColorStyle.Brown;
		((Control)metroLabel7).set_TabIndex(95);
		((Control)metroLabel7).set_Text("How to use the Share module here.");
		metroLabel7.UseStyleColors = true;
		((Control)metroLabel7).add_Click((EventHandler)metroLabel7_Click);
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Enabled(false);
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_ForeColor(Color.LightGray);
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Location(new Point(882, 403));
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Name("shared_listings_quantity_who_shared_my_listings_textBox6textBox2");
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Size(new Size(64, 31));
		shared_listings_quantity_who_shared_my_listings_textBox6textBox2.Style = MetroColorStyle.Brown;
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_TabIndex(94);
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).set_Text("5");
		shared_listings_quantity_who_shared_my_listings_textBox6textBox2.UseStyleColors = true;
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)shared_listings_quantity_who_shared_my_listings_textBox6textBox2).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)shared_listings_who_shared_my_listings_textBox6).set_Enabled(false);
		((Control)shared_listings_who_shared_my_listings_textBox6).set_ForeColor(Color.LightGray);
		((Control)shared_listings_who_shared_my_listings_textBox6).set_Location(new Point(808, 403));
		((Control)shared_listings_who_shared_my_listings_textBox6).set_Margin(new Padding(4, 5, 4, 5));
		((Control)shared_listings_who_shared_my_listings_textBox6).set_Name("shared_listings_who_shared_my_listings_textBox6");
		((Control)shared_listings_who_shared_my_listings_textBox6).set_Size(new Size(64, 31));
		shared_listings_who_shared_my_listings_textBox6.Style = MetroColorStyle.Brown;
		((Control)shared_listings_who_shared_my_listings_textBox6).set_TabIndex(93);
		((Control)shared_listings_who_shared_my_listings_textBox6).set_Text("2");
		shared_listings_who_shared_my_listings_textBox6.UseStyleColors = true;
		((Control)shared_listings_who_shared_my_listings_textBox6).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)shared_listings_who_shared_my_listings_textBox6).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)shared_listings_who_shared_my_listings_textBox6).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)share_listings_with_keywords_textBox5).set_Enabled(false);
		((Control)share_listings_with_keywords_textBox5).set_ForeColor(Color.LightGray);
		((Control)share_listings_with_keywords_textBox5).set_Location(new Point(357, 346));
		((Control)share_listings_with_keywords_textBox5).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_listings_with_keywords_textBox5).set_Name("share_listings_with_keywords_textBox5");
		((Control)share_listings_with_keywords_textBox5).set_Size(new Size(478, 31));
		share_listings_with_keywords_textBox5.Style = MetroColorStyle.Brown;
		((Control)share_listings_with_keywords_textBox5).set_TabIndex(92);
		((Control)share_listings_with_keywords_textBox5).set_Text("Michael Kors, Handbag, Bag, Tote (Comma Seperated)");
		share_listings_with_keywords_textBox5.UseStyleColors = true;
		((Control)share_listings_with_keywords_textBox5).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)share_listings_with_keywords_textBox5).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)share_listings_who_shared_my_listings_checkBox6).set_AutoSize(true);
		((Control)share_listings_who_shared_my_listings_checkBox6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)share_listings_who_shared_my_listings_checkBox6).set_Location(new Point(4, 378));
		((Control)share_listings_who_shared_my_listings_checkBox6).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_listings_who_shared_my_listings_checkBox6).set_Name("share_listings_who_shared_my_listings_checkBox6");
		((Control)share_listings_who_shared_my_listings_checkBox6).set_Size(new Size(517, 15));
		share_listings_who_shared_my_listings_checkBox6.Style = MetroColorStyle.Brown;
		((Control)share_listings_who_shared_my_listings_checkBox6).set_TabIndex(91);
		((Control)share_listings_who_shared_my_listings_checkBox6).set_Text("Share back the last [X] closets who shared my listings, and share back [X] of their listings each.");
		share_listings_who_shared_my_listings_checkBox6.UseStyleColors = true;
		((ButtonBase)share_listings_who_shared_my_listings_checkBox6).set_UseVisualStyleBackColor(true);
		((CheckBox)share_listings_who_shared_my_listings_checkBox6).add_CheckedChanged((EventHandler)share_my_feed_checkBox1_CheckedChanged);
		((Control)share_listings_who_shared_my_listings_checkBox6).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)share_listings_with_keywords_checkBox5).set_AutoSize(true);
		((Control)share_listings_with_keywords_checkBox5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)share_listings_with_keywords_checkBox5).set_Location(new Point(4, 346));
		((Control)share_listings_with_keywords_checkBox5).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_listings_with_keywords_checkBox5).set_Name("share_listings_with_keywords_checkBox5");
		((Control)share_listings_with_keywords_checkBox5).set_Size(new Size(226, 15));
		share_listings_with_keywords_checkBox5.Style = MetroColorStyle.Brown;
		((Control)share_listings_with_keywords_checkBox5).set_TabIndex(90);
		((Control)share_listings_with_keywords_checkBox5).set_Text("Share Specific Listings From My Closet");
		share_listings_with_keywords_checkBox5.UseStyleColors = true;
		((ButtonBase)share_listings_with_keywords_checkBox5).set_UseVisualStyleBackColor(true);
		((CheckBox)share_listings_with_keywords_checkBox5).add_CheckedChanged((EventHandler)share_my_feed_checkBox1_CheckedChanged);
		((Control)share_listings_with_keywords_checkBox5).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)share_party_checkBox4).set_AutoSize(true);
		((Control)share_party_checkBox4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)share_party_checkBox4).set_Location(new Point(4, 249));
		((Control)share_party_checkBox4).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_party_checkBox4).set_Name("share_party_checkBox4");
		((Control)share_party_checkBox4).set_Size(new Size(97, 15));
		share_party_checkBox4.Style = MetroColorStyle.Brown;
		((Control)share_party_checkBox4).set_TabIndex(89);
		((Control)share_party_checkBox4).set_Text("Share To Party");
		share_party_checkBox4.UseStyleColors = true;
		((ButtonBase)share_party_checkBox4).set_UseVisualStyleBackColor(true);
		((Control)share_party_checkBox4).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)reverse_share_checkBox3).set_AutoSize(true);
		((Control)reverse_share_checkBox3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)reverse_share_checkBox3).set_Location(new Point(288, 249));
		((Control)reverse_share_checkBox3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)reverse_share_checkBox3).set_Name("reverse_share_checkBox3");
		((Control)reverse_share_checkBox3).set_Size(new Size(164, 15));
		reverse_share_checkBox3.Style = MetroColorStyle.Brown;
		((Control)reverse_share_checkBox3).set_TabIndex(88);
		((Control)reverse_share_checkBox3).set_Text("Share My Closet In Reverse");
		reverse_share_checkBox3.UseStyleColors = true;
		((ButtonBase)reverse_share_checkBox3).set_UseVisualStyleBackColor(true);
		((Control)reverse_share_checkBox3).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)share_my_available_checkBox2).set_AutoSize(true);
		((Control)share_my_available_checkBox2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)share_my_available_checkBox2).set_Location(new Point(4, 314));
		((Control)share_my_available_checkBox2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_my_available_checkBox2).set_Name("share_my_available_checkBox2");
		((Control)share_my_available_checkBox2).set_Size(new Size(421, 15));
		share_my_available_checkBox2.Style = MetroColorStyle.Brown;
		((Control)share_my_available_checkBox2).set_TabIndex(87);
		((Control)share_my_available_checkBox2).set_Text("Share My Available Items (This will fetch all your closet items automatically)");
		share_my_available_checkBox2.UseStyleColors = true;
		((ButtonBase)share_my_available_checkBox2).set_UseVisualStyleBackColor(true);
		((CheckBox)share_my_available_checkBox2).add_CheckedChanged((EventHandler)share_my_feed_checkBox1_CheckedChanged);
		((Control)share_my_available_checkBox2).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)share_my_feed_checkBox1).set_AutoSize(true);
		((Control)share_my_feed_checkBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)share_my_feed_checkBox1).set_Location(new Point(4, 282));
		((Control)share_my_feed_checkBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_my_feed_checkBox1).set_Name("share_my_feed_checkBox1");
		((Control)share_my_feed_checkBox1).set_Size(new Size(193, 15));
		share_my_feed_checkBox1.Style = MetroColorStyle.Brown;
		((Control)share_my_feed_checkBox1).set_TabIndex(86);
		((Control)share_my_feed_checkBox1).set_Text("Share My Feed (1000 Items Max)");
		share_my_feed_checkBox1.UseStyleColors = true;
		((ButtonBase)share_my_feed_checkBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)share_my_feed_checkBox1).add_CheckedChanged((EventHandler)share_my_feed_checkBox1_CheckedChanged);
		((Control)share_my_feed_checkBox1).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)metroLabel5).set_AutoSize(true);
		((Control)metroLabel5).set_Location(new Point(4, 202));
		((Control)metroLabel5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel5).set_Name("metroLabel5");
		((Control)metroLabel5).set_Size(new Size(97, 19));
		metroLabel5.Style = MetroColorStyle.Brown;
		((Control)metroLabel5).set_TabIndex(85);
		((Control)metroLabel5).set_Text("Delay in listings");
		metroLabel5.UseStyleColors = true;
		((Control)metroLabel4).set_AutoSize(true);
		((Control)metroLabel4).set_Location(new Point(4, 157));
		((Control)metroLabel4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel4).set_Name("metroLabel4");
		((Control)metroLabel4).set_Size(new Size(108, 19));
		metroLabel4.Style = MetroColorStyle.Brown;
		((Control)metroLabel4).set_TabIndex(84);
		((Control)metroLabel4).set_Text("Delay after loops");
		metroLabel4.UseStyleColors = true;
		((Control)metroLabel3).set_AutoSize(true);
		((Control)metroLabel3).set_Location(new Point(4, 112));
		((Control)metroLabel3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel3).set_Name("metroLabel3");
		((Control)metroLabel3).set_Size(new Size(119, 19));
		metroLabel3.Style = MetroColorStyle.Brown;
		((Control)metroLabel3).set_TabIndex(83);
		((Control)metroLabel3).set_Text("Quantity of Listings");
		metroLabel3.UseStyleColors = true;
		((Control)metroLabel2).set_AutoSize(true);
		((Control)metroLabel2).set_Location(new Point(4, 68));
		((Control)metroLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel2).set_Name("metroLabel2");
		((Control)metroLabel2).set_Size(new Size(110, 19));
		metroLabel2.Style = MetroColorStyle.Brown;
		((Control)metroLabel2).set_TabIndex(82);
		((Control)metroLabel2).set_Text("Quantity of loops");
		metroLabel2.UseStyleColors = true;
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_Location(new Point(4, 22));
		((Control)metroLabel1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(143, 19));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(81);
		((Control)metroLabel1).set_Text("Poshmark Closet name");
		metroLabel1.UseStyleColors = true;
		((Control)delay_share_textBox7).set_Location(new Point(291, 195));
		((Control)delay_share_textBox7).set_Margin(new Padding(4, 5, 4, 5));
		((Control)delay_share_textBox7).set_Name("delay_share_textBox7");
		((Control)delay_share_textBox7).set_Size(new Size(243, 35));
		delay_share_textBox7.Style = MetroColorStyle.Brown;
		((Control)delay_share_textBox7).set_TabIndex(80);
		((Control)delay_share_textBox7).set_Text("6,11");
		delay_share_textBox7.UseStyleColors = true;
		((Control)delay_share_textBox7).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)delay_share_textBox7).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)delay_share_textBox7).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)delayLoop_textBox8).set_Location(new Point(291, 151));
		((Control)delayLoop_textBox8).set_Margin(new Padding(4, 5, 4, 5));
		((Control)delayLoop_textBox8).set_Name("delayLoop_textBox8");
		((Control)delayLoop_textBox8).set_Size(new Size(243, 35));
		delayLoop_textBox8.Style = MetroColorStyle.Brown;
		((Control)delayLoop_textBox8).set_TabIndex(79);
		((Control)delayLoop_textBox8).set_Text("300,720");
		delayLoop_textBox8.UseStyleColors = true;
		((Control)delayLoop_textBox8).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)delayLoop_textBox8).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)delayLoop_textBox8).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)share_item_textBox6).set_Location(new Point(291, 106));
		((Control)share_item_textBox6).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_item_textBox6).set_Name("share_item_textBox6");
		((Control)share_item_textBox6).set_Size(new Size(243, 35));
		share_item_textBox6.Style = MetroColorStyle.Brown;
		((Control)share_item_textBox6).set_TabIndex(78);
		((Control)share_item_textBox6).set_Text("100");
		share_item_textBox6.UseStyleColors = true;
		((Control)share_item_textBox6).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)share_item_textBox6).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)share_item_textBox6).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)shareloop_TextBox5).set_Location(new Point(291, 62));
		((Control)shareloop_TextBox5).set_Margin(new Padding(4, 5, 4, 5));
		((Control)shareloop_TextBox5).set_Name("shareloop_TextBox5");
		((Control)shareloop_TextBox5).set_Size(new Size(243, 35));
		shareloop_TextBox5.Style = MetroColorStyle.Brown;
		((Control)shareloop_TextBox5).set_TabIndex(77);
		((Control)shareloop_TextBox5).set_Text("3");
		shareloop_TextBox5.UseStyleColors = true;
		((Control)shareloop_TextBox5).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)shareloop_TextBox5).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)shareloop_TextBox5).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)Closet_name_textbox).set_Location(new Point(291, 17));
		((Control)Closet_name_textbox).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Closet_name_textbox).set_Name("Closet_name_textbox");
		((Control)Closet_name_textbox).set_Size(new Size(243, 35));
		Closet_name_textbox.Style = MetroColorStyle.Brown;
		((Control)Closet_name_textbox).set_TabIndex(76);
		((Control)Closet_name_textbox).set_Text("closetname");
		Closet_name_textbox.UseStyleColors = true;
		((Control)Closet_name_textbox).add_Click((EventHandler)Closet_name_textbox_Click);
		((Control)Closet_name_textbox).add_Leave((EventHandler)Closet_name_textbox_Leave);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(SystemColors.ButtonHighlight);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(768, 378));
		((Control)label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(42, 58));
		((Control)label1).set_TabIndex(97);
		((Control)label1).set_Text("}");
		((Control)metroTabPage2).get_Controls().Add((Control)(object)metroLabel6);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)unfollow_pro_tools_checkBox2);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)follow_pro_tools_checkBox1);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)quantity_follow_textBox6);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)label13);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)delay_follow_textBox5);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)label12);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)closet_name_follow_textBox1);
		((Control)metroTabPage2).get_Controls().Add((Control)(object)label11);
		metroTabPage2.HorizontalScrollbarBarColor = true;
		metroTabPage2.HorizontalScrollbarSize = 15;
		((TabPage)metroTabPage2).set_Location(new Point(4, 39));
		((Control)metroTabPage2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)metroTabPage2).set_Name("metroTabPage2");
		((Control)metroTabPage2).set_Size(new Size(1004, 525));
		((TabPage)metroTabPage2).set_TabIndex(1);
		((Control)metroTabPage2).set_Text("Follow/ Unfollow Profiles");
		metroTabPage2.VerticalScrollbarBarColor = true;
		metroTabPage2.VerticalScrollbarSize = 15;
		((Control)metroLabel6).set_AutoSize(true);
		((Control)metroLabel6).set_Location(new Point(156, 179));
		((Control)metroLabel6).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel6).set_Name("metroLabel6");
		((Control)metroLabel6).set_Size(new Size(263, 19));
		metroLabel6.Style = MetroColorStyle.Brown;
		((Control)metroLabel6).set_TabIndex(30);
		((Control)metroLabel6).set_Text("Check For Followers/ Ucheck For followings");
		metroLabel6.UseStyleColors = true;
		((Control)unfollow_pro_tools_checkBox2).set_AutoSize(true);
		((Control)unfollow_pro_tools_checkBox2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)unfollow_pro_tools_checkBox2).set_Location(new Point(21, 222));
		((Control)unfollow_pro_tools_checkBox2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)unfollow_pro_tools_checkBox2).set_Name("unfollow_pro_tools_checkBox2");
		((Control)unfollow_pro_tools_checkBox2).set_Size(new Size(114, 15));
		unfollow_pro_tools_checkBox2.Style = MetroColorStyle.Brown;
		((Control)unfollow_pro_tools_checkBox2).set_TabIndex(29);
		((Control)unfollow_pro_tools_checkBox2).set_Text("UnFollow Closets");
		unfollow_pro_tools_checkBox2.UseStyleColors = true;
		((ButtonBase)unfollow_pro_tools_checkBox2).set_UseVisualStyleBackColor(true);
		((CheckBox)unfollow_pro_tools_checkBox2).add_CheckedChanged((EventHandler)unfollow_pro_tools_checkBox2_CheckedChanged);
		((Control)follow_pro_tools_checkBox1).set_AutoSize(true);
		((CheckBox)follow_pro_tools_checkBox1).set_Checked(true);
		((CheckBox)follow_pro_tools_checkBox1).set_CheckState((CheckState)1);
		((Control)follow_pro_tools_checkBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)follow_pro_tools_checkBox1).set_Location(new Point(21, 183));
		((Control)follow_pro_tools_checkBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)follow_pro_tools_checkBox1).set_Name("follow_pro_tools_checkBox1");
		((Control)follow_pro_tools_checkBox1).set_Size(new Size(99, 15));
		follow_pro_tools_checkBox1.Style = MetroColorStyle.Brown;
		((Control)follow_pro_tools_checkBox1).set_TabIndex(28);
		((Control)follow_pro_tools_checkBox1).set_Text("Follow Closets");
		follow_pro_tools_checkBox1.UseStyleColors = true;
		((ButtonBase)follow_pro_tools_checkBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)follow_pro_tools_checkBox1).add_CheckedChanged((EventHandler)unfollow_pro_tools_checkBox2_CheckedChanged);
		((Control)quantity_follow_textBox6).set_ForeColor(Color.LightGray);
		((Control)quantity_follow_textBox6).set_Location(new Point(351, 98));
		((Control)quantity_follow_textBox6).set_Margin(new Padding(4, 5, 4, 5));
		((Control)quantity_follow_textBox6).set_Name("quantity_follow_textBox6");
		((Control)quantity_follow_textBox6).set_Size(new Size(228, 31));
		quantity_follow_textBox6.Style = MetroColorStyle.Brown;
		((Control)quantity_follow_textBox6).set_TabIndex(27);
		((Control)quantity_follow_textBox6).set_Text("300");
		quantity_follow_textBox6.UseStyleColors = true;
		((Control)quantity_follow_textBox6).add_Click((EventHandler)delay_follow_textBox5_Click);
		((Control)quantity_follow_textBox6).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Location(new Point(16, 106));
		((Control)label13).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(192, 19));
		label13.Style = MetroColorStyle.Brown;
		((Control)label13).set_TabIndex(26);
		((Control)label13).set_Text("Quantity of follow and unfollow");
		label13.UseStyleColors = true;
		((Control)delay_follow_textBox5).set_ForeColor(Color.LightGray);
		((Control)delay_follow_textBox5).set_Location(new Point(351, 58));
		((Control)delay_follow_textBox5).set_Margin(new Padding(4, 5, 4, 5));
		((Control)delay_follow_textBox5).set_Name("delay_follow_textBox5");
		((Control)delay_follow_textBox5).set_Size(new Size(228, 31));
		delay_follow_textBox5.Style = MetroColorStyle.Brown;
		((Control)delay_follow_textBox5).set_TabIndex(25);
		((Control)delay_follow_textBox5).set_Text("5,9");
		delay_follow_textBox5.UseStyleColors = true;
		((Control)delay_follow_textBox5).add_Click((EventHandler)delay_follow_textBox5_Click);
		((Control)delay_follow_textBox5).add_KeyPress(new KeyPressEventHandler(delay_share_textBox7_KeyPress));
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Location(new Point(16, 66));
		((Control)label12).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(192, 19));
		label12.Style = MetroColorStyle.Brown;
		((Control)label12).set_TabIndex(24);
		((Control)label12).set_Text("Dealy Between Follow/Unfollow");
		label12.UseStyleColors = true;
		((Control)closet_name_follow_textBox1).set_ForeColor(Color.LightGray);
		((Control)closet_name_follow_textBox1).set_Location(new Point(351, 18));
		((Control)closet_name_follow_textBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)closet_name_follow_textBox1).set_Name("closet_name_follow_textBox1");
		((Control)closet_name_follow_textBox1).set_Size(new Size(228, 31));
		closet_name_follow_textBox1.Style = MetroColorStyle.Brown;
		((Control)closet_name_follow_textBox1).set_TabIndex(23);
		closet_name_follow_textBox1.UseStyleColors = true;
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(16, 26));
		((Control)label11).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(85, 19));
		label11.Style = MetroColorStyle.Brown;
		((Control)label11).set_TabIndex(22);
		((Control)label11).set_Text("Closet Name");
		label11.UseStyleColors = true;
		((Control)metroTabPage3).get_Controls().Add((Control)(object)share_multi_closet_data_load_button1);
		((Control)metroTabPage3).get_Controls().Add((Control)(object)share_multi_closet_data_save_button1);
		((Control)metroTabPage3).get_Controls().Add((Control)(object)label25);
		((Control)metroTabPage3).get_Controls().Add((Control)(object)share_gridview);
		metroTabPage3.HorizontalScrollbarBarColor = true;
		metroTabPage3.HorizontalScrollbarSize = 15;
		((TabPage)metroTabPage3).set_Location(new Point(4, 39));
		((Control)metroTabPage3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)metroTabPage3).set_Name("metroTabPage3");
		((Control)metroTabPage3).set_Size(new Size(1004, 525));
		((TabPage)metroTabPage3).set_TabIndex(2);
		((Control)metroTabPage3).set_Text("Share Multiple Closets");
		metroTabPage3.VerticalScrollbarBarColor = true;
		metroTabPage3.VerticalScrollbarSize = 15;
		((Control)share_multi_closet_data_load_button1).set_Location(new Point(202, 437));
		((Control)share_multi_closet_data_load_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_multi_closet_data_load_button1).set_Name("share_multi_closet_data_load_button1");
		((Control)share_multi_closet_data_load_button1).set_Size(new Size(188, 42));
		((Control)share_multi_closet_data_load_button1).set_TabIndex(82);
		((Control)share_multi_closet_data_load_button1).set_Text("Load Rows");
		((Control)share_multi_closet_data_load_button1).add_Click((EventHandler)share_multi_closet_data_load_button1_Click);
		((Control)share_multi_closet_data_save_button1).set_Location(new Point(6, 437));
		((Control)share_multi_closet_data_save_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_multi_closet_data_save_button1).set_Name("share_multi_closet_data_save_button1");
		((Control)share_multi_closet_data_save_button1).set_Size(new Size(188, 42));
		((Control)share_multi_closet_data_save_button1).set_TabIndex(81);
		((Control)share_multi_closet_data_save_button1).set_Text("Save Rows");
		((Control)share_multi_closet_data_save_button1).add_Click((EventHandler)share_multi_closet_data_save_button1_Click);
		((Control)label25).set_AutoSize(true);
		((Control)label25).set_BackColor(Color.Transparent);
		((Control)label25).set_Location(new Point(8, 3));
		((Control)label25).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(560, 19));
		label25.Style = MetroColorStyle.Brown;
		((Control)label25).set_TabIndex(80);
		((Control)label25).set_Text("Share Multiple Closets (Select rows to share only selected closets, unselect will share all closets )");
		label25.UseStyleColors = true;
		share_gridview.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)share_gridview).set_Location(new Point(4, 32));
		((Control)share_gridview).set_Margin(new Padding(4, 5, 4, 5));
		((Control)share_gridview).set_Name("share_gridview");
		((Control)share_gridview).set_Size(new Size(1062, 400));
		((Control)share_gridview).set_TabIndex(79);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)metroTabControl1);
		((Control)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Pro_tools");
		((Control)this).set_Size(new Size(1012, 568));
		((Control)metroTabControl1).ResumeLayout(false);
		((Control)metroTabPage1).ResumeLayout(false);
		((Control)metroTabPage1).PerformLayout();
		((Control)metroTabPage2).ResumeLayout(false);
		((Control)metroTabPage2).PerformLayout();
		((Control)metroTabPage3).ResumeLayout(false);
		((Control)metroTabPage3).PerformLayout();
		((ISupportInitialize)share_gridview).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
