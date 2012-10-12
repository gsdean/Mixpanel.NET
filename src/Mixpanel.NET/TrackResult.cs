using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mixpanel.NET
{
    public class TrackResult
    {
        private Exception ex;

        public TrackResult(string response)
        {
            this.Response = response;
        }

        public TrackResult(Exception ex)
        {
            this.Response = ex.Message;
        }
        public string Response { get; private set; }
        public bool Success
        {
            get { return this.Response == "1"; }
        }
    }
}
