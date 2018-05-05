using Foundation;
using System;
using UIKit;
using SQLite;
using System.IO;

namespace OFLNPlayer
{
    public partial class VideoViewController : UIViewController
    {

        public static string dbName = "OFLNPlayerOfficial";
        public static string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), dbName);


        public VideoViewController (IntPtr handle) : base (handle)
        {
        }

        protected string createDatabase(string path)
        {
            try
            {
                var connection = new SQLiteAsyncConnection(path);
                connection.CreateTableAsync<Video>();

                return "DB created";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }

           
        }

    }
}