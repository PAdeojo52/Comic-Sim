using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Sim.People__Package
{
    class Writers: Person
    {
        Random rnd;
        int writerSetter;

        public Writers()
        {
            Random rnd = new Random();
            Random artistRandom = new Random();
            Random editorRandom = new Random();
            Random lawyerRandom = new Random();
            Random canDevRandom = new Random();
            Random executiveRandom = new Random();


            int ageSetter = rnd.Next(20, 30);
            int genderSetters = rnd.Next(0, 1);
            int ethnicitysetter = rnd.Next(0,ethnicityArray.Length);
            int nationality = rnd.Next(0, nationalityArray.Length);
            int attitudeSetter = rnd.Next(0, 100);
            int reputationSetter = rnd.Next(0, 100);
            int loyaltySetter = rnd.Next(0,100);

            //Checks to see what the they can do.
            CanBeWriter = true;

            //Check proability to see if the instance gets other attributes

            if(artistRandom.Next(100)>50)
            {
                CanBeArtist = true;
            }

            if(editorRandom.Next(100)>50)
            {
                CanBeEditor = true;
            }
            if(lawyerRandom.Next(100)>50)
            {
                CanBeLawyer = true;
            }
            if(canDevRandom.Next(100)>50)
            {
                CanWebDev = true;
            }
            if(executiveRandom.Next(100)>50)
            {
                CanBeExecutive = true;
            }



            // //Randoms foe class specfic stats: Writer
            int substanceSetter = rnd.Next(0, 100);
            int focusSetter = rnd.Next(0, 100);
            int logicSetter = rnd.Next(0, 100);
            int entertainmentSetter = rnd.Next(0, 100);
            int cwSetter = rnd.Next(0, 100);
            int humorSetter = rnd.Next(0, 100);
            int matureSetter = rnd.Next(0, 100);


            // //Randoms foe class specfic stats: Artist
            
            int designRand = rnd.Next(0, 100);
            int drawingCreativityRand = rnd.Next(0, 100);
            int drawingVisionRand = rnd.Next(0, 100);
            int humilityRand = rnd.Next(0, 100);



            // //Randoms foe class specfic stats: Editor

            // //Randoms foe class specfic stats: Lawyer

            int lawCommSkillsRand = rnd.Next(0, 100);
            int judgementRand = rnd.Next(0, 100);
            int analyticSkillRand = rnd.Next(0, 100);
            int lawResearchRand = rnd.Next(0, 100);
            int legalCreativityRand = rnd.Next(0, 100);

            // //Randoms foe class specfic stats: webDev

            // //Randoms foe class specfic stats: excutive

            int adapRand = rnd.Next(0, 100);
            int stratThinkingRand = rnd.Next(0, 100);
            int integrityRand = rnd.Next(0, 100);
            int communicaterRand = rnd.Next(0, 100);
            int visionRand = rnd.Next(0, 100);






            //Normal General Values
            //create random valu
            PersonID = writerSetter;
            //Select enum from a list
            FirstName = "John";
            //Select enum from list
            LastName = "Doe";
            //Random number
            Age = ageSetter;
            //sets Gender
            Gender = genderArray[genderSetters];
            //Ethnicity
            Ethnicity = ethnicityArray[ethnicitysetter];
            //nationality
            Nationality = ethnicityArray[ethnicitysetter];
            //Attitude
            Attitude = attitudeSetter;
            //Reputation
            Reputation = reputationSetter;
            //Sets Loyalty
            Loyalty = loyaltySetter;



            //Setting Writing Stats
           
            
                Substance = substanceSetter;
                Focus = focusSetter;
                Logic = logicSetter;
                Entertainment = entertainmentSetter;
                CreativiteWriting = cwSetter;
                Humor = humorSetter;
                Mature = matureSetter;
           
    
            

            //Setting Artist stats

            if (CanBeArtist == true)
            {
                Design = designRand;
                DrawingCreativity = drawingCreativityRand;
                DrawingVision = drawingVisionRand;
                DrawingHumility = humilityRand;
            }
            else
            {
                Design = 0;
                DrawingCreativity = 0;
                DrawingVision = 0;
                DrawingHumility = 0;

            }


            //Executise setting

            if (CanBeExecutive == true)
            {
                Adaptability = adapRand;
                StrategicThinking = stratThinkingRand;
                Integrity = integrityRand;
                Communicator = communicaterRand;
                Vision = visionRand;
            }
            else
            {
                Adaptability = 0;
                StrategicThinking = 0;
                Integrity = 0;
                Communicator = 0;
                Vision = 0;
            }



            //lawyer stuff
            if(CanBeLawyer == true)
            {
                CommunicationSkills = communicaterRand;
                Judgement = judgementRand;
                AnalyticalSkills = analyticSkillRand;
                ResearchSkills = lawResearchRand;
                LegalCreativity = legalCreativityRand;
            }
            else
            {
                CommunicationSkills = 0;
                Judgement = 0;
                AnalyticalSkills = 0;
                ResearchSkills = 0;
                LegalCreativity = 0;
            }




        }


    }
}
