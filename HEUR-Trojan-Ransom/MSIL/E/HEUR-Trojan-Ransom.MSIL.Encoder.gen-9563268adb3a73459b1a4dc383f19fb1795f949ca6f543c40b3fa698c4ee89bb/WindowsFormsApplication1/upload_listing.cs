using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApplication1;

internal class upload_listing
{
	private webrequests wb = new webrequests();

	public void main_upload_listing()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_23a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b1: Expected O, but got Unknown
		//IL_23b6: Expected O, but got Unknown
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2534: Expected O, but got Unknown
		//IL_4929: Unknown result type (might be due to invalid IL or missing references)
		//IL_4933: Expected O, but got Unknown
		//IL_494d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4957: Expected O, but got Unknown
		//IL_4999: Unknown result type (might be due to invalid IL or missing references)
		//IL_499e: Unknown result type (might be due to invalid IL or missing references)
		//IL_49a1: Expected O, but got Unknown
		//IL_49a6: Expected O, but got Unknown
		//IL_49de: Unknown result type (might be due to invalid IL or missing references)
		//IL_49e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_49e9: Expected O, but got Unknown
		//IL_4a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a28: Expected O, but got Unknown
		//IL_4a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a59: Expected O, but got Unknown
		int delay = 50;
		login_poshmark login_poshmark2 = new login_poshmark();
		JavaScriptSerializer val = new JavaScriptSerializer();
		TextBox status_textBox = Form1.mainform.status_textBox1;
		object obj = _003C_003Ec._003C_003E9__1_0;
		if (obj == null)
		{
			MethodInvoker val2 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Going For Upload Listing\r\n");
			};
			obj = (object)val2;
			_003C_003Ec._003C_003E9__1_0 = val2;
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
			dynamic jsonObject;
			int iter;
			List<string> pictures_list;
			MethodInvoker val5 = default(MethodInvoker);
			MethodInvoker val8 = default(MethodInvoker);
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
							if (item.Contains("<--<---A-->-->") && item.Contains("<--<---B-->-->") && item.Contains("<--<---C-->-->") && !(item.TrimStart(new char[0]).TrimEnd(new char[0]) == ""))
							{
								string text3 = item.Substring(0, item.IndexOf("<--<---A-->-->"));
								if (text3 == name)
								{
									text2 = item.Substring(item.IndexOf("<--<---B-->-->") + 14, item.Length - (item.IndexOf("<--<---B-->-->") + 14));
									text2 = text2.Replace("<--<---C-->-->", "");
									break;
								}
							}
						}
						((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
						{
							((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Going For Upload " + name + "\r\n");
						});
						string text4 = text2;
						jsonObject = val.Deserialize<object>(text4);
						if (jsonObject["$_listing_editor"] == null)
						{
							TextBox status_textBox2 = Form1.mainform.status_textBox1;
							object obj3 = _003C_003Ec._003C_003E9__1_4;
							if (obj3 == null)
							{
								MethodInvoker val3 = delegate
								{
									((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Please create a new backup file, the current file is old and is not supported by Poshmark \r\n");
								};
								obj3 = (object)val3;
								_003C_003Ec._003C_003E9__1_4 = val3;
							}
							((Control)status_textBox2).Invoke((Delegate)obj3);
							break;
						}
						string text5 = jsonObject["$_listing_editor"]["post"]["cover_shot"]["id"];
						string text6 = update_app.folder_path_backup + "\\" + text5 + ".jpg";
						if (!File.Exists(text6))
						{
							TextBox status_textBox3 = Form1.mainform.status_textBox1;
							object obj4 = _003C_003Ec._003C_003E9__1_5;
							if (obj4 == null)
							{
								MethodInvoker val4 = delegate
								{
									((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Downloading Cover image \r\n");
								};
								obj4 = (object)val4;
								_003C_003Ec._003C_003E9__1_5 = val4;
							}
							((Control)status_textBox3).Invoke((Delegate)obj4);
							using WebClient webClient = new WebClient();
							webClient.DownloadFile(new Uri(jsonObject["$_listing_editor"]["post"]["cover_shot"]["url_large"]), text6);
						}
						if (!File.Exists(text6))
						{
							continue;
						}
						if (Request_poshmark_com_create_listing(out var response, ""))
						{
							string text7 = wb.ReadResponse(response);
							string text8 = text7.Substring(text7.IndexOf("uid\":\"") + 6, text7.Length - (text7.IndexOf("uid\":\"") + 6));
							text8 = text8.Substring(0, text8.IndexOf("\",\""));
							string user_key = text8;
							if (Request_poshmark_com_api_user(out response, token, user_key, ""))
							{
								string text9 = wb.ReadResponse(response);
								string text10 = text9.Replace("id", "").Replace("}", "").Replace("{", "")
									.Replace(":", "")
									.Replace("\"", "")
									.TrimStart(new char[0])
									.TrimEnd(new char[0]);
								if (text9.Contains("\"iu_id\""))
								{
									text10 = text10.Substring(0, text10.IndexOf(","));
								}
								else if (text9.Contains("\"creator_id\":\""))
								{
									text10 = text10.Substring(0, text10.IndexOf(","));
								}
								if (Request_poshmark_com_upload_picture(out response, text10, token, text6))
								{
									string text11 = wb.ReadResponse(response);
									string text12 = "";
									text12 = text11.Substring(7, text11.IndexOf("\",\"") - 7);
									string text13 = jsonObject["$_listing_editor"]["post"]["title"].ToString().Replace("\n", "\\n");
									string text14 = "";
									for (int j = 0; j < text13.Length; j++)
									{
										string text15 = text13[j].ToString();
										if (text15 == "\"")
										{
											text15 = "\\" + text13[j];
										}
										text14 += text15;
									}
									text13 = text14;
									string text16 = jsonObject["$_listing_editor"]["post"]["description"].ToString().Replace("\n", "\\n");
									string text17 = "";
									for (int k = 0; k < text16.Length; k++)
									{
										string text18 = text16[k].ToString();
										if (text18 == "\"")
										{
											text18 = "\\" + text16[k];
										}
										text17 += text18;
									}
									text16 = text17;
									string text19 = "";
									string text20 = "";
									string text21 = "";
									try
									{
										if (jsonObject["$_listing_editor"]["post"]["catalog"]["category_features"].Length > 0)
										{
											text19 = "\"" + jsonObject["$_listing_editor"]["post"]["catalog"]["category_features"][0] + "\"";
											text20 = jsonObject["$_listing_editor"]["post"]["catalog"]["category_feature_objs"][0]["display"];
											text21 = "\"" + jsonObject["$_listing_editor"]["post"]["catalog"]["category_feature_objs"][0]["id"] + "\"";
											_ = "{\"id\":\"" + text21 + "\",\"display\":\"" + text20 + "\"}";
											_ = (string)("{\"id\":\"" + jsonObject["$_listing_editor"]["post"]["catalog"]["category_feature_objs"][0]["id"] + "\",\"display\":\"" + text20 + "\"}");
										}
									}
									catch
									{
									}
									string text22 = "";
									try
									{
										if (jsonObject["$_listing_editor"]["post"]["colors"].Length > 0)
										{
											foreach (dynamic item2 in jsonObject["$_listing_editor"]["post"]["colors"])
											{
												text22 = text22 + item2 + ",";
											}
											text22 = text22.Substring(0, text22.LastIndexOf(","));
											text22 = "\"" + text22.Replace(",", "\",\"") + "\"";
										}
									}
									catch
									{
									}
									iter = 1;
									pictures_list = new List<string>();
									try
									{
										foreach (dynamic item3 in jsonObject["$_listing_editor"]["post"]["pictures"])
										{
											string text23 = update_app.folder_path_backup + "\\" + item3["id"] + ".jpg";
											if (!File.Exists(text23))
											{
												TextBox status_textBox4 = Form1.mainform.status_textBox1;
												MethodInvoker obj7 = val5;
												if (obj7 == null)
												{
													MethodInvoker val6 = delegate
													{
														Form1.mainform.status_textBox1.AppendText("Downloading image " + iter + "/" + jsonObject["$_listing_editor"]["post"]["pictures"].Length + "\r\n");
													};
													MethodInvoker val7 = val6;
													val5 = val6;
													obj7 = val7;
												}
												((Control)status_textBox4).Invoke((Delegate)(object)obj7);
												using WebClient webClient2 = new WebClient();
												webClient2.DownloadFile(new Uri(item3["url_large"]), text23);
											}
											iter++;
											if (File.Exists(text23))
											{
												pictures_list.Add(text23);
											}
										}
									}
									catch
									{
									}
									List<string> list2 = new List<string>();
									foreach (string p in pictures_list)
									{
										try
										{
											((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
											{
												((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Uploading image " + pictures_list.IndexOf(p) + "/" + (pictures_list.Count - 1) + "\r\n");
											});
											if (Request_poshmark_com_upload_picture(out response, text10, token, p))
											{
												string text24 = wb.ReadResponse(response);
												string text25 = "";
												text25 = text24.Substring(7, text24.IndexOf("\",\"") - 7);
												list2.Add(text25);
											}
										}
										catch
										{
										}
									}
									string text26 = "";
									if (list2.Count > 0)
									{
										foreach (string item4 in list2)
										{
											text26 = text26 + "{\"id\":\"" + item4 + "\"},";
										}
										text26 = text26.Substring(0, text26.LastIndexOf(","));
									}
									string text27 = "";
									try
									{
										if (jsonObject["$_listing_editor"]["post"]["inventory"]["size_quantities"].Length > 0)
										{
											foreach (dynamic item5 in jsonObject["$_listing_editor"]["post"]["inventory"]["size_quantities"])
											{
												string text28 = "";
												if (item5["size_set_tags"].Length > 0)
												{
													text28 = item5["size_set_tags"][0];
												}
												text27 = text27 + "{\"size_obj\":{\"id\":\"" + item5["size_obj"]["id"] + "\",\"short\":\"" + item5["size_obj"]["display_with_size_set"] + "\",\"long\":\"" + item5["size_obj"]["display"] + "\",\"display\":\"" + item5["size_obj"]["display"] + "\",\"display_with_size_set\":\"" + item5["size_obj"]["display_with_size_set"] + "\"},\"quantity_available\":" + item5["quantity_available"] + ",\"quantity_sold\":" + item5["quantity_sold"] + ",\"size_set_tags\":[\"" + text28 + "\"]}" + ",";
											}
											text27 = text27.Substring(0, text27.LastIndexOf(","));
											text27 = text27.Replace("[\"\"]", "[]");
										}
									}
									catch
									{
									}
									string picture_id = "";
									string text29 = "";
									try
									{
										text29 = jsonObject["$_listing_editor"]["post"]["brand"];
									}
									catch
									{
									}
									try
									{
										picture_id = "{\"post\":{\"catalog\":{\"department\":\"" + jsonObject["$_listing_editor"]["post"]["catalog"]["department"] + "\",\"category\":\"" + jsonObject["$_listing_editor"]["post"]["catalog"]["category"] + "\",\"category_features\":[" + text19 + "]},\"colors\":[" + text22 + "],\"inventory\":{\"size_quantity_revision\":0,\"multi_item\":" + jsonObject["$_listing_editor"]["post"]["inventory"]["multi_item"].ToString().ToLower() + ",\"size_quantities\":[" + text27 + "]},\"price\":\"" + jsonObject["$_listing_editor"]["post"]["price"] + "\",\"original_price\":\"" + jsonObject["$_listing_editor"]["post"]["original_price"] + "\",\"title\":\"" + text13 + "\",\"description\":\"" + text16 + "\",\"brand\":\"" + text29 + "\",\"condition\":\"" + jsonObject["$_listing_editor"]["post"]["condition"] + "\",\"cover_shot\":{\"id\":\"" + text12 + "\"},\"pictures\":[" + text26 + "]}}";
									}
									catch (Exception)
									{
									}
									if (Request_poshmark_com_post_data(out response, token, text10, picture_id))
									{
										string text30 = wb.ReadResponse(response);
										if (text30 != "{}" && !text30.Contains("\"req_id\""))
										{
											((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
											{
												((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("Not Uploaded " + name + "\r\n");
											});
										}
										else
										{
											((Control)Form1.mainform.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
											{
												((TextBoxBase)Form1.mainform.Log_textBox1).AppendText("Successfully Uploaded " + name + "\r\n");
											});
										}
									}
								}
							}
						}
						try
						{
							delay = Form1.ed.delay_value_getter(((Control)Form1.pro_closet_backup_class.backup_copy_listing_delay_textBox2).get_Text());
						}
						catch
						{
						}
						TextBox status_textBox5 = Form1.mainform.status_textBox1;
						MethodInvoker obj13 = val8;
						if (obj13 == null)
						{
							MethodInvoker val9 = delegate
							{
								((TextBoxBase)Form1.mainform.status_textBox1).AppendText("APP in Sleep for " + delay + "Seconds " + DateTime.Now.ToString() + "\r\n");
							};
							MethodInvoker val7 = val9;
							val8 = val9;
							obj13 = val7;
						}
						((Control)status_textBox5).Invoke((Delegate)(object)obj13);
						Form1.sleep_stats_function(delay, "");
						continue;
					}
					TextBox status_textBox6 = Form1.mainform.status_textBox1;
					object obj14 = _003C_003Ec._003C_003E9__1_2;
					if (obj14 == null)
					{
						MethodInvoker val10 = delegate
						{
							((TextBoxBase)Form1.mainform.status_textBox1).AppendText("No Backup File Found\r\n");
						};
						obj14 = (object)val10;
						_003C_003Ec._003C_003E9__1_2 = val10;
					}
					((Control)status_textBox6).Invoke((Delegate)obj14);
					return;
				}
				catch (Exception)
				{
				}
			}
			TextBox status_textBox7 = Form1.mainform.status_textBox1;
			object obj15 = _003C_003Ec._003C_003E9__1_11;
			if (obj15 == null)
			{
				MethodInvoker val11 = delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Uploading finished\r\n");
				};
				obj15 = (object)val11;
				_003C_003Ec._003C_003E9__1_11 = val11;
			}
			((Control)status_textBox7).Invoke((Delegate)obj15);
			return;
		}
		TextBox status_textBox8 = Form1.mainform.status_textBox1;
		object obj16 = _003C_003Ec._003C_003E9__1_1;
		if (obj16 == null)
		{
			MethodInvoker val12 = delegate
			{
				((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Not able to login\r\n");
			};
			obj16 = (object)val12;
			_003C_003Ec._003C_003E9__1_1 = val12;
		}
		((Control)status_textBox8).Invoke((Delegate)obj16);
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
