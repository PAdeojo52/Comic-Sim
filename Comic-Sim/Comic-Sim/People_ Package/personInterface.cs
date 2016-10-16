using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Sim.People__Package
{
    interface personInterface
    {

        //Bassic People needed
        //Web Devlopers
        Boolean iswebDeveloper();
        Boolean iswebDesigners();
        //Writers
        Boolean isWriter();
        Boolean willCoWrite();
        //Illustrators
        Boolean isCharDesigner();
        Boolean isDesigner();
        Boolean isbackgroundArtist();
        Boolean isIllustrator();
        //Editors
        Boolean isJuniorEditor();
        Boolean isAssistantEditor();
        Boolean isEditor();
        Boolean isEditorInChief();
        //Lawyer
        Boolean isLawyer();
        //Executives
        Boolean isChiefOperatingOfficer();
        Boolean isChiefCreativeOfficer();
        Boolean isChiefFinacialOfficer();
        Boolean isChiefExecutiveOfficer();


        /*
         * 
         * Future interfaces may include...
         * 
         * Film
         * Game
         * Television
         * 
         * 
         */



    }
}
