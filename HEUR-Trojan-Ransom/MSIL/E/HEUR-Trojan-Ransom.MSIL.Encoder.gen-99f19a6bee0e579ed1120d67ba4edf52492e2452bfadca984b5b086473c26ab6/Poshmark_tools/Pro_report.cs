using System;
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
using HtmlAgilityPack;
using MetroFramework;
using MetroFramework.Controls;
using Newtonsoft.Json;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class Pro_report : UserControl
{
	private struct user_comment_like_stats
	{
		public string closet_name;

		public string comment_count;

		public string like_count;

		public string shares;

		public string offers;

		public string counter_offers;

		public string decline_offers;
	}

	private struct listing_comment_like_stats
	{
		public string shares;

		public string comment_count;

		public string like_count;

		public string images;
	}

	private struct listing_offer_counterOffer_decline_stats
	{
		public string offer;

		public string counter_offer;

		public string decline;
	}

	private struct listing_over_all_stats
	{
		public listing_comment_like_stats listing_sub_stats;

		public listing_offer_counterOffer_decline_stats listing_sub_offers_stats;

		public string listing_link;
	}

	private IContainer components = null;

	public MetroTextBox day_report_textbox;

	private MetroLabel general_text;

	public MetroTextBox report_permission_textBox2;

	private MetroLabel label39;

	private MetroCheckBox self_closet_metroCheckBox1;

	public MetroTextBox report_closet_metroTextBox1;

	private MetroLabel metroLabel1;

	public Pro_report()
	{
		InitializeComponent();
	}

	public void generate_report(int page_st)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_0850: Expected O, but got Unknown
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected O, but got Unknown
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Expected O, but got Unknown
		//IL_1110: Expected O, but got Unknown
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Expected O, but got Unknown
		//IL_1187: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected O, but got Unknown
		//IL_1ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef3: Expected O, but got Unknown
		if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Reports"))
		{
			Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Reports");
		}
		string report = Directory.GetCurrentDirectory() + "\\Reports\\user_report" + DateTime.Now.ToString("dd_MM_yyyy__hh_mm_ss") + ".csv";
		MetroTextBox status_textBox = Form1.mainform.status_textBox1;
		object obj = _003C_003Ec._003C_003E9__5_0;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				Form1.mainform.status_textBox1.AppendText("Report Generation Started\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__5_0 = val;
		}
		((Control)status_textBox).Invoke((Delegate)obj);
		string text = Form1.lg.check_who_is_logined(Form1.ck);
		string token = Form1.ed.return_csrf_token(Form1.ck);
		string closet_name = "";
		if (text != null)
		{
			closet_name = text.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
		}
		else
		{
			MessageBox.Show("Eror101");
		}
		string shares_required = Form1.ed.get_logined_available_items(Form1.ck);
		if (((CheckBox)self_closet_metroCheckBox1).get_Checked())
		{
			((Control)report_closet_metroTextBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)report_closet_metroTextBox1).set_Text(closet_name);
			});
		}
		else
		{
			if (((Control)report_closet_metroTextBox1).get_Text() == "")
			{
				MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
				object obj2 = _003C_003Ec._003C_003E9__5_2;
				if (obj2 == null)
				{
					MethodInvoker val2 = delegate
					{
						Form1.mainform.status_textBox1.AppendText("Provide Closet name whose report you want\r\n");
					};
					obj2 = (object)val2;
					_003C_003Ec._003C_003E9__5_2 = val2;
				}
				((Control)status_textBox2).Invoke((Delegate)obj2);
				return;
			}
			((Control)report_closet_metroTextBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				closet_name = ((Control)report_closet_metroTextBox1).get_Text();
			});
			shares_required = "1000";
		}
		List<extract_data.Listing_info> Listing_list = new List<extract_data.Listing_info>();
		Listing_list = Form1.ed.extract_listings_from_closet(closet_name.TrimStart(new char[0]).TrimEnd(new char[0]), shares_required, "", ref token, ref Form1.ck, default(EditSchdParameters.SchdParametersStruct));
		HtmlDocument htmlDocument = new HtmlDocument();
		List<listing_over_all_stats> listing_all_stats = new List<listing_over_all_stats>();
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		string text2 = "";
		string text3 = "";
		string text4 = "";
		if (((CheckBox)self_closet_metroCheckBox1).get_Checked() && Form1.wb.Request_poshmark_com(out var response, "https://poshmark.com/users/self/closet_stats", 1, "", Form1.ck))
		{
			string html = Form1.wb.ReadResponse(response);
			htmlDocument.LoadHtml(html);
			try
			{
				HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//ul[@class='user-history']/li");
				if (htmlNodeCollection != null)
				{
					foreach (HtmlNode item8 in (IEnumerable<HtmlNode>)htmlNodeCollection)
					{
						if (item8.InnerText.Contains("Posher Since"))
						{
							text2 = item8.InnerText.Replace("&#47;", "/").Replace("Posher Since", "").Replace(",", "")
								.TrimStart(new char[0])
								.TrimEnd(new char[0]);
						}
						else if (item8.InnerText.Contains("Listings"))
						{
							text3 = item8.InnerText.Replace("&#47;", "/").Replace("Listings", "").Replace(",", "")
								.TrimStart(new char[0])
								.TrimEnd(new char[0]);
						}
						else if (item8.InnerText.Contains("Followers"))
						{
							text4 = item8.InnerText.Replace("&#47;", "/").Replace("Followers", "").Replace(",", "")
								.TrimStart(new char[0])
								.TrimEnd(new char[0]);
						}
					}
				}
			}
			catch
			{
			}
		}
		MetroTextBox status_textBox3 = Form1.mainform.status_textBox1;
		object obj4 = _003C_003Ec._003C_003E9__5_4;
		if (obj4 == null)
		{
			MethodInvoker val3 = delegate
			{
				Form1.mainform.status_textBox1.AppendText("Getting each listing details\r\n");
			};
			obj4 = (object)val3;
			_003C_003Ec._003C_003E9__5_4 = val3;
		}
		((Control)status_textBox3).Invoke((Delegate)obj4);
		MethodInvoker val4 = default(MethodInvoker);
		foreach (extract_data.Listing_info item9 in Listing_list)
		{
			string text5 = item9.listing_link.Substring(item9.listing_link.IndexOf("post_id=") + 8, item9.listing_link.Length - (item9.listing_link.IndexOf("post_id=") + 8));
			if (!Form1.wb.Request_poshmark_com(out response, "https://poshmark.com/listing/" + text5, 1, "", Form1.ck))
			{
				continue;
			}
			string html2 = Form1.wb.ReadResponse(response);
			htmlDocument.LoadHtml(html2);
			try
			{
				List<string> list3 = new List<string>();
				List<string> list4 = new List<string>();
				List<string> list5 = new List<string>();
				HtmlNodeCollection htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//div[@class='liker-images']/a");
				if (htmlNodeCollection2 != null)
				{
					foreach (HtmlNode item10 in (IEnumerable<HtmlNode>)htmlNodeCollection2)
					{
						string text6 = item10.Attributes["href"].Value.Replace("/closet/", "");
						list3.Add(text6 + "|UMAIR|" + text5);
					}
				}
				htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//div[@class='carousel slide vertical']//img");
				if (htmlNodeCollection2 != null)
				{
					foreach (HtmlNode item11 in (IEnumerable<HtmlNode>)htmlNodeCollection2)
					{
						string value = item11.Attributes["data-img-src"].Value;
						list5.Add(value + "|UMAIR|" + text5);
					}
				}
				else
				{
					htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//div[@class='carousel-inner']//img");
					if (htmlNodeCollection2 != null)
					{
						foreach (HtmlNode item12 in (IEnumerable<HtmlNode>)htmlNodeCollection2)
						{
							string value2 = item12.Attributes["data-img-src"].Value;
							list5.Add(value2 + "|UMAIR|" + text5);
						}
					}
				}
				htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//div[@class='comment-text']");
				if (htmlNodeCollection2 != null)
				{
					foreach (HtmlNode item13 in (IEnumerable<HtmlNode>)htmlNodeCollection2)
					{
						HtmlDocument htmlDocument2 = new HtmlDocument();
						htmlDocument2.LoadHtml(item13.InnerHtml);
						HtmlNodeCollection htmlNodeCollection3 = htmlDocument2.DocumentNode.SelectNodes("//div[@class='comment-info d-fl ai-bl']");
						if (htmlNodeCollection3 == null)
						{
							continue;
						}
						foreach (HtmlNode item14 in (IEnumerable<HtmlNode>)htmlNodeCollection3)
						{
							string value3 = Regex.Match(item13.InnerHtml, "<a.+?href=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
							value3 = value3.Replace("/closet/", "");
							list4.Add(value3 + "|UMAIR|" + text5);
							string text7 = HttpUtility.HtmlDecode(item13.InnerText.Replace(item14.InnerText, "").Replace("&nbsp", ""));
							text7 = text7.Replace(value3, "");
						}
					}
				}
				list5 = list5.Distinct().ToList();
				listing_over_all_stats item = default(listing_over_all_stats);
				item.listing_link = "https://poshmark.com/listing/" + text5;
				listing_comment_like_stats listing_sub_stats = default(listing_comment_like_stats);
				listing_sub_stats.comment_count = list4.Count.ToString();
				listing_sub_stats.images = list5.Count + "|UMAIR|" + item9.listing_name.Substring(0, item9.listing_name.IndexOf("$"));
				listing_sub_stats.like_count = list3.Count.ToString();
				item.listing_sub_stats = listing_sub_stats;
				listing_all_stats.Add(item);
				MetroTextBox status_textBox4 = Form1.mainform.status_textBox1;
				MethodInvoker obj5 = val4;
				if (obj5 == null)
				{
					MethodInvoker val5 = delegate
					{
						Form1.mainform.status_textBox1.AppendText("Total Listings fetched " + listing_all_stats.Count + " / " + Listing_list.Count + "\r\n");
					};
					MethodInvoker val6 = val5;
					val4 = val5;
					obj5 = val6;
				}
				((Control)status_textBox4).Invoke((Delegate)(object)obj5);
				list.AddRange(list3);
				list2.AddRange(list4);
			}
			catch
			{
			}
		}
		try
		{
			List<user_comment_like_stats> list6 = new List<user_comment_like_stats>();
			try
			{
				foreach (string item15 in list)
				{
					string[] array = Regex.Split(item15, "UMAIR");
					int num = -1;
					for (int i = 0; i < list6.Count; i++)
					{
						if (list6[i].closet_name == array[0].Replace("|", ""))
						{
							num = i;
							break;
						}
					}
					if (num == -1)
					{
						user_comment_like_stats item2 = default(user_comment_like_stats);
						item2.closet_name = array[0].Replace("|", "");
						item2.like_count = "1";
						list6.Add(item2);
					}
					else
					{
						user_comment_like_stats user_comment_like_stats = default(user_comment_like_stats);
						user_comment_like_stats = list6[num];
						user_comment_like_stats.like_count = (int.Parse(user_comment_like_stats.like_count) + 1).ToString();
						list6[num] = user_comment_like_stats;
					}
				}
			}
			catch
			{
			}
			try
			{
				foreach (string item16 in list2)
				{
					string[] array2 = Regex.Split(item16, "UMAIR");
					int num2 = -1;
					for (int j = 0; j < list6.Count; j++)
					{
						if (list6[j].closet_name == array2[0].Replace("|", ""))
						{
							num2 = j;
							break;
						}
					}
					if (num2 == -1)
					{
						user_comment_like_stats item3 = default(user_comment_like_stats);
						item3.closet_name = array2[0].Replace("|", "");
						item3.comment_count = "1";
						list6.Add(item3);
						continue;
					}
					try
					{
						user_comment_like_stats user_comment_like_stats2 = default(user_comment_like_stats);
						user_comment_like_stats2 = list6[num2];
						if (user_comment_like_stats2.comment_count == null)
						{
							user_comment_like_stats2.comment_count = "0";
						}
						user_comment_like_stats2.comment_count = (int.Parse(user_comment_like_stats2.comment_count) + 1).ToString();
						list6[num2] = user_comment_like_stats2;
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			List<string> list7 = new List<string>();
			List<string> list8 = new List<string>();
			List<string> list9 = new List<string>();
			List<string> list10 = new List<string>();
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			string text8 = "";
			string text9 = "https://poshmark.com/news";
			MetroTextBox status_textBox5 = Form1.mainform.status_textBox1;
			object obj10 = _003C_003Ec._003C_003E9__5_6;
			if (obj10 == null)
			{
				MethodInvoker val7 = delegate
				{
					Form1.mainform.status_textBox1.AppendText("Getting information of Each closet who shared, liked, commented or made an offer on listing\r\n");
				};
				obj10 = (object)val7;
				_003C_003Ec._003C_003E9__5_6 = val7;
			}
			((Control)status_textBox5).Invoke((Delegate)obj10);
			string text10 = "";
			if (Form1.wb.Request_poshmark_com(out response, "https://poshmark.com/feed", 1, "", Form1.ck))
			{
				HtmlDocument htmlDocument3 = new HtmlDocument();
				string text11 = Form1.wb.ReadResponse(response);
				htmlDocument3.LoadHtml(text11.Replace("\\", ""));
				HtmlNodeCollection htmlNodeCollection4 = htmlDocument3.DocumentNode.SelectNodes("//script");
				foreach (HtmlNode item17 in (IEnumerable<HtmlNode>)htmlNodeCollection4)
				{
					string input = item17.InnerText.TrimStart(new char[0]);
					string[] array3 = Regex.Split(input, ";");
					string[] array4 = array3;
					foreach (string text12 in array4)
					{
						if (!text12.Contains("\"uid\""))
						{
							if (text12.Contains("_user_id "))
							{
								text10 = text12.Replace("var _user_id = ", "").Replace("\"", "").TrimEnd(new char[0])
									.TrimStart(new char[0]);
								break;
							}
							continue;
						}
						string text13 = text12.Substring(text12.IndexOf("\"uid\":\"") + 7, text12.Length - (text12.IndexOf("\"uid\":\"") + 7));
						text10 = text13.Substring(0, text13.IndexOf("\",\""));
						break;
					}
				}
			}
			text8 = "";
			bool flag = false;
			MethodInvoker val8 = default(MethodInvoker);
			do
			{
				if (((CheckBox)self_closet_metroCheckBox1).get_Checked())
				{
					text9 = "https://poshmark.com/vm-rest/users/" + text10 + "/newsfeed/all?" + text8;
					if (Form1.wb.Request_poshmark_com_simple_request_feed(out response, text9, Form1.ck))
					{
						string text14 = Form1.wb.ReadResponse(response);
						extract_data.RootObject_new rootObject_new = JsonConvert.DeserializeObject<extract_data.RootObject_new>(text14.ToString());
						if (rootObject_new != null)
						{
							DateTime dateTime = DateTime.Now.AddDays(-10.0);
							foreach (extract_data.Datum datum in rootObject_new.data)
							{
								try
								{
									datum.content.data[0].news_item.created_at.ToString("dd-MM-yyyy");
									if (dateTime < datum.content.data[0].news_item.created_at)
									{
										if (datum.story_type == "PersonSharePost")
										{
											string username = datum.content.data[0].news_item.actor.data[0].username;
											list7.Add(username + "|UMAIR|" + datum.content.data[0].news_item.content.data[0].id);
										}
										else if (datum.story_type == "PersonFollowPerson")
										{
											_ = datum.content.data[0].news_item.actor.data[0].username;
											num3++;
										}
										else if (datum.story_type == "PersonLikePost")
										{
											_ = datum.content.data[0].news_item.actor.data[0].username;
											num4++;
										}
										else if (datum.story_type == "PersonPostCommentBundle")
										{
											_ = datum.content.data[0].news_item.actor.data[0].username;
											num5++;
										}
										else if (datum.story_type == "PersonOfferRejectOfferPost")
										{
											string username2 = datum.content.data[0].news_item.actor.data[0].username;
											list8.Add(username2 + "|UMAIR|" + datum.content.data[0].news_item.content.data[0].id);
										}
										else if (datum.story_type == "PersonOfferCounterOfferPost")
										{
											string username3 = datum.content.data[0].news_item.actor.data[0].username;
											list10.Add(username3 + "|UMAIR|" + datum.content.data[0].news_item.content.data[0].id);
										}
										else if (datum.story_type == "PersonOfferInitiateOfferPost")
										{
											string username4 = datum.content.data[0].news_item.actor.data[0].username;
											list9.Add(username4 + "|UMAIR|" + datum.content.data[0].news_item.content.data[0].id);
										}
										continue;
									}
									flag = true;
									break;
								}
								catch
								{
								}
							}
							text8 = "maxId=" + rootObject_new.more.next_max_id;
							if (flag)
							{
								break;
							}
						}
					}
					page_st++;
					if (page_st <= 50)
					{
					}
					Thread.Sleep(800);
					MetroTextBox status_textBox6 = Form1.mainform.status_textBox1;
					MethodInvoker obj12 = val8;
					if (obj12 == null)
					{
						MethodInvoker val9 = delegate
						{
							Form1.mainform.status_textBox1.AppendText("Getting Closets information from " + page_st + " page\r\n");
						};
						MethodInvoker val6 = val9;
						val8 = val9;
						obj12 = val6;
					}
					((Control)status_textBox6).Invoke((Delegate)(object)obj12);
					continue;
				}
				MetroTextBox status_textBox7 = Form1.mainform.status_textBox1;
				object obj13 = _003C_003Ec._003C_003E9__5_7;
				if (obj13 == null)
				{
					MethodInvoker val10 = delegate
					{
						Form1.mainform.status_textBox1.AppendText("Cannot Extract Offers and other information of others closets\r\n");
					};
					obj13 = (object)val10;
					_003C_003Ec._003C_003E9__5_7 = val10;
				}
				((Control)status_textBox7).Invoke((Delegate)obj13);
				break;
			}
			while (page_st <= 440);
			MetroTextBox status_textBox8 = Form1.mainform.status_textBox1;
			object obj14 = _003C_003Ec._003C_003E9__5_9;
			if (obj14 == null)
			{
				MethodInvoker val11 = delegate
				{
					Form1.mainform.status_textBox1.AppendText("Compiling Report\r\n");
				};
				obj14 = (object)val11;
				_003C_003Ec._003C_003E9__5_9 = val11;
			}
			((Control)status_textBox8).Invoke((Delegate)obj14);
			try
			{
				foreach (string item18 in list7)
				{
					string[] array5 = Regex.Split(item18, "UMAIR");
					int num6 = -1;
					for (int l = 0; l < listing_all_stats.Count; l++)
					{
						if (listing_all_stats[l].listing_link.Contains(array5[1].Replace("|", "")))
						{
							num6 = l;
							break;
						}
					}
					if (num6 == -1)
					{
						listing_over_all_stats item4 = default(listing_over_all_stats);
						item4.listing_sub_offers_stats = default(listing_offer_counterOffer_decline_stats);
						item4.listing_sub_stats.shares = "1";
						item4.listing_link = "https://poshmark.com/listing/" + array5[1].Replace("|", "");
						listing_all_stats.Add(item4);
						continue;
					}
					try
					{
						listing_over_all_stats value4 = listing_all_stats[num6];
						if (value4.listing_sub_stats.shares == null)
						{
							value4.listing_sub_stats.shares = "0";
						}
						value4.listing_sub_stats.shares = (int.Parse(value4.listing_sub_stats.shares) + 1).ToString();
						listing_all_stats[num6] = value4;
					}
					catch
					{
					}
				}
				foreach (string item19 in list8)
				{
					try
					{
						string[] array6 = Regex.Split(item19, "UMAIR");
						int num7 = -1;
						for (int m = 0; m < listing_all_stats.Count; m++)
						{
							if (listing_all_stats[m].listing_link.Contains(array6[1].Replace("|", "")))
							{
								num7 = m;
								break;
							}
						}
						if (num7 == -1)
						{
							listing_over_all_stats item5 = default(listing_over_all_stats);
							item5.listing_sub_offers_stats = default(listing_offer_counterOffer_decline_stats);
							item5.listing_sub_offers_stats.decline = "1";
							item5.listing_link = "https://poshmark.com/listing/" + array6[1].Replace("|", "");
							listing_all_stats.Add(item5);
							continue;
						}
						try
						{
							listing_over_all_stats value5 = listing_all_stats[num7];
							if (value5.listing_sub_offers_stats.decline == null)
							{
								value5.listing_sub_offers_stats.decline = "0";
							}
							value5.listing_sub_offers_stats.decline = (int.Parse(value5.listing_sub_offers_stats.decline) + 1).ToString();
							listing_all_stats[num7] = value5;
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
				foreach (string item20 in list10)
				{
					try
					{
						string[] array7 = Regex.Split(item20, "UMAIR");
						int num8 = -1;
						for (int n = 0; n < listing_all_stats.Count; n++)
						{
							if (listing_all_stats[n].listing_link.Contains(array7[1].Replace("|", "")))
							{
								num8 = n;
								break;
							}
						}
						if (num8 == -1)
						{
							listing_over_all_stats item6 = default(listing_over_all_stats);
							item6.listing_sub_offers_stats = default(listing_offer_counterOffer_decline_stats);
							item6.listing_sub_offers_stats.counter_offer = "1";
							item6.listing_link = "https://poshmark.com/listing/" + array7[1].Replace("|", "");
							listing_all_stats.Add(item6);
							continue;
						}
						try
						{
							listing_over_all_stats value6 = listing_all_stats[num8];
							if (value6.listing_sub_offers_stats.counter_offer == null)
							{
								value6.listing_sub_offers_stats.counter_offer = "0";
							}
							value6.listing_sub_offers_stats.counter_offer = (int.Parse(value6.listing_sub_offers_stats.counter_offer) + 1).ToString();
							listing_all_stats[num8] = value6;
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
				foreach (string item21 in list9)
				{
					try
					{
						string[] array8 = Regex.Split(item21, "UMAIR");
						int num9 = -1;
						for (int num10 = 0; num10 < listing_all_stats.Count; num10++)
						{
							if (listing_all_stats[num10].listing_link.Contains(array8[1].Replace("|", "")))
							{
								num9 = num10;
								break;
							}
						}
						if (num9 == -1)
						{
							listing_over_all_stats item7 = default(listing_over_all_stats);
							item7.listing_sub_offers_stats = default(listing_offer_counterOffer_decline_stats);
							item7.listing_sub_offers_stats.offer = "1";
							item7.listing_link = "https://poshmark.com/listing/" + array8[1].Replace("|", "");
							listing_all_stats.Add(item7);
							continue;
						}
						try
						{
							listing_over_all_stats value7 = listing_all_stats[num9];
							if (value7.listing_sub_offers_stats.offer == null)
							{
								value7.listing_sub_offers_stats.offer = "0";
							}
							value7.listing_sub_offers_stats.offer = (int.Parse(value7.listing_sub_offers_stats.offer) + 1).ToString();
							listing_all_stats[num9] = value7;
						}
						catch
						{
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			File.AppendAllText(report, "Closet Name," + closet_name + "\r\n");
			File.AppendAllText(report, "Poshmer Since," + text2 + "\r\n");
			File.AppendAllText(report, "Total Listings in Closet," + text3 + "\r\n");
			File.AppendAllText(report, "Total Followers," + text4 + "\r\n\r\n");
			File.AppendAllText(report, "Total Follows by Others in last " + ((Control)day_report_textbox).get_Text() + " Days," + num3 + "\r\n");
			File.AppendAllText(report, "Total likes by Others in last " + ((Control)day_report_textbox).get_Text() + " Days," + num4 + "\r\n");
			File.AppendAllText(report, "Total comments by Others in last " + ((Control)day_report_textbox).get_Text() + " Days," + num5 + "\r\n");
			File.AppendAllText(report, "Total shares by Others in last " + ((Control)day_report_textbox).get_Text() + " Days," + list7.Count + "\r\n");
			File.AppendAllText(report, "Total offers by Others in last " + ((Control)day_report_textbox).get_Text() + " Days," + list9.Count + "\r\n");
			File.AppendAllText(report, "Total counter offers by Others in last " + ((Control)day_report_textbox).get_Text() + " Days," + list10.Count + "\r\n");
			File.AppendAllText(report, "Total decline offers by Others in last " + ((Control)day_report_textbox).get_Text() + " Days," + list8.Count + "\r\n\r\n");
			File.AppendAllText(report, "Listing Link,Listing Title,Total images,likes by others,commented by others,shares by others,offers by others,counter offers by others,decline offers by others\r\n");
			foreach (listing_over_all_stats item22 in listing_all_stats)
			{
				try
				{
					string text15 = item22.listing_sub_stats.comment_count;
					string text16 = item22.listing_sub_stats.like_count;
					string text17 = item22.listing_sub_stats.shares;
					string text18 = item22.listing_sub_offers_stats.offer;
					string text19 = item22.listing_sub_offers_stats.decline;
					string text20 = item22.listing_sub_offers_stats.counter_offer;
					string text21 = "-";
					string text22 = "Product Sold";
					if (item22.listing_sub_stats.images != null)
					{
						string[] array9 = Regex.Split(item22.listing_sub_stats.images, "UMAIR");
						text21 = array9[0].Replace("|", "");
						text22 = array9[1].Replace("|", "");
					}
					if (text15 == null)
					{
						text15 = "0";
					}
					if (text16 == null)
					{
						text16 = "0";
					}
					if (text17 == null)
					{
						text17 = "0";
					}
					if (text18 == null)
					{
						text18 = "0";
					}
					if (text19 == null)
					{
						text19 = "0";
					}
					if (text20 == null)
					{
						text20 = "0";
					}
					if (text22 != null)
					{
					}
					if (text21 == null)
					{
						text21 = "0";
					}
					File.AppendAllText(report, item22.listing_link + "," + text22 + "," + text21 + "," + text16 + "," + text15 + "," + text17 + "," + text18 + "," + text20 + "," + text19 + "\r\n");
				}
				catch
				{
				}
			}
			try
			{
				for (int num11 = 0; num11 < list6.Count; num11++)
				{
					user_comment_like_stats value8 = list6[num11];
					int num12 = 0;
					int num13 = 0;
					int num14 = 0;
					int num15 = 0;
					foreach (string item23 in list9)
					{
						if (item23.Contains(value8.closet_name))
						{
							num12++;
						}
					}
					foreach (string item24 in list8)
					{
						if (item24.Contains(value8.closet_name))
						{
							num14++;
						}
					}
					foreach (string item25 in list10)
					{
						if (item25.Contains(value8.closet_name))
						{
							num15++;
						}
					}
					foreach (string item26 in list7)
					{
						if (item26.Contains(value8.closet_name))
						{
							num13++;
						}
					}
					value8.counter_offers = num15.ToString();
					value8.decline_offers = num14.ToString();
					value8.offers = num12.ToString();
					value8.shares = num13.ToString();
					list6[num11] = value8;
				}
			}
			catch
			{
			}
			File.AppendAllText(report, "\r\nCloset Name,Total Likes by this Closet in last " + ((Control)day_report_textbox).get_Text() + " Days,Total Comment by this closet in last " + ((Control)day_report_textbox).get_Text() + " Days,Total shares by this closet in last " + ((Control)day_report_textbox).get_Text() + " Days,Total offers by this closet in last " + ((Control)day_report_textbox).get_Text() + " Days,Total counter offers by this closet in last " + ((Control)day_report_textbox).get_Text() + " Days,Total decline offers by this closet in last " + ((Control)day_report_textbox).get_Text() + " Days,\r\n");
			try
			{
				foreach (user_comment_like_stats item27 in list6)
				{
					string text23 = item27.like_count;
					string text24 = item27.comment_count;
					if (text23 == null)
					{
						text23 = "0";
					}
					if (text24 == null)
					{
						text24 = "0";
					}
					File.AppendAllText(report, item27.closet_name + "," + text23 + "," + text24 + "," + item27.shares + "," + item27.offers + "," + item27.counter_offers + "," + item27.decline_offers + ",\r\n");
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		((Control)Form1.mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			Form1.mainform.status_textBox1.AppendText("Report Generation Finished\r\nYour Report Created at " + report + "\r\n");
		});
		Process.Start(report);
	}

	private void self_closet_metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)self_closet_metroCheckBox1).get_Checked())
		{
			((Control)report_closet_metroTextBox1).set_Text("");
			((Control)report_closet_metroTextBox1).set_Enabled(false);
		}
		else
		{
			((Control)report_closet_metroTextBox1).set_Enabled(true);
		}
	}

	private void metroLabel1_Click(object sender, EventArgs e)
	{
		Process.Start("http://poshmarktools.com/product/poshmark-closet-detailed-report-2/");
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pro_report));
		day_report_textbox = new MetroTextBox();
		general_text = new MetroLabel();
		report_permission_textBox2 = new MetroTextBox();
		label39 = new MetroLabel();
		self_closet_metroCheckBox1 = new MetroCheckBox();
		report_closet_metroTextBox1 = new MetroTextBox();
		metroLabel1 = new MetroLabel();
		((Control)this).SuspendLayout();
		((Control)day_report_textbox).set_Location(new Point(442, 272));
		((Control)day_report_textbox).set_Name("day_report_textbox");
		((Control)day_report_textbox).set_Size(new Size(75, 23));
		((Control)day_report_textbox).set_TabIndex(0);
		((Control)day_report_textbox).set_Text("10");
		((Control)day_report_textbox).set_Visible(false);
		((Control)general_text).set_AutoSize(true);
		((Control)general_text).set_Dock((DockStyle)5);
		((Control)general_text).set_Location(new Point(0, 0));
		((Control)general_text).set_Name("general_text");
		((Control)general_text).set_Size(new Size(519, 266));
		general_text.Style = MetroColorStyle.Brown;
		((Control)general_text).set_TabIndex(56);
		((Control)general_text).set_Text(componentResourceManager.GetString("general_text.Text"));
		general_text.UseStyleColors = true;
		((Control)report_permission_textBox2).set_Location(new Point(419, 228));
		((Control)report_permission_textBox2).set_Name("report_permission_textBox2");
		report_permission_textBox2.ReadOnly = true;
		((Control)report_permission_textBox2).set_Size(new Size(98, 23));
		report_permission_textBox2.Style = MetroColorStyle.Brown;
		((Control)report_permission_textBox2).set_TabIndex(69);
		((Control)report_permission_textBox2).set_Text("Not permitted");
		report_permission_textBox2.UseStyleColors = true;
		((Control)report_permission_textBox2).set_Visible(false);
		((Control)label39).set_AutoSize(true);
		((Control)label39).set_Location(new Point(287, 230));
		((Control)label39).set_Name("label39");
		((Control)label39).set_Size(new Size(125, 19));
		label39.Style = MetroColorStyle.Brown;
		((Control)label39).set_TabIndex(68);
		((Control)label39).set_Text("Status (Reports Left)");
		label39.UseStyleColors = true;
		((Control)label39).set_Visible(false);
		((Control)self_closet_metroCheckBox1).set_AutoSize(true);
		((CheckBox)self_closet_metroCheckBox1).set_Checked(true);
		((CheckBox)self_closet_metroCheckBox1).set_CheckState((CheckState)1);
		((Control)self_closet_metroCheckBox1).set_Location(new Point(3, 280));
		((Control)self_closet_metroCheckBox1).set_Name("self_closet_metroCheckBox1");
		((Control)self_closet_metroCheckBox1).set_Size(new Size(130, 15));
		((Control)self_closet_metroCheckBox1).set_TabIndex(70);
		((Control)self_closet_metroCheckBox1).set_Text("Report of Self Closet");
		((ButtonBase)self_closet_metroCheckBox1).set_UseVisualStyleBackColor(true);
		((CheckBox)self_closet_metroCheckBox1).add_CheckedChanged((EventHandler)self_closet_metroCheckBox1_CheckedChanged);
		((Control)report_closet_metroTextBox1).set_Enabled(false);
		((Control)report_closet_metroTextBox1).set_Location(new Point(135, 272));
		((Control)report_closet_metroTextBox1).set_Name("report_closet_metroTextBox1");
		((Control)report_closet_metroTextBox1).set_Size(new Size(98, 23));
		report_closet_metroTextBox1.Style = MetroColorStyle.Brown;
		((Control)report_closet_metroTextBox1).set_TabIndex(71);
		report_closet_metroTextBox1.UseStyleColors = true;
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_Cursor(Cursors.get_Hand());
		metroLabel1.FontWeight = MetroLabelWeight.Bold;
		((Control)metroLabel1).set_Location(new Point(383, 302));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(134, 19));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(72);
		((Control)metroLabel1).set_Text("Get Report License");
		metroLabel1.UseStyleColors = true;
		((Control)metroLabel1).set_Visible(false);
		((Control)metroLabel1).add_Click((EventHandler)metroLabel1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)report_closet_metroTextBox1);
		((Control)this).get_Controls().Add((Control)(object)self_closet_metroCheckBox1);
		((Control)this).get_Controls().Add((Control)(object)report_permission_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label39);
		((Control)this).get_Controls().Add((Control)(object)general_text);
		((Control)this).get_Controls().Add((Control)(object)day_report_textbox);
		((Control)this).set_Name("Pro_report");
		((Control)this).set_Size(new Size(572, 406));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
