using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Пара
    {
        string beginPara = DateTime.Now.ToShortTimeString();
        string endPara = DateTime.Now.ToShortTimeString();
        string beginBreak = DateTime.Now.ToShortTimeString();
        string endBreak = DateTime.Now.ToShortTimeString();
        public Пара() { }
        public Пара(string bP) { BeginPara = bP; }
        public Пара(string bP, string eP) { BeginPara = bP; EndPara = eP; }
        public Пара(string bP, string eP, string bB) { BeginPara = bP; EndPara = eP; EndBreak = bB; }
        public Пара(string bP, string eP, string bB, string eB, Смена смена) { BeginPara = bP; EndPara = eP; EndBreak = bB; EndBreak = eB; this.Cмена = смена; }

        public Смена Cмена { get; }
        public string BeginPara
        {
            get { return beginPara; }
            set
            {
                try
                {
                    Regex reg = new Regex(@"\b\d+\b", RegexOptions.IgnoreCase);
                    MatchCollection matches = reg.Matches(value);
                    string[] b = Array.Empty<string>();
                    int count = 0;
                    int n = 0;
                    foreach (Match match in matches.Cast<Match>())
                    {
                        Array.Resize(ref b, ++count);
                        b[n] = match.Value;
                        n++;
                    }
                    beginPara = DateTime.Now.ToString(b[0] + ":" + b[1]);
                }
                catch (Exception) { }
            }
        }
        public string EndPara
        {
            get { return endPara; }
            set
            {
                try
                {
                    Regex reg = new Regex(@"\b\d+\b", RegexOptions.IgnoreCase);
                    MatchCollection matches = reg.Matches(value);
                    string[] b = Array.Empty<string>();
                    int count = 0;
                    int n = 0;
                    foreach (Match match in matches.Cast<Match>())
                    {
                        Array.Resize(ref b, ++count);
                        b[n] = match.Value;
                        n++;
                    }
                    endPara = DateTime.Now.ToString(b[0] + ":" + b[1]);
                }
                catch (Exception) { }
            }
        }
        public string BeginBreak
        {
            get { return beginBreak; }
            set
            {
                try
                {
                    Regex reg = new Regex(@"\b\d+\b", RegexOptions.IgnoreCase);
                    MatchCollection matches = reg.Matches(value);
                    string[] b = Array.Empty<string>();
                    int count = 0;
                    int n = 0;
                    foreach (Match match in matches.Cast<Match>())
                    {
                        Array.Resize(ref b, ++count);
                        b[n] = match.Value;
                        n++;
                    }
                    beginBreak = DateTime.Now.ToString(b[0] + ":" + b[1]);
                }
                catch (Exception) { }
            }
        }
        public string EndBreak
        {
            get { return endBreak; }
            set
            {
                try
                {
                    Regex reg = new Regex(@"\b\d+\b", RegexOptions.IgnoreCase);
                    MatchCollection matches = reg.Matches(value);
                    string[] b = Array.Empty<string>();
                    int count = 0;
                    int n = 0;
                    foreach (Match match in matches.Cast<Match>())
                    {
                        Array.Resize(ref b, ++count);
                        b[n] = match.Value;
                        n++;
                    }
                    endBreak = DateTime.Now.ToString(b[0] + ":" + b[1]);
                }
                catch (Exception) { }
            }
        }
    }
}
