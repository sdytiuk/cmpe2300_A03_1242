using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonDemo
{
    internal class PeopleCompare :IComparer<People>
    {
        //sort via different people properties
        public enum ESortType { HeightA, HeightD, WaistA, WaistD};
        public ESortType SortType { get; set; }

        public PeopleCompare()
        {
            //set the default sorttype!!
            SortType = ESortType.HeightA;
        }

        public int Compare(People a, People b)
        {
            switch (SortType)
            {
                case ESortType.HeightA:
                    return a.Height.CompareTo(b.Height);
                case ESortType.HeightD:
                    return b.Height.CompareTo(a.Height);
                case ESortType.WaistA:
                    return a.Waist.CompareTo(b.Waist);
                case ESortType.WaistD:
                    return -a.Waist.CompareTo(b.Waist);
                default:
                    break;
            }
            return 0; //unknown sort...!
        }
    }
}
