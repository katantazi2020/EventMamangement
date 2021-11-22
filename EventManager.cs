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
        private double costperperson;
        private double feePerperson;
        private string title;



        ParticipantManager pManager = new ParticipantManager();
        //CONSTRUCTOR
        public EventManager()
        {
            pManager = new ParticipantManager();
        }
        #region PROPERTIES
        public ParticipantManager participants
        {
            get { return pManager; }
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
            get { return costperperson; }
            set
            {
                if (value >= 0.0)
                    costperperson = value;
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
            return participants.Count * costperperson;
        }
        public double CalculateTotalFees()
        {
            return participants.Count * feePerperson;
        }
        #endregion
  
    }
}
