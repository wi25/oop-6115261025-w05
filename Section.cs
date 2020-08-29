using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_w05
{
    class Section
    {
        private string sectionCode;
        private string sectionDay;
        private string sectionStrat;
        private string sectionLast;
        private Room sectionRoom;
        private Subject sectionSub;
        private Lecturer sectionLec;

        public string SectionCode
        {
            get { return this.sectionCode; }
            set { this.sectionCode = value; }
        }
        public string SectionDay
        {
            get { return this.sectionDay; }
            set { this.sectionDay = value; }
        }
        public string SectionStrat
        {
            get { return this.sectionStrat; }
            set { this.sectionStrat = value; }
        }
        public string SectionLast
        {
            get { return this.sectionLast; }
            set { this.sectionLast = value; }
        }
        public void a()
        {
            sectionRoom.RoomName.ToString();
        }
        public void b()
        {
            sectionRoom.RoomBuilding.BuildingName.ToString();
        }
        public void c()
        {
            sectionSub.SubjectName.ToString();
        }
        public void d()
        {
            sectionLec.LecturerName.ToString();
        }

        public Section() { }
        public Section(string secc, string secd, string secs, string secl, Room secr, Subject secsu, Lecturer secle)
        {
            this.SectionCode = secc;
            this.SectionDay = secd;
            this.SectionStrat = secs;
            this.SectionLast = secl;
            this.sectionRoom = secr;
            this.sectionSub = secsu;
            this.sectionLec = secle;
        }

        public override string ToString()
        {
            return this.sectionRoom + " " + "Subject " +
                this.sectionSub + " " + "Lecturer " +
                this.sectionLec + " " +
                this.sectionDay + " " + "time " +
                this.sectionStrat + " " +
                this.sectionLast + " ";
        }
    }
}
