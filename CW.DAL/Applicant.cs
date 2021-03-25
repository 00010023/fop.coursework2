using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
    public class Applicant
    {
        private string name;
        private int score;

        public int ap_id_10023 { get; set; }
        public string ap_name_10023
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Applicant's name is empty!"); 
                    
                name = value;
            }
        }
        public int ap_score_10023
        {
            get => score;
            set
            {
                if (value < 0)
                    throw new Exception("Applicant's score can't be negative!");

                score = value;
            }
        }
        public string ap_tests_taken_10023 { get; set; }

        public Applicant()
        {

        }

        public Applicant(string name, int score, string test)
        {
            ap_name_10023 = name;
            ap_score_10023 = score;
            ap_tests_taken_10023 = test;
        }
    }
}
