using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Sim.People__Package
{
   public class Person 
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

        //Allows for the setting of gender for characters
        public string[] genderArray = { "male", "felmale" };

        //Sets ethnicity
        public string[] ethnicityArray = { "White", "Black", "Native", "Asian", "Middle Eastern", "Islander" };

        //Sets Nationality
        //American
        public string[] nationalityArray = {"Canadian", "Mexican","American",
        "Argentinian","Bolivian","Brazilian","Chilean","Colombian","Ecuadorian","Paraguayan","	Peruvian","Venezuelan",
        "Cuban", "Jamaican",
        "British", "Irish", "Scottish", "Welsh",
         "Austrian", "French", "German" , "Dutch"};
        

        //

        //sets what the person can do
        private bool canBeArtist = false;
        private bool canBeEditor = false;
        private bool canBeLawyer = false;
        private bool canWebDev = false;
        private bool canBeWriter = false;
        private bool canBeExecutive = false;
        //Sets the company the person is hired to



        /// <summary>
        /// Executive  Variables.
        /// </summary>
        // The getter and sets for the attributes
        //How well a product can adapt to a changing market
        //Adapts  to changes in comic trends
        private int adaptability;
        //Allows for better marketing Ideas
        private int strategicThinking;
        //Would your CEO screw over your company?
        private int integrity;
        // private int trustworthy; Merging with integrity
        // Buffs the worrkers overall happiness
        private int communicator;
       //Would your exe allow for distribution of generes outside the higher bought/ company modusOP
        private int vision;



        //Lawyers Variables
        //This will deter any in house lawsuits
        private int communicationSkills;
        //This helps place the odds in your favor if sued
        private int judgement;
        //Will be able to better analyze cases for better results
        private int analyticalSkills;
        //Allows better research for precedent set in cases
        private int researchSkills;
        // private int peopleSkills;
        //Allows the lawyer to find legal loopholes
        private int legalCreativity;


        //Writer Attributes
        //How much content is provided in the story
        private int substance;
        //The Ability centralize the story on a character
        //This could be good in single hero comics
        //Badd in combinations
        private int focus;
        //The ability place reason in story.
        //Explains why the villian is bad, why the hero is good
        //Explains plot, basically explains things
        private int logic;
        //The ability to write a story that is entertaining
        private int entertainment;
        //The ability to write a unique story
        //Think G.Morrsion with Infinite Crisis
        private int creativiteWriting;
        //Allows the story to be humorous
        private int humor;
        //The ability to write more mature stories
        private int mature;


        //illustrator Attributes

        //The ability to design characters,settings,villians, etc
        private int design;
        //The ability to take creative leaps with the characters
        private int drawingCreativity;
        //Allows the artist to have a stronger view of how the comic should turn out.
        private int drawingVision;
        //Allows for better collabs
        private int drawingHumility;









        /// <summary>
        /// Regular Attributes
        /// </summary>
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


        ///<summary>Roles Getters and Setters</summary>
        ///
        /// 
        /// 
        ///

        public bool CanBeArtist
        {
            get
            {
                return canBeArtist;
            }

            set
            {
                canBeArtist = value;
            }
        }

        public bool CanBeEditor
        {
            get
            {
                return canBeEditor;
            }

            set
            {
                canBeEditor = value;
            }
        }

        public bool CanBeLawyer
        {
            get
            {
                return canBeLawyer;
            }

            set
            {
                canBeLawyer = value;
            }
        }

        public bool CanWebDev
        {
            get
            {
                return canWebDev;
            }

            set
            {
                canWebDev = value;
            }
        }

        public bool CanBeWriter
        {
            get
            {
                return canBeWriter;
            }

            set
            {
                canBeWriter = value;
            }
        }

        public bool CanBeExecutive
        {
            get
            {
                return canBeExecutive;
            }

            set
            {
                canBeExecutive = value;
            }
        }



        /// <summary>
        /// Executive Getters & Setters
        /// </summary>
        /// <returns></returns>
        /// 
        public int Adaptability
        {
            get
            {
                return adaptability;
            }

            set
            {
                adaptability = value;
            }
        }

        public int StrategicThinking
        {
            get
            {
                return strategicThinking;
            }

            set
            {
                strategicThinking = value;
            }
        }

        public int Integrity
        {
            get
            {
                return integrity;
            }

            set
            {
                integrity = value;
            }
        }

        public int Communicator
        {
            get
            {
                return communicator;
            }

            set
            {
                communicator = value;
            }
        }

        public int Vision
        {
            get
            {
                return vision;
            }

            set
            {
                vision = value;
            }
        }



        /// <summary>
        /// Editor Getters and Setters
        /// </summary>
        /// <returns></returns>


        public int CommunicationSkills
        {
            get
            {
                return communicationSkills;
            }

            set
            {
                communicationSkills = value;
            }
        }

        public int Judgement
        {
            get
            {
                return judgement;
            }

            set
            {
                judgement = value;
            }
        }

        public int AnalyticalSkills
        {
            get
            {
                return analyticalSkills;
            }

            set
            {
                analyticalSkills = value;
            }
        }

        public int ResearchSkills
        {
            get
            {
                return researchSkills;
            }

            set
            {
                researchSkills = value;
            }
        }

        public int LegalCreativity
        {
            get
            {
                return legalCreativity;
            }

            set
            {
                legalCreativity = value;
            }
        }

        public int Substance
        {
            get
            {
                return substance;
            }

            set
            {
                substance = value;
            }
        }

        public int Focus
        {
            get
            {
                return focus;
            }

            set
            {
                focus = value;
            }
        }

        public int Logic
        {
            get
            {
                return logic;
            }

            set
            {
                logic = value;
            }
        }

        public int Entertainment
        {
            get
            {
                return entertainment;
            }

            set
            {
                entertainment = value;
            }
        }

        public int CreativiteWriting
        {
            get
            {
                return creativiteWriting;
            }

            set
            {
                creativiteWriting = value;
            }
        }

        public int Humor
        {
            get
            {
                return humor;
            }

            set
            {
                humor = value;
            }
        }

        public int Mature
        {
            get
            {
                return mature;
            }

            set
            {
                mature = value;
            }
        }

        public int Design
        {
            get
            {
                return design;
            }

            set
            {
                design = value;
            }
        }

        public int DrawingCreativity
        {
            get
            {
                return drawingCreativity;
            }

            set
            {
                drawingCreativity = value;
            }
        }

        public int DrawingVision
        {
            get
            {
                return drawingVision;
            }

            set
            {
                drawingVision = value;
            }
        }

        public int DrawingHumility
        {
            get
            {
                return drawingHumility;
            }

            set
            {
                drawingHumility = value;
            }
        }







        //This is the actual methods for persons

        // All bools here are defaulted as false. A genric person with no 
        //job capababilties will default to excutives

        //Bassic People needed
        //Web Devlopers
        // Boolean iswebDeveloper();
        //Boolean iswebDesigners();
        //Writers
        // Boolean isWriter();
        //Boolean willCoWrite();
        //Illustrators
        //  Boolean isCharDesigner();
        // Boolean isDesigner();
        // Boolean isbackgroundArtist();
        //Boolean isIllustrator();
        //Editors
        //  Boolean isJuniorEditor();
        //   Boolean isAssistantEditor();
        // Boolean isEditor();
        // Boolean isEditorInChief();
        //Lawyer
        //  Boolean isLawyer();
        //Executives
        /* Boolean isChiefOperatingOfficer();
         Boolean isChiefCreativeOfficer();
         Boolean isChiefFinacialOfficer();
         Boolean isChiefExecutiveOfficer();
         */








        //Executive

        //  public Boolean canBeExecutive()
        //  {
        //     return false;
        //  }
        /*
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
        */


        //Artist
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 


        /*
         * 
         *
        public bool isIllustrator()
        {
            return false;
        }
        public bool isDesigner()
        {
            return false;
        }
        public bool isCharDesigner()
        {
            return false;
        }

        public bool isbackgroundArtist()
        {
            return false;
        }
        */



        //Editors


        /*
        public bool isJuniorEditor()
        {
            return false;
        }
        public bool isAssistantEditor()
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
        */








        //Lawyers


        /*
         
        public bool isLawyer()
        {
            return false;
        }
        */

        //WebDevs


        /*
        public bool iswebDesigners()
        {
            return false;
        }

        public bool iswebDeveloper()
        {
            return false;
        }
        */



        //Writers


        /*
        public bool isWriter()
        {
            return false;
        }

        public bool willCoWrite()
        {
            return false;
        }
        */









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
