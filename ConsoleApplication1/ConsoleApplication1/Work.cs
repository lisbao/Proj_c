using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Work : Slot
    {
        DateTime Done_Start { get; set; }
        DateTime Done_Finish { get; set; }

        public override void UpdateSlot(DateTime Start, DateTime Finish, string Desc)
        {
            base.UpdateSlot(Done_Start, Done_Finish, Desc = null);
        }

        public override TimeSpan Duration()
        {
            return Done_Finish.Subtract(Done_Start);
        }

    }
}


