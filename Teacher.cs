namespace Shool2
{

    class Teacher : User
    {
        public string predmetid;

        public Teacher(string predmetid)
        {
            this.predmetid = predmetid;
            this.label = "Teacher";
        }

    }
}
