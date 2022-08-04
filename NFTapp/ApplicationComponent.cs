using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFTapp
{
    public class ConsoleComponents
    {
        private string appAuthor = "Kyo Matias";
        public string AppAuthor
        {
            get
            {
                return appAuthor;
            }
            set
            {
                appAuthor = value ;
            }
        }

        private string applicationname = "EUROX NFT Marketplace";
        public string ApplicationName
        {
            get
            {
                return applicationname;
            }
            set
            {
                ApplicationName = value;
            }
        }

        private string applicationversion = "Version 1.0";
        public string ApplicationVersion
        {
            get
            {
                return applicationversion;
            }
            set
            {
                applicationversion = value;
            }
        }

        private string applicationtype = "C#";
        public string ApplicationType
        {
            get
            {
                return applicationtype;
            }
            set
            {
                applicationtype = value;
            }
        }

        private string applicationplatform = "Windows 10";
        public string ApplicationPlatform
        {
            get
            {
                return applicationplatform;
            }
            set
            {
                applicationplatform = value;
            }
        }

        private string authoremail = "KyoMatias.acad@gmail.com";
        public string AuthorEmail
        {
            get
            {
                return authoremail;
            }
            set
            {
                authoremail = value;
            }
        }

    }
}
