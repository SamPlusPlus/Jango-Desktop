using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Web;


namespace Jango_Desktop
{
    public class Track
    {
        private readonly Skybound.Gecko.GeckoDocument _gDoc;

        public Track(Skybound.Gecko.GeckoDocument gDoc)
        {
            this._gDoc = gDoc;
        }

        public string TimeRemaining 
        {
           get
           {
               var timerEle = _gDoc.GetElementById("timer");
               if (timerEle != null)
               {
                   string timeRemaing = timerEle.InnerHtml.Trim().Replace("-", "").Replace(":", "");
                   int result;
                   if(int.TryParse(timeRemaing, out  result))
                   {
                       TrackLength = Math.Max(result, TrackLength);
                       TimeRemainingAtInt = result;
                   }
                   return timerEle.InnerHtml.Trim();
               }
               TrackLength = 0;
               return null;

           }
        }

        public int TrackLength { get; set; }

        public int TimeRemainingAtInt
        {
            get; set;
        }

        public string Artist 
        {
            get
            {
                var artistEle = _gDoc.GetElementById("player_current_artist");
                if(artistEle != null)
                {
                    return CleanHtml(artistEle.InnerHtml.Trim());
                }
                return null;

            }
        }

        public string Song
        {
            get
            {
                var songEle = _gDoc.GetElementById("current-song");
                if (songEle != null)
                {
                    return CleanHtml(songEle.InnerHtml.Trim());
                }
                return null;
            }
        }

        public string AlbumArtUrl
        {

            get
            {
                string src = string.Empty;
                var albumEle = _gDoc.GetElementById("player_main_pic_img");
                if (albumEle != null)
                {
                    src = albumEle.GetAttribute("src").Trim('/');

                    if (!src.StartsWith("http://"))
                    {
                       return "http://" + src;
                    }
            }
                return src;
            }
        }

        public bool IsPaused
        {
            get
            {
                var playeroutterbox = _gDoc.GetElementById("player-outer-box");
                if (playeroutterbox != null)
                {
                    return playeroutterbox.ClassName.Contains("paused");
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            if (Artist != null && Song != null && TimeRemaining != null)
            {
                return String.Format("{0}:{1} {2}", Song, Artist, TimeRemaining);
            }
            return String.Empty;
        }

        /// <summary>
        /// This function will remove basic html tags from a string.
        /// </summary>
        /// <param name="html">input string containing basic html tags</param>
        /// <returns>string with html tags removed</returns>
        private string CleanHtml(string html)
        {
            return HttpUtility.HtmlDecode(Regex.Replace(html, @"<[^>]*>", String.Empty));
        }
    }
}
