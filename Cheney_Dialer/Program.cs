using System;
// John Cheney
// IT112
// NOTES: It was a little difficult to understanded, but after I looked at your notes and figured it out
// BEHAVIORS NOT IMPLIMENTED AND WHY: Only thing I could not figure out was how to implement the (XXX) XXX-XXXX format into dial
namespace Cheney_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Phone[] P = new Phone[10];
                P[0] = new Homephone("Computest", "(303) 985-5060", 1);
                P[1] = new Cellphone("Curtis Manufacturing", "(603) 532-4123", 2);
                P[2] = new Homephone("Data Functions", "(800) 876-2524", 1);
                P[3] = new Homephone("Donnay Repair", "(708) 397-3330", 1);
                P[4] = new Homephone("ErgoNomic Inc", "(360) 434-3894", 1);
                P[5] = new Homephone("ErgoSource", "(800) 969-4374", 1);
                P[6] = new Cellphone("Fox Bay Industries", "(800) 874-8527", 2);
                P[7] = new Cellphone("Glare-Guard", "(800) 545-6254", 2);
                P[8] = new Cellphone("Hazard Comm Specialists", "(407) 783-6641", 2);
                P[9] = new Cellphone("Komfort Support", "(714) 472-4409", 2);

                for (int i = 0; i < P.Length; i++)
                {
                    P[i].Dial();
                }
        }
    }
}
