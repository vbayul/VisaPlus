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
        /*
visitdate,status,region,title,firstname,lastname,dob,email,password,"
                +"passport,passportexpire,clientticket,visatype,nationality,purpose,"
                +"persons,kids,payed,travellength,nearestdate,userid
         * */
        public Visa(){}

        private string getId()
        {
            return id;
        }
        private void setId(string id)
        {
            this.id =id;
        }
        private string getId()
        {
            return id;
        }
        private void setvisitdate(string visitdate)
        {
            this.visitdate = visitdate;
        }
        private string getvisitdate()
        {
            return visitdate;
        }
        private void setstatus(string status)
        {
            this.status = status;
        }

        private string getregion()
        {
            return region;
        }
        private void setregion(string region)
        {
            this.region = region;
        }
        private string gettitle()
        {
            return title;
        }
        private void settitle(string title)
        {
            this.title = title;
        }
        private string getfirstname()
        {
            return firstname;
        }
        private void setfirstname(string firstname)
        {
            this.firstname = firstname;
        }
        private string getlastname()
        {
            return lastname;
        }
        private void setlastname(string lastname)
        {
            this.lastname = lastname;
        }
        private string getdob()
        {
            return dob;
        }
        private void setdob(string dob )
        {
            this.dob = dob;
        }
        private string getemail()
        {
            return email;
        }
        private void setemail(string email)
        {
            this.email = email;
        }
        private string getpassword()
        {
            return password;
        }
        private void setpassword(string password)
        {
            this.password = password;
        }
        private string getpassport()
        {
            return passport;
        }
        private void setpassport(string passport)
        {
            this.passport = passport;
        }
        private string getpassportexpire()
        {
            return passportexpire;
        }
        private void setpassportexpire(string passportexpire)
        {
            this.passportexpire = passportexpire;
        }
        private string getclientticket()
        {
            return clientticket;
        }
        private void setclientticket(string clientticket)
        {
            this.clientticket = clientticket;
        }
        private string getvisatype()
        {
            return visatype;
        }
        private void setvisatype(string visatype)
        {
            this.visatype = visatype;
        }
        private string getnationality()
        {
            return nationality;
        }
        private void setnationality(string nationality)
        {
            this.nationality = nationality;
        }
        private string getpurpose()
        {
            return purpose;
        }
        private void setpurpose(string purpose)
        {
            this.purpose = purpose;
        }
        private string getpersons()
        {
            return persons;
        }
        private void setpersons(string persons)
        {
            this.persons = persons;
        }
        private string getkids()
        {
            return kids;
        }
        private void setkids(string kids)
        {
            this.kids = kids;
        }
        private string getpayed()
        {
            return payed;
        }
        private void setpayed(string payed)
        {
            this.payed = payed;
        }
        private string get()
        {
            return travellength;
        }
        private void settravellength(string travellength)
        {
            this.travellength = travellength;
        }
        private string getnearestdate()
        {
            return nearestdate;
        }
        private void setnearestdate(string nearestdate)
        {
            this.nearestdate = nearestdate;
        }
        private string getuserid()
        {
            return userid;
        }
        private void setuserid(string userid)
        {
            this.userid = userid;
        }
    }
}
