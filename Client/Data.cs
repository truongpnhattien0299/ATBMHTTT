using System;

namespace Client
{
    [Serializable]
    public class Data
    {
        public int index { get; set; }
        public string text { get; set; }
        public string token { get; set; }
        public string name { get; set; }
    }
}
