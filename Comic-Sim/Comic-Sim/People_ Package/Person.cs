using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Sim.People__Package
{
    class Person : personInterface
    {
        //Each person must have a personID
        //for databse
        private int personID;

        //first part of the name
        private String firstName;

        //last part of the name
        private String lastName;

        //Their age
        private int age;

        //There gender
        private String gender;

        //Their position title
        private String title;

        //Their ethnicity
        private String ethnicity;

        //Their nationality
        private String nationality;

        //Affects how there person gets on with people
        private int attitude;

        //What the general population thinks of the person
        private int reputation;

        //How loyal they are to their current company
        private int loyalty;

        //Sets the company the person is hired to
      
            // The getter and sets for the attributes
        public int PersonID
        {
            get
            {
                return personID;
            }

            set
            {
                personID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Ethnicity
        {
            get
            {
                return ethnicity;
            }

            set
            {
                ethnicity = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public int Attitude
        {
            get
            {
                return attitude;
            }

            set
            {
                attitude = value;
            }
        }

        public int Reputation
        {
            get
            {
                return reputation;
            }

            set
            {
                reputation = value;
            }
        }

        public int Loyalty
        {
            get
            {
                return loyalty;
            }

            set
            {
                loyalty = value;
            }
        }


        //This is the actual methods for persons
        
        // All bools here are defaulted as false. A genric person with no 
        //job capababilties will default to excutives 
        public bool isAssistantEditor()
        {
            return false;
        }

        public bool isbackgroundArtist()
        {
            return false;
        }

        public bool isCharDesigner()
        {
            return false;
        }

        public bool isChiefCreativeOfficer()
        {
            return true;
        }

        public bool isChiefExecutiveOfficer()
        {
            return true;
        }

        public bool isChiefFinacialOfficer()
        {
            return true;
        }

        public bool isChiefOperatingOfficer()
        {
            return true;
        }

        public bool isDesigner()
        {
            return false;
        }

        public bool isEditor()
        {
            return false;
        }

        public bool isEditorInChief()
        {
            return false;
        }

        public bool isIllustrator()
        {
            return false;
        }

        public bool isJuniorEditor()
        {
            return false;
        }

        public bool isLawyer()
        {
            return false;
        }

        public bool iswebDesigners()
        {
            return false;
        }

        public bool iswebDeveloper()
        {
            return false;
        }

        public bool isWriter()
        {
            return false;
        }

        public bool willCoWrite()
        {
            return false;
        }

        //Theses are the action methods a generic person can take
        public void jobConsderation()
        {


        }

        public void jobResignation()
        {

        }

        public void makeFriend()
        {

        }

        public void makeEnemy()
        {

        }

        
    }
}
