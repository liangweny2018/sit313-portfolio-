using System;
namespace Xamarin
{
    

    public class SessionData

    {
        string session_Id;
        public string session_Title;
        public string session_Description;
        public string session_Speaker;
        public DateTime session_Date;
        public bool isTechnical;

        public SessionData()
        {
        }

        public SessionData(string session_Id,string session_Title,string session_Description,string session_Speaker,DateTime session_Date,bool isTechnical)
        {
            this.session_Id = session_Id;
            this.session_Title = session_Title;
            this.session_Description = session_Description;
            this.session_Speaker = session_Speaker;
            this.session_Date = session_Date;
            this.isTechnical = isTechnical;
        }
    }
}
