using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NuGet.Common;

public class _7qFtAalbLl
{
	[AsyncStateMachine(typeof(_003CProcessAsync_003Ed__0))]
	public static Task<string> uwweldwO46(Func<Task<Stream>> VjdT9LIeWQ, Func<string, string> IfTpF3MWuC, CancellationToken _6TNONAXQAl)
	{
		obBb57aXmL stateMachine = default(obBb57aXmL);
		stateMachine.GDfzsauzAg = VjdT9LIeWQ;
		stateMachine.vuORgVx427 = IfTpF3MWuC;
		stateMachine.TSEf7k9tcK = _6TNONAXQAl;
		stateMachine.IIwwwKaGTf = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._3RKe4fPIuu = -1;
		AsyncTaskMethodBuilder<string> iIwwwKaGTf = stateMachine.IIwwwKaGTf;
		iIwwwKaGTf.Start(ref stateMachine);
		return stateMachine.IIwwwKaGTf.Task;
	}

	public static string _0BwYafsBAa(Stream _8XstZyyda9, Func<string, string> ieQzDXkZOH)
	{
		if (_8XstZyyda9 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (ieQzDXkZOH == null)
		{
			throw new ArgumentNullException("tokenReplacement");
		}
		string text;
		using (StreamReader streamReader = new StreamReader(_8XstZyyda9))
		{
			text = streamReader.ReadToEnd();
		}
		vZhHY12zyN vZhHY12zyN2 = new vZhHY12zyN(text);
		StringBuilder stringBuilder = new StringBuilder();
		while (true)
		{
			EFeFgFVY05 eFeFgFVY = vZhHY12zyN2.Bqdaa4WLbV();
			if (eFeFgFVY == null)
			{
				break;
			}
			if (eFeFgFVY.EaJ5HNFaYn == VFKEVC1drT.Variable)
			{
				string value = ieQzDXkZOH(eFeFgFVY.Yj6e6XN2YP);
				stringBuilder.Append(value);
			}
			else
			{
				stringBuilder.Append(eFeFgFVY.Yj6e6XN2YP);
			}
		}
		return stringBuilder.ToString();
	}
}
