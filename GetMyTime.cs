using System;

namespace MyFileUtilities
{
    public class GetMyTime
    {
        public string ReturnTime()
        {
            String tod = DateTime.Now.ToString("h:mm:ss tt");
            return tod;
        }
    }
}