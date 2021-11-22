using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMamangement
{
     class ParticipantManager
    {
        //FIELDS
        private List<Participant> participants; //List of particp

        // CONSTRUCTOR
        public ParticipantManager()
        {
            participants = new List<Participant>();
            TestValues();
        }
        #region METHODS TO HANDLE THE LIST
        public Participant GetParticipantAt(int index)
        {
            if (CheckIndex(index))
                return participants[index];
            return null;
               
           
            // returning a copy can be a better way comment eg
            //participant origobj  =  participants[index];
            //participant copyobj = new participant(origobj);
            // return copyobj;
        }

        public int Count
        {
            get { return participants.Count; }
        }


        public bool Addparticipant(string firstName, string lastName, Address addressIn)
        {
            Participant participant = new Participant(firstName, lastName, addressIn);
           
           
            participants.Add(participant);
            return true;
        }
        public bool AddPartcipant(Participant participantIn)
        {
            if (participantIn == null)
                return false;
            participants.Add(participantIn);
        
            return true;
        }


        public bool ChangeParticipantAt(Participant participantIn, int index)
        {
            bool ok = true;
            if ((participantIn != null) && (CheckIndex(index)))
                participants[index] = participantIn;
            else
                ok = false;
            return ok;
        }

        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < participants.Count);
        }

        public bool DeleteParticipantAt(int index)
        {
            if (CheckIndex(index))
                participants.RemoveAt(index);
            else
                return false;
            return true;
        }

        public string[] GetParticipantsInfo()
        {
            string[] participantsInfo = new string[participants.Count];

            int i = 0;
            foreach (Participant particpantobj in participants)
            {
                participantsInfo[i++] = particpantobj.ToString();

            }
            return participantsInfo;
        }

        #endregion

        public void TestValues()
        {
            AddPartcipant(new Participant("Apu", "Simpsson", new Address("londonavenue12", "malmo", "123", Countries.Brazil)));
        }





    }
}
