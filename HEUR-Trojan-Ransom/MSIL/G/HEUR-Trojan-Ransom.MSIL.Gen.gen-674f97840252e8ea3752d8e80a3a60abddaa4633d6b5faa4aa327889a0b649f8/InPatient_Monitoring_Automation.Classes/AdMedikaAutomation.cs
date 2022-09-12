using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace InPatient_Monitoring_Automation.Classes;

internal class AdMedikaAutomation
{
	private string username;

	private string password;

	private string URL_File;

	private string SubOffCode_File;

	private IWebDriver m_driver;

	public Log AdMedikaPortalAutomation()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		Log log = new Log();
		OleDbConnection val = new OleDbConnection();
		try
		{
			string text = "";
			int num = 0;
			string[] separator = new string[1] { "_" };
			text = global_variable.user_def_path + "\\Master Policy.xlsx";
			SubOffCode_File = global_variable.user_def_path + "\\Sub_Office_Codes.xlsx";
			string text2 = Environment.CurrentDirectory.Trim();
			int num2 = 1;
			string path = global_variable.user_def_path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM");
			string text3 = global_variable.user_def_path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd");
			if (Directory.Exists(text3))
			{
				DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
				int num3 = 0;
				int num4 = 0;
				for (int i = 0; i < directories.Length; i++)
				{
					string[] array = directories[i].Name.Split(separator, StringSplitOptions.None);
					if (array.Length > 1)
					{
						num4 = Convert.ToInt32(array[^1].ToString().Trim()) + 1;
						if (num4 > num3)
						{
							num3 = num4;
						}
					}
					else
					{
						num3 = 1;
					}
				}
				Directory.Move(text3.ToString().Trim(), text3.ToString().Trim() + "_" + num3.ToString().Trim());
			}
			Directory.CreateDirectory(text3);
			if (File.Exists(SubOffCode_File))
			{
				File.SetAttributes(SubOffCode_File, FileAttributes.Normal);
			}
			File.Copy("Resources\\Sub_Office_Codes.xlsx", SubOffCode_File, overwrite: true);
			File.SetAttributes(SubOffCode_File, FileAttributes.Hidden);
			string[] array2 = new string[2];
			array2 = open_credential_excel("Admedika");
			if (array2[0] != null && array2[1] != null && array2[2] != null)
			{
				try
				{
					ChromeDriverService val2 = ChromeDriverService.CreateDefaultService(text2);
					((DriverService)val2).set_HideCommandPromptWindow(true);
					ChromeOptions val3 = new ChromeOptions();
					val3.AddUserProfilePreference("download.default_directory", (object)text3);
					val3.set_BinaryLocation(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Chromium\\Application\\chrome.exe");
					m_driver = (IWebDriver)new ChromeDriver(val2, val3, TimeSpan.FromSeconds(180.0));
					m_driver.set_Url(array2[2]);
					m_driver.Manage().get_Window().Maximize();
				}
				catch (Exception)
				{
					log.status = false;
					log.method = "AdMedikaAutomation=>AdMedikaAutomation=>AdMedikaPortalAutomation";
					log.exception = "Please check the Chrome driver and try again later ";
					return log;
				}
				m_driver.get_CurrentWindowHandle();
				try
				{
					MessageBox.Show("Please Login to Admedika Website and Click OK", "Login to Admedika Website", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
				}
				catch (Exception)
				{
					log.status = false;
					log.method = "AdMedikaAutomation=>AdMedikaAutomation=>AdMedikaPortalAutomation";
					log.exception = "Admedika Portal cannot be reached. Please try again later ";
					return log;
				}
				Thread.Sleep(2000);
				if (!isElementPresent(By.XPath("/html/body/div[4]/div[2]/form/div[2]/div/div[2]")) && !isElementPresent(By.XPath("//*[@id='LogIn']")))
				{
					WebDriverWait val4 = new WebDriverWait(m_driver, TimeSpan.FromSeconds(180.0));
					((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/ul/li[2]/a")));
					((ISearchContext)m_driver).FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/ul/li[2]/a")).Click();
					((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementExists(By.Id("cboDisplayRows")));
					Thread.Sleep(500);
					((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='OnlineAlert']/div[1]/div[1]/h3")));
					Thread.Sleep(1000);
					new SelectElement(((ISearchContext)m_driver).FindElement(By.Id("cboDisplayRows"))).SelectByText("Display 4000 Rows", false);
					Thread.Sleep(3000);
					((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementToBeClickable(By.Id("searchAlert")));
					((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.Id("searchAlert")));
					int num5 = int.Parse(((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='tbTransaction']/table/tbody/tr/td/font")).GetAttribute("innerHTML").ToString()
						.Split(new char[1] { ':' })[1].Trim());
					IWebElement val5 = ((ISearchContext)m_driver).FindElement(By.Id("searchAlert"));
					new Actions(m_driver).MoveToElement(val5).Click().Perform();
					Thread.Sleep(500);
					val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text + ";Extended Properties=Excel 12.0");
					((DbConnection)(object)val).Open();
					OleDbDataAdapter val6 = new OleDbDataAdapter("SELECT [POLIS NO],[SUB OFFICE],[NO] FROM [Master_Policy_List$] where [POLIS NO] IS NOT NULL", val);
					DataSet dataSet = new DataSet();
					((DataAdapter)val6).Fill(dataSet);
					string[] array3 = new string[dataSet.Tables[0].Rows.Count];
					string[] array4 = new string[dataSet.Tables[0].Rows.Count];
					string[] array5 = new string[dataSet.Tables[0].Rows.Count];
					int num6 = 0;
					for (num2 = 0; num2 <= dataSet.Tables[0].Rows.Count - 1; num2++)
					{
						array3[num6] = dataSet.Tables[0].Rows[num2].ItemArray[0]!.ToString()!.Trim();
						array4[num6] = dataSet.Tables[0].Rows[num2].ItemArray[1]!.ToString()!.Trim();
						array5[num6] = dataSet.Tables[0].Rows[num2].ItemArray[2]!.ToString()!.Trim();
						num6++;
					}
					Thread.Sleep(5000);
					int num7 = 0;
					for (int j = 0; j <= 10; j++)
					{
						num7 = int.Parse(((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='tbTransaction']/table/tbody/tr/td/font")).GetAttribute("innerHTML").ToString()
							.Split(new char[1] { ':' })[1].Trim());
						if (num7 != num5)
						{
							break;
						}
						Thread.Sleep(1000);
					}
					int num8 = 0;
					num2 = 1;
					while (true)
					{
						if (num2 <= num7)
						{
							string text4 = ((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='tbTransaction']/table/tbody/tr[" + num2 + "]/td[21]")).GetAttribute("innerHTML").ToString();
							string text5 = text4.Substring(text4.Length - 5);
							if (array3.Contains(text5))
							{
								num8 = num2 + 5;
								if (num8 > num7)
								{
									IWebElement val7 = ((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='OnlineAlert']/div[5]/div[1]/h3"));
									Actions val8 = new Actions(m_driver);
									val8.MoveToElement(val7);
									val8.Perform();
									Thread.Sleep(5000);
								}
								else
								{
									IWebElement val9 = ((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='tbTransaction']/table/tbody/tr[" + num8 + "]/td[6]/a"));
									Actions val10 = new Actions(m_driver);
									val10.MoveToElement(val9);
									val10.Perform();
									Thread.Sleep(5000);
								}
								((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='tbTransaction']/table/tbody/tr[" + num2 + "]/td[6]/a")).Click();
								((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementExists(By.LinkText("Claims Monitoring")));
								((ISearchContext)m_driver).FindElement(By.LinkText("Claims Monitoring")).Click();
								m_driver.SwitchTo().Window(m_driver.get_WindowHandles().Last());
								((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementExists(By.XPath("//*[@id='claimsinfo']/div/div/button")));
								string text6 = ((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='claimsinfo']/div/table[1]/tbody/tr[4]/td[6]")).get_Text().ToString();
								string text7 = ((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='claimsinfo']/div/table[1]/tbody/tr[5]/td[6]")).get_Text().ToString();
								string text8 = ((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='claimsinfo']/div/table[2]/tbody/tr[2]/td[2]")).get_Text().ToString();
								log = InsertPolCertNo(text5.Trim(), text6.Trim(), text7.Trim(), text8.Trim());
								if (!log.status)
								{
									return log;
								}
								((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='claimsinfo']/div/div/button")).Click();
								if (m_driver.get_WindowHandles().Count == 2)
								{
									((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='claimsinfo']/div/div/button")).Click();
								}
								m_driver.SwitchTo().Window(m_driver.get_WindowHandles()[2]);
								num++;
								log = Check_DownloadFile(text3, num, text8);
								if (!log.status)
								{
									break;
								}
								text6 = "";
								text7 = "";
								text8 = "";
								Thread.Sleep(2000);
								m_driver.Close();
								Thread.Sleep(2000);
								if (m_driver.get_WindowHandles().Count > 1)
								{
									m_driver.SwitchTo().Window(m_driver.get_WindowHandles()[1]);
									m_driver.Close();
								}
								m_driver.SwitchTo().Window(m_driver.get_WindowHandles()[0]);
								m_driver.SwitchTo().Window(m_driver.get_WindowHandles().First());
								num8 = 0;
							}
							num2++;
							continue;
						}
						((ISearchContext)m_driver).FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[3]/ul/li[2]/a[2]")).Click();
						((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementExists(By.Id("logout")));
						((ISearchContext)m_driver).FindElement(By.Id("logout")).Click();
						((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementExists(By.XPath("/html/body/div[7]/div[2]/form/div[2]/div/div[2]")));
						IWebElement val11 = ((ISearchContext)m_driver).FindElement(By.Name("jqi_state0_buttonYes"));
						Actions val12 = new Actions(m_driver);
						val12.MoveToElement(val11);
						val12.Perform();
						Thread.Sleep(2000);
						((ISearchContext)m_driver).FindElement(By.Name("jqi_state0_buttonYes")).Click();
						((DefaultWait<IWebDriver>)(object)val4).Until<IWebElement>(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/p")));
						log = Extract_Sub_Code(array3, array4, array5);
						if (!log.status)
						{
							return log;
						}
						log.status = true;
						log.method = "AdMedikaAutomation=>AdMedikaAutomation=>AdMedikaPortalAutomation";
						log.exception = "No issues";
						return log;
					}
					return log;
				}
				log.status = false;
				log.method = "AdMedikaAutomation=>AdMedikaAutomation=>AdMedikaPortalAutomation";
				log.exception = "The user credentials are incorrect/expired. Please verify and try again.";
				return log;
			}
			log.status = false;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>open_credential_excel";
			log.exception = "Credentials for AdMedika portal not found! Please update the Config file. ";
			return log;
		}
		catch (Exception ex3)
		{
			log.status = false;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>AdMedikaPortalAutomation";
			log.exception = "Error while fetching data from AdMedika portal: " + ex3.Message.ToString();
			return log;
		}
		finally
		{
			if (((DbConnection)(object)val).State == ConnectionState.Open)
			{
				((DbConnection)(object)val).Close();
				((Component)(object)val).Dispose();
			}
			if (m_driver != null)
			{
				m_driver.Close();
				((IDisposable)m_driver).Dispose();
				m_driver = null;
			}
		}
	}

	private Log InsertPolCertNo(string policy_No, string policy_No_1, string Cert_No, string ClaimID)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		Log log = new Log();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + SubOffCode_File + ";Extended Properties=Excel 12.0");
		try
		{
			((DbConnection)(object)val).Open();
			((DbCommand)new OleDbCommand("Insert into [Sheet1$] (Policy_No,Policy_No_1,Cert_No,Claim_ID) values('" + policy_No + "','" + policy_No_1 + "','" + Cert_No + "','" + ClaimID + "')", val)).ExecuteNonQuery();
			log.status = true;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>InsertPolCertNo";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>InsertPolCertNo";
			log.exception = "Error while fetching data from AdMedika portal: " + ex.Message.ToString();
			return log;
		}
		finally
		{
			if (((DbConnection)(object)val).State == ConnectionState.Open)
			{
				((DbConnection)(object)val).Close();
				((Component)(object)val).Dispose();
			}
		}
	}

	public Log Check_DownloadFile(string filePath, int filecount, string claim_ID_scr)
	{
		Log log = new Log();
		try
		{
			for (int i = 0; i < 100; i++)
			{
				if (m_driver.get_WindowHandles().Count == 2)
				{
					((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='claimsinfo']/div/div/button")).Click();
				}
				if (Directory.GetFiles(filePath, "*_" + claim_ID_scr + ".xls").Count() == 1)
				{
					break;
				}
				Thread.Sleep(1000);
			}
			log.status = true;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>Check_DownloadFile";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>Check_DownloadFile";
			log.exception = "Error while checking for downloaded files : " + ex.Message.ToString();
			return log;
		}
	}

	public string[] open_credential_excel(string key)
	{
		string[] array = new string[3];
		string filename = Environment.CurrentDirectory + "\\Resources\\Config.xlsx";
		Application application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		Workbook workbook = application.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, "Admedika", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		try
		{
			Worksheet obj = workbook.Worksheets[1] as Worksheet;
			Microsoft.Office.Interop.Excel.Range range = ((_Worksheet)obj).get_Range((object)"A1", (object)"z1000").Find(key, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSearchDirection.xlNext, Type.Missing, Type.Missing, Type.Missing).get_Offset((object)0, (object)1);
			Microsoft.Office.Interop.Excel.Range range2 = ((_Worksheet)obj).get_Range((object)"A1", (object)"z1000").Find(key, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSearchDirection.xlNext, Type.Missing, Type.Missing, Type.Missing).get_Offset((object)0, (object)2);
			Microsoft.Office.Interop.Excel.Range range3 = ((_Worksheet)obj).get_Range((object)"A1", (object)"z1000").Find(key, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSearchDirection.xlNext, Type.Missing, Type.Missing, Type.Missing).get_Offset((object)0, (object)3);
			object obj2 = range.get_Value(Type.Missing);
			object obj3 = range2.get_Value(Type.Missing);
			object obj4 = range3.get_Value(Type.Missing);
			username = obj2.ToString()!.Trim();
			password = obj3.ToString()!.Trim();
			URL_File = obj4.ToString()!.Trim();
			array[0] = username;
			array[1] = password;
			array[2] = URL_File;
			((_Worksheet)(workbook.Worksheets[2] as Worksheet)).get_Range((object)"A1", (object)"Z1000").Find("Email_Status", Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSearchDirection.xlNext, Type.Missing, Type.Missing, Type.Missing).get_Offset((object)0, (object)1)
				.get_Value(Type.Missing);
			return array;
		}
		catch (Exception)
		{
			return array;
		}
		finally
		{
			workbook.Close(0, Type.Missing, Type.Missing);
			Marshal.ReleaseComObject(workbook);
			application.Quit();
		}
	}

	public Log check_path_email_flag(string path)
	{
		Log log = new Log();
		try
		{
			Application obj = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
			Workbook workbook = obj.Workbooks.Open(path, Missing.Value, Missing.Value, Missing.Value, "Admedika", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			Worksheet obj2 = workbook.Worksheets[2] as Worksheet;
			Microsoft.Office.Interop.Excel.Range range = ((_Worksheet)obj2).get_Range((object)"A1", (object)"Z1000").Find("Email_Status", Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSearchDirection.xlNext, Type.Missing, Type.Missing, Type.Missing).get_Offset((object)0, (object)1);
			Microsoft.Office.Interop.Excel.Range range2 = ((_Worksheet)obj2).get_Range((object)"A1", (object)"Z1000").Find("Folder_Path", Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSearchDirection.xlNext, Type.Missing, Type.Missing, Type.Missing).get_Offset((object)0, (object)1);
			object obj3 = range.get_Value(Type.Missing);
			object obj4 = range2.get_Value(Type.Missing);
			global_variable.email_flag = obj3.ToString();
			if (obj4 != null)
			{
				global_variable.user_def_path = obj4.ToString();
			}
			else if (obj4 == null)
			{
				global_variable.user_def_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Inpatient Monitoring Report";
			}
			log.status = true;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>check_path_email_flag";
			log.exception = "No issues";
			workbook.Close(0, Type.Missing, Type.Missing);
			Marshal.ReleaseComObject(workbook);
			obj.Quit();
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>check_path_email_flag";
			log.exception = "Error while checking for downloaded files : " + ex.Message.ToString();
			return log;
		}
	}

	public Log Extract_Sub_Code(string[] Policy_M_Values, string[] Sub_Code_M_Values, string[] ID_M_Values)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		string[] array = new string[3];
		OleDbConnection val = new OleDbConnection();
		Log log = new Log();
		log.status = true;
		try
		{
			array = open_credential_excel("Intranet_Portal");
			if (array[0] != null && array[1] != null && array[2] != null)
			{
				Thread.Sleep(2000);
				m_driver.set_Url(array[2]);
				try
				{
					((ISearchContext)m_driver).FindElement(By.Id("txtUser")).SendKeys(array[0]);
					((ISearchContext)m_driver).FindElement(By.Id("txtPassword")).SendKeys(array[1]);
					((ISearchContext)m_driver).FindElement(By.Id("cmdEnter")).Click();
					Thread.Sleep(2000);
				}
				catch (Exception)
				{
					log.status = false;
					log.method = "AdMedikaAutomation=>AdMedikaAutomation=>Extract_Sub_Code";
					log.exception = "The Intranet Portal cannot be reached. Please try again later ";
					return log;
				}
				if (isElementPresent(By.XPath("//*[@id='lblMessage']")))
				{
					log.status = false;
					log.method = "AdMedikaAutomation=>AdMedikaAutomation=>AdMedikaPortalAutomation";
					log.exception = "The user credentials for Intranet Portal are incorrect/expired. Please verify and try again.";
					return log;
				}
				if (isElementPresent(By.XPath("//*[@id='Menu1']/span[1]/a")))
				{
					((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='Menu1']/span[1]/a")).Click();
				}
				((DefaultWait<IWebDriver>)new WebDriverWait(m_driver, TimeSpan.FromSeconds(20.0))).Until<IWebElement>(ExpectedConditions.ElementExists(By.XPath("//*[@id='Menu1n0']/td/table")));
				IWebElement val2 = ((ISearchContext)m_driver).FindElement(By.LinkText("EBD"));
				Actions val3 = new Actions(m_driver);
				val3.MoveToElement(val2).Perform();
				IWebElement val4 = ((ISearchContext)m_driver).FindElement(By.LinkText("CALL CENTRE SERVICE"));
				val3.MoveToElement(val4).Perform();
				((ISearchContext)m_driver).FindElement(By.LinkText("HOME SCREEN")).Click();
				Thread.Sleep(4000);
				val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + SubOffCode_File + ";Extended Properties=Excel 12.0");
				((DbConnection)(object)val).Open();
				OleDbDataAdapter val5 = new OleDbDataAdapter("SELECT [Policy_No],[Policy_No_1],[Cert_No] FROM [Sheet1$]", val);
				DataSet dataSet = new DataSet();
				((DataAdapter)val5).Fill(dataSet);
				string[] array2 = new string[dataSet.Tables[0].Rows.Count];
				_ = new string[dataSet.Tables[0].Rows.Count];
				int num = 0;
				int num2 = 0;
				string text = "";
				for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
				{
					string text2 = dataSet.Tables[0].Rows[i].ItemArray[0]!.ToString();
					string text3 = dataSet.Tables[0].Rows[i].ItemArray[1]!.ToString();
					string text4 = dataSet.Tables[0].Rows[i].ItemArray[2]!.ToString();
					string text5 = text4;
					if (text4.Contains("-"))
					{
						text5 = text4.Split(new char[1] { '-' })[0];
					}
					array2[num] = text2;
					if (text2 != "")
					{
						((ISearchContext)m_driver).FindElement(By.Id("txtPolNo")).Clear();
						((ISearchContext)m_driver).FindElement(By.Id("txtPolNo")).SendKeys(text3);
						((ISearchContext)m_driver).FindElement(By.Id("txtCertNo")).Clear();
						((ISearchContext)m_driver).FindElement(By.Id("txtCertNo")).SendKeys(text5);
						((ISearchContext)m_driver).FindElement(By.Id("btnMember")).Click();
						string text6 = ((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='ddlSubOff']")).get_Text().ToString();
						text6 = text6.Split(new char[1] { '-' })[0].ToString().Trim();
						for (num2 = 0; num2 <= Policy_M_Values.Count(); num2++)
						{
							if (Policy_M_Values[num2] == text2 && (Sub_Code_M_Values[num2] == text6 || Sub_Code_M_Values[num2] == ""))
							{
								text = ID_M_Values[num2].ToString();
								break;
							}
						}
						((DbCommand)new OleDbCommand("Update [Sheet1$] Set Sub_Office_Code = '" + text6 + "', ID = '" + text + "' Where Policy_No = '" + text2 + "' and Cert_No = '" + text4 + "'", val)).ExecuteNonQuery();
					}
					text2 = "";
					text = "";
					num++;
				}
				Thread.Sleep(4000);
				((ISearchContext)m_driver).FindElement(By.XPath("//*[@id='frmMember']/div[9]/div[2]/div[2]/div[2]/a/span/span")).Click();
				log.status = true;
				log.method = "AdMedikaAutomation=>AdMedikaAutomation=>Extract_Sub_Code";
				log.exception = "No issues";
				return log;
			}
			log.status = false;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>open_credential_excel";
			log.exception = "Credentials for Intranet portal not found! Please update the Config file. ";
			return log;
		}
		catch (Exception ex2)
		{
			log.status = false;
			log.method = "AdMedikaAutomation=>AdMedikaAutomation=>Extract_Sub_Code";
			log.exception = "Failed to extract sub code: " + ex2.Message.ToString().Trim();
			return log;
		}
		finally
		{
			if (((DbConnection)(object)val).State == ConnectionState.Open)
			{
				((DbConnection)(object)val).Close();
				((Component)(object)val).Dispose();
			}
		}
	}

	public bool isElementPresent(By Locator)
	{
		try
		{
			((ISearchContext)m_driver).FindElement(Locator);
			return true;
		}
		catch
		{
			return false;
		}
	}
}
