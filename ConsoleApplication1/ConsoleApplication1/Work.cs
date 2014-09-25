using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text;


public class Work : Slot
{
    DateTime Done_Start { get; set; }
    DateTime Done_Finish { get; set; }

    public override void UpdateSlot(DateTime Start, DateTime Finish, string type, string Desc)
    {
        base.UpdateSlot(Done_Start, Done_Finish, type = null, Desc = null);
    }

}


