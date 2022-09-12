using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Poshmark_tools;

namespace WindowsFormsApplication1;

public class Pro_share_follow_schedules : UserControl
{
	public Hashtable HourVsSchdParams;

	private bool load_button_click = false;

	private IContainer components = null;

	private SplitContainer splitContainer3;

	private MetroLabel schedules_help_label;

	private MetroLabel label46;

	private MetroLabel schedule_3rows_plan_label;

	private MetroLabel label34;

	private MetroLabel label29;

	public MetroTextBox schedule_textbox_expiry_date;

	public MetroButton download_csv_schedule_button;

	public MetroButton multicloset_csv_load_button1;

	private MetroButton schedule_template_generation_button1;

	private MetroButton schedule_load_button1;

	public MetroTextBox delay_schedules_textBox2;

	private MetroLabel label42;

	public DataGridView schedule_dataGridView1;

	private MetroLabel metroLabel2;

	public MetroTextBox schedule_random_value_metroTextBox1;

	public MetroCheckBox schedule_random_delay_metroCheckBox1;

	public Pro_share_follow_schedules()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		InitializeComponent();
		HourVsSchdParams = new Hashtable();
		schedule_dataGridView1.add_CellClick(new DataGridViewCellEventHandler(dataGridView1_CellClick));
		schedule_dataGridView1.add_CellValueChanged(new DataGridViewCellEventHandler(dataGridView1_CellValueChanged));
		schedule_dataGridView1.add_CurrentCellDirtyStateChanged((EventHandler)dataGridView1_CurrentCellDirtyStateChanged);
	}

	private void schedule_dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		new DataGridViewCellEventArgs(e.get_ColumnIndex(), e.get_RowIndex());
		if (e.get_RowIndex() >= 0 && e.get_ColumnIndex() == 0)
		{
			DataGridViewCell currentCell = schedule_dataGridView1.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0);
			schedule_dataGridView1.set_CurrentCell(currentCell);
			schedule_dataGridView1.BeginEdit(true);
			Control editingControl = schedule_dataGridView1.get_EditingControl();
			DataGridViewComboBoxEditingControl val = (DataGridViewComboBoxEditingControl)(object)((editingControl is DataGridViewComboBoxEditingControl) ? editingControl : null);
			((ComboBox)val).set_DroppedDown(true);
		}
	}

	public void SaveSchedule()
	{
		try
		{
			if (HourVsSchdParams.Count <= 0)
			{
				return;
			}
			List<EditSchdParameters.SchdParametersStruct> list = new List<EditSchdParameters.SchdParametersStruct>();
			IDictionaryEnumerator enumerator = HourVsSchdParams.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string value = enumerator.Key.ToString();
				if (!string.IsNullOrEmpty(value))
				{
					EditSchdParameters.SchdParametersStruct item = (EditSchdParameters.SchdParametersStruct)enumerator.Value;
					item.last_run_hour = "-1";
					if (item.closet_name != "Closet name /Follow keyword" || item.closet_name != "")
					{
						list.Add(item);
					}
				}
			}
			try
			{
				if (File.Exists(Form1.schedule_save_path))
				{
					File.Delete(Form1.schedule_save_path);
				}
				SaveSchedule(list);
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public void SaveSchedule(List<EditSchdParameters.SchdParametersStruct> schedule_tasks)
	{
		try
		{
			List<string> list = new List<string>();
			foreach (EditSchdParameters.SchdParametersStruct schedule_task in schedule_tasks)
			{
				if (!(schedule_task.hour == "") && schedule_task.hour != null)
				{
					string text = "";
					text = text + schedule_task.type + "#";
					text = text + schedule_task.hour + "#";
					text = text + schedule_task.closet_name + "#";
					text = text + schedule_task.QuantityOfLoops + "#";
					text = text + schedule_task.QuantityOfListings + "#";
					text = text + schedule_task.DelayAfterLoops + "#";
					text = text + schedule_task.DelayInListings + "#";
					text = text + schedule_task.ShareSpecificListingsFromMyCloset + "#";
					text = text + schedule_task.ShareBackLast + "#";
					text = text + schedule_task.ShareNewPosher + "#";
					text = text + schedule_task.DelayBetweenFollow_Unfollow + "#";
					text = text + schedule_task.QuantityOfFollow_Unfollow + "#";
					text = text + schedule_task.Follow_keywords + "#";
					text = text + schedule_task.FollowNextClosetXtoXSec + "#";
					text = text + schedule_task.NumberofClosetsToFollow + "#";
					text = text + schedule_task.KeywordToLike + "#";
					text = text + schedule_task.CountOfLikes + "#";
					text = text + schedule_task.DelayBetweennextLike + "#";
					text = text + schedule_task.KeywordToComment + "#";
					text = text + schedule_task.CountOfComments + "#";
					text = text + schedule_task.DelayBetweennextComment + "#";
					text = ((schedule_task.CommentText != null) ? (text + schedule_task.CommentText.Replace("\r\n", "-----") + "#") : (text + schedule_task.CommentText + "#"));
					string text2 = text;
					bool shareToParty = schedule_task.ShareToParty;
					text = text2 + shareToParty + "#";
					string text3 = text;
					shareToParty = schedule_task.ShareClosetInReverse;
					text = text3 + shareToParty;
					list.Add(text);
				}
			}
			if (list.Count > 0)
			{
				list.Reverse();
				File.WriteAllLines(Form1.schedule_save_path, list);
			}
		}
		catch (Exception)
		{
		}
	}

	public void start_poshmark__scheduler()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		try
		{
			TextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__5_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Starting share Schedule\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__5_0 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			List<EditSchdParameters.SchdParametersStruct> list = new List<EditSchdParameters.SchdParametersStruct>();
			IDictionaryEnumerator enumerator = HourVsSchdParams.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Key.ToString();
				EditSchdParameters.SchdParametersStruct item = (EditSchdParameters.SchdParametersStruct)enumerator.Value;
				item.last_run_hour = "-1";
				if (item.closet_name != "Closet name /Follow keyword" || item.closet_name != "")
				{
					list.Add(item);
				}
			}
			try
			{
				if (File.Exists(Form1.schedule_save_path))
				{
					File.Delete(Form1.schedule_save_path);
				}
				SaveSchedule(list);
			}
			catch
			{
			}
			string text = ((Control)delay_schedules_textBox2).get_Text();
			if (text == "")
			{
				text = "2,8";
			}
			while (true)
			{
				for (int i = 0; i < list.Count; i++)
				{
					EditSchdParameters.SchdParametersStruct sc = list[i];
					string type = sc.type;
					string hour = sc.hour;
					string closet_name = sc.closet_name;
					string text2 = sc.QuantityOfListings;
					string quantityOfLoops = sc.QuantityOfLoops;
					bool shareToParty = sc.ShareToParty;
					bool shareClosetInReverse = sc.ShareClosetInReverse;
					((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
					{
						((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Checking schedule time " + type + " " + hour + " " + closet_name + "\r\nLast Run Hour " + sc.last_run_hour + ", Last run date " + sc.last_run_date + "\r\n");
					});
					if (process_this_row(sc))
					{
						((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Starting schedule " + type + " " + hour + " " + closet_name + "\r\n");
						});
						if (((CheckBox)schedule_random_delay_metroCheckBox1).get_Checked())
						{
							string text3 = ((Control)schedule_random_value_metroTextBox1).get_Text();
							int delay = Form1.ed.delay_value_getter(text3);
							((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.status_textBox1).AppendText("APP will wait for " + delay + "minutes, then start processing\r\n");
							});
							Thread.Sleep(delay * 1000 * 60);
						}
						if (type.ToLower().Contains("share"))
						{
							if (!(type == "Share My Available Items") && !(type == "Share Specific Listings"))
							{
								text2 = ((!(type == "Share Back")) ? sc.QuantityOfListings : "1");
							}
							else
							{
								string text4 = Form1.lg.check_who_is_logined(Form1.ck);
								if (text4 != null)
								{
									closet_name = text4.Substring(text4.LastIndexOf("/") + 1, text4.Length - (text4.LastIndexOf("/") + 1));
									text2 = Form1.ed.get_logined_available_items(Form1.ck);
								}
								else
								{
									MessageBox.Show("Eror101");
								}
							}
							if (closet_name != "" || closet_name != null)
							{
								try
								{
									int.Parse(text2);
									int.Parse(quantityOfLoops);
									text = sc.DelayInListings;
									string delayAfterLoops = sc.DelayAfterLoops;
									if (!(text2 == "") && !(text == "") && !(delayAfterLoops == "") && !(quantityOfLoops == ""))
									{
										Form1.pro_tools_class.share_some_listings_data(closet_name.ToLower(), text2, text, delayAfterLoops, quantityOfLoops, shareToParty, shareClosetInReverse, sc);
									}
								}
								catch (Exception)
								{
								}
								sc.last_run_hour = DateTime.Now.Hour.ToString();
								sc.last_run_date = DateTime.Now.ToString("dd_MM_yyyy");
								list[i] = sc;
							}
						}
						else if (type.ToLower().Contains("follow"))
						{
							try
							{
								if (type == "Follow (keyword based)" || type == "Follow New Poshers" || type == "Follow Back Closets")
								{
									text2 = sc.NumberofClosetsToFollow;
									closet_name = sc.Follow_keywords;
									text = sc.FollowNextClosetXtoXSec;
									Form1.pro_leads_class.follow_the_people_on_keyword(closet_name.ToLower(), text, text2);
								}
								else if (type == "Follow Closet" || type == "UnFollow Closet")
								{
									text2 = sc.QuantityOfFollow_Unfollow;
									closet_name = sc.closet_name;
									text = sc.DelayBetweenFollow_Unfollow;
									string text5 = "--";
									if (type == "Follow Closet")
									{
										text5 = "true";
									}
									else
									{
										text5 = "false";
										string text6 = Form1.lg.check_who_is_logined(Form1.ck);
										if (text6 != null)
										{
											closet_name = text6.Substring(text6.LastIndexOf("/") + 1, text6.Length - (text6.LastIndexOf("/") + 1));
										}
									}
									Form1.pro_tools_class.follow_the_people(closet_name, text, text2, text5, follower_following: true);
								}
							}
							catch (Exception)
							{
							}
							sc.last_run_date = DateTime.Now.ToString("dd_MM_yyyy");
							sc.last_run_hour = DateTime.Now.Hour.ToString();
							list[i] = sc;
						}
						else if (type.ToLower().Contains("like"))
						{
							if (closet_name != "")
							{
								try
								{
									Form1.pro_influencer_class.like_comment_people_profile(sc.KeywordToLike, sc.CountOfLikes, sc.CommentText, comment_it: false, sc.DelayBetweennextLike);
								}
								catch (Exception)
								{
								}
								sc.last_run_date = DateTime.Now.ToString("dd_MM_yyyy");
								sc.last_run_hour = DateTime.Now.Hour.ToString();
								list[i] = sc;
							}
						}
						else if (type.ToLower().Contains("comment"))
						{
							try
							{
								Form1.pro_influencer_class.like_comment_people_profile(sc.KeywordToComment, sc.CountOfLikes, sc.CommentText, comment_it: true, sc.DelayBetweennextLike);
							}
							catch (Exception)
							{
							}
							sc.last_run_date = DateTime.Now.ToString("dd_MM_yyyy");
							sc.last_run_hour = DateTime.Now.Hour.ToString();
							list[i] = sc;
						}
					}
					Thread.Sleep(1000);
				}
				TextBox status_textBox2 = Form1.mainform.status_textBox1;
				object obj3 = _003C_003Ec._003C_003E9__5_4;
				if (obj3 == null)
				{
					MethodInvoker val2 = delegate
					{
						((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Sleep for 2 minute at " + DateTime.Now.ToString() + "\r\n");
					};
					obj3 = (object)val2;
					_003C_003Ec._003C_003E9__5_4 = val2;
				}
				((Control)status_textBox2).Invoke((Delegate)obj3);
				Thread.Sleep(120000);
				TextBox status_textBox3 = Form1.mainform.status_textBox1;
				object obj4 = _003C_003Ec._003C_003E9__5_5;
				if (obj4 == null)
				{
					MethodInvoker val3 = delegate
					{
						((Control)Form1.mainform.status_textBox1).set_Text("");
					};
					obj4 = (object)val3;
					_003C_003Ec._003C_003E9__5_5 = val3;
				}
				((Control)status_textBox3).Invoke((Delegate)obj4);
			}
		}
		catch (Exception ex5)
		{
			if (!ex5.ToString().ToLower().Contains("thread was being aborted"))
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				File.AppendAllText("logs//logs.jk", "91) " + ex5.ToString() + "\r\n");
			}
		}
	}

	private bool process_this_row(EditSchdParameters.SchdParametersStruct sc)
	{
		if (sc.hour == DateTime.Now.Hour.ToString())
		{
			if (DateTime.Now.Hour.ToString() == sc.last_run_hour)
			{
				if (sc.last_run_date == DateTime.Now.ToString("dd_MM_yyyy"))
				{
					return false;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	public void schedule_load_button1_Click(object sender, EventArgs e)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		load_button_click = true;
		schedule_dataGridView1.get_Columns().Clear();
		try
		{
			int.Parse(Form1.schedule_rows);
		}
		catch
		{
			Form1.schedule_rows = "3";
		}
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("Time (hour)");
		DataRow dataRow = null;
		for (int i = 0; i <= int.Parse(Form1.schedule_rows); i++)
		{
			dataRow = dataTable.NewRow();
			dataRow["Time (hour)"] = i + 2;
			dataTable.Rows.Add(dataRow);
		}
		DataGridViewComboBoxColumn val = new DataGridViewComboBoxColumn();
		((DataGridViewColumn)val).set_HeaderText("Type");
		((DataGridViewColumn)val).set_Name("select type");
		val.set_MaxDropDownItems(3);
		val.get_Items().Add((object)"<Clear Schedule>");
		val.get_Items().Add((object)"Share");
		val.get_Items().Add((object)"Feed Share");
		val.get_Items().Add((object)"Follow (keyword based)");
		val.get_Items().Add((object)"Share My Available Items");
		val.get_Items().Add((object)"Share Specific Listings");
		val.get_Items().Add((object)"Share Back");
		val.get_Items().Add((object)"Share New Posher Listings");
		val.get_Items().Add((object)"Share Back from Party");
		val.get_Items().Add((object)"Follow Closet");
		val.get_Items().Add((object)"UnFollow Closet");
		val.get_Items().Add((object)"Follow New Poshers");
		val.get_Items().Add((object)"Follow Back Closets");
		val.get_Items().Add((object)"Like");
		val.get_Items().Add((object)"Comment");
		schedule_dataGridView1.get_Columns().Add((DataGridViewColumn)(object)val);
		schedule_dataGridView1.set_DataSource((object)dataTable);
		for (int j = 0; j < schedule_dataGridView1.get_ColumnCount(); j++)
		{
			((DataGridViewBand)schedule_dataGridView1.get_Columns().get_Item(j)).get_DefaultCellStyle().set_WrapMode((DataGridViewTriState)1);
			schedule_dataGridView1.get_Columns().get_Item(j).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)16);
		}
		DataGridViewButtonColumn val2 = new DataGridViewButtonColumn();
		((DataGridViewColumn)val2).set_HeaderText("SET Parameters");
		((DataGridViewColumn)val2).set_Name("parameters");
		((DataGridViewBand)val2).get_DefaultCellStyle().set_BackColor(Color.LightBlue);
		val2.set_FlatStyle((FlatStyle)0);
		schedule_dataGridView1.get_Columns().Add((DataGridViewColumn)(object)val2);
		schedule_dataGridView1.get_Columns().get_Item(1).set_Width(200);
		schedule_dataGridView1.get_Columns().get_Item(2).set_Width(90);
		((DataGridViewBand)schedule_dataGridView1.get_Columns().get_Item("parameters")).get_DefaultCellStyle().set_NullValue((object)"Edit");
		test_data_grid_data_load_Click(null, null);
		load_button_click = false;
	}

	private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
	{
		if (schedule_dataGridView1.get_IsCurrentCellDirty())
		{
			schedule_dataGridView1.CommitEdit((DataGridViewDataErrorContexts)512);
		}
	}

	private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (e.get_RowIndex() < 0 || e.get_ColumnIndex() != 0)
		{
			return;
		}
		DataGridView val = (DataGridView)sender;
		string text = (string)val.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
			.get_Item(0)
			.get_Value();
		_ = (string)val.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
			.get_Item(1)
			.get_Value();
		if (text.Contains("<Clear Schedule>"))
		{
			val.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.set_Value((object)"");
			if (HourVsSchdParams.ContainsKey(e.get_RowIndex()))
			{
				HourVsSchdParams.Remove(e.get_RowIndex());
				SaveSchedule();
			}
		}
	}

	private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		if (e.get_RowIndex() >= 0 && e.get_ColumnIndex() == 0)
		{
			DataGridViewCell currentCell = schedule_dataGridView1.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0);
			schedule_dataGridView1.set_CurrentCell(currentCell);
			schedule_dataGridView1.BeginEdit(true);
			Control editingControl = schedule_dataGridView1.get_EditingControl();
			DataGridViewComboBoxEditingControl val = (DataGridViewComboBoxEditingControl)(object)((editingControl is DataGridViewComboBoxEditingControl) ? editingControl : null);
			((ComboBox)val).set_DroppedDown(true);
		}
		if (e.get_RowIndex() < 0 || e.get_ColumnIndex() != 2)
		{
			return;
		}
		DataGridView val2 = (DataGridView)sender;
		string text = (string)val2.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
			.get_Item(0)
			.get_Value();
		string hour = (string)val2.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
			.get_Item(1)
			.get_Value();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		if (text.Contains("<Clear Schedule>"))
		{
			val2.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.set_Value((object)"");
			if (HourVsSchdParams.ContainsKey(e.get_RowIndex()))
			{
				HourVsSchdParams.Remove(e.get_RowIndex());
				SaveSchedule();
			}
			return;
		}
		try
		{
			EditSchdParameters editSchdParameters = ((!HourVsSchdParams.ContainsKey(e.get_RowIndex())) ? new EditSchdParameters(this, text, hour) : new EditSchdParameters(this, text, hour, (EditSchdParameters.SchdParametersStruct)HourVsSchdParams[e.get_RowIndex()]));
			((Control)editSchdParameters).set_Text(text.ToString());
			((Form)editSchdParameters).ShowDialog();
			if (editSchdParameters.SchdParameters.type != "" || editSchdParameters.SchdParameters.type != null)
			{
				if (!HourVsSchdParams.ContainsKey(e.get_RowIndex()))
				{
					HourVsSchdParams.Add(e.get_RowIndex(), editSchdParameters.SchdParameters);
				}
				else
				{
					HourVsSchdParams[e.get_RowIndex()] = editSchdParameters.SchdParameters;
				}
				SaveSchedule();
			}
		}
		catch (Exception)
		{
		}
	}

	private void multicloset_csv_load_button1_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		schedule_dataGridView1.get_Columns().Clear();
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".csv");
		((FileDialog)val).set_Filter("CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml");
		((CommonDialog)val).ShowDialog();
		if (((FileDialog)val).get_FileName() == string.Empty)
		{
			MessageBox.Show("You didn't select any file !", "No file was selected", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string fileName = ((FileDialog)val).get_FileName();
		List<string> list = File.ReadAllLines(fileName).ToList();
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("Time (hour)");
		dataTable.Columns.Add("Closet Name/Keyword");
		dataTable.Columns.Add("Loop (Num)");
		dataTable.Columns.Add("Quantity (Num)");
		DataRow dataRow = null;
		foreach (string item in list)
		{
			string[] array = Regex.Split(item, ",");
			if (array.Length >= 6 && !(array[2] == "Closet Name/ Keyword") && !(array[5] == "Party Share") && !(array[0] == "") && !(array[1] == "") && !(array[2] == "") && !(array[3] == "") && !(array[4] == "") && !(array[5] == ""))
			{
				dataRow = dataTable.NewRow();
				dataRow["Time (hour)"] = array[1];
				dataRow["Closet Name/Keyword"] = array[2] + "<-->" + array[0] + "<-->" + array[5];
				dataRow["Loop (Num)"] = array[3];
				dataRow["Quantity (Num)"] = array[4];
				dataTable.Rows.Add(dataRow);
			}
		}
		DataGridViewComboBoxColumn val2 = new DataGridViewComboBoxColumn();
		((DataGridViewColumn)val2).set_HeaderText("Type");
		((DataGridViewColumn)val2).set_Name("select type");
		val2.set_MaxDropDownItems(3);
		val2.get_Items().Add((object)"Share");
		val2.get_Items().Add((object)"Feed Share");
		val2.get_Items().Add((object)"Share Available Items");
		val2.get_Items().Add((object)"Share Specific Listing");
		val2.get_Items().Add((object)"Share Back");
		val2.get_Items().Add((object)"Share Back from Party");
		val2.get_Items().Add((object)"Share New Posher");
		val2.get_Items().Add((object)"Follow (keyword based)");
		schedule_dataGridView1.get_Columns().Add((DataGridViewColumn)(object)val2);
		schedule_dataGridView1.set_DataSource((object)dataTable);
		for (int i = 0; i < schedule_dataGridView1.get_ColumnCount(); i++)
		{
			((DataGridViewBand)schedule_dataGridView1.get_Columns().get_Item(i)).get_DefaultCellStyle().set_WrapMode((DataGridViewTriState)1);
			schedule_dataGridView1.get_Columns().get_Item(i).set_AutoSizeMode((DataGridViewAutoSizeColumnMode)16);
		}
		DataGridViewCheckBoxColumn val3 = new DataGridViewCheckBoxColumn();
		((DataGridViewColumn)val3).set_HeaderText("Party Share");
		((DataGridViewColumn)val3).set_Name("party_share");
		((DataGridViewColumn)val3).set_ValueType(typeof(bool));
		schedule_dataGridView1.get_Columns().Add((DataGridViewColumn)(object)val3);
		for (int j = 0; j < schedule_dataGridView1.get_Rows().get_Count(); j++)
		{
			string input = schedule_dataGridView1.get_Rows().get_Item(j).get_Cells()
				.get_Item("Closet Name/Keyword")
				.get_Value()
				.ToString();
			string[] array2 = Regex.Split(input, "<-->");
			string text = val2.get_Items().get_Item(0).ToString();
			foreach (object item2 in val2.get_Items())
			{
				if (item2.ToString()!.ToLower().Contains(array2[1].ToLower()))
				{
					text = item2.ToString();
					break;
				}
			}
			DataGridViewCheckBoxCell val4 = (DataGridViewCheckBoxCell)schedule_dataGridView1.get_Rows().get_Item(j).get_Cells()
				.get_Item("party_share");
			if (array2[2].ToLower().Contains("true"))
			{
				((DataGridViewCell)val4).set_Value((object)1);
			}
			if (text == "Feed Share")
			{
				array2[0] = "feed";
			}
			schedule_dataGridView1.get_Rows().get_Item(j).get_Cells()
				.get_Item("Closet Name/Keyword")
				.set_Value((object)array2[0]);
			schedule_dataGridView1.get_Rows().get_Item(j).get_Cells()
				.get_Item("select type")
				.set_Value((object)text);
		}
	}

	private void download_csv_schedule_button_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		try
		{
			FolderBrowserDialog val = new FolderBrowserDialog();
			try
			{
				val.set_Description("Select Folder To Save Sample File");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					string selectedPath = val.get_SelectedPath();
					using (WebClient webClient = new WebClient())
					{
						webClient.DownloadFile("http://poshmarktools.com/support/mpt/DownloadableFiles/Sample_schedule_file.csv", selectedPath + "\\Sample_schedule_file.csv");
					}
					Process.Start(selectedPath + "\\Sample_schedule_file.csv");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	private void schedule_template_generation_button1_Click(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		string text = DateTime.Now.ToString("dd_MM_yyyy");
		string text2 = Directory.GetCurrentDirectory() + "\\scheduler_template_" + text + ".csv";
		File.AppendAllText(text2, "Type,Time (hour), Closet Name /Keyword, Quantity,\r\n");
		File.AppendAllText(text2, "Share,00, Feed, 326,\r\n");
		File.AppendAllText(text2, "Follow,11, zara, 271,\r\n");
		File.AppendAllText(text2, "Share,22, poshcloset, 32,\r\n");
		MessageBox.Show("Sample file created at \r\n" + text2);
	}

	private void schedule_3rows_plan_label_Click(object sender, EventArgs e)
	{
		Process.Start("https://poshmarktools.com/pricing");
	}

	private void schedules_help_label_Click(object sender, EventArgs e)
	{
		Process.Start("http://poshmarktools.com/Scheduler.pdf");
	}

	private void schedule_dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (load_button_click || e.get_ColumnIndex() != 0)
			{
				return;
			}
			schedule_dataGridView1.set_CurrentCell(schedule_dataGridView1.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(2));
			DataGridView val = (DataGridView)sender;
			string text = (string)val.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.get_Value();
			string hour = (string)val.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(1)
				.get_Value();
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			if (text.Contains("<Clear Schedule>"))
			{
				val.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
					.get_Item(0)
					.set_Value((object)"");
				if (HourVsSchdParams.ContainsKey(e.get_RowIndex()))
				{
					HourVsSchdParams.Remove(e.get_RowIndex());
					SaveSchedule();
				}
				return;
			}
			try
			{
				EditSchdParameters editSchdParameters = ((!HourVsSchdParams.ContainsKey(e.get_RowIndex())) ? new EditSchdParameters(this, text, hour) : new EditSchdParameters(this, text, hour, (EditSchdParameters.SchdParametersStruct)HourVsSchdParams[e.get_RowIndex()]));
				((Control)editSchdParameters).set_Text(text.ToString());
				((Form)editSchdParameters).ShowDialog();
				if (editSchdParameters.SchdParameters.type != "" || editSchdParameters.SchdParameters.type != null)
				{
					if (!HourVsSchdParams.ContainsKey(e.get_RowIndex()))
					{
						HourVsSchdParams.Add(e.get_RowIndex(), editSchdParameters.SchdParameters);
					}
					else
					{
						HourVsSchdParams[e.get_RowIndex()] = editSchdParameters.SchdParameters;
					}
					SaveSchedule();
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

	private void delay_schedules_textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

	public void test_data_grid_data_load_Click(object sender, EventArgs e)
	{
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			HourVsSchdParams = new Hashtable();
			if (!File.Exists(Form1.schedule_save_path))
			{
				return;
			}
			List<string> list = File.ReadAllLines(Form1.schedule_save_path).ToList();
			if (list.Count > int.Parse(Form1.schedule_rows))
			{
				list.RemoveRange(int.Parse(Form1.schedule_rows), list.Count - int.Parse(Form1.schedule_rows));
			}
			for (int i = 0; i < schedule_dataGridView1.get_Rows().get_Count() && i < list.Count; i++)
			{
				try
				{
					string[] array = Regex.Split(list[i], "#");
					if (array.Length == 24)
					{
						if (!(array[5].ToLower() == "true"))
						{
						}
						if (!(array[6].ToLower() == "true"))
						{
						}
						EditSchdParameters.SchdParametersStruct schdParametersStruct = default(EditSchdParameters.SchdParametersStruct);
						schdParametersStruct.type = array[0];
						schdParametersStruct.hour = array[1];
						schdParametersStruct.closet_name = array[2];
						schdParametersStruct.QuantityOfLoops = array[3];
						schdParametersStruct.QuantityOfListings = array[4];
						schdParametersStruct.DelayAfterLoops = array[5];
						schdParametersStruct.DelayInListings = array[6];
						schdParametersStruct.ShareSpecificListingsFromMyCloset = array[7];
						schdParametersStruct.ShareBackLast = array[8];
						schdParametersStruct.ShareNewPosher = array[9];
						schdParametersStruct.DelayBetweenFollow_Unfollow = array[10];
						schdParametersStruct.QuantityOfFollow_Unfollow = array[11];
						schdParametersStruct.Follow_keywords = array[12];
						schdParametersStruct.FollowNextClosetXtoXSec = array[13];
						schdParametersStruct.NumberofClosetsToFollow = array[14];
						schdParametersStruct.KeywordToLike = array[15];
						schdParametersStruct.CountOfLikes = array[16];
						schdParametersStruct.DelayBetweennextLike = array[17];
						schdParametersStruct.KeywordToComment = array[18];
						schdParametersStruct.CountOfComments = array[19];
						schdParametersStruct.DelayBetweennextComment = array[20];
						schdParametersStruct.CommentText = array[21].Replace("-----", "\r\n");
						schdParametersStruct.ShareToParty = bool.Parse(array[22]);
						schdParametersStruct.ShareClosetInReverse = bool.Parse(array[23]);
						if (HourVsSchdParams.ContainsKey(i))
						{
							HourVsSchdParams[i] = schdParametersStruct;
						}
						else
						{
							HourVsSchdParams.Add(i, schdParametersStruct);
						}
						if (schedule_dataGridView1.get_Rows().get_Item(i).get_Cells()
							.get_Item(1)
							.get_Value() != null)
						{
							schedule_dataGridView1.get_Rows().get_Item(i).get_Cells()
								.get_Item(1)
								.set_Value((object)array[1]);
							schedule_dataGridView1.get_Rows().get_Item(i).get_Cells()
								.get_Item(0)
								.set_Value((object)array[0]);
						}
					}
				}
				catch (Exception)
				{
					MessageBox.Show(e.ToString());
				}
			}
		}
		catch (Exception)
		{
			MessageBox.Show(e.ToString());
		}
	}

	private void schedule_random_delay_metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)schedule_random_delay_metroCheckBox1).get_Checked())
		{
			((Control)schedule_random_value_metroTextBox1).set_Enabled(true);
		}
		else
		{
			((Control)schedule_random_value_metroTextBox1).set_Enabled(false);
		}
	}

	private void schedule_dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.get_ColumnIndex() == 1)
			{
				string text = schedule_dataGridView1.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
					.get_Item(e.get_ColumnIndex())
					.get_Value()
					.ToString();
				if (text != "" && HourVsSchdParams.ContainsKey(e.get_RowIndex()))
				{
					EditSchdParameters.SchdParametersStruct schdParametersStruct = (EditSchdParameters.SchdParametersStruct)HourVsSchdParams[e.get_RowIndex()];
					schdParametersStruct.hour = text;
					HourVsSchdParams[e.get_RowIndex()] = schdParametersStruct;
					SaveSchedule();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void schedule_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected O, but got Unknown
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected O, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected O, but got Unknown
		splitContainer3 = new SplitContainer();
		metroLabel2 = new MetroLabel();
		schedule_random_value_metroTextBox1 = new MetroTextBox();
		schedule_random_delay_metroCheckBox1 = new MetroCheckBox();
		delay_schedules_textBox2 = new MetroTextBox();
		label42 = new MetroLabel();
		schedules_help_label = new MetroLabel();
		download_csv_schedule_button = new MetroButton();
		label46 = new MetroLabel();
		multicloset_csv_load_button1 = new MetroButton();
		schedule_3rows_plan_label = new MetroLabel();
		label34 = new MetroLabel();
		schedule_template_generation_button1 = new MetroButton();
		schedule_load_button1 = new MetroButton();
		label29 = new MetroLabel();
		schedule_textbox_expiry_date = new MetroTextBox();
		schedule_dataGridView1 = new DataGridView();
		((ISupportInitialize)splitContainer3).BeginInit();
		((Control)splitContainer3.get_Panel1()).SuspendLayout();
		((Control)splitContainer3.get_Panel2()).SuspendLayout();
		((Control)splitContainer3).SuspendLayout();
		((ISupportInitialize)schedule_dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		splitContainer3.set_Dock((DockStyle)5);
		((Control)splitContainer3).set_Location(new Point(0, 0));
		((Control)splitContainer3).set_Name("splitContainer3");
		splitContainer3.set_Orientation((Orientation)0);
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)metroLabel2);
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)label34);
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)schedule_random_delay_metroCheckBox1);
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)schedule_random_value_metroTextBox1);
		splitContainer3.set_Panel1MinSize(15);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)delay_schedules_textBox2);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)label42);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)schedules_help_label);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)download_csv_schedule_button);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)label29);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)schedule_load_button1);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)label46);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)multicloset_csv_load_button1);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)schedule_textbox_expiry_date);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)schedule_template_generation_button1);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)schedule_3rows_plan_label);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)schedule_dataGridView1);
		splitContainer3.set_Panel2MinSize(85);
		((Control)splitContainer3).set_Size(new Size(796, 416));
		splitContainer3.set_SplitterDistance(71);
		((Control)splitContainer3).set_TabIndex(5);
		((Control)metroLabel2).set_AutoSize(true);
		((Control)metroLabel2).set_Location(new Point(629, 28));
		((Control)metroLabel2).set_Name("metroLabel2");
		((Control)metroLabel2).set_Size(new Size(62, 19));
		metroLabel2.Style = MetroColorStyle.Brown;
		((Control)metroLabel2).set_TabIndex(127);
		((Control)metroLabel2).set_Text("(minutes)");
		metroLabel2.UseStyleColors = true;
		((Control)metroLabel2).set_Visible(false);
		((Control)schedule_random_value_metroTextBox1).set_ForeColor(SystemColors.GrayText);
		((Control)schedule_random_value_metroTextBox1).set_Location(new Point(514, 27));
		((Control)schedule_random_value_metroTextBox1).set_Name("schedule_random_value_metroTextBox1");
		((Control)schedule_random_value_metroTextBox1).set_Size(new Size(109, 20));
		schedule_random_value_metroTextBox1.Style = MetroColorStyle.Brown;
		((Control)schedule_random_value_metroTextBox1).set_TabIndex(126);
		((Control)schedule_random_value_metroTextBox1).set_Text("10,30");
		schedule_random_value_metroTextBox1.UseStyleColors = true;
		((Control)schedule_random_delay_metroCheckBox1).set_AutoSize(true);
		((CheckBox)schedule_random_delay_metroCheckBox1).set_Checked(true);
		((CheckBox)schedule_random_delay_metroCheckBox1).set_CheckState((CheckState)1);
		((Control)schedule_random_delay_metroCheckBox1).set_Location(new Point(472, 6));
		((Control)schedule_random_delay_metroCheckBox1).set_Name("schedule_random_delay_metroCheckBox1");
		((Control)schedule_random_delay_metroCheckBox1).set_Size(new Size(151, 15));
		schedule_random_delay_metroCheckBox1.Style = MetroColorStyle.Brown;
		((Control)schedule_random_delay_metroCheckBox1).set_TabIndex(125);
		((Control)schedule_random_delay_metroCheckBox1).set_Text("Schedule Random Delay");
		schedule_random_delay_metroCheckBox1.UseStyleColors = true;
		((ButtonBase)schedule_random_delay_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)schedule_random_delay_metroCheckBox1).add_CheckedChanged((EventHandler)schedule_random_delay_metroCheckBox1_CheckedChanged);
		((Control)delay_schedules_textBox2).set_ForeColor(Color.Black);
		((Control)delay_schedules_textBox2).set_Location(new Point(717, 26));
		((Control)delay_schedules_textBox2).set_Name("delay_schedules_textBox2");
		((Control)delay_schedules_textBox2).set_Size(new Size(50, 23));
		delay_schedules_textBox2.Style = MetroColorStyle.Brown;
		((Control)delay_schedules_textBox2).set_TabIndex(83);
		((Control)delay_schedules_textBox2).set_Text("2,7");
		delay_schedules_textBox2.UseStyleColors = true;
		((Control)delay_schedules_textBox2).set_Visible(false);
		((Control)delay_schedules_textBox2).add_KeyPress(new KeyPressEventHandler(delay_schedules_textBox2_KeyPress));
		((Control)label42).set_AutoSize(true);
		((Control)label42).set_Location(new Point(472, 26));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(239, 19));
		label42.Style = MetroColorStyle.Brown;
		((Control)label42).set_TabIndex(82);
		((Control)label42).set_Text("Share/follow after every X to X seconds");
		label42.UseStyleColors = true;
		((Control)label42).set_Visible(false);
		((Control)schedules_help_label).set_AutoSize(true);
		((Control)schedules_help_label).set_Cursor(Cursors.get_Hand());
		((Control)schedules_help_label).set_ForeColor(SystemColors.ActiveCaption);
		((Control)schedules_help_label).set_Location(new Point(472, 64));
		((Control)schedules_help_label).set_Name("schedules_help_label");
		((Control)schedules_help_label).set_Size(new Size(202, 19));
		schedules_help_label.Style = MetroColorStyle.Brown;
		((Control)schedules_help_label).set_TabIndex(81);
		((Control)schedules_help_label).set_Text("How to use Schedules? Click here");
		schedules_help_label.UseStyleColors = true;
		((Control)schedules_help_label).set_Visible(false);
		((Control)schedules_help_label).add_Click((EventHandler)schedules_help_label_Click);
		((Control)download_csv_schedule_button).set_Enabled(false);
		((Control)download_csv_schedule_button).set_Location(new Point(425, 141));
		((Control)download_csv_schedule_button).set_Name("download_csv_schedule_button");
		((Control)download_csv_schedule_button).set_Size(new Size(160, 20));
		download_csv_schedule_button.Style = MetroColorStyle.Brown;
		((Control)download_csv_schedule_button).set_TabIndex(80);
		((Control)download_csv_schedule_button).set_Text("Download Sample CSV");
		((Control)download_csv_schedule_button).set_Visible(false);
		((Control)download_csv_schedule_button).add_Click((EventHandler)download_csv_schedule_button_Click);
		((Control)label46).set_AutoSize(true);
		((Control)label46).set_Cursor(Cursors.get_Hand());
		((Control)label46).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label46).set_Location(new Point(472, 64));
		((Control)label46).set_Name("label46");
		((Control)label46).set_Size(new Size(170, 19));
		label46.Style = MetroColorStyle.Brown;
		((Control)label46).set_TabIndex(79);
		((Control)label46).set_Text("Load Csv Requires Pro Plan");
		label46.UseStyleColors = true;
		((Control)label46).set_Visible(false);
		((Control)multicloset_csv_load_button1).set_Enabled(false);
		((Control)multicloset_csv_load_button1).set_Location(new Point(607, 141));
		((Control)multicloset_csv_load_button1).set_Name("multicloset_csv_load_button1");
		((Control)multicloset_csv_load_button1).set_Size(new Size(160, 35));
		multicloset_csv_load_button1.Style = MetroColorStyle.Brown;
		((Control)multicloset_csv_load_button1).set_TabIndex(78);
		((Control)multicloset_csv_load_button1).set_Text("Load CSV");
		((Control)multicloset_csv_load_button1).set_Visible(false);
		((Control)multicloset_csv_load_button1).add_Click((EventHandler)multicloset_csv_load_button1_Click);
		((Control)schedule_3rows_plan_label).set_AutoSize(true);
		((Control)schedule_3rows_plan_label).set_Cursor(Cursors.get_Hand());
		((Control)schedule_3rows_plan_label).set_ForeColor(Color.FromArgb(0, 0, 192));
		((Control)schedule_3rows_plan_label).set_Location(new Point(472, 101));
		((Control)schedule_3rows_plan_label).set_Name("schedule_3rows_plan_label");
		((Control)schedule_3rows_plan_label).set_Size(new Size(139, 19));
		schedule_3rows_plan_label.Style = MetroColorStyle.Brown;
		((Control)schedule_3rows_plan_label).set_TabIndex(9);
		((Control)schedule_3rows_plan_label).set_Text("Click To Buy Schedules");
		schedule_3rows_plan_label.UseStyleColors = true;
		((Control)schedule_3rows_plan_label).set_Visible(false);
		((Control)schedule_3rows_plan_label).add_Click((EventHandler)schedule_3rows_plan_label_Click);
		((Control)label34).set_AutoSize(true);
		((Control)label34).set_ForeColor(Color.DarkRed);
		((Control)label34).set_Location(new Point(3, 6));
		((Control)label34).set_Name("label34");
		((Control)label34).set_Size(new Size(418, 57));
		label34.Style = MetroColorStyle.Brown;
		((Control)label34).set_TabIndex(8);
		((Control)label34).set_Text("* All rows will run daily \r\n* Time will be 0-23 hour, and shares will be done according to Pc time\r\n* Add 2captcha so the captchas will get solved automatically");
		label34.UseStyleColors = true;
		((Control)schedule_template_generation_button1).set_Location(new Point(472, 195));
		((Control)schedule_template_generation_button1).set_Name("schedule_template_generation_button1");
		((Control)schedule_template_generation_button1).set_Size(new Size(285, 31));
		schedule_template_generation_button1.Style = MetroColorStyle.Brown;
		((Control)schedule_template_generation_button1).set_TabIndex(7);
		((Control)schedule_template_generation_button1).set_Text("Generate Sample Schedule File");
		((Control)schedule_template_generation_button1).set_Visible(false);
		((Control)schedule_template_generation_button1).add_Click((EventHandler)schedule_template_generation_button1_Click);
		((Control)schedule_load_button1).set_Location(new Point(10, 64));
		((Control)schedule_load_button1).set_Name("schedule_load_button1");
		((Control)schedule_load_button1).set_Size(new Size(252, 31));
		schedule_load_button1.Style = MetroColorStyle.Brown;
		((Control)schedule_load_button1).set_TabIndex(6);
		((Control)schedule_load_button1).set_Text("Generate Rows");
		((Control)schedule_load_button1).set_Visible(false);
		((Control)schedule_load_button1).add_Click((EventHandler)schedule_load_button1_Click);
		((Control)label29).set_AutoSize(true);
		((Control)label29).set_Location(new Point(10, 3));
		((Control)label29).set_Name("label29");
		((Control)label29).set_Size(new Size(97, 19));
		label29.Style = MetroColorStyle.Brown;
		((Control)label29).set_TabIndex(5);
		((Control)label29).set_Text("Schedule status");
		label29.UseStyleColors = true;
		((Control)label29).set_Visible(false);
		((Control)schedule_textbox_expiry_date).set_Location(new Point(10, 25));
		((Control)schedule_textbox_expiry_date).set_Name("schedule_textbox_expiry_date");
		schedule_textbox_expiry_date.ReadOnly = true;
		((Control)schedule_textbox_expiry_date).set_Size(new Size(352, 20));
		schedule_textbox_expiry_date.Style = MetroColorStyle.Brown;
		((Control)schedule_textbox_expiry_date).set_TabIndex(4);
		schedule_textbox_expiry_date.UseStyleColors = true;
		((Control)schedule_textbox_expiry_date).set_Visible(false);
		schedule_dataGridView1.set_AllowUserToAddRows(false);
		schedule_dataGridView1.set_AllowUserToDeleteRows(false);
		schedule_dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)schedule_dataGridView1).set_Dock((DockStyle)5);
		((Control)schedule_dataGridView1).set_Location(new Point(0, 0));
		((Control)schedule_dataGridView1).set_Name("schedule_dataGridView1");
		((Control)schedule_dataGridView1).set_Size(new Size(796, 341));
		((Control)schedule_dataGridView1).set_TabIndex(0);
		schedule_dataGridView1.add_CellClick(new DataGridViewCellEventHandler(schedule_dataGridView1_CellClick));
		schedule_dataGridView1.add_CellLeave(new DataGridViewCellEventHandler(schedule_dataGridView1_CellLeave));
		schedule_dataGridView1.add_CellValueChanged(new DataGridViewCellEventHandler(schedule_dataGridView1_CellValueChanged));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)splitContainer3);
		((Control)this).set_Name("Pro_share_follow_schedules");
		((Control)this).set_Size(new Size(796, 416));
		((Control)splitContainer3.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer3.get_Panel1()).PerformLayout();
		((Control)splitContainer3.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer3.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer3).EndInit();
		((Control)splitContainer3).ResumeLayout(false);
		((ISupportInitialize)schedule_dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
