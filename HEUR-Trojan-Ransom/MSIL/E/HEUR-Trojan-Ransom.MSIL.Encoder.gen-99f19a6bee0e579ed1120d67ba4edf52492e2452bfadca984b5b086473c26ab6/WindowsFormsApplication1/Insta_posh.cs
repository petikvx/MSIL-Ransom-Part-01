using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Poshmark_tools;

namespace WindowsFormsApplication1;

public class Insta_posh : UserControl
{
	private instagram_upload insta = new instagram_upload();

	private IContainer components = null;

	private MetroLabel label50;

	public DataGridView dataGridView1_instaposh;

	private DataGridViewTextBoxColumn Title;

	private DataGridViewTextBoxColumn Hashtags;

	private DataGridViewTextBoxColumn Description;

	private DataGridViewTextBoxColumn Price;

	private DataGridViewTextBoxColumn Image;

	private MetroCheckBox allItem_instaposh_checkBox1;

	private MetroTextBox quantity_instaposh_textBox2;

	public MetroTextBox instagram_password_textBox3;

	public MetroTextBox instagram_username_textBox2;

	private MetroLabel label18;

	private MetroLabel label17;

	private MetroLabel label16;

	public MetroButton instagram_image_upload_button1;

	private MetroLabel metroLabel1;

	private MetroLabel metroLabel3;

	public MetroTextBox metroTextBox1;

	public MetroButton instagram_code_submit_metroButton1;

	public Insta_posh()
	{
		InitializeComponent();
	}

	public bool check_required_things()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		if (!((CheckBox)allItem_instaposh_checkBox1).get_Checked() && ((Control)quantity_instaposh_textBox2).get_Text() == "")
		{
			MetroTextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__2_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide Quantity of upload in Instaposh\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__2_0 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			return false;
		}
		if (((Control)instagram_username_textBox2).get_Text() == "" && ((Control)instagram_password_textBox3).get_Text() == "")
		{
			MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
			object obj2 = _003C_003Ec._003C_003E9__2_1;
			if (obj2 == null)
			{
				MethodInvoker val2 = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Provide Username and password in Instaposh\r\n");
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__2_1 = val2;
			}
			((Control)status_textBox2).Invoke((Delegate)obj2);
			return false;
		}
		return true;
	}

	public void start_insta__posh()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		((Control)instagram_image_upload_button1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)instagram_image_upload_button1).set_Enabled(false);
		});
		MetroTextBox status_textBox = Form1.mainform.status_textBox1;
		object obj = _003C_003Ec._003C_003E9__3_1;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Starting Extracting Data From Closet\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__3_1 = val;
		}
		((Control)status_textBox).Invoke((Delegate)obj);
		((Control)dataGridView1_instaposh).Invoke((Delegate)(MethodInvoker)delegate
		{
			dataGridView1_instaposh.get_Rows().Clear();
		});
		((Control)dataGridView1_instaposh).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)dataGridView1_instaposh).Refresh();
		});
		try
		{
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\images"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\images");
			}
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
		string text = Form1.lg.check_who_is_logined(Form1.ck);
		string closet_name = "";
		string text2 = "";
		if (text != null)
		{
			closet_name = text.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
		}
		else
		{
			MessageBox.Show("Eror101");
		}
		text2 = ((!((CheckBox)allItem_instaposh_checkBox1).get_Checked()) ? ((Control)quantity_instaposh_textBox2).get_Text() : Form1.ed.get_logined_available_items(Form1.ck));
		string token = Form1.ed.return_csrf_token(Form1.ck);
		string party_id = Form1.ed.get_eventid(Form1.ck, token);
		List<extract_data.Listing_info> list = Form1.ed.extract_listings_from_closet(closet_name, text2, party_id, ref token, ref Form1.ck, default(EditSchdParameters.SchdParametersStruct));
		foreach (extract_data.Listing_info item in list)
		{
			extract_data.Listng_data Ld = default(extract_data.Listng_data);
			Ld = Form1.ed.extract_listings_data_listinglink(item.listing_link.Replace("share?post_id=", ""), ref token, ref Form1.ck);
			((Control)dataGridView1_instaposh).Invoke((Delegate)(MethodInvoker)delegate
			{
				dataGridView1_instaposh.get_Rows().Add(new object[5] { Ld.title, "", Ld.description, Ld.price, Ld.image_link });
			});
		}
		MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
		object obj3 = _003C_003Ec._003C_003E9__3_5;
		if (obj3 == null)
		{
			MethodInvoker val2 = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Data Extraction Completed from poshmark, click upload button to upload on Instagram\r\n");
			};
			obj3 = (object)val2;
			_003C_003Ec._003C_003E9__3_5 = val2;
		}
		((Control)status_textBox2).Invoke((Delegate)obj3);
		((Control)instagram_image_upload_button1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)instagram_image_upload_button1).set_Enabled(true);
		});
	}

	private void allItem_instaposh_checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		CheckBox val = (CheckBox)(object)(sender as MetroCheckBox);
		if (val.get_Checked())
		{
			((Control)quantity_instaposh_textBox2).set_Enabled(false);
		}
		else
		{
			((Control)quantity_instaposh_textBox2).set_Enabled(true);
		}
	}

	private void quantity_instaposh_textBox2_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
	}

	private void label50_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/watch?v=zM_OLE5Lpuk");
	}

	private async void instagram_image_upload_button1_Click(object sender, EventArgs e)
	{
		insta.instagram_uploader();
		await insta.initialize_and_login();
		if (instagram_upload.instagram_loign)
		{
			MetroTextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__7_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Going for Instagram Upload\r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__7_0 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			List<extract_data.Listng_data> ListingsDetails_list = new List<extract_data.Listng_data>();
			for (int rows = 0; rows < dataGridView1_instaposh.get_Rows().get_Count(); rows++)
			{
				extract_data.Listng_data ld = default(extract_data.Listng_data);
				ld.title = dataGridView1_instaposh.get_Rows().get_Item(rows).get_Cells()
					.get_Item(0)
					.get_Value()
					.ToString();
				ld.other_info = dataGridView1_instaposh.get_Rows().get_Item(rows).get_Cells()
					.get_Item(1)
					.get_Value()
					.ToString();
				ld.price = dataGridView1_instaposh.get_Rows().get_Item(rows).get_Cells()
					.get_Item(3)
					.get_Value()
					.ToString();
				ld.description = dataGridView1_instaposh.get_Rows().get_Item(rows).get_Cells()
					.get_Item(2)
					.get_Value()
					.ToString();
				ld.image_link = dataGridView1_instaposh.get_Rows().get_Item(rows).get_Cells()
					.get_Item(4)
					.get_Value()
					.ToString();
				if (File.Exists(ld.image_link))
				{
					ListingsDetails_list.Add(ld);
				}
			}
			MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
			object obj2 = _003C_003Ec._003C_003E9__7_1;
			if (obj2 == null)
			{
				MethodInvoker val2 = delegate
				{
					((Control)Form1.mainform.status_textBox1).set_Text("Going To upload on instagram\r\n");
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__7_1 = val2;
			}
			((Control)status_textBox2).Invoke((Delegate)obj2);
			((Control)instagram_image_upload_button1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)instagram_image_upload_button1).set_Enabled(false);
			});
			try
			{
				Form1.t.Abort();
			}
			catch
			{
			}
			Form1.t = new Thread((ThreadStart)delegate
			{
				insta.instagram_picture_uploader(Form1.mainform, ListingsDetails_list);
			});
			Form1.t.Start();
			return;
		}
		MetroTextBox status_textBox3 = Form1.mainform.status_textBox1;
		object obj4 = _003C_003Ec._003C_003E9__7_4;
		if (obj4 == null)
		{
			MethodInvoker val3 = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Not able to Login To Instagram\r\n");
			};
			obj4 = (object)val3;
			_003C_003Ec._003C_003E9__7_4 = val3;
		}
		((Control)status_textBox3).Invoke((Delegate)obj4);
	}

	private void quantity_instaposh_textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		label50 = new MetroLabel();
		instagram_image_upload_button1 = new MetroButton();
		dataGridView1_instaposh = new DataGridView();
		Title = new DataGridViewTextBoxColumn();
		Hashtags = new DataGridViewTextBoxColumn();
		Description = new DataGridViewTextBoxColumn();
		Price = new DataGridViewTextBoxColumn();
		Image = new DataGridViewTextBoxColumn();
		allItem_instaposh_checkBox1 = new MetroCheckBox();
		quantity_instaposh_textBox2 = new MetroTextBox();
		instagram_password_textBox3 = new MetroTextBox();
		instagram_username_textBox2 = new MetroTextBox();
		label18 = new MetroLabel();
		label17 = new MetroLabel();
		label16 = new MetroLabel();
		metroLabel1 = new MetroLabel();
		metroLabel3 = new MetroLabel();
		metroTextBox1 = new MetroTextBox();
		instagram_code_submit_metroButton1 = new MetroButton();
		((ISupportInitialize)dataGridView1_instaposh).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label50).set_AutoSize(true);
		((Control)label50).set_Cursor(Cursors.get_Hand());
		((Control)label50).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label50).set_Location(new Point(13, 64));
		((Control)label50).set_Name("label50");
		((Control)label50).set_Size(new Size(198, 19));
		label50.Style = MetroColorStyle.Brown;
		((Control)label50).set_TabIndex(38);
		((Control)label50).set_Text("How to use InstaPosh? Click here");
		label50.UseStyleColors = true;
		((Control)label50).add_Click((EventHandler)label50_Click);
		((Control)instagram_image_upload_button1).set_Location(new Point(530, 56));
		((Control)instagram_image_upload_button1).set_Name("instagram_image_upload_button1");
		((Control)instagram_image_upload_button1).set_Size(new Size(243, 30));
		((Control)instagram_image_upload_button1).set_TabIndex(37);
		((Control)instagram_image_upload_button1).set_Text("Upload on Instagram");
		((Control)instagram_image_upload_button1).add_Click((EventHandler)instagram_image_upload_button1_Click);
		dataGridView1_instaposh.set_AllowUserToAddRows(false);
		dataGridView1_instaposh.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView1_instaposh.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1_instaposh.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Title,
			(DataGridViewColumn)Hashtags,
			(DataGridViewColumn)Description,
			(DataGridViewColumn)Price,
			(DataGridViewColumn)Image
		});
		((Control)dataGridView1_instaposh).set_Location(new Point(13, 92));
		((Control)dataGridView1_instaposh).set_Name("dataGridView1_instaposh");
		((Control)dataGridView1_instaposh).set_Size(new Size(769, 237));
		((Control)dataGridView1_instaposh).set_TabIndex(36);
		((DataGridViewColumn)Title).set_HeaderText("Title");
		((DataGridViewColumn)Title).set_Name("Title");
		((DataGridViewBand)Title).set_ReadOnly(true);
		((DataGridViewColumn)Hashtags).set_HeaderText("1st Comment (Add here)");
		((DataGridViewColumn)Hashtags).set_Name("Hashtags");
		((DataGridViewColumn)Description).set_HeaderText("Description");
		((DataGridViewColumn)Description).set_Name("Description");
		((DataGridViewBand)Description).set_ReadOnly(true);
		((DataGridViewColumn)Price).set_HeaderText("Price");
		((DataGridViewColumn)Price).set_Name("Price");
		((DataGridViewBand)Price).set_ReadOnly(true);
		((DataGridViewColumn)Image).set_HeaderText("image");
		((DataGridViewColumn)Image).set_Name("Image");
		((DataGridViewBand)Image).set_ReadOnly(true);
		((Control)allItem_instaposh_checkBox1).set_AutoSize(true);
		((Control)allItem_instaposh_checkBox1).set_Location(new Point(614, 34));
		((Control)allItem_instaposh_checkBox1).set_Name("allItem_instaposh_checkBox1");
		((Control)allItem_instaposh_checkBox1).set_Size(new Size(159, 15));
		allItem_instaposh_checkBox1.Style = MetroColorStyle.Brown;
		((Control)allItem_instaposh_checkBox1).set_TabIndex(35);
		((Control)allItem_instaposh_checkBox1).set_Text("Upload All available items");
		allItem_instaposh_checkBox1.UseStyleColors = true;
		((ButtonBase)allItem_instaposh_checkBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)allItem_instaposh_checkBox1).add_CheckedChanged((EventHandler)allItem_instaposh_checkBox1_CheckedChanged);
		((Control)quantity_instaposh_textBox2).set_ForeColor(Color.LightGray);
		((Control)quantity_instaposh_textBox2).set_Location(new Point(530, 30));
		((Control)quantity_instaposh_textBox2).set_Name("quantity_instaposh_textBox2");
		((Control)quantity_instaposh_textBox2).set_Size(new Size(44, 20));
		((Control)quantity_instaposh_textBox2).set_TabIndex(34);
		((Control)quantity_instaposh_textBox2).set_Text("30");
		quantity_instaposh_textBox2.UseStyleColors = true;
		((Control)quantity_instaposh_textBox2).add_Click((EventHandler)quantity_instaposh_textBox2_Click);
		((Control)quantity_instaposh_textBox2).add_KeyPress(new KeyPressEventHandler(quantity_instaposh_textBox2_KeyPress));
		((Control)instagram_password_textBox3).set_ForeColor(SystemColors.GrayText);
		((Control)instagram_password_textBox3).set_Location(new Point(148, 34));
		((Control)instagram_password_textBox3).set_Name("instagram_password_textBox3");
		instagram_password_textBox3.PasswordChar = '●';
		((Control)instagram_password_textBox3).set_Size(new Size(180, 20));
		instagram_password_textBox3.Style = MetroColorStyle.Brown;
		((Control)instagram_password_textBox3).set_TabIndex(31);
		instagram_password_textBox3.UseStyleColors = true;
		instagram_password_textBox3.UseSystemPasswordChar = true;
		((Control)instagram_password_textBox3).add_Click((EventHandler)quantity_instaposh_textBox2_Click);
		((Control)instagram_username_textBox2).set_ForeColor(SystemColors.GrayText);
		((Control)instagram_username_textBox2).set_Location(new Point(148, 8));
		((Control)instagram_username_textBox2).set_Name("instagram_username_textBox2");
		((Control)instagram_username_textBox2).set_Size(new Size(180, 20));
		instagram_username_textBox2.Style = MetroColorStyle.Brown;
		((Control)instagram_username_textBox2).set_TabIndex(29);
		instagram_username_textBox2.UseStyleColors = true;
		((Control)instagram_username_textBox2).add_Click((EventHandler)quantity_instaposh_textBox2_Click);
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Location(new Point(530, 8));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(233, 19));
		label18.Style = MetroColorStyle.Brown;
		((Control)label18).set_TabIndex(33);
		((Control)label18).set_Text("# of Listings to import from Poshmark");
		label18.UseStyleColors = true;
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Location(new Point(13, 35));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(125, 19));
		label17.Style = MetroColorStyle.Brown;
		((Control)label17).set_TabIndex(32);
		((Control)label17).set_Text("Instagram Password");
		label17.UseStyleColors = true;
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(12, 9));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(130, 19));
		label16.Style = MetroColorStyle.Brown;
		((Control)label16).set_TabIndex(30);
		((Control)label16).set_Text("Instagram Username");
		label16.UseStyleColors = true;
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_Location(new Point(580, 31));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(28, 19));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(39);
		((Control)metroLabel1).set_Text("OR");
		metroLabel1.UseStyleColors = true;
		((Control)metroLabel3).set_AutoSize(true);
		((Control)metroLabel3).set_Location(new Point(13, 332));
		((Control)metroLabel3).set_Name("metroLabel3");
		((Control)metroLabel3).set_Size(new Size(713, 19));
		metroLabel3.Style = MetroColorStyle.Brown;
		((Control)metroLabel3).set_TabIndex(41);
		((Control)metroLabel3).set_Text("1) Click start to fetch Poshmark listings. 2) Delete Unwanted Rows. 3) Click Upload on Instagram Button to start uploading");
		metroLabel3.UseStyleColors = true;
		((Control)metroTextBox1).set_ForeColor(SystemColors.GrayText);
		((Control)metroTextBox1).set_Location(new Point(387, 9));
		((Control)metroTextBox1).set_Name("metroTextBox1");
		metroTextBox1.PasswordChar = '●';
		((Control)metroTextBox1).set_Size(new Size(102, 20));
		metroTextBox1.Style = MetroColorStyle.Brown;
		((Control)metroTextBox1).set_TabIndex(42);
		metroTextBox1.UseStyleColors = true;
		metroTextBox1.UseSystemPasswordChar = true;
		((Control)metroTextBox1).set_Visible(false);
		((Control)instagram_code_submit_metroButton1).set_Location(new Point(387, 35));
		((Control)instagram_code_submit_metroButton1).set_Name("instagram_code_submit_metroButton1");
		((Control)instagram_code_submit_metroButton1).set_Size(new Size(102, 30));
		((Control)instagram_code_submit_metroButton1).set_TabIndex(43);
		((Control)instagram_code_submit_metroButton1).set_Text("Submit code");
		((Control)instagram_code_submit_metroButton1).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)instagram_code_submit_metroButton1);
		((Control)this).get_Controls().Add((Control)(object)metroTextBox1);
		((Control)this).get_Controls().Add((Control)(object)metroLabel3);
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)label50);
		((Control)this).get_Controls().Add((Control)(object)instagram_image_upload_button1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1_instaposh);
		((Control)this).get_Controls().Add((Control)(object)allItem_instaposh_checkBox1);
		((Control)this).get_Controls().Add((Control)(object)quantity_instaposh_textBox2);
		((Control)this).get_Controls().Add((Control)(object)instagram_password_textBox3);
		((Control)this).get_Controls().Add((Control)(object)instagram_username_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label18);
		((Control)this).get_Controls().Add((Control)(object)label17);
		((Control)this).get_Controls().Add((Control)(object)label16);
		((Control)this).set_Name("Insta_posh");
		((Control)this).set_Size(new Size(809, 359));
		((ISupportInitialize)dataGridView1_instaposh).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
