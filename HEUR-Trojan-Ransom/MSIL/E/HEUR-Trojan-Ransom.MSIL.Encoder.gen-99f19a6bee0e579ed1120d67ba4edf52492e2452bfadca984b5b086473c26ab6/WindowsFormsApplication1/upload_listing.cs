using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using Newtonsoft.Json;

namespace WindowsFormsApplication1;

internal class upload_listing
{
	private webrequests wb = new webrequests();

	public void main_upload_listing()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected O, but got Unknown
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected O, but got Unknown
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e84: Expected O, but got Unknown
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected O, but got Unknown
		//IL_0ed3: Expected O, but got Unknown
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected O, but got Unknown
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected O, but got Unknown
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f87: Expected O, but got Unknown
		int delay = 50;
		login_poshmark login_poshmark2 = new login_poshmark();
		MetroTextBox status_textBox = Form1.mainform.status_textBox1;
		object obj = _003C_003Ec._003C_003E9__1_0;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				Form1.mainform.status_textBox1.AppendText("Going For Upload Listing\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__1_0 = val;
		}
		((Control)status_textBox).Invoke((Delegate)obj);
		string text = login_poshmark2.check_who_is_logined(Form1.ck);
		extract_data extract_data2 = new extract_data(login_poshmark2);
		string token = extract_data2.return_csrf_token(Form1.ck);
		if (text != null)
		{
			text.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
			List<string> list = new List<string>();
			if (File.Exists(update_app.folder_path_backup + "\\backups.bk"))
			{
				try
				{
					list = File.ReadAllLines(update_app.folder_path_backup + "\\backups.bk").ToList();
				}
				catch
				{
				}
			}
			string name;
			RootObject data_searialized;
			MethodInvoker val4 = default(MethodInvoker);
			for (int i = 0; i < Form1.pro_closet_backup_class.upload_dataGridView1.get_Rows().get_Count(); i++)
			{
				try
				{
					if (!(bool)Form1.pro_closet_backup_class.upload_dataGridView1.get_Rows().get_Item(i).get_Cells()
						.get_Item(0)
						.get_Value())
					{
						continue;
					}
					Form1.pro_closet_backup_class.upload_dataGridView1.get_Rows().get_Item(i).get_Cells()
						.get_Item(3)
						.get_Value()
						.ToString();
					name = Form1.pro_closet_backup_class.upload_dataGridView1.get_Rows().get_Item(i).get_Cells()
						.get_Item(1)
						.get_Value()
						.ToString();
					string text2 = "";
					if (File.Exists(update_app.folder_path_backup + "\\backups.bk"))
					{
						foreach (string item in list)
						{
							string text3 = item.Substring(0, item.IndexOf("<--<---A-->-->"));
							if (text3 == name)
							{
								text2 = item.Substring(item.IndexOf("<--<---B-->-->") + 14, item.Length - (item.IndexOf("<--<---B-->-->") + 14));
								text2 = text2.Replace("<--<---C-->-->", "");
								break;
							}
						}
						((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							Form1.mainform.status_textBox1.AppendText("Going For Upload " + name + "\r\n");
						});
						string text4 = text2;
						data_searialized = JsonConvert.DeserializeObject<RootObject>(text4.ToString());
						if (data_searialized.__listing_editor == null)
						{
							MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
							object obj3 = _003C_003Ec._003C_003E9__1_4;
							if (obj3 == null)
							{
								MethodInvoker val2 = delegate
								{
									Form1.mainform.status_textBox1.AppendText("Please create a new backup file, the current file is old and is not supported by Poshmark \r\n");
								};
								obj3 = (object)val2;
								_003C_003Ec._003C_003E9__1_4 = val2;
							}
							((Control)status_textBox2).Invoke((Delegate)obj3);
							break;
						}
						string id = data_searialized.__listing_editor.post.cover_shot.id;
						string text5 = update_app.folder_path_backup + "\\" + id + ".jpg";
						if (!File.Exists(text5))
						{
							MetroTextBox status_textBox3 = Form1.mainform.status_textBox1;
							object obj4 = _003C_003Ec._003C_003E9__1_5;
							if (obj4 == null)
							{
								MethodInvoker val3 = delegate
								{
									Form1.mainform.status_textBox1.AppendText("Downloading Cover image \r\n");
								};
								obj4 = (object)val3;
								_003C_003Ec._003C_003E9__1_5 = val3;
							}
							((Control)status_textBox3).Invoke((Delegate)obj4);
							using WebClient webClient = new WebClient();
							webClient.DownloadFile(new Uri(data_searialized.__listing_editor.post.cover_shot.url_large), text5);
						}
						if (!File.Exists(text5))
						{
							continue;
						}
						if (Request_poshmark_com_create_listing(out var response, ""))
						{
							string text6 = wb.ReadResponse(response);
							string text7 = text6.Substring(text6.IndexOf("uid\":\"") + 6, text6.Length - (text6.IndexOf("uid\":\"") + 6));
							text7 = text7.Substring(0, text7.IndexOf("\",\""));
							string user_key = text7;
							if (Request_poshmark_com_api_user(out response, token, user_key, ""))
							{
								string text8 = wb.ReadResponse(response);
								string text9 = text8.Replace("id", "").Replace("}", "").Replace("{", "")
									.Replace(":", "")
									.Replace("\"", "")
									.TrimStart(new char[0])
									.TrimEnd(new char[0]);
								if (text8.Contains("\"iu_id\""))
								{
									text9 = text9.Substring(0, text9.IndexOf(","));
								}
								else if (text8.Contains("\"creator_id\":\""))
								{
									text9 = text9.Substring(0, text9.IndexOf(","));
								}
								if (Request_poshmark_com_upload_picture(out response, text9, token, text5))
								{
									string text10 = wb.ReadResponse(response);
									string text11 = "";
									text11 = text10.Substring(7, text10.IndexOf("\",\"") - 7);
									string text12 = data_searialized.__listing_editor.post.title.Replace("\n", "\\n");
									string text13 = "";
									for (int j = 0; j < text12.Length; j++)
									{
										string text14 = text12[j].ToString();
										if (text14 == "\"")
										{
											text14 = "\\" + text12[j];
										}
										text13 += text14;
									}
									text12 = text13;
									string text15 = data_searialized.__listing_editor.post.description.Replace("\n", "\\n");
									string text16 = "";
									for (int k = 0; k < text15.Length; k++)
									{
										string text17 = text15[k].ToString();
										if (text17 == "\"")
										{
											text17 = "\\" + text15[k];
										}
										text16 += text17;
									}
									text15 = text16;
									string text18 = "";
									string text19 = "";
									string text20 = "";
									if (data_searialized.__listing_editor.post.catalog.category_features.Count > 0)
									{
										text18 = "\"" + data_searialized.__listing_editor.post.catalog.category_features[0] + "\"";
										text19 = data_searialized.__listing_editor.post.catalog.category_feature_objs[0].display;
										text20 = "\"" + data_searialized.__listing_editor.post.catalog.category_feature_objs[0].id + "\"";
										_ = "{\"id\":\"" + text20 + "\",\"display\":\"" + text19 + "\"}";
										_ = "{\"id\":\"" + data_searialized.__listing_editor.post.catalog.category_feature_objs[0].id + "\",\"display\":\"" + text19 + "\"}";
									}
									string text21 = "";
									if (data_searialized.__listing_editor.post.colors.Count > 0)
									{
										foreach (string color in data_searialized.__listing_editor.post.colors)
										{
											text21 = text21 + color + ",";
										}
										text21 = text21.Substring(0, text21.LastIndexOf(","));
										text21 = "\"" + text21.Replace(",", "\",\"") + "\"";
									}
									List<string> pictures_list = new List<string>();
									foreach (Picture pic in data_searialized.__listing_editor.post.pictures)
									{
										string text22 = update_app.folder_path_backup + "\\" + pic.id + ".jpg";
										if (!File.Exists(text22))
										{
											((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
											{
												Form1.mainform.status_textBox1.AppendText("Downloading image " + data_searialized.__listing_editor.post.pictures.IndexOf(pic) + "/" + (data_searialized.__listing_editor.post.pictures.Count - 1) + "\r\n");
											});
											using WebClient webClient2 = new WebClient();
											webClient2.DownloadFile(new Uri(pic.url_large), text22);
										}
										if (File.Exists(text22))
										{
											pictures_list.Add(text22);
										}
									}
									List<string> list2 = new List<string>();
									foreach (string p in pictures_list)
									{
										((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
										{
											Form1.mainform.status_textBox1.AppendText("Uploading image " + pictures_list.IndexOf(p) + "/" + (pictures_list.Count - 1) + "\r\n");
										});
										if (Request_poshmark_com_upload_picture(out response, text9, token, p))
										{
											string text23 = wb.ReadResponse(response);
											string text24 = "";
											text24 = text23.Substring(7, text23.IndexOf("\",\"") - 7);
											list2.Add(text24);
										}
									}
									string text25 = "";
									if (list2.Count > 0)
									{
										foreach (string item2 in list2)
										{
											text25 = text25 + "{\"id\":\"" + item2 + "\"},";
										}
										text25 = text25.Substring(0, text25.LastIndexOf(","));
									}
									string text26 = "";
									if (data_searialized.__listing_editor.post.inventory.size_quantities.Count > 0)
									{
										foreach (SizeQuantity size_quantity in data_searialized.__listing_editor.post.inventory.size_quantities)
										{
											string text27 = "";
											if (size_quantity.size_set_tags.Count > 0)
											{
												text27 = size_quantity.size_set_tags[0];
											}
											text26 = text26 + "{\"size_obj\":{\"id\":\"" + size_quantity.size_obj.id + "\",\"short\":\"" + size_quantity.size_obj.display_with_size_set + "\",\"long\":\"" + size_quantity.size_obj.display + "\",\"display\":\"" + size_quantity.size_obj.display + "\",\"display_with_size_set\":\"" + size_quantity.size_obj.display_with_size_set + "\"},\"quantity_available\":" + size_quantity.quantity_available + ",\"quantity_sold\":" + size_quantity.quantity_sold + ",\"size_set_tags\":[\"" + text27 + "\"]},";
										}
										text26 = text26.Substring(0, text26.LastIndexOf(","));
										text26 = text26.Replace("[\"\"]", "[]");
									}
									string text28 = "";
									text28 = "{\"post\":{\"catalog\":{\"department\":\"" + data_searialized.__listing_editor.post.catalog.department + "\",\"category\":\"" + data_searialized.__listing_editor.post.catalog.category + "\",\"category_features\":[" + text18 + "]},\"colors\":[" + text21 + "],\"inventory\":{\"size_quantity_revision\":0,\"multi_item\":" + data_searialized.__listing_editor.post.inventory.multi_item.ToString().ToLower() + ",\"size_quantities\":[" + text26 + "]},\"price\":\"" + data_searialized.__listing_editor.post.price + "\",\"original_price\":\"" + data_searialized.__listing_editor.post.original_price + "\",\"title\":\"" + text12 + "\",\"description\":\"" + text15 + "\",\"brand\":\"" + data_searialized.__listing_editor.post.brand + "\",\"condition\":\"" + data_searialized.__listing_editor.post.condition + "\",\"cover_shot\":{\"id\":\"" + text11 + "\"},\"pictures\":[" + text25 + "]}}";
									if (Request_poshmark_com_post_data(out response, token, text9, text28))
									{
										string text29 = wb.ReadResponse(response);
										if (text29 != "{}" && !text29.Contains("\"req_id\""))
										{
											((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
											{
												Form1.mainform.status_textBox1.AppendText("Not Uploaded " + name + "\r\n");
											});
										}
										else
										{
											((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
											{
												Form1.mainform.status_textBox1.AppendText("Uploaded " + name + "\r\n");
											});
										}
									}
								}
							}
						}
						try
						{
							delay = Form1.ed.delay_value_getter(((Control)Form1.pro_closet_backup_class.backup_copy_listing_dela_textBox2).get_Text());
						}
						catch
						{
						}
						MetroTextBox status_textBox4 = Form1.mainform.status_textBox1;
						MethodInvoker obj6 = val4;
						if (obj6 == null)
						{
							MethodInvoker val5 = delegate
							{
								Form1.mainform.status_textBox1.AppendText("APP in Sleep for " + delay + "Seconds " + DateTime.Now.ToString() + "\r\n");
							};
							MethodInvoker val6 = val5;
							val4 = val5;
							obj6 = val6;
						}
						((Control)status_textBox4).Invoke((Delegate)(object)obj6);
						Thread.Sleep(delay * 1000);
						continue;
					}
					MetroTextBox status_textBox5 = Form1.mainform.status_textBox1;
					object obj7 = _003C_003Ec._003C_003E9__1_2;
					if (obj7 == null)
					{
						MethodInvoker val7 = delegate
						{
							Form1.mainform.status_textBox1.AppendText("No Backup File Found\r\n");
						};
						obj7 = (object)val7;
						_003C_003Ec._003C_003E9__1_2 = val7;
					}
					((Control)status_textBox5).Invoke((Delegate)obj7);
					return;
				}
				catch
				{
				}
			}
			MetroTextBox status_textBox6 = Form1.mainform.status_textBox1;
			object obj9 = _003C_003Ec._003C_003E9__1_11;
			if (obj9 == null)
			{
				MethodInvoker val8 = delegate
				{
					Form1.mainform.status_textBox1.AppendText("Uploading finished\r\n");
				};
				obj9 = (object)val8;
				_003C_003Ec._003C_003E9__1_11 = val8;
			}
			((Control)status_textBox6).Invoke((Delegate)obj9);
			return;
		}
		MetroTextBox status_textBox7 = Form1.mainform.status_textBox1;
		object obj10 = _003C_003Ec._003C_003E9__1_1;
		if (obj10 == null)
		{
			MethodInvoker val9 = delegate
			{
				Form1.mainform.status_textBox1.AppendText("Not able to login\r\n");
			};
			obj10 = (object)val9;
			_003C_003Ec._003C_003E9__1_1 = val9;
		}
		((Control)status_textBox7).Invoke((Delegate)obj10);
	}

	public bool Request_poshmark_com_create_listing(out HttpWebResponse response, string misc)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://poshmark.com/sell");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";
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

	public bool Request_poshmark_com_api_user(out HttpWebResponse response, string token, string user_key, string misc)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://poshmark.com/vm-rest/users/" + user_key + "/posts");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "application/json";
			httpWebRequest.Headers.Add("Origin", "https://poshmark.com");
			httpWebRequest.Headers.Add("X-XSRF-TOKEN", token);
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Referer = "https://poshmark.com/create-listing";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "{}";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
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

	private static void WriteMultipartBodyToRequest(HttpWebRequest request, string body)
	{
		string[] array = Regex.Split(body, "<!>");
		using MemoryStream memoryStream = new MemoryStream();
		string[] array2 = array;
		foreach (string text in array2)
		{
			byte[] array3 = ((!File.Exists(text)) ? Encoding.UTF8.GetBytes(text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n")) : File.ReadAllBytes(text));
			memoryStream.Write(array3, 0, array3.Length);
		}
		request.ContentLength = memoryStream.Length;
		using Stream stream = request.GetRequestStream();
		memoryStream.WriteTo(stream);
	}

	public bool Request_poshmark_com_upload_picture(out HttpWebResponse response, string user_id, string token, string misc)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://poshmark.com/api/posts/" + user_id + "/media");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Headers.Add("Origin", "https://poshmark.com");
			httpWebRequest.Headers.Add("X-CSRF-Token", token);
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";
			httpWebRequest.ContentType = "multipart/form-data; boundary=----WebKitFormBoundaryvdlAt1ktJeruWOV3";
			httpWebRequest.Referer = "https://poshmark.com/sell";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string body = "------WebKitFormBoundaryvdlAt1ktJeruWOV3\r\nContent-Disposition: form-data; name=\"file\"; filename=\"01.jpg\"\r\nContent-Type: image/jpeg\r\n\r\n<!>" + misc + "<!>------WebKitFormBoundaryvdlAt1ktJeruWOV3--";
			WriteMultipartBodyToRequest(httpWebRequest, body);
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

	public bool Request_poshmark_com_post_data(out HttpWebResponse response, string token, string user_id, string picture_id)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://poshmark.com/vm-rest/posts/" + user_id + "?rest=true");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Accept = "application/json";
			httpWebRequest.Headers.Add("Origin", "https://poshmark.com");
			httpWebRequest.Headers.Add("X-XSRF-TOKEN", token);
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Referer = "https://poshmark.com/create-listing";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			httpWebRequest.CookieContainer = Form1.ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			byte[] bytes = Encoding.UTF8.GetBytes(picture_id);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			response = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = wb.ReadResponse(response);
			if (!(text != "{}"))
			{
			}
			response = null;
			try
			{
				httpWebRequest = (HttpWebRequest)WebRequest.Create("https://poshmark.com/vm-rest/posts/" + user_id + "/status/published?app_version=2.55&rest=true");
				httpWebRequest.KeepAlive = true;
				httpWebRequest.Accept = "application/json";
				httpWebRequest.Headers.Add("Origin", "https://poshmark.com");
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
				httpWebRequest.ContentType = "application/json";
				httpWebRequest.Referer = "https://poshmark.com/create-listing";
				httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
				httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
				httpWebRequest.CookieContainer = Form1.ck;
				httpWebRequest.Method = "PUT";
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
		}
		catch (WebException ex3)
		{
			if (ex3.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex3.Response;
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
}
