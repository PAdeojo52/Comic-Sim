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
        private String firstName{get;set;}

        //last part of the name
        private String lastName{get;set;}

        //Their age
        private int age{get;set;}

        //There gender
        private String gender{get;set;}

        //Their position title
        private String title{get;set;}

        //Their ethnicity
        private String ethnicity{get;set;}

        //Their nationality
        private String nationality{get;set;}

        //Affects how there person gets on with people
        private int attitude{get;set;}

        //What the general population thinks of the person
        private int reputation{get;set;}

        //How loyal they are to their current company
        //hjhjhj
        private int loyalty{get;set;}

        //Sets the company the person is hired to
      
            // The getter and sets for the attributes
       

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
