using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Doctor
    {

        private String name;
        private String speciality;
        private String ID;
        private String password;

        public Doctor()
        {
            name="";
            speciality="";
             ID="";


        }
        public Doctor(String name, String speciality, String ID)
        {
            this.name = name;
            this.speciality = speciality;
            this.ID = ID;
            

        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setSpeciality(String speciality)
        {
            this.speciality = speciality;
        }
        public void setID(String ID)
        {
            this.ID = ID;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public String getName()
        {
            return name;
        }
        public String getSpeciality()
        {
            return speciality;
        }
        public String getID()
        {
            return ID;
        }
        public String getPassword()
        {
            return password;
        }

    }
}
