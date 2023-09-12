using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingandGithub
{
     public class TestMe
    {
        private String strName;
        private String strDescription;
        private String strVersion;
        private String strAuthor;

        public TestMe(string strName, string strDescription, string strVersion, string strAuthor)
        {
            this.strName = strName;
            this.strDescription = strDescription;
            this.strVersion = strVersion;
            this.strAuthor = strAuthor;
        }

        public String ToString()
        {
            return "My Name is " + strName + " and " + strDescription;
        }



    }
}
