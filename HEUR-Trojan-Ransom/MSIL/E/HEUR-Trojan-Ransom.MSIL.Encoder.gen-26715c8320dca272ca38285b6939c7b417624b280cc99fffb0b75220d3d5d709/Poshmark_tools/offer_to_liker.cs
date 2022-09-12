using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using HtmlAgilityPack;
using MetroFramework;
using MetroFramework.Controls;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class offer_to_liker : UserControl
{
	private CheckBox headerCheckBox = new CheckBox();

	private IContainer components = null;

	public MetroButton update_price_metroButton1;

	public DataGridView dataGridView1_offer_likers;

	public MetroButton offers_listings_fetch_button;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn discount;

	private DataGridViewCheckBoxColumn shipping;

	private MetroLabel metroLabel1;

	public MetroTextBox offer_percentage_textBox2;

	public MetroTextBox delay_offer_textBox2;

	private MetroLabel label42;

	private MetroLabel metroLabel2;

	private MetroLabel metroLabel3;

	public offer_to_liker()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		InitializeComponent();
		ColumnCheckbox(dataGridView1_offer_likers);
	}

	public void lets_extract_offer_listings()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Expected O, but got Unknown
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_100d: Expected O, but got Unknown
		//IL_103a: Unknown result type (might be due to invalid IL or missing references)
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1045: Expected O, but got Unknown
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Expected O, but got Unknown
		//IL_1087: Unknown result type (might be due to invalid IL or missing references)
		//IL_1091: Expected O, but got Unknown
		//IL_109f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a9: Expected O, but got Unknown
		((Control)offers_listings_fetch_button).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)offers_listings_fetch_button).set_Enabled(false);
		});
		MetroButton start_button = Form1.mainform.Start_button1;
		object obj = _003C_003Ec._003C_003E9__2_1;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.Start_button1).set_Enabled(false);
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__2_1 = val;
		}
		((Control)start_button).Invoke((Delegate)obj);
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj2 = _003C_003Ec._003C_003E9__2_2;
		if (obj2 == null)
		{
			MethodInvoker val2 = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Extracting listings recently liked \r\n");
			};
			obj2 = (object)val2;
			_003C_003Ec._003C_003E9__2_2 = val2;
		}
		((Control)status_textBox).Invoke((Delegate)obj2);
		try
		{
			Form1.cookie_Set();
			new HtmlDocument();
			int i = 0;
			List<string> unique_ids = new List<string>();
			string text = "";
			string text2 = Form1.ed.return_login_uid(Form1.ck);
			string title;
			string link;
			string price;
			for (; i < 10; i++)
			{
				try
				{
					string url = "https://poshmark.com/vm-rest/users/" + text2 + "/newsfeed/like?" + text + "&pm_version=134.0.0";
					if (Form1.wb.Request_poshmark_com(out var response, url, 1, "", Form1.ck))
					{
						string text3 = Form1.wb.ReadResponse(response);
						JavaScriptSerializer val3 = new JavaScriptSerializer();
						dynamic obj3 = null;
						obj3 = val3.Deserialize<object>(text3);
						try
						{
							if (obj3["error"]["userMessage"] == "Something went wrong! Please try again later")
							{
								break;
							}
						}
						catch
						{
						}
						foreach (dynamic item in obj3["data"])
						{
							try
							{
								_ = (string)item["content"]["data"][0]["news_item"]["actor"]["data"][0]["username"];
								string text4 = item["content"]["data"][0]["news_item"]["message"];
								if (!text4.Contains("Make an offer to all Likers now"))
								{
									continue;
								}
								string text5 = item["content"]["data"][0]["news_item"]["content"]["data"][0]["id"];
								string url2 = "https://poshmark.com/vm-rest/posts/" + text5 + "?app_version=2.55&pm_version=134.0.0";
								if (unique_ids.Contains(text5))
								{
									continue;
								}
								unique_ids.Add(text5);
								if (Form1.wb.Request_poshmark_com(out response, url2, 1, "", Form1.ck))
								{
									string text6 = Form1.wb.ReadResponse(response);
									dynamic val4 = val3.Deserialize<object>(text6);
									title = val4["data"]["title"];
									link = "https://poshmark.com/listing/-" + text5;
									if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
									{
										link = link.Replace("poshmark.com", "poshmark.ca");
									}
									price = val4["data"]["price"].ToString();
									((Control)dataGridView1_offer_likers).Invoke((Delegate)(MethodInvoker)delegate
									{
										dataGridView1_offer_likers.get_Rows().Add(new object[5] { title, link, price, "", false });
									});
								}
							}
							catch
							{
							}
						}
						text = "maxId=" + obj3["more"]["next_max_id"].ToString().Replace(":", "%3A");
					}
				}
				catch (Exception)
				{
				}
				((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Listings Found for Offers " + unique_ids.Count + "\r\n");
				});
			}
		}
		catch
		{
		}
		TextBox status_textBox2 = Form1.mainform.status_textBox1;
		object obj7 = _003C_003Ec._003C_003E9__2_5;
		if (obj7 == null)
		{
			MethodInvoker val5 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Listings Fetched, Completed\r\n");
			};
			obj7 = (object)val5;
			_003C_003Ec._003C_003E9__2_5 = val5;
		}
		((Control)status_textBox2).Invoke((Delegate)obj7);
		MetroButton start_button2 = Form1.mainform.Start_button1;
		object obj8 = _003C_003Ec._003C_003E9__2_6;
		if (obj8 == null)
		{
			MethodInvoker val6 = delegate
			{
				((Control)Form1.mainform.Start_button1).set_Enabled(true);
			};
			obj8 = (object)val6;
			_003C_003Ec._003C_003E9__2_6 = val6;
		}
		((Control)start_button2).Invoke((Delegate)obj8);
		((Control)offer_percentage_textBox2).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)offer_percentage_textBox2).set_Enabled(true);
		});
		((Control)offers_listings_fetch_button).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)offers_listings_fetch_button).set_Enabled(true);
		});
	}

	public void start_making_offer()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected O, but got Unknown
		string csrf_token = Form1.ed.return_csrf_token(Form1.ck);
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj = _003C_003Ec._003C_003E9__3_0;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Starting sending offer\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__3_0 = val;
		}
		((Control)status_textBox).Invoke((Delegate)obj);
		if (dataGridView1_offer_likers.get_Rows().get_Count() < 1)
		{
			TextBox status_textBox2 = Form1.mainform.status_textBox1;
			object obj2 = _003C_003Ec._003C_003E9__3_1;
			if (obj2 == null)
			{
				MethodInvoker val2 = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Extract listings for Offers first\r\n");
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__3_1 = val2;
			}
			((Control)status_textBox2).Invoke((Delegate)obj2);
			return;
		}
		string name;
		string discount;
		for (int i = 0; i < dataGridView1_offer_likers.get_Rows().get_Count(); i++)
		{
			try
			{
				string text = dataGridView1_offer_likers.get_Rows().get_Item(i).get_Cells()
					.get_Item(1)
					.get_Value()
					.ToString()!.TrimStart(new char[0]).TrimEnd(new char[0]);
				name = dataGridView1_offer_likers.get_Rows().get_Item(i).get_Cells()
					.get_Item(0)
					.get_Value()
					.ToString()!.TrimStart(new char[0]).TrimEnd(new char[0]);
				string s = dataGridView1_offer_likers.get_Rows().get_Item(i).get_Cells()
					.get_Item(2)
					.get_Value()
					.ToString()!.Replace("$", "").TrimStart(new char[0]).TrimEnd(new char[0]);
				string text2 = dataGridView1_offer_likers.get_Rows().get_Item(i).get_Cells()
					.get_Item(3)
					.get_Value()
					.ToString()!.Replace("$", "").TrimStart(new char[0]).TrimEnd(new char[0]);
				bool flag = (bool)dataGridView1_offer_likers.get_Rows().get_Item(i).get_Cells()
					.get_Item(4)
					.get_Value();
				string text3 = text.Substring(text.LastIndexOf("-") + 1, text.Length - (text.LastIndexOf("-") + 1));
				if (text2 == "")
				{
					TextBox status_textBox3 = Form1.mainform.status_textBox1;
					object obj3 = _003C_003Ec._003C_003E9__3_2;
					if (obj3 == null)
					{
						MethodInvoker val3 = delegate
						{
							((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Offer Percentage cant be empty\r\n");
						};
						obj3 = (object)val3;
						_003C_003Ec._003C_003E9__3_2 = val3;
					}
					((Control)status_textBox3).Invoke((Delegate)obj3);
					continue;
				}
				discount = "";
				double num = 0.0;
				try
				{
					num = double.Parse(text2);
					if (num < 10.0)
					{
						TextBox status_textBox4 = Form1.mainform.status_textBox1;
						object obj4 = _003C_003Ec._003C_003E9__3_3;
						if (obj4 == null)
						{
							MethodInvoker val4 = delegate
							{
								((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Discount Cant be less than 10%\r\n");
							};
							obj4 = (object)val4;
							_003C_003Ec._003C_003E9__3_3 = val4;
						}
						((Control)status_textBox4).Invoke((Delegate)obj4);
						continue;
					}
					if (num > 50.0)
					{
						TextBox status_textBox5 = Form1.mainform.status_textBox1;
						object obj5 = _003C_003Ec._003C_003E9__3_4;
						if (obj5 == null)
						{
							MethodInvoker val5 = delegate
							{
								((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Discount Cant be greater than 50%\r\n");
							};
							obj5 = (object)val5;
							_003C_003Ec._003C_003E9__3_4 = val5;
						}
						((Control)status_textBox5).Invoke((Delegate)obj5);
						continue;
					}
					double num2 = int.Parse(s);
					double d = num2 - num2 * num / 100.0;
					discount = int.Parse(Math.Floor(d).ToString()).ToString();
					goto IL_0373;
				}
				catch
				{
					TextBox status_textBox6 = Form1.mainform.status_textBox1;
					object obj6 = _003C_003Ec._003C_003E9__3_5;
					if (obj6 == null)
					{
						MethodInvoker val6 = delegate
						{
							((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Error in Discount value\r\n");
						};
						obj6 = (object)val6;
						_003C_003Ec._003C_003E9__3_5 = val6;
					}
					((Control)status_textBox6).Invoke((Delegate)obj6);
				}
				goto end_IL_00a3;
				IL_0373:
				string text4 = "";
				string text5 = "";
				if (!((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
				{
					text4 = "2.46";
					if (flag)
					{
						text4 = "7.45";
					}
					text5 = "USD";
				}
				else
				{
					text4 = "3";
					if (flag)
					{
						text4 = "12.99";
					}
					text5 = "CAD";
				}
				string body_cus = "{\"offer_amount\":{\"val\":" + discount + ",\"currency_code\":\"" + text5 + "\"},\"seller_shipping_discount\":{\"val\":" + text4 + ",\"currency_code\":\"" + text5 + "\"},\"offer_shipping_discount_type\":\"default_discount_v2\",\"offer_api_version\":3}";
				((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Sending offer to " + name + " of " + discount + "\r\n");
				});
				string link = "https://poshmark.com/vm-rest/posts/" + text3 + "/likes/users/offers?pm_version=134.0.0";
				if (Form1.wb.Request_poshmark_com_send_offer(out var response, link, Form1.ck, body_cus, csrf_token))
				{
					string text6 = Form1.wb.ReadResponse(response);
					JavaScriptSerializer val7 = new JavaScriptSerializer();
					dynamic obj8 = null;
					obj8 = val7.Deserialize<object>(text6);
					try
					{
						if (obj8.Count > 1)
						{
							_ = (string)obj8["error"]["userMessage"];
							((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("Unsuccessful-offer " + name + "\r\n");
							});
						}
						else
						{
							((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("Successful-offer " + name + "\r\n");
							});
						}
					}
					catch
					{
					}
				}
				goto IL_069c;
				end_IL_00a3:;
			}
			catch
			{
				goto IL_069c;
			}
			continue;
			IL_069c:
			int num3 = 5;
			try
			{
				num3 = Form1.ed.delay_value_getter(((Control)Form1.pro_bulk_editor.delay_bulk_price_edittor_textBox2).get_Text());
			}
			catch
			{
			}
			Thread.Sleep(num3 * 1000);
		}
		TextBox status_textBox7 = Form1.mainform.status_textBox1;
		object obj12 = _003C_003Ec._003C_003E9__3_9;
		if (obj12 == null)
		{
			MethodInvoker val8 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Sending offer Finished\r\n");
			};
			obj12 = (object)val8;
			_003C_003Ec._003C_003E9__3_9 = val8;
		}
		((Control)status_textBox7).Invoke((Delegate)obj12);
	}

	private void offers_listings_fetch_button_Click(object sender, EventArgs e)
	{
		dataGridView1_offer_likers.get_Rows().Clear();
		((Control)offer_percentage_textBox2).set_Enabled(false);
		try
		{
			Form1.t.Abort();
		}
		catch
		{
		}
		Form1.t = new Thread((ThreadStart)delegate
		{
			lets_extract_offer_listings();
		});
		Form1.t.Start();
	}

	private void offer_percentage_textBox2_TextChanged(object sender, EventArgs e)
	{
		string text = ((Control)offer_percentage_textBox2).get_Text();
		if (int.Parse(text) > 50)
		{
			((Control)offer_percentage_textBox2).set_Text("50");
		}
		else if (int.Parse(text) < 10)
		{
		}
		for (int i = 0; i < dataGridView1_offer_likers.get_Rows().get_Count(); i++)
		{
			dataGridView1_offer_likers.get_Rows().get_Item(i).get_Cells()
				.get_Item(3)
				.set_Value((object)((Control)offer_percentage_textBox2).get_Text());
		}
	}

	private void offer_percentage_textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

	private void HeaderCheckBox_Clicked(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		dataGridView1_offer_likers.EndEdit();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1_offer_likers.get_Rows())
		{
			DataGridViewRow val = item;
			DataGridViewCell obj = val.get_Cells().get_Item("shipping");
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
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1_offer_likers.get_Rows())
		{
			DataGridViewRow val = item;
			if (!Convert.ToBoolean(val.get_Cells().get_Item("shipping").get_EditedFormattedValue()))
			{
				@checked = false;
				break;
			}
		}
		headerCheckBox.set_Checked(@checked);
	}

	private void ColumnCheckbox(DataGridView dataGridView)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		Rectangle cellDisplayRectangle = dataGridView.GetCellDisplayRectangle(4, -1, true);
		cellDisplayRectangle.Y = 3;
		cellDisplayRectangle.X = cellDisplayRectangle.Location.X + 60 + cellDisplayRectangle.Width / 4;
		((Control)headerCheckBox).set_Location(cellDisplayRectangle.Location);
		((Control)headerCheckBox).set_BackColor(Color.White);
		((Control)headerCheckBox).set_Size(new Size(18, 18));
		((Control)headerCheckBox).add_Click((EventHandler)HeaderCheckBox_Clicked);
		((Control)dataGridView).get_Controls().Add((Control)(object)headerCheckBox);
		dataGridView.add_CellContentClick(new DataGridViewCellEventHandler(DataGridView_CellClick));
	}

	private void delay_offer_textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		update_price_metroButton1 = new MetroButton();
		dataGridView1_offer_likers = new DataGridView();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		discount = new DataGridViewTextBoxColumn();
		shipping = new DataGridViewCheckBoxColumn();
		offers_listings_fetch_button = new MetroButton();
		metroLabel1 = new MetroLabel();
		offer_percentage_textBox2 = new MetroTextBox();
		delay_offer_textBox2 = new MetroTextBox();
		label42 = new MetroLabel();
		metroLabel2 = new MetroLabel();
		metroLabel3 = new MetroLabel();
		((ISupportInitialize)dataGridView1_offer_likers).BeginInit();
		((Control)this).SuspendLayout();
		((Control)update_price_metroButton1).set_Location(new Point(79, 157));
		((Control)update_price_metroButton1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)update_price_metroButton1).set_Name("update_price_metroButton1");
		((Control)update_price_metroButton1).set_Size(new Size(208, 35));
		((Control)update_price_metroButton1).set_TabIndex(93);
		((Control)update_price_metroButton1).set_Text("Click to Change Price");
		dataGridView1_offer_likers.set_AllowUserToAddRows(false);
		dataGridView1_offer_likers.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView1_offer_likers.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1_offer_likers.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn1,
			(DataGridViewColumn)dataGridViewTextBoxColumn4,
			(DataGridViewColumn)dataGridViewTextBoxColumn3,
			(DataGridViewColumn)discount,
			(DataGridViewColumn)shipping
		});
		((Control)dataGridView1_offer_likers).set_Location(new Point(15, 131));
		((Control)dataGridView1_offer_likers).set_Margin(new Padding(4, 5, 4, 5));
		((Control)dataGridView1_offer_likers).set_Name("dataGridView1_offer_likers");
		((Control)dataGridView1_offer_likers).set_Size(new Size(1136, 423));
		((Control)dataGridView1_offer_likers).set_TabIndex(95);
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_HeaderText("Title");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_Name("dataGridViewTextBoxColumn1");
		((DataGridViewBand)dataGridViewTextBoxColumn1).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn4).set_HeaderText("Link");
		((DataGridViewColumn)dataGridViewTextBoxColumn4).set_Name("dataGridViewTextBoxColumn4");
		((DataGridViewBand)dataGridViewTextBoxColumn4).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn3).set_HeaderText("Price");
		((DataGridViewColumn)dataGridViewTextBoxColumn3).set_Name("dataGridViewTextBoxColumn3");
		((DataGridViewBand)dataGridViewTextBoxColumn3).set_ReadOnly(true);
		((DataGridViewColumn)discount).set_HeaderText("Discount (Percent)");
		((DataGridViewColumn)discount).set_Name("discount");
		((DataGridViewColumn)shipping).set_HeaderText("Free Shipping");
		((DataGridViewColumn)shipping).set_Name("shipping");
		((Control)offers_listings_fetch_button).set_Enabled(false);
		((Control)offers_listings_fetch_button).set_Location(new Point(15, 11));
		((Control)offers_listings_fetch_button).set_Margin(new Padding(4, 5, 4, 5));
		((Control)offers_listings_fetch_button).set_Name("offers_listings_fetch_button");
		((Control)offers_listings_fetch_button).set_Size(new Size(215, 57));
		((Control)offers_listings_fetch_button).set_TabIndex(96);
		((Control)offers_listings_fetch_button).set_Text("Fetch Listings For Offers (Step 1)");
		((Control)offers_listings_fetch_button).add_Click((EventHandler)offers_listings_fetch_button_Click);
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_Location(new Point(702, 59));
		((Control)metroLabel1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(199, 19));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(94);
		((Control)metroLabel1).set_Text("Offer Percentage(10%-50% only)");
		metroLabel1.UseStyleColors = true;
		((Control)offer_percentage_textBox2).set_Enabled(false);
		((Control)offer_percentage_textBox2).set_ForeColor(Color.Black);
		((Control)offer_percentage_textBox2).set_Location(new Point(1051, 59));
		((Control)offer_percentage_textBox2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)offer_percentage_textBox2).set_Name("offer_percentage_textBox2");
		((Control)offer_percentage_textBox2).set_RightToLeft((RightToLeft)1);
		((Control)offer_percentage_textBox2).set_Size(new Size(100, 35));
		offer_percentage_textBox2.Style = MetroColorStyle.Brown;
		((Control)offer_percentage_textBox2).set_TabIndex(92);
		((Control)offer_percentage_textBox2).set_Text("10");
		offer_percentage_textBox2.UseStyleColors = true;
		((Control)offer_percentage_textBox2).add_TextChanged((EventHandler)offer_percentage_textBox2_TextChanged);
		((Control)offer_percentage_textBox2).add_KeyPress(new KeyPressEventHandler(offer_percentage_textBox2_KeyPress));
		((Control)delay_offer_textBox2).set_ForeColor(Color.Black);
		((Control)delay_offer_textBox2).set_Location(new Point(1051, 11));
		((Control)delay_offer_textBox2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)delay_offer_textBox2).set_Name("delay_offer_textBox2");
		((Control)delay_offer_textBox2).set_RightToLeft((RightToLeft)1);
		((Control)delay_offer_textBox2).set_Size(new Size(100, 35));
		delay_offer_textBox2.Style = MetroColorStyle.Brown;
		((Control)delay_offer_textBox2).set_TabIndex(98);
		((Control)delay_offer_textBox2).set_Text("60,120");
		delay_offer_textBox2.UseStyleColors = true;
		((Control)delay_offer_textBox2).add_KeyPress(new KeyPressEventHandler(delay_offer_textBox2_KeyPress));
		((Control)label42).set_AutoSize(true);
		((Control)label42).set_Location(new Point(711, 11));
		((Control)label42).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(230, 19));
		label42.Style = MetroColorStyle.Brown;
		((Control)label42).set_TabIndex(97);
		((Control)label42).set_Text("Make offer after every X to X seconds");
		label42.UseStyleColors = true;
		((Control)metroLabel2).set_AutoSize(true);
		((Control)metroLabel2).set_Location(new Point(251, 11));
		((Control)metroLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel2).set_Name("metroLabel2");
		((Control)metroLabel2).set_Size(new Size(162, 76));
		metroLabel2.Style = MetroColorStyle.Brown;
		((Control)metroLabel2).set_TabIndex(99);
		((Control)metroLabel2).set_Text("1) Fetch Listings\r\n2) Select Row to Delete\r\n3) Setup Offer percentage\r\n4) Click Start");
		metroLabel2.UseStyleColors = true;
		((Control)metroLabel3).set_AutoSize(true);
		metroLabel3.FontWeight = MetroLabelWeight.Bold;
		((Control)metroLabel3).set_Location(new Point(702, 102));
		((Control)metroLabel3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel3).set_Name("metroLabel3");
		((Control)metroLabel3).set_Size(new Size(311, 19));
		metroLabel3.Style = MetroColorStyle.Blue;
		((Control)metroLabel3).set_TabIndex(100);
		((Control)metroLabel3).set_Text("Beta Feature: Report us if any problem found");
		metroLabel3.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)metroLabel3);
		((Control)this).get_Controls().Add((Control)(object)metroLabel2);
		((Control)this).get_Controls().Add((Control)(object)delay_offer_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label42);
		((Control)this).get_Controls().Add((Control)(object)offers_listings_fetch_button);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1_offer_likers);
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)update_price_metroButton1);
		((Control)this).get_Controls().Add((Control)(object)offer_percentage_textBox2);
		((Control)this).set_Name("offer_to_liker");
		((Control)this).set_Size(new Size(1167, 528));
		((ISupportInitialize)dataGridView1_offer_likers).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
