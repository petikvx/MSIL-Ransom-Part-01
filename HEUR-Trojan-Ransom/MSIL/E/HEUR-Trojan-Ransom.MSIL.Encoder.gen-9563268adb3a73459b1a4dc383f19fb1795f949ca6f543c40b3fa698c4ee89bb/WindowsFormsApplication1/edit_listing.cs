using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using HtmlAgilityPack;
using MetroFramework.Controls;

namespace WindowsFormsApplication1;

internal class edit_listing
{
	private webrequests wb = new webrequests();

	private Form1 Form1;

	public string edit_string
	{
		get
		{
			string result = "";
			if (Request_poshmark_com_get_data_step2(out var response, id))
			{
				string html = wb.ReadResponse(response);
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(html);
				HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//script");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						if (item.InnerHtml.Contains("window.__INITIAL_STATE__") && !upload_or_edit)
						{
							return item.InnerHtml;
						}
					}
				}
			}
			return result;
		}
	}

	public void edit_listing_main(string listing_url, Form1 pm_form, int delay)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		login_poshmark login_poshmark2 = new login_poshmark();
		Form1 = pm_form;
		if (listing_url == "initialized")
		{
			return;
		}
		((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)Form1.status_textBox1).AppendText("Going For ENL\r\n");
		});
		if (Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Count() <= 0)
		{
			((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((TextBoxBase)Form1.status_textBox1).AppendText("Fetch your listings first\r\n");
			});
			return;
		}
		if (((CheckBox)Form1.pro_enl_class.deleteCheckBox1).get_Checked() && (int)MessageBox.Show("Are you sure to delete listing?", "Delete Listings: ", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
		{
			MetroCheckBox deleteCheckBox = Form1.pro_enl_class.deleteCheckBox1;
			object obj = _003C_003Ec._003C_003E9__2_2;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((CheckBox)Form1.pro_enl_class.deleteCheckBox1).set_Checked(false);
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__2_2 = val;
			}
			((Control)deleteCheckBox).Invoke((Delegate)obj);
			((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((TextBoxBase)Form1.status_textBox1).AppendText("Deleting Cancelled by User\r\n");
			});
			return;
		}
		string text = login_poshmark2.check_who_is_logined(Form1.ck);
		extract_data extract_data2 = new extract_data(login_poshmark2);
		extract_data2.return_csrf_token(Form1.ck);
		text?.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
		string name;
		int cou;
		for (int rows = 0; rows < Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Count(); rows++)
		{
			try
			{
				if (!(bool)Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Item(rows).get_Cells()
					.get_Item(0)
					.get_Value())
				{
					continue;
				}
				string text2 = Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Item(rows).get_Cells()
					.get_Item(3)
					.get_Value()
					.ToString();
				name = Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Item(rows).get_Cells()
					.get_Item(1)
					.get_Value()
					.ToString();
				((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)Form1.status_textBox1).AppendText("Going For ENL/Delete " + name + " " + rows + 1 + "/" + Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Count() + "\r\n");
				});
				string text3 = "";
				text3 = ((!text2.Contains("post_id=")) ? text2 : text2.Substring(text2.IndexOf("post_id=") + 8, text2.Length - (text2.IndexOf("post_id=") + 8)));
				string text4 = this.get_edit_string(text3, upload_or_edit: false);
				text4 = text4.Substring(text4.IndexOf("{"), text4.Length - text4.IndexOf("{"));
				text4 = text4.Substring(0, text4.LastIndexOf(";(function(){va"));
				if (((CheckBox)Form1.pro_enl_class.deleteCheckBox1).get_Checked())
				{
					if (Request_poshmark_com_delete(out var response, text3))
					{
						string text5 = wb.ReadResponse(response);
						if (text5 == "{}")
						{
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.status_textBox1).AppendText("Successfully Deleted" + name + "\r\n");
							});
						}
						else
						{
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.status_textBox1).AppendText("UnSuccessfully Deleted" + name + "\r\n");
							});
						}
					}
				}
				else
				{
					string json_data = text4;
					if (update_listing(json_data, text3, ""))
					{
						((Control)Form1.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							((TextBoxBase)Form1.Log_textBox1).AppendText("Successfully ENL: " + name + "\r\n");
						});
						if (Form1.Enl_permission.Contains("Not permitted"))
						{
							string s = File.ReadAllText(Form1.hidden_path);
							if (int.Parse(s) > 49)
							{
								((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
								{
									((TextBoxBase)Form1.status_textBox1).AppendText("Your Free ENL Limit Reached, Buy license for further use\r\n");
								});
								break;
							}
							cou = int.Parse(s) + 1;
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.status_textBox1).AppendText("Your " + (50 - cou) + " Free ENL Left\r\n");
							});
							File.WriteAllText(Form1.hidden_path, cou.ToString());
						}
					}
					else
					{
						((Control)Form1.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							((TextBoxBase)Form1.Log_textBox1).AppendText("UnSuccessfully ENL: " + name + "\r\n");
						});
					}
				}
				try
				{
					delay = Form1.ed.delay_value_getter(((Control)Form1.pro_enl_class.delay_enl_textBox2).get_Text());
				}
				catch
				{
				}
				Thread.Sleep(delay * 1000);
			}
			catch (Exception ex)
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				File.AppendAllText("logs//logs.jk", "7) " + ex.ToString() + "\r\n");
			}
		}
		((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)Form1.status_textBox1).AppendText("ENL/Deletion Finished\r\n");
		});
	}

	public bool update_listing(string json_data, string id, string price)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		string text = json_data;
		JavaScriptSerializer val = new JavaScriptSerializer();
		dynamic obj = null;
		obj = val.Deserialize<object>(text);
		string text2 = "";
		try
		{
			foreach (dynamic item in obj["$_listing_editor"]["post"]["colors"])
			{
				text2 = text2 + item + ",";
			}
			text2 = text2.Substring(0, text2.LastIndexOf(","));
			text2 = "\"" + text2.Replace(",", "\",\"") + "\"";
		}
		catch
		{
		}
		string text3 = "";
		try
		{
			foreach (dynamic item2 in obj["$_listing_editor"]["post"]["inventory"]["size_quantities"])
			{
				string text4 = "";
				if (item2["size_set_tags"].Length > 0)
				{
					text4 = item2["size_set_tags"][0].ToString();
				}
				text3 = text3 + "{\"size_id\":\"" + item2["size_id"] + "\",\"quantity_available\":" + item2["quantity_available"] + ", \"quantity_reserved\":" + item2["quantity_reserved"] + ",\"quantity_sold\":" + item2["quantity_sold"] + ",\"size_ref\":" + item2["size_ref"].ToString() + ",\"size_obj\":{\"id\":\"" + item2["size_obj"]["id"] + "\",\"display\":\"" + item2["size_obj"]["display"] + "\",\"display_with_size_set\":\"" + item2["size_obj"]["display_with_size_set"] + "\"},\"size_set_tags\":[\"" + text4 + "\"]}" + ",";
			}
			text3 = text3.Substring(0, text3.LastIndexOf(","));
		}
		catch
		{
		}
		string text5 = "";
		try
		{
			foreach (dynamic item3 in obj["$_listing_editor"]["post"]["pictures"])
			{
				text5 = text5 + "{\"id\":\"" + item3["id"] + "\"}" + ",";
			}
			text5 = text5.Substring(0, text5.LastIndexOf(","));
		}
		catch
		{
		}
		string text6 = obj["$_listing_editor"]["post"]["title"].ToString().Replace("\n", "\\n");
		string text7 = "";
		for (int i = 0; i < text6.Length; i++)
		{
			string text8 = text6[i].ToString();
			if (text8 == "\"")
			{
				text8 = "\\" + text6[i];
			}
			text7 += text8;
		}
		text6 = text7;
		string text9 = obj["$_listing_editor"]["post"]["description"].ToString().Replace("\n", "\\n").Replace("\t", "\\t");
		string text10 = "";
		for (int j = 0; j < text9.Length; j++)
		{
			string text11 = text9[j].ToString();
			if (text11 == "\"")
			{
				text11 = "\\" + text9[j];
			}
			text10 += text11;
		}
		text9 = text10;
		text9 = ((text9[text9.Length - 1] != '.') ? (text9 + ".") : text9.Substring(0, text9.Length - 1));
		string text12 = "";
		string text13 = "";
		string text14 = "";
		string text15 = "";
		try
		{
			text12 = "\"" + obj["$_listing_editor"]["post"]["catalog"]["category_features"][0].ToString() + "\"";
			text13 = obj["$_listing_editor"]["post"]["catalog"]["category_feature_objs"][0]["display"].ToString();
			text14 = "\"" + obj["$_listing_editor"]["post"]["catalog"]["category_feature_objs"][0]["id"].ToString() + "\"";
			_ = "{\"id\":\"" + text14 + "\",\"display\":\"" + text13 + "\"}";
			text15 = "{\"id\":\"" + obj["$_listing_editor"]["post"]["catalog"]["category_feature_objs"][0]["id"].ToString() + "\",\"display\":\"" + text13 + "\"}";
		}
		catch
		{
		}
		string text16 = obj["$_listing_editor"]["post"]["status_changed_at"].ToString();
		string text17 = text16;
		string text18 = "";
		string text19 = "";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text18 = "CAD";
			text19 = "C$";
		}
		else
		{
			text18 = "USD";
			text19 = "$";
		}
		text = "{\"post\":{\"catalog\":{\"category_features\":[" + text12 + "],\"department\":\"" + obj["$_listing_editor"]["post"]["catalog"]["department"] + "\",\"category\":\"" + obj["$_listing_editor"]["post"]["catalog"]["category"];
		text = text + "\",\"department_obj\":{\"id\":\"" + obj["$_listing_editor"]["post"]["catalog"]["department_obj"]["id"] + "\",\"display\":\"" + obj["$_listing_editor"]["post"]["catalog"]["department_obj"]["display"] + "\"},\"category_obj\":{\"id\":\"" + obj["$_listing_editor"]["post"]["catalog"]["category_obj"]["id"] + "\",\"display\":\"" + obj["$_listing_editor"]["post"]["catalog"]["category_obj"]["display"] + "\"},\"category_feature_objs\":[" + text15 + "]},\"colors\":[" + text2;
		text = text + "],\"inventory\":{\"status\":\"" + obj["$_listing_editor"]["post"]["inventory"]["status"] + "\",\"status_changed_at\":\"" + text17 + "\",\"size_quantities\":[" + text3 + "],\"size_quantity_revision\":" + obj["$_listing_editor"]["post"]["inventory"]["size_quantity_revision"] + ",\"multi_item\":" + obj["$_listing_editor"]["post"]["inventory"]["multi_item"].ToString().ToLower();
		string text20 = obj["$_listing_editor"]["post"]["price_amount"]["val"];
		if (price != "")
		{
			text20 = price;
		}
		text = text + "},\"price_amount\":{ \"val\":\"" + text20 + "\",\"currency_code\":\"" + text18 + "\",\"currency_symbol\":\"" + text19 + "\"},\"original_price_amount\":{ \"val\":\"" + obj["$_listing_editor"]["post"]["original_price_amount"]["val"] + "\",\"currency_code\":\"" + text18 + "\",\"currency_symbol\":\"" + text19 + "\"}" + ",\"title\":\"" + text6 + "\",\"description\":\"" + text9;
		string text21 = "";
		try
		{
			text21 = obj["$_listing_editor"]["post"]["condition"];
		}
		catch
		{
		}
		text = text + "\",\"brand\":\"" + obj["$_listing_editor"]["post"]["brand"] + "\",\"condition\":\"" + text21 + "\",\"cover_shot\":{\"id\":\"" + obj["$_listing_editor"]["post"]["cover_shot"]["id"] + "\"},\"pictures\":[" + text5 + "]}}";
		HttpWebResponse response = default(HttpWebResponse);
		if (Request_poshmark_com_update_step3(out response, obj["csrftoken"], text, id))
		{
			string text22 = wb.ReadResponse(response);
			if (text22 == "{}" || text22.Contains("\"req_id\":\""))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool Request_poshmark_com_listing_page_step1(out HttpWebResponse response)
	{
		response = null;
		try
		{
			string text = "https://poshmark.com/listing/Twopiece-Toddler-Summer-Outfit-24m-NWT-5b37bc1da5d7c6c0b9fd62e7";
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/closet/cabojulia";
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private bool Request_poshmark_com_get_data_step2(out HttpWebResponse response, string id)
	{
		response = null;
		string text = "https://poshmark.com/edit-listing/" + id;
		string text2 = "https://poshmark.com";
		string text3 = "https://poshmark.com/closet/cabojulia";
		if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
		{
			text = text.Replace(".com", ".ca");
			text2 = text2.Replace(".com", ".ca");
			text3 = text3.Replace(".com", ".ca");
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.89 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
			httpWebRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
			httpWebRequest.Headers.Add("Sec-Fetch-Mode", "navigate");
			httpWebRequest.Headers.Add("Sec-Fetch-User", "?1");
			httpWebRequest.Headers.Add("Sec-Fetch-Dest", "document");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private bool Request_poshmark_com_update_step3(out HttpWebResponse response, string token, string misc, string id)
	{
		response = null;
		try
		{
			string text = "https://poshmark.com/vm-rest/posts/" + id;
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/edit-listing/" + id;
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "application/json";
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.Headers.Add("X-XSRF-TOKEN", token);
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			byte[] bytes = Encoding.UTF8.GetBytes(misc);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private bool Request_poshmark_com_step4(out HttpWebResponse response)
	{
		response = null;
		try
		{
			string text = "https://poshmark.com/listing/Premium%20Tricolor%20Pebbled%20Leather%20Micro%20Mini%20NWT-5a67e23472769be56deafac9";
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/edit-listing/5a67e23472769be56deafac9";
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private bool Request_poshmark_com_delete(out HttpWebResponse response, string id)
	{
		response = null;
		try
		{
			string text = "https://poshmark.com/api//posts/" + id + "?app_version=1&app_type=web";
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/edit-listing/" + id;
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Headers.Add("Origin", text2);
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			httpWebRequest.Method = "DELETE";
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private bool Request_poshmark_com_step5(out HttpWebResponse response)
	{
		response = null;
		try
		{
			string text = "https://poshmark.com/listing/Premium-Tricolor-Pebbled-Leather-Micro-Mini-NWT-5a67e23472769be56deafac9";
			string text2 = "https://poshmark.com";
			string text3 = "https://poshmark.com/edit-listing/5a67e23472769be56deafac9";
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				text = text.Replace(".com", ".ca");
				text2 = text2.Replace(".com", ".ca");
				text3 = text3.Replace(".com", ".ca");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = text3;
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			httpWebRequest.Headers.Set(HttpRequestHeader.IfNoneMatch, "\"89bfaf771afe51e71847bfd86bfffff5\"");
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	public void edit_listing_main_price_Edit(string listing_url, Form1 pm_form, int delay)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0476: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		login_poshmark login_poshmark2 = new login_poshmark();
		Form1 = pm_form;
		if (listing_url == "initialized")
		{
			return;
		}
		((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)Form1.status_textBox1).AppendText("Going For Bulk Price Editting\r\n");
		});
		if (Form1.pro_bulk_editor.dataGridView1_bulk_price_editor.get_Rows().get_Count() <= 0)
		{
			((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((TextBoxBase)Form1.status_textBox1).AppendText("Fetch your listings first\r\n");
			});
			return;
		}
		string text = login_poshmark2.check_who_is_logined(Form1.ck);
		extract_data extract_data2 = new extract_data(login_poshmark2);
		extract_data2.return_csrf_token(Form1.ck);
		text?.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
		string name;
		string price;
		int cou;
		MethodInvoker val = default(MethodInvoker);
		for (int i = 0; i < Form1.pro_bulk_editor.dataGridView1_bulk_price_editor.get_Rows().get_Count(); i++)
		{
			try
			{
				if (!(bool)Form1.pro_bulk_editor.dataGridView1_bulk_price_editor.get_Rows().get_Item(i).get_Cells()
					.get_Item(0)
					.get_Value())
				{
					continue;
				}
				string text2 = Form1.pro_bulk_editor.dataGridView1_bulk_price_editor.get_Rows().get_Item(i).get_Cells()
					.get_Item(2)
					.get_Value()
					.ToString();
				name = Form1.pro_bulk_editor.dataGridView1_bulk_price_editor.get_Rows().get_Item(i).get_Cells()
					.get_Item(1)
					.get_Value()
					.ToString();
				price = Form1.pro_bulk_editor.dataGridView1_bulk_price_editor.get_Rows().get_Item(i).get_Cells()
					.get_Item(3)
					.get_Value()
					.ToString();
				((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)Form1.status_textBox1).AppendText("Going For Price change " + name + " --> " + price + "\r\n");
				});
				string text3 = "";
				text3 = ((!text2.Contains("post_id=")) ? text2 : text2.Substring(text2.IndexOf("post_id=") + 8, text2.Length - (text2.IndexOf("post_id=") + 8)));
				string text4 = this.get_edit_string(text3, upload_or_edit: false);
				text4 = text4.Substring(text4.IndexOf("{"), text4.Length - text4.IndexOf("{"));
				text4 = text4.Substring(0, text4.LastIndexOf(";(function(){va"));
				string json_data = text4;
				if (update_listing(json_data, text3, price))
				{
					((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
					{
						((TextBoxBase)Form1.status_textBox1).AppendText("Successfully Price Edited " + name + "\r\n");
					});
					if (Form1.bulk_edit_permission.Contains("Not permitted"))
					{
						string input = File.ReadAllText(Form1.bulk_permission_hidden_path);
						string[] array = Regex.Split(input, "--");
						DateTime dateTime = DateTime.ParseExact(array[0], "dd-MM-yyyy", CultureInfo.InvariantCulture);
						DateTime today_date_microsolft = Form1.today_date_microsolft;
						string text5 = "0";
						if (today_date_microsolft.Date > dateTime.Date)
						{
							File.WriteAllText(Form1.bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + text5.ToString());
						}
						else
						{
							if (!(today_date_microsolft.Date == dateTime.Date))
							{
								break;
							}
							text5 = array[1];
						}
						if (int.Parse(text5) > 10)
						{
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)Form1.status_textBox1).AppendText("Your Free Bulk Edit daily Limit Reached, Buy license for further use or wait for 1 day\r\n");
							});
							break;
						}
						cou = int.Parse(text5) + 1;
						((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							((TextBoxBase)Form1.status_textBox1).AppendText("Your " + (10 - cou) + " Free Price Change Left\r\n");
						});
						File.WriteAllText(Form1.bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + cou);
					}
				}
				else
				{
					((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
					{
						((TextBoxBase)Form1.status_textBox1).AppendText("UnSuccessfully Price Change" + name + "\r\n");
					});
				}
				TextBox status_textBox = Form1.status_textBox1;
				MethodInvoker obj = val;
				if (obj == null)
				{
					MethodInvoker val2 = delegate
					{
						((TextBoxBase)Form1.status_textBox1).AppendText("APP in Sleep for " + delay + "Seconds " + DateTime.Now.ToString() + "\r\n");
					};
					MethodInvoker val3 = val2;
					val = val2;
					obj = val3;
				}
				((Control)status_textBox).Invoke((Delegate)(object)obj);
				try
				{
					delay = Form1.ed.delay_value_getter(((Control)Form1.pro_bulk_editor.delay_bulk_price_edittor_textBox2).get_Text());
				}
				catch
				{
				}
				Thread.Sleep(delay * 1000);
			}
			catch (Exception ex)
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				File.AppendAllText("logs//logs.jk", "blk7) " + ex.ToString() + "\r\n");
			}
		}
		((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)Form1.status_textBox1).AppendText("Price Editing Finished Finished\r\n");
		});
	}
}
