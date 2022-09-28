using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ModuleNameSpace;

internal class MainApp : MainAppInterface
{
	private bool shouldExit;

	private int exitCode;

	public bool ShouldExit
	{
		get
		{
			return shouldExit;
		}
		set
		{
			shouldExit = value;
		}
	}

	public int ExitCode
	{
		get
		{
			return exitCode;
		}
		set
		{
			exitCode = value;
		}
	}

	[STAThread]
	private static int Main(string[] args)
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Invalid comparison between Unknown and I4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		MainApp mainApp = new MainApp();
		bool flag = false;
		string text = string.Empty;
		MainModuleUI ui = new MainModuleUI();
		MainModule mainModule = new MainModule(mainApp, ui);
		ManualResetEvent mre = new ManualResetEvent(initialState: false);
		AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
		try
		{
			Runspace val = RunspaceFactory.CreateRunspace((PSHost)(object)mainModule);
			try
			{
				val.set_ApartmentState(ApartmentState.STA);
				val.Open();
				PowerShell val2 = PowerShell.Create();
				try
				{
					val2.set_Runspace(val);
					val2.get_Streams().get_Error().add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteErrorLine(((object)((PSDataCollection<ErrorRecord>)sender).get_Item(e.get_Index())).ToString());
					});
					PSDataCollection<string> val3 = new PSDataCollection<string>();
					if (Console_Info.IsInputRedirected())
					{
						string text2 = "";
						while ((text2 = Console.ReadLine()) != null)
						{
							val3.Add(text2);
						}
					}
					val3.Complete();
					PSDataCollection<PSObject> colOutput = new PSDataCollection<PSObject>();
					colOutput.add_DataAdded((EventHandler<DataAddedEventArgs>)delegate(object sender, DataAddedEventArgs e)
					{
						((PSHostUserInterface)ui).WriteLine(((object)colOutput.get_Item(e.get_Index())).ToString());
					});
					int num = 0;
					int num2 = 0;
					foreach (string text3 in args)
					{
						if (string.Compare(text3, "-whatt".Replace("hat", "ai"), ignoreCase: true) == 0)
						{
							flag = true;
						}
						else if (text3.StartsWith("-extdummt".Replace("dumm", "rac"), StringComparison.InvariantCultureIgnoreCase))
						{
							string[] array = text3.Split(new string[1] { ":" }, 2, StringSplitOptions.RemoveEmptyEntries);
							if (array.Length != 2)
							{
								MessageBox.Show("If you spzzcify thzz -zzxtract option you nzzed to add a filzz for zzxtraction in this way\r\n   -zzxtract:\"<filzznamzz>\"".Replace("zz", "e"), AppDomain.CurrentDomain.FriendlyName, (MessageBoxButtons)0, (MessageBoxIcon)16);
								return 1;
							}
							text = array[1].Trim(new char[1] { '"' });
						}
						else
						{
							if (string.Compare(text3, "-end", ignoreCase: true) == 0)
							{
								num = num2 + 1;
								break;
							}
							if (string.Compare(text3, "-debug", ignoreCase: true) == 0)
							{
								Debugger.Launch();
								break;
							}
						}
						num2++;
					}
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String("IyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQojIChjKSBEb2RvIENDDQojIEdlbmVyYXRlZCBCeTogQWxla3NleSBNZWR2ZWRvdnNraXkNCiMgRWRpdGVkIGJ5IG1heC5jZmcNCiMgMjAyMQ0KIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQokdmVyc2lvbiA9ICIzLjkuMCINCg0KJEFycmF5ID0gQCgNCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0JIg0YLQtdGB0YLQvtCy0YvQuSDQutCw0L3QsNC7IjsgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gInRlc3QifSAjIHRlc3RtZXNzYWdlc2thY2sgLyB0ZXN0DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gJG51bGw7ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAkbnVsbH0NCiAgICAjW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCh0LXQsdC1INCyINGC0LXRgdGC0L7QstGD0Y4g0LPRgNGD0L/Qv9GDIjsgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIlRlc3QgZ3JvdXAifSAjINC00LvRjyDRgtC10YHRgtC+0LINCiAgICAjW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gJG51bGw7ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAkbnVsbH0gICAgICAgICMg0LTQu9GPINGC0LXRgdGC0L7Qsg0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQntC/0LXRgNCw0YLQvtGA0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJPcGVyYXRvciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCh0L/QtdGG0LjQsNC70LjRgdGC0LDQvCDQutC70LjQtdC90YLRgdC60L7QuSDQu9C40L3QuNC4IjsgICAgICAgICAiV2hhdElkbyIgPSAiU3BlY2lhbGlzdCJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCa0L7QvNGM0Y7QvdC40YLQuCDRgdC/0LXRhtC40LDQu9C40YHRgtCw0LwiOyAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiQ29tbXVuaXR5IHNwZWNpYWxpc3QifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQntC/0LXRgNCw0YLQvtGA0LDQvCDQv9C+0YfRgtGLIjsgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIk1haWwgb3BlcmF0b3IifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQmtC+0LzRjNGO0L3QuNGC0Lgg0LzQtdC90LXQtNC20LXRgNCw0LwiOyAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJDb21tdW5pdHktbWFuYWdlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCi0YDQtdC90LXRgNCw0LwgKNCR0LDQt9CwINC30L3QsNC90LjQuSDQuCDQvNC10YLRgNC40LrQuCkiOyAgICAgICJXaGF0SWRvIiA9ICJUcmFpbmVyIEJhc2UifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQotGA0LXQvdC10YDQsNC8ICjQndCw0LnQvCwg0L7QsdGD0YfQtdC90LjQtSDQuCDQsNC00LDQv9GC0LDRhtC40Y8pIjsgIldoYXRJZG8iID0gIlRyYWluZXIgVGVhY2gifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQotGA0LXQvdC10YDQsNC8ICjQotC10LrRgdGCKSI7ICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJUcmFpbmVyIFRleHQifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQkdC40LfQvdC10YEt0YLRgNC10L3QtdGA0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiQnVzaW5lc3MgVHJhaW5lciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gIkhSINGB0L/QtdGG0LjQsNC70LjRgdGC0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiSFIgU3BlY2lhbGlzdCBvZiBDb250YWN0IENlbnRlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gIkhSINC80LXQvdC10LTQttC10YDQsNC8IjsgICAgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIkhSIERvZG9DQyJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCc0LXQvdC10LTQttC10YDQsNC8INGB0LzQtdC90YsiOyAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiU2hpZnQgbWFuYWdlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCc0LXQvdC10LTQttC10YDQsNC8INC/0L4g0YDQtdC60LvQsNC80LDRhtC40Y/QvCI7ICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJDbGFpbXMgbWFuYWdlciJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gIlFBLdC80LXQvdC10LTQttC10YDQsNC8IjsgICAgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIlFBIn0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0KHQv9C10YbQuNCw0LvQuNGB0YLQsNC8INGH0LDRgi3Qv9C+0LTQtNC10YDQttC60LgiOyAgICAgICAgICAgICJXaGF0SWRvIiA9ICJDaGF0IFN1cHBvcnQifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQodC/0LXRhtC40LDQu9C40YHRgtCw0Lwg0J7QnNCfIjsgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIk1vYmlsZSBzdXBwb3J0In0NCikNCg0KZnVuY3Rpb24gR2VuZXJhdGVGb3JtIHsNCiAgICBBZGQtVHlwZSAtQXNzZW1ibHlOYW1lIFN5c3RlbS5XaW5kb3dzLkZvcm1zLCBTeXN0ZW0uRHJhd2luZw0KICAgIFtTeXN0ZW0uV2luZG93cy5Gb3Jtcy5BcHBsaWNhdGlvbl06OkVuYWJsZVZpc3VhbFN0eWxlcygpDQoNCiAgICAjIEdsb2JhbCBJbmRlbnQgKGhhcmQpDQogICAgJHogID0gMTAgIyBSaWNoVGV4dEJveF8xLCBMYWJlbF8xLCBMYWJlbF8yLCBCdXR0b25fMSwgTGFiZWxfMywgUHJvZ3Jlc3NCYXJfMSwgQ2hlY2tCb3hlcw0KICAgICMgU2l6ZSAoaGFyZCkNCiAgICAkdyAgPSA3NjAgIyBGb3JtXzENCiAgICAkdzIgPSAyNDkgIyBDaGVja0JveGVzDQogICAgJGgyID0gMjAgICMgTGFiZWxfMSwgTGFiZWxfMiwgQ2hlY2tCb3hlcw0KICAgICRoMyA9IDUwICAjIEJ1dHRvbl8xDQogICAgIyBTaXplDQogICAgJGggPSAoJEFycmF5LkNvdW50ICogJGgyKSArICgkeiAqIDIpICMgRm9ybV8xDQogICAgaWYgKCAkaCAtbHQgJHcgLyAyICkgeyAkaCA9ICR3IC8gMiB9ICAjIEZvcm1fMSAoIGggbWluaW11bSAxLzIgb2YgdyApDQogICAgJGgxID0gJGggLSAkaDMgLSAoJGgyICogMikgLSAoJHogKiAyKSAjIFJpY2hUZXh0Qm94XzENCiAgICAkaDQgPSAkaDMgLyAyICMgTGFiZWxfMywgUHJvZ3Jlc3NCYXJfMQ0KICAgICR3MSA9ICR3IC0gJHcyIC0gKCR6ICogMykgIyBSaWNoVGV4dEJveF8xLCBMYWJlbF8xLCBMYWJlbF8yLCBCdXR0b25fMSwgTGFiZWxfMywgUHJvZ3Jlc3NCYXJfMQ0KICAgICMgUG9pbnQNCiAgICAkeDEgPSAkdzEgKyAoJHogKiAyKSAjIENoZWNrQm94ZXMNCiAgICAkeTEgPSAkaDEgKyAkeiAgIyBMYWJlbF8xDQogICAgJHkyID0gJHkxICsgJGgyICMgTGFiZWxfMg0KICAgICR5MyA9ICR5MiArICRoMiAjIEJ1dHRvbl8xLCBMYWJlbF8zDQogICAgJHk0ID0gJHkzICsgKCAkaDMgLyAyICkgIyBQcm9ncmVzc0Jhcl8xDQogICAgIyBHbG9iYWwgRm9udA0KICAgICRmb250ID0gIk1pY3Jvc29mdCBTYW5zIFNlcmlmIg0KDQogICAgIyBGb3JtXzEgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KICAgICRGb3JtXzEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkZvcm0NCiAgICAgICAgJEZvcm1fMS5DbGllbnRTaXplID0gIiR3LCRoIg0KICAgICAgICAkRm9ybV8xLkljb24gPSAiQzpcT3BlcmF0b3JUb29sc1xpY29cRmF2aWNvbi5pY28iDQogICAgICAgICRGb3JtXzEuQmFja0NvbG9yID0gIjIyNSwyMjUsMjI1Ig0KICAgICAgICAkRm9ybV8xLkZvcm1Cb3JkZXJTdHlsZSA9ICJGaXhlZDNEIg0KICAgICAgICAkRm9ybV8xLlN0YXJ0UG9zaXRpb24gPSAiQ2VudGVyU2NyZWVuIg0KICAgICAgICAkRm9ybV8xLk1heGltaXplQm94ID0gMA0KICAgICAgICAkRm9ybV8xLlRleHQgPSAiRG9kbyBDb250YWN0IENlbnRlcjogU2xhY2sgU2VuZCBNZXNzYWdlIFRvb2xzIHYkKCR2ZXJzaW9uKSINCg0KICAgICMgUmljaFRleHRCb3hfMSAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJFJpY2hUZXh0Qm94XzEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLlJpY2hUZXh0Qm94DQogICAgICAgICRSaWNoVGV4dEJveF8xLkxvY2F0aW9uID0gIiR6LCR6Ig0KICAgICAgICAkUmljaFRleHRCb3hfMS5TaXplID0gIiR3MSwkaDEiDQogICAgICAgICRSaWNoVGV4dEJveF8xLkZvbnQgPSAiJGZvbnQsMTAiDQogICAgICAgICRSaWNoVGV4dEJveF8xLkJhY2tDb2xvciA9ICIyNTUsMjU1LDI1NSINCiAgICAgICAgJFJpY2hUZXh0Qm94XzEuQm9yZGVyU3R5bGUgPSAiTm9uZSINCiAgICAgICAgJFJpY2hUZXh0Qm94XzEuU2VsZWN0aW9uSW5kZW50ID0gKCAkeiAvIDIgKQ0KICAgICAgICAkUmljaFRleHRCb3hfMS5TZWxlY3Rpb25SaWdodEluZGVudCA9ICggJHogLyAyICkNCiAgICAgICAgJFJpY2hUZXh0Qm94XzEuRW5hYmxlZCA9ICR0cnVlDQogICAgICAgICRSaWNoVGV4dEJveF8xLlRleHQgPSANCidgYGDihpMg0K3RgtC+INC/0YDQuNC80LXRgCDRgdC+0L7QsdGJ0LXQvdC40Y8g4oaTYGBgDQrQoNC10LHRj9GC0LAsINC/0YDQuNCy0LXRgiENCg0K0JLQsNC20L3QvtC1ICLRg9GC0L7Rh9C90LXQvdC40LUiINC/0L4g0LDQutGG0LjQuDogX9CS0YLQvtGA0LDRjyDQv9C+0LvQvtCy0LjQvdC60LAg0LIg0L/QvtC00LDRgNC+0LpfLCDQv9C+INC/0YDQvtC80L7QutC+0LTRgyBgTE9WRWAuDQrQp9GC0L7QsdGLINGB0L3QuNC30LjRgtGMINC90LDQs9GA0YPQt9C60YMg0L3QsCDQv9C40YbRhtC10YDQuNC4LCDQv9GA0LjQvdGP0YLQviDRgNC10YjQtdC90LjQtSDQstCy0LXRgdGC0Lgg0L7Qs9GA0LDQvdC40YfQtdC90LjQtS4NCg0KPjp3YXJuaW5nOiAq0JHRg9C00YzRgtC1INCy0L3QuNC80LDRgtC10LvRjNC90YsuKg0KPirQotC10L/QtdGA0Ywg0L7QtNC40L0g0LrQu9C40LXQvdGCINGB0LzQvtC20LXRgiDQstC+0YHQv9C+0LvRjNC30L7QstCw0YLRjNGB0Y8g0L/RgNC+0LzQvtC60L7QtNC+0Lwg0YLQvtC70YzQutC+IH4yINGA0LDQt9CwfiAxINGA0LDQty4qDQoNCjpib29rOiA8aHR0cHM6Ly9kb2RvcGl6emEuaW5mby9zdGFuZGFyZHMvfNCR0LDQt9CwINC30L3QsNC90LjQuT4NCg0KX01heSB0aGUgRm9yY2UgYmUgd2l0aCB5b3VfIDp5b2RhX2ZvcmNlOg0KYGBg4oaRINCt0YLQviDQv9GA0LjQvNC10YAg0YHQvtC+0LHRidC10L3QuNGPIOKGkWBgYCcNCiAgICANCiAgICAkRm9ybV8xLkNvbnRyb2xzLkFkZCgkUmljaFRleHRCb3hfMSkNCg0KICAgICMgTGFiZWxfMSAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJExhYmVsXzEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkxhYmVsDQogICAgICAgICRMYWJlbF8xLkxvY2F0aW9uID0gIiR6LCR5MSINCiAgICAgICAgJExhYmVsXzEuU2l6ZSA9ICIkdzEsJGgyIg0KICAgICAgICAkTGFiZWxfMS5Gb250ID0gIiRmb250LDkiDQogICAgICAgICRMYWJlbF8xLkZvcmVDb2xvciA9ICI4MCw4MCw4MCINCiAgICAgICAgJExhYmVsXzEuVGV4dCA9ICdcbiAgLSDQv9C10YDQtdC90L7RgSDRgdGC0YDQvtC60LggICAgKtC20LjRgNC90YvQuSogICAgX9C60YPRgNGB0LjQsl8gICAgftC30LDRh9C10YDRgtC90YPRgtGL0Ll+ICAgIGBgYNC60L7QtCDQsdC70L7QumBgYCcNCiAgICAkRm9ybV8xLkNvbnRyb2xzLkFkZCgkTGFiZWxfMSkNCg0KICAgICMgTGFiZWxfMiAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJExhYmVsXzIgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkxhYmVsDQogICAgICAgICRMYWJlbF8yLkxvY2F0aW9uID0gIiR6LCR5MiINCiAgICAgICAgJExhYmVsXzIuU2l6ZSA9ICIkdzEsJGgyIg0KICAgICAgICAkTGFiZWxfMi5Gb250ID0gIiRmb250LDkiDQogICAgICAgICRMYWJlbF8yLkZvcmVDb2xvciA9ICI4MCw4MCw4MCINCiAgICAgICAgJExhYmVsXzIuVGV4dCA9ICdcbj4gIC0g0YbQuNGC0LjRgNC+0LLQsNC90LjQtSAgICBg0LrQvtC0INC60YDQsNGB0L3Ri9C8YCAgICA60Y3QvNC+0LTQt9C4OiAgICA8ZG9kb3BpenphLnJ1fNGC0LXQutGB0YIg0YHRgdGL0LvQutC4PicNCiAgICAkRm9ybV8xLkNvbnRyb2xzLkFkZCgkTGFiZWxfMikNCg0KICAgICMgQnV0dG9uXzEgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJEJ1dHRvbl8xID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5CdXR0b24NCiAgICAgICAgJEJ1dHRvbl8xLkxvY2F0aW9uID0gIiR6LCR5MyINCiAgICAgICAgJEJ1dHRvbl8xLlNpemUgPSAiJHcxLCRoMyINCiAgICAgICAgJEJ1dHRvbl8xLkZvbnQgPSAiJGZvbnQsMTIiDQogICAgICAgICRCdXR0b25fMS5Vc2VWaXN1YWxTdHlsZUJhY2tDb2xvciA9ICRUcnVlDQogICAgICAgICRCdXR0b25fMS5UZXh0ID0gItCeINCiINCfINCgINCQINCSINCYINCiINCsIg0KICAgICAgICAkQnV0dG9uXzEuQWRkX0NsaWNrKCB7DQoNCiAgICAgICAgICAgICRMYWJlbF8zLlNob3coKQ0KICAgICAgICAgICAgJEJ1dHRvbl8xLkhpZGUoKQ0KDQogICAgICAgICAgICBTZW5kTWVzc2FnZVNsYWNrDQogICAgICAgICAgICBTdGFydC1TbGVlcCAtU2Vjb25kcyAxDQoNCiAgICAgICAgICAgICRMYWJlbF8zLkhpZGUoKQ0KICAgICAgICAgICAgJEJ1dHRvbl8xLlNob3coKQ0KDQogICAgICAgIH0gKQ0KICAgICRGb3JtXzEuQ29udHJvbHMuQWRkKCRCdXR0b25fMSkNCg0KICAgICMgTGFiZWxfMyAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJExhYmVsXzMgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkxhYmVsDQogICAgICAgICRMYWJlbF8zLkxvY2F0aW9uID0gIiR6LCR5MyINCiAgICAgICAgJExhYmVsXzMuU2l6ZSA9ICIkdzEsJGg0Ig0KICAgICAgICAkTGFiZWxfMy5Gb250ID0gW1N5c3RlbS5EcmF3aW5nLkZvbnRdOjpuZXcoICRmb250LCAxMCwgW1N5c3RlbS5EcmF3aW5nLkZvbnRTdHlsZV06OkJvbGQgKQ0KICAgICAgICAkTGFiZWxfMy5IaWRlKCkNCiAgICAkRm9ybV8xLkNvbnRyb2xzLkFkZCgkTGFiZWxfMykNCg0KICAgICMgUHJvZ3Jlc3NCYXJfMSAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQogICAgJFByb2dyZXNzQmFyXzEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLlByb2dyZXNzQmFyDQogICAgICAgICRQcm9ncmVzc0Jhcl8xLkxvY2F0aW9uID0gIiR6LCR5NCINCiAgICAgICAgJFByb2dyZXNzQmFyXzEuU2l6ZSA9ICIkdzEsJGg0Ig0KICAgICAgICAkUHJvZ3Jlc3NCYXJfMS5Gb250ID0gIiRmb250LDEyIg0KICAgICAgICAkUHJvZ3Jlc3NCYXJfMS5IaWRlKCkNCiAgICAkRm9ybV8xLkNvbnRyb2xzLkFkZCgkUHJvZ3Jlc3NCYXJfMSkNCg0KICAgICMgQ2hlY2tCb3hlcyAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMNCiAgICAkQ2hlY2tCb3hlcyA9IEAoKQ0KICAgICRBcnJheS5Gb3JlYWNoew0KICAgICAgICAkQ2hlY2tCb3ggPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkNoZWNrQm94DQogICAgICAgICAgICAkQ2hlY2tCb3guTG9jYXRpb24gPSAiJHgxLCR6Ig0KICAgICAgICAgICAgJENoZWNrQm94LlNpemUgPSAiJHcyLCRoMiINCiAgICAgICAgICAgICRDaGVja0JveC5Gb250ID0gIiRmb250LDkiDQogICAgICAgICAgICAkQ2hlY2tCb3guQXBwZWFyYW5jZSA9ICJCdXR0b24iDQogICAgICAgICAgICAkQ2hlY2tCb3guRmxhdFN0eWxlID0gIkZsYXQiDQogICAgICAgICAgICAkQ2hlY2tCb3guRmxhdEFwcGVhcmFuY2UuQm9yZGVyU2l6ZSA9IDANCiAgICAgICAgICAgICRDaGVja0JveC5GbGF0QXBwZWFyYW5jZS5DaGVja2VkQmFja0NvbG9yID0gIjE2MCwyMDAsMjQwIg0KICAgICAgICAgICAgJENoZWNrQm94Lk5hbWUgPSAkXy5XaGF0SWRvDQogICAgICAgICAgICAkQ2hlY2tCb3guVGV4dCA9ICRfLlRleHQNCg0KICAgICAgICBJZiAoICRudWxsIC1uZSAkXy5UZXh0ICkgew0KICAgICAgICAgICAgSWYgKCAkXy5XaGF0SWRvIC1lcSAkQXJyYXkuV2hhdElkb1swXSApIHsgJENoZWNrQm94LkNoZWNrZWQgPSAkdHJ1ZSB9DQogICAgICAgICAgICAkRm9ybV8xLkNvbnRyb2xzLkFkZCgkQ2hlY2tCb3gpDQogICAgICAgICAgICAkQ2hlY2tCb3hlcyArPSAkQ2hlY2tCb3gNCiAgICAgICAgfQ0KICAgICAgICAkeiArPSAkaDINCiAgICB9DQogICAgIyBTaG93IHRoZSBGb3JtDQogICAgW3ZvaWRdJEZvcm1fMS5TaG93RGlhbG9nKCkNCn0gIyBFbmQgR2VuZXJhdGVGb3JtDQoNCkZ1bmN0aW9uIFNlbmRNZXNzYWdlU2xhY2sgew0KDQogICAgIyDQn9GA0L7QstC10YDRj9C10Lwg0L7QsdGP0LfQsNGC0LXQu9GM0L3Ri9C1INGD0YHQu9C+0LLQuNGPDQogICAgJExhYmVsXzMuRm9yZUNvbG9yID0gIjE2MCw0MCw0MCINCiAgICBpZiAoICRDaGVja0JveGVzLldoZXJleyRfLkNoZWNrZWQgLWVxICRUcnVlfS5jb3VudCAtZXEgMCApIHsNCiAgICAgICAgJExhYmVsXzMuVGV4dCA9ICLQndCV0JrQntCc0KMg0J7QotCf0KDQkNCS0JvQr9Ci0KwiDQogICAgICAgIHJldHVybg0KICAgIH0gZWxzZWlmICggJFJpY2hUZXh0Qm94XzEuVGV4dCAtZXEgIiIgKSB7DQogICAgICAgICRMYWJlbF8zLlRleHQgPSAi0J3QldCn0JXQk9CeINCe0KLQn9Cg0JDQktCb0K/QotCsIg0KICAgICAgICByZXR1cm4NCiAgICB9DQogICAgJExhYmVsXzMuRm9yZUNvbG9yID0gIjgwLDgwLDgwIg0KICAgICRMYWJlbF8zLlRleHQgPSAi0J/QvtC00LPQvtGC0L7QstC60LAg0Log0L7RgtC/0YDQsNCy0LrQtSAuIC4gLiINCg0KICAgICMg0JDRg9GBIFNsYWNrDQogICAgJEJvdFVzZXJPQXV0aEFjY2Vzc1Rva2VuID0gInhveGItNDYzMzQ1NjM2Njc0LTUxMTU5MjcxODMyMi1oanlhWWN1ck5tV0JRcmh3TmdXQ1lpbWwiDQogICAgJGhlYWRlcnNfc2xhY2sgPSBAeyAiQXV0aG9yaXphdGlvbiIgPSAiQmVhcmVyICQoJEJvdFVzZXJPQXV0aEFjY2Vzc1Rva2VuKSI7ICJDb250ZW50LVR5cGUiID0gImFwcGxpY2F0aW9uL2pzb247Y2hhcnNldD1VVEYtOCIgfQ0KDQogICAgIyDQn9C+0LvRg9GH0LDQtdC8INGB0L/QuNGB0L7QuiDQstGB0LXRhSDQv9C+0LvRjNC30L7QstCw0YLQtdC70LXQuSBTbGFjaw0KICAgICMg0J/QtdGA0LLQsNGPINC/0LDRgNGC0LjRjyAo0LTQviAxMDAwKQ0KICAgICRzbGFja19hbGxfdXNlcnMgPSBAKCkNCiAgICAkc2xhY2tfcmVxdWllc3QgPSBJbnZva2UtUmVzdE1ldGhvZCAtTWV0aG9kIEdFVCAtVXJpICJodHRwczovL3NsYWNrLmNvbS9hcGkvdXNlcnMubGlzdCIgLUhlYWRlcnMgJGhlYWRlcnNfc2xhY2sNCiAgICAkc2xhY2tfYWxsX3VzZXJzICs9ICRzbGFja19yZXF1aWVzdC5tZW1iZXJzDQogICAgIyDQodC70LXQtNGD0Y7RidC40LUg0L/QsNGA0YLQuNC4ICjQtdGB0LvQuCDQtdGB0YLRjCkNCiAgICB3aGlsZSAoICRzbGFja19yZXF1aWVzdC5yZXNwb25zZV9tZXRhZGF0YS5uZXh0X2N1cnNvciAtbmUgIiIgKSB7DQogICAgICAgICRzbGFja19yZXF1aWVzdCA9IEludm9rZS1SZXN0TWV0aG9kIC1NZXRob2QgR0VUIC1VcmkgImh0dHBzOi8vc2xhY2suY29tL2FwaS91c2Vycy5saXN0P2N1cnNvcj0kKCRzbGFja19yZXF1aWVzdC5yZXNwb25zZV9tZXRhZGF0YS5uZXh0X2N1cnNvcikiIC1IZWFkZXJzICRoZWFkZXJzX3NsYWNrDQogICAgICAgICRzbGFja19hbGxfdXNlcnMgKz0gJHNsYWNrX3JlcXVpZXN0Lm1lbWJlcnMNCiAgICB9DQoNCiAgICAjINCe0YLQv9GA0LDQstC60LAg0YHQvtC+0LHRidC10L3QuNGPINCyIFNsYWNrDQogICAgJHBhcmFtcyA9IEB7DQogICAgICAgIE1ldGhvZCAgICAgID0gIlBPU1QiDQogICAgICAgIFVyaSAgICAgICAgID0gImh0dHBzOi8vc2xhY2suY29tL2FwaS9jaGF0LnBvc3RNZXNzYWdlIg0KICAgICAgICBIZWFkZXJzICAgICA9ICRoZWFkZXJzX3NsYWNrDQogICAgICAgIENvbnRlbnRUeXBlID0gImFwcGxpY2F0aW9uL2pzb247Y2hhcnNldD1VVEYtOCINCiAgICB9DQogICAgZm9yZWFjaCAoICRDaGVja0JveCBpbiAkQ2hlY2tCb3hlcy5XaGVyZXsgJF8uQ2hlY2tlZCAtZXEgJFRydWUgfSApIHsNCg0KICAgICAgICBpZiAoICRDaGVja0JveC5OYW1lIC1lcSAkQXJyYXkuV2hhdElkb1swXSApIHsNCg0KICAgICAgICAgICAgW3N0cmluZ10kU2VuZF9UbyA9ICcq0J7RgtC/0YDQsNCy0LvQtdC90L46KiAnDQogICAgICAgICAgICAkQ2hlY2tCb3hlcy5XaGVyZXsgJF8uQ2hlY2tlZCAtZXEgJFRydWUgfS5Gb3JFYWNoew0KDQogICAgICAgICAgICAgICAgJFNlbmRfVG8gKz0gKCAnXG4+YCcgKyAkXy5UZXh0ICsgJ2AgJyApDQogICAgICAgICAgICB9DQogICAgICAgICAgICAkU2VuZF9UbyArPSAnXG4gXG4gJw0KDQogICAgICAgICAgICAkYm9keV9zbGFjayA9IFtQU0N1c3RvbU9iamVjdF1Aew0KICAgICAgICAgICAgICAgIGNoYW5uZWwgICAgPSAkQ2hlY2tCb3guTmFtZQ0KICAgICAgICAgICAgICAgIGljb25fZW1vamkgPSAiOnphcDoiDQogICAgICAgICAgICAgICAgdGV4dCAgICAgICA9ICRTZW5kX1RvICsgJFJpY2hUZXh0Qm94XzEuVGV4dCAtcmVwbGFjZSAnIicsICdcIicNCiAgICAgICAgICAgICAgICB1c2VybmFtZSAgID0gIkNDQm90Ig0KICAgICAgICAgICAgfSB8IENvbnZlcnRUby1Kc29uIHwgRm9yRWFjaC1PYmplY3QgeyBbU3lzdGVtLlRleHQuUmVndWxhckV4cHJlc3Npb25zLlJlZ2V4XTo6VW5lc2NhcGUoJF8pIH0NCg0KICAgICAgICAgICAgSW52b2tlLVJlc3RNZXRob2QgQHBhcmFtcyAtQm9keSAkYm9keV9zbGFjaw0KDQogICAgICAgIH0gZWxzZSB7DQogICAgICAgICAgICAkcmVxdWllc3Rfb2JqID0gJHNsYWNrX2FsbF91c2Vycy5XaGVyZXsgJF8ucHJvZmlsZS50aXRsZSAtZXEgJENoZWNrQm94Lk5hbWUgLWFuZCAkXy5kZWxldGVkIC1lcSAkZmFsc2UgfQ0KDQogICAgICAgICAgICAkcHJvZ3Jlc3MgPSAwDQogICAgICAgICAgICAkUHJvZ3Jlc3NCYXJfMS5NYXhpbXVtID0gJHJlcXVpZXN0X29iai5Db3VudA0KICAgICAgICAgICAgJFByb2dyZXNzQmFyXzEuU2hvdygpDQoNCiAgICAgICAgICAgICRyZXF1aWVzdF9vYmouRm9yZWFjaHsNCg0KICAgICAgICAgICAgICAgICRib2R5X3NsYWNrID0gW1BTQ3VzdG9tT2JqZWN0XUB7DQogICAgICAgICAgICAgICAgICAgIGNoYW5uZWwgICAgPSAkXy5JRA0KICAgICAgICAgICAgICAgICAgICBpY29uX2Vtb2ppID0gIjp6YXA6Ig0KICAgICAgICAgICAgICAgICAgICB0ZXh0ICAgICAgID0gJFJpY2hUZXh0Qm94XzEuVGV4dCAtcmVwbGFjZSAnIicsICdcIicNCiAgICAgICAgICAgICAgICAgICAgdXNlcm5hbWUgICA9ICJDQ0JvdCINCiAgICAgICAgICAgICAgICB9IHwgQ29udmVydFRvLUpzb24gfCBGb3JFYWNoLU9iamVjdCB7IFtTeXN0ZW0uVGV4dC5SZWd1bGFyRXhwcmVzc2lvbnMuUmVnZXhdOjpVbmVzY2FwZSgkXykgfQ0KDQogICAgICAgICAgICAgICAgSW52b2tlLVJlc3RNZXRob2QgQHBhcmFtcyAtQm9keSAkYm9keV9zbGFjaw0KDQogICAgICAgICAgICAgICAgJHByb2dyZXNzICs9IDENCiAgICAgICAgICAgICAgICB0cnkgeyAkUHJvZ3Jlc3NCYXJfMS5WYWx1ZSA9ICRwcm9ncmVzcyArIDEgfSBjYXRjaCB7fQ0KICAgICAgICAgICAgICAgICRQcm9ncmVzc0Jhcl8xLlZhbHVlID0gJHByb2dyZXNzDQogICAgICAgICAgICAgICAgJExhYmVsXzMuVGV4dCA9ICLQntGC0L/RgNCw0LLQutCwICQoJENoZWNrQm94LlRleHQpOiAkKCRwcm9ncmVzcykg0LjQtyAkKCRyZXF1aWVzdF9vYmouQ291bnQpIg0KICAgICAgICAgICAgfQ0KICAgICAgICAgICAgJFByb2dyZXNzQmFyXzEuSGlkZSgpDQogICAgICAgICAgICAkTGFiZWxfMy5Gb3JlQ29sb3IgPSAiNDAsMTIwLDAiDQogICAgICAgICAgICAkTGFiZWxfMy5UZXh0ID0gItCe0YLQv9GA0LDQstC60LAgJCgkQ2hlY2tCb3guVGV4dCk6INCX0JDQktCV0KDQqNCV0J3QkCINCiAgICAgICAgICAgIFN0YXJ0LVNsZWVwIC1TZWNvbmRzIDQNCiAgICAgICAgfQ0KICAgIH0NCn0gIyBFbmQgU2VuZE1lc3NhZ2VTbGFjaw0KDQpHZW5lcmF0ZUZvcm0="));
					if (!string.IsNullOrEmpty(text))
					{
						File.WriteAllText(text, @string);
						return 0;
					}
					val2.AddScript(@string);
					string text4 = null;
					Regex regex = new Regex("^-([^: ]+)[ :]?([^:]*)$");
					for (int j = num; j < args.Length; j++)
					{
						Match match = regex.Match(args[j]);
						if (match.Success && match.Groups.Count == 3 && !double.TryParse(args[j], out var _))
						{
							if (text4 != null)
							{
								val2.AddParameter(text4);
							}
							if (match.Groups[2].Value.Trim() == "")
							{
								text4 = match.Groups[1].Value;
							}
							else if (!(match.Groups[2].Value == "True") && !(match.Groups[2].Value.ToUpper() == "$TRUE"))
							{
								if (!(match.Groups[2].Value == "False") && !(match.Groups[2].Value.ToUpper() == "$FALSE"))
								{
									val2.AddParameter(match.Groups[1].Value, (object)match.Groups[2].Value);
									text4 = null;
								}
								else
								{
									val2.AddParameter(match.Groups[1].Value, (object)false);
									text4 = null;
								}
							}
							else
							{
								val2.AddParameter(match.Groups[1].Value, (object)true);
								text4 = null;
							}
						}
						else if (text4 != null)
						{
							val2.AddParameter(text4, (object)args[j]);
							text4 = null;
						}
						else
						{
							val2.AddArgument((object)args[j]);
						}
					}
					if (text4 != null)
					{
						val2.AddParameter(text4);
					}
					val2.AddCommand("out-string");
					val2.AddParameter("stream");
					val2.BeginInvoke<string, PSObject>(val3, colOutput, (PSInvocationSettings)null, (AsyncCallback)delegate(IAsyncResult ar)
					{
						if (ar.IsCompleted)
						{
							mre.Set();
						}
					}, (object)null);
					while (!mainApp.ShouldExit && !mre.WaitOne(100))
					{
					}
					val2.Stop();
					if ((int)val2.get_InvocationStateInfo().get_State() == 5)
					{
						((PSHostUserInterface)ui).WriteErrorLine(val2.get_InvocationStateInfo().get_Reason().Message);
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				val.Close();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("An exception occured: " + ex.Message, AppDomain.CurrentDomain.FriendlyName, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		if (flag)
		{
			MessageBox.Show("Click OK to exit...", AppDomain.CurrentDomain.FriendlyName);
		}
		return mainApp.ExitCode;
	}

	private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		throw new Exception("Unhandled exception in " + AppDomain.CurrentDomain.FriendlyName);
	}
}
