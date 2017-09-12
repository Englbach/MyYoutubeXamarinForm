using System;

namespace Youtube
{
    public static class GlobalSettings
    {
        //Authentication
        public const string AuthenticationEndpoint="https://accounts.google.com/o/oauth2/v2/auth";
        public const string Client_ID="936293862456-1e3a521r9psh4u78qfmcitqu9tucjhkn.apps.googleusercontent.com";
        public const string Client_Serect="BkGkMyb_AxntccTLeHnq4yUo ";
        public const string Redirect_Uri = "";
        public const string Key = "AIzaSyDE6MXFK9rUUGcuAQVJ1kH3nQng4smBYz4";
        public const int MaxResult = 10;

        //****************************************Youtube request*********************************************
        #region Activities
        public const string Youtube_Activities="https://www.googleapis.com/youtube/v3/activities";
        #endregion

        #region Caption
        public const string Youtube_Caption="https://www.googleapis.com/youtube/v3/captions";
        public const string Youtube_Caption_Insert="https://www.googleapis.com/upload/youtube/v3/captions";
        public const string Youtube_Caption_Update="https://www.googleapis.com/upload/youtube/v3/captions";
        public const string Youtube_Caption_Download="https://www.googleapis.com/youtube/v3/captions/{0}";
        #endregion

        #region Channel Banners
        public const string Youtube_ChannelBanners_Insert="https://www.googleapis.com/upload/youtube/v3/channelBanners/insert";
        public const string Youtube_Channel="https://www.googleapis.com/youtube/v3/channels";
        public const string Youtube_Channel_Section="https://www.googleapis.com/youtube/v3/channelSections";
        #endregion

        #region Comment
        public const string Youtube_Comment="https://www.googleapis.com/youtube/v3/comments";
        public const string Youtube_Comment_Thread="https://www.googleapis.com/youtube/v3/commentThreads";
        #endregion

        #region Playlist
        public const string Youtube_PlayListItems="https://www.googleapis.com/youtube/v3/playlistItems";
        public const string Youtube_PlayList="https://www.googleapis.com/youtube/v3/playlists";
        #endregion

        #region Search
        public const string Youtube_Search="https://www.googleapis.com/youtube/v3/search";
        #endregion

        #region Subscription
        public const string Youtube_Subscription="https://www.googleapis.com/youtube/v3/subscriptions";
        #endregion

        #region Thumbnails
        public const string Youtube_Thumbnail="https://www.googleapis.com/upload/youtube/v3/thumbnails/set";
        #endregion

        #region Video Category
        public const string Youtube_VideoCategory="https://www.googleapis.com/youtube/v3/videoCategories";
        #endregion

        #region Video
        public const string Youtube_Video="https://www.googleapis.com/youtube/v3/videos";
        public const string Youtube_Insert_Video="https://www.googleapis.com/upload/youtube/v3/videos";
        public const string Youtube_Rating_Video="https://www.googleapis.com/youtube/v3/videos/rate";
        public const string Youtube_GetRating_Video="https://www.googleapis.com/youtube/v3/videos/getRating";
        #endregion

    }
}