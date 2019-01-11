using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using SplashScreen;

namespace SchoolManager
{
    class Timetable
    {
        public static string CertHash;
        public static bool Compareversions(string version1, string version2)
        {
            //compares the versions and returns true if version 2 is greater than version 1
            string[] v1 = version1.Split('.');
            string[] v2 = version2.Split('.');
            int i;
            for (i = 0; i < v1.Length; i++)
            {
                int v1Int = int.Parse(v1[i]);
                if (v2.Length == i)
                {
                    return false;
                }

                if (int.Parse(v2[i]) > v1Int)
                {
                    return true;
                }
            }

            for (i = v1.Length; i < v2.Length; i++)
            {
                if (int.Parse(v2[i]) > 0)
                    return true;
            }

            return false;
        }

        public static void Tcpsend(string message, Stream strs)
        {
            if (strs.CanWrite)
            {
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(message);
                strs.Write(ba, 0, ba.Length);
                strs.Flush();
            }
        }

        public static string Tcpreceive(Stream stms)
        {
            Byte[] data = new Byte[256];
            if (stms.CanRead)
            {
                Int32 bytes = stms.Read(data, 0, data.Length); //(**This receives the data using the byte method**)
                return Encoding.ASCII.GetString(data, 0, bytes);
            }
            return "";
        }

        public static Font Fontexists(string Fontname, string directory,float size)
        {
            Font test = new Font(Fontname, size);
            if(test.Name!= "Microsoft Sans Serif"||Fontname=="")
                return test;
            try
            {
                PrivateFontCollection collection = new PrivateFontCollection();
                if (File.Exists(directory + "/" + Fontname + ".ttf"))
                collection.AddFontFile(directory + "/" + Fontname+".ttf");
                if (File.Exists(directory + "/" + Fontname + ".otf"))
                collection.AddFontFile(directory + "/" + Fontname + ".otf");
                if (collection.Families.Length>0)
                return new Font(collection.Families[0], size);
            }
            catch
            {
                //Failed
            }
            return test;
        }

        public static string SSLreceive(SslStream sslStream)
        {
            // Read the  message sent by the client.
            // The client signals the end of the message using the
            // "<EOF>" marker.
            byte[] buffer = new byte[2048];
            StringBuilder messageData = new StringBuilder();
            int bytes = -1;
            do
            {
                // Read the client's test message.
                try
                {
                    bytes = sslStream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    //Connection closed
                }
                // Use Decoder class to convert from bytes to UTF8
                // in case a character spans two buffers.
                Decoder decoder = Encoding.UTF8.GetDecoder();
                char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
                decoder.GetChars(buffer, 0, bytes, chars, 0);
                messageData.Append(chars);
                // Check for EOF or an empty message.
                if (messageData.ToString().IndexOf("<EOF>") != -1)
                {
                    break;
                }
            } while (bytes != 0);
            return messageData.ToString().Replace("<EOF>","");
        }

        public static List<DateTime> ParseDates(string k)
        {
            List<DateTime> TmpTimes = new List<DateTime>();
                string[] spl = k.Split(' ');
                for (int i = 1; i < spl.Length; i++)
                {
                    string[] sort = spl[i].Split('/');
                    DateTime p = new DateTime(int.Parse(spl[0]), int.Parse(sort[1]), int.Parse(sort[0]));
                    TmpTimes.Add(p);
                }
            TmpTimes.Sort();
            TmpTimes.Reverse();
            return TmpTimes;
        }

        public static Tuple<string, bool> UpdateTimetable(string user, string pass)
        {
            try
            {
                MyWebClient web = new MyWebClient();
                web.Proxy = null;
                CredentialCache myCache = new CredentialCache();
                if (user.Trim() != "" && pass.Trim() != "")
                {
                    myCache.Add(new Uri("https://intranet.trinity.vic.edu.au/"), "NTLM",
                        new NetworkCredential(user, pass));
                    web.Credentials = myCache;
                }
                else
                {
                    web.Credentials = CredentialCache.DefaultNetworkCredentials;
                }

                String html = web.DownloadString("https://intranet.trinity.vic.edu.au/timetable/default.asp");
                Match match = Regex.Match(html, "<input type=\"hidden\" value=\"(.*?)\" id=\"callType\">",
                    RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    Program.Calltype = match.Groups[1].Value;
                }

                match = Regex.Match(html, "<input type=\"hidden\" value=\"(.*?)\" id=\"synID\">",
                    RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    Program.SettingsData.SynID = Convert.ToInt32(match.Groups[1].Value);
                }

                match = Regex.Match(html, "value=\"(.*?)\" id=\"curTerm\"", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    Program.SettingsData.Curterm = Convert.ToInt32(match.Groups[1].Value);
                }

                string sqlquery = "";
                if (Program.Calltype == "student")
                    sqlquery =
                        "%20AND%20TD.PeriodNumber%20>=%200%20AND%20TD.PeriodNumberSeq%20=%201AND%20(stopdate%20IS%20NULL%20OR%20stopdate%20>%20getdate())--";
                if (Program.SettingsData.Curterm == 0)
                {
                    for (int i = 4; i > 0; i--)
                    {
                        html = web.DownloadString(
                            "https://intranet.trinity.vic.edu.au/timetable/getTimetable1.asp?synID=" + Program.SettingsData.SynID +
                            "&year=" + DateTime.Now.Year + "&term=" + i + sqlquery + "&callType=" + Program.Calltype);
                        if (html.Length > 10)
                        {
                            Program.SettingsData.Curterm = i;
                            html = html.Substring(html.IndexOf("["));
                            break;
                        }
                    }
                }
                else
                {
                    html = web.DownloadString("https://intranet.trinity.vic.edu.au/timetable/getTimetable1.asp?synID=" +
                                              Program.SettingsData.SynID + "&year=" + DateTime.Now.Year + "&term=" +
                                              Program.SettingsData.Curterm + sqlquery + "&callType=" +
                                              Program.Calltype);
                    html = html.Substring(html.IndexOf("["));
                }

                List<Period> timetableList = JsonConvert.DeserializeObject<List<Period>>(html);
                using (StreamWriter file = File.CreateText(Program.SETTINGS_DIRECTORY + "/Timetable.Json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(file, timetableList);
                }

                Int16 colorint = 0;
                Program.TimetableList.Clear();
                Dictionary<string, int> yearlevel = new Dictionary<string, int>();
                for (int i = 1; i < 13; i++)
                {
                    string p = i < 10 ? "0" : "";
                    yearlevel.Add(p+i, 0);
                }
                foreach (var v in timetableList)
                {
                    if (!Program.ColorRef.ContainsKey(v.ClassCode))
                    {
                        Program.ColorRef.Add(v.ClassCode, Program.ColourTable[colorint]);
                        colorint++;
                        if (colorint >= Program.ColourTable.Count)
                            colorint = 0;
                    }

                    Program.TimetableList.Add(v.DayNumber.ToString() + v.PeriodNumber, v);
                    if (yearlevel.ContainsKey(v.ClassCode.Substring(0, 2)))
                        yearlevel[v.ClassCode.Substring(0, 2)] += 1;
                }

                web.Dispose();
                //Analytics reporting
                string currentyear = yearlevel.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                if (currentyear == "12"&& yearlevel["12"] == 0)
                { 
                    //do nothing
                }
                else
                    Program.SettingsData.CurrentYearlevel = int.Parse(currentyear);
            }
            catch (WebException ee)
            {
                if (ee.Message.Contains("Unauthorized"))
                {
                    return new Tuple<string, bool>("Unauthorised", false);
                }

                return new Tuple<string, bool>(ee.Message, false);
            }
            catch (Exception ee)
            {
                return new Tuple<string, bool>(ee.Message, false);
            }
            return new Tuple<string, bool>("Successful!", true);
        }
        public static bool ValidateServerCertificate(
            object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            CertHash = certificate.GetCertHashString();
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                Console.WriteLine(sslPolicyErrors.ToString());
                return true;
            }

            if (Program.SettingsData.Thumbprintlist.Contains(certificate.GetCertHashString()))
                return true;
            Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
            // refuse connection
            return false;
        }
    }

    
    public struct Period
    {
        public int DayNumber;
        public int PeriodNumber;
        public int PeriodNumberSeq;
        public int DefinitionPeriodNumber;
        public string DefinitionTimeFrom;
        public string DefinitionTimeTo;
        public string ClassCode;
        public string ClassDescription;
        public int StaffId;
        public string SchoolStaffCode;
        public string Room;

        public Period(int daynumber, int periodnumber, int periodnumberseq, int definitionperiodnumber,
            string definitiontimefrom, string definitionTimeTo, string classcode, string classdescription, int staffid,
            string schoolstaffcode, string room)
        {
            DayNumber = daynumber;
            PeriodNumber = periodnumber;
            PeriodNumberSeq = periodnumberseq;
            DefinitionPeriodNumber = definitionperiodnumber;
            DefinitionTimeFrom = definitiontimefrom;
            DefinitionTimeTo = definitionTimeTo;
            ClassCode = classcode;
            ClassDescription = classdescription;
            StaffId = staffid;
            SchoolStaffCode = schoolstaffcode;
            Room = room;
        }
    }

    public struct Themedata
    {
        [DefaultValue("Theme")]
        public string Name;
        [DefaultValue("1.0")]
        public string Version;
        [DefaultValue("Unknown")]
        public string Author;

        public string Directory;

        public Image Timetableimage
        {
            get
            {
                if (_Timetableimage == null)
                    return Program.Defaulttheme.Timetableimage;
                return _Timetableimage;
            }
            set => _Timetableimage = value;
        }

        public Image _Timetableimage
        {
            get;
            private set;
        } 
        public Image Clockimage
        {
            get
            {
                if (_Clockimage == null)
                    return Program.Defaulttheme.Clockimage;
                return _Clockimage;
            }
            set => _Clockimage = value;
        }
        public Image _Clockimage
        {
            get;
            private set;
        }
        public Image Preview
        {
            get
            {
                if (_Preview == null)
                    return Program.Defaulttheme.Preview;
                return _Preview;
            }
            set => _Preview = value;
        }
        public Image _Preview
        {
            get;
            private set;
        }
        public Image ExtendedImage
        {
            get
            {
                if (_ExtendedImage == null)
                    return Program.Defaulttheme.ExtendedImage;
                return _ExtendedImage;
            }
            set => _ExtendedImage = value;
        }

        public Image _ExtendedImage
        {
            get;
            private set;
        }
        public List<Drawstrings> Drawlist;
        public RectangleF Extendedbutton;
        public List<Drawstrings> ExtendDrawlist;

        public void Disposable()
        {
            //safe disposal
            _Preview?.Dispose();
            _Clockimage?.Dispose();
            _ExtendedImage?.Dispose();
            _Timetableimage?.Dispose();
            Drawlist = null;
            ExtendDrawlist = null;
        }

        public Themedata(Image timetableimage,Image clockimage,Image extend)
        {
            Name = "Default";
            Version = "1";
            Author = "WilliamC";
            Directory = @"C:\";
            _Timetableimage = timetableimage;
            _Clockimage = clockimage;
            _Preview = clockimage;
            _ExtendedImage = extend;
            Extendedbutton = new RectangleF(186,3,20,20);
            ExtendDrawlist = new List<Drawstrings>{new Drawstrings("<User>",10,10,14,0,255,255,255,255), new Drawstrings("<ClassA0>", 10, 34, 14, 0, 255, 255, 255, 255), new Drawstrings("<Room0>", 148, 34, 14, 0, 255, 255, 255, 255), new Drawstrings("<ClassA1>", 10, 60, 14, 0, 255, 255, 255, 255), new Drawstrings("<Room1>", 148, 60, 14, 0, 255, 255, 255, 255), new Drawstrings("<ClassA2>", 10, 86, 14, 0, 255, 255, 255, 255), new Drawstrings("<Room2>", 148, 86, 14, 0, 255, 255, 255, 255), new Drawstrings("<ClassA3>", 10, 112, 14, 0, 255, 255, 255, 255), new Drawstrings("<Room3>", 148, 112, 14, 0, 255, 255, 255, 255), new Drawstrings("<ClassA4>", 10, 138, 14, 0, 255, 255, 255, 255), new Drawstrings("<Room4>", 148, 138, 14, 0, 255, 255, 255, 255), new Drawstrings("<ClassA5>", 10, 164, 14, 0, 255, 255, 255, 255), new Drawstrings("<Room5>", 148, 164, 14, 0, 255, 255, 255, 255), new Drawstrings("<ClassA6>", 10, 190, 14, 0, 255, 255, 255, 255), new Drawstrings("<Room6>", 148, 190, 14, 0, 255, 255, 255, 255) };
            Drawlist = new List<Drawstrings>{new Drawstrings("Day <CurDay>",2,65,8,-90,255,255,255,255), new Drawstrings("<GoTo><ClassA>", 10, 2, 14, 0, 255, 255, 255, 255), new Drawstrings("<Hours>:<Minutes>:<Seconds>", 10, 40, 18, 0, 255, 255, 255, 255), new Drawstrings("<Room>", 140, 40, 18, 0, 255, 255, 255, 255) };
        }
    }

    public class Drawstrings
    {
        [DefaultValue("Text")]
        public string Text;
        public Point Position;
        [DefaultValue(8)]
        public int Size;
        [DefaultValue(0)]
        public float Rotation;
        [DefaultValue("255,255,255,255")]
        public Color Colour;
        [DefaultValue("")]
        public string Fontname;
        [DefaultValue(null)]
        public Font FontCache;

        public Drawstrings()
        {
            //no generation
        }
        public Drawstrings(string text,Point pos,int size,float rotation,Color colour)
        {
            Text = text;
            Position = pos;
            Size = size;
            Rotation = rotation;
            Colour = colour;
        }
        public Drawstrings(string text, int x,int y, int size, float rotation, int a, int r, int g,int b)
        {
            Text = text;
            Position = new Point(x,y);
            Size = size;
            Rotation = rotation;
            Colour = Color.FromArgb(a, r, g, b);
        }
    }

    public class Syntaxserializer
    {
        private List<Period> _periods = new List<Period>();
        private Period _pc;
        private string _hours;
        private string _minutes;
        private string _seconds;
        public bool End;
        private string _goto;
        private string _label;

        public string Process(string text)
        {
            text = text.Replace("<CurDay>", Program.curDay.ToString());
            text = text.Replace("<Hours>", _hours);
            text = text.Replace("<Minutes>", _minutes);
            text = text.Replace("<Seconds>", _seconds);
            text = text.Replace("<ClassA>", _label);
            text = text.Replace("<ClassD>", _pc.ClassDescription);
            text = text.Replace("<ClassC>", _pc.ClassCode);
            text = text.Replace("<Room>", _pc.Room);
            text = text.Replace("<TeacherC>", _pc.SchoolStaffCode);
            text = text.Replace("<User>", Environment.UserName);
            text = text.Replace("<ID>", Program.SettingsData.SynID.ToString());
            text = text.Replace("<GoTo>", _goto);
            for (int i = 0; i < 7; i++)
            {
                text = text.Replace("<ClassA"+i+">", _periods[i].ClassDescription.Length > 12 ? _periods[i].ClassCode : _periods[i].ClassDescription);
                text = text.Replace("<Room" + i + ">",_periods[i].Room);
                text = text.Replace("<ClassD" + i + ">", _periods[i].ClassDescription);
                text = text.Replace("<ClassC" + i + ">", _periods[i].ClassCode);
                text = text.Replace("<Teacher" + i + ">", _periods[i].SchoolStaffCode);
            }
            return text;
        }

        public Syntaxserializer(List<string> temp,int currentday)
        {
            double timeleft = Int32.Parse(temp[0]);
            if (temp[2] == "End" && Program.SettingsData.Hideonend)
                End = true;
            if (Math.Floor(timeleft / 3600) < 10)
            {
                _hours = "0" + (Math.Floor(timeleft / 3600));
                timeleft %= 3600;
            }
            else
            {
                _hours = (Math.Floor(timeleft / 3600)).ToString();
                timeleft %= 3600;
            }

            if (Math.Floor(timeleft / 60) < 10)
            {
                _minutes = "0" + (Math.Floor(timeleft / 60));
            }
            else
            {
                _minutes = (Math.Floor(timeleft / 60)).ToString();
            }

            if (Math.Floor(timeleft % 60) < 10)
            {
                _seconds = "0" + (timeleft % 60);
            }
            else
            {
                _seconds = (timeleft % 60).ToString();
            }

            _label = temp[2];
            if (temp[2].StartsWith("Go to"))
            {
                _label = _label.Replace("Go to ", "");
                _goto = "Go to ";
            }
            if (Program.TimetableList.ContainsKey(currentday + "" + temp[2].Substring(temp[2].Length - 1)))
            {
                _pc = Program.TimetableList[currentday + "" + temp[2].Substring(temp[2].Length - 1)];
                if (temp[2].StartsWith("Period") || temp[2].StartsWith("Form") || temp[2].StartsWith("Go to"))
                {
                    _label = _pc.ClassDescription.Length > 12 ? _pc.ClassCode : _pc.ClassDescription;
                }
            }
            else
            {
                _pc.ClassCode = temp[2];
                _pc.ClassDescription = temp[2];
            }

            for (int i = 0; i < 7; i++)
            {
                _periods.Add(Program.TimetableList.ContainsKey(currentday + "" + i)
                    ? Program.TimetableList[currentday + "" + i]
                    : new Period(3, i, 1, 1, "10", "11", "", "", 0, "", ""));
            }
        }
    }

    public class Settingstruct
    {
        [DefaultValue("2017-8-28T00:00:00")] public DateTime Referencedayone;
        [DefaultValue("2017-8-28T00:00:00")] public DateTime EarlyDate;
        [DefaultValue("2017 28/8")] public string TermOnes;
        public string User;
        [DefaultValue(false)] public bool Dev;
        [DefaultValue(true)] public bool Alwaystop;
        [DefaultValue(0)] public int Curterm;
        [DefaultValue(0)] public int Hideset;
        [DefaultValue(0)] public int TimeOffset;
        [DefaultValue(0)] public int Dayoffset;
        [DefaultValue(true)] public bool Doubles;
        [DefaultValue(true)] public bool Hideonend;
        [DefaultValue("Default")] public string Theme;
        [DefaultValue(0)] public int Errors;
        [DefaultValue(0)] public int SynID;
        [DefaultValue(0)] public int CurrentYearlevel;
        [DefaultValue("0")] public string UniID;
        [DefaultValue(@"https://outlook.office365.com/owa/calendar/2565f03a392b4aa7ae08559caf271bc8@trinity.vic.edu.au/7df612fa5cb549e993a058753de347464943400756469956671/calendar.ics")] public string Calendarlink;
        [DefaultValue(default(List<string>))]public List<string> Thumbprintlist;

        public Settingstruct()
        {
            User = Environment.UserName;
            Referencedayone = new DateTime(2017, 8, 28, 0, 0, 0);
            EarlyDate = new DateTime(2017, 8, 2, 0, 0, 0);
            Dev = false;
            Curterm = 0;
            Errors = 0;
            Alwaystop = true;
            TermOnes = "2017 28/8";
            Hideset = 0;
            Dayoffset = 0;
            TimeOffset = 0;
            SynID = 0;
            Doubles = true;
            Hideonend = true;
            CurrentYearlevel = 0;
            Theme = "Default";
            Calendarlink =
                @"https://outlook.office365.com/owa/calendar/2565f03a392b4aa7ae08559caf271bc8@trinity.vic.edu.au/7df612fa5cb549e993a058753de347464943400756469956671/calendar.ics";
            UniID = "0";
            Thumbprintlist = new List<string>();
        }
    }

    public class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = (WebRequest) base.GetWebRequest(address);

            if (request is HttpWebRequest)
            {
                var myWebRequest = request as HttpWebRequest;
                myWebRequest.CookieContainer = new CookieContainer();
                myWebRequest.AllowAutoRedirect = true;
                myWebRequest.MaximumAutomaticRedirections = 100;
                myWebRequest.UnsafeAuthenticatedConnectionSharing = true;
                myWebRequest.KeepAlive = true;
            }

            return request;
        }
    }
}
