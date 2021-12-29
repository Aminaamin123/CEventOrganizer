using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Organizer
{
    class ParticipantManager
    {

        private List<Participant> participants;


        public ParticipantManager()
        {
            participants = new List<Participant>();
        }

        public Participant GetParticipantAt(int index)
        {
            if (CheckIndex(index))
                return participants[index];
            return null;
        }

        public int Count
        {
            get { return participants.Count; }
        }

        public bool AddParticipant(string firstName, string lastName, Address adressIn)
        {
            Participant Participant = new Participant(firstName, lastName, adressIn);
            participants.Add(Participant);
            return true;
        }

        public bool AddParticipant(Participant ParticipantIn)
        {
            if (ParticipantIn == null)
                return false;
            participants.Add(ParticipantIn);
            return true;
        }

        public bool ChangeParticipantAt(Participant ParticipantIn, int index)
        {
            bool ok = true;
            if ((ParticipantIn != null) && (CheckIndex(index)))
                participants[index] = ParticipantIn;
            else
                ok = false;
            return ok;
        }


        private bool CheckIndex(int index)
        {
            return (index >= 0 || index < participants.Count);
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
            string[] strInfoStrings = new string[participants.Count];
            int i = 0;

            foreach(Participant ParticipantObj in participants)
            {
                strInfoStrings[i++] = ParticipantObj.ToString();
            }
            return strInfoStrings;
        }

        public void TestValues()
        {
            AddParticipant(new Participant("Amina", "Amin", new Address("augustenborgsgatan 3", "21444", "Malmo", Countries.Sverige)));
            AddParticipant(new Participant("Meryem", "Amin", new Address("augustenborgsgatan 3", "21444", "Malmo", Countries.Sverige)));
        }


    }
}
