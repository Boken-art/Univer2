namespace Shool2
{

    class Student : User
    {

        public string kurs;
        public int score;

        public Student(string kurs)
        {
            this.label = "Student";
            this.kurs = kurs;
            this.score = 0;

        }


    }
}
