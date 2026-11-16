using System;
using System.Collections.Generic;

namespace AiToolsPortal.Models
{
    public class AiToolItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortTagline { get; set; }
        public string OfficialUrl { get; set; }
        public string Category { get; set; }
        public string BadgeColor { get; set; }
        public string IconClass { get; set; }
        
        /// <summary>
        /// Exact comprehensive one-paragraph description detailing how the tool works and how it helps the user.
        /// </summary>
        public string OneParagraphDescription { get; set; }
        
        public string HowItWorksDetails { get; set; }
        public string HowItHelpsDetails { get; set; }
        public List<string> KeyFeatures { get; set; }
        public List<string> PracticalUseCases { get; set; }
        public string SamplePrompt { get; set; }
        
        // YouTube Embed Information
        public string YouTubeVideoId { get; set; }
        public string YouTubeVideoTitle { get; set; }
        public string YouTubeEmbedUrl
        {
            get
            {
                return string.Format("https://www.youtube.com/embed/{0}?rel=0", YouTubeVideoId);
            }
        }
        public string YouTubeWatchUrl
        {
            get
            {
                return string.Format("https://www.youtube.com/watch?v={0}", YouTubeVideoId);
            }
        }

        public AiToolItem()
        {
            KeyFeatures = new List<string>();
            PracticalUseCases = new List<string>();
        }
    }

    public class AiToolsViewModel
    {
        public List<AiToolItem> Tools { get; set; }
        public List<string> Categories { get; set; }
        public string ActiveTab { get; set; }
        public string SearchQuery { get; set; }
        public string SelectedCategory { get; set; }

        public AiToolsViewModel()
        {
            Tools = new List<AiToolItem>();
            Categories = new List<string>();
        }
    }
}
