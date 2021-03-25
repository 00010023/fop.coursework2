using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
    public class Test
    {
        private string name;
        private string q1;
        private string q1_answer;
        private string q2;
        private string q2_answer;
        private string q3;
        private string q3_answer;

        public int ts_id_10023 { get; set; }
        public string ts_name_10023
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Test's name can't be empty!");

                name = value;
            }
        }
        public string ts_q1_10023
        {
            get => q1;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Question's text can't be empty!");

                q1 = value;
            }
        }
        public string ts_q1_answer_10023
        {
            get => q1_answer;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Question's text can't be empty!");

                q1_answer = value;
            }
        }
        public string ts_q2_10023
        {
            get => q2;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Question's text can't be empty!");

                q2 = value;
            }
        }
        public string ts_q2_answer_10023
        {
            get => q2_answer;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Question's text can't be empty!");

                q2_answer = value;
            }
        }
        public string ts_q3_10023
        {
            get => q3;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Question's text can't be empty!");

                q3 = value;
            }
        }
        public string ts_q3_answer_10023
        {
            get => q3_answer;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Question's text can't be empty!");

                q3_answer = value;
            }
        }

        public Test()
        {

        }

        public Test(
            string name,
            string question1,
            string question1_answer,
            string question2,
            string question2_answer,
            string question3,
            string question3_answer
            )
        {
            ts_name_10023 = name;
            ts_q1_10023 = question1;
            ts_q1_answer_10023 = question1_answer;
            ts_q2_10023 = question2;
            ts_q2_answer_10023 = question2_answer;
            ts_q3_10023 = question3;
            ts_q3_answer_10023 = question3_answer;
        }
    }
}
