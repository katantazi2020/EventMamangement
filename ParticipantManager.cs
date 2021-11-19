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
        private List<Participant> participants;

        // CONSTRUCTOR
        public ParticipantManager()
        {
            participants = new List<Participant>();
            //TestValue();
        }
        #region METHODS TO HANDLE THE LIST
        public Participant GetParticipantAt(int index)
        {
            if (index < 0 || index >= participants.Count)
                return null;
            return participants[index];
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
            Participant participant = new Participant();
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

        //public void TestValues()
        // {
        //participants.Clear();
        //AddParticipant(new Partcipant("Apu","simpson", new Address("ththtosos")))
        // }





    }
}
