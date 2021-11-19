using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMamangement
{
   class EventManager
    {
        // FIELDS
        private double costPerperson;
        private double feePerperson;
        private string tittle;



        ParticipantManager pttManager = new ParticipantManager();
        //CONSTRUCTOR
        public EventManager()
        {
            pttManager = new ParticipantManager();
        }
        #region PROPERTIES
        public ParticipantManager participants
        {
            get { return pttManager; }
        }
        public string Title
        {
            get { return tittle; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tittle = value;
            }
        }
        public double CostPerPerson
        {
            get { return costPerperson; }
            set
            {
                if (value >= 0.0)
                    costPerperson = value;
            }
        }
        public double FeePerperson
        {
            // 0 value for free entry
            get { return feePerperson; }
            set
            {
                if (value >= 0.0)
                    feePerperson = value;
            }
        }
        #endregion

        #region OTHER METHODS
        public double CalcTotalCost()
        {
            return participants.Count * costPerperson;
        }
        public double CalculateTotalFees()
        {
            return participants.Count * feePerperson;
        }
        #endregion

    }
}
