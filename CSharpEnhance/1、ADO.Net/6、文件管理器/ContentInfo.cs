using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_文件管理器
{
    class ContentInfo
    {
        private int Id
        {
            get;set;
        }

        public int Cid
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        public string Content
        {
            get;set;
        }

        public DateTime CreateTime
        {
            get;set;
        }

        public DateTime EditTime
        {
            get;set;
        }

        public bool Delete
        {
            get;set;
        }
    }
}
