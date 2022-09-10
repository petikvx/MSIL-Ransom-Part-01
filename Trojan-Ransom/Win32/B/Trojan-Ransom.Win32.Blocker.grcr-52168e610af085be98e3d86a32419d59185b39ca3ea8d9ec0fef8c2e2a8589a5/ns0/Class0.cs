using System.Threading;
using System.Windows.Forms;
using YoutubeFeedUpdater.Classes;

namespace ns0;

internal class Class0 : ITask
{
	private readonly WebBrowser webBrowser_0;

	public Class0(WebBrowser webBrowser_1)
	{
		webBrowser_0 = webBrowser_1;
	}

	public void Run(TaskSystem taskSystem)
	{
		webBrowser_0.Navigate("javascript:void((function(){var a,b,c,e,f;f=0;a=document.cookie.split('; ');for(e=0;e<a.length&&a[e];e++){f++;for(b='.'+location.host;b;b=b.replace(/^(?:%5C.|[^%5C.]+)/,'')){for(c=location.pathname;c;c=c.replace(/.$/,'')){document.cookie=(a[e]+'; domain='+b+'; path='+c+'; expires='+new Date((new Date()).getTime()-1e11).toGMTString());}}}})())");
		Thread.Sleep(2000);
	}
}
