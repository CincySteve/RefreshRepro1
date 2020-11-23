
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshRepro
{
    public class IBSpec
        {
        public Static_.IBType IBType { get; set; }
        public string Title { get; set; }
        public bool CheckState { get; set; }

        public IBSpec(Static_.IBType ibType, string title, bool checkState)
            {
            IBType = ibType;
            Title = title;

            CheckState = checkState;
            }
        }
    }
