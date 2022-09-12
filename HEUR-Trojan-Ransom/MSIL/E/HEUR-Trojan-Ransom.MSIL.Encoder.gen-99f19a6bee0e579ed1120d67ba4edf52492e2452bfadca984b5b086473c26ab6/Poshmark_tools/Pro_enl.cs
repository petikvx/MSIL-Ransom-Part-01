using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class Pro_enl : UserControl
{
	private CheckBox headerCheckBox = new CheckBox();

	private IContainer components = null;

	private MetroLabel label44;

	public MetroTextBox enl_filter_textBox2;

	private MetroLabel label43;

	public MetroTextBox delay_enl_textBox2;

	private MetroLabel label42;

	private MetroLabel label40;

	private MetroLabel label39;

	private MetroCheckBox fetch_all_listing_edit_list_checkBox1;

	public MetroButton enl_fetch_listing_button;

	private MetroTextBox enl_listing_count_textbox;

	public DataGridView dataGridView1_enl;

	private DataGridViewCheckBoxColumn checkbox;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private MetroLabel label41;

	public MetroCheckBox deleteCheckBox1;

	public MetroTextBox Enl_permission_textBox2;

	public Pro_enl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		InitializeComponent();
		try
		{
			Rectangle cellDisplayRectangle = dataGridView1_enl.GetCellDisplayRectangle(0, -1, true);
			cellDisplayRectangle.Y = 3;
			cellDisplayRectangle.X = cellDisplayRectangle.Location.X + 3 + cellDisplayRectangle.Width / 4;
			((Control)headerCheckBox).set_Location(cellDisplayRectangle.Location);
			((Control)headerCheckBox).set_BackColor(Color.White);
			((Control)headerCheckBox).set_Size(new Size(18, 18));
			((Control)headerCheckBox).add_Click((EventHandler)HeaderCheckBox_Clicked);
			((Control)dataGridView1_enl).get_Controls().Add((Control)(object)headerCheckBox);
			dataGridView1_enl.add_CellContentClick(new DataGridViewCellEventHandler(DataGridView_CellClick));
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

	private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (e.get_RowIndex() < 0 || e.get_ColumnIndex() != 4)
		{
			return;
		}
		bool @checked = true;
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1_enl.get_Rows())
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

	private void HeaderCheckBox_Clicked(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		dataGridView1_enl.EndEdit();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1_enl.get_Rows())
		{
			DataGridViewRow val = item;
			DataGridViewCell obj = val.get_Cells().get_Item("checkbox");
			DataGridViewCheckBoxCell val2 = (DataGridViewCheckBoxCell)(object)((obj is DataGridViewCheckBoxCell) ? obj : null);
			((DataGridViewCell)val2).set_Value((object)headerCheckBox.get_Checked());
		}
	}

	private void deleteCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (((CheckBox)deleteCheckBox1).get_Checked() && (int)MessageBox.Show("Are you sure you want to delete Listings?", "Delete Listings: ", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
		{
			((CheckBox)deleteCheckBox1).set_Checked(false);
		}
	}

	public void enl_fetch_listing_button_Click(object sender, EventArgs e)
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
		dataGridView1_enl.get_Rows().Clear();
		Form1.cookie_Set();
		string listing_quantity = "";
		if (((CheckBox)fetch_all_listing_edit_list_checkBox1).get_Checked())
		{
			listing_quantity = Form1.ed.get_logined_available_items(Form1.ck);
		}
		else
		{
			listing_quantity = ((Control)enl_listing_count_textbox).get_Text();
		}
		try
		{
			Form1.t.Abort();
		}
		catch
		{
		}
		string filter = ((Control)enl_filter_textBox2).get_Text();
		Form1.t = new Thread((ThreadStart)delegate
		{
			lets_extract_listings_for_enl(listing_quantity, filter);
		});
		Form1.t.Start();
	}

	private void lets_extract_listings_for_enl(string listing_quantity, string filter)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		try
		{
			MetroTextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__6_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Going for data extraction from closet\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__6_0 = val;
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
					Ld.price = item.listing_link;
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
					((Control)dataGridView1_enl).Invoke((Delegate)(MethodInvoker)delegate
					{
						dataGridView1_enl.get_Rows().Add(new object[4] { false, Ld.title, Ld.description, Ld.price });
					});
				}
			}
			MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
			object obj2 = _003C_003Ec._003C_003E9__6_2;
			if (obj2 == null)
			{
				MethodInvoker val2 = delegate
				{
					Form1.mainform.status_textBox1.AppendText("Data Extraction Completed from poshmark, Delete Rows that you dont want for ENL, and click start\r\n");
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__6_2 = val2;
			}
			((Control)status_textBox2).Invoke((Delegate)obj2);
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

	private void enl_listing_count_textbox_KeyPress(object sender, KeyPressEventArgs e)
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

	private void enl_filter_textBox2_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
	}

	private void fetch_all_listing_edit_list_checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		CheckBox val = (CheckBox)(object)(sender as MetroCheckBox);
		if (val.get_Checked())
		{
			((Control)enl_listing_count_textbox).set_Enabled(false);
			((Control)enl_filter_textBox2).set_Enabled(false);
		}
		else
		{
			((Control)enl_listing_count_textbox).set_Enabled(true);
			((Control)enl_filter_textBox2).set_Enabled(true);
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
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		label44 = new MetroLabel();
		enl_filter_textBox2 = new MetroTextBox();
		label43 = new MetroLabel();
		delay_enl_textBox2 = new MetroTextBox();
		label42 = new MetroLabel();
		label40 = new MetroLabel();
		label39 = new MetroLabel();
		fetch_all_listing_edit_list_checkBox1 = new MetroCheckBox();
		enl_fetch_listing_button = new MetroButton();
		enl_listing_count_textbox = new MetroTextBox();
		dataGridView1_enl = new DataGridView();
		checkbox = new DataGridViewCheckBoxColumn();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		label41 = new MetroLabel();
		deleteCheckBox1 = new MetroCheckBox();
		Enl_permission_textBox2 = new MetroTextBox();
		((ISupportInitialize)dataGridView1_enl).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label44).set_AutoSize(true);
		((Control)label44).set_ForeColor(Color.Maroon);
		((Control)label44).set_Location(new Point(164, 7));
		((Control)label44).set_Name("label44");
		((Control)label44).set_Size(new Size(90, 19));
		label44.Style = MetroColorStyle.Brown;
		((Control)label44).set_TabIndex(65);
		((Control)label44).set_Text("(50 free ENLs)");
		label44.UseStyleColors = true;
		((Control)label44).set_Visible(false);
		((Control)enl_filter_textBox2).set_ForeColor(Color.Black);
		((Control)enl_filter_textBox2).set_Location(new Point(462, 55));
		((Control)enl_filter_textBox2).set_Name("enl_filter_textBox2");
		((Control)enl_filter_textBox2).set_Size(new Size(316, 23));
		enl_filter_textBox2.Style = MetroColorStyle.Brown;
		((Control)enl_filter_textBox2).set_TabIndex(64);
		enl_filter_textBox2.UseStyleColors = true;
		((Control)enl_filter_textBox2).add_Click((EventHandler)enl_filter_textBox2_Click);
		((Control)label43).set_AutoSize(true);
		((Control)label43).set_Location(new Point(11, 57));
		((Control)label43).set_Name("label43");
		((Control)label43).set_Size(new Size(444, 19));
		label43.Style = MetroColorStyle.Brown;
		((Control)label43).set_TabIndex(63);
		((Control)label43).set_Text("Get Listings containg words (comma separated - Left blank if not required)");
		label43.UseStyleColors = true;
		((Control)delay_enl_textBox2).set_ForeColor(Color.Black);
		((Control)delay_enl_textBox2).set_Location(new Point(657, 84));
		((Control)delay_enl_textBox2).set_Name("delay_enl_textBox2");
		((Control)delay_enl_textBox2).set_Size(new Size(67, 23));
		delay_enl_textBox2.Style = MetroColorStyle.Brown;
		((Control)delay_enl_textBox2).set_TabIndex(62);
		((Control)delay_enl_textBox2).set_Text("60,120");
		delay_enl_textBox2.UseStyleColors = true;
		((Control)delay_enl_textBox2).add_Click((EventHandler)enl_filter_textBox2_Click);
		((Control)delay_enl_textBox2).add_KeyPress(new KeyPressEventHandler(enl_listing_count_textbox_KeyPress));
		((Control)label42).set_AutoSize(true);
		((Control)label42).set_Location(new Point(462, 86));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(189, 19));
		label42.Style = MetroColorStyle.Brown;
		((Control)label42).set_TabIndex(61);
		((Control)label42).set_Text("ENL after every X to X seconds");
		label42.UseStyleColors = true;
		((Control)label40).set_AutoSize(true);
		((Control)label40).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label40).set_Location(new Point(3, 339));
		((Control)label40).set_Name("label40");
		((Control)label40).set_Size(new Size(299, 19));
		label40.Style = MetroColorStyle.Brown;
		((Control)label40).set_TabIndex(59);
		((Control)label40).set_Text("Select any row and press delete to delete any row");
		label40.UseStyleColors = true;
		((Control)label39).set_AutoSize(true);
		((Control)label39).set_Location(new Point(11, 7));
		((Control)label39).set_Name("label39");
		((Control)label39).set_Size(new Size(43, 19));
		label39.Style = MetroColorStyle.Brown;
		((Control)label39).set_TabIndex(58);
		((Control)label39).set_Text("Status");
		label39.UseStyleColors = true;
		((Control)label39).set_Visible(false);
		((Control)fetch_all_listing_edit_list_checkBox1).set_AutoSize(true);
		((Control)fetch_all_listing_edit_list_checkBox1).set_Location(new Point(210, 33));
		((Control)fetch_all_listing_edit_list_checkBox1).set_Name("fetch_all_listing_edit_list_checkBox1");
		((Control)fetch_all_listing_edit_list_checkBox1).set_Size(new Size(109, 15));
		fetch_all_listing_edit_list_checkBox1.Style = MetroColorStyle.Brown;
		((Control)fetch_all_listing_edit_list_checkBox1).set_TabIndex(56);
		((Control)fetch_all_listing_edit_list_checkBox1).set_Text("Fetch All listings");
		fetch_all_listing_edit_list_checkBox1.UseStyleColors = true;
		((ButtonBase)fetch_all_listing_edit_list_checkBox1).set_UseVisualStyleBackColor(false);
		((CheckBox)fetch_all_listing_edit_list_checkBox1).add_CheckedChanged((EventHandler)fetch_all_listing_edit_list_checkBox1_CheckedChanged);
		((Control)enl_fetch_listing_button).set_Location(new Point(462, 7));
		((Control)enl_fetch_listing_button).set_Name("enl_fetch_listing_button");
		((Control)enl_fetch_listing_button).set_Size(new Size(219, 39));
		((Control)enl_fetch_listing_button).set_TabIndex(55);
		((Control)enl_fetch_listing_button).set_Text("Fetch Listings");
		((Control)enl_fetch_listing_button).add_Click((EventHandler)enl_fetch_listing_button_Click);
		((Control)enl_listing_count_textbox).set_ForeColor(Color.Black);
		((Control)enl_listing_count_textbox).set_Location(new Point(80, 31));
		((Control)enl_listing_count_textbox).set_Name("enl_listing_count_textbox");
		((Control)enl_listing_count_textbox).set_Size(new Size(51, 23));
		((Control)enl_listing_count_textbox).set_TabIndex(54);
		((Control)enl_listing_count_textbox).set_Text("30");
		((Control)enl_listing_count_textbox).add_Click((EventHandler)enl_filter_textBox2_Click);
		((Control)enl_listing_count_textbox).add_KeyPress(new KeyPressEventHandler(enl_listing_count_textbox_KeyPress));
		dataGridView1_enl.set_AllowUserToAddRows(false);
		dataGridView1_enl.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView1_enl.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1_enl.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)checkbox,
			(DataGridViewColumn)dataGridViewTextBoxColumn1,
			(DataGridViewColumn)dataGridViewTextBoxColumn3,
			(DataGridViewColumn)dataGridViewTextBoxColumn4
		});
		((Control)dataGridView1_enl).set_Location(new Point(3, 113));
		((Control)dataGridView1_enl).set_Name("dataGridView1_enl");
		((Control)dataGridView1_enl).set_Size(new Size(769, 223));
		((Control)dataGridView1_enl).set_TabIndex(53);
		((DataGridViewColumn)checkbox).set_HeaderText("Include");
		((DataGridViewColumn)checkbox).set_Name("checkbox");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_HeaderText("Title");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_Name("dataGridViewTextBoxColumn1");
		((DataGridViewBand)dataGridViewTextBoxColumn1).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn3).set_HeaderText("Description");
		((DataGridViewColumn)dataGridViewTextBoxColumn3).set_Name("dataGridViewTextBoxColumn3");
		((DataGridViewBand)dataGridViewTextBoxColumn3).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn4).set_HeaderText("Link");
		((DataGridViewColumn)dataGridViewTextBoxColumn4).set_Name("dataGridViewTextBoxColumn4");
		((DataGridViewBand)dataGridViewTextBoxColumn4).set_ReadOnly(true);
		((Control)label41).set_AutoSize(true);
		((Control)label41).set_Location(new Point(11, 31));
		((Control)label41).set_Name("label41");
		((Control)label41).set_Size(new Size(193, 19));
		label41.Style = MetroColorStyle.Brown;
		((Control)label41).set_TabIndex(60);
		((Control)label41).set_Text("Fetch first                Listings OR");
		label41.UseStyleColors = true;
		((Control)deleteCheckBox1).set_AutoSize(true);
		((Control)deleteCheckBox1).set_Location(new Point(11, 86));
		((Control)deleteCheckBox1).set_Name("deleteCheckBox1");
		((Control)deleteCheckBox1).set_Size(new Size(99, 15));
		deleteCheckBox1.Style = MetroColorStyle.Brown;
		((Control)deleteCheckBox1).set_TabIndex(66);
		((Control)deleteCheckBox1).set_Text("Delete Listings");
		deleteCheckBox1.UseStyleColors = true;
		((ButtonBase)deleteCheckBox1).set_UseVisualStyleBackColor(false);
		((CheckBox)deleteCheckBox1).add_CheckedChanged((EventHandler)deleteCheckBox1_CheckedChanged);
		((Control)Enl_permission_textBox2).set_Location(new Point(60, 5));
		((Control)Enl_permission_textBox2).set_Name("Enl_permission_textBox2");
		Enl_permission_textBox2.ReadOnly = true;
		((Control)Enl_permission_textBox2).set_Size(new Size(98, 23));
		Enl_permission_textBox2.Style = MetroColorStyle.Brown;
		((Control)Enl_permission_textBox2).set_TabIndex(67);
		((Control)Enl_permission_textBox2).set_Text("Not permitted");
		Enl_permission_textBox2.UseStyleColors = true;
		((Control)Enl_permission_textBox2).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Enl_permission_textBox2);
		((Control)this).get_Controls().Add((Control)(object)deleteCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)label44);
		((Control)this).get_Controls().Add((Control)(object)enl_filter_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label43);
		((Control)this).get_Controls().Add((Control)(object)delay_enl_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label42);
		((Control)this).get_Controls().Add((Control)(object)label40);
		((Control)this).get_Controls().Add((Control)(object)label39);
		((Control)this).get_Controls().Add((Control)(object)fetch_all_listing_edit_list_checkBox1);
		((Control)this).get_Controls().Add((Control)(object)enl_fetch_listing_button);
		((Control)this).get_Controls().Add((Control)(object)enl_listing_count_textbox);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1_enl);
		((Control)this).get_Controls().Add((Control)(object)label41);
		((Control)this).set_Name("Pro_enl");
		((Control)this).set_Size(new Size(781, 366));
		((ISupportInitialize)dataGridView1_enl).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
