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
using System.Web;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class Pro_bulk_price_editor : UserControl
{
	private CheckBox headerCheckBox = new CheckBox();

	private IContainer components = null;

	public MetroTextBox bulk_price_permission_textBox2;

	private MetroLabel label44;

	public MetroTextBox bulk_price_edittor_filter_textBox2;

	private MetroLabel label43;

	public MetroTextBox delay_bulk_price_edittor_textBox2;

	private MetroLabel label42;

	private MetroLabel label40;

	private MetroLabel label39;

	private MetroCheckBox fetch_all_listing_bulk_price_edittor_checkBox1;

	public MetroButton bulk_price_edittor_fetch_listing_button;

	private MetroTextBox bulk_price_edittor_listing_count_textbox;

	public DataGridView dataGridView1_bulk_price_editor;

	private MetroLabel label41;

	public MetroButton download_csv_bulk_edit_metroButton1;

	public MetroButton upload_csv_bulk_edit_metroButton1;

	private DataGridViewCheckBoxColumn checkbox;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	public Pro_bulk_price_editor()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		InitializeComponent();
		try
		{
			Rectangle cellDisplayRectangle = dataGridView1_bulk_price_editor.GetCellDisplayRectangle(0, -1, true);
			cellDisplayRectangle.Y = 3;
			cellDisplayRectangle.X = cellDisplayRectangle.Location.X + 3 + cellDisplayRectangle.Width / 4;
			((Control)headerCheckBox).set_Location(cellDisplayRectangle.Location);
			((Control)headerCheckBox).set_BackColor(Color.White);
			((Control)headerCheckBox).set_Size(new Size(18, 18));
			((Control)headerCheckBox).add_Click((EventHandler)HeaderCheckBox_Clicked);
			((Control)dataGridView1_bulk_price_editor).get_Controls().Add((Control)(object)headerCheckBox);
			dataGridView1_bulk_price_editor.add_CellContentClick(new DataGridViewCellEventHandler(DataGridView_CellClick));
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "07) " + ex.ToString() + "\r\n");
		}
	}

	private void HeaderCheckBox_Clicked(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		dataGridView1_bulk_price_editor.EndEdit();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1_bulk_price_editor.get_Rows())
		{
			DataGridViewRow val = item;
			DataGridViewCell obj = val.get_Cells().get_Item("checkbox");
			DataGridViewCheckBoxCell val2 = (DataGridViewCheckBoxCell)(object)((obj is DataGridViewCheckBoxCell) ? obj : null);
			((DataGridViewCell)val2).set_Value((object)headerCheckBox.get_Checked());
		}
	}

	private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (e.get_RowIndex() < 0 || e.get_ColumnIndex() != 4)
		{
			return;
		}
		bool @checked = true;
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1_bulk_price_editor.get_Rows())
		{
			DataGridViewRow val = item;
			if (!Convert.ToBoolean(val.get_Cells().get_Item("checkbox").get_EditedFormattedValue()))
			{
				@checked = false;
				break;
			}
		}
		headerCheckBox.set_Checked(@checked);
	}

	private void bulk_price_edittor_fetch_listing_button_Click(object sender, EventArgs e)
	{
		try
		{
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\\\images\\\\");
			string[] array = files;
			foreach (string path in array)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		dataGridView1_bulk_price_editor.get_Rows().Clear();
		Form1.cookie_Set();
		string listing_quantity = "";
		if (((CheckBox)fetch_all_listing_bulk_price_edittor_checkBox1).get_Checked())
		{
			listing_quantity = Form1.ed.get_logined_available_items(Form1.ck);
		}
		else
		{
			listing_quantity = ((Control)bulk_price_edittor_listing_count_textbox).get_Text();
		}
		try
		{
			Form1.t.Abort();
		}
		catch
		{
		}
		string filter = ((Control)bulk_price_edittor_filter_textBox2).get_Text();
		Form1.t = new Thread((ThreadStart)delegate
		{
			lets_extract_listings_for_bulk_price(listing_quantity, filter);
		});
		Form1.t.Start();
	}

	private void lets_extract_listings_for_bulk_price(string listing_quantity, string filter)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		try
		{
			MetroTextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__5_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Going for data extraction from closet\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__5_0 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			string text = Form1.lg.check_who_is_logined(Form1.ck);
			string text2 = "";
			if (text != null)
			{
				text2 = text.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
				string token = Form1.ed.return_csrf_token(Form1.ck);
				string party_id = Form1.ed.get_eventid(Form1.ck, token);
				List<extract_data.Listing_info> list = Form1.ed.extract_listings_from_closet(text2, listing_quantity, party_id, ref token, ref Form1.ck, default(EditSchdParameters.SchdParametersStruct));
				foreach (extract_data.Listing_info item in list)
				{
					extract_data.Listng_data Ld = default(extract_data.Listng_data);
					Ld = Form1.ed.extract_listings_data_listinglink(item.listing_link.Replace("share?post_id=", ""), ref token, ref Form1.ck);
					Ld.description = item.listing_link;
					if (!(filter == ""))
					{
						string[] array = Regex.Split(filter, ",");
						bool flag = false;
						string[] array2 = array;
						foreach (string text3 in array2)
						{
							if (Ld.title.ToLower().Contains(text3.ToLower().TrimStart(new char[0]).TrimEnd(new char[0])))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							continue;
						}
					}
					try
					{
						Ld.title = HttpUtility.HtmlDecode(Ld.title);
						((Control)dataGridView1_bulk_price_editor).Invoke((Delegate)(MethodInvoker)delegate
						{
							dataGridView1_bulk_price_editor.get_Rows().Add(new object[4]
							{
								false,
								Ld.title,
								Ld.description,
								Ld.price.Replace("$", "")
							});
						});
					}
					catch
					{
					}
				}
			}
			int index;
			for (index = 0; index < ((BaseCollection)dataGridView1_bulk_price_editor.get_Columns()).get_Count(); index++)
			{
				((Control)dataGridView1_bulk_price_editor).Invoke((Delegate)(MethodInvoker)delegate
				{
					((DataGridViewBand)dataGridView1_bulk_price_editor.get_Columns().get_Item(index)).set_ReadOnly(false);
				});
			}
			MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
			object obj3 = _003C_003Ec._003C_003E9__5_3;
			if (obj3 == null)
			{
				MethodInvoker val2 = delegate
				{
					Form1.mainform.status_textBox1.AppendText("Data Extraction Completed from poshmark, Delete Rows that you dont want for ENL, and click start\r\n");
				};
				obj3 = (object)val2;
				_003C_003Ec._003C_003E9__5_3 = val2;
			}
			((Control)status_textBox2).Invoke((Delegate)obj3);
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "9) " + ex.ToString() + "\r\n");
		}
	}

	private void bulk_price_edittor_listing_count_textbox_KeyPress(object sender, KeyPressEventArgs e)
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

	private void bulk_price_edittor_listing_count_textbox_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
	}

	private void fetch_all_listing_bulk_price_edittor_checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		CheckBox val = (CheckBox)(object)(sender as MetroCheckBox);
		if (val.get_Checked())
		{
			((Control)bulk_price_edittor_listing_count_textbox).set_Enabled(false);
			((Control)bulk_price_edittor_filter_textBox2).set_Enabled(false);
		}
		else
		{
			((Control)bulk_price_edittor_listing_count_textbox).set_Enabled(true);
			((Control)bulk_price_edittor_filter_textBox2).set_Enabled(true);
		}
	}

	private void download_csv_bulk_edit_metroButton1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "bulk_Edit.csv";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			for (int i = 0; i < dataGridView1_bulk_price_editor.get_Rows().get_Count(); i++)
			{
				try
				{
					string text2 = dataGridView1_bulk_price_editor.get_Rows().get_Item(i).get_Cells()
						.get_Item(2)
						.get_Value()
						.ToString()!.TrimStart(new char[0]).TrimEnd(new char[0]);
					string text3 = dataGridView1_bulk_price_editor.get_Rows().get_Item(i).get_Cells()
						.get_Item(1)
						.get_Value()
						.ToString()!.TrimStart(new char[0]).TrimEnd(new char[0]);
					string text4 = dataGridView1_bulk_price_editor.get_Rows().get_Item(i).get_Cells()
						.get_Item(3)
						.get_Value()
						.ToString()!.Replace("$", "").TrimStart(new char[0]).TrimEnd(new char[0]);
					File.AppendAllText(text, "\"" + text3.Replace("\"", "\"\"") + "\",\"" + text2 + "\",\"" + text4 + "\",\r\n");
				}
				catch
				{
				}
			}
			Process.Start(text);
		}
		catch
		{
		}
	}

	private void upload_csv_bulk_edit_metroButton1_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b1: Expected O, but got Unknown
		dataGridView1_bulk_price_editor.get_Rows().Clear();
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Title("Load Listing File");
			((FileDialog)val).set_Filter("csv files (*.csv)|*.csv|All files (*.*)|*.*");
			((CommonDialog)val).ShowDialog();
			string fileName = ((FileDialog)val).get_FileName();
			if (fileName != "")
			{
				List<string> list = new List<string>();
				list = File.ReadAllLines(fileName).ToList();
				string title = "";
				string desc = "";
				string price = "";
				MethodInvoker val2 = default(MethodInvoker);
				foreach (string item in list)
				{
					string[] array = Regex.Split(item, ",");
					if (!(array[0] != "") || !((array[1] != "") & (array[2] != "")))
					{
						continue;
					}
					title = array[0].Substring(1, array[0].Length - 1 - 1).TrimStart(new char[0]).TrimEnd(new char[0]);
					desc = array[1].Substring(1, array[1].Length - 1 - 1).TrimStart(new char[0]).TrimEnd(new char[0]);
					price = array[2].Substring(1, array[2].Length - 1 - 1).Replace("$", "").TrimStart(new char[0])
						.TrimEnd(new char[0]);
					DataGridView obj = dataGridView1_bulk_price_editor;
					MethodInvoker obj2 = val2;
					if (obj2 == null)
					{
						MethodInvoker val3 = delegate
						{
							dataGridView1_bulk_price_editor.get_Rows().Add(new object[4] { false, title, desc, price });
						};
						MethodInvoker val4 = val3;
						val2 = val3;
						obj2 = val4;
					}
					((Control)obj).Invoke((Delegate)(object)obj2);
				}
				Form1.mainform.status_textBox1.AppendText("\r\nBulk edit File Loaded");
			}
			else
			{
				Form1.mainform.status_textBox1.AppendText("\r\nNo File Selected");
			}
		}
		catch (Exception)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "01aaa) " + e.ToString() + "\r\n");
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
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		bulk_price_permission_textBox2 = new MetroTextBox();
		label44 = new MetroLabel();
		bulk_price_edittor_filter_textBox2 = new MetroTextBox();
		label43 = new MetroLabel();
		delay_bulk_price_edittor_textBox2 = new MetroTextBox();
		label42 = new MetroLabel();
		label40 = new MetroLabel();
		label39 = new MetroLabel();
		fetch_all_listing_bulk_price_edittor_checkBox1 = new MetroCheckBox();
		bulk_price_edittor_fetch_listing_button = new MetroButton();
		bulk_price_edittor_listing_count_textbox = new MetroTextBox();
		dataGridView1_bulk_price_editor = new DataGridView();
		checkbox = new DataGridViewCheckBoxColumn();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		label41 = new MetroLabel();
		download_csv_bulk_edit_metroButton1 = new MetroButton();
		upload_csv_bulk_edit_metroButton1 = new MetroButton();
		((ISupportInitialize)dataGridView1_bulk_price_editor).BeginInit();
		((Control)this).SuspendLayout();
		((Control)bulk_price_permission_textBox2).set_Location(new Point(8, 7));
		((Control)bulk_price_permission_textBox2).set_Name("bulk_price_permission_textBox2");
		bulk_price_permission_textBox2.ReadOnly = true;
		((Control)bulk_price_permission_textBox2).set_Size(new Size(98, 23));
		bulk_price_permission_textBox2.Style = MetroColorStyle.Brown;
		((Control)bulk_price_permission_textBox2).set_TabIndex(81);
		((Control)bulk_price_permission_textBox2).set_Text("Not permitted");
		bulk_price_permission_textBox2.UseStyleColors = true;
		((Control)bulk_price_permission_textBox2).set_Visible(false);
		((Control)label44).set_AutoSize(true);
		((Control)label44).set_ForeColor(Color.Maroon);
		((Control)label44).set_Location(new Point(112, 11));
		((Control)label44).set_Name("label44");
		((Control)label44).set_Size(new Size(246, 19));
		label44.Style = MetroColorStyle.Brown;
		((Control)label44).set_TabIndex(79);
		((Control)label44).set_Text("You can perfrom 10 free price edits daily");
		label44.UseStyleColors = true;
		((Control)label44).set_Visible(false);
		((Control)bulk_price_edittor_filter_textBox2).set_ForeColor(Color.Black);
		((Control)bulk_price_edittor_filter_textBox2).set_Location(new Point(459, 57));
		((Control)bulk_price_edittor_filter_textBox2).set_Name("bulk_price_edittor_filter_textBox2");
		((Control)bulk_price_edittor_filter_textBox2).set_Size(new Size(316, 23));
		bulk_price_edittor_filter_textBox2.Style = MetroColorStyle.Brown;
		((Control)bulk_price_edittor_filter_textBox2).set_TabIndex(78);
		bulk_price_edittor_filter_textBox2.UseStyleColors = true;
		((Control)label43).set_AutoSize(true);
		((Control)label43).set_Location(new Point(8, 59));
		((Control)label43).set_Name("label43");
		((Control)label43).set_Size(new Size(444, 19));
		label43.Style = MetroColorStyle.Brown;
		((Control)label43).set_TabIndex(77);
		((Control)label43).set_Text("Get Listings containg words (comma separated - Left blank if not required)");
		label43.UseStyleColors = true;
		((Control)delay_bulk_price_edittor_textBox2).set_ForeColor(Color.Black);
		((Control)delay_bulk_price_edittor_textBox2).set_Location(new Point(686, 83));
		((Control)delay_bulk_price_edittor_textBox2).set_Name("delay_bulk_price_edittor_textBox2");
		((Control)delay_bulk_price_edittor_textBox2).set_Size(new Size(67, 23));
		delay_bulk_price_edittor_textBox2.Style = MetroColorStyle.Brown;
		((Control)delay_bulk_price_edittor_textBox2).set_TabIndex(76);
		((Control)delay_bulk_price_edittor_textBox2).set_Text("60,120");
		delay_bulk_price_edittor_textBox2.UseStyleColors = true;
		((Control)delay_bulk_price_edittor_textBox2).add_Click((EventHandler)bulk_price_edittor_listing_count_textbox_Click);
		((Control)delay_bulk_price_edittor_textBox2).add_KeyPress(new KeyPressEventHandler(bulk_price_edittor_listing_count_textbox_KeyPress));
		((Control)label42).set_AutoSize(true);
		((Control)label42).set_Location(new Point(459, 83));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(221, 19));
		label42.Style = MetroColorStyle.Brown;
		((Control)label42).set_TabIndex(75);
		((Control)label42).set_Text("Edit Price after every X to X seconds");
		label42.UseStyleColors = true;
		((Control)label40).set_AutoSize(true);
		((Control)label40).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label40).set_Location(new Point(525, 341));
		((Control)label40).set_Name("label40");
		((Control)label40).set_Size(new Size(244, 19));
		label40.Style = MetroColorStyle.Red;
		((Control)label40).set_TabIndex(73);
		((Control)label40).set_Text("Donot change anything, other than price");
		label40.UseStyleColors = true;
		((Control)label39).set_AutoSize(true);
		((Control)label39).set_Location(new Point(726, 17));
		((Control)label39).set_Name("label39");
		((Control)label39).set_Size(new Size(43, 19));
		label39.Style = MetroColorStyle.Brown;
		((Control)label39).set_TabIndex(72);
		((Control)label39).set_Text("Status");
		label39.UseStyleColors = true;
		((Control)label39).set_Visible(false);
		((Control)fetch_all_listing_bulk_price_edittor_checkBox1).set_AutoSize(true);
		((Control)fetch_all_listing_bulk_price_edittor_checkBox1).set_Location(new Point(207, 35));
		((Control)fetch_all_listing_bulk_price_edittor_checkBox1).set_Name("fetch_all_listing_bulk_price_edittor_checkBox1");
		((Control)fetch_all_listing_bulk_price_edittor_checkBox1).set_Size(new Size(109, 15));
		fetch_all_listing_bulk_price_edittor_checkBox1.Style = MetroColorStyle.Brown;
		((Control)fetch_all_listing_bulk_price_edittor_checkBox1).set_TabIndex(71);
		((Control)fetch_all_listing_bulk_price_edittor_checkBox1).set_Text("Fetch All listings");
		fetch_all_listing_bulk_price_edittor_checkBox1.UseStyleColors = true;
		((ButtonBase)fetch_all_listing_bulk_price_edittor_checkBox1).set_UseVisualStyleBackColor(false);
		((CheckBox)fetch_all_listing_bulk_price_edittor_checkBox1).add_CheckedChanged((EventHandler)fetch_all_listing_bulk_price_edittor_checkBox1_CheckedChanged);
		((Control)bulk_price_edittor_fetch_listing_button).set_Location(new Point(461, 11));
		((Control)bulk_price_edittor_fetch_listing_button).set_Name("bulk_price_edittor_fetch_listing_button");
		((Control)bulk_price_edittor_fetch_listing_button).set_Size(new Size(219, 33));
		((Control)bulk_price_edittor_fetch_listing_button).set_TabIndex(70);
		((Control)bulk_price_edittor_fetch_listing_button).set_Text("Fetch Listings (Step 1)");
		((Control)bulk_price_edittor_fetch_listing_button).add_Click((EventHandler)bulk_price_edittor_fetch_listing_button_Click);
		((Control)bulk_price_edittor_listing_count_textbox).set_ForeColor(Color.Black);
		((Control)bulk_price_edittor_listing_count_textbox).set_Location(new Point(77, 33));
		((Control)bulk_price_edittor_listing_count_textbox).set_Name("bulk_price_edittor_listing_count_textbox");
		((Control)bulk_price_edittor_listing_count_textbox).set_Size(new Size(51, 23));
		((Control)bulk_price_edittor_listing_count_textbox).set_TabIndex(69);
		((Control)bulk_price_edittor_listing_count_textbox).set_Text("30");
		((Control)bulk_price_edittor_listing_count_textbox).add_Click((EventHandler)bulk_price_edittor_listing_count_textbox_Click);
		((Control)bulk_price_edittor_listing_count_textbox).add_KeyPress(new KeyPressEventHandler(bulk_price_edittor_listing_count_textbox_KeyPress));
		dataGridView1_bulk_price_editor.set_AllowUserToAddRows(false);
		dataGridView1_bulk_price_editor.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView1_bulk_price_editor.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1_bulk_price_editor.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)checkbox,
			(DataGridViewColumn)dataGridViewTextBoxColumn1,
			(DataGridViewColumn)dataGridViewTextBoxColumn4,
			(DataGridViewColumn)dataGridViewTextBoxColumn3
		});
		((Control)dataGridView1_bulk_price_editor).set_Location(new Point(0, 112));
		((Control)dataGridView1_bulk_price_editor).set_Name("dataGridView1_bulk_price_editor");
		((Control)dataGridView1_bulk_price_editor).set_Size(new Size(769, 217));
		((Control)dataGridView1_bulk_price_editor).set_TabIndex(68);
		((DataGridViewColumn)checkbox).set_HeaderText("Include");
		((DataGridViewColumn)checkbox).set_Name("checkbox");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_HeaderText("Title");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_Name("dataGridViewTextBoxColumn1");
		((DataGridViewBand)dataGridViewTextBoxColumn1).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn4).set_HeaderText("Link");
		((DataGridViewColumn)dataGridViewTextBoxColumn4).set_Name("dataGridViewTextBoxColumn4");
		((DataGridViewBand)dataGridViewTextBoxColumn4).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn3).set_HeaderText("Price");
		((DataGridViewColumn)dataGridViewTextBoxColumn3).set_Name("dataGridViewTextBoxColumn3");
		((DataGridViewBand)dataGridViewTextBoxColumn3).set_ReadOnly(true);
		((Control)label41).set_AutoSize(true);
		((Control)label41).set_Location(new Point(8, 33));
		((Control)label41).set_Name("label41");
		((Control)label41).set_Size(new Size(193, 19));
		label41.Style = MetroColorStyle.Brown;
		((Control)label41).set_TabIndex(74);
		((Control)label41).set_Text("Fetch first                Listings OR");
		label41.UseStyleColors = true;
		((Control)download_csv_bulk_edit_metroButton1).set_Location(new Point(0, 335));
		((Control)download_csv_bulk_edit_metroButton1).set_Name("download_csv_bulk_edit_metroButton1");
		((Control)download_csv_bulk_edit_metroButton1).set_Size(new Size(142, 25));
		((Control)download_csv_bulk_edit_metroButton1).set_TabIndex(82);
		((Control)download_csv_bulk_edit_metroButton1).set_Text("Download Listings in csv");
		((Control)download_csv_bulk_edit_metroButton1).add_Click((EventHandler)download_csv_bulk_edit_metroButton1_Click);
		((Control)upload_csv_bulk_edit_metroButton1).set_Location(new Point(174, 335));
		((Control)upload_csv_bulk_edit_metroButton1).set_Name("upload_csv_bulk_edit_metroButton1");
		((Control)upload_csv_bulk_edit_metroButton1).set_Size(new Size(142, 25));
		((Control)upload_csv_bulk_edit_metroButton1).set_TabIndex(83);
		((Control)upload_csv_bulk_edit_metroButton1).set_Text("Upload Listings in csv");
		((Control)upload_csv_bulk_edit_metroButton1).add_Click((EventHandler)upload_csv_bulk_edit_metroButton1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)upload_csv_bulk_edit_metroButton1);
		((Control)this).get_Controls().Add((Control)(object)download_csv_bulk_edit_metroButton1);
		((Control)this).get_Controls().Add((Control)(object)bulk_price_permission_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label44);
		((Control)this).get_Controls().Add((Control)(object)bulk_price_edittor_filter_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label43);
		((Control)this).get_Controls().Add((Control)(object)delay_bulk_price_edittor_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label42);
		((Control)this).get_Controls().Add((Control)(object)label40);
		((Control)this).get_Controls().Add((Control)(object)label39);
		((Control)this).get_Controls().Add((Control)(object)fetch_all_listing_bulk_price_edittor_checkBox1);
		((Control)this).get_Controls().Add((Control)(object)bulk_price_edittor_fetch_listing_button);
		((Control)this).get_Controls().Add((Control)(object)bulk_price_edittor_listing_count_textbox);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1_bulk_price_editor);
		((Control)this).get_Controls().Add((Control)(object)label41);
		((Control)this).set_Name("Pro_bulk_price_editor");
		((Control)this).set_Size(new Size(802, 376));
		((ISupportInitialize)dataGridView1_bulk_price_editor).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
