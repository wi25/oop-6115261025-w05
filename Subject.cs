using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_w05
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private string subjectCredit;
        private string subjectLecture;
        private string subjectPractice;

        public string SubjectCode
        {
            get { return this.subjectCode; }
            set { this.subjectCode = value; }
        }
        public string SubjectName
        {
            get { return this.subjectName; }
            set { this.subjectName = value; }
        }
        public string SubjectCredit
        {
            get { return this.subjectCredit; }
            set { this.subjectCredit = value; }
        }
        public string SubjectLecture
        {
            get { return this.subjectLecture; }
            set { this.subjectLecture = value; }
        }
        public string SubjectPractice
        {
            get { return this.subjectPractice; }
            set { this.subjectPractice = value; }
        }

        public Subject() { }
        public Subject(string subco, string subn, string subcr, string subl, string subp)
        {
            this.SubjectCode = subco;
            this.SubjectName = subn;
            this.SubjectCredit = subcr;
            this.SubjectLecture = subl;
            this.SubjectPractice = subp;
        }

        public override string ToString()
        {
            return this.SubjectName + " ";
        }
    }
}
