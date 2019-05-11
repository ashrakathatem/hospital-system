using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Patient
    {
         private String Name;
        private String Disease;
        private String Id ;
        private String Date ;
        public Patient()
        {
        Name="";
        Disease = "";
        Id = "";
        Date = "";
        }
        public Patient(String Name, String Disease, String Id, String Date)
        {
            this.Name = Name;
            this.Disease = Disease;
            this.Id = Id;
            this.Date = Date;

        }
        public void setName(String Name)
        {
            this.Name = Name;
        }
        public void setDisease(String Disease)
        {
            this.Disease = Disease;
        }
        public void setID(String Id)
        {
            this.Id = Id;
        }
        public void setDate(String Date)
        {
            this.Date = Date;
        }
        public String getName()
        {
            return Name;
        }
        public String getDisease()
        {
            return Disease;
        }
        public String getId()
        {
            return Id;
        }
        public String getDate()
        {
            return Date;
        }
        
    }
}
