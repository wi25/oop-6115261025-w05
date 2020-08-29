using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_w05
{
    class Group
    {
        private string groupCode;
        private string groupName;
        private string groupDegree;

        public string GroupCode
        {
            get { return this.groupCode; }
            set { this.groupCode = value; }
        }
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }
        public string GroupDegree
        {
            get { return this.groupDegree; }
            set { this.groupDegree = value; }
        }

        public Group() { }
        public Group(string gc, string gn, string gd)
        {
            this.GroupCode = gc;
            this.GroupName = gn;
            this.GroupDegree = gd;
        }
        public override string ToString()
        {
            return this.GroupName + " ";
        }
    }
}
