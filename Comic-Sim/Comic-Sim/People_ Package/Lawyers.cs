using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Sim.People__Package
{
    class Lawyers: Person
    {
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
        private int creativity;

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

        public int Creativity
        {
            get
            {
                return creativity;
            }

            set
            {
                creativity = value;
            }
        }
    }
}
