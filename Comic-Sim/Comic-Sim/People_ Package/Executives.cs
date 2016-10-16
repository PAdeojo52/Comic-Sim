
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Sim.People__Package
{
    class Executives: Person
    {

        /*Throwin some more specfic excecutive attributes
         * 
         * Adaptability
         * Strategic thinking
         * Integrity
         * Very good communicator
         * trustworthy 
         * Vision
         * 
         */
        //Adapts  to changes in comic trends
        private int adaptability;
        //Allows for better marketing Ideas
        private int strategicThinking;
        //Would your CEO screw over your company?
        private int integrity;

       // private int trustworthy;
       //Would your exe allow for distribution of generes outside the higher bought/ company modusOP
        private int vision;

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

        public int Strategic_thinking
        {
            get
            {
                return strategic_thinking;
            }

            set
            {
                strategic_thinking = value;
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

        public int Trustworthy
        {
            get
            {
                return trustworthy;
            }

            set
            {
                trustworthy = value;
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
    }
}
