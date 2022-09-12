using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Poshmark_tools;

namespace WindowsFormsApplication1;

public class Pro_closet_backup : UserControl
{
	private CheckBox headerCheckBox = new CheckBox();

	private IContainer components = null;

	private MetroLabel label47;

	private MetroLabel Delay_in_backup_listings;

	public MetroTextBox backup_copy_listing_delay_textBox2;

	public DataGridView upload_dataGridView1;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	public MetroButton save_backup_file_button1;

	public MetroButton load_backup_file_button1;

	public MetroButton generate_backup_listings_grid_button1;

	public MetroButton backup_listings;

	private SaveFileDialog saveFileDialog1;

	public Pro_closet_backup()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		InitializeComponent();
		Rectangle cellDisplayRectangle = upload_dataGridView1.GetCellDisplayRectangle(0, -1, true);
		cellDisplayRectangle.Y = 3;
		cellDisplayRectangle.X = cellDisplayRectangle.Location.X + 3 + cellDisplayRectangle.Width / 4;
		((Control)headerCheckBox).set_Location(cellDisplayRectangle.Location);
		((Control)headerCheckBox).set_BackColor(Color.White);
		((Control)headerCheckBox).set_Size(new Size(18, 18));
		((Control)headerCheckBox).add_Click((EventHandler)HeaderCheckBox_Clicked_upload);
		((Control)upload_dataGridView1).get_Controls().Add((Control)(object)headerCheckBox);
		upload_dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(DataGridView_CellClick));
	}

	public void start_poshmark__uploader()
	{
		upload_listing upload_listing2 = new upload_listing();
		upload_listing2.main_upload_listing();
	}

	private void generate_backup_listings_grid_button1_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			TextBox status_textBox = Form1.mainform.status_textBox1;
			object obj = _003C_003Ec._003C_003E9__3_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Generating backup listings on grid \r\n");
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__3_0 = val;
			}
			((Control)status_textBox).Invoke((Delegate)obj);
			upload_dataGridView1.get_Rows().Clear();
			if (File.Exists(update_app.folder_path_backup + "\\backups.bk"))
			{
				List<string> list = File.ReadAllLines(update_app.folder_path_backup + "\\backups.bk").ToList();
				foreach (string item in list)
				{
					if (!item.Contains("<--<---A-->-->") || !item.Contains("<--<---B-->-->") || !item.Contains("<--<---C-->-->"))
					{
						continue;
					}
					if (!(item.TrimStart(new char[0]).TrimEnd(new char[0]) == ""))
					{
						string title = item.Substring(0, item.IndexOf("<--<---A-->-->"));
						((Control)upload_dataGridView1).Invoke((Delegate)(MethodInvoker)delegate
						{
							upload_dataGridView1.get_Rows().Add(new object[4] { false, title, "", "" });
						});
					}
				}
			}
			else
			{
				TextBox status_textBox2 = Form1.mainform.status_textBox1;
				object obj2 = _003C_003Ec._003C_003E9__3_2;
				if (obj2 == null)
				{
					MethodInvoker val2 = delegate
					{
						((TextBoxBase)Form1.mainform.status_textBox1).AppendText("No Backup Exists \r\n");
					};
					obj2 = (object)val2;
					_003C_003Ec._003C_003E9__3_2 = val2;
				}
				((Control)status_textBox2).Invoke((Delegate)obj2);
			}
			TextBox status_textBox3 = Form1.mainform.status_textBox1;
			object obj3 = _003C_003Ec._003C_003E9__3_3;
			if (obj3 == null)
			{
				MethodInvoker val3 = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Backup Listing on Grid Finished \r\n");
				};
				obj3 = (object)val3;
				_003C_003Ec._003C_003E9__3_3 = val3;
			}
			((Control)status_textBox3).Invoke((Delegate)obj3);
			((Control)headerCheckBox).add_Click((EventHandler)HeaderCheckBox_Clicked_upload);
			try
			{
				((Control)upload_dataGridView1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((Control)upload_dataGridView1).get_Controls().Add((Control)(object)headerCheckBox);
				});
				((Control)headerCheckBox).Invoke((Delegate)(MethodInvoker)delegate
				{
					headerCheckBox.set_Checked(false);
				});
			}
			catch
			{
			}
			upload_dataGridView1.add_CellContentClick(new DataGridViewCellEventHandler(DataGridView_CellClick));
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error in loading backup file \r\n" + ex.ToString());
		}
	}

	private void HeaderCheckBox_Clicked_upload(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		upload_dataGridView1.EndEdit();
		foreach (DataGridViewRow item in (IEnumerable)upload_dataGridView1.get_Rows())
		{
			DataGridViewRow val = item;
			DataGridViewCell obj = val.get_Cells().get_Item("dataGridViewCheckBoxColumn1");
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
		foreach (DataGridViewRow item in (IEnumerable)upload_dataGridView1.get_Rows())
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

	private void backup_listings_Click(object sender, EventArgs e)
	{
		try
		{
			Form1.t.Abort();
		}
		catch
		{
		}
		Form1.t = new Thread((ThreadStart)delegate
		{
			backup_listings_fun();
		});
		Form1.t.Start();
	}

	public void backup_listings_fun()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected O, but got Unknown
		//IL_09d9: Expected O, but got Unknown
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected O, but got Unknown
		//IL_0b6c: Expected O, but got Unknown
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected O, but got Unknown
		if (File.Exists(update_app.folder_path_backup + "\\backups.bk"))
		{
			File.Delete(update_app.folder_path_backup + "\\backups.bk");
		}
		try
		{
			foreach (string item in Directory.EnumerateFiles(update_app.folder_path_backup, "*.jpg"))
			{
				File.Delete(item);
			}
		}
		catch
		{
		}
		((Control)upload_dataGridView1).Invoke((Delegate)(MethodInvoker)delegate
		{
			upload_dataGridView1.get_Rows().Clear();
		});
		login_poshmark login_poshmark2 = new login_poshmark();
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj2 = _003C_003Ec._003C_003E9__7_1;
		if (obj2 == null)
		{
			MethodInvoker val = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Going For Backup Listing\r\n");
			};
			obj2 = (object)val;
			_003C_003Ec._003C_003E9__7_1 = val;
		}
		((Control)status_textBox).Invoke((Delegate)obj2);
		Form1.cookie_Set();
		string text = login_poshmark2.check_who_is_logined(Form1.ck);
		string text2 = "";
		string token = Form1.ed.return_csrf_token(Form1.ck);
		if (text != null)
		{
			text2 = text.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
			string listing_quantity = "";
			string party_id = Form1.ed.get_eventid(Form1.ck, token);
			listing_quantity = Form1.ed.get_logined_available_items(Form1.ck);
			List<extract_data.Listing_info> list = Form1.ed.extract_listings_from_closet(text2, listing_quantity, party_id, ref token, ref Form1.ck, default(EditSchdParameters.SchdParametersStruct));
			edit_listing edit_listing2 = new edit_listing();
			((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Total Listing found " + listing_quantity + "\r\n");
			});
			edit_listing2.edit_listing_main("initialized", Form1.mainform, 0);
			int delay = 30;
			if (!(((Control)backup_copy_listing_delay_textBox2).get_Text() == ""))
			{
				delay = Form1.ed.delay_value_getter(((Control)backup_copy_listing_delay_textBox2).get_Text());
			}
			JavaScriptSerializer val2 = new JavaScriptSerializer();
			int iter;
			MethodInvoker val4 = default(MethodInvoker);
			MethodInvoker val7 = default(MethodInvoker);
			foreach (extract_data.Listing_info Listings in list)
			{
				dynamic jsonObject = null;
				((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Going for backup: " + Listings.listing_name + "\r\n");
				});
				string text3 = "";
				text3 = ((!Listings.listing_link.Contains("post_id=")) ? Listings.listing_link : Listings.listing_link.Substring(Listings.listing_link.IndexOf("post_id=") + 8, Listings.listing_link.Length - (Listings.listing_link.IndexOf("post_id=") + 8)));
				string text4 = edit_listing2.get_edit_string(text3, upload_or_edit: false);
				string text5 = text4.Substring(text4.IndexOf("{"), text4.Length - text4.IndexOf("{"));
				try
				{
					text5 = text5.Substring(0, text5.LastIndexOf(";(function(){va"));
					jsonObject = val2.Deserialize<object>(text5);
					try
					{
						string text6 = jsonObject["$_listing_editor"]["post"]["cover_shot"]["id"];
						string fileName = update_app.folder_path_backup + "\\" + text6 + ".jpg";
						TextBox status_textBox2 = Form1.mainform.status_textBox1;
						object obj3 = _003C_003Ec._003C_003E9__7_5;
						if (obj3 == null)
						{
							MethodInvoker val3 = delegate
							{
								((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Downloading Cover image \r\n");
							};
							obj3 = (object)val3;
							_003C_003Ec._003C_003E9__7_5 = val3;
						}
						((Control)status_textBox2).Invoke((Delegate)obj3);
						using WebClient webClient = new WebClient();
						webClient.DownloadFile(new Uri(jsonObject["$_listing_editor"]["post"]["cover_shot"]["url_large"]), fileName);
					}
					catch
					{
					}
					iter = 1;
					foreach (dynamic item2 in jsonObject["$_listing_editor"]["post"]["pictures"])
					{
						try
						{
							string fileName2 = update_app.folder_path_backup + "\\" + item2["id"] + ".jpg";
							TextBox status_textBox3 = Form1.mainform.status_textBox1;
							MethodInvoker obj5 = val4;
							if (obj5 == null)
							{
								MethodInvoker val5 = delegate
								{
									Form1.mainform.status_textBox1.AppendText("Downloading image " + iter + "/" + jsonObject["$_listing_editor"]["post"]["pictures"].Length + "\r\n");
								};
								MethodInvoker val6 = val5;
								val4 = val5;
								obj5 = val6;
							}
							((Control)status_textBox3).Invoke((Delegate)(object)obj5);
							using WebClient webClient2 = new WebClient();
							webClient2.DownloadFile(new Uri(item2["url_large"]), fileName2);
						}
						catch
						{
						}
						iter++;
					}
				}
				catch
				{
				}
				File.AppendAllText(update_app.folder_path_backup + "\\backups.bk", Listings.listing_name + "<--<---A-->-->" + Listings.listing_link + "<--<---B-->-->" + text5 + "<--<---C-->-->\r\n");
				TextBox status_textBox4 = Form1.mainform.status_textBox1;
				MethodInvoker obj8 = val7;
				if (obj8 == null)
				{
					MethodInvoker val8 = delegate
					{
						((TextBoxBase)Form1.mainform.status_textBox1).AppendText("APP in Sleep for " + delay + "Seconds " + DateTime.Now.ToString() + "\r\n");
					};
					MethodInvoker val6 = val8;
					val7 = val8;
					obj8 = val6;
				}
				((Control)status_textBox4).Invoke((Delegate)(object)obj8);
				try
				{
					delay = Form1.ed.delay_value_getter(((Control)backup_copy_listing_delay_textBox2).get_Text());
				}
				catch
				{
					delay = Form1.ed.delay_value_getter("25,35");
				}
				Thread.Sleep(delay * 1000);
			}
			try
			{
				generate_backup_listings_grid_button1_Click(null, null);
			}
			catch
			{
			}
			TextBox status_textBox5 = Form1.mainform.status_textBox1;
			object obj11 = _003C_003Ec._003C_003E9__7_8;
			if (obj11 == null)
			{
				MethodInvoker val9 = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("BackUp Finished\r\n");
				};
				obj11 = (object)val9;
				_003C_003Ec._003C_003E9__7_8 = val9;
			}
			((Control)status_textBox5).Invoke((Delegate)obj11);
			return;
		}
		TextBox status_textBox6 = Form1.mainform.status_textBox1;
		object obj12 = _003C_003Ec._003C_003E9__7_2;
		if (obj12 == null)
		{
			MethodInvoker val10 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Not able to login\r\n");
			};
			obj12 = (object)val10;
			_003C_003Ec._003C_003E9__7_2 = val10;
		}
		((Control)status_textBox6).Invoke((Delegate)obj12);
	}

	private void load_backup_file_button1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Title("Browse Backup Files");
			((FileDialog)val).set_Filter("bk files (*.bzip)|*.bzip|All files (*.*)|*.*");
			((CommonDialog)val).ShowDialog();
			string fileName = ((FileDialog)val).get_FileName();
			if (fileName != "")
			{
				try
				{
					if (File.Exists(update_app.folder_path_backup + "\\backups.bk"))
					{
						File.Delete(update_app.folder_path_backup + "\\backups.bk");
						foreach (string item in Directory.EnumerateFiles(update_app.folder_path_backup, "*"))
						{
							File.Delete(item);
						}
					}
				}
				catch
				{
				}
				ZipFile.ExtractToDirectory(((FileDialog)val).get_FileName(), update_app.folder_path_backup);
				generate_backup_listings_grid_button1_Click(null, null);
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nBackup File Loaded");
			}
			else
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nNo File Selected");
			}
		}
		catch (Exception)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "011a) " + e.ToString() + "\r\n");
		}
	}

	private void save_backup_file_button1_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (File.Exists(update_app.folder_path_backup + "\\backups.bk"))
			{
				DialogResult val = ((CommonDialog)saveFileDialog1).ShowDialog();
				if ((int)val == 1)
				{
					string fileName = ((FileDialog)saveFileDialog1).get_FileName();
					if (fileName.Contains("."))
					{
						MessageBox.Show("Filename doesnot contains special characters like .");
						return;
					}
					fileName += ".bzip";
					string text = "";
					foreach (string item in Directory.EnumerateFiles(update_app.folder_path_backup, "*"))
					{
						text = text + item + ",";
					}
					generate_zip(text, fileName);
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nBackup File copied at " + fileName);
				}
				else
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nFolder Not Selected");
				}
			}
			else
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("\r\nNo backup file present, generate backup first");
			}
		}
		catch (Exception)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "011) " + e.ToString() + "\r\n");
		}
	}

	public void generate_zip(string zip_files_name, string zip_file_tiles)
	{
		string[] array = zip_files_name.Split(new char[1] { ',' });
		ZipArchive zipArchive = ZipFile.Open(zip_file_tiles, ZipArchiveMode.Create);
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text != "")
			{
				zipArchive.CreateEntryFromFile(text, Path.GetFileName(text), CompressionLevel.Optimal);
			}
		}
		zipArchive.Dispose();
	}

	private void backup_copy_listing_dela_textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

	private void backup_copy_listing_dela_textBox2_Click(object sender, EventArgs e)
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pro_closet_backup));
		label47 = new MetroLabel();
		save_backup_file_button1 = new MetroButton();
		load_backup_file_button1 = new MetroButton();
		Delay_in_backup_listings = new MetroLabel();
		backup_copy_listing_delay_textBox2 = new MetroTextBox();
		upload_dataGridView1 = new DataGridView();
		dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
		dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		generate_backup_listings_grid_button1 = new MetroButton();
		backup_listings = new MetroButton();
		saveFileDialog1 = new SaveFileDialog();
		((ISupportInitialize)upload_dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label47).set_AutoSize(true);
		((Control)label47).set_ForeColor(Color.Maroon);
		((Control)label47).set_Location(new Point(4, 466));
		((Control)label47).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label47).set_Name("label47");
		((Control)label47).set_Size(new Size(655, 95));
		label47.Style = MetroColorStyle.Brown;
		((Control)label47).set_TabIndex(58);
		((Control)label47).set_Text(componentResourceManager.GetString("label47.Text"));
		label47.UseStyleColors = true;
		((Control)save_backup_file_button1).set_Location(new Point(448, 65));
		((Control)save_backup_file_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)save_backup_file_button1).set_Name("save_backup_file_button1");
		((Control)save_backup_file_button1).set_Size(new Size(226, 42));
		((Control)save_backup_file_button1).set_TabIndex(57);
		((Control)save_backup_file_button1).set_Text("Save Backup File");
		((Control)save_backup_file_button1).add_Click((EventHandler)save_backup_file_button1_Click);
		((Control)load_backup_file_button1).set_Location(new Point(448, 14));
		((Control)load_backup_file_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)load_backup_file_button1).set_Name("load_backup_file_button1");
		((Control)load_backup_file_button1).set_Size(new Size(226, 42));
		((Control)load_backup_file_button1).set_TabIndex(56);
		((Control)load_backup_file_button1).set_Text("Load Backup File");
		((Control)load_backup_file_button1).add_Click((EventHandler)load_backup_file_button1_Click);
		((Control)Delay_in_backup_listings).set_AutoSize(true);
		((Control)Delay_in_backup_listings).set_Location(new Point(4, 85));
		((Control)Delay_in_backup_listings).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Delay_in_backup_listings).set_Name("Delay_in_backup_listings");
		((Control)Delay_in_backup_listings).set_Size(new Size(87, 19));
		Delay_in_backup_listings.Style = MetroColorStyle.Brown;
		((Control)Delay_in_backup_listings).set_TabIndex(55);
		((Control)Delay_in_backup_listings).set_Text("Delay (In Sec)");
		Delay_in_backup_listings.UseStyleColors = true;
		((Control)backup_copy_listing_delay_textBox2).set_Location(new Point(198, 85));
		((Control)backup_copy_listing_delay_textBox2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)backup_copy_listing_delay_textBox2).set_Name("backup_copy_listing_delay_textBox2");
		((Control)backup_copy_listing_delay_textBox2).set_Size(new Size(150, 31));
		backup_copy_listing_delay_textBox2.Style = MetroColorStyle.Brown;
		((Control)backup_copy_listing_delay_textBox2).set_TabIndex(54);
		((Control)backup_copy_listing_delay_textBox2).set_Text("50");
		backup_copy_listing_delay_textBox2.UseStyleColors = true;
		((Control)backup_copy_listing_delay_textBox2).add_Click((EventHandler)backup_copy_listing_dela_textBox2_Click);
		((Control)backup_copy_listing_delay_textBox2).add_KeyPress(new KeyPressEventHandler(backup_copy_listing_dela_textBox2_KeyPress));
		upload_dataGridView1.set_AllowUserToAddRows(false);
		upload_dataGridView1.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		upload_dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		upload_dataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)dataGridViewCheckBoxColumn1,
			(DataGridViewColumn)dataGridViewTextBoxColumn2,
			(DataGridViewColumn)dataGridViewTextBoxColumn5,
			(DataGridViewColumn)dataGridViewTextBoxColumn6
		});
		((Control)upload_dataGridView1).set_Location(new Point(4, 135));
		((Control)upload_dataGridView1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)upload_dataGridView1).set_Name("upload_dataGridView1");
		((Control)upload_dataGridView1).set_Size(new Size(1154, 326));
		((Control)upload_dataGridView1).set_TabIndex(53);
		((DataGridViewColumn)dataGridViewCheckBoxColumn1).set_HeaderText("Include");
		((DataGridViewColumn)dataGridViewCheckBoxColumn1).set_Name("dataGridViewCheckBoxColumn1");
		((DataGridViewColumn)dataGridViewTextBoxColumn2).set_HeaderText("Title");
		((DataGridViewColumn)dataGridViewTextBoxColumn2).set_Name("dataGridViewTextBoxColumn2");
		((DataGridViewBand)dataGridViewTextBoxColumn2).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn5).set_HeaderText("Description");
		((DataGridViewColumn)dataGridViewTextBoxColumn5).set_Name("dataGridViewTextBoxColumn5");
		((DataGridViewBand)dataGridViewTextBoxColumn5).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn6).set_HeaderText("Link");
		((DataGridViewColumn)dataGridViewTextBoxColumn6).set_Name("dataGridViewTextBoxColumn6");
		((DataGridViewBand)dataGridViewTextBoxColumn6).set_ReadOnly(true);
		((Control)generate_backup_listings_grid_button1).set_Location(new Point(783, 66));
		((Control)generate_backup_listings_grid_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)generate_backup_listings_grid_button1).set_Name("generate_backup_listings_grid_button1");
		((Control)generate_backup_listings_grid_button1).set_Size(new Size(375, 60));
		((Control)generate_backup_listings_grid_button1).set_TabIndex(52);
		((Control)generate_backup_listings_grid_button1).set_Text("Display all backed up listings");
		((Control)generate_backup_listings_grid_button1).add_Click((EventHandler)generate_backup_listings_grid_button1_Click);
		((Control)backup_listings).set_Location(new Point(3, 14));
		((Control)backup_listings).set_Margin(new Padding(4, 5, 4, 5));
		((Control)backup_listings).set_Name("backup_listings");
		((Control)backup_listings).set_Size(new Size(328, 60));
		((Control)backup_listings).set_TabIndex(51);
		((Control)backup_listings).set_Text("Backup Listings");
		((Control)backup_listings).add_Click((EventHandler)backup_listings_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label47);
		((Control)this).get_Controls().Add((Control)(object)save_backup_file_button1);
		((Control)this).get_Controls().Add((Control)(object)load_backup_file_button1);
		((Control)this).get_Controls().Add((Control)(object)Delay_in_backup_listings);
		((Control)this).get_Controls().Add((Control)(object)backup_copy_listing_delay_textBox2);
		((Control)this).get_Controls().Add((Control)(object)upload_dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)generate_backup_listings_grid_button1);
		((Control)this).get_Controls().Add((Control)(object)backup_listings);
		((Control)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Pro_closet_backup");
		((Control)this).set_Size(new Size(1170, 838));
		((ISupportInitialize)upload_dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
