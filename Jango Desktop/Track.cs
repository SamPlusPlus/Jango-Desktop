using System;
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
                   return timerEle.InnerHtml.Trim();
               }
               return null;
           }
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
