using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisaPlus
{
    class Visa
    {
        private string id;
        private string visitdate;
        private string status;
        private string region;
        private string title;
        private string firstname;
        private string lastname;
        private string dob;
        private string email;
        private string password;
        private string passport;
        private string passportexpire;
        private string clientticket;
        private string visatype;
        private string nationality;
        private string purpose;
        private string persons;
        private string kids;
        private string payed;
        private string travellength;
        private string nearestdate;
        private string userid;

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setvisitdate(string visitdate)
        {
            this.visitdate = visitdate;
        }
        public string getvisitdate()
        {
            return visitdate;
        }
        public void setstatus(string status)
        {
            this.status = status;
        }
        public string getstatus()
        {
            return status;
        }
        public string getregion()
        {
            return region;
        }
        public void setregion(string region)
        {
            this.region = region;
        }
        public string gettitle()
        {
            return title;
        }
        public void settitle(string title)
        {
            this.title = title;
        }
        public string getfirstname()
        {
            return firstname;
        }
        public void setfirstname(string firstname)
        {
            this.firstname = firstname;
        }
        public string getlastname()
        {
            return lastname;
        }
        public void setlastname(string lastname)
        {
            this.lastname = lastname;
        }
        public string getdob()
        {
            return dob;
        }
        public void setdob(string dob )
        {
            this.dob = dob;
        }
        public string getemail()
        {
            return email;
        }
        public void setemail(string email)
        {
            this.email = email;
        }
        public string getpassword()
        {
            return password;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public string getpassport()
        {
            return passport;
        }
        public void setpassport(string passport)
        {
            this.passport = passport;
        }
        public string getpassportexpire()
        {
            return passportexpire;
        }
        public void setpassportexpire(string passportexpire)
        {
            this.passportexpire = passportexpire;
        }
        public string getclientticket()
        {
            return clientticket;
        }
        public void setclientticket(string clientticket)
        {
            this.clientticket = clientticket;
        }
        public string getvisatype()
        {
            return visatype;
        }
        public void setvisatype(string visatype)
        {
            this.visatype = visatype;
        }
        public string getnationality()
        {
            return nationality;
        }
        public void setnationality(string nationality)
        {
            this.nationality = nationality;
        }
        public string getpurpose()
        {
            return purpose;
        }
        public void setpurpose(string purpose)
        {
            this.purpose = purpose;
        }
        public string getpersons()
        {
            return persons;
        }
        public void setpersons(string persons)
        {
            this.persons = persons;
        }
        public string getkids()
        {
            return kids;
        }
        public void setkids(string kids)
        {
            this.kids = kids;
        }
        public string getpayed()
        {
            return payed;
        }
        public void setpayed(string payed)
        {
            this.payed = payed;
        }
        public string gettravellength()
        {
            return travellength;
        }
        public void settravellength(string travellength)
        {
            this.travellength = travellength;
        }
        public string getnearestdate()
        {
            return nearestdate;
        }
        public void setnearestdate(string nearestdate)
        {
            this.nearestdate = nearestdate;
        }
        public string getuserid()
        {
            return userid;
        }
        public void setuserid(string userid)
        {
            this.userid = userid;
        }
    }
}
