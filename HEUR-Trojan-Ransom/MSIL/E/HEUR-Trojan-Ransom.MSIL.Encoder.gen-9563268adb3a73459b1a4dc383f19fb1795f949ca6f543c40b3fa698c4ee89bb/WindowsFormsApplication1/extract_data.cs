using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using HtmlAgilityPack;
using MetroFramework.Controls;
using Newtonsoft.Json;
using Poshmark_tools;
using SEO_BB.Harvester;

namespace WindowsFormsApplication1;

public class extract_data
{
	public class Data
	{
		public string user_id { get; set; }

		public string alert { get; set; }
	}

	public class Target
	{
		public string route { get; set; }

		public bool mapp_enabled { get; set; }

		public Data data { get; set; }

		public string url { get; set; }

		public object actionData { get; set; }

		public object screenData { get; set; }
	}

	public class Datum3
	{
		public string image { get; set; }
	}

	public class Actor
	{
		public string type { get; set; }

		public List<Datum3> data { get; set; }

		public int count { get; set; }
	}

	public class BannerItem
	{
		public string message { get; set; }

		public Target target { get; set; }

		public Actor actor { get; set; }

		public string bg_color { get; set; }
	}

	public class Datum4
	{
		public string id { get; set; }

		public string object_type { get; set; }

		public object ext_service_id { get; set; }

		public string username { get; set; }

		public string display_handle { get; set; }

		public string full_name { get; set; }

		public string fb_user_id { get; set; }

		public string picture_url { get; set; }

		public string commenting_status { get; set; }

		public string image { get; set; }
	}

	public class Actor2
	{
		public string type { get; set; }

		public List<Datum4> data { get; set; }

		public int count { get; set; }
	}

	public class Icon
	{
		public string url { get; set; }
	}

	public class Data2
	{
		public string user_id { get; set; }

		public string username { get; set; }

		public string post_id { get; set; }

		public string post_title { get; set; }
	}

	public class IconImage
	{
		public string url { get; set; }
	}

	public class RightImage
	{
		public string url { get; set; }
	}

	public class Data3
	{
		public string user_id { get; set; }

		public string username { get; set; }
	}

	public class Target3
	{
		public string route { get; set; }

		public bool mapp_enabled { get; set; }

		public Data3 data { get; set; }

		public string url { get; set; }
	}

	public class Pb
	{
		public string name { get; set; }

		public string text { get; set; }

		public string text_color { get; set; }

		public string bg_color { get; set; }

		public IconImage icon_image { get; set; }

		public RightImage right_image { get; set; }

		public Target3 target { get; set; }

		public string destination_url { get; set; }

		public string banner_tap_track_event { get; set; }
	}

	public class Params
	{
		public Pb pb { get; set; }
	}

	public class Target2
	{
		public string route { get; set; }

		public bool mapp_enabled { get; set; }

		public Data2 data { get; set; }

		public string url { get; set; }

		public object actionData { get; set; }

		public object screenData { get; set; }

		public Params @params { get; set; }
	}

	public class CoverShot
	{
		public string url_small { get; set; }
	}

	public class Datum5
	{
		public string id { get; set; }

		public string content { get; set; }

		public object start_time { get; set; }

		public CoverShot cover_shot { get; set; }
	}

	public class Content2
	{
		public string type { get; set; }

		public int count { get; set; }

		public List<Datum5> data { get; set; }
	}

	public class NewsItem
	{
		public string id { get; set; }

		public Actor2 actor { get; set; }

		public string message { get; set; }

		public Icon icon { get; set; }

		public bool read { get; set; }

		public Target2 target { get; set; }

		public DateTime created_at { get; set; }

		public Content2 content { get; set; }
	}

	public class Datum2
	{
		public BannerItem banner_item { get; set; }

		public NewsItem news_item { get; set; }
	}

	public class More
	{
		public object url { get; set; }

		public object actionData { get; set; }

		public object screenData { get; set; }
	}

	public class Content
	{
		public string type { get; set; }

		public List<Datum2> data { get; set; }

		public More more { get; set; }
	}

	public class View
	{
		public string layout { get; set; }

		public object borders { get; set; }
	}

	public class Datum
	{
		public string story_type { get; set; }

		public object header { get; set; }

		public Content content { get; set; }

		public View view { get; set; }

		public object footer { get; set; }
	}

	public class More2
	{
		public string next_max_id { get; set; }
	}

	public class RootObject_new
	{
		public List<Datum> data { get; set; }

		public More2 more { get; set; }
	}

	public struct Listing_info
	{
		public string listing_link;

		public string party_link;

		public string listing_name;
	}

	public struct litsing_filter
	{
		public string category;

		public string keyword;

		public bool _category_keyword_match;

		public bool _notforsale_SHARE;

		public bool _sold_SHARE;

		public bool _noprice_check_SHARE;
	}

	public struct Listng_data
	{
		public string description;

		public string title;

		public string other_info;

		public string image_link;

		public string price;

		public string listing_link;

		public string image_url;
	}

	private webrequests wb;

	private login_poshmark lg;

	private string password = string.Empty;

	private Form1 pm_form;

	private int captcha_fucked = 0;

	private int blocked_test = 0;

	public List<object> feed_items_Community_sharing
	{
		get
		{
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected O, but got Unknown
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0432: Expected O, but got Unknown
			//IL_0437: Expected O, but got Unknown
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0575: Expected O, but got Unknown
			List<dynamic> listings_Result = new List<object>();
			try
			{
				Random random = new Random();
				string text = "";
				int num = item_count / 48 + 1;
				for (int i = 0; i <= num * 2; i++)
				{
					int index = random.Next(0, Form1.brands_list.Count);
					text = text + Form1.brands_list[index] + ",";
				}
				List<string> list = new List<string>();
				int iter = 0;
				string[] array = Regex.Split(text, ",");
				string[] array2 = array;
				MethodInvoker val3 = default(MethodInvoker);
				foreach (string text2 in array2)
				{
					if (text2 != "")
					{
						string text3 = text2;
						string[] array3 = Regex.Split(text2, " ");
						try
						{
							if (array3.Length > 1)
							{
								random = new Random();
								int num2 = random.Next(0, array3.Length);
								text3 = array3[num2];
							}
							else
							{
								text3 = text2;
							}
						}
						catch
						{
							try
							{
								text3 = text2;
							}
							catch
							{
							}
						}
						string text4 = "";
						string url = "https://poshmark.com/vm-rest/posts?request={%22filters%22:{%22department%22:%22All%22,%22inventory_status%22:[%22available%22]},%22query_and_facet_filters%22:{%22department%22:%22All%22},%22query%22:%22" + text3.ToLower().TrimStart(new char[0]).TrimEnd(new char[0]) + "%22,%22facets%22:[%22department%22,%22category_v2%22,%22category_feature%22,%22brand%22,%22size%22,%22color%22],%22experience%22:%22all%22," + text4 + "%22count%22:%2248%22}&summarize=true";
						string text5 = return_html_straight_request(url, ck);
						JavaScriptSerializer val = new JavaScriptSerializer();
						try
						{
							if (text5.Contains(">Page not found - Poshmark<"))
							{
								((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
								{
									((TextBoxBase)pm_form.status_textBox1).AppendText("Page not Found 'Follow' --->" + url + "\r\n");
								});
								continue;
							}
							dynamic val2 = val.Deserialize<object>(text5);
							try
							{
								foreach (dynamic listing in val2["data"])
								{
									string item = listing["creator_username"].ToString();
									if (!list.Contains(item))
									{
										list.Add(item);
										((List<object>)listings_Result).Add(listing);
										((Control)pm_form.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
										{
											pm_form.Log_textBox1.AppendText("Listing Fetched: " + listing["title"] + "\r\n");
										});
									}
									if (listings_Result.Count >= item_count)
									{
										break;
									}
								}
							}
							catch
							{
							}
							TextBox status_textBox = pm_form.status_textBox1;
							MethodInvoker obj4 = val3;
							if (obj4 == null)
							{
								MethodInvoker val4 = delegate
								{
									((TextBoxBase)pm_form.status_textBox1).AppendText("Listing Fetched: from page " + iter + ", total listings fetched" + listings_Result.Count + "\r\n");
								};
								MethodInvoker val5 = val4;
								val3 = val4;
								obj4 = val5;
							}
							((Control)status_textBox).Invoke((Delegate)(object)obj4);
							if (listings_Result.Count >= item_count)
							{
								break;
							}
							goto IL_04bf;
						}
						catch (Exception ex)
						{
							try
							{
								File.AppendAllText("nw.logs", "-" + DateTime.Now.ToString() + "- " + ex.ToString() + "\r\n---" + url);
							}
							catch
							{
							}
							goto IL_04bf;
						}
					}
					goto IL_04f2;
					IL_04bf:
					int num3 = iter;
					iter = num3 + 1;
					if (iter > 50)
					{
						break;
					}
					goto IL_04f2;
					IL_04f2:
					Thread.Sleep(500);
				}
			}
			catch
			{
			}
			return listings_Result;
		}
	}

	public List<object> closet_listings_by_name
	{
		get
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected O, but got Unknown
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Expected O, but got Unknown
			//IL_04b2: Expected O, but got Unknown
			List<dynamic> listings_Result = new List<object>();
			string text = "";
			string text2 = "";
			text2 = (available_or_all ? "All" : "available");
			string text3 = return_filter_link();
			if (text3 != "")
			{
				text3 = "%2C%22sort_by%22%3A%22" + text3 + "%22";
			}
			int num = int.Parse(misc);
			int num2 = 100;
			try
			{
				JavaScriptSerializer val = new JavaScriptSerializer();
				int iter = 0;
				MethodInvoker val3 = default(MethodInvoker);
				while (true)
				{
					string link = "";
					if (!closet_name.Contains("https://poshmark.com/party/"))
					{
						string text4 = "48";
						if (((CheckBox)Form1.pro_configuration_class.fetch_all_listings_metroCheckBox1).get_Checked())
						{
							text4 = "9999";
						}
						link = "https://poshmark.com/vm-rest/users/" + closet_name + "/posts/filtered?request=%7B%22filters%22%3A%7B%22department%22%3A%22All%22%2C%22inventory_status%22%3A%5B%22" + text2 + "%22%5D%7D%2C%22query_and_facet_filters%22%3A%7B%22creator_id%22%3A%22" + closet_name + "%22%7D" + text3 + "%2C%22facets%22%3A%5B%22department%22%2C%22category_v2%22%2C%22category_feature%22%2C%22brand%22%2C%22size%22%2C%22color%22%5D%2C%22experience%22%3A%22all%22%2C" + text + "%22count%22%3A" + text4 + "%7D&summarize=true&app_version=2.55";
					}
					else
					{
						string text5 = closet_name.Replace("https://poshmark.com/party/", "");
						link = "https://poshmark.com/vm-rest/events/" + text5 + "/posts/filtered?request=%7B%22filters%22%3A%7B%22department%22%3A%22All%22%2C%22inventory_status%22%3A%5B%22all%22%5D%7D%2C%22query_and_facet_filters%22%3A%7B%22department%22%3A%22All%22%7D%2C%22experience%22%3A%22all%22%2C" + text + "%22count%22%3A48%7D&summarize=true&app_version=2.55";
					}
					string text6 = return_html_straight_request(link, ck);
					try
					{
						if (text6.Contains(">Page not found - Poshmark<"))
						{
							((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)pm_form.status_textBox1).AppendText("Page not Found 'Follow' --->" + link + "\r\n");
							});
							listings_Result = new List<object>();
							return listings_Result;
						}
						dynamic val2 = val.Deserialize<object>(text6);
						int num3 = 0;
						try
						{
							foreach (dynamic data in val2["data"])
							{
								switch ((string)data["inventory"]["status"])
								{
								case "sold_out":
									num3++;
									break;
								case "not_for_sale":
									num3++;
									break;
								}
								((List<object>)listings_Result).Add(data);
								((Control)pm_form.Log_textBox1).Invoke((Delegate)(MethodInvoker)delegate
								{
									pm_form.Log_textBox1.AppendText("Listing Fetched: " + data["title"] + "\r\n");
								});
								if (listings_Result.Count >= num)
								{
									break;
								}
							}
							TextBox status_textBox = pm_form.status_textBox1;
							MethodInvoker obj = val3;
							if (obj == null)
							{
								MethodInvoker val4 = delegate
								{
									((TextBoxBase)pm_form.status_textBox1).AppendText("Listing Fetched: from page " + iter + ", total listings fetched" + listings_Result.Count + "\r\n");
								};
								MethodInvoker val5 = val4;
								val3 = val4;
								obj = val5;
							}
							((Control)status_textBox).Invoke((Delegate)(object)obj);
							if (listings_Result.Count >= num)
							{
								break;
							}
						}
						catch
						{
						}
						try
						{
							if (iter == 1 && ((val2["data"].Length != 48) ? true : false))
							{
								num2 = (int)(3000 / val2["data"].Length);
							}
						}
						catch
						{
						}
						string text7 = "";
						try
						{
							text7 = val2["more"]["next_max_id"].ToString();
						}
						catch
						{
							goto end_IL_014b;
						}
						text = "%22max_id%22%3A" + text7 + "%2C";
						goto IL_0984;
						end_IL_014b:;
					}
					catch (Exception ex)
					{
						try
						{
							File.AppendAllText("nw.logs", "-" + DateTime.Now.ToString() + "- " + ex.ToString() + "\r\n---" + link);
						}
						catch
						{
						}
						goto IL_0984;
					}
					break;
					IL_0984:
					int num4 = iter;
					iter = num4 + 1;
					if (iter <= num2)
					{
						Thread.Sleep(500);
						continue;
					}
					break;
				}
			}
			catch
			{
			}
			return listings_Result;
		}
	}

	public List<string> listings_based_on_keyword
	{
		get
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Expected O, but got Unknown
			//IL_0408: Expected O, but got Unknown
			MethodInvoker val = (MethodInvoker)delegate
			{
				((TextBoxBase)pm_form.status_textBox1).AppendText("Going For Lead Data Extraction of " + keyword + ", expected Listings checked " + total_leads + "\r\n");
			};
			((Control)pm_form).Invoke((Delegate)(object)val);
			string text = "";
			new HtmlDocument();
			string path = Form1.schedule_save_path.Replace("schd.sch", "") + "pl.cfg";
			if (File.Exists(path))
			{
				string input = File.ReadAllText(path);
				string[] array = Regex.Split(input, "\r\n");
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (!text2.Contains(keyword.ToLower() + "----"))
					{
						continue;
					}
					string text3 = Regex.Split(text2, "----")[1].Replace("&max_id=", "");
					text = "%22max_id%22:%22" + text3 + "%22,";
					try
					{
						string s = Regex.Split(text2, "----")[1].Substring(Regex.Split(text2, "----")[1].IndexOf("=") + 1, Regex.Split(text2, "----")[1].Length - (Regex.Split(text2, "----")[1].IndexOf("=") + 1));
						if (int.Parse(s) > 25)
						{
							text = "";
						}
					}
					catch
					{
						text = "";
					}
					break;
				}
			}
			else
			{
				text = "";
			}
			int st = 0;
			List<string> username_list = new List<string>();
			List<string> list = new List<string>();
			MethodInvoker val2 = default(MethodInvoker);
			while (username_list.Count < int.Parse(total_leads))
			{
				string url = "https://poshmark.com/vm-rest/posts?request={%22filters%22:{%22department%22:%22All%22,%22inventory_status%22:[%22available%22]},%22query_and_facet_filters%22:{%22department%22:%22All%22},%22query%22:%22" + keyword.ToLower().TrimStart(new char[0]).TrimEnd(new char[0]) + "%22,%22facets%22:[%22department%22,%22category_v2%22,%22category_feature%22,%22brand%22,%22size%22,%22color%22],%22experience%22:%22all%22," + text + "%22count%22:%2248%22}&summarize=true";
				Random random = new Random();
				if (wb.Request_poshmark_com(out var response, url, 2, "", ck))
				{
					string value = wb.ReadResponse(response);
					try
					{
						search_class.RootObject rootObject = JsonConvert.DeserializeObject<search_class.RootObject>(value);
						if (rootObject != null)
						{
							foreach (search_class.Datum datum in rootObject.data)
							{
								string id = datum.id;
								if (return_listings && username_list.Contains(datum.creator_username))
								{
									continue;
								}
								if (!((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
								{
									list.Add("https://poshmark.com/listing/-" + id);
								}
								else
								{
									list.Add("https://poshmark.ca/listing/-" + id);
								}
								username_list.Add(datum.creator_username);
								if ((datum.aggregates.likes > 0 || datum.aggregates.comments > 0) && !return_listings)
								{
									string url2 = "https://poshmark.com/vm-rest/posts/" + id + "?app_version=2.55";
									if (wb.Request_poshmark_com(out response, url2, 2, "", ck))
									{
										string value2 = wb.ReadResponse(response);
										listing_page_class.RootObject rootObject2 = JsonConvert.DeserializeObject<listing_page_class.RootObject>(value2);
										foreach (listing_page_class.Like like in rootObject2.data.likes)
										{
											username_list.Add(like.creator_username);
										}
										foreach (listing_page_class.Comment comment in rootObject2.data.comments)
										{
											username_list.Add(comment.creator_username);
										}
									}
									Thread.Sleep(random.Next(700, 2100));
								}
								MethodInvoker obj2 = val2;
								if (obj2 == null)
								{
									MethodInvoker val3 = delegate
									{
										((TextBoxBase)pm_form.status_textBox1).AppendText("Listing Data Fetched From page" + st + ", Total Leads Closets Found: " + username_list.Count + "\r\n");
									};
									MethodInvoker val4 = val3;
									val2 = val3;
									obj2 = val4;
								}
								val = obj2;
								((Control)pm_form).Invoke((Delegate)(object)val);
								if ((double)username_list.Count > (double)int.Parse(total_leads) * 1.15)
								{
									break;
								}
							}
							username_list = username_list.Distinct().ToList();
							if (rootObject.more.next_max_id == 0)
							{
								break;
							}
							text = "%22max_id%22:%22" + rootObject.more.next_max_id + "%22,";
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(2000);
				if (return_listings && list.Count > int.Parse(total_leads))
				{
					break;
				}
				st++;
				if (st > 15)
				{
					break;
				}
			}
			try
			{
				if (File.Exists(path))
				{
					string text4 = File.ReadAllText(path);
					string[] array3 = Regex.Split(text4, "\r\n");
					bool flag = false;
					string[] array4 = array3;
					foreach (string text5 in array4)
					{
						if (text5.Contains(keyword.ToLower() + "----"))
						{
							text4 = text4.Replace(text5, keyword.ToLower() + "----" + text.Replace("%22max_id%22:%22", "&max_id=").Replace("%22,", ""));
							File.WriteAllText(path, text4);
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						File.AppendAllText(path, keyword.ToLower() + "----" + text.Replace("%22max_id%22:%22", "&max_id=").Replace("%22,", "") + "\r\n");
					}
				}
				else
				{
					File.WriteAllText(path, keyword.ToLower() + "----" + text.Replace("%22max_id%22:%22", "&max_id=").Replace("%22,", "") + "\r\n");
				}
			}
			catch
			{
			}
			if (!return_listings)
			{
				return username_list;
			}
			return list;
		}
	}

	public List<string> profiles_based_on_closet
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_0965: Unknown result type (might be due to invalid IL or missing references)
			//IL_096b: Expected O, but got Unknown
			//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b0: Expected O, but got Unknown
			//IL_09b5: Expected O, but got Unknown
			bool flag = false;
			if (follow_unfollow == "true")
			{
				flag = true;
			}
			JavaScriptSerializer val = new JavaScriptSerializer();
			MethodInvoker val2 = (MethodInvoker)delegate
			{
				((TextBoxBase)pm_form.status_textBox1).AppendText("Going For followers of " + closet_name + ", expected profiles fetched " + total_leads + "\r\n");
			};
			((Control)pm_form).Invoke((Delegate)(object)val2);
			string text = "";
			new HtmlDocument();
			new HtmlDocument();
			List<string> leads = new List<string>();
			int st = 0;
			string[] array = Regex.Split(closet_name.Replace("@", ""), ",");
			string[] array2 = array;
			MethodInvoker val5 = default(MethodInvoker);
			foreach (string text2 in array2)
			{
				string text3 = text2.ToLower().TrimStart(new char[0]).TrimEnd(new char[0]);
				if (text3 == "")
				{
					continue;
				}
				st = 0;
				text = "";
				while (leads.Count < int.Parse(total_leads))
				{
					string text4 = "";
					text4 = ((!flag) ? ("https://poshmark.com/vm-rest/users/" + text3 + "/following?max_id=" + text + "&count=48") : ((!follower_following) ? ("https://poshmark.com/vm-rest/users/" + text3 + "/following?max_id=" + text + "&count=48") : ("https://poshmark.com/vm-rest/users/" + text3 + "/followers?max_id=" + text + "&count=48")));
					try
					{
						if (wb.Request_poshmark_com(out var response, text4, 2, "", ck))
						{
							string text5 = wb.ReadResponse(response);
							check_cpatcha(text5, "follow", ref ck, ref token);
							dynamic val3 = val.Deserialize<object>(text5);
							dynamic val4 = val3["data"];
							foreach (dynamic item in val4)
							{
								try
								{
									bool flag2 = false;
									try
									{
										if (item["caller_is_following"])
										{
											flag2 = true;
										}
									}
									catch
									{
									}
									if (flag)
									{
										if (!flag2)
										{
											leads.Add("/closet/" + item["username"] + "------" + item["id"]);
										}
									}
									else if (flag2)
									{
										leads.Add("/closet/" + item["username"] + "------" + item["id"]);
									}
								}
								catch
								{
								}
							}
							try
							{
								text = val3["more"]["next_max_id"].ToString();
							}
							catch
							{
								break;
							}
						}
					}
					catch (Exception)
					{
					}
					Thread.Sleep(1000);
					leads = leads.Distinct().ToList();
					if (leads.Count > int.Parse(total_leads))
					{
						break;
					}
					List<string> tmp = new List<string>();
					foreach (string item2 in leads)
					{
						tmp.Add(item2.Substring(0, item2.IndexOf("--")));
					}
					val2 = (MethodInvoker)delegate
					{
						((Control)pm_form.Log_textBox1).set_Text(string.Join("\r\n", tmp.ToArray()) + "\r\n");
					};
					((Control)pm_form).Invoke((Delegate)(object)val2);
					tmp = new List<string>();
					MethodInvoker obj4 = val5;
					if (obj4 == null)
					{
						MethodInvoker val6 = delegate
						{
							((TextBoxBase)pm_form.status_textBox1).AppendText("Listing Data Fetched From page" + st + ", Total Leads Listings Found: " + leads.Count + "\r\n");
						};
						MethodInvoker val7 = val6;
						val5 = val6;
						obj4 = val7;
					}
					val2 = obj4;
					((Control)pm_form).Invoke((Delegate)(object)val2);
					int num = st;
					st = num + 1;
					if (st > 25)
					{
						break;
					}
				}
			}
			return leads;
		}
	}

	public string logined_available_items
	{
		get
		{
			HtmlDocument htmlDocument = new HtmlDocument();
			if (wb.Request_poshmark_com(out var response, "https://poshmark.com/users/self/closet_stats", 2, "", ck))
			{
				string text = wb.ReadResponse(response);
				htmlDocument.LoadHtml(text.Replace("\\", ""));
				HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='stat-count']");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						if (item.ParentNode.InnerHtml.Contains(">Available Listings<"))
						{
							return item.InnerText;
						}
					}
				}
			}
			return "";
		}
	}

	public string posh_market
	{
		set
		{
			if (wb.Request_poshmark_com_select_all_poshmarket(out var response, ck, value))
			{
				wb.ReadResponse(response);
			}
			return true;
		}
	}

	public string eventid
	{
		get
		{
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			string result = "";
			try
			{
				HtmlDocument htmlDocument = new HtmlDocument();
				if (wb.Request_poshmark_com(out var response, "https://poshmark.com/parties", 2, "", ck))
				{
					string text = wb.ReadResponse(response);
					check_cpatcha(text, "share", ref ck, ref csrf_token);
					htmlDocument.LoadHtml(text.Replace("\\", ""));
					HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='party__list--current']/li");
					if (htmlNodeCollection != null)
					{
						using IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator();
						if (enumerator.MoveNext())
						{
							HtmlNode itm = enumerator.Current;
							string value = Regex.Match(itm.InnerHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
							result = value.Replace("/party/", "");
							((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
							{
								((TextBoxBase)pm_form.status_textBox1).AppendText("Party Happening now " + itm.InnerText.Replace("amp;", "").TrimStart(new char[0]).TrimEnd(new char[0]) + "\r\n");
							});
							return result;
						}
					}
				}
			}
			catch
			{
			}
			return result;
		}
	}

	public string party_requirements
	{
		get
		{
			string result = "";
			try
			{
				HtmlDocument htmlDocument = new HtmlDocument();
				if (wb.Request_poshmark_com(out var response, "https://poshmark.com/party/" + csrf_token, 2, "", ck))
				{
					string html = wb.ReadResponse(response);
					htmlDocument.LoadHtml(html);
					HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//script");
					if (htmlNodeCollection != null)
					{
						foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
						{
							if (item.InnerHtml.Contains("window.__INITIAL_STATE__="))
							{
								string text = item.InnerHtml.Replace("window.__INITIAL_STATE__=", "");
								return text.Substring(0, text.LastIndexOf(";(function()"));
							}
						}
					}
				}
			}
			catch
			{
			}
			return result;
		}
	}

	public extract_data(login_poshmark lg)
	{
		this.lg = lg;
		wb = Form1.wb;
		pm_form = Form1.mainform;
	}

	public int delay_value_getter(string input)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		bool delay_protection = true;
		try
		{
			MethodInvoker val = (MethodInvoker)delegate
			{
				delay_protection = ((CheckBox)Form1.pro_configuration_class.delay_protection_checkBox1).get_Checked();
			};
			((Control)pm_form).Invoke((Delegate)(object)val);
		}
		catch
		{
		}
		int follow_delay = 1;
		string text = input;
		foreach (char c in text)
		{
			if ((c < '0' || c > '9') && c != ',')
			{
				input = "5";
			}
		}
		string[] array = Regex.Split(input, ",");
		if (array.Length > 2)
		{
			input = "5";
		}
		if (input.Contains(","))
		{
			string[] array2 = Regex.Split(input, ",");
			int num = 0;
			int num2 = 0;
			if (int.Parse(array2[0]) > int.Parse(array2[1]))
			{
				num = int.Parse(array2[0]);
				num2 = int.Parse(array2[1]);
			}
			else
			{
				num = int.Parse(array2[1]);
				num2 = int.Parse(array2[0]);
			}
			if (delay_protection)
			{
				if (num2 <= 5)
				{
					num2 = 5;
				}
				if (num < 6)
				{
					num = 6;
				}
			}
			Random random = new Random();
			follow_delay = random.Next(num2, num);
		}
		else
		{
			if (delay_protection)
			{
				try
				{
					if (int.Parse(input) <= 4)
					{
						input = "5";
					}
				}
				catch
				{
					input = "5";
				}
			}
			follow_delay = int.Parse(input);
		}
		MethodInvoker val2 = (MethodInvoker)delegate
		{
			((TextBoxBase)pm_form.status_textBox1).AppendText("Paused for " + follow_delay + " seconds\r\n");
		};
		((Control)pm_form).Invoke((Delegate)(object)val2);
		return follow_delay;
	}

	public string return_html_straight_request(string link, CookieContainer ck)
	{
		string result = "";
		if (wb.straight_request(out var response, link, ck))
		{
			result = wb.ReadResponse(response);
		}
		return result;
	}

	public string return_html_straight_put(string link, CookieContainer ck, ref string token)
	{
		string text = "";
		int num = 0;
		while (true)
		{
			if (num < 3)
			{
				if (!wb.straight_put(out var response, link, ck, ""))
				{
					goto IL_007f;
				}
				text = wb.ReadResponse(response);
				check_cpatcha(text, "share", ref ck, ref token);
				if (text.Contains("SuspectedBotError"))
				{
					goto IL_007f;
				}
				if (!((num == 0) & text.Contains("\"error\"")))
				{
					break;
				}
				if (link.Contains("?event_ids="))
				{
					link = link.Substring(0, link.IndexOf("?event_ids="));
					goto IL_007f;
				}
			}
			return text;
			IL_007f:
			Thread.Sleep(500);
			num++;
		}
		return text;
	}

	public string return_filter_link()
	{
		return "";
	}

	public List<Listing_info> extract_listings_from_closet(string closet_name, string shares_required, string party_id, ref string token, ref CookieContainer ck, EditSchdParameters.SchdParametersStruct sc)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_129b: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a2: Expected O, but got Unknown
		List<Listing_info> list = new List<Listing_info>();
		try
		{
			MethodInvoker val = (MethodInvoker)delegate
			{
				((TextBoxBase)pm_form.status_textBox1).AppendText("Going For Listings Data Extraction of " + closet_name + ", expected Shares " + shares_required + "\r\n");
			};
			((Control)pm_form).Invoke((Delegate)(object)val);
			int num = 0;
			try
			{
				double num2 = double.Parse(shares_required) * 1.15;
				num = (int)num2;
			}
			catch
			{
			}
			if (token != null)
			{
			}
			int num3 = 0;
			int num4 = 0;
			num4 = num / 48;
			if (num4 * 48 < num)
			{
				num4++;
			}
			List<object> list2 = new List<object>();
			new HtmlDocument();
			string closet_link = "";
			if (closet_name == "feed")
			{
				list2 = this.get_feed_items_Community_sharing("feed", available_or_all: false, num, ck);
			}
			else if (closet_name == "party shareback")
			{
				closet_link = "https://poshmark.com/party/" + party_id;
				list2 = this.get_closet_listings_by_name(closet_link, available_or_all: false, num.ToString(), ck);
			}
			else
			{
				list2 = this.get_closet_listings_by_name(closet_name, available_or_all: false, num.ToString(), ck);
			}
			val = (MethodInvoker)delegate
			{
				((TextBoxBase)pm_form.status_textBox1).AppendText("Closet Link: " + closet_link + "\r\n");
			};
			((Control)pm_form).Invoke((Delegate)(object)val);
			litsing_filter litsing_filter = default(litsing_filter);
			if (sc.type == null)
			{
				sc.type = "";
			}
			if (((CheckBox)Form1.pro_tools_class.share_listings_with_keywords_checkBox5).get_Checked() || sc.type == "Share Specific Listings")
			{
				Regex.Split(((Control)Form1.pro_tools_class.share_listings_with_keywords_textBox5).get_Text(), ",");
				if (sc.type == "Share Specific Listings")
				{
					if (sc.ShareSpecificListingsFromMyCloset != null)
					{
						Regex.Split(sc.ShareSpecificListingsFromMyCloset.ToLower(), ",");
					}
					else
					{
						(new string[1])[0] = "";
					}
				}
				litsing_filter.category = ((Control)Form1.pro_tools_class.share_listings_with_keywords_textBox5).get_Text();
				litsing_filter.keyword = ((Control)Form1.pro_tools_class.share_listings_with_keywords_textBox5).get_Text();
				litsing_filter._category_keyword_match = true;
			}
			if (closet_name != "feed")
			{
				List<object> list3 = new List<object>();
				foreach (dynamic item2 in list2)
				{
					try
					{
						int num5 = int.Parse(item2["price"].ToString());
						bool flag = true;
						if (!litsing_filter._noprice_check_SHARE && num5 > 9999)
						{
							flag = false;
						}
						string text = item2["inventory"]["status"];
						if (!litsing_filter._sold_SHARE && text == "sold_out")
						{
							flag = false;
						}
						if (!litsing_filter._notforsale_SHARE && text == "not_for_sale")
						{
							flag = false;
						}
						if (party_id != "For Excel" && litsing_filter.keyword != "" && litsing_filter.keyword != null)
						{
							bool flag2 = false;
							string[] array = Regex.Split(litsing_filter.keyword, ",");
							string[] array2 = array;
							foreach (string text2 in array2)
							{
								string text3 = text2.ToLower().TrimStart(new char[0]).TrimEnd(new char[0]);
								if (text3 != "" && (item2["title"].ToString().ToLower().Contains(text3) ? true : false))
								{
									flag2 = true;
									break;
								}
							}
							if (litsing_filter._category_keyword_match)
							{
								if (!flag2)
								{
									flag = false;
								}
							}
							else if (flag2)
							{
								flag = false;
							}
						}
						if (party_id != "For Excel" && !flag && litsing_filter.category != "" && litsing_filter.category != null)
						{
							int num6 = 0;
							string text4 = item2["department"]["display"].ToString();
							if (litsing_filter.category.Contains(text4.ToLower()))
							{
								num6++;
							}
							string text5 = item2["category_v2"]["display"].ToString();
							if (litsing_filter.category.Contains(text5.ToLower()))
							{
								num6++;
							}
							foreach (dynamic item3 in item2["category_features"])
							{
								if (litsing_filter.category.Contains(item3["display"].ToLower()))
								{
									num6++;
									break;
								}
							}
							if ((item2["brand"].ToLower() != "") && (litsing_filter.category.Contains(item2["brand"].ToLower()) ? true : false))
							{
								num6++;
							}
							if (litsing_filter._category_keyword_match)
							{
								if (num6 == 0)
								{
									flag = false;
								}
							}
							else if (num6 > 0)
							{
								flag = false;
							}
						}
						if (flag)
						{
							list3.Add(item2);
						}
					}
					catch
					{
					}
				}
				list2 = list3;
			}
			try
			{
				if (list2.Count > 0)
				{
					num3 = list2.Count - 1;
					while (true)
					{
						if (((dynamic)list2[num3])["inventory"]["status"] == "not_for_sale")
						{
							list2.RemoveAt(num3);
							num3--;
							continue;
						}
						if (((dynamic)list2[num3])["inventory"]["status"] == "sold_out")
						{
							list2.RemoveAt(num3);
							num3--;
							continue;
						}
						break;
					}
				}
			}
			catch
			{
			}
			string text6 = "";
			string text7 = "";
			string text8 = "";
			if (party_id != "")
			{
				try
				{
					string text9 = this.get_party_requirements(Form1.ck, party_id);
					JavaScriptSerializer val2 = new JavaScriptSerializer();
					dynamic val3 = val2.Deserialize<object>(text9);
					try
					{
						foreach (dynamic item4 in val3["$_party"]["eventInfo"]["data"]["theme"]["brands"])
						{
							text6 = text6 + item4 + ",";
						}
					}
					catch
					{
						text6 = "all";
					}
					try
					{
						foreach (dynamic item5 in val3["$_party"]["eventInfo"]["data"]["theme"]["categories_v2"])
						{
							text7 = text7 + item5 + ",";
						}
					}
					catch
					{
						text7 = "all";
					}
					try
					{
						foreach (dynamic item6 in val3["$_party"]["eventInfo"]["data"]["theme"]["size_set_tags"])
						{
							text8 = text8 + item6 + ",";
						}
					}
					catch
					{
						text8 = "all";
					}
				}
				catch
				{
				}
			}
			foreach (dynamic item7 in list2)
			{
				try
				{
					bool flag3 = false;
					bool flag4 = false;
					Listing_info item = default(Listing_info);
					item.listing_name = item7["inventory"]["status"] + "||" + item7["title"].ToString();
					try
					{
						if (text6 != "")
						{
							if (text6 != "all")
							{
								if (item7["brand"].ToString().ToLower() != "")
								{
									string[] array3 = Regex.Split(text6, ",");
									foreach (string text10 in array3)
									{
										if (text10.ToLower() == item7["brand"].ToString().ToLower())
										{
											flag3 = true;
											break;
										}
									}
								}
							}
							else
							{
								flag3 = true;
							}
						}
						if (text7 != "")
						{
							if (text7 != "all")
							{
								if (item7["category_v2"]["id"].ToString() != "")
								{
									string[] array4 = Regex.Split(text7, ",");
									foreach (string text11 in array4)
									{
										if (text11 == item7["category_v2"]["id"].ToString())
										{
											flag4 = true;
											break;
										}
									}
								}
							}
							else
							{
								flag4 = true;
							}
						}
					}
					catch (Exception)
					{
					}
					if (flag3 && flag4)
					{
						item.listing_name += "||Party";
					}
					item.listing_link = item7["id"].ToString();
					list.Add(item);
				}
				catch
				{
				}
			}
		}
		catch (Exception ex2)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "055a) " + ex2.ToString() + "\r\n");
		}
		return list;
	}

	public List<string> extract_closet_from_news(string required_sharers, ref string token, ref CookieContainer ck, bool share_follow)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		MethodInvoker val = (MethodInvoker)delegate
		{
			((TextBoxBase)pm_form.status_textBox1).AppendText("Going to find profiles who share my listings, expected Profiles fetched " + required_sharers + "\r\n");
		};
		((Control)pm_form).Invoke((Delegate)(object)val);
		List<string> closets_name = new List<string>();
		int num = 0;
		try
		{
			double num2 = double.Parse(required_sharers);
			num = (int)num2;
		}
		catch
		{
		}
		if (token != null)
		{
		}
		int st = 0;
		string text = "";
		new HtmlDocument();
		string text2 = "https://poshmark.com/news";
		string text3 = "";
		if (wb.Request_poshmark_com(out var response, "https://poshmark.com/feed", 1, "", ck))
		{
			HtmlDocument htmlDocument = new HtmlDocument();
			string text4 = wb.ReadResponse(response);
			htmlDocument.LoadHtml(text4.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//script");
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
			{
				string input = item.InnerText.TrimStart(new char[0]);
				string[] array = Regex.Split(input, ";");
				string[] array2 = array;
				foreach (string text5 in array2)
				{
					if (!text5.Contains("\"uid\""))
					{
						if (text5.Contains("_user_id "))
						{
							text3 = text5.Replace("var _user_id = ", "").Replace("\"", "").TrimEnd(new char[0])
								.TrimStart(new char[0]);
							break;
						}
						continue;
					}
					string text6 = text5.Substring(text5.IndexOf("\"uid\":\"") + 7, text5.Length - (text5.IndexOf("\"uid\":\"") + 7));
					text3 = text6.Substring(0, text6.IndexOf("\",\""));
					break;
				}
			}
		}
		text = "";
		do
		{
			text2 = "https://poshmark.com/vm-rest/users/" + text3 + "/newsfeed/all?" + text;
			if (wb.Request_poshmark_com_simple_request_feed(out response, text2, ck))
			{
				string text7 = wb.ReadResponse(response);
				check_cpatcha(text7, "share", ref ck, ref token);
				RootObject_new rootObject_new = JsonConvert.DeserializeObject<RootObject_new>(text7.ToString());
				if (rootObject_new.data != null)
				{
					foreach (Datum datum in rootObject_new.data)
					{
						if (share_follow)
						{
							if (datum.story_type == "PersonSharePost")
							{
								string username = datum.content.data[0].news_item.actor.data[0].username;
								closets_name.Add(username);
								closets_name = closets_name.Distinct().ToList();
								if (closets_name.Count >= num)
								{
									break;
								}
							}
						}
						else if (datum.story_type == "PersonFollowPerson")
						{
							string username2 = datum.content.data[0].news_item.actor.data[0].username;
							closets_name.Add("/closet/" + username2);
							closets_name = closets_name.Distinct().ToList();
							if (closets_name.Count >= num)
							{
								break;
							}
						}
					}
					text = "maxId=" + rootObject_new.more.next_max_id;
				}
			}
			st++;
			Thread.Sleep(2000);
			val = (MethodInvoker)delegate
			{
				((TextBoxBase)pm_form.status_textBox1).AppendText("Share Closets Data Fetched From News page" + st + ", Total Closets Found: " + closets_name.Count + "\r\n");
			};
			((Control)pm_form).Invoke((Delegate)(object)val);
		}
		while (closets_name.Count < num && st <= 25);
		try
		{
			closets_name.RemoveRange(0, closets_name.Count - num);
		}
		catch
		{
		}
		return closets_name;
	}

	public List<string> extract_closet_of_new_poshers(string required_sharers, ref string token, ref CookieContainer ck)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0396: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		MethodInvoker val = (MethodInvoker)delegate
		{
			((TextBoxBase)pm_form.status_textBox1).AppendText("Going to find New Poshers, expected Profiles fetched " + required_sharers + "\r\n");
		};
		((Control)pm_form).Invoke((Delegate)(object)val);
		List<string> closets_name = new List<string>();
		int num = 0;
		try
		{
			double num2 = double.Parse(required_sharers);
			num = (int)num2;
		}
		catch
		{
		}
		if (token != null)
		{
		}
		int st = 0;
		string text = "";
		HtmlDocument htmlDocument = new HtmlDocument();
		string text2 = "https://poshmark.com/brand/Meet%20the%20Posher";
		int end_ = 0;
		end_ = num / 48;
		if (end_ * 48 < num)
		{
			end_++;
		}
		end_ += 5;
		MethodInvoker val2 = default(MethodInvoker);
		while (st < end_)
		{
			if (wb.Request_poshmark_com_simple_request_feed(out var response, text2 + text, ck))
			{
				string text3 = wb.ReadResponse(response);
				check_cpatcha(text3, "share", ref ck, ref token);
				htmlDocument.LoadHtml(text3.Replace("\\", ""));
				if (text3.Contains("<title>Page not found - Poshmark</title>"))
				{
					val = (MethodInvoker)delegate
					{
						((TextBoxBase)pm_form.Log_textBox1).AppendText("Page not Foundr\n");
					};
					((Control)pm_form).Invoke((Delegate)(object)val);
					break;
				}
				HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='tile  ']");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						try
						{
							string value = item.Attributes["data-creator-handle"].Value;
							closets_name.Add(value);
						}
						catch (Exception ex)
						{
							if (!Directory.Exists("logs"))
							{
								Directory.CreateDirectory("logs");
							}
							File.AppendAllText("logs//logs.jk", "0585) " + ex.ToString() + "\r\n");
						}
					}
					if (htmlNodeCollection.Count < 48)
					{
						break;
					}
				}
				else
				{
					htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='tile__creator d--fl']");
					if (htmlNodeCollection != null)
					{
						foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)htmlNodeCollection)
						{
							try
							{
								string value2 = item2.Attributes["href"].Value;
								closets_name.Add(value2);
							}
							catch (Exception ex2)
							{
								if (!Directory.Exists("logs"))
								{
									Directory.CreateDirectory("logs");
								}
								File.AppendAllText("logs//logs.jk", "0585) " + ex2.ToString() + "\r\n");
							}
						}
						if (htmlNodeCollection.Count < 48)
						{
							break;
						}
					}
				}
				try
				{
					string text4 = text3.Substring(text3.IndexOf("max_id") + 6, text3.Length - (text3.IndexOf("max_id") + 6));
					if (!text4.Contains("?max_id"))
					{
					}
					text4 = text4.Substring(2, text4.IndexOf("}") - 2);
					text = ((!text2.Contains("brand/Meet")) ? ("&max_id=" + text4) : ("?max_id=" + text4));
					if (text.Contains("filter"))
					{
						text = text.Substring(0, text.IndexOf(",\""));
					}
					if (text.ToLower().Contains("null"))
					{
						break;
					}
				}
				catch
				{
					break;
				}
			}
			st++;
			Thread.Sleep(2000);
			MethodInvoker obj3 = val2;
			if (obj3 == null)
			{
				MethodInvoker val3 = delegate
				{
					((TextBoxBase)pm_form.status_textBox1).AppendText("New Poshers Fetched From page" + st + " Total pages " + end_ + ", Total Listings Found: " + closets_name.Count + "\r\n");
				};
				MethodInvoker val4 = val3;
				val2 = val3;
				obj3 = val4;
			}
			val = obj3;
			((Control)pm_form).Invoke((Delegate)(object)val);
			if (closets_name.Count > int.Parse(required_sharers) || st > 30)
			{
				break;
			}
		}
		text = "null";
		try
		{
			closets_name = closets_name.Distinct().ToList();
		}
		catch
		{
		}
		return closets_name;
	}

	public dynamic extract_closet_page_date(string closet_name)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		HtmlDocument htmlDocument = new HtmlDocument();
		JavaScriptSerializer val = new JavaScriptSerializer();
		if (Form1.wb.Request_poshmark_com(out var response, "https://poshmark.com/closet/" + closet_name.Replace("/closet/", ""), 2, "", Form1.ck))
		{
			string text = Form1.wb.ReadResponse(response);
			try
			{
				htmlDocument.LoadHtml(text.Replace("\\", ""));
				if (text.Contains("<title>Page not found - Poshmark</title>"))
				{
					MethodInvoker val2 = (MethodInvoker)delegate
					{
						((TextBoxBase)pm_form.Log_textBox1).AppendText("Page not Foundr\n");
					};
					((Control)pm_form).Invoke((Delegate)(object)val2);
					return null;
				}
				HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//script");
				bool flag = true;
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						if (item.InnerHtml.Contains("window.__INITIAL_STATE__="))
						{
							string text2 = item.InnerHtml.Replace("window.__INITIAL_STATE__=", "");
							text2 = text2.Substring(0, text2.LastIndexOf(";(function()"));
							object result = val.Deserialize<object>(text2);
							flag = false;
							return result;
						}
					}
				}
				if (flag)
				{
					string text3 = "";
					htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@data-user-id]");
					if (htmlNodeCollection != null)
					{
						foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)htmlNodeCollection)
						{
							text3 = item2.Attributes["data-user-id"].Value;
						}
					}
					htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//li[@class='follow-action-con']");
					if (htmlNodeCollection != null)
					{
						using IEnumerator<HtmlNode> enumerator3 = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator();
						if (enumerator3.MoveNext())
						{
							HtmlNode current3 = enumerator3.Current;
							_ = Regex.Match(current3.InnerHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
							if (current3.InnerHtml.Contains("\"auth-required btn blue\""))
							{
								string text4 = "{\"closet_det_id\" : \"" + text3 + "\",\"user_already_following\" : false}";
								return val.Deserialize<object>(text4);
							}
							return null;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return null;
	}

	public Listng_data extract_listings_data_listinglink(string listinglink, ref string token, ref CookieContainer ck)
	{
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c4: Expected O, but got Unknown
		Listng_data Ld = default(Listng_data);
		HtmlDocument htmlDocument = new HtmlDocument();
		if (wb.Request_poshmark_com_simple_request_feed(out var response, listinglink, ck))
		{
			string text = wb.ReadResponse(response);
			check_cpatcha(text, "share", ref ck, ref token);
			htmlDocument.LoadHtml(text.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[contains(@class, 'description')]");
			if (htmlNodeCollection != null)
			{
				foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
				{
					Ld.description = item.InnerText.Replace("&amp;", "").Replace("&nbsp;", "").Replace("&quot;", "")
						.TrimStart(new char[0])
						.TrimEnd(new char[0]);
				}
			}
			htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//h1[@class='title']");
			if (htmlNodeCollection != null)
			{
				MethodInvoker val = default(MethodInvoker);
				foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)htmlNodeCollection)
				{
					Ld.title = item2.InnerText.Replace("&amp;", "").Replace("&nbsp;", " ").Replace("&quot;", "\"")
						.Replace("&#47;$", "/")
						.TrimStart(new char[0])
						.TrimEnd(new char[0]);
					TextBox status_textBox = pm_form.status_textBox1;
					MethodInvoker obj = val;
					if (obj == null)
					{
						MethodInvoker val2 = delegate
						{
							((TextBoxBase)pm_form.status_textBox1).AppendText("Listing Fetched: " + Ld.title + "\r\n");
						};
						MethodInvoker val3 = val2;
						val = val2;
						obj = val3;
					}
					((Control)status_textBox).Invoke((Delegate)(object)obj);
				}
			}
			else
			{
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='listing__title']");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item3 in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						Ld.title = item3.InnerText.Replace("&amp;", "").Replace("&nbsp;", " ").Replace("&quot;", "\"")
							.TrimStart(new char[0])
							.TrimEnd(new char[0]);
					}
				}
			}
			htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@itemprop='image']");
			if (htmlNodeCollection != null)
			{
				using IEnumerator<HtmlNode> enumerator4 = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator();
				if (enumerator4.MoveNext())
				{
					HtmlNode current4 = enumerator4.Current;
					Ld.image_link = current4.Attributes["data-img-src"].Value;
					Ld.image_url = current4.Attributes["data-img-src"].Value;
				}
			}
			else
			{
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='d--fl']//img");
				if (htmlNodeCollection != null)
				{
					using IEnumerator<HtmlNode> enumerator5 = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator();
					if (enumerator5.MoveNext())
					{
						HtmlNode current5 = enumerator5.Current;
						Ld.image_link = current5.Attributes["src"].Value;
						Ld.image_url = current5.Attributes["src"].Value;
					}
				}
			}
			htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='item-info']/div/*");
			if (htmlNodeCollection != null)
			{
				foreach (HtmlNode item4 in (IEnumerable<HtmlNode>)htmlNodeCollection)
				{
					if (item4.OuterHtml.Contains("=\"price\">"))
					{
						try
						{
							string text2 = item4.InnerText.TrimStart(new char[0]).TrimEnd(new char[0]);
							Ld.price = text2.Substring(0, text2.IndexOf("&nbsp;"));
						}
						catch
						{
							Ld.price = item4.InnerText.TrimStart(new char[0]).TrimEnd(new char[0]);
							continue;
						}
						break;
					}
				}
			}
			else
			{
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='listing__ipad-centered d--fl ai--c m--t--3']");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item5 in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						try
						{
							string text3 = item5.InnerText.TrimStart(new char[0]).TrimEnd(new char[0]);
							Ld.price = text3.Substring(0, text3.IndexOf("\n"));
						}
						catch
						{
							Ld.price = item5.InnerText.TrimStart(new char[0]).TrimEnd(new char[0]);
							continue;
						}
						break;
					}
				}
				else
				{
					htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='listing__ipad-centered d--fl ai--c m--t--5']");
					if (htmlNodeCollection != null)
					{
						foreach (HtmlNode item6 in (IEnumerable<HtmlNode>)htmlNodeCollection)
						{
							try
							{
								string text4 = item6.InnerText.TrimStart(new char[0]).TrimEnd(new char[0]);
								Ld.price = text4.Substring(0, text4.IndexOf("\n"));
							}
							catch
							{
								Ld.price = item6.InnerText.TrimStart(new char[0]).TrimEnd(new char[0]);
								continue;
							}
							break;
						}
					}
					else
					{
						string text5 = text.Substring(text.IndexOf("\"price\":") + 8, text.Length - (text.IndexOf("\"price\":") + 8));
						text5 = text5.Substring(0, text5.IndexOf("\","));
						text5 = text5.Replace("\"", "").TrimStart(new char[0]).TrimEnd(new char[0]);
						Ld.price = Convert.ToInt64(Math.Floor(Convert.ToDouble(text5))).ToString();
					}
				}
			}
			string text6 = "";
			if (Ld.image_link != "" && Ld.title != "")
			{
				text6 = Regex.Replace(Ld.title, "[^a-zA-Z0-9]", "") + "_" + DateTime.Now.Ticks;
				if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\\\images"))
				{
					Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\\\images");
				}
				if (!File.Exists(Directory.GetCurrentDirectory() + "\\\\images\\\\" + text6 + ".png"))
				{
					using WebClient webClient = new WebClient();
					webClient.DownloadFile(new Uri(Ld.image_link), Directory.GetCurrentDirectory() + "\\\\images\\\\" + text6 + ".png");
				}
				Ld.image_link = Directory.GetCurrentDirectory() + "\\\\images\\\\" + text6 + ".png";
			}
		}
		return Ld;
	}

	public List<string> extract_usernames_from_listings(List<string> listings, string follow_required, ref string token, ref CookieContainer ck)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0462: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0491: Expected O, but got Unknown
		MethodInvoker val = (MethodInvoker)delegate
		{
			((TextBoxBase)pm_form.status_textBox1).AppendText("Fetching Usernames who like/comment any listing\r\n");
		};
		((Control)pm_form).Invoke((Delegate)(object)val);
		HtmlDocument htmlDocument = new HtmlDocument();
		int num = int.Parse(follow_required);
		List<string> username_leads = new List<string>();
		MethodInvoker val2 = default(MethodInvoker);
		MethodInvoker val5 = default(MethodInvoker);
		foreach (string listing in listings)
		{
			if (wb.Request_poshmark_com(out var response, listing, 1, "", ck))
			{
				string text = wb.ReadResponse(response);
				check_cpatcha(text, "share", ref ck, ref token);
				htmlDocument.LoadHtml(text);
				HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='liker-images']");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						try
						{
							username_leads.Add(item.Attributes["href"].Value);
						}
						catch
						{
							username_leads.Add(Regex.Match(item.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value);
						}
					}
				}
				else
				{
					htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@id='itemsCount']");
					if (htmlNodeCollection != null)
					{
						foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)htmlNodeCollection)
						{
							try
							{
								username_leads.Add(item2.Attributes["href"].Value);
							}
							catch
							{
								username_leads.Add(Regex.Match(item2.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value);
							}
						}
					}
				}
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//div[@class='comment']/a");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item3 in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						try
						{
							username_leads.Add(item3.Attributes["href"].Value);
						}
						catch
						{
							username_leads.Add(Regex.Match(item3.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value);
						}
					}
				}
				else
				{
					htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='comment-item__container']/a");
					if (htmlNodeCollection != null)
					{
						foreach (HtmlNode item4 in (IEnumerable<HtmlNode>)htmlNodeCollection)
						{
							try
							{
								username_leads.Add(item4.Attributes["href"].Value);
							}
							catch
							{
								username_leads.Add(Regex.Match(item4.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value);
							}
						}
					}
				}
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//a[@class='creator']");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item5 in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						try
						{
							username_leads.Add(item5.Attributes["href"].Value);
						}
						catch
						{
							username_leads.Add(Regex.Match(item5.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value);
						}
					}
				}
				else
				{
					htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='header__username']/a");
					if (htmlNodeCollection != null)
					{
						foreach (HtmlNode item6 in (IEnumerable<HtmlNode>)htmlNodeCollection)
						{
							try
							{
								username_leads.Add(item6.Attributes["href"].Value);
							}
							catch
							{
								username_leads.Add(Regex.Match(item6.OuterHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value);
							}
						}
					}
				}
				username_leads = username_leads.Distinct().ToList();
				MethodInvoker obj7 = val2;
				if (obj7 == null)
				{
					MethodInvoker val3 = delegate
					{
						((TextBoxBase)pm_form.Log_textBox1).AppendText(string.Join("\r\n", username_leads.ToArray()) + "\r\n");
					};
					MethodInvoker val4 = val3;
					val2 = val3;
					obj7 = val4;
				}
				val = obj7;
				((Control)pm_form).Invoke((Delegate)(object)val);
				MethodInvoker obj8 = val5;
				if (obj8 == null)
				{
					MethodInvoker val6 = delegate
					{
						((TextBoxBase)pm_form.status_textBox1).AppendText("Total Profiles Found " + username_leads.Count + "\r\n");
					};
					MethodInvoker val4 = val6;
					val5 = val6;
					obj8 = val4;
				}
				val = obj8;
				((Control)pm_form).Invoke((Delegate)(object)val);
				Thread.Sleep(1500);
			}
			if (username_leads.Count > num)
			{
				break;
			}
		}
		return username_leads;
	}

	public bool like_comment_these_leads(string listing_link, string comment, bool comment_or_not, ref string token, ref CookieContainer ck, ref string status)
	{
		new HtmlDocument();
		if (wb.Request_poshmark_com_comment_like(out var response, listing_link, token, 1, comment, comment_or_not, ck))
		{
			string text = wb.ReadResponse(response);
			check_cpatcha(text, "follow", ref ck, ref token);
			if (text == "")
			{
				return false;
			}
			if (text.Contains("{\"success\":true"))
			{
				return true;
			}
			status = text;
			return false;
		}
		return false;
	}

	public bool follow_these_leads(string closet_name, ref string token, ref CookieContainer ck, ref string status, string follow_unfollow, string uid)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		bool follow_unfollow2 = false;
		if (follow_unfollow == "true")
		{
			follow_unfollow2 = true;
		}
		new HtmlDocument();
		new HtmlDocument();
		string text = Regex.Split(closet_name, "------")[1];
		string url = "https://poshmark.com/vm-rest/users/" + text + "/followers/" + uid;
		if (wb.Request_to_website_follow(out var response, 1, url, token, ck, follow_unfollow2))
		{
			string text2 = wb.ReadResponse(response);
			check_cpatcha(text2, "follow", ref ck, ref token);
			JavaScriptSerializer val = new JavaScriptSerializer();
			dynamic val2 = val.Deserialize<object>(text2);
			try
			{
				string text3 = "";
				if (val2.Count == 1)
				{
					text3 = val2["req_id"].ToString();
					return true;
				}
				text3 = val2["error"]["errorType"].ToString();
				if (text3 == "SuspectedBotError")
				{
					status = "Captcha in Follow";
					return false;
				}
				status = text3;
				return false;
			}
			catch
			{
			}
		}
		return false;
	}

	public void check_cpatcha(string response_txt, string captcha_type, ref CookieContainer ck, ref string csrf_token)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		if (response_txt.Contains("SuspectedBotError"))
		{
			MethodInvoker val = (MethodInvoker)delegate
			{
				((TextBoxBase)pm_form.status_textBox1).AppendText("Captcha Found, Going to check Captcha\r\n");
			};
			((Control)pm_form).Invoke((Delegate)(object)val);
			captcha_fucked++;
			csrf_token = return_csrf_token(ck);
			string text = "";
			if (captcha_type == "follow")
			{
				text = "follow_person";
				if (response_txt.Contains("\"restricted_action\":\"unfollow_person\""))
				{
					text = "unfollow_person";
				}
			}
			else
			{
				text = "share_post";
			}
			if (Form1._2captcha_key != "")
			{
				string text2 = "";
				text2 = ((!(captcha_type == "follow")) ? "Go to poshmark share any listing and solve captcha" : "Go to poshmark follow any user and solve captcha");
				if (!solve_captcha_by_2captcha(csrf_token, ck, text))
				{
					string user_name = lg.check_who_is_logined(ck);
					val = (MethodInvoker)delegate
					{
						((TextBoxBase)pm_form.status_textBox1).AppendText("@ This profile is paused because of captcha at " + DateTime.Now.ToString() + "\r\n" + user_name);
					};
					((Control)pm_form).Invoke((Delegate)(object)val);
					show_captcha_alert(text2);
					Form1.t.Suspend();
					return;
				}
			}
			else
			{
				if (!solve_captcha_by_browser(captcha_type))
				{
					string txt = "";
					if (captcha_type == "follow")
					{
						txt = "Go to poshmark follow any user and solve captcha";
					}
					else
					{
						txt = "Go to poshmark, share any listing and solve captcha";
					}
					lg.check_who_is_logined(ck);
					((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
					{
						((TextBoxBase)pm_form.status_textBox1).AppendText("App Paused, Solve captcha and click continue\r\n" + txt + "\r\n");
					});
					show_captcha_alert(txt);
					Form1.t.Suspend();
					captcha_fucked = 0;
					return;
				}
				captcha_fucked = 0;
			}
			if (captcha_fucked <= 10)
			{
				return;
			}
			try
			{
				string user_name2 = lg.check_who_is_logined(ck);
				string txt2 = "";
				if (captcha_type == "follow")
				{
					txt2 = "Go to poshmark follow any user and solve captcha";
				}
				else
				{
					txt2 = "Go to poshmark share any listing and solve captcha";
				}
				val = (MethodInvoker)delegate
				{
					((TextBoxBase)pm_form.status_textBox1).AppendText("This profile is paused because of captcha at " + DateTime.Now.ToString() + "\r\n" + user_name2 + "\r\n" + txt2 + "\r\n");
				};
				((Control)pm_form).Invoke((Delegate)(object)val);
				show_captcha_alert(txt2);
				Form1.t.Suspend();
				return;
			}
			catch
			{
				return;
			}
		}
		if (response_txt.Contains("u're logged out, Please lo"))
		{
			if (((CheckBox)Form1.pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
			{
				Form1.eob.get_WebView().set_Url("https://poshmark.com/feed");
			}
			else
			{
				Form1.brower_webbrowser_2.Navigate("https://poshmark.com/feed");
			}
			Form1.cookie_Set();
			ck = Form1.ck;
			csrf_token = return_csrf_token(ck);
		}
		else
		{
			if (!(response_txt == " "))
			{
				return;
			}
			blocked_test++;
			if (((CheckBox)Form1.pro_configuration_class.Throttle_checkBox1).get_Checked())
			{
				lg.check_who_is_logined(ck);
				MethodInvoker val2 = (MethodInvoker)delegate
				{
					((TextBoxBase)pm_form.status_textBox1).AppendText("\r\nApp Paused at " + DateTime.Now.ToString() + "\r\nCheck " + captcha_type + " Tab\r\nPause Reason: Website blocks the sharing, throttle reached\r\n");
				};
				((Control)pm_form).Invoke((Delegate)(object)val2);
				try
				{
					Form1.t.Suspend();
				}
				catch
				{
				}
			}
			if (blocked_test >= 5)
			{
				MethodInvoker val3 = (MethodInvoker)delegate
				{
					((TextBoxBase)pm_form.status_textBox1).AppendText("\r\nIt seems your sharing is stopped by Poshmark, we will wait and try again after 10 minutes " + DateTime.Now.ToString() + "\r\nCheck " + captcha_type + " Tab\r\nPause Reason: Website blocks the sharing, throttle reached\r\n");
				};
				((Control)pm_form).Invoke((Delegate)(object)val3);
				Thread.Sleep(600000);
				blocked_test = 0;
			}
		}
	}

	public void show_captcha_alert(string header)
	{
		Captcha_Alert ca = new Captcha_Alert(header);
		if (!File.Exists(update_app.folder_path + "\\captcha.gif"))
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadFile("http://poshmarktools.com/support/mpt/DownloadableFiles/captcha.gif", update_app.folder_path + "\\captcha.gif");
		}
		ca.pictureBox1.set_ImageLocation(update_app.folder_path + "\\captcha.gif");
		ca.pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((Form)ca).ShowDialog();
		});
		thread.Start();
	}

	public string return_poshmarket(CookieContainer ck)
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		if (wb.Request_poshmark_com(out var response, "https://poshmark.com/feed", 1, "", ck))
		{
			string text = wb.ReadResponse(response);
			htmlDocument.LoadHtml(text.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@id='selected-experience']");
			if (htmlNodeCollection == null)
			{
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@class='dropdown__selector dropdown__selector--arrow d--b']");
			}
			if (htmlNodeCollection != null)
			{
				using IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator();
				if (enumerator.MoveNext())
				{
					HtmlNode current = enumerator.Current;
					return current.InnerText.TrimStart(new char[0]).TrimEnd(new char[0]);
				}
			}
		}
		return null;
	}

	private bool solve_captcha_by_browser(string captcha_type)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)pm_form.status_textBox1).AppendText("Trying Solving Simple Captcha \r\n");
		});
		return false;
	}

	public void take_Screenshot()
	{
	}

	private bool solve_captcha_by_2captcha(string csrf_token, CookieContainer ck, string restriction)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)pm_form.status_textBox1).AppendText("Solving Captcha by 2captcha Api\r\n");
		});
		C2CaptchaService c2CaptchaService = new C2CaptchaService(Form1._2captcha_key, Form1._2captcha_password);
		string text = c2CaptchaService.GetBalance().ToString();
		if (text == "0.0")
		{
			MessageBox.Show("captcha balence is 0");
			return false;
		}
		int i = 0;
		while (true)
		{
			if (i < 5)
			{
				((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)Form1.mainform.status_textBox1).AppendText("Captcha Attempt " + i + "\r\n");
				});
				string key = "6Lc6GRkTAAAAAK0RWM_CD7tUAGopvrq_JHRrwDbD";
				string text2 = "";
				text2 = ((!((CheckBox)Form1.pro_tools_class.follow_pro_tools_checkBox1).get_Checked()) ? "https://poshmark.ca" : "https://poshmark.com");
				string text3 = c2CaptchaService.SolveCaptcha(key, text2);
				if (text3 != null && wb.Request_poshmark_com_for_captcha_post(out var response, csrf_token, text3, ck, restriction))
				{
					string text4 = wb.ReadResponse(response);
					if (text4 == "{\"success\":true}")
					{
						break;
					}
				}
				Thread.Sleep(20000);
				i++;
				continue;
			}
			return false;
		}
		Form1.captcha_solved++;
		captcha_fucked = 0;
		MetroLabel captcha_solved_label = Form1.pro_configuration_class.captcha_solved_label;
		object obj = _003C_003Ec._003C_003E9__60_2;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.pro_configuration_class.captcha_solved_label).set_Text("Total Captchas Solved by api =" + Form1.captcha_solved);
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__60_2 = val;
		}
		((Control)captcha_solved_label).Invoke((Delegate)obj);
		return true;
	}

	public string return_csrf_token(CookieContainer ck)
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		if (wb.Request_poshmark_com(out var response, "https://poshmark.com/feed", 1, "", ck))
		{
			string text = wb.ReadResponse(response);
			htmlDocument.LoadHtml(text.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@id='csrftoken']");
			if (htmlNodeCollection == null)
			{
				htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//*[@name='csrf-token']");
			}
			if (htmlNodeCollection != null)
			{
				using IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator();
				if (enumerator.MoveNext())
				{
					HtmlNode current = enumerator.Current;
					return current.Attributes["content"].Value;
				}
			}
		}
		htmlDocument = new HtmlDocument();
		if (wb.Request_poshmark_com(out response, "https://poshmark.com/my-feed", 1, "", ck))
		{
			string text2 = wb.ReadResponse(response);
			htmlDocument.LoadHtml(text2.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//*[@id='csrftoken']");
			if (htmlNodeCollection2 == null)
			{
				htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//*[@name='csrf-token']");
			}
			if (htmlNodeCollection2 != null)
			{
				using IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>)htmlNodeCollection2).GetEnumerator();
				if (enumerator2.MoveNext())
				{
					HtmlNode current2 = enumerator2.Current;
					return current2.Attributes["content"].Value;
				}
			}
		}
		return null;
	}

	public string return_login_uid(CookieContainer ck)
	{
		string result = "";
		if (Form1.wb.Request_poshmark_com(out var response, "https://poshmark.com/feed", 1, "", Form1.ck))
		{
			HtmlDocument htmlDocument = new HtmlDocument();
			string text = Form1.wb.ReadResponse(response);
			htmlDocument.LoadHtml(text.Replace("\\", ""));
			HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//script");
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
			{
				string input = item.InnerText.TrimStart(new char[0]);
				string[] array = Regex.Split(input, ";");
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (!text2.Contains("\"uid\""))
					{
						if (text2.Contains("_user_id "))
						{
							result = text2.Replace("var _user_id = ", "").Replace("\"", "").TrimEnd(new char[0])
								.TrimStart(new char[0]);
							break;
						}
						continue;
					}
					string text3 = text2.Substring(text2.IndexOf("\"uid\":\"") + 7, text2.Length - (text2.IndexOf("\"uid\":\"") + 7));
					result = text3.Substring(0, text3.IndexOf("\",\""));
					break;
				}
			}
		}
		return result;
	}

	public bool share_this_feeds(Listing_info listing, bool party_share, ref string csrf_token, ref CookieContainer ck, ref string status)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		bool result = false;
		HttpWebResponse response;
		for (int i = 0; i < 2; i++)
		{
			if (wb.Request_poshmark_com_share_listing(out response, listing.listing_link, csrf_token, ck))
			{
				string text = wb.ReadResponse(response);
				check_cpatcha(text, "share", ref ck, ref csrf_token);
				if (check_share_success(text))
				{
					blocked_test = 0;
					result = true;
				}
				else
				{
					status = text;
				}
				if (!text.Contains("SuspectedBotError"))
				{
					break;
				}
			}
		}
		if (party_share && listing.party_link != null && wb.Request_poshmark_com_share_listing(out response, listing.party_link, csrf_token, ck))
		{
			string text2 = wb.ReadResponse(response);
			if (text2 == "{}")
			{
				((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((TextBoxBase)pm_form.status_textBox1).AppendText("----> Listing Shared on Party " + listing.listing_name.Replace("amp;", "").TrimStart(new char[0]).TrimEnd(new char[0]) + "\r\n");
				});
			}
			check_cpatcha(text2, "party", ref ck, ref csrf_token);
		}
		return result;
	}

	public bool check_share_success(string html)
	{
		if (html == "{}")
		{
			return true;
		}
		return false;
	}
}
