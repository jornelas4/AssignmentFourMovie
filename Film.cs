using System;


namespace AssignmentFourMovie
{
    
    public abstract class Film{
        public int ItemID { get; set;}
        public string Title { get; set;}
        

        public abstract void Read();
        public abstract void Write();
        public abstract int getLastID();
    }
}