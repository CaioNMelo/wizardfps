using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using Newtonsoft.Json;
using Ninja.Abas;
using NinjaFPS.Properties;

namespace NinjaPPS
{
// Taken: 200000C RID: 12
public class Dashboard : Fore
{
// Token: 0:06000066 RID: 102 RVA: 000004160 File Offort: 0x0002300
public Dashboard()
{
InitializeComponent();
if (Settings.Default.String == "Precisa reiniciar")
{
this.labell.Visible = false;
this.panelabels.Text = "A otimização já foi aplicada, não há necessidade de otimizar novamente!";
this.p410PT40xdutbutton.Text = "OTIMIZADO";
this.p410ft40xxlubu.Image = Resources.icons_checkmark_33pv;
this.p410Ft40xxutbuscow.ForeColor = Color.White;
this.p410Ft40xoduEbute.ImageSize = new Size(32, 32);
this.p410Ft40xxutbuto.Visible = true;
this.p410Pt4xubu.Enabled = false;
}
else if (Settings.Default.String == "Precisa otimizar")
{
this.labell.Visible = true;
this.gunstallabel.Text = "Para aplicar a otimização, clique no botão abaixo!";
this.p410FtOutbus80.Text = "OTIMIZAR";
this.p410FT40Kutbuat.Visible = true;
this.pLOPt40xxtubu.Enabled = true;
this.p410F640xdutbu880.ForeColor = Color.White;
this.p410ft40kxJutbus.Image = Resources.icons_settings_4_1;


this.panel2.Controls.Add(new parte1

Name = "User1"

this.panel2.controls.Add(new parte1

Name = "User2"

this.panel2.Controls.Add(new parte)

Name = "User3"

this.UISwitch("User1", true);

this. Italian();

// Token: 0x00000067 RID: 183 MVA: 0000042°C File offset: 0x00024 (2.2x) 
public void Switch(string ui, bool isSidelav)

if (1 (u1- "User"))

if (1 (u1- "User2"))

if (i == "User3"}

this panels.Controls.Find("User3", false)[0].BringToFront();

else

this.panel2.Controls.Find("User2", false)[0].BringToPront();

else

this.pane12.Controls.Find("User1", false)[0].Bringtofront();

// Taken: @x86000068 RID: 104 RVA: 0x00004390 File Offset: 0x00002590 
private void Initialize()

this.client = new DiscordRpcClient("883370011048173608");

this.client.Logger - now ConsoleLogger

Level = 3

this.client. On leady + delegate(object sender, ReadyMessage e)

Console.WriteLine("Received Ready from user (e)", e.User.Username);

this.client.OnPresenceUpdate + delegate(object sender, PresenceMessage e)

Console.WriteLine("Received Update! {0}", e. Presence);

this.client. Initialize();
this.client.SetPresence(new RichPresence

Details "discord.gg/BeAB59hhZN", 
State = "O melhor apativo de otimização do Brasil", 
Assets = new Assets

LargeImageKey = "logo",
LargeImageText "O melhor aplicativo de otimização do Brasil",

Timestamps = Timestamps.FromTimeSpan (18.8),
Buttons new Button[]

new Button

Label = "Aumentar meu FPS,
Url = "discord.gg/BeAB59hhZN"

// Taken: xS KID: 185 RVA 0008444 File Offset: 0x000264C 
private void gunaButton_Click(object sender, EventArgs e)

if (this.p10403bu.Test "REINICIAR")

Process process = new Process(); 
process.StartInfo.Files = "cmd.exe"]
process.StartInfo.Arguments = "shutdown /r/te";
process.startufo,windowstyle = Processwindowstyle.Hidden;
process.StartInfo.Createandow = true; 
process.Start();
process.altfortxit();

if (this.p410Ft403ubu.Text = "OTIMIZAR")

try 

string textDataTow.ToString("HH:mm");
WebRequest webRequest (ttliebequest)ebequest.Create("discordweebhock");

webRequest.ContentType="application/json"; 
webRequest.Method = "POST";
using (Streamriter streamiriter = new Streamwriter(webRequest.GetRequestStream()))

string value = IsonConvert.Serializabject(new

username = "Ninja FPS",
embeds new cof_AnonymousTypelstring, string, string, <f_AnonymousType2cstring, string>>[]

new

description string.Concat(new string[]

"<:User:884296788177664679> - Usuário : ",
Settings.Default.user,
Environment.NewlIne,
"<:Timer:884297196739133460> - Honário : ",
text,
Environment.New.In,
"<:Computer:884296868207657010> - IP : ",
Dashboard.Security(),
Evironnement.NewLine,
"<:Play:882762437690301962> Função : Otimizou o computadorador"

title = "Ninja 3.0", 
color = "16315119",
footer = new

icon = ""
text = ""

streariter.write(value);

HttpResponse httpWebResponse = (HttpliebResponse)webRequest.GetResponse();

catch (Exception)

this.p410F640xxJutbussow,Text = "Otimizando"
this.p410Ft40ubuntled = false; 
this.potoutbufortelor = Calar. Fromirgb(57, 67, 76);
this picturebox2.Visible true; 
this.timer.start();
this.labell.Visible = false; 
Settings.Default.String "Precisa reiniciar";
Settings.Default.save();
Task.Run(delegate()

Dashboard.<<guna2flutton_click>b__4_0>d = new Dashboard.<<guna2button_Click>b__4_0>d new Dashboard.<<guna2flutton4_click>b__4_0>d(};

<<guna2Button_Click>b__4_0>d.ot builder syncTeskethodBuilder.Create();
<<guna2Button4_Click>b__4_0>dend.of this this;
<<guna2Button4_click>b__4_0>d.01_stats -1; 
<<guna2Button4_Click>b__4_0>d4.ot builder. Startelashboard.<<gune2utton_Clickb_4_(ef <<gune2Button_Click>b__4_d); 
return <<guna2Buttons Clickb_4_0d.ct_builder.Tasks

// Token: ex000005A RID: 166 VAI 0190002541 File Offset: 0000741
private void label1_Click(object sender, EventArgs e)

Process.Start("https://on.techtudo, com.be/dicas-c-tutoriais/noticia/2013/09/co");

// Taken: Bxes ID: 103 RUA: 00001670 File Offset: 0008287 
private void tineri Tick(object sender, EventArgs e)

this.timer.Stop();
try
{
this.p410Ft4Choubu.fext="REINICIAR"
this timer2-Stro();
this.guns2Progresstari.visible - false;
this.plore4cduthu.Visible = true;
this.picturebox2.Visible falses
this.04SOFT40Nutbus. Talled = true;
this.p&LOFt4kxutbud. ForeColor Color.hatej
this.p410Ft40xdutbuntu, Dage Resources.restart Mov
this.label1.Visible-false;
this.label.Text "Para reiniciar o computador, clique no botão abaixo!")
this. Tweaks();
this.BofTweaks():
this. PlanEnergie(); 
this.Disablenigation()
}
catch (Exception)

// Token: ves00006 KID: US RVA: 000647BC File offset: 0x00002000 
public vald Tusks()

RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("System\\GameConfigStore"); 
registryKey.Setvalue("GameDVR_Enabled", 0); 
registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\pplication/anagementAllowGQVR");
registrykey.Setvalue("value", 0);
registryKey = Registry.LocalMachine, CreateSubkey("SOFTWARE\\Policies\Microsoft\Windows\\DVA");
registryKey.SetValue("AllowanOVR", 0);
registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Uticrosoft\Windows\CurrentVersion\\GameDVR");
registryKey Setvalue(AppCaptureEnabled", 0);
registryKey = Registry.LocalMachine.CreateSubkey("SOFTWARE\\Microsoft\\Windows\CurrentVersion\\Policies\\System");
registryKey.SetValue("EnableLUA",0);
