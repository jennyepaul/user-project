using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class user
    {
        private uint id;
        private string firstName;
        private string lastName;
        private string birthDate;
        private string maleOrFemale;
    
        public user()
        {
            id = 0;
            firstName = "";
            lastName = "";
            birthDate = "";
            maleOrFemale = "";
        }

        public user(uint id,  string firstName, string lastName, string birthDate, string maleOrFemale)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.maleOrFemale = maleOrFemale;
        }

        public uint ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public string MaleOrFemale
        {
            get { return maleOrFemale; }
            set { maleOrFemale = value; }
        }

    }
}
