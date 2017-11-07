using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01Problema02
{
    public class CompleteRange
    {
        public List<int> build(List<int> prmInput)
        {
            List<int> Result = new List<int>();
            int First = 0;
            int Last = 0;

            prmInput.Sort();

            First = prmInput.First();

            Last = prmInput.Last();

            for (int i = First; i <= Last; i++)
            {
                Result.Add(i);
            }

            return Result;
        }
    }
}
