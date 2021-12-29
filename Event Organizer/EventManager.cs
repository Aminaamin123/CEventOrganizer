using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Organizer
{
    class EventManager
    {

        private double costPerPerson;
        private double feePerPerson;
        private string title;

        ParticipantManager participantManager = new ParticipantManager();

        public EventManager()
        {
            participantManager = new ParticipantManager();
        }

        #region PROPERTIES

        public ParticipantManager Participants
        {
            get { return participantManager;  }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
            }
        }


        public double CostPerPerson
        {
            get { return costPerPerson;  }
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        #endregion


        #region METHODS

        public double CalcTotalCost()
        {
            return Participants.Count * costPerPerson;
        }

        public double CalcTotalFee()
        {
            return Participants.Count * feePerPerson;
        }

        #endregion


    }
}
