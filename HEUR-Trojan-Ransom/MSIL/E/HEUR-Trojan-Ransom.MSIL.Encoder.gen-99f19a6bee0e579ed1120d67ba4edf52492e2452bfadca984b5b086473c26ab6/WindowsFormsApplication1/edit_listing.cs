using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;
using MetroFramework.Controls;
using Newtonsoft.Json;

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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca4: Expected O, but got Unknown
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf4: Expected O, but got Unknown
		//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d37: Expected O, but got Unknown
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected O, but got Unknown
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected O, but got Unknown
		//IL_0dbe: Expected O, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected O, but got Unknown
		login_poshmark login_poshmark2 = new login_poshmark();
		Form1 = pm_form;
		if (listing_url == "initialized")
		{
			return;
		}
		((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			Form1.status_textBox1.AppendText("Going For ENL\r\n");
		});
		if (Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Count() <= 0)
		{
			((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				Form1.status_textBox1.AppendText("Fetch your listings first\r\n");
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
				Form1.status_textBox1.AppendText("Deleting Cancelled by User\r\n");
			});
			return;
		}
		string text = login_poshmark2.check_who_is_logined(Form1.ck);
		extract_data extract_data2 = new extract_data(login_poshmark2);
		extract_data2.return_csrf_token(Form1.ck);
		text?.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
		string name;
		int cou;
		MethodInvoker val2 = default(MethodInvoker);
		for (int i = 0; i < Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Count(); i++)
		{
			try
			{
				if (!(bool)Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Item(i).get_Cells()
					.get_Item(0)
					.get_Value())
				{
					continue;
				}
				string text2 = Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Item(i).get_Cells()
					.get_Item(3)
					.get_Value()
					.ToString();
				name = Form1.pro_enl_class.dataGridView1_enl.get_Rows().get_Item(i).get_Cells()
					.get_Item(1)
					.get_Value()
					.ToString();
				((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					Form1.status_textBox1.AppendText("Going For ENL/Delete " + name + "\r\n");
				});
				string id = text2.Substring(text2.IndexOf("post_id=") + 8, text2.Length - (text2.IndexOf("post_id=") + 8));
				string text3 = this.get_edit_string(id, upload_or_edit: false);
				text3 = text3.Substring(text3.IndexOf("{"), text3.Length - text3.IndexOf("{"));
				text3 = text3.Substring(0, text3.LastIndexOf(";(function(){va"));
				text3 = text3.Replace("seller_broadcast_offer_price\":null", "seller_broadcast_offer_price\":0");
				text3 = text3.Replace("$_listing_editor", "__listing_editor");
				HttpWebResponse response;
				if (((CheckBox)Form1.pro_enl_class.deleteCheckBox1).get_Checked())
				{
					if (Request_poshmark_com_delete(out response, id))
					{
						string text4 = wb.ReadResponse(response);
						if (text4 == "{}")
						{
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								Form1.status_textBox1.AppendText("Successfully Deleted" + name + "\r\n");
							});
						}
						else
						{
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								Form1.status_textBox1.AppendText("UnSuccessfully Deleted" + name + "\r\n");
							});
						}
					}
				}
				else
				{
					RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(text3.ToString());
					string text5 = "";
					if (rootObject.__listing_editor.post.colors.Count > 0)
					{
						foreach (string color in rootObject.__listing_editor.post.colors)
						{
							text5 = text5 + color + ",";
						}
						text5 = text5.Substring(0, text5.LastIndexOf(","));
						text5 = "\"" + text5.Replace(",", "\",\"") + "\"";
					}
					string text6 = "";
					if (rootObject.__listing_editor.post.inventory.size_quantities.Count > 0)
					{
						foreach (SizeQuantity size_quantity in rootObject.__listing_editor.post.inventory.size_quantities)
						{
							string text7 = "";
							if (size_quantity.size_set_tags.Count > 0)
							{
								text7 = size_quantity.size_set_tags[0].ToString();
							}
							text6 = text6 + "{\"size_id\":\"" + size_quantity.size_id + "\",\"quantity_available\":" + size_quantity.quantity_available + ",\"quantity_reserved\":" + size_quantity.quantity_reserved + ",\"quantity_sold\":" + size_quantity.quantity_sold + ",\"size_ref\":" + size_quantity.size_ref.ToString() + ",\"size_obj\":{\"id\":\"" + size_quantity.size_obj.id + "\",\"display\":\"" + size_quantity.size_obj.display + "\",\"display_with_size_set\":\"" + size_quantity.size_obj.display_with_size_set + "\"},\"size_set_tags\":[\"" + text7 + "\"]},";
						}
						text6 = text6.Substring(0, text6.LastIndexOf(","));
					}
					string text8 = "";
					if (rootObject.__listing_editor.post.pictures.Count > 0)
					{
						foreach (Picture picture in rootObject.__listing_editor.post.pictures)
						{
							text8 = text8 + "{\"id\":\"" + picture.id + "\"},";
						}
						text8 = text8.Substring(0, text8.LastIndexOf(","));
					}
					string text9 = rootObject.__listing_editor.post.title.Replace("\n", "\\n");
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
					string text12 = rootObject.__listing_editor.post.description.Replace("\n", "\\n").Replace("\t", "\\t");
					string text13 = "";
					for (int k = 0; k < text12.Length; k++)
					{
						string text14 = text12[k].ToString();
						if (text14 == "\"")
						{
							text14 = "\\" + text12[k];
						}
						text13 += text14;
					}
					text12 = text13;
					text12 = ((text12[text12.Length - 1] != '.') ? (text12 + ".") : text12.Substring(0, text12.Length - 1));
					string text15 = "";
					string text16 = "";
					string text17 = "";
					string text18 = "";
					if (rootObject.__listing_editor.post.catalog.category_features.Count > 0)
					{
						text15 = "\"" + rootObject.__listing_editor.post.catalog.category_features[0] + "\"";
						text16 = rootObject.__listing_editor.post.catalog.category_feature_objs[0].display;
						text17 = "\"" + rootObject.__listing_editor.post.catalog.category_feature_objs[0].id + "\"";
						_ = "{\"id\":\"" + text17 + "\",\"display\":\"" + text16 + "\"}";
						text18 = "{\"id\":\"" + rootObject.__listing_editor.post.catalog.category_feature_objs[0].id + "\",\"display\":\"" + text16 + "\"}";
					}
					string text19 = rootObject.__listing_editor.post.status_changed_at.ToString("yyyy-MM-dd") + "T16:37:03-08:00";
					string text20 = "";
					string text21 = "";
					if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
					{
						text20 = "CAD";
						text21 = "C$";
					}
					else
					{
						text20 = "USD";
						text21 = "$";
					}
					text3 = "{\"post\":{\"catalog\":{\"category_features\":[" + text15 + "],\"department\":\"" + rootObject.__listing_editor.post.catalog.department + "\",\"category\":\"" + rootObject.__listing_editor.post.catalog.category + "\",\"department_obj\":{\"id\":\"" + rootObject.__listing_editor.post.catalog.department_obj.id + "\",\"display\":\"" + rootObject.__listing_editor.post.catalog.department_obj.display + "\"},\"category_obj\":{\"id\":\"" + rootObject.__listing_editor.post.catalog.category_obj.id + "\",\"display\":\"" + rootObject.__listing_editor.post.catalog.category_obj.display + "\"},\"category_feature_objs\":[" + text18 + "]},\"colors\":[" + text5 + "],\"inventory\":{\"status\":\"" + rootObject.__listing_editor.post.inventory.status + "\",\"status_changed_at\":\"" + text19 + "\",\"size_quantities\":[" + text6 + "],\"size_quantity_revision\":" + rootObject.__listing_editor.post.inventory.size_quantity_revision + ",\"multi_item\":" + rootObject.__listing_editor.post.inventory.multi_item.ToString().ToLower() + "},\"price_amount\":{ \"val\":\"" + rootObject.__listing_editor.post.price_amount.val + "\",\"currency_code\":\"" + text20 + "\",\"currency_symbol\":\"" + text21 + "\"},\"original_price_amount\":{ \"val\":\"" + rootObject.__listing_editor.post.original_price_amount.val + "\",\"currency_code\":\"" + text20 + "\",\"currency_symbol\":\"" + text21 + "\"},\"title\":\"" + text9 + "\",\"description\":\"" + text12 + "\",\"brand\":\"" + rootObject.__listing_editor.post.brand + "\",\"condition\":\"" + rootObject.__listing_editor.post.condition + "\",\"cover_shot\":{\"id\":\"" + rootObject.__listing_editor.post.cover_shot.id + "\"},\"pictures\":[" + text8 + "]}}";
					if (!rootObject.__listing_editor.post.title.Contains("\""))
					{
					}
					if (Request_poshmark_com_update_step3(out response, rootObject.csrftoken, text3, id))
					{
						string text22 = wb.ReadResponse(response);
						if (text22 == "{}" || text22.Contains("\"req_id\":\""))
						{
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								Form1.status_textBox1.AppendText("Successfully ENL" + name + "\r\n");
							});
							if (Form1.Enl_permission.Contains("Not permitted"))
							{
								string s = File.ReadAllText(Form1.hidden_path);
								if (int.Parse(s) > 49)
								{
									((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
									{
										Form1.status_textBox1.AppendText("Your Free ENL Limit Reached, Buy license for further use\r\n");
									});
									break;
								}
								cou = int.Parse(s) + 1;
								((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
								{
									Form1.status_textBox1.AppendText("Your " + (50 - cou) + " Free ENL Left\r\n");
								});
								File.WriteAllText(Form1.hidden_path, cou.ToString());
							}
						}
						else
						{
							if (!text22.Contains("\"user_message\":\"Description too long\","))
							{
							}
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								Form1.status_textBox1.AppendText("UnSuccessfully ENL" + name + "\r\n");
							});
						}
					}
				}
				MetroTextBox status_textBox = Form1.status_textBox1;
				MethodInvoker obj2 = val2;
				if (obj2 == null)
				{
					MethodInvoker val3 = delegate
					{
						Form1.status_textBox1.AppendText("APP in Sleep for " + delay + "Seconds " + DateTime.Now.ToString() + "\r\n");
					};
					MethodInvoker val4 = val3;
					val2 = val3;
					obj2 = val4;
				}
				((Control)status_textBox).Invoke((Delegate)(object)obj2);
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
			Form1.status_textBox1.AppendText("ENL/Deletion Finished\r\n");
		});
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
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
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
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected O, but got Unknown
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected O, but got Unknown
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected O, but got Unknown
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Expected O, but got Unknown
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected O, but got Unknown
		//IL_0d7e: Expected O, but got Unknown
		//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected O, but got Unknown
		login_poshmark login_poshmark2 = new login_poshmark();
		Form1 = pm_form;
		if (listing_url == "initialized")
		{
			return;
		}
		((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			Form1.status_textBox1.AppendText("Going For Bulk Price Editting\r\n");
		});
		if (Form1.pro_bulk_editor.dataGridView1_bulk_price_editor.get_Rows().get_Count() <= 0)
		{
			((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				Form1.status_textBox1.AppendText("Fetch your listings first\r\n");
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
					Form1.status_textBox1.AppendText("Going For Price change " + name + " --> " + price + "\r\n");
				});
				string id = text2.Substring(text2.IndexOf("post_id=") + 8, text2.Length - (text2.IndexOf("post_id=") + 8));
				string text3 = this.get_edit_string(id, upload_or_edit: false);
				text3 = text3.Substring(text3.IndexOf("{"), text3.Length - text3.IndexOf("{"));
				text3 = text3.Substring(0, text3.LastIndexOf(";(function(){va"));
				text3 = text3.Replace("seller_broadcast_offer_price\":null", "seller_broadcast_offer_price\":0");
				text3 = text3.Replace("$_listing_editor", "__listing_editor");
				RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(text3.ToString());
				string text4 = "";
				int num = 0;
				try
				{
					num = (int)float.Parse(rootObject.__listing_editor.post.price_amount.val);
					if (num == int.Parse(price))
					{
						((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							Form1.status_textBox1.AppendText("Listing has already same Price " + name + "\r\n");
						});
						continue;
					}
				}
				catch
				{
					((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
					{
						Form1.status_textBox1.AppendText("Listing Price Error: " + name + "\r\n");
					});
				}
				if (rootObject.__listing_editor.post.colors.Count > 0)
				{
					foreach (string color in rootObject.__listing_editor.post.colors)
					{
						text4 = text4 + color + ",";
					}
					text4 = text4.Substring(0, text4.LastIndexOf(","));
					text4 = "\"" + text4.Replace(",", "\",\"") + "\"";
				}
				string text5 = "";
				if (rootObject.__listing_editor.post.inventory.size_quantities.Count > 0)
				{
					foreach (SizeQuantity size_quantity in rootObject.__listing_editor.post.inventory.size_quantities)
					{
						string text6 = "";
						if (size_quantity.size_set_tags.Count > 0)
						{
							text6 = size_quantity.size_set_tags[0].ToString();
						}
						text5 = text5 + "{\"size_id\":\"" + size_quantity.size_id + "\",\"quantity_available\":" + size_quantity.quantity_available + ",\"quantity_reserved\":" + size_quantity.quantity_reserved + ",\"quantity_sold\":" + size_quantity.quantity_sold + ",\"size_ref\":" + size_quantity.size_ref.ToString() + ",\"size_obj\":{\"id\":\"" + size_quantity.size_obj.id + "\",\"display\":\"" + size_quantity.size_obj.display + "\",\"display_with_size_set\":\"" + size_quantity.size_obj.display_with_size_set + "\"},\"size_set_tags\":[\"" + text6 + "\"]},";
					}
					text5 = text5.Substring(0, text5.LastIndexOf(","));
				}
				string text7 = "";
				if (rootObject.__listing_editor.post.pictures.Count > 0)
				{
					foreach (Picture picture in rootObject.__listing_editor.post.pictures)
					{
						text7 = text7 + "{\"id\":\"" + picture.id + "\"},";
					}
					text7 = text7.Substring(0, text7.LastIndexOf(","));
				}
				string text8 = rootObject.__listing_editor.post.title.Replace("\n", "\\n");
				string text9 = "";
				for (int j = 0; j < text8.Length; j++)
				{
					string text10 = text8[j].ToString();
					if (text10 == "\"")
					{
						text10 = "\\" + text8[j];
					}
					text9 += text10;
				}
				text8 = text9;
				string text11 = rootObject.__listing_editor.post.description.Replace("\n", "\\n");
				string text12 = "";
				for (int k = 0; k < text11.Length; k++)
				{
					string text13 = text11[k].ToString();
					if (text13 == "\"")
					{
						text13 = "\\" + text11[k];
					}
					text12 += text13;
				}
				text11 = text12;
				text11 = ((text11[text11.Length - 1] != '.') ? (text11 + ".") : text11.Substring(0, text11.Length - 1));
				string text14 = "";
				string text15 = "";
				string text16 = "";
				string text17 = "";
				if (rootObject.__listing_editor.post.catalog.category_features.Count > 0)
				{
					text14 = "\"" + rootObject.__listing_editor.post.catalog.category_features[0] + "\"";
					text15 = rootObject.__listing_editor.post.catalog.category_feature_objs[0].display;
					text16 = "\"" + rootObject.__listing_editor.post.catalog.category_feature_objs[0].id + "\"";
					_ = "{\"id\":\"" + text16 + "\",\"display\":\"" + text15 + "\"}";
					text17 = "{\"id\":\"" + rootObject.__listing_editor.post.catalog.category_feature_objs[0].id + "\",\"display\":\"" + text15 + "\"}";
				}
				string text18 = rootObject.__listing_editor.post.status_changed_at.ToString("yyyy-MM-dd") + "T16:37:03-08:00";
				text3 = "{\"post\":{\"catalog\":{\"category_features\":[" + text14 + "],\"department\":\"" + rootObject.__listing_editor.post.catalog.department + "\",\"category\":\"" + rootObject.__listing_editor.post.catalog.category + "\",\"department_obj\":{\"id\":\"" + rootObject.__listing_editor.post.catalog.department_obj.id + "\",\"display\":\"" + rootObject.__listing_editor.post.catalog.department_obj.display + "\"},\"category_obj\":{\"id\":\"" + rootObject.__listing_editor.post.catalog.category_obj.id + "\",\"display\":\"" + rootObject.__listing_editor.post.catalog.category_obj.display + "\"},\"category_feature_objs\":[" + text17 + "]},\"colors\":[" + text4 + "],\"inventory\":{\"status\":\"" + rootObject.__listing_editor.post.inventory.status + "\",\"status_changed_at\":\"" + text18 + "\",\"size_quantities\":[" + text5 + "],\"size_quantity_revision\":" + rootObject.__listing_editor.post.inventory.size_quantity_revision + ",\"multi_item\":" + rootObject.__listing_editor.post.inventory.multi_item.ToString().ToLower() + "},\"price_amount\":{ \"val\":\"" + price + "\",\"currency_code\":\"USD\",\"currency_symbol\":\"$\"},\"original_price_amount\":{ \"val\":\"" + rootObject.__listing_editor.post.original_price_amount.val + "\",\"currency_code\":\"USD\",\"currency_symbol\":\"$\"},\"title\":\"" + text8 + "\",\"description\":\"" + text11 + "\",\"brand\":\"" + rootObject.__listing_editor.post.brand + "\",\"condition\":\"" + rootObject.__listing_editor.post.condition + "\",\"cover_shot\":{\"id\":\"" + rootObject.__listing_editor.post.cover_shot.id + "\"},\"pictures\":[" + text7 + "]}}";
				if (!rootObject.__listing_editor.post.title.Contains("\""))
				{
				}
				if (Request_poshmark_com_update_step3(out var response, rootObject.csrftoken, text3, id))
				{
					string text19 = wb.ReadResponse(response);
					if (text19 == "{}" || text19.Contains("\"req_id\":"))
					{
						((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							Form1.status_textBox1.AppendText("Successfully Price Edited " + name + "\r\n");
						});
						if (Form1.bulk_edit_permission.Contains("Not permitted"))
						{
							string input = File.ReadAllText(Form1.bulk_permission_hidden_path);
							string[] array = Regex.Split(input, "--");
							DateTime dateTime = DateTime.ParseExact(array[0], "dd-MM-yyyy", CultureInfo.InvariantCulture);
							DateTime today_date_microsolft = Form1.today_date_microsolft;
							string text20 = "0";
							if (today_date_microsolft.Date > dateTime.Date)
							{
								File.WriteAllText(Form1.bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + text20.ToString());
							}
							else
							{
								if (!(today_date_microsolft.Date == dateTime.Date))
								{
									break;
								}
								text20 = array[1];
							}
							if (int.Parse(text20) > 10)
							{
								((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
								{
									Form1.status_textBox1.AppendText("Your Free Bulk Edit daily Limit Reached, Buy license for further use or wait for 1 day\r\n");
								});
								break;
							}
							cou = int.Parse(text20) + 1;
							((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								Form1.status_textBox1.AppendText("Your " + (10 - cou) + " Free Price Change Left\r\n");
							});
							File.WriteAllText(Form1.bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + cou);
						}
					}
					else
					{
						if (!text19.Contains("\"user_message\":\"Description too long\","))
						{
						}
						((Control)Form1.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							Form1.status_textBox1.AppendText("UnSuccessfully Price Change" + name + "\r\n");
						});
					}
				}
				MetroTextBox status_textBox = Form1.status_textBox1;
				MethodInvoker obj2 = val;
				if (obj2 == null)
				{
					MethodInvoker val2 = delegate
					{
						Form1.status_textBox1.AppendText("APP in Sleep for " + delay + "Seconds " + DateTime.Now.ToString() + "\r\n");
					};
					MethodInvoker val3 = val2;
					val = val2;
					obj2 = val3;
				}
				((Control)status_textBox).Invoke((Delegate)(object)obj2);
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
			Form1.status_textBox1.AppendText("Price Editing Finished Finished\r\n");
		});
	}
}
