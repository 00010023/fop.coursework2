using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
    public class ApplicantList
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();
        }

        public List<Applicant> Sort(ByAttribute attribute)
        {
            var result = GetAllApplicants();

            switch (attribute)
            {
                case ByAttribute.ap_name_10023:
                    result.Sort(new ByNameComparer());
                    return result;
                case ByAttribute.ap_score_10023:
                    result.Sort(new ByScoreComparer());
                    return result;
                case ByAttribute.ap_tests_taken_10023:
                    result.Sort(new ByTestComparer());
                    return result;
            }

            return null;
        }

        public List<Applicant> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.ap_name_10023:
                    return GetAllApplicants()
                        .OrderBy(a => a.ap_name_10023)
                        .ToList();
                case ByAttribute.ap_score_10023:
                    return GetAllApplicants()
                        .OrderBy(a => a.ap_score_10023)
                        .ToList();
                case ByAttribute.ap_tests_taken_10023:
                    return GetAllApplicants()
                        .OrderBy(a => a.ap_tests_taken_10023)
                        .ToList();
            }

            return null;
        }

        public List<Applicant> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.ap_name_10023:
                    return GetAllApplicants().Where(a => a.ap_name_10023.Contains(value)).ToList();
                case ByAttribute.ap_tests_taken_10023:
                    return GetAllApplicants().Where(a => a.ap_tests_taken_10023.Contains(value)).ToList();
            }

            return null;
        }


        private class ByNameComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.ap_name_10023, y.ap_name_10023);
            }
        }

        private class ByScoreComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.ap_score_10023.ToString(), y.ap_score_10023.ToString());
            }
        }

        private class ByTestComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.ap_tests_taken_10023, y.ap_tests_taken_10023);
            }
        }
    }
}
