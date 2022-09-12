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
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String("IyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQojIChjKSBEb2RvIENDDQojIEdlbmVyYXRlZCBCeTogQWxla3NleSBNZWR2ZWRvdnNraXkNCiMgRWRpdGVkIGJ5IG1heC5jZmcNCiMgMjAyMQ0KIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQokdmVyc2lvbiA9ICIzLjUuMyINCg0KJEFycmF5ID0gQCgNCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0J7Qv9C10YDQsNGC0L7RgNCw0LwiOyAgICAgICAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiT3BlcmF0b3IifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQodC/0LXRhtC40LDQu9C40YHRgtCw0Lwg0LrQu9C40LXQvdGC0YHQutC+0Lkg0LvQuNC90LjQuCI7ICAgICAgICAgIldoYXRJZG8iID0gIlNwZWNpYWxpc3QifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQmtC+0LzRjNGO0L3QuNGC0Lgg0YHQv9C10YbQuNCw0LvQuNGB0YLQsNC8IjsgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIkNvbW11bml0eSBzcGVjaWFsaXN0In0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0J7Qv9C10YDQsNGC0L7RgNCw0Lwg0L/QvtGH0YLRiyI7ICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJNYWlsIG9wZXJhdG9yIn0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0JrQvtC80YzRjtC90LjRgtC4INC80LXQvdC10LTQttC10YDQsNC8IjsgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiQ29tbXVuaXR5LW1hbmFnZXIifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQotGA0LXQvdC10YDQsNC8ICjQkdCw0LfQsCDQt9C90LDQvdC40Lkg0Lgg0LzQtdGC0YDQuNC60LgpIjsgICAgICAiV2hhdElkbyIgPSAiVHJhaW5lciBCYXNlIn0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0KLRgNC10L3QtdGA0LDQvCAo0J3QsNC50LwsINC+0LHRg9GH0LXQvdC40LUg0Lgg0LDQtNCw0L/RgtCw0YbQuNGPKSI7ICJXaGF0SWRvIiA9ICJUcmFpbmVyIFRlYWNoIn0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0KLRgNC10L3QtdGA0LDQvCAo0KLQtdC60YHRgikiOyAgICAgICAgICAgICAgICAgICAgICAiV2hhdElkbyIgPSAiVHJhaW5lciBUZXh0In0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0JHQuNC30L3QtdGBLdGC0YDQtdC90LXRgNCw0LwiOyAgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIkJ1c2luZXNzIFRyYWluZXIifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICJIUiDRgdC/0LXRhtC40LDQu9C40YHRgtCw0LwiOyAgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIkhSIFNwZWNpYWxpc3Qgb2YgQ29udGFjdCBDZW50ZXIifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICJIUiDQvNC10L3QtdC00LbQtdGA0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJIUiBEb2RvQ0MifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQnNC10L3QtdC00LbQtdGA0LDQvCDRgdC80LXQvdGLIjsgICAgICAgICAgICAgICAgICAgICAgIldoYXRJZG8iID0gIlNoaWZ0IG1hbmFnZXIifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICLQnNC10L3QtdC00LbQtdGA0LDQvCDQv9C+INGA0LXQutC70LDQvNCw0YbQuNGP0LwiOyAgICAgICAgICAgICAiV2hhdElkbyIgPSAiQ2xhaW1zIG1hbmFnZXIifQ0KICAgIFtQU0N1c3RvbU9iamVjdF1AeyJUZXh0IiA9ICJRQS3QvNC10L3QtdC00LbQtdGA0LDQvCI7ICAgICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJRQSJ9DQogICAgW1BTQ3VzdG9tT2JqZWN0XUB7IlRleHQiID0gItCh0L/QtdGG0LjQsNC70LjRgdGC0LDQvCDRh9Cw0YIt0L/QvtC00LTQtdGA0LbQutC4IjsgICAgICAgICAgICAiV2hhdElkbyIgPSAiQ2hhdCBTdXBwb3J0In0NCiAgICBbUFNDdXN0b21PYmplY3RdQHsiVGV4dCIgPSAi0KHQv9C10YbQuNCw0LvQuNGB0YLQsNC8INCe0JzQnyI7ICAgICAgICAgICAgICAgICAgICAgICJXaGF0SWRvIiA9ICJNb2JpbGUgc3VwcG9ydCJ9DQopDQoNCmZ1bmN0aW9uIEdlbmVyYXRlRm9ybSB7DQoNCiNyZWdpb24gSW1wb3J0IHRoZSBBc3NlbWJsaWVzDQpbcmVmbGVjdGlvbi5hc3NlbWJseV06OmxvYWR3aXRocGFydGlhbG5hbWUoIlN5c3RlbS5XaW5kb3dzLkZvcm1zIikgfCBPdXQtTnVsbA0KW3JlZmxlY3Rpb24uYXNzZW1ibHldOjpsb2Fkd2l0aHBhcnRpYWxuYW1lKCJTeXN0ZW0uRHJhd2luZyIpIHwgT3V0LU51bGwNCiNlbmRyZWdpb24NCiRPbkxvYWRGb3JtX1N0YXRlQ29ycmVjdGlvbiA9ICNDb3JyZWN0IHRoZSBpbml0aWFsIHN0YXRlIG9mIHRoZSBmb3JtIHRvIHByZXZlbnQgdGhlIC5OZXQgbWF4aW1pemVkIGZvcm0gaXNzdWUNCiAgICB7JEZvcm0xLldpbmRvd1N0YXRlID0gJEluaXRpYWxGb3JtV2luZG93U3RhdGV9DQoNCiMgU2l6ZS5IZWlnaHQNCiRoID0gKCgkQXJyYXkuQ291bnQgKyAxKSAqIDIwKSArIDQwICMgRm9ybTENCiRoMyA9IDUwICMgQnRuMQ0KJGgyID0gMjAgIyBMYWJlbDEgYW5kIExhYmVsMg0KJGgxID0gJGggLSAkaDMgLSAkaDIgLSA0MCAjIFJpY2hUZXh0Qm94MQ0KDQojIFBvaW50LlkNCiR5MSA9IDEwICMgUmljaFRleHRCb3gxDQokeTIgPSAkaDEgKyAkeTEgIyBMYWJlbDENCiR5MyA9ICR5MiArICRoMiAjIExhYmVsMg0KJHk0ID0gJHkzICsgJGgyICMgQnRuMQ0KDQojIEZvcm0xICMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMNCiRGb3JtMSA9IE5ldy1PYmplY3QgU3lzdGVtLldpbmRvd3MuRm9ybXMuRm9ybQ0KICAgICRTeXN0ZW1fRHJhd2luZ19TaXplID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5TaXplDQogICAgICAgICRTeXN0ZW1fRHJhd2luZ19TaXplLldpZHRoICA9IDc2MCAjINCo0LjRgNC40L3QsA0KICAgICAgICAkU3lzdGVtX0RyYXdpbmdfU2l6ZS5IZWlnaHQgPSAkaCAjINCS0YvRgdC+0YLQsA0KICAgICRGb3JtMS5DbGllbnRTaXplID0gJFN5c3RlbV9EcmF3aW5nX1NpemUNCiAgICAkRm9ybTEuQmFja0NvbG9yID0gW1N5c3RlbS5EcmF3aW5nLkNvbG9yXTo6RnJvbUFyZ2IoMjU1LDIxMiwyMDgsMjAwKQ0KICAgICRGb3JtMS5NYXhpbWl6ZUJveCA9IDANCiAgICAkRm9ybTEuRm9ybUJvcmRlclN0eWxlID0gW1N5c3RlbS5XaW5kb3dzLkZvcm1zLkZvcm1Cb3JkZXJTdHlsZV06OkZpeGVkM0QNCiAgICAkRm9ybTEuRGF0YUJpbmRpbmdzLkRlZmF1bHREYXRhU291cmNlVXBkYXRlTW9kZSA9IDANCiAgICAjJEZvcm0xLlRvcG1vc3QgPSAkdHJ1ZQ0KICAgICRGb3JtMS5Gb250ID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5Gb250KCJNaWNyb3NvZnQgU2FucyBTZXJpZiIsOSwwLDMsMCkNCiAgICAkRm9ybTEuSWNvbiA9IFtTeXN0ZW0uRHJhd2luZy5JY29uXTo6RXh0cmFjdEFzc29jaWF0ZWRJY29uKCJDOlxPcGVyYXRvclRvb2xzXGljb1xGYXZpY29uLmljbyIpDQogICAgJEZvcm0xLk5hbWUgPSAiRm9ybTEiDQogICAgJEZvcm0xLlRleHQgPSAiRG9kbyBDb250YWN0IENlbnRlcjogU2xhY2sgU2VuZCBNZXNzYWdlIFRvb2xzIHYuICQoJHZlcnNpb24pIg0KDQojIFJpY2hUZXh0Qm94MSAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQokUmljaFRleHRCb3gxID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5SaWNoVGV4dEJveA0KICAgICRTeXN0ZW1fRHJhd2luZ19Qb2ludCA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuUG9pbnQNCiAgICAgICAgJFN5c3RlbV9EcmF3aW5nX1BvaW50LlggPSAxMCAjINCe0YLRgdGC0YPQvyDRgdC70LXQstCwDQogICAgICAgICRTeXN0ZW1fRHJhd2luZ19Qb2ludC5ZID0gJHkxICMg0J7RgtGB0YLRg9C/INGB0LLQtdGA0YXRgw0KICAgICRSaWNoVGV4dEJveDEuTG9jYXRpb24gPSAkU3lzdGVtX0RyYXdpbmdfUG9pbnQNCiAgICAkU3lzdGVtX0RyYXdpbmdfU2l6ZSA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuU2l6ZQ0KICAgICAgICAkU3lzdGVtX0RyYXdpbmdfU2l6ZS5XaWR0aCAgPSA0NTAgIyDQqNC40YDQuNC90LANCiAgICAgICAgJFN5c3RlbV9EcmF3aW5nX1NpemUuSGVpZ2h0ID0gJGgxICMg0JLRi9GB0L7RgtCwDQogICAgJFJpY2hUZXh0Qm94MS5TaXplID0gJFN5c3RlbV9EcmF3aW5nX1NpemUNCiAgICAkUmljaFRleHRCb3gxLkJhY2tDb2xvciA9IFtTeXN0ZW0uRHJhd2luZy5Db2xvcl06OkZyb21BcmdiKDI1NSwyNTUsMjU1LDI1NSkNCiAgICAkUmljaFRleHRCb3gxLkRhdGFCaW5kaW5ncy5EZWZhdWx0RGF0YVNvdXJjZVVwZGF0ZU1vZGUgPSAwDQogICAgJFJpY2hUZXh0Qm94MS5Cb3JkZXJTdHlsZSA9IFtTeXN0ZW0uV2luZG93cy5Gb3Jtcy5Gb3JtQm9yZGVyU3R5bGVdOjpOb25lDQogICAgJFJpY2hUZXh0Qm94MS5TZWxlY3Rpb25JbmRlbnQgPSA1DQogICAgJFJpY2hUZXh0Qm94MS5TZWxlY3Rpb25SaWdodEluZGVudCA9IDUNCiAgICAkUmljaFRleHRCb3gxLkVuYWJsZWQgPSAkdHJ1ZQ0KICAgICRSaWNoVGV4dEJveDEuRm9udCA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuRm9udCgiTWljcm9zb2Z0IFNhbnMgU2VyaWYiLDEwLDAsMywwKQ0KICAgICRSaWNoVGV4dEJveDEuVGFiSW5kZXggPSAyDQogICAgJFJpY2hUZXh0Qm94MS5OYW1lID0gIlJpY2hUZXh0Qm94MSINCiAgICAkUmljaFRleHRCb3gxLlRleHQgPSAnYGBg0K3RgtC+INC/0YDQuNC80LXRgCDRgdC+0L7QsdGJ0LXQvdC40Y9gYGAg0KDQtdCx0Y/RgtCwLCDQv9GA0LjQstC10YIhIFxuINCS0LDQttC90L7QtSDRg9GC0L7Rh9C90LXQvdC40LUg0L/QviDQsNC60YbQuNC4OiBf0JLRgtC+0YDQsNGPINC/0L7Qu9C+0LLQuNC90LrQsCDQsiDQv9C+0LTQsNGA0L7QuiDQv9C+INC/0YDQvtC80L7QutC+0LTRg18gYExPVkVgLiBcbiDQp9GC0L7QsdGLINGB0L3QuNC30LjRgtGMINC90LDQs9GA0YPQt9C60YMg0L3QsCDQv9C40YbRhtC10YDQuNC4LCDQv9GA0LjQvdGP0YLQviDRgNC10YjQtdC90LjQtSDQstCy0LXRgdGC0Lgg0L7Qs9GA0LDQvdC40YfQtdC90LjQtS4gXG4+IDp3YXJuaW5nOiAq0JHRg9C00YzRgtC1INCy0L3QuNC80LDRgtC10LvRjNC90YsuKiBcbj4gKtCi0LXQv9C10YDRjCDQvtC00LjQvSDQutC70LjQtdC90YIg0YHQvNC+0LbQtdGCINCy0L7RgdC/0L7Qu9GM0LfQvtCy0LDRgtGM0YHRjyDQv9GA0L7QvNC+0LrQvtC00L7QvCDRgtC+0LvRjNC60L4gfjIg0YDQsNC30LB+IDEg0YDQsNC3LiogXG4gOmJvb2s6IDxodHRwczovL2RvZG9waXp6YS5pbmZvL3N0YW5kYXJkcy980JHQsNC30LAg0LfQvdCw0L3QuNC5PiBgYGDQrdGC0L4g0L/RgNC40LzQtdGAINGB0L7QvtCx0YnQtdC90LjRj2BgYCcNCiRGb3JtMS5Db250cm9scy5BZGQoJFJpY2hUZXh0Qm94MSkNCg0KIyBMYWJlbDEgIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KJExhYmVsMSA9IE5ldy1PYmplY3QgU3lzdGVtLldpbmRvd3MuRm9ybXMuTGFiZWwNCiAgICAkTGFiZWwxLkxvY2F0aW9uID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5Qb2ludCgxMCwkeTIpDQogICAgJExhYmVsMS5TaXplID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5TaXplKDQ1MCwkaDIpDQogICAgJExhYmVsMS5Gb250ID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5Gb250KCJNaWNyb3NvZnQgU2FucyBTZXJpZiIsOSwwLDMsMCkNCiAgICAkTGFiZWwxLlRleHQgPSAnXG4gLSDQv9C10YDQtdC90L7RgSDRgdGC0YDQvtC60LggICAq0LbQuNGA0L3Ri9C5KiAgIF/QutGD0YDRgdC40LJfICAgftC30LDRh9C10YDRgtC90YPRgtGL0Ll+ICAgYGBg0LrQvtC0INCx0LvQvtC6YGBgJw0KJEZvcm0xLkNvbnRyb2xzLkFkZCgkTGFiZWwxKQ0KDQojIExhYmVsMiAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjDQokTGFiZWwyID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5MYWJlbA0KICAgICRMYWJlbDIuTG9jYXRpb24gPSBOZXctT2JqZWN0IFN5c3RlbS5EcmF3aW5nLlBvaW50KDEwLCR5MykNCiAgICAkTGFiZWwyLlNpemUgPSBOZXctT2JqZWN0IFN5c3RlbS5EcmF3aW5nLlNpemUoNDUwLCRoMikNCiAgICAkTGFiZWwyLkZvbnQgPSBOZXctT2JqZWN0IFN5c3RlbS5EcmF3aW5nLkZvbnQoIk1pY3Jvc29mdCBTYW5zIFNlcmlmIiw5LDAsMywwKQ0KICAgICRMYWJlbDIuVGV4dCA9ICdcbj4gLSDRhtC40YLQuNGA0L7QstCw0L3QuNC1ICAgYNC60L7QtCDQutGA0LDRgdC90YvQvGAgICA60Y3QvNC+0LTQt9C4OiAgIDxnb29nbGUuY29tfNGC0LXQutGB0YIg0YHRgdGL0LvQutC4PicNCiRGb3JtMS5Db250cm9scy5BZGQoJExhYmVsMikNCg0KIyBCdG4xICMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIw0KJEJ0bjEgPSBOZXctT2JqZWN0IFN5c3RlbS5XaW5kb3dzLkZvcm1zLkJ1dHRvbg0KICAgICRTeXN0ZW1fRHJhd2luZ19Qb2ludCA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuUG9pbnQNCiAgICAgICAgJFN5c3RlbV9EcmF3aW5nX1BvaW50LlggPSAxMCAgIyDQntGC0YHRgtGD0L8g0YHQu9C10LLQsA0KICAgICAgICAkU3lzdGVtX0RyYXdpbmdfUG9pbnQuWSA9ICR5NCAjINCe0YLRgdGC0YPQvyDRgdCy0LXRgNGF0YMNCiAgICAkQnRuMS5Mb2NhdGlvbiA9ICRTeXN0ZW1fRHJhd2luZ19Qb2ludA0KICAgICRTeXN0ZW1fRHJhd2luZ19TaXplID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5TaXplDQogICAgICAgICRTeXN0ZW1fRHJhd2luZ19TaXplLldpZHRoID0gNDUwICMg0KjQuNGA0LjQvdCwDQogICAgICAgICRTeXN0ZW1fRHJhd2luZ19TaXplLkhlaWdodCA9ICRoMyAjINCS0YvRgdC+0YLQsA0KICAgICRCdG4xLlNpemUgPSAkU3lzdGVtX0RyYXdpbmdfU2l6ZQ0KICAgICRCdG4xLkRhdGFCaW5kaW5ncy5EZWZhdWx0RGF0YVNvdXJjZVVwZGF0ZU1vZGUgPSAwDQogICAgJEJ0bjEuRm9udCA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuRm9udCgiTWljcm9zb2Z0IFNhbnMgU2VyaWYiLDExLDAsMywwKQ0KICAgICRCdG4xLlRhYkluZGV4ID0gMA0KICAgICRCdG4xLlRhYlN0b3AgPSAkRmFsc2UNCiAgICAkQnRuMS5OYW1lID0gIkJ0bjEiDQogICAgJEJ0bjEuVGV4dCA9ICLQntCi0J/QoNCQ0JLQmNCi0KwiDQogICAgJEJ0bjEuVXNlVmlzdWFsU3R5bGVCYWNrQ29sb3IgPSAkVHJ1ZQ0KICAgICRCdG4xLkFkZF9DbGljayh7DQogICAgICAgICRHbG9iYWw6eCA9ICRSaWNoVGV4dEJveDEuVGV4dA0KICAgICAgICBTZW5kTWVzc2FnZVNsYWNrDQogICAgfSkNCiRGb3JtMS5Db250cm9scy5BZGQoJEJ0bjEpDQoNCiMgQ2hlY2tCb3hlcyAjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMNCiRtQ2hlY2tCb3gxID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5DaGVja0JveA0KICAgICRtQ2hlY2tCb3gxLlRleHQgPSAi0J7RgtC/0YDQsNCy0LjRgtGMINGC0LXRgdGC0L7QstC+0LUg0YHQvtC+0LHRidC10L3QuNC1Ig0KICAgICRtQ2hlY2tCb3gxLkxlZnQgPSAiNDgwIg0KICAgICRtQ2hlY2tCb3gxLlRvcCA9ICIxMCINCiAgICAkbUNoZWNrQm94MS5BbmNob3IgPSAiTGVmdCxUb3AiDQogICAgJG1DaGVja0JveDEuU2l6ZSA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuU2l6ZSgyNzAsMjApDQogICAgJG1DaGVja0JveDEuRm9udCA9IE5ldy1PYmplY3QgU3lzdGVtLkRyYXdpbmcuRm9udCgiTWljcm9zb2Z0IFNhbnMgU2VyaWYiLDksMCwzLDApDQokRm9ybTEuQ29udHJvbHMuQWRkKCRtQ2hlY2tCb3gxKQ0KDQokQW5jaG9yVG9wID0gNTANCiRDaGVja0JveGVzID0gZm9yZWFjaCAoJF8gaW4gJEFycmF5KSB7DQogICAgJENoZWNrQm94ID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5DaGVja0JveA0KICAgICAgICAkQ2hlY2tCb3guTmFtZSA9ICRfLldoYXRJZG8NCiAgICAgICAgJENoZWNrQm94LlRleHQgPSAkXy5UZXh0DQogICAgICAgICRDaGVja0JveC5MZWZ0ID0gNDgwDQogICAgICAgICRDaGVja0JveC5Ub3AgPSAkQW5jaG9yVG9wDQogICAgICAgICRDaGVja0JveC5BbmNob3IgPSAiTGVmdCxUb3AiDQogICAgICAgICRDaGVja0JveC5TaXplID0gTmV3LU9iamVjdCBTeXN0ZW0uRHJhd2luZy5TaXplKDI3MCwyMCkNCiAgICAgICAgJENoZWNrQm94LkZvbnQgPSBOZXctT2JqZWN0IFN5c3RlbS5EcmF3aW5nLkZvbnQoIk1pY3Jvc29mdCBTYW5zIFNlcmlmIiw5LDAsMywwKQ0KICAgICRGb3JtMS5Db250cm9scy5BZGQoJENoZWNrQm94KQ0KICAgICRBbmNob3JUb3AgKz0gMjANCiAgICAkQ2hlY2tCb3gNCn0NCg0KI1NhdmUgdGhlIGluaXRpYWwgc3RhdGUgb2YgdGhlIGZvcm0NCiRJbml0aWFsRm9ybVdpbmRvd1N0YXRlID0gTmV3LU9iamVjdCBTeXN0ZW0uV2luZG93cy5Gb3Jtcy5Gb3JtV2luZG93U3RhdGUNCiRJbml0aWFsRm9ybVdpbmRvd1N0YXRlID0gJEZvcm0xLldpbmRvd1N0YXRlDQojSW5pdCB0aGUgT25Mb2FkIGV2ZW50IHRvIGNvcnJlY3QgdGhlIGluaXRpYWwgc3RhdGUgb2YgdGhlIGZvcm0NCiRGb3JtMS5hZGRfTG9hZCgkT25Mb2FkRm9ybV9TdGF0ZUNvcnJlY3Rpb24pDQojU2hvdyB0aGUgRm9ybQ0KJEZvcm0xLlNob3dEaWFsb2coKXwgT3V0LU51bGwNCg0KfSAjRW5kIEZ1bmN0aW9uDQoNCkZ1bmN0aW9uIFNlbmRNZXNzYWdlU2xhY2sgew0KDQoj0L/QvtC70YPRh9Cw0LXQvCDQtNCw0L3QvdGL0LUg0LTQu9GPIFNsYWNrDQokQm90VXNlck9BdXRoQWNjZXNzVG9rZW4gPSAieG94Yi00NjMzNDU2MzY2NzQtNTExNTkyNzE4MzIyLWhqeWFZY3VyTm1XQlFyaHdOZ1dDWWltbCINCiRoZWFkZXJzX3NsYWNrID0gTmV3LU9iamVjdCAiU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWMuRGljdGlvbmFyeVtbU3RyaW5nXSxbU3RyaW5nXV0iDQokaGVhZGVyc19zbGFjay5BZGQoIkF1dGhvcml6YXRpb24iLCJCZWFyZXIgJCgkQm90VXNlck9BdXRoQWNjZXNzVG9rZW4pIikNCiRoZWFkZXJzX3NsYWNrLkFkZCgiQ29udGVudC1UeXBlIiwgImFwcGxpY2F0aW9uL2pzb247Y2hhcnNldD1VVEYtOCIpDQoj0L/QvtC70YPRh9Cw0LXQvCDRgdC/0LjRgdC+0Log0LLRgdC10YUg0L/QvtC70YzQt9C+0LLQsNGC0LXQu9C10LkgU2xhY2sNCiPQn9C+0LvRg9GH0LDQtdC8INC/0LXRgNCy0YPRjiDQv9Cw0YDRgtC40Y4g0LrQvtC90YLQsNC60YLQvtCyDQokcmVxdWllc3RsaXN0ID0gSW52b2tlLVJlc3RNZXRob2QgLU1ldGhvZCBHZXQgLXVyaSAgImh0dHBzOi8vc2xhY2suY29tL2FwaS91c2Vycy5saXN0IiAtSGVhZGVycyAkaGVhZGVyc19zbGFjaw0KJHJlcXVpZXN0bGlzdC5yZXNwb25zZV9tZXRhZGF0YS5uZXh0X2N1cnNvcg0KJHJlcXVpZXN0ID0gQCgpDQokcmVxdWllc3QgKz0gJHJlcXVpZXN0bGlzdC5tZW1iZXJzDQpkbyB7DQogICAgICAgICRyZXF1aWVzdGxpc3QgPSBJbnZva2UtUmVzdE1ldGhvZCAtTWV0aG9kIEdldCAtdXJpICAiaHR0cHM6Ly9zbGFjay5jb20vYXBpL3VzZXJzLmxpc3Q/Y3Vyc29yPSQoJHJlcXVpZXN0bGlzdC5yZXNwb25zZV9tZXRhZGF0YS5uZXh0X2N1cnNvcikiIC1IZWFkZXJzICRoZWFkZXJzX3NsYWNrDQogICAgICAgICRyZXF1aWVzdGxpc3QucmVzcG9uc2VfbWV0YWRhdGEubmV4dF9jdXJzb3INCiAgICAgICAgJHJlcXVpZXN0ICs9ICRyZXF1aWVzdGxpc3QubWVtYmVycw0KfQ0Kd2hpbGUgKCAkcmVxdWllc3RsaXN0LnJlc3BvbnNlX21ldGFkYXRhLm5leHRfY3Vyc29yIC1uZSAiIiApDQoNCiMg0L7RgtC/0YDQsNCy0LrQsCDRgtC10YHRgtC+0LLQvtCz0L4g0YHQvtC+0LHRidC10L3QuNGPDQppZiAoJG1DaGVja0JveDEuQ2hlY2tlZCAtZXEgJHRydWUpIHsNCiRhdHQgPSBAIg0Kew0KImNoYW5uZWwiOiAidGVzdG1lc3NhZ2Vza2FjayIsDQoiaWNvbl9lbW9qaSI6ICI6ZmlyZTE6IiwNCiJ0ZXh0IjogIiQoJEdsb2JhbDp4KSIsDQoidXNlcm5hbWUiOiAiQ0NCb3QiDQp9DQoiQA0KSW52b2tlLVJlc3RNZXRob2QgLU1ldGhvZCBQb3N0IC1VcmkgaHR0cHM6Ly9zbGFjay5jb20vYXBpL2NoYXQucG9zdE1lc3NhZ2UgLUJvZHkgJGF0dCAtSGVhZGVycyAkaGVhZGVyc19zbGFjayAtQ29udGVudFR5cGUgImFwcGxpY2F0aW9uL2pzb247Y2hhcnNldD1VVEYtOCINCn0gI2VuZCBpZg0KDQojINC+0YLQv9GA0LDQstC60LAg0YHQvtC+0LHRidC10L3QuNGPDQpmb3JlYWNoICgkQ2hlY2tCb3ggaW4gJENoZWNrQm94ZXMpIHsNCiAgICBpZiAoJENoZWNrQm94LkNoZWNrZWQgLWVxICR0cnVlKSB7DQogICAgICAgICRpID0gMA0KICAgICAgICAkcmVxdWllc3Rfb2JqID0gJHJlcXVpZXN0LldoZXJleyRfLnByb2ZpbGUudGl0bGUgLWVxICRDaGVja0JveC5OYW1lIC1hbmQgJF8uZGVsZXRlZCAtZXEgJGZhbHNlfQ0KICAgICAgICAkcmVxdWllc3Rfb2JqLkZvcmVhY2h7DQogICAgICAgICAgICAkYXR0ID0gQCINCiAgICAgICAgICAgIHsNCiAgICAgICAgICAgICJjaGFubmVsIjogIiQoJF8uSUQpIiwNCiAgICAgICAgICAgICJpY29uX2Vtb2ppIjogIjpmaXJlMToiLA0KICAgICAgICAgICAgInRleHQiOiAiJCgkR2xvYmFsOngpIiwNCiAgICAgICAgICAgICJ1c2VybmFtZSI6ICJDQ0JvdCINCiAgICAgICAgICAgIH0NCiJADQogICAgICAgICAgICBJbnZva2UtUmVzdE1ldGhvZCAtTWV0aG9kIFBPU1QgLVVyaSBodHRwczovL3NsYWNrLmNvbS9hcGkvY2hhdC5wb3N0TWVzc2FnZSAtQm9keSAkYXR0IC1IZWFkZXJzICRoZWFkZXJzX3NsYWNrIC1Db250ZW50VHlwZSAiYXBwbGljYXRpb24vanNvbjtjaGFyc2V0PVVURi04Ig0KICAgICAgICAgICAgJGkgKysNCiAgICAgICAgICAgIFdyaXRlLVByb2dyZXNzIC1BY3Rpdml0eSAi0J7RgtC/0YDQsNCy0LrQsCDRgdC+0L7QsdGJ0LXQvdC40LkgJCgkQ2hlY2tCb3guVGV4dCkgLiAuIC4iIC1TdGF0dXMgItCe0YLQv9GA0LDQstC70LXQvdC+OiAkaSDQuNC3ICQoJHJlcXVpZXN0X29iai5Db3VudCkiIC1QZXJjZW50Q29tcGxldGUgKCgkaS8kcmVxdWllc3Rfb2JqLkNvdW50KSAqIDEwMCkNCiAgICAgICAgfQ0KICAgICAgICBXcml0ZS1Qcm9ncmVzcyAtQWN0aXZpdHkgItCe0YLQv9GA0LDQstC60LAg0YHQvtC+0LHRidC10L3QuNC5ICQoJENoZWNrQm94LlRleHQpIiAtU3RhdHVzICLQl9Cw0LLQtdGA0YjQtdC90LAiIC1Db21wbGV0ZWQNCiAgICB9DQp9DQoNCn0gI0VuZCBGdW5jdGlvbg0KDQpHZW5lcmF0ZUZvcm0="));
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
