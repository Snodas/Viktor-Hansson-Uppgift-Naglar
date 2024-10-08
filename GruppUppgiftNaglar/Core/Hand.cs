using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiftNaglar.Core
{
    //abstract class Hand
    //{
    //    public bool IsLeft {  get; set; }

    //}


    public enum Position
    { 
        Left,   
        Right,  
    }



    public class Hand
    {
        public List<Nail> Nails { get; set; } = new List<Nail>();
        public Position Position { get; set; }
    }


    public class Foot
    {
        List<Nail> Nails { get; set; } = new List<Nail>();
    }

    //public class Nail
    //{

    //}
}







