using System;
using SQLite;

namespace OFLNPlayer
{
    public class Video
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string title { get; set; }
        public string link { get; set; }
        public string storage { get; set; }
    }
}
