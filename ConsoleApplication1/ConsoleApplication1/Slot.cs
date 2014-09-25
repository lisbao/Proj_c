using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Slot
{
    public DateTime Allocated_Start { get; set; }
    public DateTime Allocated_Finish { get; set; }
    String Description { get; set; }

    public Slot(DateTime Start, DateTime Finish, String Description = null)
    {
        this.Allocated_Start = Start;
        this.Allocated_Finish = Finish;
        this.Description = Description;
    }

    public virtual void UpdateSlot(DateTime Start, DateTime Finish, String Description)
    {
        this.Allocated_Start = Start;
        this.Allocated_Finish = Finish;
        this.Description = Description;
    }

    public TimeSpan Duration()
    {
        return Allocated_Finish.Subtract(Allocated_Start);

    }


}
