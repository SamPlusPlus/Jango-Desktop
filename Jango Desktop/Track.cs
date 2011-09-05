using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jango_Desktop
{
    public class Track
    {
        private readonly Skybound.Gecko.GeckoDocument gDoc;

        public Track(Skybound.Gecko.GeckoDocument gDoc)
        {
            this.gDoc = gDoc;
        }

        public string TimeRemaining 
        {
           get{ return gDoc.GetElementById("timer").InnerHtml.Trim(); }
        } 

        public string Artist 
        {
            get{ return gDoc.GetElementById("player_current_artist").InnerHtml.Trim();}
        }

        public string Song
        {
            get { return gDoc.GetElementById("current-song").InnerHtml.Trim(); }
        }

        public override string ToString()
        {
            return String.Format("{0}:{1} {2}", Artist, Song, TimeRemaining);
        }
    }
}
